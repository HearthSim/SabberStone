using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HearthDb.Enums;
using log4net;
using Newtonsoft.Json;
using SabberStone.Enchants;
using SabberStone.Properties;

namespace SabberStone.Model
{
    public static class Cards
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly CardDefinitions Data;

        public static CardSet[] StandardSets { get; } = { CardSet.CORE, CardSet.EXPERT1, CardSet.FP2, CardSet.TGT, CardSet.LOE, CardSet.OG, CardSet.KARA, CardSet.GANGS };

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
            //var cardLoader = new CardLoader();
            //var cards = cardLoader.Load();

            
            //string json = File.ReadAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardData.json");
            //string json = File.ReadAllText(Environment.CurrentDirectory + @"\cardData.json");
            var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(Resources.cardDataJson);
            //File.WriteAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardDataJson.txt", JsonConvert.SerializeObject(cards, Formatting.Indented));
            // Set as card definitions

            Data = new CardDefinitions();
            Data.Load(cards);

            Log.Info($"Loaded {All.Count()} cards.");

            // Wild
            Log.Debug("Wild:");
            foreach (var heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
            {
                Wild.Add(heroClass, All.Where(c => 
                c.Collectible &&
                    (c.Class == heroClass ||
                     c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
                     c.MultiClassGroup == 1 && (c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
                     c.MultiClassGroup == 2 && (c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
                     c.MultiClassGroup == 3 && (c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
                     c.Type != CardType.HERO).ToList());
                Log.Debug($"-> [{heroClass}] - {Wild[heroClass].Count()} cards.");
            }

            Log.Debug("Standard:");
            foreach (var heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
            {
                Standard.Add(heroClass, All.Where(c => 
                    c.Collectible && 
                    (c.Class == heroClass || 
                     c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
                     c.MultiClassGroup == 1 && (c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
                     c.MultiClassGroup == 2 && (c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
                     c.MultiClassGroup == 3 && (c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) && 
                     c.Type != CardType.HERO && StandardSets.Contains(c.Set)
                ).ToList());
                Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count()} cards.");
            }

            Log.Debug("AllStandard:");
            AllStandard = All.Where(c => c.Collectible && c.Type != CardType.HERO && StandardSets.Contains(c.Set)).ToList();

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
        
        public static void Statistics()
        {
            var standard = All.Where(c => c.Collectible && StandardSets.Contains(c.Set));
            var noench = standard.Where(p => p.Enchantments == null).GroupBy(p => p.Set).Select(t => new {Key = t.Key, Count = t.Count()});
            var noImpl = standard.Where(p => p.Enchantments != null && (
                p.Enchantments[0].Activation == EnchantmentActivation.NONE 
             || (p.Enchantments[0].SingleTask == null && p.Enchantments[0].Enchant == null && p.Enchantments[0].Trigger == null))).GroupBy(p => p.Set).Select(t => new { Key = t.Key, Count = t.Count() });
            var okench = standard.Where(p => p.Enchantments != null).GroupBy(p => p.Set).Select(t => new { Key = t.Key, Count = t.Count() });

            foreach (var set in StandardSets)
            {
                var noenchCnt = noench.FirstOrDefault(p => p.Key == set) == null ? 0 : noench.FirstOrDefault(p => p.Key == set).Count;
                var noimplCnt = noImpl.FirstOrDefault(p => p.Key == set).Count;
                var totcolCnt = okench.FirstOrDefault(p => p.Key == set).Count;
                var implCnt = totcolCnt - noimplCnt;
                Log.Info($"{set} => {((implCnt + noenchCnt) * 100 / (totcolCnt + noenchCnt))}% from {totcolCnt + noenchCnt} Cards");
            }
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
                }

            }

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
