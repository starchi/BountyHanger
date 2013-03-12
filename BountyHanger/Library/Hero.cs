using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Hero : Character
    {
        public double AttackBonus;
        public double HealPoinBonus;
        public int Leadership;


        public Hero(string name, int hp, int attack, double ab, double hb, int leadership)
            : base(name, hp, attack)
        {
            this.AttackBonus = ab;
            this.HealPoinBonus = hb;
            this.Leadership = leadership;
        }
    }
}
