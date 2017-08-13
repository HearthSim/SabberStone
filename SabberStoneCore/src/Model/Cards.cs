using SabberStoneCore.Enums;
using SabberStoneCore.Loader;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Provides helper methods for filtering the entire card set.
	/// </summary>
	public static class Cards
	{
		/// <summary>
		/// Specifies which card sets combine into the STANDARD set.
		/// </summary>
		public static CardSet[] StandardSets { get; } = {
			CardSet.CORE, CardSet.EXPERT1, CardSet.OG, CardSet.KARA, CardSet.GANGS, CardSet.UNGORO, CardSet.ICECROWN
		};

		/// <summary>
		/// Specifies which card sets combine into the WILD set.
		/// </summary>
		public static CardSet[] WildSets { get; } = {
			CardSet.CORE, CardSet.EXPERT1, CardSet.OG, CardSet.KARA, CardSet.GANGS, CardSet.UNGORO,
			CardSet.BRM, CardSet.GVG, CardSet.HOF, CardSet.NAXX, CardSet.LOE, CardSet.TGT
		};

		/// <summary>
		/// Defines all card classes that can be used for deck creation.
		/// </summary>
		public static CardClass[] HeroClasses => new[]
		{
			CardClass.DRUID, CardClass.HUNTER, CardClass.PALADIN,
			CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK,
			CardClass.MAGE, CardClass.PRIEST, CardClass.WARRIOR
		};

		private static CardContainer _data;

		#region FILTERS

		/// <summary>
		/// Returns all known cards.
		/// </summary>
		public static IEnumerable<Card> All => _data;

		/// <summary>
		/// Returns the count of all known cards.
		/// </summary>
		public static int Count => _data.Count;

		/// <summary>
		/// Retrieves all wild cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, IEnumerable<Card>> Wild => _data.Wild;

		/// <summary>
		/// Retrieves all standard cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, IEnumerable<Card>> Standard => _data.Standard;

		/// <summary>
		/// All cards belonging to the Standard set.
		/// </summary>
		public static IEnumerable<Card> AllStandard => _data.AllStandard;

		/// <summary>
		/// All cards belonging to the Wild set.
		/// </summary>
		public static IEnumerable<Card> AllWild => _data.AllWild;

		/// <summary>
		/// Retrieves the specified set of cards, sorted by <see cref="CardClass"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<CardClass, IEnumerable<Card>> FormatTypeClassCards(FormatType formatType)
		{
			return formatType == FormatType.FT_STANDARD ? Standard : Wild;
		}

		/// <summary>
		/// Retrieves the specifified set of cards.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static IEnumerable<Card> FormatTypeCards(FormatType formatType)
		{
			return formatType == FormatType.FT_STANDARD ? AllStandard : AllWild;
		}

		/// <summary>
		/// Returns the default hero class card.
		/// ex; Returns Grommash for the WARRIOR class.
		/// </summary>
		/// <param name="cardClass"></param>
		/// <returns></returns>
		public static Card HeroCard(CardClass cardClass)
		{
			return All.FirstOrDefault(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO") && c.Class == cardClass);
		}

		/// <summary>
		/// Returns a sequence of all known hero cards.
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Card> HeroCards()
		{
			return All.Where(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO"));
		}

		/// <summary>
		/// Return a specific card from the given ID.
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
		public static Card FromId(string cardId)
		{
			// TODO Test this for exceptions.
			return _data[cardId];
		}

		/// <summary>
		/// Returns the first collectible card that matches the provided name.
		/// 
		/// This string MUST be localized into the loaded language!
		/// </summary>
		/// <param name="cardName"></param>
		/// <returns></returns>
		public static Card FromName(string cardName)
		{
			return _data.FirstOrDefault(x => x.Name == cardName && x.Collectible);
		}

		/// <summary>
		/// Returns the first card that matches the provided asset id.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public static Card FromAssetId(int assetId)
		{
			return _data.FirstOrDefault(x => x.AssetId == assetId);
		}

		#endregion

		#region SETUP

		static Cards()
		{
			// Load and test received CardContainer instance.
			var cardLoader = new CardLoader();
			// CardContainer must be assigned immediately because enchantment definitions
			// depend on access to Card objects.
			_data = cardLoader.Load();
			
			// Here can custom cards be implemented, if desired.
			// The container will become read-only after the LockContainer() method
			// is executed!


			_data.LockContainer();			
		}

		#endregion

		/// <summary>
		/// Returns a string representation of the provided card set.
		/// </summary>
		/// <param name="cardSet"></param>
		/// <returns></returns>
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
					return "Journey to Un\'Goro";
				case CardSet.ICECROWN:
					return "Knights of the Frozen Throne";
				default:
					throw new ArgumentOutOfRangeException(nameof(cardSet), cardSet, null);
			}
		}

		/// <summary>
		/// Returns a string with the card implementation statistics.
		/// </summary>
		/// <returns></returns>
		public static string Statistics()
		{
			IEnumerable<Card> standard = All.Where(c => c.Collectible && StandardSets.Contains(c.Set));
			IEnumerable<Card> wild = All.Where(c => c.Collectible);
			var implemented = standard.Where(p => p.Implemented)
				.GroupBy(p => p.Set)
				.Select(t => new { Key = t.Key, Count = t.Count() });
			var implementedWild = wild.Where(p => p.Implemented)
				.GroupBy(p => p.Set)
				.Select(t => new { Key = t.Key, Count = t.Count() });
			var all = standard
				.GroupBy(p => p.Set)
				.Select(t => new { Key = t.Key, Count = t.Count() });
			var allWild = wild
				.GroupBy(p => p.Set)
				.Select(t => new { Key = t.Key, Count = t.Count() });
			string str = String.Empty;
			int totImpl = 0;
			int totCards = 0;
			foreach (CardSet set in StandardSets)
			{
				int impl = implemented.FirstOrDefault(p => p.Key == set).Count;
				totImpl += impl;
				int tot = all.FirstOrDefault(p => p.Key == set).Count;
				str += $"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards\n";
				totCards += tot;
			}

			str += $"Total Standard => {totImpl * 100 / totCards}% from {totCards} Cards\n";
			str += "\n";

			totImpl = 0;
			totCards = 0;
			foreach (CardSet set in WildSets)
			{
				int impl = implementedWild.FirstOrDefault(p => p.Key == set).Count;
				totImpl += impl;
				int tot = allWild.FirstOrDefault(p => p.Key == set).Count;
				str += $"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards\n";
				totCards += tot;
			}

			str += $"Total Wild => {totImpl * 100 / totCards}% from {totCards} Cards\n";

			return str;
		}
	}
}
