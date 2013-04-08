using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BountyHanger.Library.Interface;

namespace BountyHanger.Library
{
    public class Corps : Unit, IStackableUnit
    {
        public int AliveCount;
        public int DeadCount;
        public int CurrentHP;
        public int MaxHP
        {
            get
            {
                return this.HealPoint * this.AliveCount;
            }
        }
        public int TotalAttack
        {
            get
            {
                return this.Attack * this.AliveCount;
            }
        }

        public Corps(int unitID, int count)
            : base(unitID)
        {
            this.AliveCount = count;
            this.DeadCount = 0;
            this.CurrentHP = this.MaxHP;
        }

        /// <summary>
        /// 受到伤害
        /// </summary>
        /// <param name="damage">伤害值</param>
        /// <returns>伤害结算信息{Name}</returns>
        public string BeHurt(int damage)
        {
            //溢出伤害修正
            if (damage >= this.CurrentHP)
            {
                damage = this.CurrentHP;
                this.IsDestroyed = true;
            }
            //计算伤害杀掉的数量
            int killCount = damage / this.HealPoint;
            //额外杀掉伤兵
            if (damage % this.HealPoint >= this.MaxHP - this.CurrentHP)
            {
                killCount++;
            }
            //数值处理
            this.CurrentHP -= damage;
            this.AliveCount -= killCount;
            this.DeadCount += killCount;
            //返回信息
            return UnitName + "受到" + damage + "点伤害，损失" + killCount + "个单位。" + (this.IsDestroyed ? UnitName + "被消灭了。" : "");
        }

        public void ResetActionState()
        {
            if (this.ActionState != UnitActionState.Dead)
            {
                this.ActionState = UnitActionState.Ready;
            }
        }

        public string Action(int turn, MonsterTeam enemy)
        {
            if (this.ActionState != UnitActionState.Dead)
            {
                this.ActionState = UnitActionState.Done;
            }
            PassiveEffect();
            if (IsActiveSkillTiming())
            {

            }
            else
            {
                Attack(Targeting(enemy));
            }
            return "部队行动";
        }

        public void PassiveEffect()
        {
            if (PassiveSkill != null)
            {
                //PassiveSkill.Spell();
            }
        }

        public bool IsActiveSkillTiming()
        {
            return false;
        }


    }
}
