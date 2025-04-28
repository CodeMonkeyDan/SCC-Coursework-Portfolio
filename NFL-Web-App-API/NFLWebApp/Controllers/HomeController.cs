using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSchiefer_Lab_5_WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Text.Json;

namespace DSchiefer_Lab_5_WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpClientFactory _clientFactory;


    public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _clientFactory = httpClientFactory;
    }


    [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)]
    //handles requests to the Index page with optional filter parameters
    public async Task<IActionResult> Index(int? year, string? week, string? team, string? winner, string? home_away)
    {
        //initialize an empty list to hold game results
        List<GameResults> games = new();

        //create an HttpClient using the named client from dependency injection
        var client = _clientFactory.CreateClient("DSchiefer_Lab_5_WebAPI");

        //build query parameters list
        var queryParams = new List<string>();
        if (year.HasValue) queryParams.Add($"year={year}");
        if (!string.IsNullOrEmpty(week)) queryParams.Add($"week={week}");
        if (!string.IsNullOrEmpty(team)) queryParams.Add($"team={team}");
        if (!string.IsNullOrEmpty(winner)) queryParams.Add($"winner={winner}");
        if (!string.IsNullOrEmpty(home_away)) queryParams.Add($"home_away={home_away}");

        //construct the final query string for the API endpoint
        string query = queryParams.Count > 0 ? "search?" + string.Join("&", queryParams) : "search";

        //send a GET request to the API using the constructed query
        var response = await client.GetAsync($"api/games/{query}");

        if (response.IsSuccessStatusCode)
        {
            //if successful, read and deserialize the JSON response into a list of GameResults
            var content = await response.Content.ReadAsStringAsync();
            games = JsonSerializer.Deserialize<List<GameResults>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<GameResults>(); //fallback to empty list if deserialization fails
        }
        else
        {
            //log a warning if the API request failed
            _logger.LogWarning("API call failed: {status}", response.StatusCode);
        }

        //pass the filtered list to the view
        return View(games);
    }


    public IActionResult Privacy()
    {
        return View();
    }


    //fetch NFL games data from API
    public async Task<IActionResult> GetGames(string year, string week, string team, string winner, string homeAway)
    {
        _logger.LogInformation("Entered GetGames method.");

        string uri = "https://localhost:5501/api/games/search?";

        //build the query string based on parameters
        if (!string.IsNullOrEmpty(year)) uri += $"year={year}&";
        if (!string.IsNullOrEmpty(week)) uri += $"week={week}&";
        if (!string.IsNullOrEmpty(team)) uri += $"team={team}&";
        if (!string.IsNullOrEmpty(winner)) uri += $"winner={winner}&";
        if (!string.IsNullOrEmpty(homeAway)) uri += $"home_away={homeAway}&";

        //remove the trailing '&' if it exists
        uri = uri.TrimEnd('&');

        _logger.LogInformation($"Requesting data from: {uri}");


        //create the HttpClient intance
        HttpClient client = _clientFactory.CreateClient(name: "DSchiefer_Lab_5_WebAPI");

        //make the request
        HttpRequestMessage request = new(method: HttpMethod.Get, requestUri: uri);
        HttpResponseMessage response = await client.SendAsync(request);

        //check if the response is successful
        if (response.IsSuccessStatusCode)
        {
            //deserialize the returned JSON data into a model
            IEnumerable<GameResults>? model = await response.Content.ReadFromJsonAsync<IEnumerable<GameResults>>();

            //check if model is null
            if (model == null)
            {
                _logger.LogWarning("No games found.");
                //return an empty list if the model is null
                return View(new List<GameResults>());
            }

            return View(model);
        }
        else
        {
            //handle/return the error
            _logger.LogError("Error fetching data from the API.");
            return View("Error");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
