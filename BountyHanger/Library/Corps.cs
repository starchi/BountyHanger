using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BountyHanger.Library.Interface;

namespace BountyHanger.Library
{
    public class Corps : Unit, IStackableUnit
    {
        public int TotalCount;
        public int AliveCount;
        public int DeadCount;
        public new int CurrentHP;
        public override int MaxHP
        {
            get
            {
                return base.MaxHP * this.AliveCount;
            }
        }
        public override int CurrentAttack
        {
            get
            {
                return base.CurrentAttack * this.AliveCount;
            }
        }

        public Corps(int unitID, int count)
            : base(unitID)
        {
            this.TotalCount = count;
            this.AliveCount = this.TotalCount;
            this.DeadCount = 0;
            this.CurrentHP = this.MaxHP;
        }

        /// <summary>
        /// 受到伤害
        /// </summary>
        /// <param name="damage">伤害值</param>
        /// <returns>伤害结算日志</returns>
        public override string BeDamage(int damage)
        {
            //溢出伤害修正
            int damage_real = damage;
            if (damage >= this.CurrentHP)
            {
                damage_real = this.CurrentHP;
            }
            //计算伤害杀掉的数量
            int killCount = damage_real / base.MaxHP;
            //额外杀掉伤兵
            if (damage % this.MaxHP >= this.MaxHP - this.CurrentHP)
            {
                killCount++;
            }
            //数值处理
            this.CurrentHP -= damage;
            this.AliveCount -= killCount;
            this.DeadCount += killCount;
            if (this.AliveCount == 0)
            {
                this.ActionState = UnitActionState.Dead;
            }
            //返回日志
            return this.UnitName + "受到" + damage + "点伤害，损失" + killCount + "个单位。" + (this.ActionState == UnitActionState.Dead ? this.UnitName + "被消灭了。" : "");
        }

    }
}
