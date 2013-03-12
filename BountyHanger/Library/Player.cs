using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Player
    {
        public string Name;
        public int Money;
        public Team Team;

        public Player(string name)
        {
            this.Name = name;
            this.Money = 1000;
            
        }
    }
}
