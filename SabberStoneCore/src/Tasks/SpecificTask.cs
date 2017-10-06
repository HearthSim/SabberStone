using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	internal class SpecificTask
	{
		public static ISimpleTask LivingMana
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					var result = new List<IPlayable>();
					Controller controller = p[0].Controller;
					int manaCrystal = (new[] { controller.BoardZone.MaxSize - controller.BoardZone.Count, controller.BaseMana }).Min();
					for (int i = 0; i < manaCrystal; i++)
					{
						result.Add(Entity.FromCard(controller, Cards.FromId("UNG_111t1")));
					}
					return result;
				}),
				new CountTask(EntityType.STACK),
				new SummonCopyTask(EntityType.STACK),
				new MathMultiplyTask(-1),
				new ManaCrystalEmptyTask(0, false, true)
			);

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
				new FuncPlayablesTask(list =>
				{
					var result = new List<IPlayable>();
					Controller controller = list[0].Controller;
					List<string> entourage = list[0].Card.Entourage;
					entourage.ForEach(p => result.Add(Entity.FromCard(controller, Cards.FromId(p))));
					return result;
				}),
				new RandomTask(1, EntityType.STACK),
				new SummonTask());

		public static ISimpleTask TotemicCall
			=> ComplexTask.Create(
				new IncludeTask(EntityType.HERO),
				new FuncPlayablesTask(list =>
				{
					var result = new List<IPlayable>();
					Controller controller = list[0].Controller;
					List<string> entourage = controller.Hero.Power.Card.Entourage;
					var notContained = new List<string>();
					var idsOnBoard = controller.BoardZone.GetAll.Select(p => p.Card.Id).ToList();
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
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					switch (controller.Hero.Power.Card.Id)
					{
						case "CS1h_001":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_PRIEST")) };
						case "CS2_017":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_DRUID")) };
						case "CS2_034":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_MAGE")) };
						case "CS2_049":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_SHAMAN")) };
						case "CS2_056":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_WARLOCK")) };
						case "CS2_083b":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_ROGUE")) };
						case "CS2_101":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_PALADIN")) };
						case "CS2_102":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_WARRIOR")) };
						case "DS1h_292":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_HUNTER")) };
					}
					return new List<IPlayable>();
				}),
				new ReplaceHeroPower()
			);

		public static ISimpleTask RandomHunterSecretPlay
			=> ComplexTask.Create(
				new IncludeTask(EntityType.TARGET),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					var activeSecrets = controller.SecretZone.GetAll.Select(secret => secret.Card.Id).ToList();
					//activeSecrets.Add(p[0].Card.Id);
					IEnumerable<Card> cards = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER] : Cards.Wild[CardClass.HUNTER];
					IEnumerable<Card> cardsList = cards.Where(card => card.Type == CardType.SPELL && card.Tags.ContainsKey(GameTag.SECRET) && !activeSecrets.Contains(card.Id));
					IPlayable spell = Entity.FromCard(controller, Util.Choose<Card>(cardsList.ToList()));
					spell.ApplyEnchantments(EnchantmentActivation.SECRET_OR_QUEST, Zone.PLAY);
					controller.SecretZone.Add(spell);
					controller.Game.OnRandomHappened(true);
					return new List<IPlayable>();
				})
			);

		public static ISimpleTask Simulacrum
			=> ComplexTask.Create(
				new IncludeTask(EntityType.HAND),
				new FilterStackTask(SelfCondition.IsMinion),
				new FuncPlayablesTask(list =>
				{
					if (!list.Any())
						return new List<IPlayable>();
					int minCost = list.Min(p => p.Cost);
					list.Where(p => p.Cost == minCost).ToList();
					return list.Where(p => p.Cost == minCost).ToList();
				}),
				new RandomTask(1, EntityType.STACK),
				new CopyTask(EntityType.STACK, 1),
				new AddStackTo(EntityType.HAND));

		public static ISimpleTask Frostmourne
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					return p[0].Controller.Opponent.GraveyardZone.GetAll.Where(c => c[GameTag.LAST_AFFECTED_BY] == p[0].Id).ToList();
				}),
				new SummonCopyTask(EntityType.STACK));

		public static ISimpleTask CuriousGlimmerroot
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					IEntity source = p[0];
					Controller controller = p[0].Controller;
					Controller opponent = p[0].Controller.Opponent;
					var opStartDeckClassCards = opponent.DeckCards.Where(c => c.Class == opponent.BaseClass).ToList();
					var allClassCards = Cards.FormatTypeClassCards(controller.Game.FormatType)[opponent.BaseClass].Where(c => c.Class == opponent.BaseClass).ToList();
					var result = new List<Card> { Util.Choose(opStartDeckClassCards) };
					IEnumerable<string> Ids = opStartDeckClassCards.Select(c => c.Id);
					while (result.Count < 3)
					{
						Card pick = Util.Choose(allClassCards);
						if (Ids.Contains(pick.Id) || result.Contains(pick))
						{
							allClassCards.Remove(pick);
							continue;
						}
						result.Add(pick);
					}
					
					for (int i = 0; i < 3; i++)
					{
						int j = Util.Random.Next(i, 3);
						Card temp = result[i];
						result[i] = result[j];
						result[j] = temp;
					}
					Actions.Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.GLIMMERROOT, result, null);
					controller.Game.OnRandomHappened(true);
					return p;
				}));

		public static ISimpleTask RazaTheChained
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					p[0].Game.Enchants.Add(
							new Enchants.Enchant
							{
								Game = p[0].Game,
								Owner = p[0].Controller.Hero,
								ApplyConditions = new List<RelaCondition>
								{
									RelaCondition.IsOther(SelfCondition.IsHeroPower),
									RelaCondition.IsFriendly
								},

								Effects = new Dictionary<GameTag, int>
								{
									[GameTag.COST] = 0
								},
								FixedValueFunc = owner => 0
							});
					return new List<IPlayable>();
				}));

		public static ISimpleTask BuildABeast
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					IEnumerable<Card> all = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5) : Cards.Wild[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5);
					var firstBeasts = new List<Card>();
					var secondBeasts = new List<Card>();
					foreach (Card card in all)
					{
						if (card.Enchantments != null)
							firstBeasts.Add(card);
						else
							secondBeasts.Add(card);
					}

					var first = new List<Card>();
					var second = new List<Card>();
					int numToSelect = 3;
					int numLeft = firstBeasts.Count;
					foreach (Card item in firstBeasts)
					{
						double prob = numToSelect / (double)numLeft;
						if (Util.Random.NextDouble() < prob)
						{
							first.Add(item);
							numToSelect--;
							if (numToSelect == 0)
								break;
						}
						numLeft--;
					}
					numToSelect = 3;
					numLeft = secondBeasts.Count;
					foreach (Card item in secondBeasts)
					{
						double prob = numToSelect / (double)numLeft;
						if (Util.Random.NextDouble() < prob)
						{
							second.Add(item);
							numToSelect--;
							if (numToSelect == 0)
								break;
						}
						numLeft--;
					}


					Actions.Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, first, null);
					Actions.Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, second, null);

					return p;
				}));
	}
}


			
