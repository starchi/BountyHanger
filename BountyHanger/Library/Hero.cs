using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BountyHanger.Library.Interface;

namespace BountyHanger.Library
{
    public class Hero : Unit
    {

        private string _heroName="";
        /// <summary>
        /// 英雄名称
        /// </summary>
        public override string Name
        {
            get
            {
                if (_heroName != "")
                {
                    return _heroName;
                }
                else
                {
                    return base.Name + "(英雄)";
                }
            }
            set
            {
                _heroName = value;
            }
        }
        /// <summary>
        /// 英雄领导力
        /// </summary>
        public int Leadership;
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
            this.Leadership = leadership;
            this.Equip = null;
        }
    }
}
