using ASP.Net_Dependency_Injection.Classes;
using ASP.Net_Dependency_Injection.Middleware;
using ASP.Net_Dependency_Injection.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IDrink, Tea>();
builder.Services.AddTransient<IDrink, Coffee>();
builder.Services.AddTransient<IDrink, Juice>();
builder.Services.AddTransient<DrinkService>();

var app = builder.Build();

app.Map("/drink", (app) =>
{
    app.UseMiddleware<DrinkMiddleware>();
});
app.Run();
