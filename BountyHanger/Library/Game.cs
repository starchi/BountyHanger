using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Game
    {
        public Team Team;

        public void TestGame()
        {
            //Player player = new Player("Once");
            Team = new Team();
            Hero hero = new Hero("Once", 1000, 10, 1, 1, 4);
            Team.ChangeHero(hero);
            Unit[] units = new Unit[hero.Leadership-1];
            for (int i = 0; i < units.Length; i++) {
                units[i] = new Unit("部队" + i, 100 * i+50, 10 * i+5);
            }
            Team.ChangeUnits(units);
            
        }
    }
}
