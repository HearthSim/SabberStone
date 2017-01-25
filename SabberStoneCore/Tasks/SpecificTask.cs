using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.SimpleTasks.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Tasks
{
    internal class SpecificTask
    {
        public static ISimpleTask PatchesThePirate
            => ComplexTask.Create(
                new RemoveFromDeck(EntityType.SOURCE),
                new SummonTask()
            );

        public static ISimpleTask FrostwolfBanner
            => ComplexTask.Create(
                new CountTask(EntityType.MINIONS_NOSOURCE),
                new BuffAttackHealthNumberTask(EntityType.SOURCE)
            );

        public static ISimpleTask HourOfTwilight
            => ComplexTask.Create(
                new CountTask(EntityType.HAND_NOSOURCE),
                new BuffHealthNumberTask(EntityType.SOURCE)
            );

        public static ISimpleTask HourOfCorruption
            => ComplexTask.Create(
                new CountTask(EntityType.HAND_NOSOURCE),
                new BuffAttackNumberTask(EntityType.SOURCE)
            );

        public static ISimpleTask AnimalCompanion
            => ComplexTask.Create(
                new IncludeTask(EntityType.SOURCE),
                new FuncTask(list =>
                {
                    var result = new List<IPlayable>();
                    var controller = list[0].Controller;
                    var entourage = list[0].Card.Entourage;
                    entourage.ForEach(p => result.Add(Entity.FromCard(controller, Cards.FromId(p))));
                    return result;
                }),
                new RandomTask(1, EntityType.STACK),
                new SummonTask());

        public static ISimpleTask TotemicCall
            => ComplexTask.Create(
                new IncludeTask(EntityType.HERO),
                new FuncTask(list =>
                {
                    var result = new List<IPlayable>();
                    var controller = list[0].Controller;
                    var entourage = controller.Hero.Power.Card.Entourage;
                    var notContained = new List<string>();
                    var idsOnBoard = controller.Board.GetAll.Select(p => p.Card.Id).ToList();
                    entourage.ForEach(p =>
                    {
                        if (!idsOnBoard.Contains(p))
                        {
                            notContained.Add(p);
                        }
                    });
                    notContained.ForEach(p => result.Add(Entity.FromCard(controller, Cards.FromId(p))));
                    return result;
                }),
                new RandomTask(1, EntityType.STACK),
                new SummonTask());

        public static ISimpleTask Betrayal
            => ComplexTask.Create(
                new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
                new IncludeTask(EntityType.OP_MINIONS),
                new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
                new DamageNumberTask(EntityType.STACK));
    }
}