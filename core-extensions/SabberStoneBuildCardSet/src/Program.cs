using SabberStoneCore.Model;

namespace SabberStoneBuildCardSet
{
	class Program
	{
		static void Main(string[] args)
		{
			//Generate.CardSetFile(Cards.All, false);
			Generate.EnchantmentLeftOver(Cards.All);
			//Generate.NamingConventions(Cards.All);
		}
	}
}
