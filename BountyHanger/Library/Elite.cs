using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Elite : Unit
    {
        private string _eliteName = "";
        /// <summary>
        /// 精英名称
        /// </summary>
        public override string Name
        {
            get
            {
                if (_eliteName != "")
                {
                    return _eliteName;
                }
                else
                {
                    return base.Name + "(精英)";
                }
            }
            set
            {
                _eliteName = value;
            }
        }

        public Elite(int unitID)
            : base(unitID)
        {
           
        }
    }
}
