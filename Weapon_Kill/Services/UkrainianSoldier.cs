using ASP.Net_Dependency_Injection.Classes;

namespace Weapon_Kill.Services
{
    public class UkrainianSoldier
    {
        public IWeapon Weapon { get; }
        public UkrainianSoldier(IWeapon weapon)
        {
            Weapon = weapon;
        }
    }
}
