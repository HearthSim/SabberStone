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
                .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                .TriggerEffect(GameTag.HEROPOWER_ACTIVATIONS_THIS_TURN, 1)
                .SingleTask(task)
                .Build();
        }

        public static Trigger FriendlySpellTargetingMe(ISimpleTask task)
        {
            return new TriggerBuilder().Create()
                .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell), RelaCondition.IsTargetingMe, RelaCondition.IsFriendly)
                .FastExecution(true)
                .TriggerEffect(GameTag.JUST_PLAYED, 1)
                .SingleTask(task)
                .Build();
        }

        public static Trigger MinionAttacksAndTargetMinion(params ISimpleTask[] list)
        {
            var taskList = new List<ISimpleTask>
            {
                new IncludeTask(EntityType.SOURCE),
                new FuncTask(p =>
                {
                    var result = new List<IPlayable>();
                    var minion = p[0] as Minion;
                    if (minion == null)
                        return result;
                    var target = minion.Game.IdEntityDic[minion.ProposedDefender] as Minion;
                    if (target != null)
                        result.Add(target);
                    return result;
                })
            };
            taskList.AddRange(list);

            return new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.ATTACKING, -1)
                        .SingleTask(StateTaskList<ISimpleTask>.Chain(taskList.ToArray()))
                        .Build();
        }
    }
}
