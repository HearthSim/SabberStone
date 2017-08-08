using SabberStoneCore.Model;
using System;
using System.Linq;

namespace SabberStoneBuildCardSet
{
    class Program
    {
        static void Main(string[] args)
        {
			Generate.CardSetFile(Cards.All);
			Generate.EnchantmentLeftOver(Cards.All);
		}
    }
}