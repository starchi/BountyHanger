using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BountyHanger.Library
{
    public enum UnitActionState
    {
        [Description("单位待命中")]
        Ready,
        [Description("单位已行动")]
        Done,
        [Description("单位已死亡")]
        Dead,
    }

    public class Unit
    {
        public int UnitID;
        public string UnitName;
        public int HealPoint;
        public int AttackPower;
        public int CurrentHP;
        private int _maxHP;
        public virtual int MaxHP
        {
            get
            {
                return _maxHP;
            }
            set
            {
                _maxHP = value;
            }
        }
        private int _currentAttack;
        public virtual int CurrentAttack
        {
            get
            {
                return _currentAttack;
            }
            set
            {
                _currentAttack = value;
            }
        }
        public Skill ActiveSkill;
        public Skill PassiveSkill;
        public UnitActionState ActionState;

        #region 构造函数
        public Unit(int id)
        {
            //test
            this.UnitID = id;
            this.UnitName = "民兵";
            this.HealPoint = 3;
            this.MaxHP = this.HealPoint;
            this.CurrentHP = this.MaxHP;
            this.AttackPower = 1;
            this.CurrentAttack = AttackPower;
            this.ActiveSkill = null;
            this.PassiveSkill = null;
            ResetActionState();
        }

        public Unit(int id, int count)
            : this(id)
        {
            //this.AliveCount = count;
        }
        #endregion

        /// <summary>
        /// 重置行动状态
        /// 如果英雄未死亡则重置为待命状态
        /// </summary>
        public virtual void ResetActionState()
        {
            if (this.ActionState != UnitActionState.Dead)
            {
                this.ActionState = UnitActionState.Ready;
            }
        }

        /// <summary>
        /// 玩家单位行动
        /// </summary>
        /// <param name="turn">当前回合数</param>
        /// <param name="enemy">敌人（怪物队伍）</param>
        /// <returns>行动日志</returns>
        public virtual string Action(int turn, Team enemy)
        {
            //如已死亡则返回空字符串，否则修改为已行动
            if (this.ActionState == UnitActionState.Dead)
            {
                return "";
            }
            else
            {
                this.ActionState = UnitActionState.Done;
            }
            //判断是否符合主动技能发动条件
            //todo:技能释放判断
            if (false)
            {
                //释放主动技能
                return "单位释放技能";
            }
            else
            {
                //随机攻击敌人
                return RandomAttack(enemy);
            }
            return "单位行动";
        }

        /// <summary>
        /// 随机攻击
        /// </summary>
        /// <param name="enemy">敌人队伍</param>
        /// <returns>攻击日志</returns>
        private string RandomAttack(Team enemy)
        {
            StringBuilder actionLog = new StringBuilder();
            //随机选择目标单位
            Unit target = RandomTargetAliveEnemy(enemy);
            actionLog.AppendLine(this.UnitName + "对" + target.UnitName + "发动攻击。");
            //目标受到伤害
            string result = target.BeDamage(this.CurrentAttack);
            actionLog.AppendLine(result);
            return actionLog.ToString();
        }

        /// <summary>
        /// 随机选择敌人队伍中存活单位
        /// </summary>
        /// <param name="enemy">敌人队伍</param>
        /// <returns>随机选中的未死亡的单位</returns>
        private Unit RandomTargetAliveEnemy(Team enemy)
        {
            Unit targetUnit = null;
            double maxValue = 0;
            double randValue = 0;

            //根据敌人类型（怪物/玩家）进行遍历
            if (enemy.GetType() == Type.GetType("BountyHanger.Library.MonsterTeam"))
            {
                MonsterTeam monster = (MonsterTeam)enemy;
                #region 遍历怪物未死亡单位
                //遍历未死亡的Boss
                for (int i = 0; i < monster.Bosses.Length; i++)
                {
                    if (monster.Bosses[i].ActionState != UnitActionState.Dead)
                    {
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            maxValue = randValue;
                            targetUnit = monster.Bosses[i];
                        }
                    }
                }
                //遍历未死亡的精英
                for (int i = 0; i < monster.Elites.Length; i++)
                {
                    if (monster.Elites[i].ActionState != UnitActionState.Dead)
                    {
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            maxValue = randValue;
                            targetUnit = monster.Elites[i];
                        }
                    }
                }
                //遍历未死亡的喽啰
                for (int i = 0; i < monster.Minions.Length; i++)
                {
                    if (monster.Minions[i].ActionState != UnitActionState.Dead)
                    {
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            maxValue = randValue;
                            targetUnit = monster.Minions[i];
                        }
                    }
                }
                #endregion
            }
            else
            {
                PlayerTeam player = (PlayerTeam)enemy;
                #region 遍历玩家未死亡单位
                targetUnit = player.Hero;
                maxValue = RandomBuilder.GetDouble();
                //遍历未死亡的部队
                for (int i = 0; i < player.Corps.Length; i++)
                {
                    if (player.Corps[i].ActionState != UnitActionState.Dead)
                    {
                        randValue = RandomBuilder.GetDouble();
                        if (randValue > maxValue)
                        {
                            maxValue = randValue;
                            targetUnit = player.Corps[i];
                        }
                    }
                }
                #endregion
            }

            return targetUnit;
        }

        /// <summary>
        /// 单位受到伤害
        /// </summary>
        /// <param name="damege">受到的伤害值</param>
        /// <returns>结算结果日志</returns>
        public virtual string BeDamage(int damege)
        {
            this.CurrentHP -= damege;
            //判断是否死亡
            if (this.CurrentHP <= 0)
            {
                this.CurrentHP = 0;
                this.ActionState = UnitActionState.Dead;
                return this.UnitName + "受到" + damege + "点伤害，剩余体力：" + this.CurrentHP + "/" + this.MaxHP + "。" + this.UnitName + "被击毙。";
            }
            else
            {
                return this.UnitName + "受到" + damege + "点伤害，剩余体力：" + this.CurrentHP + "/" + this.MaxHP + "。";
            }
        }
    }
}
