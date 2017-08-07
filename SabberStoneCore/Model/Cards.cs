using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
//using Newtonsoft.Json;
using SabberStoneCore.Enchants;
//using SabberStoneCore.Properties;
using SabberStoneCore.Loader;

namespace SabberStoneCore.Model
{
    public static class Cards
    {
        private static readonly CardDefinitions Data;

        public static CardSet[] StandardSets { get; } = {
            CardSet.CORE, CardSet.EXPERT1, CardSet.OG, CardSet.KARA, CardSet.GANGS, CardSet.UNGORO
        };

        public static CardSet[] WildSets { get; } = {
            CardSet.CORE, CardSet.EXPERT1, CardSet.OG, CardSet.KARA, CardSet.GANGS, CardSet.UNGORO,
            CardSet.BRM, CardSet.GVG, CardSet.HOF, CardSet.NAXX, CardSet.LOE, CardSet.TGT
        };

        public static string CardSetToName(CardSet cardSet)
        {
            switch (cardSet)
            {
                case CardSet.CORE:
                    return "Basic";
                case CardSet.EXPERT1:
                    return "Classic";
                case CardSet.HOF:
                    return "Hall of Fame";
                case CardSet.NAXX:
                    return "Curse of Naxxramas";
                case CardSet.GVG:
                    return "Goblins vs Gnomes";
                case CardSet.BRM:
                    return "Blackrock Mountain";
                case CardSet.TGT:
                    return "The Grand Tournament";
                case CardSet.LOE:
                    return "The League of Explorers";
                case CardSet.OG:
                    return "Whispers of the Old Gods";
                case CardSet.KARA:
                    return "One Night in Karazhan";
                case CardSet.GANGS:
                    return "Mean Streets of Gadgetzan";
                case CardSet.UNGORO:
                    return "Journey to Un\'Goro ";
                default:
                    throw new ArgumentOutOfRangeException(nameof(cardSet), cardSet, null);
            }
        }



        public static CardClass[] BasicHeroes => new []
        {
            CardClass.DRUID, CardClass.HUNTER, CardClass.PALADIN,
            CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK,
            CardClass.MAGE, CardClass.PRIEST, CardClass.WARRIOR 
        };

        public static Card HeroCard(CardClass cardClass)
        {
            return All.FirstOrDefault(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO")&& c.Class == cardClass);
        }

        public static IEnumerable<Card> HeroCards()
        {
            return All.Where(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO"));
        }

        static Cards()
        {
            var cardLoader = new CardLoader();
            var cards = cardLoader.Load();

            //string json = File.ReadAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardData.json");
            //string json = File.ReadAllText(Environment.CurrentDirectory + @"\cardData.json");
            //var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(Resources.cardDataJson);
            //File.WriteAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardDataJson.txt", JsonConvert.SerializeObject(cards, Formatting.Indented));
            // Set as card definitions

            Data = new CardDefinitions();
            Data.Load(cards);

            //Log.Info($"Loaded {All.Count()} cards.");

            // Wild
            //Log.Debug("Wild:");
            foreach (var heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
            {
                Wild.Add(heroClass, All.Where(c => 
                c.Collectible &&
                    (c.Class == heroClass ||
                     c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
                     c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
                     c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
                     c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
                     c.Type != CardType.HERO).ToList());
                //Log.Debug($"-> [{heroClass}] - {Wild[heroClass].Count} cards.");
            }

            //Log.Debug("Standard:");
            foreach (var heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
            {
                Standard.Add(heroClass, All.Where(c => 
                    c.Collectible && 
                    (c.Class == heroClass || 
                     c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
                     c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
                     c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
                     c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) && 
                     c.Type != CardType.HERO && StandardSets.Contains(c.Set)
                ).ToList());
                //Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count} cards.");
            }

            //Log.Debug("AllStandard:");
            AllStandard = All.Where(c => c.Collectible && c.Type != CardType.HERO && StandardSets.Contains(c.Set)).ToList();

            //Log.Debug("AllWild:");
            AllWild = All.Where(c => c.Collectible && c.Type != CardType.HERO).ToList();
        }

        public static int Count => Data.Cards.Count;

        public static Card FromId(string cardId)
        {
            return Data.Cards.ContainsKey(cardId) ? Data.Cards[cardId] : null;
        }

        public static Card FromName(string cardName)
        {
            return Data.Cards.FirstOrDefault(x => x.Value.Name == cardName && x.Value.Collectible).Value;
        }

        public static Card FromAssetId(int assetId)
        {
            return Data.Cards.Values.FirstOrDefault(x => x.AssetId == assetId);
        }

        public static IEnumerable<Card> All => Data.Cards.Values;

        public static Dictionary<CardClass, List<Card>> Wild { get; } = new Dictionary<CardClass, List<Card>>();

        public static Dictionary<CardClass, List<Card>> Standard { get; } = new Dictionary<CardClass, List<Card>>();

        public static IEnumerable<Card> AllStandard { get; }

        public static IEnumerable<Card> AllWild { get; }

        public static Dictionary<CardClass, List<Card>> FormatTypeClassCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? Cards.Standard : Cards.Wild;

        public static IEnumerable<Card> FormatTypeCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;


        public static string Statistics()
        {
            var standard = All.Where(c => c.Collectible && StandardSets.Contains(c.Set));
            var wild = All.Where(c => c.Collectible);
            var implemented = standard.Where(p => p.Implemented)
                .GroupBy(p => p.Set)
                .Select(t => new {Key = t.Key, Count = t.Count()});
            var implementedWild = wild.Where(p => p.Implemented)
                .GroupBy(p => p.Set)
                .Select(t => new { Key = t.Key, Count = t.Count() });
            var all = standard
                .GroupBy(p => p.Set)
                .Select(t => new {Key = t.Key, Count = t.Count()});
            var allWild = wild
                .GroupBy(p => p.Set)
                .Select(t => new { Key = t.Key, Count = t.Count() });
            var str = string.Empty;
            var totImpl = 0;
            var totCards = 0;
            foreach (var set in StandardSets)
            {
                var impl = implemented.FirstOrDefault(p => p.Key == set).Count;
                totImpl += impl;
                var tot = all.FirstOrDefault(p => p.Key == set).Count;
                str += $"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards\n";
                totCards += tot;
            }

            str += $"Total Standard => {totImpl * 100 / totCards}% from {totCards} Cards\n";
            str += "\n";

            totImpl = 0;
            totCards = 0;
            foreach (var set in WildSets)
            {
                var impl = implementedWild.FirstOrDefault(p => p.Key == set).Count;
                totImpl += impl;
                var tot = allWild.FirstOrDefault(p => p.Key == set).Count;
                str += $"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards\n";
                totCards += tot;
            }

            str += $"Total Wild => {totImpl * 100 / totCards}% from {totCards} Cards\n";

            return str;
        }
    }

    internal class CardDefinitions : IEnumerable<Card>
    {
        internal Dictionary<string, Card> Cards { get; private set; }

        internal Card this[string cardId] => Cards[cardId];

        // Card must be collectible to avoid selecting duplicate cards. Use CardID to retrieve adventure cards etc.
        //internal Card ByName(string cardName)
        //{
        //    var card = Cards.FirstOrDefault(x => x.Value.Name == cardName && x.Value.Collectible);
        //    return !card.Equals(default(KeyValuePair<string, Card>)) ? card.Value : null;
        //}

        internal void Load(IEnumerable<Card> cards)
        {
            // Set cards (without behaviours)
            Cards = (from c in cards select new {Key = c.Id, Value = c}).ToDictionary(x => x.Key, x => x.Value);

            // Add enchantments
            //Generate.CardSetFile(Cards.Values);

            foreach (var c in Cards.Values)
            {
                List<Enchantment> list;
                if (Enchantments.Instance.Get().TryGetValue(c.Id, out list))
                {
                    c.Enchantments = list;
                    c.Implemented = list == null || c.Enchantments[0].Activation != EnchantmentActivation.NONE &&
                                    (c.Enchantments[0].SingleTask != null || c.Enchantments[0].Enchant != null ||
                                     c.Enchantments[0].Trigger != null);
                }

            }

            //Generate.EnchantmentLeftOver(Cards.Values);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return Cards.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
