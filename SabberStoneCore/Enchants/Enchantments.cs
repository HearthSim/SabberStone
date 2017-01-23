using System.Collections.Generic;
using System.Reflection;
using SabberStoneCore.CardSets;

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
            CoreCardsGen.AddAll(_entchantmentDic);
            Expert1CardsGen.AddAll(_entchantmentDic);
            Fp2CardsGen.AddAll(_entchantmentDic);
            GangsCardsGen.AddAll(_entchantmentDic);
            KaraCardsGen.AddAll(_entchantmentDic);
            LoeCardsGen.AddAll(_entchantmentDic);
            OgCardsGen.AddAll(_entchantmentDic);
            TgtCardsGen.AddAll(_entchantmentDic);
        }

        public static Enchantments Instance => _instance ?? (_instance = new Enchantments());

        public Dictionary<string, List<Enchantment>> Get()
        {
            return _entchantmentDic;
        }
    }
}