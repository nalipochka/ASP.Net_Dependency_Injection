namespace ASP.Net_Dependency_Injection.Classes
{
    public interface IWeapon
    {
        public string Kill();
    }

    public class Sword : IWeapon
    {
        public string Kill() => "Kill! Weapon: \"Sword\"";
    }

    public class Glock18 : IWeapon
    {
        public string Kill() => "Kill! Weapon: \"Glock 18\"";
    }

    public class M16A4 : IWeapon
    {
        public string Kill() => "Kill! Weapon: \"M16A4\"";
    }
}
