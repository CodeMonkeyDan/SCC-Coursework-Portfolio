//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSchiefer_CPT206_MealPlanning.Models;


namespace DSchiefer_CPT206_MealPlanning.Controllers;

public class HomeController : Controller
{
    // logger for tracking app events
    private readonly ILogger<HomeController> _logger;


    // constructor that sets the logger
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    // GET
    // displays home page
    public IActionResult Index()
    {
        return View();
    }


    // POST
    // displays home page
    [HttpPost]
    public IActionResult Index(MealInput mealInput)
    {
        return View(mealInput);
    }


    // displays privacy page
    public IActionResult Privacy()
    {
        return View();
    }


    // displays error page with request id
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}