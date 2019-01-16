#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	internal static class ComplexTask
	{
		public static ISimpleTask Repeat(ISimpleTask task, int times)
		{
			ISimpleTask[] list = new ISimpleTask[times];
			for (int i = 0; i < times; i++)
				list[i] = task;
			return Create(list);
		}

		public static ISimpleTask Create(params ISimpleTask[] list)
		{
			return StateTaskList.Chain(list);
		}

		internal static ISimpleTask GetRandomEntourageCardToHand(bool opponent = false)
			=> Create(
				new RandomEntourageTask(),
				new AddStackTo(opponent ? EntityType.OP_HAND : EntityType.HAND));

		internal static ISimpleTask LifeSteal(EntityType entityType)
			=> new SetGameTagTask(GameTag.LIFESTEAL, 1, entityType);

		public static ISimpleTask Freeze(EntityType entityType)
			=> new SetGameTagTask(GameTag.FROZEN, 1, entityType);

		public static ISimpleTask WindFury(EntityType entityType)
			=> Create(
				new SetGameTagTask(GameTag.WINDFURY, 1, entityType),
				new IncludeTask(entityType),
				new FuncPlayablesTask(playables =>
				{
					foreach (IPlayable p in playables)
					{
						var m = (Minion) p;
						if (m.NumAttacksThisTurn == 1 && m.IsExhausted)
							m.IsExhausted = false;
					}

					return playables;
				}));

		public static ISimpleTask Taunt(EntityType entityType)
			=> new SetGameTagTask(GameTag.TAUNT, 1, entityType);

		public static ISimpleTask DivineShield(EntityType entityType)
			=> new SetGameTagTask(GameTag.DIVINE_SHIELD, 1, entityType);

		public static ISimpleTask Poisonous(EntityType entityType)
			=> new SetGameTagTask(GameTag.POISONOUS, 1, entityType);

		public static ISimpleTask Charge(EntityType entityType)
			=> Create(
				new SetGameTagTask(GameTag.CHARGE, 1, entityType),
				new IncludeTask(entityType),
				new FuncPlayablesTask(list =>
				{
					foreach (IPlayable p in list)
					{
						var m = (Minion) p;
						if (m.NumAttacksThisTurn == 0 && m.IsExhausted)
							m.IsExhausted = false;
					}
					return null;
				})
			);

		public static ISimpleTask Stealth(EntityType entityType)
			=> new SetGameTagTask(GameTag.STEALTH, 1, entityType);

		public static ISimpleTask DiscardRandomCard(int amount)
			=> Create(
				new RandomTask(amount, EntityType.HAND),
				new DiscardTask(EntityType.STACK));

		public static ISimpleTask AddRandomShamanSpell
			=> Create(
				new RandomCardTask(CardType.SPELL, CardClass.SHAMAN),
				new AddStackTo(EntityType.HAND));

		public static ISimpleTask DrawCardTask()
			=> Create(
				new SplitTask(1, EntityType.DECK),
				new RandomTask(1, EntityType.STACK),
				new DrawCardTask());

		public static ISimpleTask DamageRandomTargets(int targets, EntityType type, int amount, bool spellDmg = false)
			=> Create(
				new SplitTask(targets, type),
				new FilterStackTask(SelfCondition.IsNotDead),
				new RandomTask(targets, EntityType.STACK),
				//new RandomTask(targets, type),
				new DamageTask(amount, EntityType.STACK, spellDmg));

		public static ISimpleTask DestroyRandomTargets(int targets, EntityType type)
			=> Create(
				new IncludeTask(type),
				new FilterStackTask(SelfCondition.IsNotDead),
				new RandomTask(targets, EntityType.STACK),
				new DestroyTask(EntityType.STACK));

		public static ISimpleTask RandomCardCopyToHandFrom(EntityType entityType)
			//=> Create(
			//	new RandomTask(1, entityType),
			//	new CopyTask(EntityType.STACK, 1),
			//	new AddStackTo(EntityType.HAND));
			=> Create(
				new RandomTask(1, entityType),
				new CopyTask(EntityType.STACK, Zone.HAND));

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

		public static ISimpleTask BuffRandomMinion(EntityType type, string enchantmentId, params SelfCondition[] list)
		{
			return Create(
				new IncludeTask(type),
				new FilterStackTask(SelfCondition.IsMinion),
				new FilterStackTask(list),
				new RandomTask(1, EntityType.STACK),
				new AddEnchantmentTask(enchantmentId, EntityType.STACK));
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

		public static ISimpleTask SummonRandomMinionThatDied(SelfCondition selfCondition = null, int amount = 1)
		{
			return Create(
				new IncludeTask(EntityType.GRAVEYARD),
				new FilterStackTask(SelfCondition.IsMinion, SelfCondition.IsTagValue(GameTag.TO_BE_DESTROYED, 1), selfCondition),
				new RandomTask(amount, EntityType.STACK),
				new CopyTask(EntityType.STACK, Zone.PLAY));
		}

		public static ISimpleTask SummonRandomMinion(GameTag tag, int value)
		{
			return Create(
				new RandomMinionTask(tag, value),
				new SummonTask());
		}

		public static ISimpleTask DrawFromDeck(int amount, params SelfCondition[] list)
		{
			return Create(
				new IncludeTask(EntityType.DECK),
				new FilterStackTask(list),
				new RandomTask(amount, EntityType.STACK),
				new DrawStackTask());
		}

		public static ISimpleTask PutSecretFromDeck =>
			Create(
				new ConditionTask(EntityType.SOURCE, SelfCondition.IsZoneCount(Zone.SECRET, 5)),
				new FlagTask(false, Create(
					new IncludeTask(EntityType.DECK),
					new FilterStackTask(SelfCondition.IsSecret),
					new FuncPlayablesTask(stack =>
					{
						if (stack.Count == 0)
							return null;

						Controller c = stack[0].Controller;
						do
						{
							IPlayable pick = Util.Choose((List<IPlayable>)stack);
							if (c.SecretZone.Any(p => p.Card.AssetId == pick.Card.AssetId))
							{
								stack.Remove(pick);
								continue;
							}

							c.DeckZone.Remove(pick);
							pick.Power.Trigger?.Activate(pick);
							c.SecretZone.Add((Spell) pick);
							if (c == c.Game.CurrentPlayer)
								pick.IsExhausted = true;
							break;

						} while (stack.Count > 0);

						return null;
					}))));

		public static ISimpleTask AddRandomOpClassCardToHand =>
			Create(
				new RandomCardTask(EntityType.OP_HERO),
				new AddStackTo(EntityType.HAND));

		// TODO maybee better implement it with CFM_712_t + int
		private static readonly IReadOnlyList<string> JadeGolemStr = new []
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

		public static ISimpleTask SummonJadeGolem(SummonSide side)
		{
			return Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					int jadeGolem = controller.JadeGolem;
					controller.JadeGolem = jadeGolem + 1;
					
					return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId(jadeGolem < 30 ? JadeGolemStr[jadeGolem] : JadeGolemStr[29])) };
				}),
				new SummonTask(side));
		}

		public static ISimpleTask Secret(params ISimpleTask[] list)
		{
			var secretList = list.ToList();
			secretList.Add(new SetGameTagTask(GameTag.REVEALED, 1, EntityType.SOURCE));
			secretList.Add(new MoveToGraveYard(EntityType.SOURCE));
			return StateTaskList.Chain(secretList.ToArray());
		}

		public static ISimpleTask SummonRandomMinionNumberTag(GameTag tag)
		{
			return Create(
				new RandomMinionNumberTask(tag),
				new SummonTask());
		}

		public static ISimpleTask ProgressSpellStoneUpdate(string cardId)
		{
			return Create(
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new MathAddTask(1),
				new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, 0, 1),
				new NumberConditionTask(RelaSign.GEQ),
				new FlagTask(true, Create(
					new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
					new ChangeEntityTask(cardId))));
		}

		public static ISimpleTask ProgressSpellStoneUpdateUsingEventNumber(string cardId)
		{
			return Create(
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new GetEventNumberTask(1),
				new MathNumberIndexTask(0, 1, MathOperation.ADD),
				new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, 0, 1),
				new NumberConditionTask(RelaSign.GEQ),
				new FlagTask(true, Create(
					new SetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, 0, EntityType.SOURCE),
					new ChangeEntityTask(cardId))));
		}

		public static ISimpleTask RecursiveTask(ConditionTask repeatCondition, params ISimpleTask[] tasks)
		{
			ISimpleTask[] taskList = new ISimpleTask[tasks.Length + 2];
			tasks.CopyTo(taskList, 0);
			taskList[tasks.Length] = repeatCondition;
			taskList[tasks.Length + 1] = 
				new FlagTask(true,
				new FuncNumberTask(p =>
				{
					p.ActivateTask(PowerActivation.POWER);
					return 0;
				}
				));
			return StateTaskList.Chain(taskList);
		}

		public static ISimpleTask Conditional(EntityType type, SelfCondition condition, ISimpleTask trueTask,
			ISimpleTask falseTask = null)
		{
			var tasks = new List<ISimpleTask>
			{
				new ConditionTask(type, condition),
				new FlagTask(true, trueTask)
			};

			if (falseTask != null)
				tasks.Add(new FlagTask(false, falseTask));

			return Create(tasks.ToArray());
		}
	}
}
