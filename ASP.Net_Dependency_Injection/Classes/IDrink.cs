namespace ASP.Net_Dependency_Injection.Classes
{
    public interface IDrink
    {
        public string GetInfo();
    }

    public class Tea : IDrink
    {
        public string GetInfo() => "Hot tea with raspberries!";
    }

    public class Coffee : IDrink
    {
        public string GetInfo() => "Hot coffee with milk!";
    }

    public class Juice : IDrink
    {
        public string GetInfo() => "Cold apple juice!";
    }
}
