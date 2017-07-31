using System.Collections.Generic;
using SabberStoneCore.CardSets;
using SabberStoneCore.CardSets.Standard;

namespace SabberStoneCore.Enchants
{
    public interface ILazyRemove
    {
        void Remove();
    }

    internal class Enchantments
    {
        private static Enchantments _instance;

        private readonly Dictionary<string, List<Enchantment>> _entchantmentDic =
            new Dictionary<string, List<Enchantment>>();

        private Enchantments()
        {
            // Standard
            CoreCardsGen.AddAll(_entchantmentDic);
            Expert1CardsGen.AddAll(_entchantmentDic);
            GangsCardsGen.AddAll(_entchantmentDic);
            KaraCardsGen.AddAll(_entchantmentDic);
            OgCardsGen.AddAll(_entchantmentDic);
            UngoroCardsGen.AddAll(_entchantmentDic);

            // Rest
            HofCardsGen.AddAll(_entchantmentDic);
            NaxxCardsGen.AddAll(_entchantmentDic);
            GvgCardsGen.AddAll(_entchantmentDic);
            BrmCardsGen.AddAll(_entchantmentDic);
            TgtCardsGen.AddAll(_entchantmentDic);
            LoeCardsGen.AddAll(_entchantmentDic);
        }

        public static Enchantments Instance => _instance ?? (_instance = new Enchantments());

        public Dictionary<string, List<Enchantment>> Get()
        {
            return _entchantmentDic;
        }
    }
}