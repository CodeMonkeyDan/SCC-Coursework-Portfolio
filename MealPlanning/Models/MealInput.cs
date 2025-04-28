//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


namespace DSchiefer_CPT206_MealPlanning.Models;

// holds user input from meal planner form
public class MealInput
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Request {  get; set; }
    public string Likes { get; set; }
    public string Dislikes { get; set; }
    public string Allergies { get; set; }
}