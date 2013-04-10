using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BountyHanger.Library
{
    /// <summary>
    /// 玩家队伍行动状态
    /// </summary>
    public enum PlayerActionState
    {
        [Description("所有单位待命中")]
        AllReady,
        [Description("英雄行动结束")]
        HeroDone,
        [Description("所有单位行动结束")]
        AllDone,
        [Description("所有单位死亡，被消灭")]
        AllDead,
    }

    /// <summary>
    /// 玩家队伍类
    /// </summary>
    public class PlayerTeam : Team
    {
        /// <summary>
        /// 玩家英雄
        /// </summary>
        public Hero Hero;
        /// <summary>
        /// 玩家部队
        /// </summary>
        public Corps[] Corps;
        /// <summary>
        /// 玩家队伍行动状态
        /// </summary>
        public PlayerActionState ActionState;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public PlayerTeam()
            : base()
        {
            //test
            this.Hero = new Hero(1, 3);
            this.Members.Add(this.Hero);
            this.Hero.JoinTeam(this);
            this.Corps = new Corps[Hero.Leadership];
            for (int i = 0; i < Corps.Length; i++)
            {
                this.Corps[i] = new Corps(10+i, 10 * (i + 1));
                this.Members.Add(this.Corps[i]);
                this.Corps[i].JoinTeam(this);
            }
            ResetActionState();
        }

        /// <summary>
        /// 重置所有单位的行动状态
        /// </summary>
        public void ResetActionState()
        {
            if (this.ActionState != PlayerActionState.AllDead)
            {
                //重置英雄行动状态
                Hero.ResetActionState();
                //重置所有部队的行动状态
                for (int i = 0; i < Corps.Length; i++)
                {
                    Corps[i].ResetActionState();
                }
                //修改队伍行动状态
                this.ActionState = PlayerActionState.AllReady;
            }
        }

        /// <summary>
        /// 队伍执行下一个动作
        /// </summary>
        /// <param name="turn">当前回合数</param>
        /// <param name="enemy">敌人（怪物队伍）</param>
        /// <returns>本次行动日志</returns>
        public string DoNextAction(int turn, MonsterTeam enemy)
        {
            Unit nextActionUnit = null;
            //根据队伍行动状态选取下一个行动单位并执行动作
            if (this.ActionState == PlayerActionState.AllReady)
            {
                //英雄行动
                //修改队伍行动状态为英雄行动结束
                this.ActionState = PlayerActionState.HeroDone;
                if (Hero.ActionState != UnitActionState.Dead)
                {
                    //执行英雄动作
                    nextActionUnit = Hero;
                    //return Hero.Action(turn, enemy);
                }
            }
            else if (this.ActionState == PlayerActionState.HeroDone)
            {
                //部队行动
                double maxValue = 0;
                double randValue = 0;
                //Corps nextCorps = null;
                int count = 0;
                //随机选取未行动的部队行动（分配随机数，选取随机数最大的部队准备执行动作）
                for (int i = 0; i < Corps.Length; i++)
                {
                    if (Corps[i].ActionState == UnitActionState.Ready)
                    {
                        count++;
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            nextActionUnit = Corps[i];
                            maxValue = randValue;
                        }
                    }
                }
                //如果为最后一个未行动部队，修改队伍行动状态为全部单位行动结束
                if (count <= 1)
                {
                    this.ActionState = PlayerActionState.AllDone;
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
