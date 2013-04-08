using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Minions:Unit
    {
        public Corp Unit;
        public int Count;
        public int CurrentHP;
        public int MaxHP
        {
            get
            {
                return Unit.HealPoint * Count;
            }
        }
        public int Attack
        {
            get
            {
                return Unit.Attack * Count;
            }
        }
        public Skill ActiveSkill;
        public Skill PassiveSkill;
        public object[] LootList;
        public double[] LootProbability;

        public Minions(Corp unit, int count):base(1)
        {
            this.Unit = unit;
            this.Count = count;
            this.ActiveSkill = null;
            this.PassiveSkill = null;
            this.LootList = null;
            this.LootProbability = null;
        }
    }
}
