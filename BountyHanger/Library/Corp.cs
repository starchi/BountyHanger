using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Corp
    {
        public string Name;
        public int HealPoint;
        public int Attack;

        public Corp(string name, int hp, int attack)
        {
            this.Name = name;
            this.HealPoint = hp;
            this.Attack = attack;
        }
    }
}
