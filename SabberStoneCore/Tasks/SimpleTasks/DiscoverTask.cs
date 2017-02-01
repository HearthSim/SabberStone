using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;

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
        HUNTER_PALADIN_WARRIOR
    }
    public class DiscoverTask : SimpleTask
    {
        public DiscoverTask(DiscoverType discoverType)
        {
            DiscoverType = discoverType;
        }

        public DiscoverType DiscoverType { get; set; }

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
                while (resultCards.Count < 3)
                {
                    var discoveredCard = Util<Card>.Choose(totcardsToDiscover);
                    resultCards.Add(discoveredCard);
                    // remove all cards matching the discovered one, 
                    // need because class cards are duplicated 4 x times
                    // to have a balance to neutral cards
                    // http://hearthstone.gamepedia.com/Discover
                    totcardsToDiscover.RemoveAll(p => p == discoveredCard);
                }
            }
            else
            {
                // tri-class discover takes one random card from each of the three sets
                foreach (var classDiscover in cardsToDiscover)
                {
                    resultCards.ForEach(p => classDiscover.Remove(p));
                    resultCards.Add(Util<Card>.Choose(classDiscover));
                } 
            }

            // TODO work on it ...
            if (Game.Splitting)
            {
                ProcessSplit(cardsToDiscover, choiceAction);
            }

            var success = Generic.CreateChoice.Invoke(Controller, ChoiceType.GENERAL, choiceAction, resultCards.ToList());

            return TaskState.COMPLETE;
        }

        private void ProcessSplit(List<Card>[] cardsToDiscover, ChoiceAction choiceAction)
        {
            var neutralCnt = cardsToDiscover[0].Count;
            var classCnt = 0;
            var uniqueList = new List<Card>(cardsToDiscover[0]);

            if (cardsToDiscover.Length> 1)
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
                var success = Generic.CreateChoice.Invoke(cloneController, ChoiceType.GENERAL, choiceAction, p.ToList());
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
                    return new [] { Cards.HeroCards().Where(p => p != Controller.Hero.Card).Select(p => Cards.FromAssetId(p[GameTag.SHOWN_HERO_POWER])).ToList()};

                case DiscoverType.DRAGON:
                    choiceAction = ChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == Race.DRAGON));

                case DiscoverType.OVERLOAD:
                    choiceAction = ChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.HasOverload));

                case DiscoverType.TAUNT:
                    choiceAction = ChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p[GameTag.TAUNT] == 1));

                case DiscoverType.BEAST:
                    choiceAction = ChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == Race.BEAST));

                case DiscoverType.MECHANICAL:
                    choiceAction = ChoiceAction.HAND;
                    return GetFilter(list => list.Where(p => p.Race == Race.MECHANICAL));

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

                case DiscoverType.TRACKING:
                    choiceAction = ChoiceAction.TRACKING;
                    var cards = new List<Card>();
                    Controller.Deck.GetAll.Take(3).ToList().ForEach(p =>
                    {
                        Generic.RemoveFromZone(Controller, p);
                        Controller.Setaside.Add(p);
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

                case DiscoverType.OP_DECK:
                    choiceAction = ChoiceAction.HAND;
                    return new [] { IncludeTask.GetEntites(EntityType.OP_DECK, Controller, Source, Target, Playables).Select(p => p.Card).ToList() } ;

                default:
                    throw new ArgumentOutOfRangeException(nameof(discoverType), discoverType, null);
            }
        }

        private List<Card>[] GetTriClass(CardClass class1, CardClass class2, CardClass class3)
        {
            var cardSet = Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard : Cards.Wild;
            return new [] { cardSet[class1].Where(p => p.Class == class1 || p.MultiClassGroup != 0).ToList(),
                            cardSet[class2].Where(p => p.Class == class2 || p.MultiClassGroup != 0).ToList(),
                            cardSet[class3].Where(p => p.Class == class3 || p.MultiClassGroup != 0).ToList()};
        }

        private List<Card>[] GetFilter(Func<IEnumerable<Card>, IEnumerable<Card>> filter)
        {
            var cardSet = Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard : Cards.Wild;
            var nonClassCards = filter.Invoke(cardSet[Controller.HeroClass].Where(p => p.Class != Controller.HeroClass));
            var classCards = filter.Invoke(cardSet[Controller.HeroClass].Where(p => p.Class == Controller.HeroClass));
            return new [] { nonClassCards.ToList(), classCards.ToList() };
        }

        public override ISimpleTask Clone()
        {
            var clone = new DiscoverTask(DiscoverType);
            clone.Copy(this);
            return clone;
        }
    }
}