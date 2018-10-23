using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public class Player : Entity
    {
        public Head head { set; get; }
        public Arms arms { set; get; }
        public Torso torso { set; get; }
        public Leggings leggings { set; get; }
        public Footwear footwear { set; get; }
        public Weapon weaponEquipped { set; get; }

        public Player()
        {
            head = null;
            arms = null;
            torso = null;
            leggings = null;
            footwear = null;
            weaponEquipped = null;
        }

        public void calculateDamage()
        {
            this.DamagePerAttack = weaponEquipped.Damage;
            this.AttacksPerTurn = weaponEquipped.NumberOfAttacksOfTheWeapon;
        }
        
    }
}
