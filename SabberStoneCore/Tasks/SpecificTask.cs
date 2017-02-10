using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Tasks
{
    internal class SpecificTask
    {
        public static ISimpleTask PatchesThePirate
            => ComplexTask.Create(
                new ConditionTask(EntityType.HERO, SelfCondition.IsNotBoardFull),
                new FlagTask(true, new RemoveFromDeck(EntityType.SOURCE)),
                new FlagTask(true, new SummonTask())
            );

        public static ISimpleTask FrostwolfBanner
            => ComplexTask.Create(
                new CountTask(EntityType.MINIONS_NOSOURCE),
                new BuffAttackHealthNumberTask(EntityType.SOURCE)
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

        public static ISimpleTask JusticarTrueheart
            => ComplexTask.Create(
                new IncludeTask(EntityType.SOURCE),
                new FuncTask(p =>
                {
                    var controller = p[0].Controller;
                    switch (controller.Hero.Power.Card.Id)
                    {
                        case "CS1h_001":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_PRIEST"))};
                        case "CS2_017":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_DRUID"))};
                        case "CS2_034":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_MAGE"))};
                        case "CS2_049":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_SHAMAN"))};
                        case "CS2_056":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_WARLOCK"))};
                        case "CS2_083b":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_ROGUE"))};
                        case "CS2_101":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_PALADIN"))};
                        case "CS2_102":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_WARRIOR"))};
                        case "DS1h_292":
                            return new List<IPlayable> {Entity.FromCard(controller, Cards.FromId("AT_132_HUNTER"))};
                    }
                    return new List<IPlayable>();
                }),
                new ReplaceHeroPower()
            );

        public static ISimpleTask RandomPotionToHand()
            => ComplexTask.Create(
                new FuncCardIdsTask(p => new List<string>
                {
                    "CFM_021",
                    "CFM_065",
                    "CFM_620",
                    "CFM_603",
                    "CFM_661",
                    "CFM_604",
                    "CFM_662",
                    "CFM_611",
                    "CFM_608",
                    "CFM_094"
                }),
                new RandomCardIdFromListTask(),
                new AddStackTo(EntityType.HAND));
    }
}