using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFighterDApp
{
    public abstract class Entity
    {
        public string Name { set; get; }
        public long Health { set; get; }
        public long DamagePerAttack { set; get; }
        public uint AttacksPerTurn { set; get; }
        public ulong Experience { set; get; }

        public void AddExperience(ulong ExperienceGained)
        {
            Experience = Experience + ExperienceGained;
        }

        private void BasicAttack(Entity entity)
        {
            entity.Health = entity.Health - DamagePerAttack;
        }

        public void Attack(Entity entity)
        {
            for (int i = 0; i < AttacksPerTurn; i++)
            {
                BasicAttack(entity);
            }
        }
    }
}
