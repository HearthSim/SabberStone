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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks
{
	internal static class SpecificTask
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
				new FuncNumberTask(p =>
				{
					Minion[] minions = p.Controller.BoardZone.GetAll();
					var notContained = new List<Card>(4);
					for (int i = 0; i < p.Card.Entourage.Length; i++)
					{
						string id = p.Card.Entourage[i];
						bool flag = false;
						for (int j = 0; j < minions.Length; j++)
						{
							Minion m = minions[j];
							if (id == m.Card.Id)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
							notContained.Add(Cards.FromId(id));
					}
					Entity.FromCard(p.Controller, notContained[Util.Random.Next(notContained.Count)],
						null, p.Controller.BoardZone);
					p.Game.OnRandomHappened(true);
					return 0;
				}));

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

		public static ISimpleTask Doppelgangster
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					var s = (Minion) p[0];
					Controller c = s.Controller;
					Minion left = null;
					Minion right = null;
					int space = c.BoardZone.MaxSize - c.BoardZone.Count;
					switch (s.Card.Id)
					{
						case "CFM_668":
							if (space > 0)
								left = (Minion) Entity.FromCard(c, Cards.FromId("CFM_668t"));
							if (space > 1)
								right = (Minion) Entity.FromCard(c, Cards.FromId("CFM_668t2"));
							break;
						case "CFM_668t":
							if (space > 0)
								left = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668t2"));
							if (space > 1)
								right = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668"));
							break;
						case "CFM_668t2":
							if (space > 0)
								left = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668t"));
							if (space > 1)
								right = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668"));
							break;
						default:
							throw new NotImplementedException();
					}
					if (left != null)
					{
						Generic.SummonBlock.Invoke(c.Game, left, s.ZonePosition);
						s.AppliedEnchantments?.ForEach(e => Enchantment.GetInstance(in c, left, left, e.Card));
						//left[GameTag.ATK] = s[GameTag.ATK];
						//left[GameTag.HEALTH] = s[GameTag.HEALTH];
						left.AttackDamage = s.AttackDamage;
						left.BaseHealth = s.BaseHealth;

						if (right != null)
						{
							Generic.SummonBlock.Invoke(c.Game, right, s.ZonePosition + 1);
							s.AppliedEnchantments?.ForEach(e => Enchantment.GetInstance(in c, right, right, e.Card));
							//right[GameTag.ATK] = s[GameTag.ATK];
							//right[GameTag.HEALTH] = s[GameTag.HEALTH];
							right.AttackDamage = s.AttackDamage;
							right.BaseHealth = s.BaseHealth;
						}
					}
					return null;
				})
			);

		public static ISimpleTask MayorNoggenfogger =>
			ComplexTask.Create(
				new IncludeTask(EntityType.TARGET),
				new FuncPlayablesTask(list =>
				{
					IPlayable p = list[0];
					//int boardCount = p.Controller.BoardZone.CountExceptUntouchables;
					int opBoardCount = p.Controller.Opponent.BoardZone.CountExceptUntouchables;

					if (p is ICharacter c && c.IsAttacking)
					{
						int index = Util.Random.Next(opBoardCount + 1);
						c.Game.CurrentEventData.EventTarget =
							index == opBoardCount
								? (IPlayable)c.Controller.Opponent.Hero
								: c.Controller.Opponent.BoardZone.HasUntouchables
									? c.Controller.Opponent.BoardZone.GetAll(null)[index]
									: c.Controller.Opponent.BoardZone[index];

						c.Game.ProposedDefender = c.Game.CurrentEventData.EventTarget.Id;
						c.Game.OnRandomHappened(true);
						return null;
					}

					p.CardTarget = Util.Choose((List<ICharacter>) p.ValidPlayTargets).Id;
					p.Game.OnRandomHappened(true);
					return null;
				}));

		// TODO The cache should be managed separately when using different decks 
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

					if (_glimmerrootMemory1.Count == 0)
						return null;

					//var result = new List<Card> { Util.Choose(_glimmerrootMemory1) };
					//while (result.Count < 3)
					//{
					//	Card pick = Util.Choose(_glimmerrootMemory3);
					//	if (_glimmerrootMemory2.Contains(pick.AssetId) || result.Contains(pick))
					//		continue;
					//	result.Add(pick);
					//}

					var result = new Card[3];
					result[0] = Util.Choose(_glimmerrootMemory1);
					int count = 1;
					do
					{
						Card pick = Util.Choose(_glimmerrootMemory3);
						if (_glimmerrootMemory2.Contains(pick.AssetId) || result.Contains(pick)) continue;
						result[count] = pick;
						count++;
					} while (count < 3);

					for (int i = 0; i < 3; i++)
					{
						int j = Util.Random.Next(i, 3);
						Card temp = result[i];
						result[i] = result[j];
						result[j] = temp;
					}
					Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.GLIMMERROOT, result, null, null);
					controller.Game.OnRandomHappened(true);
					return p;
				}));
		private static ReadOnlyCollection<Card> _glimmerrootMemory1;
		private static HashSet<int> _glimmerrootMemory2;
		private static ReadOnlyCollection<Card> _glimmerrootMemory3;
		private static readonly object locker = new object();

		public static ISimpleTask UngoroPack
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					int space = controller.MaxHandSize - controller.HandZone.Count;
					if (space >= 5)
						space = 5;
					else if (space == 0)
						return null;
					//var pack = new List<IPlayable>(space);

					if (_ungoroPackMemory == null)
					{
						lock (locker)
						{
							var dic = new Dictionary<Rarity, Card[]>(4);
							var ungCards = Cards.All.Where(c => c.Set == CardSet.UNGORO && c.Collectible && !c.IsQuest).ToArray();
							dic.Add(Rarity.COMMON, ungCards.Where(c => c.Rarity == Rarity.COMMON).ToArray());
							dic.Add(Rarity.RARE, ungCards.Where(c => c.Rarity == Rarity.RARE).ToArray());
							dic.Add(Rarity.EPIC, ungCards.Where(c => c.Rarity == Rarity.EPIC).ToArray());
							dic.Add(Rarity.LEGENDARY, ungCards.Where(c => c.Rarity == Rarity.LEGENDARY).ToArray());
							_ungoroPackMemory = new ReadOnlyDictionary<Rarity, Card[]>(dic);
						}
					}

					for (int i = 0; i < space; ++i)
					{
						var tags = new EntityData
						{
							{GameTag.CREATOR, p[0].Id}
						};
						Rarity rarity;
						double rnd = Util.Random.NextDouble();

						// empirical result
						if (rnd < 0.19)
							rarity = Rarity.LEGENDARY;
						else if (rnd < 0.43)
							rarity = Rarity.EPIC;
						else if (rnd < 0.71)
							rarity = Rarity.RARE;
						else
							rarity = Rarity.COMMON;

						Card[] cards = _ungoroPackMemory[rarity];
						Card pick = cards[Util.Random.Next(cards.Length)];
						IPlayable entity = Entity.FromCard(controller, pick, tags, controller.HandZone);
						entity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, p[0].Id);
						//pack.Add(entity);
					}

					controller.Game.OnRandomHappened(true);
					return null;
				}));
		private static ReadOnlyDictionary<Rarity, Card[]> _ungoroPackMemory;

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
							// In Hearthstone, cards from K & C is not included in the card pool for Build-A-Beast
							// I am not sure whether Sabber should follow the rule or not ...
							IEnumerable<Card> all = controller.Game.FormatType == FormatType.FT_STANDARD ?
								Cards.Standard[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5) :
								Cards.Wild[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5);
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



					//var first = new List<Card>();
					//var second = new List<Card>();
					//int numToSelect = 3;
					//int numLeft = _firstBeastsMemory.Count;
					//foreach (Card item in _firstBeastsMemory)
					//{
					//	double prob = numToSelect / (double)numLeft;
					//	if (Util.Random.NextDouble() < prob)
					//	{
					//		first.Add(item);
					//		numToSelect--;
					//		if (numToSelect == 0)
					//			break;
					//	}
					//	numLeft--;
					//}
					//numToSelect = 3;
					//numLeft = _secondBeastsMemory.Count;
					//foreach (Card item in _secondBeastsMemory)
					//{
					//	double prob = numToSelect / (double)numLeft;
					//	if (Util.Random.NextDouble() < prob)
					//	{
					//		second.Add(item);
					//		numToSelect--;
					//		if (numToSelect == 0)
					//			break;
					//	}
					//	numLeft--;
					//}
					Card[] first = _firstBeastsMemory.ChooseNElements(3);
					Card[] second = _secondBeastsMemory.ChooseNElements(3);


					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, first, null, null);
					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, second, null, null);

					return p;
				}));
		private static IReadOnlyList<Card> _firstBeastsMemory;
		private static IReadOnlyList<Card> _secondBeastsMemory;

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
					var spell = (Spell)Entity.FromCard(controller, Util.Choose(cardsList.ToList()));
					Generic.CastSpell(controller, spell, null, 0, true);
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
					return list.Where(p => p.Cost == minCost).ToArray();
				}),
				new RandomTask(1, EntityType.STACK),
				new CopyTask(EntityType.STACK, Zone.HAND));

		public static ISimpleTask DeathsShadow
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(list =>
				{
					IPlayable p = list[0];
					if (p.Controller.HandZone.IsFull)
						return new List<IPlayable>(0);
					IPlayable entity = Entity.FromCard(p.Controller, Cards.FromId("ICC_827t"),
						new EntityData
						{
							{GameTag.CREATOR, p.Id}
						}, p.Controller.HandZone);
					return new List<IPlayable> {entity};
				}),
				new AddEnchantmentTask("ICC_827e", EntityType.STACK));

		public static ISimpleTask ShadowReflection
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new IncludeTask(EntityType.TARGET, null, true),
				new FuncPlayablesTask(pList =>
				{
					Enchantment e = (Enchantment) pList[0];
					IPlayable previous = (IPlayable) e.Target;
					e.Remove();

					IPlayable newEntity = Generic.ChangeEntityBlock.Invoke(e.Controller, previous, pList[1].Card, false);

					if (newEntity[GameTag.DISPLAYED_CREATOR] == 0)
						newEntity[GameTag.DISPLAYED_CREATOR] = e.Creator.Id;

					Generic.AddEnchantmentBlock(e.Controller, e.Card, e, newEntity, 0, 0, false);

					// TODO choose ones

					return null;
				}));

		public static ISimpleTask ExplosiveRunes
			=> ComplexTask.Create(
				new ConditionTask(EntityType.EVENT_SOURCE, SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
				new FlagTask(true, ComplexTask.Secret(
					new IncludeTask(EntityType.SOURCE),
					new IncludeTask(EntityType.EVENT_SOURCE, null, true),
					new FuncPlayablesTask(list =>
					{
						var target = (Minion) list[1];
						int health = target.Health;
						int amount = 6 + target.Controller.CurrentSpellPower;
						amount *= (int) Math.Pow(2, target.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE]);
						if (health >= amount)
						{
							Generic.DamageCharFunc(list[0], target, 6, true);
							return null;
						}
						target.TakeDamage(list[0], health);
						target.Controller.Hero.TakeDamage(list[0], amount - health);
						return null;
					}))));

		public static ISimpleTask DiamondSpellstone(int i)
		{
			return ComplexTask.Create(
				new IncludeTask(EntityType.GRAVEYARD),
				new FuncPlayablesTask(list =>
				{
					list[0].Game.OnRandomHappened(true);
					return list
						.Where(p => p is Minion && p.ToBeDestroyed)
						.Select(p => p.Card.Id)
						.Distinct()
						.OrderBy(p => Util.Random)
						.Take(i)
						.Select(p => Entity.FromCard(list[0].Controller, Cards.FromId(p)))
						.ToList();
				}),
				new SummonStackTask());
		}

		public static ISimpleTask Kingsbane
			=> ComplexTask.Create(
				new FuncNumberTask(p =>
				{
					var tags = new EntityData
					{
						{GameTag.ATK, p[GameTag.ATK]},
						{GameTag.POISONOUS, p[GameTag.POISONOUS]},
						{GameTag.LIFESTEAL, p[GameTag.LIFESTEAL]}
					};
					IPlayable newWeapon = Entity.FromCard(p.Controller, p.Card, tags);
					p.AppliedEnchantments?.ForEach(e =>
					{
						Enchantment instance = Enchantment.GetInstance(p.Controller, newWeapon, newWeapon, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
						}
					});

					Generic.ShuffleIntoDeck(p.Controller, newWeapon, newWeapon);
					return 0;
				}));

		public static ISimpleTask DarknessCandle
			=> ComplexTask.Create(
				new FuncNumberTask(p =>
				{
					Minion[] targets = p.Controller.Opponent.BoardZone.Where(m => m.Card.Id == "LOOT_526d").ToArray();
					if (targets.Length == 0) return 0;
					for (int i = 0; i < targets.Length; i++)
					{
						ISimpleTask task = DarknessCandleInternal;
						p.Game.TaskQueue.Execute(task, p.Controller, targets[i], null);
					}
					return 0;
				}),
				new DrawTask());
		private static ISimpleTask DarknessCandleInternal
			=> ComplexTask.Create(
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new MathAddTask(1),
				new SetGameTagNumberTask(GameTag.TAG_SCRIPT_DATA_NUM_1, EntityType.SOURCE),
				new SetGameTagNumberTask(GameTag.SCORE_VALUE_2, EntityType.SOURCE),
				new GetGameTagTask(GameTag.TAG_SCRIPT_DATA_NUM_2, EntityType.SOURCE, 0, 1),
				new NumberConditionTask(RelaSign.EQ),
				new FlagTask(true, new FuncNumberTask(q =>
				{
					// TODO ChangeEntityBlock
					q.Card = Cards.FromId("LOOT_526");
					q.Controller.BoardZone.DecrementUntouchablesCount();
					return 0;
				})));

		public static ISimpleTask LynessaSunsorrow
			=> new FuncNumberTask(p =>
			{
				Controller c = p.Controller;
				List<PlayHistoryEntry> history = c.PlayHistory;

				List<PlayHistoryEntry> spellCards = history
					.Where(current => current.SourceController == current.TargetController &&
					                  current.SourceCard.Type == CardType.SPELL)
					.ToList();

				spellCards.Shuffle();
				for (int i = 0; i < spellCards.Count; i++)
				{
					Generic.CastSpell(c, (Spell)Entity.FromCard(c, spellCards[i].SourceCard), (ICharacter)p, spellCards[i].SubOption, true);
					while (c.Choice != null)
						Generic.ChoicePick(c, Util.Choose(c.Choice.Choices));
					if (p.Zone?.Type != Zone.PLAY)
						break;
				}

				c.Game.OnRandomHappened(true);

				return 0;
			});

		public static ISimpleTask SwapDecks
			=> new FuncNumberTask(p =>
			{
				Controller c = p.Controller;
				Controller op = c.Opponent;

				DeckZone temp = c.DeckZone;
				temp.ForEach(x =>
				{
					x.Controller = op;
					x[GameTag.CONTROLLER] = op.PlayerId;
				});
				op.DeckZone.ForEach(x =>
				{
					x.Controller = c;
					x[GameTag.CONTROLLER] = c.PlayerId;
				});
				c.DeckZone = op.DeckZone;
				c.DeckZone.Controller = c;
				op.DeckZone = temp;
				temp.Controller = op;

				return 0;
			});

		public static ISimpleTask TessGreymane
			=> new FuncNumberTask(p =>
			{
				IList<Card> playedCards = p.Controller.PlayHistory
					.Select(e => e.SourceCard)
					.Where(card => card.Class != CardClass.NEUTRAL && card.Class != p.Controller.Hero.Card.Class)
					.ToArray()
					.Shuffle();

				foreach (Card card in playedCards)
				{
					Controller c = p.Controller;
					IPlayable entity = Entity.FromCard(c, card);
					ICharacter randTarget = null;
					if (card.TargetingType != TargetingType.None)
					{
						List<ICharacter> targets = (List<ICharacter>)entity.ValidPlayTargets;

						randTarget = targets.Count > 0 ? Util.RandomElement(targets) : null;

						entity.CardTarget = randTarget?.Id ?? -1;

						if (randTarget != null)
							p.Game.Log(LogLevel.INFO, BlockType.POWER, "Tess Greymane",
							!p.Game.Logging ? "" : $"{entity}'s target is randomly selected to {randTarget}");
					}

					int randChooseOne = SimpleTask.Random.Next(1, 3);

					if (card.HasOverload)
						c.OverloadOwed = card.Overload;

					c.Game.TaskQueue.StartEvent();
					switch (card.Type)
					{
						case CardType.MINION:
							if (c.BoardZone.IsFull) break;
							Generic.SummonBlock.Invoke(c.Game, entity as Minion, -1);
							c.Game.DeathProcessingAndAuraUpdate();
							break;
						case CardType.WEAPON:
							var weapon = entity as Weapon;
							weapon.Card.Power?.Aura?.Activate(weapon);
							weapon.Card.Power?.Trigger?.Activate(weapon);
							c.Hero.AddWeapon(weapon);
							break;
						case CardType.HERO:
							Generic.PlayHero.Invoke(c, entity as Hero, randTarget, randChooseOne);
							break;
						case CardType.SPELL:
							Generic.CastSpell.Invoke(c, entity as Spell, randTarget, randChooseOne, true);
							c.Game.DeathProcessingAndAuraUpdate();
							break;
						default:
							throw new NotImplementedException();
					}
					c.Game.TaskQueue.EndEvent();

					while (c.Choice != null)
					{
						c.Game.TaskQueue.StartEvent();
						Generic.ChoicePick.Invoke(c, Util.Choose(c.Choice.Choices));
						c.Game.ProcessTasks();
						c.Game.TaskQueue.EndEvent();
						c.Game.DeathProcessingAndAuraUpdate();
					}
				}
				return 0;
			});

		public static ISimpleTask Shudderwock
			=> new FuncNumberTask(p =>
			{
				Game game = p.Game;
				Controller c = p.Controller;

				IList<Card> playedCards = c.PlayHistory
					.Select(e => e.SourceCard)
					.Where(card => card[GameTag.BATTLECRY] == 1 && card.AssetId != 48111)
					.ToArray()
					.Shuffle();

				int count = 0;
				foreach (Card card in playedCards)
				{
					IPlayable entity = Entity.FromCard(c, card); // TODO
					ICharacter randTarget = null;
					if (card.TargetingType != TargetingType.None)
					{
						List<ICharacter> targets = (List<ICharacter>) entity.ValidPlayTargets;

						randTarget = targets.Count > 0 ? Util.RandomElement(targets) : null;

						entity.CardTarget = randTarget?.Id ?? -1;

						if (randTarget != null)
							game.Log(LogLevel.INFO, BlockType.POWER, "Shudderwock",
							!game.Logging ? "" : $"{entity}'s target is randomly selected to {randTarget}");
					}

					game.TaskQueue.StartEvent();
					entity.ActivateTask(PowerActivation.POWER, randTarget, 0, p);
					game.ProcessTasks();
					game.TaskQueue.EndEvent();
					game.DeathProcessingAndAuraUpdate();

					while (c.Choice != null)
					{
						c.Game.TaskQueue.StartEvent();
						Generic.ChoicePick.Invoke(c, Util.Choose(c.Choice.Choices));
						c.Game.ProcessTasks();
						c.Game.TaskQueue.EndEvent();
						c.Game.DeathProcessingAndAuraUpdate();
					}

					if (++count == 30) break;

					if (p.ToBeDestroyed || p.Zone.Type != Zone.PLAY)
						break;
				}

				return 0;
			});

		public static ISimpleTask ArcaneKeysmith =>
			new FuncNumberTask(source =>
			{
				if (source.Controller.SecretZone.IsFull) return 0;

				CardClass[] secretClasses = {CardClass.HUNTER, CardClass.PALADIN, CardClass.ROGUE};
				Card[] existing = source.Controller.SecretZone.Select(p => p.Card).ToArray();

				CardClass cls = source.Controller.Hero.Card.Class;

				if (!secretClasses.Contains(cls))
					cls = CardClass.MAGE;

				lock (locker)
				{
					if (_cachedSecrets == null || !_cachedSecrets.ContainsKey(cls))
					{
						if (_cachedSecrets == null)
							_cachedSecrets = new Dictionary<CardClass, Card[]>();

						// This would not work when you would use both format types at the same time in a runtime
						_cachedSecrets.Add(cls, Cards.FormatTypeClassCards(source.Game.FormatType)[cls]
							.Where(p => p.IsSecret && !existing.Contains(p))
							.ToArray());
					}

				}

				Card[] candidates = _cachedSecrets[cls];

				Card[] choices = candidates.ChooseNElements(3);

				if (candidates.Length == 0) return 0;

				Generic.CreateChoiceCards(source.Controller, source, null, ChoiceType.GENERAL, ChoiceAction.CAST, choices, null, null);
				return 0;
			});
		private static Dictionary<CardClass, Card[]> _cachedSecrets;

		public static ISimpleTask GetRandomDrBoomHeroPower =>
			new FuncNumberTask(source =>
			{
				string nextId;
				Controller c = source.Controller;

				if (source is HeroPower currentPower)
				{
					do
					{
						nextId = Util.Choose(DrBoomHeroPowerIds);
					} while (nextId == currentPower.Card.Id);
				}
				else
				{
					nextId = Util.Choose(DrBoomHeroPowerIds);
					currentPower = c.Hero.HeroPower;
				}
				c.SetasideZone.Add(currentPower);
				HeroPower nextPower = (HeroPower)Entity.FromCard(in c, Cards.FromId(nextId));
				c.Hero.HeroPower = nextPower;
				nextPower.Power?.Trigger?.Activate(nextPower);

				return 0;
			});
		private static IReadOnlyList<string> DrBoomHeroPowerIds = Cards.FromId("BOT_238p").Entourage;

		public static readonly ISimpleTask PrismaticLens =
			new FuncNumberTask(p =>
			{
				Controller c = p.Controller;
				ReadOnlySpan<IPlayable> deck = c.DeckZone.GetSpan();
				List<int> minions = new List<int>();
				List<int> spells = new List<int>();
				for (int i = 0; i < deck.Length; i++)
				{
					if (deck[i] is Minion)
						minions.Add(i);
					else if
						(deck[i] is Spell)
						spells.Add(i);
				}

				Random rnd = Util.Random;
				IPlayable minionToDraw = minions.Count == 0 ? null : deck[minions[rnd.Next(minions.Count)]];
				IPlayable spellToDraw = spells.Count == 0 ? null : deck[spells[rnd.Next(spells.Count)]];

				if (minionToDraw == null)
				{
					Generic.Draw(c, spellToDraw);
					return 0;
				}
				if (spellToDraw == null)
				{
					Generic.Draw(c, minionToDraw);
					return 0;
				}

				Generic.Draw(c, minionToDraw);
				Generic.Draw(c, spellToDraw);

				int temp = minionToDraw.Cost;
				minionToDraw.Cost = spellToDraw.Cost;
				spellToDraw.Cost = temp;

				// TODO Enchantment BOT_436e

				return 0;
			});

		public class RenonunceDarkness : SimpleTask
		{
			private static readonly Card EnchantmentCard = Cards.FromId("OG_118e");

			public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
				in TaskStack stack = null)
			{
				// get a new class
				CardClass randClass;
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
					(HeroPower) Entity.FromCard(in controller, heroPowerCard, new EntityData
					{
						{GameTag.CREATOR, source.Id},
						{GameTag.ZONE, (int)Zone.PLAY}
					});
				controller.SetasideZone.Add(controller.Hero.HeroPower);
				controller.Hero.HeroPower = heroPower;

				var cards = Cards.FormatTypeClassCards(game.FormatType)[randClass].Where(p => p.Class == randClass && !p.IsQuest).ToArray();

				// replace cards in hand
				for (int i = 0; i < controller.HandZone.Count; i++)
				{
					IPlayable entity = controller.HandZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;
					controller.HandZone.Remove(entity);
					controller.SetasideZone.Add(entity);
					var tags = new EntityData();
					if (game.History)
					{
						tags.Add(GameTag.ZONE_POSITION, i + 1);
						tags.Add(GameTag.CREATOR, source.Id);
					}

					IPlayable newEntity = Entity.FromCard(in controller, Util.Choose(cards), tags, controller.HandZone, -1, i);
					newEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, source.Id);
					newEntity.Cost = newEntity.Card.Cost - 1;
				}
				

				// replace cards in deck
				for (int i = controller.DeckZone.Count - 1; i >= 0; i--)
				{
					IPlayable entity = controller.DeckZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;

					Card randCard = Util.Choose(cards);
					IPlayable newEntity = Entity.FromCard(in controller, in randCard, null, controller.DeckZone);
					newEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, source.Id);

					//Enchantment.GetInstance(Controller, (IPlayable) Source, newEntity, EnchantmentCard);

					controller.DeckZone.Remove(entity);
					controller.SetasideZone.Add(entity);

					newEntity.Cost = newEntity.Card.Cost - 1;
				}

				game.OnRandomHappened(true);

				return TaskState.COMPLETE;
			}
		}

		public class GetRandomPastLegendary : SimpleTask
		{
			private static readonly CardSet[] WildSets = Cards.WildSets.Except(Cards.StandardSets).ToArray();

			private static readonly Card[] PastLegendaryMinions
				= Cards.All.Where(p => p.Rarity == Rarity.LEGENDARY &&
				                       p.Collectible &&
				                       WildSets.Contains(p.Set) &&
				                       p.Type == CardType.MINION
				                       ).ToArray();

			public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
				in TaskStack stack = null)
			{
				Card pick = Util.Choose(PastLegendaryMinions);
				Entity.FromCard(in controller, in pick, null, controller.HandZone);
				return TaskState.COMPLETE;
			}
		}
	}
}


