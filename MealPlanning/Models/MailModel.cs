//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using System.Collections.Generic;


namespace DSchiefer_CPT206_MealPlanning.Models;

// stores email data
public class MailModel
{
    public string From { get; set; }

    public string To { get; set; }

    public string Subject { get; set; }

    public List<DailyMeals> WeeklyPlan { get; set; }
}
