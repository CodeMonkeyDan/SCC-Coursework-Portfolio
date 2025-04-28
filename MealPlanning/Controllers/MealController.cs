//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using DSchiefer_CPT206_MealPlanning.Models;
using DSchiefer_CPT206_MealPlanning.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Reflection;


namespace DSchiefer_CPT206_MealPlanning.Controllers;

public class MealController : Controller
{
    // holds app setting values like api keys
    private readonly IConfiguration _configuration;

    // handles communication with openai
    private readonly OpenAiService _openAiService;

    // logger for tacking app events
    private readonly ILogger<MealController> _logger;

    // finds valid recipe urls using meal names
    private readonly RecipeFinderService _recipeFinderService;


    // constructor to inject needed services
    public MealController(IConfiguration configuration, OpenAiService openAiService, ILogger<MealController> logger)
    {
        _configuration = configuration;
        _openAiService = openAiService;
        _logger = logger;
        // initialize recipe finder service
        _recipeFinderService = new RecipeFinderService();
    }


    // display meal planner form (home page)
    [HttpPost]
    public IActionResult Index(MealInput input)
    {
        return View("~/Views/Home/Index.cshtml", input);
    }


    // handles form submission and gernerates meal plan
    [HttpPost]
    public async Task<IActionResult> Generate(MealInput input)
    {
        // get api key from appsettings.json
        string apiKey = _configuration.GetValue<string>("OpenAI:ApiKey") ?? throw new InvalidOperationException("API key is missing.");

        // build prompt for openai with all user preferences and rules
        string userPrompt = $@"
                You are to create a 7-day meal plan for elderly clients that is simple, affordable, healthy, and above all else fully follows the dietary preferences provided.
                You must return **exactly 21 meals**: 7 breakfasts, 7 lunches, and 7 dinners — NO MORE, NO LESS.

                STRICT REQUIREMENTS — DO NOT IGNORE:
                - You must include the user’s Request somewhere in the plan: {input.Request}
                - Strongly prefer foods the user Likes or similar substitutions: {input.Likes}
                - NEVER include anything listed in Dislikes: {input.Dislikes}
                - NEVER include anything listed in Allergies: {input.Allergies}
                ⚠️ If **even one meal** contains an item from Dislikes or Allergies, the entire plan is INVALID. Do not return invalid results.

                TIME-OF-DAY RULES — NO EXCEPTIONS:
                - Each meal must be appropriate for its time of day.
                - Breakfasts must only include foods traditionally eaten for breakfast.
                - Lunches must only include typical lunch items.
                - Dinners must only include traditional dinner meals.
                - You may NOT place dinner-style meals in the breakfast slot or vice versa. 
                - If unsure about a meal's classification, DO NOT include it.

                General expectations:
                - Breakfasts should be light, simple, and quick to prepare.
                - Lunches should be hearty but easy to digest.
                - Dinners should be more substantial and nutritionally complete, with protein, vegetables, and grains.

                OUTPUT FORMAT:
                Each line must contain a single meal name followed by 'BREAK'.
                No labels, categories, explanations, blank lines, or commentary of any kind.

                Example format (do NOT include these exact meals):
                Meal Name 'BREAK'
                Meal Name 'BREAK'
                Meal Name 'BREAK'
                ... (continue until you have exactly 21 lines)

                Order must strictly follow:
                - Day 1: Breakfast, Lunch, Dinner
                - Day 2: Breakfast, Lunch, Dinner
                - ...
                - Day 7: Breakfast, Lunch, Dinner

                FINAL REMINDER:
                If the format is incorrect OR if any meals are inappropriate, repeated, or violate preferences/allergies, the request is INVALID.
                Check your work carefully. Do not generate incomplete or improperly formatted results.";

        // initialize empty string to hold meal plan response from openai
        string mealPlanResponse = string.Empty;

        // flag to keep track of whether response is valid
        bool isValidResponse = false;

        // initialize mealplan object outside loop to be used later
        WeeklyMealPlan mealPlan = new WeeklyMealPlan();

        // maximum attempts to generate valid meal plan
        int maxAttempts = _configuration.GetValue<int>("MealPlannerSettings:MaxAttempts");
        int attemptCount = 0;

        // loop to keep trying until a valid meal plan with exactly 21 meals is returned
        while (!isValidResponse && attemptCount < maxAttempts)
        {
            // increment attempt counter
            attemptCount++;

            // call openai api to generate meal plan
            mealPlanResponse = await _openAiService.GenerateMealPlan(apiKey, userPrompt);

            // check if response is empty or invalid
            if (string.IsNullOrWhiteSpace(mealPlanResponse))
            {
                _logger.LogWarning("Attempt {AttemptCount}: Empty response from OpenAI.", attemptCount);

            }
            else
            {
                // clean and trim response
                string mealPlanCsv = mealPlanResponse.Trim();

                // parse meal plan response into structured format (WeeklyMealPlan)
                mealPlan = ParseMealPlan(mealPlanCsv);

                // check for exactly 21 meals (7 days × 3 meals per day)
                if (mealPlan.WeeklyPlan.Count == 7 && mealPlan.WeeklyPlan.All(d => d.Breakfast != null && d.Lunch != null && d.Dinner != null))
                {
                    // if valid set flag to true
                    isValidResponse = true;
                }
                else
                {
                    // log issue and try again if response doesnt have right number of meals
                    Console.WriteLine($"Invalid meal plan response. Expected 21 meals, got {mealPlan.WeeklyPlan.Count * 3}.");
                }
            }
        }

        // if valid response not generated within maxattempts, return empty meal plan
        if (!isValidResponse)
        {
            Console.WriteLine("Max attempts reached. Returning empty meal plan.");
            mealPlan = new WeeklyMealPlan { WeeklyPlan = new List<DailyMeals>() };
        }

        // log to check meal plan data
        _logger.LogInformation("Generated meal plan: {@mealPlan}", mealPlan);

        // generate recipe url for each meal
        foreach (var dailyMeal in mealPlan.WeeklyPlan)
        {
            dailyMeal.Breakfast.RecipeUrl = _recipeFinderService.GenerateGoogleSearchUrl(dailyMeal.Breakfast.Name);
            dailyMeal.Lunch.RecipeUrl = _recipeFinderService.GenerateGoogleSearchUrl(dailyMeal.Lunch.Name);
            dailyMeal.Dinner.RecipeUrl = _recipeFinderService.GenerateGoogleSearchUrl(dailyMeal.Dinner.Name);
        }

        //testing
        Console.WriteLine(input.Name + input.Request + input.Likes + input.Dislikes + input.Allergies);

        // return meal plan to view
        return View("MealPlan", new WeeklyMealPlan
        {
            WeeklyPlan = mealPlan.WeeklyPlan,
            // pass the inputs to view (Name, Email, etc.) 
            MealInput = input
        });
    }


    // helper method to parse raw openai response into structured meal plan
    private WeeklyMealPlan ParseMealPlan(string rawText)
    {
        var mealPlan = new WeeklyMealPlan();

        // split raw text by 'BREAK' and trim each part
        var parts = rawText.Split("'BREAK'", StringSplitOptions.RemoveEmptyEntries)
                           .Select(p => p.Trim())
                           .ToList();

        // loop through parts and organize into daily meals
        for (int i = 0; i + 2 < parts.Count; i += 3)
        {
            var dailyMeals = new DailyMeals
            {
                Breakfast = new Meal
                {
                    Name = parts[i]
                },
                Lunch = new Meal
                {
                    Name = parts[i + 1]
                },
                Dinner = new Meal
                {
                    Name = parts[i + 2]
                }
            };

            // add daily meals to weekly plan
            mealPlan.WeeklyPlan.Add(dailyMeals);
        }

        // return parsed meal plan
        return mealPlan;
    }
}