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

    public class MonsterTeam:Team
    {
        public Boss[] Bosses;
        public Elite[] Elites;
        public Minions[] Minions;
        public MonsterActionState ActionState;

        public MonsterTeam()
        {
            this.Bosses = null;
            this.Elites = null;
            this.Minions = null;
            ResetActionState();
        }

        public void ResetActionState()
        {
            this.ActionState = MonsterActionState.AllReady;
        }
    }
}
