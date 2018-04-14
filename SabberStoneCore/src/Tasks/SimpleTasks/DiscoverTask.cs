using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
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
		LEGENDARY_MINIONS
	}
	public class DiscoverTask : SimpleTask
	{
		private static ConcurrentDictionary<DiscoverType, Tuple<List<Card>[], ChoiceAction>> CachedDiscoverySets = new ConcurrentDictionary<DiscoverType, Tuple<List<Card>[], ChoiceAction>>();

		private readonly DiscoverType _discoverType;
		private readonly Card _enchantmentCard;
		private readonly ISimpleTask _taskTodo;
		private readonly int _numberOfChoices = 3;

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

		public override TaskState Process()
		{
			List<Card>[] cardsToDiscover = Discovery(_discoverType, out ChoiceAction choiceAction);

			var totcardsToDiscover = new List<Card>(cardsToDiscover[0]);
			if (cardsToDiscover.Length == 2)
			{
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
			}

			//var resultCards = new List<Card>();
			var resultCards = new Card[_numberOfChoices];

			// standard discover takes 3 random cards from a set of cards
			if (cardsToDiscover.Length < 3)
			{
				if (_numberOfChoices >= totcardsToDiscover.Count)
				{
					//resultCards.AddRange(totcardsToDiscover);
					if (_numberOfChoices != totcardsToDiscover.Count)
						resultCards = new Card[totcardsToDiscover.Count];
					totcardsToDiscover.CopyTo(resultCards);
				}
				else
				{
					int count = 0;
					//while (resultCards.Count < 3 && totcardsToDiscover.Count > 0)
					while (count < 3 && totcardsToDiscover.Count > 0)
					{
						Card discoveredCard = Util.Choose(totcardsToDiscover);
						//resultCards.Add(discoveredCard);
						resultCards[count] = discoveredCard;
						count++;
						// remove all cards matching the discovered one, 
						// need because class cards are duplicated 4 x times
						// to have a balance to neutral cards
						// http://hearthstone.gamepedia.com/Discover
						totcardsToDiscover.RemoveAll(p => p == discoveredCard);
					}

					if (count < resultCards.Length)
					{
						var newArray = new Card[count];
						Array.Copy(resultCards, 0, newArray, 0, count);
						resultCards = newArray;
					}
				}
			}
			else
			{
				// tri-class discover takes one random card from each of the three sets
				//foreach (List<Card> classDiscover in cardsToDiscover)
				//{
				//	resultCards.ForEach(p => classDiscover.Remove(p));

				//	resultCards.Add(Util.Choose<Card>(classDiscover));
				//}

				for (int i = 0; i < 3; i++)
				{
					Card pick;
					do
					{
						pick = Util.Choose(cardsToDiscover[i]);
					} while (resultCards.Contains(pick));

					resultCards[i] = pick;
				}
			}

			// TODO work on it ...
			//if (Game.Splitting)
			//{
			//    ProcessSplit(cardsToDiscover, choiceAction);
			//}

			//if (resultCards.Count == 0)
			if (resultCards.Length == 0)
			{
				Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscoverTask",
					!Game.Logging ? "" : $"Found no potential cards to use for {_discoverType}");
			}
			else
			{
				Generic.CreateChoiceCards.Invoke(Controller, Source, null, ChoiceType.GENERAL, choiceAction, resultCards, _enchantmentCard, _taskTodo);
			}

			return TaskState.COMPLETE;
		}

		private void ProcessSplit(List<Card>[] cardsToDiscover, ChoiceAction choiceAction)
		{
			int neutralCnt = cardsToDiscover[0].Count;
			int classCnt = 0;
			var uniqueList = new List<Card>(cardsToDiscover[0]);

			if (cardsToDiscover.Length > 1)
			{
				classCnt = cardsToDiscover[1].Count;
				uniqueList.AddRange(cardsToDiscover[1]);
			}
			var combinations = Util.GetDiscoverSets(uniqueList).ToList();

			Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscoverTask", !Game.Logging ? "" : $"... found {combinations.Count} discovery splits [class: {classCnt}, neutral: {neutralCnt}]");
			combinations.ForEach(p =>
			{
				Game cloneGame = Game.Clone();
				Controller cloneController = cloneGame.ControllerById(Controller.Id);
				bool success = Generic.CreateChoiceCards.Invoke(cloneController, Source, null, ChoiceType.GENERAL, choiceAction, p.ToArray(), null, _taskTodo);
				cloneGame.TaskQueue.CurrentTask.State = TaskState.COMPLETE;
			});

		}

		private List<Card>[] Discovery(DiscoverType discoverType, out ChoiceAction choiceAction)
		{
			if (!CachedDiscoverySets.TryGetValue(discoverType, out Tuple<List<Card>[], ChoiceAction> result))
			{
				switch (discoverType)
				{
					case DiscoverType.DRUID_ROGUE_SHAMAN:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetTriClass(CardClass.DRUID, CardClass.ROGUE, CardClass.SHAMAN);
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.MAGE_PRIEST_WARLOCK:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetTriClass(CardClass.MAGE, CardClass.PRIEST, CardClass.WARLOCK);
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.HUNTER_PALADIN_WARRIOR:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetTriClass(CardClass.HUNTER, CardClass.PALADIN, CardClass.WARRIOR);
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.BASIC_HEROPOWERS:
					{
						choiceAction = ChoiceAction.HEROPOWER;
						List<Card>[] listArray = { Cards.HeroCards().Where(p => p != Controller.Hero.Card).Select(p => Cards.FromAssetId(p[GameTag.HERO_POWER])).ToList() };
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.DRAGON:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Race == Race.DRAGON));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.OVERLOAD:
					{
						choiceAction = ChoiceAction.HAND;
						IEnumerable<Card> cardSet = Cards.FormatTypeCards(Game.FormatType);
						List<Card>[] listArray = { cardSet.Where(p => p.HasOverload).ToList() };
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.TAUNT:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p[GameTag.TAUNT] == 1));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.SECRET:
					{
						choiceAction = ChoiceAction.HAND;
						CardClass classForSecret =
						Controller.BaseClass == CardClass.PALADIN
						|| Controller.BaseClass == CardClass.MAGE
						|| Controller.BaseClass == CardClass.HUNTER
						? Controller.BaseClass
						: CardClass.PALADIN;
						List<Card>[] listArray = GetClassCard(classForSecret, list => list.Where(p => p[GameTag.SECRET] == 1));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.BEAST:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Race == Race.BEAST));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.MURLOC:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Race == Race.MURLOC));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.ELEMENTAL:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Race == Race.ELEMENTAL));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.MECHANICAL:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Race == Race.MECHANICAL));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.ALL:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Cost >= 0));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.ARTIFACT:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = 
						{
							new List<Card>
							{
								Cards.FromId("LOEA16_3"),
								Cards.FromId("LOEA16_4"),
								Cards.FromId("LOEA16_5")
							}
						};
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.ELEMENTAL_INVOCATION:
					{
						choiceAction = ChoiceAction.SPELL;
						List<Card>[] listArray = 
						{
							new List<Card>
							{
								Cards.FromId("UNG_211a"),
								Cards.FromId("UNG_211b"),
								Cards.FromId("UNG_211c"),
								Cards.FromId("UNG_211d")
							}
						};
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.MINION:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Type == CardType.MINION));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.DECK_MINION:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = { Controller.DeckZone.Where(p => p is Minion).Select(p => p.Card).ToList() };
						return listArray;
					}
					case DiscoverType.DEATHRATTLE:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p[GameTag.DEATHRATTLE] == 1));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.ONE_COST:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Cost == 1));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.THREE_COST:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Cost == 3));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.SPELL:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Type == CardType.SPELL));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.SPELL_RANDOM:
					{
						choiceAction = ChoiceAction.SPELL;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Type == CardType.SPELL && !p.HideStat));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.OWN_SPELL:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = { Controller.DeckZone.Where(p => p is Spell).Select(p => p.Card).ToList() };
						return listArray;
					}
					case DiscoverType.BASIC_TOTEM:
					{
						choiceAction = ChoiceAction.SUMMON;
						List<Card>[] listArray =
						{
							new List<Card>
							{
								Cards.FromId("AT_132_SHAMANa"),
								Cards.FromId("AT_132_SHAMANb"),
								Cards.FromId("AT_132_SHAMANc"),
								Cards.FromId("AT_132_SHAMANd")
							}
						};
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.COST_8_MORE_SUMMON:
					{
						choiceAction = ChoiceAction.SUMMON;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Cost >= 8 && p.Type == CardType.MINION));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.OP_DECK:
					{
						choiceAction = ChoiceAction.HAND;
						//List<Card>[] listArray = { Controller.Opponent.DeckZone.Select(p => p.Card).ToList() };
						var deckCards = new List<Card>(Controller.Opponent.DeckZone.Count);
						Controller.Opponent.DeckZone.ForEach(p => deckCards.Add(p.Card));
						List<Card>[] listArray = {deckCards};
						return listArray;
					}
					case DiscoverType.OP_HERO:
					{
						choiceAction = ChoiceAction.HAND;
						List<Card>[] listArray = GetClassCard(Controller.Opponent.HeroClass, list => list);
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.DIED_THIS_GAME:
					{
						choiceAction = ChoiceAction.SUMMON;
						List<Card>[] listArray = { Controller.GraveyardZone.Where(p => p.ToBeDestroyed && p.Card.Type == CardType.MINION).Select(p => p.Card).ToList() };
						return listArray;
					}
					case DiscoverType.BRANCHING_PATHS:
					{
						choiceAction = ChoiceAction.SPELL;
						List<Card>[] listArray =
						{
							new List<Card>
							{
								Cards.FromId("LOOT_054b"),
								Cards.FromId("LOOT_054c"),
								Cards.FromId("LOOT_054d")
							}
						};
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					case DiscoverType.LEGENDARY_MINIONS:
					{
						choiceAction = ChoiceAction.SUMMON;
						List<Card>[] listArray = GetFilter(list => list.Where(p => p.Rarity == Rarity.LEGENDARY && p.Type == CardType.MINION));
						var output = new Tuple<List<Card>[], ChoiceAction>(listArray, choiceAction);
						CachedDiscoverySets.TryAdd(discoverType, output);
						return listArray;
					}
					default:
						throw new ArgumentOutOfRangeException(nameof(discoverType), discoverType, null);
				}
			}

			choiceAction = result.Item2;
			return result.Item1;
		}

		private List<Card>[] GetClassCard(CardClass heroClass, Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			Dictionary<CardClass, IEnumerable<Card>> cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			IEnumerable<Card> classCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass && !p.IsQuest));
			return new[] { classCards.ToList() };
		}

		private List<Card>[] GetTriClass(CardClass class1, CardClass class2, CardClass class3)
		{
			Dictionary<CardClass, IEnumerable<Card>> cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			return new[] { cardSet[class1].Where(p => (p.Class == class1 || p.MultiClassGroup != 0) && !p.IsQuest).ToList(),
							cardSet[class2].Where(p => (p.Class == class2 || p.MultiClassGroup != 0) && !p.IsQuest).ToList(),
							cardSet[class3].Where(p => (p.Class == class3 || p.MultiClassGroup != 0) && !p.IsQuest).ToList()};
		}

		private List<Card>[] GetFilter(Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			Dictionary<CardClass, IEnumerable<Card>> cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			CardClass heroClass = Controller.BaseClass != CardClass.NEUTRAL ? Controller.BaseClass : Util.RandomElement(Cards.HeroClasses);
			IEnumerable<Card> nonClassCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class != heroClass));
			IEnumerable<Card> classCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass && !p.IsQuest));
			return new[] { nonClassCards.ToList(), classCards.ToList() };
		}

		public override ISimpleTask Clone()
		{
			var clone = new DiscoverTask(_discoverType, _enchantmentCard, _taskTodo, _numberOfChoices);
			clone.Copy(this);
			return clone;
		}
	}
}
