using SabberStoneCore.Actions;
using SabberStoneCore.Collections;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities.Playables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	
    public class DiscoverTask : SimpleTask
    {
        public DiscoverTask(EDiscoverType discoverType, Enchantment enchantment = null)
        {
            DiscoverType = discoverType;
            Enchantment = enchantment;
        }

        public EDiscoverType DiscoverType { get; set; }

        public Enchantment Enchantment { get; set; }

        public override ETaskState Process()
        {
            var choiceAction = EChoiceAction.INVALID;
            var cardsToDiscover = Discovery(DiscoverType, out choiceAction);

            var totcardsToDiscover = new List<Card>(cardsToDiscover[0]);
            if (cardsToDiscover.Length == 2)
            {
                totcardsToDiscover.AddRange(cardsToDiscover[1]);
                totcardsToDiscover.AddRange(cardsToDiscover[1]);
                totcardsToDiscover.AddRange(cardsToDiscover[1]);
                totcardsToDiscover.AddRange(cardsToDiscover[1]);
            }

            var resultCards = new OrderedHashSet<Card>();

            // standard discover takes 3 random cards from a set of cards
            if (cardsToDiscover.Length < 3)
            {
                while (resultCards.Count() < 3 && totcardsToDiscover.Count > 0)
                {
                    var discoveredCard = Util.Choose(totcardsToDiscover);
                    resultCards.Add(discoveredCard);
                    // remove all cards matching the discovered one, 
                    // need because class cards are duplicated 4 x times
                    // to have a balance to neutral cards
                    // http://hearthstone.gamepedia.com/Discover
                    if (DiscoverType == EDiscoverType.TRACKING)
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
					foreach(var card in resultCards)
					{
						classDiscover.Remove(card);
					}
                    resultCards.Add(Util.Choose(classDiscover));
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
            //    return ETaskState.STOP;
            //}

            var success = Generic.CreateChoiceCards.Invoke(Controller, Source, null, EChoiceType.GENERAL, choiceAction, resultCards, Enchantment);
            return ETaskState.COMPLETE;
        }

        private void ProcessSplit(List<Card>[] cardsToDiscover, EChoiceAction choiceAction)
        {
			int neutralCnt = cardsToDiscover[0].Count;
			int classCnt = 0;
            var uniqueList = OrderedHashSet<Card>.Build(cardsToDiscover[0]);

            if (cardsToDiscover.Length > 1)
            {
                classCnt = cardsToDiscover[1].Count;
				for (int i = 0; i < classCnt; ++i)
				{
					uniqueList.Add(cardsToDiscover[1][i]);
				}
            }
            var combinations = Util.GetDiscoverSets(uniqueList).ToList();

            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "DiscoverTask", $"... found {combinations.Count} discovery splits [class: {classCnt}, neutral: {neutralCnt}]");
            combinations.ForEach(p =>
            {
                var cloneGame = Game.Clone();
                var cloneController = cloneGame.ControllerByEntityID(Controller.Id);
                var success = Generic.CreateChoiceCards.Invoke(cloneController, Source, null, EChoiceType.GENERAL, choiceAction, LightWeightOrderedSet<Card>.Build(p), null);
                cloneGame.TaskQueue.CurrentTask.State = ETaskState.COMPLETE;
            });

        }

        private List<Card>[] Discovery(EDiscoverType discoverType, out EChoiceAction choiceAction)
        {
            switch (discoverType)
            {
                case EDiscoverType.DRUID_ROGUE_SHAMAN:
                    choiceAction = EChoiceAction.HAND;
                    return GetTriClass(ECardClass.DRUID, ECardClass.ROGUE, ECardClass.SHAMAN);

                case EDiscoverType.MAGE_PRIEST_WARLOCK:
                    choiceAction = EChoiceAction.HAND;
                    return GetTriClass(ECardClass.MAGE, ECardClass.PRIEST, ECardClass.WARLOCK);

                case EDiscoverType.HUNTER_PALADIN_WARRIOR:
                    choiceAction = EChoiceAction.HAND;
                    return GetTriClass(ECardClass.HUNTER, ECardClass.PALADIN, ECardClass.WARRIOR);

                case EDiscoverType.BASIC_HEROPOWERS:
                    choiceAction = EChoiceAction.HEROPOWER;
                    return new[] { Cards.HeroCards().Where(p => p != Controller.Hero.Card).Select(p => Cards.FromAssetId(p[EGameTag.HERO_POWER])).ToList() };

                case EDiscoverType.DRAGON:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == ERace.DRAGON));

                case EDiscoverType.OVERLOAD:
                    choiceAction = EChoiceAction.HAND;
                    var cardSet = Cards.FormatTypeCards(Game.FormatType);
                    return new[] { cardSet.Where(p => p.HasOverload).ToList() };

                case EDiscoverType.TAUNT:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p[EGameTag.TAUNT] == 1));

                case EDiscoverType.SECRET:
                    choiceAction = EChoiceAction.HAND;
                    var classForSecret = 
                        Controller.HeroClass == ECardClass.PALADIN
                        || Controller.HeroClass == ECardClass.MAGE
                        || Controller.HeroClass == ECardClass.HUNTER
                        ? Controller.HeroClass
                        : ECardClass.PALADIN;
                    return GetClassCard(classForSecret, list => list.Where(p => p[EGameTag.SECRET] == 1));

                case EDiscoverType.BEAST:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == ERace.BEAST));

                case EDiscoverType.MURLOC:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == ERace.MURLOC));

                case EDiscoverType.ELEMENTAL:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == ERace.ELEMENTAL));

                case EDiscoverType.MECHANICAL:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == ERace.MECHANICAL));

                case EDiscoverType.ALL:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Cost >= 0));

                case EDiscoverType.ARTIFACT:
                    choiceAction = EChoiceAction.HAND;
                    return new[]
                    {
                        new List<Card>
                        {
                            Cards.FromId("LOEA16_3"),
                            Cards.FromId("LOEA16_4"),
                            Cards.FromId("LOEA16_5")
                        }
                    };

                case EDiscoverType.ELEMENTAL_INVOCATION:
                    choiceAction = EChoiceAction.HAND;
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

                case EDiscoverType.TRACKING:
                    choiceAction = EChoiceAction.TRACKING;
                    var cards = new List<Card>();
                    Controller.Deck.GetAll.Take(3).ToList().ForEach(p =>
                    {
                        Generic.RemoveFromZone(Controller, p);
                        Controller.Setaside.Add(p);
                        cards.Add(p.Card);
                    });
                    return new[] { cards };

                case EDiscoverType.MINION:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Type == ECardType.MINION));

                case EDiscoverType.DEATHRATTLE:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p[EGameTag.DEATHRATTLE] == 1));

                case EDiscoverType.ONE_COST:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Cost == 1));

                case EDiscoverType.THREE_COST:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Cost == 3));

                case EDiscoverType.SPELL:
                    choiceAction = EChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Type == ECardType.SPELL));

                case EDiscoverType.OWN_SPELL:
                    choiceAction = EChoiceAction.HAND;
                    return new[] { Controller.Deck.Where(p => p is Spell).Select(p => p.Card).ToList() };

                case EDiscoverType.BASIC_TOTEM:
                    choiceAction = EChoiceAction.SUMMON;
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

                case EDiscoverType.COST_8_MORE_SUMMON:
                    choiceAction = EChoiceAction.SUMMON;
                    return GetFilter(list => list.Where(p => p.Cost >= 8 && p.Type == ECardType.MINION));

                case EDiscoverType.OP_DECK:
                    choiceAction = EChoiceAction.HAND;
                    return new[] { Controller.Opponent.Deck.Select(p => p.Card).ToList() };

                case EDiscoverType.OP_HERO:
                    choiceAction = EChoiceAction.HAND;
                    return GetClassCard(Controller.Opponent.HeroClass, list => list);

                default:
                    throw new ArgumentOutOfRangeException(nameof(discoverType), discoverType, null);
            }
        }

        private List<Card>[] GetClassCard(ECardClass heroClass, Func<IEnumerable<Card>, IEnumerable<Card>> filter)
        {
            var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
            var classCards = filter.Invoke(cardSet[heroClass].Where(p => p.Class == heroClass));
            return new[] { classCards.ToList()};
        }

        private List<Card>[] GetTriClass(ECardClass class1, ECardClass class2, ECardClass class3)
        {
            var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
            return new[] { cardSet[class1].Where(p => p.Class == class1 || p.MultiClassGroupType != 0).ToList(),
                            cardSet[class2].Where(p => p.Class == class2 || p.MultiClassGroupType != 0).ToList(),
                            cardSet[class3].Where(p => p.Class == class3 || p.MultiClassGroupType != 0).ToList()};
        }

        private List<Card>[] GetFilter(Func<IEnumerable<Card>, IEnumerable<Card>> filter)
        {
            var cardSet = Cards.FormatTypeClassCards(Game.FormatType);
            var heroClass = Controller.HeroClass != ECardClass.NEUTRAL ? Controller.HeroClass : Util.RandomElement(Cards.BasicClasses);
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