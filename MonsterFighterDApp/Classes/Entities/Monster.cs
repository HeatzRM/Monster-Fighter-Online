using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public class Monster : Entity
    {
       public List<Dictionary<Element, int>> ElementalAttribute { set; get; }

       public Monster()
       {

       }

       public Monster(string Name, long Health, List<Dictionary<Element, int>> ElementalAttribute, uint AttackPerTurn, long DamagePerAttack)
       {
            this.Name = Name;
            this.Health = Health;
            this.ElementalAttribute = ElementalAttribute;
            this.AttackPerTurn = AttackPerTurn;
            this.DamagePerAttack = DamagePerAttack;
       }
    }
}
