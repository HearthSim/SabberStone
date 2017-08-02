using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Tasks
{
    internal partial class ComplexTask
    {
        public static ISimpleTask Create(ISimpleTask task, int times)
        {
            var list = new ISimpleTask[times];
            for (var i = 0; i < times; i++)
                list[i] = task;
            return Create(list);
        }

        public static ISimpleTask Create(params ISimpleTask[] list)
        {
            return StateTaskList<ISimpleTask>.Chain(list);
        }

        public static ISimpleTask Freeze(EEntityType entityType)
            => new SetGameTagTask(EGameTag.FROZEN, 1, entityType);

        public static ISimpleTask WindFury(EEntityType entityType)
            => new SetGameTagTask(EGameTag.WINDFURY, 1, entityType);

        public static ISimpleTask Taunt(EEntityType entityType)
            => new SetGameTagTask(EGameTag.TAUNT, 1, entityType);

        public static ISimpleTask DivineShield(EEntityType entityType)
            => new SetGameTagTask(EGameTag.DIVINE_SHIELD, 1, entityType);

        public static ISimpleTask Charge(EEntityType entityType)
            => new SetGameTagTask(EGameTag.CHARGE, 1, entityType);

        public static ISimpleTask Stealth(EEntityType entityType)
            => new SetGameTagTask(EGameTag.STEALTH, 1, entityType);

        public static ISimpleTask DiscardRandomCard(int amount)
            => Create(
                new RandomTask(amount, EEntityType.HAND),
                new DiscardTask(EEntityType.STACK));

        public static ISimpleTask DrawCardTask()
            => Create(
                new SplitTask(1, EEntityType.DECK),
                new RandomTask(1, EEntityType.STACK),
                new DrawCardTask());

        public static ISimpleTask DamageRandomTargets(int targets, EEntityType type, int amount, bool spellDmg = false)
            => Create(
                new SplitTask(targets, type),
                new RandomTask(targets, EEntityType.STACK),
                //new RandomTask(targets, type),
                new DamageTask(amount, EEntityType.STACK, spellDmg));

        public static ISimpleTask DestroyRandomTargets(int targets, EEntityType type)
            => Create(
                new RandomTask(targets, type),
                new DestroyTask(EEntityType.STACK));

        public static ISimpleTask RandomCardCopyToHandFrom(EEntityType entityType)
            => Create(
                new RandomTask(1, entityType),
                new CopyTask(EEntityType.STACK, 1),
                new AddStackTo(EEntityType.HAND));

        public static ISimpleTask IfComboElse(ISimpleTask combo)
            => Create(
                new ConditionTask(EEntityType.SOURCE, SelfCondition.IsComboActive),
                new FlagTask(true, combo));

        public static ISimpleTask IfComboElse(ISimpleTask combo, ISimpleTask noCombo)
            => Create(
                new ConditionTask(EEntityType.SOURCE, SelfCondition.IsComboActive),
                new FlagTask(true, combo),
                new FlagTask(false, noCombo));

        public static ISimpleTask True(ISimpleTask task)
            => new FlagTask(true, task);

        public static ISimpleTask False(ISimpleTask task)
            => new FlagTask(false, task);

        public static ISimpleTask RemoveFromGameTag(EGameTag tag, int amount, EEntityType type)
            => Create(
                new GetGameTagTask(tag, type),
                new MathSubstractionTask(amount),
                new SetGameTagNumberTask(tag, type));

        public static ISimpleTask ExcessManaCheck
            => Create(
                new ConditionTask(EEntityType.SOURCE, SelfCondition.IsManaCrystalFull),
                new FlagTask(true, new AddCardTo("CS2_013t", EEntityType.HAND)),
                new FlagTask(false, Create(
                    new ConditionTask(EEntityType.SOURCE, SelfCondition.IsRemaningManaFull),
                    new FlagTask(true, new AddCardTo("CS2_013t", EEntityType.HAND))))
                );

        public static ISimpleTask SpendAllManaTask(ISimpleTask task)
        {
            return Create(
                new GetControllerManaTask(),
                task,
                new IncludeTask(EEntityType.SOURCE),
                new FuncPlayablesTask(p =>
                {
                    var controller = p[0].Controller;
                    if (controller != null)
                    {
                        controller.UsedMana =
                            controller.BaseMana
                            + controller.TemporaryMana
                            - controller.OverloadLocked;
                    }
                    return null;
                }));
        }

        public static ISimpleTask BuffRandomMinion(EEntityType type, Enchant buff, params SelfCondition[] list)
        {
            return Create(
                new IncludeTask(type),
                new FilterStackTask(list),
                new RandomTask(1, EEntityType.STACK),
                new BuffTask(buff, EEntityType.STACK));
        }

        public static ISimpleTask BuffRandomMinion(EEntityType type, Enchant buff, params RelaCondition[] list)
        {
            return Create(
                new IncludeTask(type),
                new FilterStackTask(EEntityType.SOURCE, list),
                new RandomTask(1, EEntityType.STACK),
                new BuffTask(buff, EEntityType.STACK));
        }

        public static ISimpleTask SummonRandomMinion(EEntityType type, params RelaCondition[] list)
        {
            return Create(
                new IncludeTask(type),
                new FilterStackTask(EEntityType.SOURCE, list),
                new RandomTask(1, EEntityType.STACK),
                new ConditionTask(EEntityType.HERO, SelfCondition.IsNotBoardFull),
                new FlagTask(true, new RemoveFromDeck(EEntityType.STACK)),
                new FlagTask(true, new SummonTask()));
        }

        public static ISimpleTask SummonOpRandomMinion(EEntityType type, params RelaCondition[] list)
        {
            return Create(
                new IncludeTask(type),
                new FilterStackTask(EEntityType.SOURCE, list),
                new RandomTask(1, EEntityType.STACK),
                new ConditionTask(EEntityType.OP_HERO, SelfCondition.IsNotBoardFull),
                new FlagTask(true, new RemoveFromDeck(EEntityType.STACK)),
                new FlagTask(true, new SummonOpTask()));
        }

        public static ISimpleTask SummonRandomMinionThatDied()
        {
            return Create(
                new IncludeTask(EEntityType.GRAVEYARD),
                new FilterStackTask(SelfCondition.IsMinion),
                new RandomTask(1, EEntityType.STACK),
                new CopyTask(EEntityType.STACK, 1),
                new SummonTask());
        }

        public static ISimpleTask SummonRandomMinion(EGameTag tag, int value)
        {
            return Create(
                new RandomMinionTask(tag, value),
                new SummonTask());
        }

        public static ISimpleTask DrawFromDeck(params SelfCondition[] list)
        {
            return Create(
                new IncludeTask(EEntityType.DECK),
                new FilterStackTask(list),
                new RandomTask(1, EEntityType.STACK),
                new DrawStackTask());
        }

        public static ISimpleTask SummonJadeGolem()
        {
            return Create(
                new IncludeTask(EEntityType.SOURCE),
                new FuncPlayablesTask(p =>
                {
                    var controller = p[0].Controller;
                    var jadeGolem = controller.JadeGolem;
                    controller.JadeGolem++;
                    // TODO maybee better implement it with CFM_712_t + int
                    var jadeGolemStr = new List<string>
                    {
                        "CFM_712_t01",
                        "CFM_712_t02",
                        "CFM_712_t03",
                        "CFM_712_t04",
                        "CFM_712_t05",
                        "CFM_712_t06",
                        "CFM_712_t07",
                        "CFM_712_t08",
                        "CFM_712_t09",
                        "CFM_712_t10",
                        "CFM_712_t11",
                        "CFM_712_t12",
                        "CFM_712_t13",
                        "CFM_712_t14",
                        "CFM_712_t15",
                        "CFM_712_t16",
                        "CFM_712_t17",
                        "CFM_712_t18",
                        "CFM_712_t19",
                        "CFM_712_t20",
                        "CFM_712_t21",
                        "CFM_712_t22",
                        "CFM_712_t23",
                        "CFM_712_t24",
                        "CFM_712_t25",
                        "CFM_712_t26",
                        "CFM_712_t27",
                        "CFM_712_t28",
                        "CFM_712_t29",
                        "CFM_712_t30",
                    };
                    var golemStr = jadeGolem <= jadeGolemStr.Count ? jadeGolemStr[jadeGolem] : jadeGolemStr[29];
                    return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId(golemStr))};
                }),
                new SummonTask());
        }

        public static ISimpleTask Secret(params ISimpleTask[] list)
        {
            var secretList = list.ToList();
            secretList.Add(new SetGameTagTask(EGameTag.REVEALED, 1, EEntityType.SOURCE));
            secretList.Add(new MoveToGraveYard(EEntityType.SOURCE));
            return StateTaskList<ISimpleTask>.Chain(secretList.ToArray());
        }

        public static ISimpleTask SummonRandomMinionNumberTag(EGameTag tag)
        {
            return Create(
                new RandomMinionNumberTask(tag),
                new SummonTask());
        }

    }
}