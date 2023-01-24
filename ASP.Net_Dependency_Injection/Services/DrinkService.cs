using ASP.Net_Dependency_Injection.Classes;

namespace ASP.Net_Dependency_Injection.Services
{
    public class DrinkService
    {
        public IEnumerable<IDrink> Drink { get; }
        public DrinkService(IEnumerable<IDrink> drink)
        {
            this.Drink = drink;
        }
    }
}
