//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


namespace DSchiefer_CPT206_MealPlanning.Services;

public class RecipeFinderService
{
    public RecipeFinderService()
    {
    }


    // builds google search url for finding recipe based on meal name
    public string GenerateGoogleSearchUrl(string mealName)
    {
        string query = Uri.EscapeDataString($"{mealName} recipe");
        string googleSearchUrl = $"https://www.google.com/search?q={query}";

        return googleSearchUrl;
    }
}