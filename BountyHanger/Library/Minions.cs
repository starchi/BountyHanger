using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Minions:Unit
    {
        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount;
        /// <summary>
        /// 存活数量
        /// </summary>
        public int AliveCount;
        /// <summary>
        /// 死亡数量
        /// </summary>
        public int DeadCount;

        /// <summary>
        /// 当前体力值，目前没有当前体力值的限制逻辑，暂时不需要额外new
        /// </summary>
        //public new int CurrentHP;

        /// <summary>
        /// 最大体力值
        /// </summary>
        public override int MaxHP
        {
            get
            {
                return base.MaxHP * this.AliveCount;
            }
        }

        /// <summary>
        /// 当前攻击力
        /// </summary>
        public override int CurrentAttack
        {
            get
            {
                return base.CurrentAttack * this.AliveCount;
            }
        }
        /// <summary>
        /// 装备
        /// </summary>
        public Equip Equip;

        public Minions(int unitID, int count)
            : base(unitID)
        {
            this.TotalCount = count;
            this.AliveCount = this.TotalCount;
            this.DeadCount = 0;
            this.CurrentHP = this.MaxHP;
            this.Equip = null;
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
            if (this.MaxHP > this.CurrentHP && damage_real % base.MaxHP >= base._maxHP - this.MaxHP + this.CurrentHP)
            {
                killCount++;
            }
            //数值处理
            this.CurrentHP -= damage_real;
            this.AliveCount -= killCount;
            this.DeadCount += killCount;
            if (this.AliveCount == 0)
            {
                this.ActionState = UnitActionState.Dead;
                this.Team.MemberDead(this);
            }
            //返回日志
            return this.Name + "受到" + damage + "点伤害，损失" + killCount + "个单位。部队存活：" + this.AliveCount + "/" + this.TotalCount + "。部队体力：" + this.CurrentHP + "/" + this.MaxHP + "。"  + (this.ActionState == UnitActionState.Dead ? this.Name + "被消灭了。" : "");
        }
    }
}
