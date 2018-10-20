using System.Collections.Generic;

namespace MonsterFighterDApp.Classes
{
    public class Armor : Item
    {
        public double Defence { set; get; }
        public ArmorType armorType { set; get; }
        public Dictionary<Element, double> ElementWeakness { set; get; }

        public Armor(string Name, double Defence, Dictionary<Element, double> ElementWeakness, ArmorType armorType)
        {
            this.Name = Name;
            this.Defence = Defence;
            this.ElementWeakness = ElementWeakness;
            this.armorType = armorType;
        }
    }
}
