using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;
using System;

namespace SabberStoneCore.Tasks
{
	internal partial class ComplexTask
	{
		public static ISimpleTask Create(ISimpleTask task, int times)
		{
			ISimpleTask[] list = new ISimpleTask[times];
			for (int i = 0; i < times; i++)
				list[i] = task;
			return Create(list);
		}

		public static ISimpleTask Create(params ISimpleTask[] list)
		{
			return StateTaskList<ISimpleTask>.Chain(list);
		}

		
		internal static ISimpleTask LifeSteal(EntityType entityType)
			=> new SetGameTagTask(GameTag.LIFESTEAL, 1, entityType);

		public static ISimpleTask Freeze(EntityType entityType)
			=> new SetGameTagTask(GameTag.FROZEN, 1, entityType);

		public static ISimpleTask WindFury(EntityType entityType)
			=> new SetGameTagTask(GameTag.WINDFURY, 1, entityType);

		public static ISimpleTask Taunt(EntityType entityType)
			=> new SetGameTagTask(GameTag.TAUNT, 1, entityType);

		public static ISimpleTask DivineShield(EntityType entityType)
			=> new SetGameTagTask(GameTag.DIVINE_SHIELD, 1, entityType);

		public static ISimpleTask Poisonous(EntityType entityType)
			=> new SetGameTagTask(GameTag.POISONOUS, 1, entityType);

		public static ISimpleTask Charge(EntityType entityType)
			=> new SetGameTagTask(GameTag.CHARGE, 1, entityType);

		public static ISimpleTask Stealth(EntityType entityType)
			=> new SetGameTagTask(GameTag.STEALTH, 1, entityType);

		public static ISimpleTask DiscardRandomCard(int amount)
			=> Create(
				new RandomTask(amount, EntityType.HAND),
				new DiscardTask(EntityType.STACK));

		public static ISimpleTask DrawCardTask()
			=> Create(
				new SplitTask(1, EntityType.DECK),
				new RandomTask(1, EntityType.STACK),
				new DrawCardTask());

		public static ISimpleTask DamageRandomTargets(int targets, EntityType type, int amount, bool spellDmg = false)
			=> Create(
				new SplitTask(targets, type),
				new RandomTask(targets, EntityType.STACK),
				//new RandomTask(targets, type),
				new DamageTask(amount, EntityType.STACK, spellDmg));

		public static ISimpleTask DestroyRandomTargets(int targets, EntityType type)
			=> Create(
				new RandomTask(targets, type),
				new DestroyTask(EntityType.STACK));

		public static ISimpleTask RandomCardCopyToHandFrom(EntityType entityType)
			=> Create(
				new RandomTask(1, entityType),
				new CopyTask(EntityType.STACK, 1),
				new AddStackTo(EntityType.HAND));

		public static ISimpleTask IfComboElse(ISimpleTask combo)
			=> Create(
				new ConditionTask(EntityType.SOURCE, SelfCondition.IsComboActive),
				new FlagTask(true, combo));

		public static ISimpleTask IfComboElse(ISimpleTask combo, ISimpleTask noCombo)
			=> Create(
				new ConditionTask(EntityType.SOURCE, SelfCondition.IsComboActive),
				new FlagTask(true, combo),
				new FlagTask(false, noCombo));

		public static ISimpleTask True(ISimpleTask task)
			=> new FlagTask(true, task);

		public static ISimpleTask False(ISimpleTask task)
			=> new FlagTask(false, task);

		public static ISimpleTask RemoveFromGameTag(GameTag tag, int amount, EntityType type)
			=> Create(
				new GetGameTagTask(tag, type),
				new MathSubstractionTask(amount),
				new SetGameTagNumberTask(tag, type));

		public static ISimpleTask ExcessManaCheck
			=> Create(
				new ConditionTask(EntityType.SOURCE, SelfCondition.IsManaCrystalFull),
				new FlagTask(true, new AddCardTo("CS2_013t", EntityType.HAND)),
				new FlagTask(false, Create(
					new ConditionTask(EntityType.SOURCE, SelfCondition.IsRemaningManaFull),
					new FlagTask(true, new AddCardTo("CS2_013t", EntityType.HAND))))
				);

		public static ISimpleTask SpendAllManaTask(ISimpleTask task)
		{
			return Create(
				new GetControllerManaTask(),
				task,
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
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

		public static ISimpleTask BuffRandomMinion(EntityType type, Enchant buff, params SelfCondition[] list)
		{
			return Create(
				new IncludeTask(type),
				new FilterStackTask(list),
				new RandomTask(1, EntityType.STACK),
				new BuffTask(buff, EntityType.STACK));
		}

		public static ISimpleTask BuffRandomMinion(EntityType type, Enchant buff, params RelaCondition[] list)
		{
			return Create(
				new IncludeTask(type),
				new FilterStackTask(EntityType.SOURCE, list),
				new RandomTask(1, EntityType.STACK),
				new BuffTask(buff, EntityType.STACK));
		}

		public static ISimpleTask SummonRandomMinion(EntityType type, params RelaCondition[] list)
		{
			return Create(
				new IncludeTask(type),
				new FilterStackTask(EntityType.SOURCE, list),
				new RandomTask(1, EntityType.STACK),
				new ConditionTask(EntityType.HERO, SelfCondition.IsNotBoardFull),
				new FlagTask(true, new RemoveFromDeck(EntityType.STACK)),
				new FlagTask(true, new SummonTask()));
		}

		public static ISimpleTask SummonOpRandomMinion(EntityType type, params RelaCondition[] list)
		{
			return Create(
				new IncludeTask(type),
				new FilterStackTask(EntityType.SOURCE, list),
				new RandomTask(1, EntityType.STACK),
				new ConditionTask(EntityType.OP_HERO, SelfCondition.IsNotBoardFull),
				new FlagTask(true, new RemoveFromDeck(EntityType.STACK)),
				new FlagTask(true, new SummonOpTask()));
		}

		public static ISimpleTask SummonRandomMinionThatDied(SelfCondition selfCondition = null)
		{
			return Create(
				new IncludeTask(EntityType.GRAVEYARD),
				new FilterStackTask(SelfCondition.IsMinion, selfCondition),
				new RandomTask(1, EntityType.STACK),
				new CopyTask(EntityType.STACK, 1),
				new SummonTask());
		}

		public static ISimpleTask SummonRandomMinion(GameTag tag, int value)
		{
			return Create(
				new RandomMinionTask(tag, value),
				new SummonTask());
		}

		public static ISimpleTask DrawFromDeck(params SelfCondition[] list)
		{
			return Create(
				new IncludeTask(EntityType.DECK),
				new FilterStackTask(list),
				new RandomTask(1, EntityType.STACK),
				new DrawStackTask());
		}

		public static ISimpleTask SummonJadeGolem(SummonSide side)
		{
			return Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					int jadeGolem = controller.JadeGolem;
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
					string golemStr = jadeGolem <= jadeGolemStr.Count ? jadeGolemStr[jadeGolem] : jadeGolemStr[29];
					return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId(golemStr)) };
				}),
				new SummonTask(side));
		}

		public static ISimpleTask Secret(params ISimpleTask[] list)
		{
			var secretList = list.ToList();
			secretList.Add(new SetGameTagTask(GameTag.REVEALED, 1, EntityType.SOURCE));
			secretList.Add(new MoveToGraveYard(EntityType.SOURCE));
			return StateTaskList<ISimpleTask>.Chain(secretList.ToArray());
		}

		public static ISimpleTask SummonRandomMinionNumberTag(GameTag tag)
		{
			return Create(
				new RandomMinionNumberTask(tag),
				new SummonTask());
		}

	}
}
