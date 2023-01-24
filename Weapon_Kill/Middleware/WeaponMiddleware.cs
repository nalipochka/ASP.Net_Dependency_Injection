using Weapon_Kill.Services;

namespace Weapon_Kill.Middleware
{
    public class WeaponMiddleware
    {
        private readonly RequestDelegate next;

        public WeaponMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, UkrainianSoldier soldier)
        {
            context.Response.Headers.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync(soldier.Weapon.Kill());
        }
    }
}
