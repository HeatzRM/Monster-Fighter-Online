using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp.Classes
{
    public class Arms : Equiptable
    {
        public Arms(Armor EquippedArmor)
        {
            this.EquippedArmor = EquippedArmor;
        }
    }
}
