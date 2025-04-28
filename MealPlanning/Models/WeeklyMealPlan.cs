//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


namespace DSchiefer_CPT206_MealPlanning.Models;

// full weeks worh of meals (7 days x 3 meals)
public class WeeklyMealPlan
{
    // list of daily meal sets (breakfast, lunch, dinner for each day)
    public List<DailyMeals> WeeklyPlan { get; set; } = new List<DailyMeals>();

    // property to store meal input information
    public MealInput? MealInput { get; set; }

    // constructor to initialize mealinput
    public WeeklyMealPlan()
    {
        MealInput = new MealInput();
    }
}


// meals for a single day
public class DailyMeals
{
    public Meal? Breakfast { get; set; } = new Meal();
    public Meal? Lunch { get; set; } = new Meal();
    public Meal? Dinner { get; set; } = new Meal();
}


// single meal with name and recipe url
public class Meal
{
    public string? Name { get; set; }
    public string? RecipeUrl { get; set; }
}