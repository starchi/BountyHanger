using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Boss : Unit
    {
        private string _bossName = "";
        /// <summary>
        /// Boss名称
        /// </summary>
        public override string Name
        {
            get
            {
                if (_bossName != "")
                {
                    return _bossName;
                }
                else
                {
                    return base.Name + "(Boss)";
                }
            }
            set
            {
                _bossName = value;
            }
        }

        public Boss(int unitID)
            : base(unitID)
        {

        }
    }
}
