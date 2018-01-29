﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Kettle;

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


		public static ISimpleTask TotemicCall
			=> ComplexTask.Create(
				new IncludeTask(EntityType.HERO),
				new FuncPlayablesTask(list =>
				{
					var result = new List<IPlayable>();
					Controller controller = list[0].Controller;
					List<string> entourage = controller.Hero.HeroPower.Card.Entourage;
					var notContained = new List<string>();
					var idsOnBoard = controller.BoardZone.Select(p => p.Card.Id).ToList();
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
					switch (controller.Hero.HeroPower.Card.Id)
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
					var activeSecrets = controller.SecretZone.Select(secret => secret.Card.Id).ToList();
					//activeSecrets.Add(p[0].Card.Id);
					IEnumerable<Card> cards = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER] : Cards.Wild[CardClass.HUNTER];
					IEnumerable<Card> cardsList = cards.Where(card => card.Type == CardType.SPELL && card.Tags.ContainsKey(GameTag.SECRET) && !activeSecrets.Contains(card.Id));
					var spell = (Spell) Entity.FromCard(controller, Util.Choose(cardsList.ToList()));
					//spell.ApplyPowers(PowerActivation.SECRET_OR_QUEST, Zone.PLAY);
					spell.ActivateTask();
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
					return p[0].Controller.Opponent.GraveyardZone.Where(c => c[GameTag.LAST_AFFECTED_BY] == p[0].Id).ToList();
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
					if (_glimmerrootMemory1 == null)
					{
						lock (locker)
						{
							var opClassCards = new List<Card>();
							_glimmerrootMemory2 = new HashSet<int>();
							_glimmerrootMemory3 = Cards.FormatTypeClassCards(controller.Game.FormatType)[opponent.BaseClass].Where(c => c.Class == opponent.BaseClass).ToList().AsReadOnly();
							foreach (Card card in opponent.DeckCards)
							{
								if (card.Class != opponent.BaseClass)
									continue;
								if (_glimmerrootMemory2.Contains(card.AssetId))
									continue;
								opClassCards.Add(card);
								_glimmerrootMemory2.Add(card.AssetId);
							}
							_glimmerrootMemory1 = opClassCards.AsReadOnly();
						}
					}

					var result = new List<Card> { Util.Choose(_glimmerrootMemory1) };
					while (result.Count < 3)
					{
						Card pick = Util.Choose(_glimmerrootMemory3);
						if (_glimmerrootMemory2.Contains(pick.AssetId) || result.Contains(pick))
							continue;
						result.Add(pick);
					}

					for (int i = 0; i < 3; i++)
					{
						int j = Util.Random.Next(i, 3);
						Card temp = result[i];
						result[i] = result[j];
						result[j] = temp;
					}
					Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.GLIMMERROOT, result, null);
					controller.Game.OnRandomHappened(true);
					return p;
				}));
		private static ReadOnlyCollection<Card> _glimmerrootMemory1;
		private static HashSet<int> _glimmerrootMemory2;
		private static ReadOnlyCollection<Card> _glimmerrootMemory3;
		private static readonly object locker = new object();


		public static ISimpleTask RazaTheChained
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					//p[0].Game.OldEnchants.Add(
					//		new Enchants.OldEnchant
					//		{
					//			Game = p[0].Game,
					//			Owner = p[0].Controller.Hero,
					//			ApplyConditions = new List<RelaCondition>
					//			{
					//				RelaCondition.IsOther(SelfCondition.IsHeroPower),
					//				RelaCondition.IsFriendly
					//			},

					//			Effects = new Dictionary<GameTag, int>
					//			{
					//				[GameTag.COST] = 0
					//			},
					//			FixedValueFunc = owner => 0
					//		});
					return new List<IPlayable>();
				}));

		public static ISimpleTask BuildABeast
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;

					if (_firstBeastsMemory == null)
					{
						lock (locker)
						{
							IEnumerable<Card> all = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5) : Cards.Wild[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5);
							var firstBeasts = new List<Card>();
							var secondBeasts = new List<Card>();
							foreach (Card card in all)
							{
								if (card.Power != null)
									firstBeasts.Add(card);
								else
									secondBeasts.Add(card);
							}

							_firstBeastsMemory = firstBeasts.AsReadOnly();
							_secondBeastsMemory = secondBeasts.AsReadOnly();
						}
					}



					var first = new List<Card>();
					var second = new List<Card>();
					int numToSelect = 3;
					int numLeft = _firstBeastsMemory.Count;
					foreach (Card item in _firstBeastsMemory)
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
					numLeft = _secondBeastsMemory.Count;
					foreach (Card item in _secondBeastsMemory)
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


					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, first, null);
					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, second, null);

					return p;
				}));
		private static ReadOnlyCollection<Card> _firstBeastsMemory;
		private static ReadOnlyCollection<Card> _secondBeastsMemory;


		public class RenonunceDarkness : SimpleTask
		{
			private static readonly Card EnchantmentCard = Cards.FromId("OG_118e");
			private static readonly Effect CostReduceEffect = Effects.ReduceCost(1);

			public override TaskState Process()
			{
				// get a new class
				CardClass randClass = 0;
				do
				{
					randClass = (CardClass) Random.Next(2, 11);
				} while (randClass == CardClass.WARLOCK);
					
				// replace Hero Power
				Card heroPowerCard = null;
				switch (randClass)
				{
					case CardClass.DRUID:
						heroPowerCard = Cards.FromId("CS2_017");
						break;
					case CardClass.HUNTER:
						heroPowerCard = Cards.FromId("DS1h_292");
						break;
					case CardClass.MAGE:
						heroPowerCard = Cards.FromId("CS2_034");
						break;
					case CardClass.PALADIN:
						heroPowerCard = Cards.FromId("CS2_101");
						break;
					case CardClass.PRIEST:
						heroPowerCard = Cards.FromId("CS1h_001");
						break;
					case CardClass.ROGUE:
						heroPowerCard = Cards.FromId("CS2_083b");
						break;
					case CardClass.SHAMAN:
						heroPowerCard = Cards.FromId("CS2_049");
						break;
					case CardClass.WARRIOR:
						heroPowerCard = Cards.FromId("CS2_102");
						break;
				}
				HeroPower heroPower =
					(HeroPower) Entity.FromCard(Controller, heroPowerCard, new EntityData.Data
					{
						{GameTag.CREATOR, Source.Id},
						{GameTag.ZONE, (int)Zone.PLAY}
					});
				Controller.SetasideZone.Add(Controller.Hero.HeroPower);
				Controller.Hero.HeroPower = heroPower;

				var cards = Cards.FormatTypeClassCards(Game.FormatType)[randClass].Where(p => p.Class == randClass).ToList();

				// replace cards in hand
				for (int i = 0; i < Controller.HandZone.Count; i++)
				{
					IPlayable entity = Controller.HandZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;
					Controller.HandZone.Remove(entity);
					Controller.SetasideZone.Add(entity);
					var tags = new EntityData.Data
					{
						{GameTag.ZONE_POSITION, i + 1},
					};
					if (Game.History)
						tags.Add(GameTag.CREATOR, Source.Id);
					IPlayable newEntity = Entity.FromCard(Controller, Util.Choose(cards), tags, Controller.HandZone, -1, i);
					newEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, Source.Id);
					CostReduceEffect.Apply(newEntity.AuraEffects);
				}

				// replace cards in deck
				for (int i = Controller.DeckZone.Count - 1; i >= 0; i--)
				{
					IPlayable entity = Controller.DeckZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;

					var tags = new EntityData.Data
					{
						{GameTag.ZONE, (int) Zone.DECK},
						{GameTag.CONTROLLER, Controller.PlayerId},
						{GameTag.ENTITY_ID, Controller.Game.NextId}
					};

					Card randCard = Util.Choose(cards);
					IPlayable newEntity = null;
					switch (randCard.Type)
					{
						case CardType.MINION:
							newEntity = new Minion(Controller, randCard, tags);
							break;
						case CardType.SPELL:
							newEntity = new Spell(Controller, randCard, tags);
							break;
						case CardType.WEAPON:
							newEntity = new Weapon(Controller, randCard, tags);
							break;
						case CardType.HERO:
							newEntity = new Hero(Controller, randCard, tags);
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}

					Game.IdEntityDic.Add(newEntity.Id, newEntity);

					if (Game.History)
					{
						Game.PowerHistory.Add(new PowerHistoryFullEntity
						{
							Entity = new PowerHistoryEntity
							{
								Id = newEntity.Id,
								Name = "",
								Tags = new Dictionary<GameTag, int>(tags)
							}
						});

						Enchantment.GetInstance(Controller, (IPlayable) Source, newEntity, EnchantmentCard);
					}

					Controller.DeckZone.Remove(entity);
					Controller.SetasideZone.Add(entity);
					Controller.DeckZone.Add(newEntity, i);

					CostReduceEffect.Apply(newEntity.AuraEffects);
				}

				return TaskState.COMPLETE;
			}

			public override ISimpleTask Clone()
			{
				return new RenonunceDarkness();
			}
		}
	}
}


