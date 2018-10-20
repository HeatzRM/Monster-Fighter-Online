using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public class Weapon : Item
    {
        public List<Dictionary<Element, double>> ElementalAttributes { set; get; }
        public WeaponType weaponType { set; get; }
        public long Damage { set; get; }
        public uint NumberOfAttacksOfTheWeapon { set; get; }

        public Weapon(string Name, 
                      WeaponType weaponType,
                      List<Dictionary<Element, double>> ElementalAttributes,
                      long Damage,
                      uint NumberOfAttacksOfTheWeapon)
        {
            this.Name = Name;
            this.weaponType = weaponType;
            this.ElementalAttributes = ElementalAttributes;
            this.Damage = Damage;
            this.NumberOfAttacksOfTheWeapon = NumberOfAttacksOfTheWeapon;
        }
    }
}
