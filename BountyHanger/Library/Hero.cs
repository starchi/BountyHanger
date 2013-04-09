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
    }
}
