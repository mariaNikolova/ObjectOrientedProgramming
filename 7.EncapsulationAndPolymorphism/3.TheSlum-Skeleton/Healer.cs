using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Healer : Character, IHeal
    {
        private int healingPoints;

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int healingPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.healingPoints = value;
            }
        }


        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var OrderTarget =
                from target in targetsList
                orderby target.HealthPoints
                select target;

            var firstTarget = OrderTarget.FirstOrDefault(x => x.IsAlive && x.Team == this.Team && x != this);
            return firstTarget;
        }

        public override void AddToInventory(Item item)
        {
            Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
            RemoveFromInventory(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
           
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
