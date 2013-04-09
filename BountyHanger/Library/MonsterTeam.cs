using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public enum MonsterActionState
    {
        AllReady,
        BossDone,
        ElitesDone,
        AllDone
    }

    public class MonsterTeam : Team
    {
        public Boss[] Bosses;
        public Elite[] Elites;
        public Minions[] Minions;
        public MonsterActionState ActionState;

        public MonsterTeam()
        {
            this.Bosses = new Boss[1];
            this.Bosses[0] = new Boss("Boss", 100, 10);
            this.Elites = new Elite[0];
            this.Minions = new Minions[3];
            for (int i = 0; i < Minions.Length; i++)
            {
                Minions[i] = new Minions(null, 10);
            }
            ResetActionState();
        }

        public void ResetActionState()
        {
            this.ActionState = MonsterActionState.AllReady;
        }
    }
}
