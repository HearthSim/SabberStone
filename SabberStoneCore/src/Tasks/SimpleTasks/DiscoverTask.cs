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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum DiscoverType
	{
		BASIC_HEROPOWERS,
		DRAGON,
		OP_DECK,
		BASIC_TOTEM,
		MINION,
		DECK_MINION,
		SPELL_RANDOM,
		SPELL,
		DEATHRATTLE,
		ONE_COST,
		THREE_COST,
		BEAST,
		MECHANICAL,
		ARTIFACT,
		DRUID_ROGUE_SHAMAN,
		MAGE_PRIEST_WARLOCK,
		OVERLOAD,
		TAUNT,
		HUNTER_PALADIN_WARRIOR,
		MURLOC,
		SECRET,
		ELEMENTAL,
		ALL,
		ELEMENTAL_INVOCATION,
		OWN_SPELL,
		COST_8_MORE_SUMMON,
		OP_HERO,
		DIED_THIS_GAME,
		BRANCHING_PATHS,
		LEGENDARY_MINIONS,
		BATTLECRY,
		DEMON,
		OP_DECK_MINION,
		DEATHRATTLE_MINIONS,
		SPELL_COSTS_5_OR_MORE
	}

	public class DiscoverTask : SimpleTask
	{
		private static readonly ConcurrentDictionary<DiscoverType, (Card[][], ChoiceAction)>
			CachedDiscoverySets =
				new ConcurrentDictionary<DiscoverType, (Card[][], ChoiceAction)>();

		private readonly DiscoverType _discoverType;
		private readonly Card _enchantmentCard;
		private readonly int _numberOfChoices = 3;
		private readonly ISimpleTask _taskTodo;

		public DiscoverTask(DiscoverType discoverType, string enchantmentId = null, int numberOfChoices = 3)
		{
			_discoverType = discoverType;
			_numberOfChoices = numberOfChoices;
			if (enchantmentId != null)
				_enchantmentCard = Cards.FromId(enchantmentId);
		}

		public DiscoverTask(DiscoverType discoverType, ISimpleTask afterDiscoverTask)
		{
			_discoverType = discoverType;
			_taskTodo = afterDiscoverTask;
		}

		private DiscoverTask(DiscoverType type, Card enchantmentCard, ISimpleTask afterDiscoverTask, int number)
		{
			_discoverType = type;
			_enchantmentCard = enchantmentCard;
			_taskTodo = afterDiscoverTask;
			_numberOfChoices = number;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{

			// Sets of cards to discover.
			Card[][] cardsToDiscover =
				Discovery(in game, controller, in _discoverType, out ChoiceAction choiceAction);

			Card[] result;
			Random rnd;

			// 2 Sets means Class cards / Neutral cards.
			// 3 Sets means Tri-Class discovers. (Gangs)
			switch (cardsToDiscover.Length)
			{
				case 1:
					Card[] distinct = cardsToDiscover[0].Distinct().ToArray();
					if (_numberOfChoices >= distinct.Length)
						result = distinct;
					else
					{
						rnd = Util.Random;
						result = new Card[_numberOfChoices];
						Card pick;
						for (int i = 0; i < result.Length; i++)
						{
							do
							{
								pick = cardsToDiscover[0][rnd.Next(cardsToDiscover[0].Length)];
							} while (result.Contains(pick));

							result[i] = pick;
						}
					}
					break;
				case 2:
					rnd = Util.Random;
					int classCount = cardsToDiscover[1].Length;
					int neutralCount = cardsToDiscover[0].Length;
					result = new Card[_numberOfChoices];
					for (int i = 0; i < result.Length; i++)
					{
						int roll = rnd.Next(neutralCount + (classCount << 2));
						Card pick;
						if (roll < neutralCount)
							pick = cardsToDiscover[0][rnd.Next(cardsToDiscover[0].Length)];
						else
							pick = cardsToDiscover[1][rnd.Next(cardsToDiscover[1].Length)];

						bool contains = false;
						for (int j = 0; j < i; j++)
							if (result[j] == pick)
								contains = true;

						if (contains)
						{
							i--;
							continue;
						}

						result[i] = pick;

						if (roll < neutralCount)
							neutralCount--;
						else
							classCount--;
					}
					break;
				case 3:
					result = new Card[3];
					rnd = Util.Random;
					for (int i = 0; i < result.Length; i++)
					{
						Card pick;
						bool contains = false;
						do
						{
							pick = cardsToDiscover[i][rnd.Next(cardsToDiscover[i].Length)];
							for (int j = 0; j < i; j++)
								if (result[j] == pick)
									contains = true;
						} while (contains);

						result[i] = pick;
					}
					break;
				default:
					throw new NotImplementedException();
			}

			// TODO work on it ...
			//if (game.Splitting)
			//{
			//    ProcessSplit(cardsToDiscover, choiceAction);
			//}


			if (result.Length == 0)
				game.Log(LogLevel.INFO, BlockType.PLAY, "DiscoverTask",
					!game.Logging ? "" : $"Found no potential cards to use for {_discoverType}");
			else
				Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, choiceAction,
					result, _enchantmentCard, _taskTodo);

			return TaskState.COMPLETE;
		}

		private void ProcessSplit(Game game, Controller controller, IEntity source, Card[][] cardsToDiscover,
			ChoiceAction choiceAction)
		{
			int neutralCnt = cardsToDiscover[0].Length;
			int classCnt = 0;
			var uniqueList = new List<Card>(cardsToDiscover[0]);

			if (cardsToDiscover.Length > 1)
			{
				classCnt = cardsToDiscover[1].Length;
				uniqueList.AddRange(cardsToDiscover[1]);
			}

			List<IEnumerable<Card>> combinations = Util.GetDiscoverSets(uniqueList).ToList();

			game.Log(LogLevel.INFO, BlockType.PLAY, "DiscoverTask",
				!game.Logging
					? ""
					: $"... found {combinations.Count} discovery splits [class: {classCnt}, neutral: {neutralCnt}]");
			combinations.ForEach(p =>
			{
				Game cloneGame = game.Clone();
				Controller cloneController = cloneGame.ControllerById(controller.Id);
				bool success = Generic.CreateChoiceCards.Invoke(cloneController, source, null, ChoiceType.GENERAL,
					choiceAction, p.ToArray(), null, _taskTodo);
				cloneGame.TaskQueue.CurrentTask.State = TaskState.COMPLETE;
			});
		}

		private Card[][] Discovery(in Game game, Controller controller, in DiscoverType discoverType,
			out ChoiceAction choiceAction)
		{
			if (!CachedDiscoverySets.TryGetValue(discoverType, out (Card[][], ChoiceAction) result))
			{
				FormatType format = game.FormatType;

				switch (discoverType)
				{
					case DiscoverType.DRUID_ROGUE_SHAMAN:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							GetTriClass(in format, CardClass.DRUID, CardClass.ROGUE, CardClass.SHAMAN);
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.MAGE_PRIEST_WARLOCK:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							GetTriClass(in format, CardClass.MAGE, CardClass.PRIEST, CardClass.WARLOCK);
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.HUNTER_PALADIN_WARRIOR:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetTriClass(in format, CardClass.HUNTER, CardClass.PALADIN,
							CardClass.WARRIOR);
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.BASIC_HEROPOWERS:
					{
						choiceAction = ChoiceAction.HEROPOWER;
						Card[][] cardSets =
						{
							Cards.HeroCards().Where(p => p != controller.Hero.Card)
								.Select(p => Cards.FromAssetId(p[GameTag.HERO_POWER])).ToArray()
						};
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.DRAGON:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.DRAGON));

						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.OVERLOAD:
					{
						choiceAction = ChoiceAction.HAND;
						IEnumerable<Card> cardSet = Cards.FormatTypeCards(game.FormatType);
						Card[][] cardSets = {cardSet.Where(p => p.HasOverload).ToArray()};

						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.TAUNT:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p[GameTag.TAUNT] == 1));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.SECRET:
					{
						choiceAction = ChoiceAction.HAND;
						CardClass classForSecret =
							controller.BaseClass == CardClass.PALADIN
							|| controller.BaseClass == CardClass.MAGE
							|| controller.BaseClass == CardClass.HUNTER
								? controller.BaseClass
								: CardClass.PALADIN;
						Card[][] cardSets = GetClassCard(in format, classForSecret,
							list => list.Where(p => p[GameTag.SECRET] == 1));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.BEAST:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.BEAST));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.MURLOC:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.MURLOC));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.ELEMENTAL:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.ELEMENTAL));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.MECHANICAL:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.MECHANICAL));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.DEMON:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Race == Race.DEMON));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.ALL:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							GetFilter(in format, in controller, list => list.Where(p => p.Cost >= 0));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.ARTIFACT:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
						{
							new []
							{
								Cards.FromId("LOEA16_3"),
								Cards.FromId("LOEA16_4"),
								Cards.FromId("LOEA16_5")
							}
						};
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.ELEMENTAL_INVOCATION:
					{
						choiceAction = ChoiceAction.CAST;
						Card[][] cardSets =
						{
							new []
							{
								Cards.FromId("UNG_211a"),
								Cards.FromId("UNG_211b"),
								Cards.FromId("UNG_211c"),
								Cards.FromId("UNG_211d")
							}
						};
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.MINION:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Type == CardType.MINION));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.DECK_MINION:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							{controller.DeckZone.Where(p => p is Minion).Select(p => p.Card).ToArray()};
						return cardSets;
					}
					case DiscoverType.OP_DECK_MINION:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							{controller.Opponent.DeckZone.Where(p => p is Minion).Select(p => p.Card).ToArray()};
						return cardSets;
					}
					case DiscoverType.DEATHRATTLE:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p[GameTag.DEATHRATTLE] == 1));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.DEATHRATTLE_MINIONS:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p[GameTag.DEATHRATTLE] == 1 && p.Type == CardType.MINION));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.BATTLECRY:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p[GameTag.BATTLECRY] == 1 && p.Type == CardType.MINION));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.ONE_COST:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							GetFilter(in format, in controller, list => list.Where(p => p.Cost == 1));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.THREE_COST:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							GetFilter(in format, in controller, list => list.Where(p => p.Cost == 3));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.SPELL:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Type == CardType.SPELL));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.SPELL_COSTS_5_OR_MORE:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Type == CardType.SPELL && p.Cost >= 5));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.SPELL_RANDOM:
					{
						choiceAction = ChoiceAction.SPELL_RANDOM;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Type == CardType.SPELL && !p.HideStat));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.OWN_SPELL:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets =
							{controller.DeckZone.Where(p => p is Spell).Select(p => p.Card).ToArray()};
						return cardSets;
					}
					case DiscoverType.BASIC_TOTEM:
					{
						choiceAction = ChoiceAction.SUMMON;
						Card[][] cardSets =
						{
							new []
							{
								Cards.FromId("AT_132_SHAMANa"),
								Cards.FromId("AT_132_SHAMANb"),
								Cards.FromId("AT_132_SHAMANc"),
								Cards.FromId("AT_132_SHAMANd")
							}
						};
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.COST_8_MORE_SUMMON:
					{
						choiceAction = ChoiceAction.SUMMON;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Cost >= 8 && p.Type == CardType.MINION));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.OP_DECK:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = { controller.Opponent.DeckZone.Select(p => p.Card).ToArray()};
						return cardSets;
					}
					case DiscoverType.OP_HERO:
					{
						choiceAction = ChoiceAction.HAND;
						Card[][] cardSets = GetClassCard(in format, controller.Opponent.HeroClass, list => list);
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.DIED_THIS_GAME:
					{
						choiceAction = ChoiceAction.SUMMON;
						Card[][] cardSets =
						{
							controller.GraveyardZone.Where(p => p.ToBeDestroyed && p.Card.Type == CardType.MINION)
								.Select(p => p.Card).ToArray()
						};
						return cardSets;
					}
					case DiscoverType.BRANCHING_PATHS:
					{
						choiceAction = ChoiceAction.CAST;
						Card[][] cardSets =
						{
							new []
							{
								Cards.FromId("LOOT_054b"),
								Cards.FromId("LOOT_054c"),
								Cards.FromId("LOOT_054d")
							}
						};
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					case DiscoverType.LEGENDARY_MINIONS:
					{
						choiceAction = ChoiceAction.SUMMON;
						Card[][] cardSets = GetFilter(in format, in controller,
							list => list.Where(p => p.Rarity == Rarity.LEGENDARY && p.Type == CardType.MINION));
						
						CachedDiscoverySets.TryAdd(discoverType, (cardSets, choiceAction));
						return cardSets;
					}
					default:
						throw new ArgumentOutOfRangeException(nameof(discoverType), discoverType, null);
				}
			}

			choiceAction = result.Item2;
			return result.Item1;
		}

		private Card[][] GetClassCard(in FormatType formatType, CardClass heroClass,
			in Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			Dictionary<CardClass, IReadOnlyList<Card>> cardSet = Cards.FormatTypeClassCards(formatType);
			IEnumerable<Card> classCards =
				filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass && !p.IsQuest));
			return new[] {classCards.ToArray()};
		}

		private Card[][] GetTriClass(in FormatType formatType, CardClass class1, CardClass class2, CardClass class3)
		{
			Dictionary<CardClass, IReadOnlyList<Card>> cardSet = Cards.FormatTypeClassCards(formatType);
			return new[]
			{
				cardSet[class1].Where(p => (p.Class == class1 || p.MultiClassGroup != 0) && !p.IsQuest).ToArray(),
				cardSet[class2].Where(p => (p.Class == class2 || p.MultiClassGroup != 0) && !p.IsQuest).ToArray(),
				cardSet[class3].Where(p => (p.Class == class3 || p.MultiClassGroup != 0) && !p.IsQuest).ToArray()
			};
		}

		private Card[][] GetFilter(in FormatType formatType, in Controller controller,
			in Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			Dictionary<CardClass, IReadOnlyList<Card>> cardSet = Cards.FormatTypeClassCards(formatType);
			CardClass heroClass = controller.BaseClass != CardClass.NEUTRAL
				? controller.BaseClass
				: Util.RandomElement(Cards.HeroClasses);
			IEnumerable<Card> nonClassCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class != heroClass));
			IEnumerable<Card> classCards =
				filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass && !p.IsQuest));
			return new[] {nonClassCards.ToArray(), classCards.ToArray()};
		}
	}
}
