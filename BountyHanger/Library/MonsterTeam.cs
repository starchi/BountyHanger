using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BountyHanger.Library
{
    public enum MonsterActionState
    {
        [Description("所有单位待命中")]
        AllReady,
        [Description("所有Boss行动完毕")]
        BossDone,
        [Description("所有精英行动完毕")]
        ElitesDone,
        [Description("所有单位行动完毕")]
        AllDone,
        [Description("所有单位死亡，被消灭")]
        AllDead,
    }

    public class MonsterTeam : Team
    {
        public Boss[] Bosses;
        public Elite[] Elites;
        public Minions[] Minions;
        public MonsterActionState ActionState;

        public MonsterTeam()
        {
            //test
            this.Bosses = new Boss[1];
            this.Bosses[0] = new Boss(2);
            this.Members.Add(this.Bosses[0]);
            this.Bosses[0].JoinTeam(this);
            this.Elites = new Elite[2];
            for (int i = 0; i < Elites.Length; i++)
            {
                Elites[i] = new Elite(200 + i);
                this.Members.Add(this.Elites[i]);
                this.Elites[i].JoinTeam(this);
            }
            this.Minions = new Minions[3];
            for (int i = 0; i < Minions.Length; i++)
            {
                Minions[i] = new Minions(20+i, (i + 1) * 8);
                this.Members.Add(this.Minions[i]);
                this.Minions[i].JoinTeam(this);
            }
            ResetActionState();
        }

        /// <summary>
        /// 重置所有单位的行动状态
        /// </summary>
        public void ResetActionState()
        {
            if (this.ActionState != MonsterActionState.AllDead)
            {
                //重置Boss行动状态
                for (int i = 0; i < Bosses.Length; i++)
                {
                    Bosses[i].ResetActionState();
                }
                //重置精英的行动状态
                for (int i = 0; i < Elites.Length; i++)
                {
                    Elites[i].ResetActionState();
                }
                //重置喽啰的行动状态
                for (int i = 0; i < Minions.Length; i++)
                {
                    Minions[i].ResetActionState();
                }
                //修改队伍行动状态
                this.ActionState = MonsterActionState.AllReady;
            }
        }

        /// <summary>
        /// 队伍执行下一个动作
        /// </summary>
        /// <param name="turn">当前回合数</param>
        /// <param name="enemy">敌人（玩家队伍）</param>
        /// <returns>本次行动日志</returns>
        public string DoNextAction(int turn, PlayerTeam enemy)
        {
            Unit nextActionUnit = null;
            double maxValue = 0;
            double randValue = 0;
            int count = 0;
            //根据队伍行动状态选取下一个行动单位并执行动作
            if (this.ActionState == MonsterActionState.AllReady)
            {
                //随机选取未行动的Boss
                for (int i = 0; i < Bosses.Length; i++)
                {
                    if (Bosses[i].ActionState == UnitActionState.Ready)
                    {
                        count++;
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            nextActionUnit = Bosses[i];
                            maxValue = randValue;
                        }
                    }
                }
                //最后一个Boss行动，修改队伍行动状态
                if (count <= 1)
                {
                    this.ActionState = MonsterActionState.BossDone;
                }
            }
            //无Boss行动 选取精英行动
            if (nextActionUnit == null && this.ActionState == MonsterActionState.BossDone)
            {
                //随机选取未行动的精英
                for (int i = 0; i < Elites.Length; i++)
                {
                    if (Elites[i].ActionState == UnitActionState.Ready)
                    {
                        count++;
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            nextActionUnit = Elites[i];
                            maxValue = randValue;
                        }
                    }
                }
                //如果为最后一个精英行动，修改队伍行动状态
                if (count <= 1)
                {
                    this.ActionState = MonsterActionState.ElitesDone;
                }
            }
            //无Boss和精英行动 选取喽啰行动
            if (nextActionUnit == null && this.ActionState == MonsterActionState.ElitesDone)
            {
                //随机选取未行动的喽啰
                for (int i = 0; i < Minions.Length; i++)
                {
                    if (Minions[i].ActionState == UnitActionState.Ready)
                    {
                        count++;
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            nextActionUnit = Minions[i];
                            maxValue = randValue;
                        }
                    }
                }
                //如果为最后一个喽啰动，修改队伍行动状态
                if (count <= 1)
                {
                    this.ActionState = MonsterActionState.AllDone;
                }
            }
            //如果无可行动单位，返回空字符串
            if (nextActionUnit == null)
            {
                return "";
            }
            else
            {
                //执行该单位动作
                return nextActionUnit.Action(turn, enemy);
            }
        }
    }
}
