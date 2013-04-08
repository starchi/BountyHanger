using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel; // 先添加该引用

namespace BountyHanger.Library
{
    public enum SkillType { 
        [Description("主动技能")]
        Active,
        [Description("被动技能")]
        Passive,        
    };
    public enum SkillTargetState
    { 
        [Description("敌对生存")]
        EnemyAlive,
        [Description("敌对死亡")]
        EnemyDead,
        [Description("友方生存")]
        MateAlive,
        [Description("友方死亡")]
        MateDead,
        [Description("自己")]
        Self,
    };
    public enum SkillTargetStrategy { 
        [Description("随机选择")]
        Random,
        [Description("高级优先")]
        HighLevel,
        [Description("低级优先")]
        LowLevel,
        [Description("高血量优先")]
        HighHP,
        [Description("低血量优先")]
        LowHP,
        [Description("高攻击优先")]
        HighAttack,
        [Description("低攻击优先")]
        LowAttack,
        [Description("自己")]
        Self,
    }
    public enum SkillEffectType
    {
        [Description("体力减少")]
        HPReduce,
        [Description("体力增加")]
        HPIncrease,
        [Description("复活")]
        Revive,
    }
    public enum SkillSpellType
    {
        [Description("冷却释放")]
        AfterCooldown,
        [Description("条件释放")]
        InCondition,
    }

    public class Skill
    {
        public int SkillID;
        public string Name;
        public SkillType Type;
        public int TargetNumber;
        public SkillTargetState TargetState;
        public SkillTargetStrategy TargetStrategy;
        public SkillEffectType EffectType;
        public int EffectValue;
        public double EffectProbability;
        public SkillSpellType SpellType;
        public int FirstSpellTurn;
        public int CurrentHPRequire;
        public int UnitCountRequire;        
        public int Cooldown;

        public Skill(int id) {
            this.SkillID = id;
            if (id == 1) {
                this.Name = "愤怒一击";
                this.Type = SkillType.Active;
                this.TargetNumber = 1;
                this.TargetState =  SkillTargetState.EnemyAlive;
                this.TargetStrategy = SkillTargetStrategy.Random;
                this.EffectType = SkillEffectType.HPReduce;
                this.EffectValue = 5;
                this.EffectProbability = 0.8;
                this.SpellType = SkillSpellType.AfterCooldown;
                this.FirstSpellTurn = 1;
                this.CurrentHPRequire = 1;
                this.UnitCountRequire = 1;
                this.Cooldown = 3;
            }
        }
    }
}
