//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Final Project: Meal Planning App


using DSchiefer_CPT206_MealPlanning.Services;

var builder = WebApplication.CreateBuilder(args);

// Enable console logging
builder.Logging.ClearProviders(); // Optional: Remove other loggers if needed
builder.Logging.AddConsole(); // Add console logging for logs in the terminal

// Add services to the container.
builder.Services.AddControllersWithViews();

// Retrieve the API key from configuration
var apiKey = builder.Configuration["OpenAI:ApiKey"];

// checks if apikey is null or empty
if (string.IsNullOrEmpty(apiKey))
{
    throw new InvalidOperationException("API key is missing from configuration.");
}

// Register OpenAiService with the API key
builder.Services.AddSingleton<OpenAiService>(sp =>
{
    var logger = sp.GetRequiredService<ILogger<OpenAiService>>();
    return new OpenAiService(apiKey, logger);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();