//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using OpenAI;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using OpenAI.Chat;


namespace DSchiefer_CPT206_MealPlanning.Services;

public class OpenAiService
{
    private readonly OpenAIClient _api;
    private readonly ILogger<OpenAiService> _logger;


    // constructor sets up openai client and logger
    public OpenAiService(string apiKey, ILogger<OpenAiService> logger)
    {
        _api = new OpenAIClient(apiKey);
        _logger = logger;
    }


    // sends prompt and returns response
    public async Task<string> GenerateMealPlan(string key, string prompt)
    {
        ChatClient client = new("gpt-3.5-turbo", key);

        var response = await client.CompleteChatAsync(prompt);
        string responseText = "";

        if (response.Value.Content.Count > 0)
        {
            responseText = response.Value.Content[0].Text;
        }

        return responseText;
    }
}