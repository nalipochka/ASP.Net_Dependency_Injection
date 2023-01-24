using ASP.Net_Dependency_Injection.Services;

namespace ASP.Net_Dependency_Injection.Middleware
{
    public class DrinkMiddleware
    {
        private readonly RequestDelegate next;

        public DrinkMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, DrinkService service)
        {
            context.Response.Headers.ContentType = "text/html;charset=utf-8";
            foreach (var item in service.Drink)
            {
                await context.Response.WriteAsync($"<div>Drink: {item.GetInfo()}</div>");
            } 
        }
    }
}
