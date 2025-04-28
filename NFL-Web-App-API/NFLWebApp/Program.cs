//Daniel Schiefer aka CodeMonkeyDan
//CPT206-A80S-2025SP
//Lab #5: Web App


using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//register HttpClient for making API calls
builder.Services.AddHttpClient(name: "DSchiefer_Lab_5_WebAPI",
        configureClient: options =>
        {
            options.BaseAddress = new Uri("https://localhost:5501/");
            options.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json", 1.0));
        });

// Enable logging to console (optional but helpful for troubleshooting)
builder.Services.AddLogging(logging =>
{
    logging.AddConsole(); // Logs to the console
    logging.SetMinimumLevel(LogLevel.Information); // You can adjust the minimum level (default is Information)
});

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
