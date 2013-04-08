using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public class Equip
    {
        public int EquipID;
        public int HPIncrease;
        public int AttackIncrease;

        public Equip(int id) {
            this.EquipID = id;
        }
    }
}
