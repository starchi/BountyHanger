using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Character
    {
        public string Name;
        public int CurrentHeal;
        public int HealPoint;
        public int Attack;

        public Character(string name, int hp, int attack)
        {
            this.Name = name;
            this.HealPoint = hp;
            this.CurrentHeal = this.HealPoint;
            this.Attack = attack;
        }
    }
}
