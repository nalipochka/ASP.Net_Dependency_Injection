using ASP.Net_Dependency_Injection.Classes;
using Weapon_Kill.Middleware;
using Weapon_Kill.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IWeapon, Glock18>();
builder.Services.AddTransient<UkrainianSoldier>();

var app = builder.Build();

app.Map("/kill", (app) =>
{
    app.UseMiddleware<WeaponMiddleware>();
});

app.Run();
