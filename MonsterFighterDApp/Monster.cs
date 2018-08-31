using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp
{
    public enum Elements
    {
        BirdWyvern, FlyingWyvern, PiscineWyvern, Carapaceon,
        Amphibian, FangedBeasts, Leviathan, SnakeWyvern, BruteWyvern,
        FangedWyvern, ElderDragon
    }

    public enum WeaponType { BusterSword, LongSword, SwordAndShield, Lance, BowGun }

    public enum Element { Fire, Water, Thunder, Ice, Dragon, None }

    class Monster : Entity
    {
        private Element element;
        
        public Monster() {
            
        }

        
    }
}
