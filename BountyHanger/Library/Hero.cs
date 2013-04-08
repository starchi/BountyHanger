using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BountyHanger.Library.Interface;

namespace BountyHanger.Library
{
    public class Hero : Unit
    {
        /// <summary>
        /// 英雄名称
        /// </summary>
        public string HeroName;
        /// <summary>
        /// 英雄领导力
        /// </summary>
        public int Leadership;
        /// <summary>
        /// 主动技能
        /// </summary>
        public Skill ActiveSkill;
        /// <summary>
        /// 被动技能
        /// </summary>
        public Skill PassiveSkill;
        /// <summary>
        /// 装备
        /// </summary>
        public Equip Equip;


        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="unitID">单位id</param>
        /// <param name="leadership">英雄领导力</param>
        public Hero(int unitID, int leadership)
            : base(unitID)
        {
            this.HeroName = this.UnitName + "(英雄)";
            this.Leadership = leadership;
            this.Equip = null;
        }

        /// <summary>
        /// 重置行动状态
        /// 如果英雄未死亡则重置为待命状态
        /// </summary>
        public void ResetActionState()
        {
            if (this.ActionState != UnitActionState.Dead)
            {
                this.ActionState = UnitActionState.Ready;
            }
        }

        /// <summary>
        /// 英雄行动
        /// </summary>
        /// <param name="turn">当前回合数</param>
        /// <param name="enemy">敌人（怪物队伍）</param>
        /// <returns>行动日志</returns>
        public string Action(int turn, MonsterTeam enemy)
        {
            //如未死亡则行动结束
            if (this.ActionState != UnitActionState.Dead)
            {
                this.ActionState = UnitActionState.Done;
            }
            //判断是否符合主动技能发动条件
            //todo:技能释放判断
            if (false)
            {
                //释放主动技能
                return "英雄释放技能";
            }
            else
            {
                //攻击随机目标
                return RandomAttack(enemy);
            }
            return "英雄行动";
        }

        private string RandomAttack(MonsterTeam enemy)
        {
            StringBuilder actionLog = new StringBuilder();
            //随机选择目标单位
            Unit target = RandomAliveTarget(enemy);
            

            return actionLog.ToString();
        }

        /// <summary>
        /// 随机选择怪物队伍中存活单位
        /// </summary>
        /// <param name="monster">怪物队伍</param>
        /// <returns>随机选中的未死亡的单位</returns>
        private Unit RandomAliveTarget(MonsterTeam monster)
        {
            Unit targetUnit = null;
            double maxValue = 0;
            double randValue = 0;
            #region 遍历怪物未死亡单位
            //遍历未死亡的Boss
            for (int i = 0; i < enemy.Bosses.Length; i++)
            {
                if (enemy.Bosses[i].ActionState != UnitActionState.Dead)
                {
                    randValue = RandomBuilder.GetDouble();
                    if (randValue > maxValue)
                    {
                        maxValue = randValue;
                        targetUnit = enemy.Bosses[i];
                    }
                }
            }
            //遍历未死亡的精英
            for (int i = 0; i < enemy.Elites.Length; i++)
            {
                if (enemy.Elites[i].ActionState != UnitActionState.Dead)
                {
                    randValue = RandomBuilder.GetDouble();
                    if (randValue > maxValue)
                    {
                        maxValue = randValue;
                        targetUnit = enemy.Elites[i];
                    }
                }
            }
            //遍历未死亡的喽啰
            for (int i = 0; i < enemy.Minions.Length; i++)
            {
                if (enemy.Minions[i].ActionState != UnitActionState.Dead)
                {
                    randValue = RandomBuilder.GetDouble();
                    if (randValue > maxValue)
                    {
                        maxValue = randValue;
                        targetUnit = enemy.Minions[i];
                    }
                }
            }
            #endregion
            return targetUnit;
        }

    }
}
