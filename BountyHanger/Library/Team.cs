using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    #region 旧代码
    /// <summary>
    /// 退役者（队伍更变后更替出的英雄和士兵）
    /// </summary>
    public struct Retirees
    {
        public Hero Hero;
        public Corp[] Units;
    }
    #endregion

    public class Team
    {
        #region 旧代码
        //    public Hero Hero;
        //    public Unit[] Units;
        //    public int TeamHeal
        //    {
        //        get
        //        {
        //            int heal = 0;
        //            foreach (Unit unit in this.Units)
        //            {
        //                if (unit != null)
        //                {
        //                    heal += unit.CurrentHeal;
        //                }
        //            }
        //            if (this.Hero != null)
        //            {
        //                heal += this.Hero.HealPoint;
        //                heal = (int)(heal * this.Hero.HealPoinBonus);
        //            }
        //            return heal;
        //        }
        //    }
        //    public int TeamAttack
        //    {
        //        get
        //        {
        //            int attack = 0;
        //            foreach (Unit unit in this.Units)
        //            {
        //                if (unit != null)
        //                {
        //                    //waring: unit is alive?
        //                    attack += unit.Attack;
        //                }
        //            }
        //            if (this.Hero != null)
        //            {
        //                attack += this.Hero.Attack;
        //                attack = (int)(attack * this.Hero.AttackBonus);
        //            }
        //            return attack;
        //        }
        //    }

        //    public Team()
        //    {
        //        this.Hero = null;
        //        this.Units = null;
        //    }

        //    /// <summary>
        //    /// 更换英雄
        //    /// </summary>
        //    /// <param name="hero"></param>
        //    /// <returns>Retirees</returns>
        //    public Retirees ChangeHero(Hero hero)
        //    {
        //        Retirees retirees = new Retirees();
        //        //更换英雄
        //        if (hero != this.Hero)
        //        {
        //            retirees.Hero = this.Hero;
        //            this.Hero = hero;
        //            //领导力高于原英雄，保留所有士兵，否则所有士兵退役
        //            if (retirees.Hero!=null&&this.Hero.Leadership >= retirees.Hero.Leadership)
        //            {
        //                Unit[] oldUnits = this.Units;
        //                this.Units = new Unit[this.Hero.Leadership];
        //                for (int i = 0; i < oldUnits.Length; i++)
        //                {
        //                    this.Units[i] = oldUnits[i];
        //                }
        //            }
        //            else
        //            {
        //                retirees.Units = this.Units;
        //                this.Units = new Unit[this.Hero.Leadership];
        //            }
        //        }
        //        return retirees;
        //    }

        //    public Retirees AddUnitByIndex(Unit unit, int index)
        //    {
        //        Retirees retirees = new Retirees();
        //        if (index <= this.Hero.Leadership)
        //        {
        //            if (this.Units[index] != null)
        //            {
        //                retirees.Units = new Unit[1];
        //                retirees.Units[0] = this.Units[index];
        //            }
        //            this.Units[index] = unit;
        //        }
        //        return retirees;
        //    }

        //    public Retirees DelUnitByIndex(Unit unit, int index)
        //    {
        //        Retirees retirees = new Retirees();
        //        if (index <= this.Hero.Leadership && this.Units[index] != null)
        //        {
        //            retirees.Units = new Unit[1];
        //            retirees.Units[0] = this.Units[index];
        //            for (int i = index + 1; i < this.Units.Length; i++)
        //            {
        //                if (this.Units[i] != null)
        //                {
        //                    this.Units[i - 1] = this.Units[i];
        //                }
        //            }

        //        }
        //        return retirees;
        //    }

        //    public Retirees ChangeUnits(Unit[] units) {
        //        Retirees retirees = new Retirees();
        //        if (units.Length <= Hero.Leadership)
        //        {
        //            retirees.Units = this.Units;
        //            this.Units = units;
        //        }
        //        else {
        //            retirees.Units = units;
        //        }
        //        return retirees;
        //    }
        #endregion

        public List<Unit> Members;
        public List<Unit> DeadMembers;
        private int _deadCount;
        public bool IsDetroyed
        {
            get
            {
                return _deadCount >= Members.Count;
            }
        }

        public Team()
        {
            Members = new List<Unit>();
            DeadMembers = new List<Unit>();
            _deadCount = 0;
        }

        public void MemberDead(Unit unit)
        {
            DeadMembers.Add(unit);
            _deadCount++;
            //throw new NotImplementedException();
        }
    }
}
