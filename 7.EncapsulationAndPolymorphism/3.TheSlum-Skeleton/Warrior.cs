using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Warrior : Character, IAttack
    {
        private int attackPoints;
        public Warrior(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range,int attackPoints)
            : base(id, x, y, healthPoints, defensePoints, team,range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints 
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.FirstOrDefault(x => x.IsAlive && x.Team != this.Team);
            return target;
        }

        public override void AddToInventory(Item item)
        {
            Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
