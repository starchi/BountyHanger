using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    /// <summary>
    /// 战斗类
    /// 用于构建一场战斗的实例
    /// </summary>
    public class Combat
    {
        /// <summary>
        /// 战斗的玩家队伍
        /// </summary>
        public PlayerTeam PlayerTeam;
        /// <summary>
        /// 战斗的怪兽队伍
        /// </summary>
        public MonsterTeam MonsterTeam;
        /// <summary>
        /// 记录战斗日志
        /// </summary>
        public string[] CombatLog;
        /// <summary>
        /// 当前阅读的战斗日志下标
        /// </summary>
        public int LogIndex;

        /// <summary>
        /// 战斗构造函数
        /// 初始化一场战斗
        /// </summary>
        /// <param name="player">玩家队伍</param>
        /// <param name="monster">怪物队伍</param>
        public Combat(PlayerTeam player, MonsterTeam monster)
        {
            this.PlayerTeam = player;
            this.MonsterTeam = monster;
        }

        /// <summary>
        /// 开始战斗
        /// 自动根据双方阵容进行战斗过程
        /// 记录战斗日志到CombatLog中
        /// todo:返回战斗结果
        /// </summary>
        public string BeginCombat()
        {
            StringBuilder logBuilder = new StringBuilder();
            string result;
            int turn = 0;
            logBuilder.AppendLine("战斗开始");
            logBuilder.AppendLine("==================================================");
            while (turn < 100)
            {
                turn++;//回合计数
                logBuilder.AppendLine("第" + turn + "回合：");
                //如果有一方尚未行动完毕，则继续顺序行动，否则进入下一回合
                while (PlayerTeam.ActionState != PlayerActionState.AllDone || MonsterTeam.ActionState != MonsterActionState.AllDone)
                {
                    //玩家怪物轮流行动
                    result = PlayerTeam.DoNextAction(turn, MonsterTeam);
                    if (result != "")
                    {
                        logBuilder.AppendLine(result);
                    }
                    if (PlayerTeam.IsDetroyed || MonsterTeam.IsDetroyed)
                    {
                        logBuilder.AppendLine("战斗结束，" + ((PlayerTeam.IsDetroyed) ? "玩家失败" : "玩家胜利") + "！");
                        logBuilder.AppendLine("==================================================");
                        return logBuilder.ToString();
                    }
                    result = MonsterTeam.DoNextAction(turn, PlayerTeam);
                    if (result != "")
                    {
                        logBuilder.AppendLine(result);
                    }
                    if (PlayerTeam.IsDetroyed || MonsterTeam.IsDetroyed)
                    {
                        logBuilder.AppendLine("战斗结束：" + ((PlayerTeam.IsDetroyed) ? "玩家失败" : "玩家胜利") + "！");
                        logBuilder.AppendLine("==================================================");
                        return logBuilder.ToString();
                    }
                }
                logBuilder.AppendLine("--------------------------------------------------");
                PlayerTeam.ResetActionState();
                MonsterTeam.ResetActionState();
            }
            logBuilder.AppendLine("战斗结束：玩家部队已经筋疲力尽了，暂且撤退。");
            logBuilder.AppendLine("==================================================");
            return logBuilder.ToString();
        }
    }
}
