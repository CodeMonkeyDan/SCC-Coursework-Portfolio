//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


namespace DSchiefer_CPT206_MealPlanning.Models;


// holds data for displaying error details
public class ErrorViewModel
{
    // request id for current activity or error
    public string? RequestId { get; set; }

    // true if request id is available
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
