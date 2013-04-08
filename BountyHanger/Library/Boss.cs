using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Boss:Unit
    {
        public string Name;
        public int HealPoint;
        public int Attack;
        public Skill ActiveSkill;
        public Skill PassiveSkill;
        public object[] LootList;
        public double[] LootProbability;

        public Boss(string name, int hp, int attack):base(1)
        {
            this.Name = name;
            this.HealPoint = hp;
            this.Attack = attack;
            this.ActiveSkill = null;
            this.PassiveSkill = null;
            this.LootList = null;
            this.LootProbability = null;
        }
    }
}
