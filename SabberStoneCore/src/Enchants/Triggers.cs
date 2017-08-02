using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
    internal class Triggers
    {
        public static Trigger Inspire(ISimpleTask task)
        {
            return new TriggerBuilder().Create()
                .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                .TriggerEffect(EGameTag.HEROPOWER_ACTIVATIONS_THIS_TURN, 1)
                .SingleTask(task)
                .Build();
        }

        public static Trigger FriendlySpellTargetingMe(ISimpleTask task)
        {
            return new TriggerBuilder().Create()
                .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell), RelaCondition.IsTargetingMe, RelaCondition.IsFriendly)
                .FastExecution(true)
                .TriggerEffect(EGameTag.JUST_PLAYED, 1)
                .SingleTask(task)
                .Build();
        }

        public static Trigger MinionAttacksAndTarget(params ISimpleTask[] list)
        {
            var taskList = new List<ISimpleTask>
            {
                new IncludeTask(EEntityType.SOURCE),
                new FuncPlayablesTask(p =>
                {
                    var result = new List<IPlayable>();
                    var minion = p[0] as Minion;
                    if (minion == null)
                        return result;
                    var target = minion.Game.IdEntityDic[minion.ProposedDefender] as ICharacter;
                    if (target != null)
                        result.Add(target);
                    return result;
                })
            };
            taskList.AddRange(list);

            return new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInZone(EZone.PLAY), SelfCondition.IsNotSilenced)
                        .TriggerEffect(EGameTag.ATTACKING, -1)
                        .SingleTask(StateTaskList<ISimpleTask>.Chain(taskList.ToArray()))
                        .Build();
        }
    }
}
