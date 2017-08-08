using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
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
		SPELL,
		DEATHRATTLE,
		ONE_COST,
		THREE_COST,
		BEAST,
		MECHANICAL,
		ARTIFACT,
		TRACKING,
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
		OP_HERO
	}
	public class DiscoverTask : SimpleTask
	{
		public DiscoverTask(DiscoverType discoverType, Enchantment enchantment = null)
		{
			DiscoverType = discoverType;
			Enchantment = enchantment;
		}

		public DiscoverType DiscoverType { get; set; }

		public Enchantment Enchantment { get; set; }

		public override TaskState Process()
		{
			var choiceAction = ChoiceAction.INVALID;
			var cardsToDiscover = Discovery(DiscoverType, out choiceAction);

			var totcardsToDiscover = new List<Card>(cardsToDiscover[0]);
			if (cardsToDiscover.Length == 2)
			{
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
				totcardsToDiscover.AddRange(cardsToDiscover[1]);
			}

			var resultCards = new List<Card>();

			// standard discover takes 3 random cards from a set of cards
			if (cardsToDiscover.Length < 3)
			{
				while (resultCards.Count < 3 && totcardsToDiscover.Count > 0)
				{
					var discoveredCard = Util.Choose<Card>(totcardsToDiscover);
					resultCards.Add(discoveredCard);
					// remove all cards matching the discovered one, 
					// need because class cards are duplicated 4 x times
					// to have a balance to neutral cards
					// http://hearthstone.gamepedia.com/Discover
					if (DiscoverType == DiscoverType.TRACKING)
					{
						totcardsToDiscover.Remove(discoveredCard);
					}
					else
					{
						totcardsToDiscover.RemoveAll(p => p == discoveredCard);
					}
				}
			}
			else
			{
				// tri-class discover takes one random card from each of the three sets
				foreach (var classDiscover in cardsToDiscover)
				{
					resultCards.ForEach(p => classDiscover.Remove(p));
					resultCards.Add(Util.Choose<Card>(classDiscover));
				}
			}

			// TODO work on it ...
			//if (Game.Splitting)
			//{
			//    ProcessSplit(cardsToDiscover, choiceAction);
			//}

			// TODO check for the rules class specific vs. non-class specific cards, discovers, like Finders Keepers, and spell creating cards like Spellslinger generate problematic contellations.
			//if (resultCards.Count == 0)
			//{
			//    Game.Log(LogLevel.ERROR, BlockType.PLAY, "DiscoverTask",
			//        $"Found no petential cards to use for {DiscoverType}");
			//    return TaskState.STOP;
			//}

			var success = Generic.CreateChoiceCards.Invoke(Controller, Source, null, ChoiceType.GENERAL, choiceAction, resultCards.ToList(), Enchantment);
			return TaskState.COMPLETE;
		}

		private void ProcessSplit(List<Card>[] cardsToDiscover, ChoiceAction choiceAction)
		{
			var neutralCnt = cardsToDiscover[0].Count;
			var classCnt = 0;
			var uniqueList = new List<Card>(cardsToDiscover[0]);

			if (cardsToDiscover.Length > 1)
			{
				classCnt = cardsToDiscover[1].Count;
				uniqueList.AddRange(cardsToDiscover[1]);
			}
			var combinations = Util.GetDiscoverSets(uniqueList).ToList();

			Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscoverTask", $"... found {combinations.Count} discovery splits [class: {classCnt}, neutral: {neutralCnt}]");
			combinations.ForEach(p =>
			{
				var cloneGame = Game.Clone();
				var cloneController = cloneGame.ControllerById(Controller.Id);
				var success = Generic.CreateChoiceCards.Invoke(cloneController, Source, null, ChoiceType.GENERAL, choiceAction, p.ToList(), null);
				cloneGame.TaskQueue.CurrentTask.State = TaskState.COMPLETE;
			});

		}

		private List<Card>[] Discovery(DiscoverType discoverType, out ChoiceAction choiceAction)
		{
			switch (discoverType)
			{
				case DiscoverType.DRUID_ROGUE_SHAMAN:
					choiceAction = ChoiceAction.HAND;
					return GetTriClass(CardClass.DRUID, CardClass.ROGUE, CardClass.SHAMAN);

				case DiscoverType.MAGE_PRIEST_WARLOCK:
					choiceAction = ChoiceAction.HAND;
					return GetTriClass(CardClass.MAGE, CardClass.PRIEST, CardClass.WARLOCK);

				case DiscoverType.HUNTER_PALADIN_WARRIOR:
					choiceAction = ChoiceAction.HAND;
					return GetTriClass(CardClass.HUNTER, CardClass.PALADIN, CardClass.WARRIOR);

				case DiscoverType.BASIC_HEROPOWERS:
					choiceAction = ChoiceAction.HEROPOWER;
					return new[] { Cards.HeroCards().Where(p => p != Controller.Hero.Card).Select(p => Cards.FromAssetId(p[GameTag.HERO_POWER])).ToList() };

				case DiscoverType.DRAGON:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Race == Race.DRAGON));

				case DiscoverType.OVERLOAD:
					choiceAction = ChoiceAction.HAND;
					var cardSet = Cards.FormatTypeCards(Game.FormatType);
					return new[] { cardSet.Where(p => p.HasOverload).ToList() };

				case DiscoverType.TAUNT:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p[GameTag.TAUNT] == 1));

				case DiscoverType.SECRET:
					choiceAction = ChoiceAction.HAND;
					var classForSecret =
						Controller.HeroClass == CardClass.PALADIN
						|| Controller.HeroClass == CardClass.MAGE
						|| Controller.HeroClass == CardClass.HUNTER
						? Controller.HeroClass
						: CardClass.PALADIN;
					return GetClassCard(classForSecret, list => list.Where(p => p[GameTag.SECRET] == 1));

				case DiscoverType.BEAST:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Race == Race.BEAST));

				case DiscoverType.MURLOC:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Race == Race.MURLOC));

				case DiscoverType.ELEMENTAL:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Race == Race.ELEMENTAL));

				case DiscoverType.MECHANICAL:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Race == Race.MECHANICAL));

				case DiscoverType.ALL:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Cost >= 0));

				case DiscoverType.ARTIFACT:
					choiceAction = ChoiceAction.HAND;
					return new[]
					{
						new List<Card>
						{
							Cards.FromId("LOEA16_3"),
							Cards.FromId("LOEA16_4"),
							Cards.FromId("LOEA16_5")
						}
					};

				case DiscoverType.ELEMENTAL_INVOCATION:
					choiceAction = ChoiceAction.HAND;
					return new[]
					{
						new List<Card>
						{
							Cards.FromId("UNG_211a"),
							Cards.FromId("UNG_211b"),
							Cards.FromId("UNG_211c"),
							Cards.FromId("UNG_211d")
						}
					};

				case DiscoverType.TRACKING:
					choiceAction = ChoiceAction.TRACKING;
					var cards = new List<Card>();
					Controller.DeckZone.GetAll.Take(3).ToList().ForEach(p =>
					{
						Generic.RemoveFromZone(Controller, p);
						Controller.SetasideZone.Add(p);
						cards.Add(p.Card);
					});
					return new[] { cards };

				case DiscoverType.MINION:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Type == CardType.MINION));

				case DiscoverType.DEATHRATTLE:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p[GameTag.DEATHRATTLE] == 1));

				case DiscoverType.ONE_COST:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Cost == 1));

				case DiscoverType.THREE_COST:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Cost == 3));

				case DiscoverType.SPELL:
					choiceAction = ChoiceAction.HAND;
					return GetFilter(list => list.Where(p => p.Type == CardType.SPELL));

				case DiscoverType.OWN_SPELL:
					choiceAction = ChoiceAction.HAND;
					return new[] { Controller.DeckZone.Where(p => p is Spell).Select(p => p.Card).ToList() };

				case DiscoverType.BASIC_TOTEM:
					choiceAction = ChoiceAction.SUMMON;
					return new[]
					{
						new List<Card>
						{
							Cards.FromId("AT_132_SHAMANa"),
							Cards.FromId("AT_132_SHAMANb"),
							Cards.FromId("AT_132_SHAMANc"),
							Cards.FromId("AT_132_SHAMANd")
						}
					};

				case DiscoverType.COST_8_MORE_SUMMON:
					choiceAction = ChoiceAction.SUMMON;
					return GetFilter(list => list.Where(p => p.Cost >= 8 && p.Type == CardType.MINION));

				case DiscoverType.OP_DECK:
					choiceAction = ChoiceAction.HAND;
					return new[] { Controller.Opponent.DeckZone.Select(p => p.Card).ToList() };

				case DiscoverType.OP_HERO:
					choiceAction = ChoiceAction.HAND;
					return GetClassCard(Controller.Opponent.HeroClass, list => list);

				default:
					throw new ArgumentOutOfRangeException(nameof(discoverType), discoverType, null);
			}
		}

		private List<Card>[] GetClassCard(CardClass heroClass, Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			var classCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass));
			return new[] { classCards.ToList() };
		}

		private List<Card>[] GetTriClass(CardClass class1, CardClass class2, CardClass class3)
		{
			var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			return new[] { cardSet[class1].Where(p => p.Class == class1 || p.MultiClassGroup != 0).ToList(),
							cardSet[class2].Where(p => p.Class == class2 || p.MultiClassGroup != 0).ToList(),
							cardSet[class3].Where(p => p.Class == class3 || p.MultiClassGroup != 0).ToList()};
		}

		private List<Card>[] GetFilter(Func<IEnumerable<Card>, IEnumerable<Card>> filter)
		{
			var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
			var heroClass = Controller.HeroClass != CardClass.NEUTRAL ? Controller.HeroClass : Util.RandomElement(Cards.HeroClasses);
			var nonClassCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class != heroClass));
			var classCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass));
			return new[] { nonClassCards.ToList(), classCards.ToList() };
		}

		public override ISimpleTask Clone()
		{
			var clone = new DiscoverTask(DiscoverType, Enchantment);
			clone.Copy(this);
			return clone;
		}
	}
}