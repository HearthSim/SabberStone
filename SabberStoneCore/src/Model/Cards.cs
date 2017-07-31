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
		/// Object holding the information of all known cards.
		/// </summary>
		private static readonly CardContainer Data = new CardContainer();

		private static bool DataReady = SetupCards();

		/// <summary>
		/// Specifies which card sets combine into the STANDARD set.
		/// </summary>
		public static CardSet[] StandardSets { get; } = {
			CardSet.CORE, CardSet.EXPERT1, CardSet.OG, CardSet.KARA, CardSet.GANGS, CardSet.UNGORO
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
		public static CardClass[] BasicClasses => new[]
		{
			CardClass.DRUID, CardClass.HUNTER, CardClass.PALADIN,
			CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK,
			CardClass.MAGE, CardClass.PRIEST, CardClass.WARRIOR
		};

		/// <summary>
		/// Returns all known cards.
		/// </summary>
		public static IEnumerable<Card> All => Data.AllCards();

		/// <summary>
		/// Returns the count of all known cards.
		/// </summary>
		public static int Count => Data.AllCards().Count;

		#region CARD_SETUP

		private static bool SetupCards()
		{
			// Fetch all cards.
			var cardLoader = new CardLoader();
			List<Card> cards = cardLoader.Load();

			// Setup container.
			return CardContainer.SetupContainer(cards, Data);

			//Log.Info($"Loaded {All.Count()} cards.");
		}

		private static Dictionary<CardClass, List<Card>> SetupWildCards()
		{
			var container = new Dictionary<CardClass, List<Card>>(Count);
			// Wild
			//Log.Debug("Wild:");
			foreach (CardClass heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
			{
				container.Add(heroClass, Data.AllCards().Where(c =>
				c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroupType == 0 ||
					 c.MultiClassGroupType == MultiClassGroup.GRIMY_GOONS && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroupType == MultiClassGroup.JADE_LOTUS && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroupType == MultiClassGroup.KABAL && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO).ToList());
				//Log.Debug($"-> [{heroClass}] - {Wild[heroClass].Count} cards.");
			}

			return container;
		}

		private static Dictionary<CardClass, List<Card>> SetupStandardCards()
		{
			var container = new Dictionary<CardClass, List<Card>>(Count);
			//Log.Debug("Standard:");
			foreach (CardClass heroClass in Enum.GetValues(typeof(CardClass)).Cast<CardClass>())
			{
				container.Add(heroClass, All.Where(c =>
					c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroupType == 0 ||
					 c.MultiClassGroupType == MultiClassGroup.GRIMY_GOONS && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroupType == MultiClassGroup.JADE_LOTUS && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroupType == MultiClassGroup.KABAL && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO && StandardSets.Contains(c.Set)
				).ToList());
				//Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count} cards.");
			}
			return container;
		}

		#endregion

		#region FILTERS

		/// <summary>
		/// Retrieves all wild cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, List<Card>> WildPerClass => _WildPerClass ?? (_WildPerClass = SetupWildCards());
		private static Dictionary<CardClass, List<Card>> _WildPerClass;

		/// <summary>
		/// Retrieves all standard cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, List<Card>> StandardPerClass => _StandardPerClass ?? (_StandardPerClass = SetupStandardCards());
		private static Dictionary<CardClass, List<Card>> _StandardPerClass;

		/// <summary>
		/// Retrieves the specified set of cards, sorted by <see cref="CardClass"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<CardClass, List<Card>> FormatTypeClassCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? StandardPerClass : WildPerClass;

		/// <summary>
		/// All cards belonging to the Standard set.
		/// </summary>
		public static IEnumerable<Card> AllStandard => Data.AllCards().Where(c => c.Collectible && c.Type != CardType.HERO && StandardSets.Contains(c.Set));

		/// <summary>
		/// All cards belonging to the Wild set.
		/// </summary>
		public static IEnumerable<Card> AllWild => Data.AllCards().Where(c => c.Collectible && c.Type != CardType.HERO);

		/// <summary>
		/// Retrieves the specifified set of cards.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static IEnumerable<Card> FormatTypeCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? AllStandard : AllWild;

		/// <summary>
		/// Returns the default hero class card.
		/// ex; Returns Grommash for the WARRIOR class.
		/// </summary>
		/// <param name="cardClass"></param>
		/// <returns></returns>
		public static Card DefaultHeroCard(CardClass cardClass)
		{
			return Data.AllCards().First(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO") && c.Class == cardClass);
		}

		/// <summary>
		/// Returns a sequence of all known hero cards.
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Card> HeroCards()
		{
			return Data.AllCards().Where(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO"));
		}

		/// <summary>
		/// Return a specific card from the given ID.
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
		public static Card FromId(string cardId)
		{
			return Data[cardId];
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
			return Data.FirstOrDefault(x => x.Name == cardName && x.Collectible);
		}

		/// <summary>
		/// Returns the first card that matches the provided asset id.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public static Card FromAssetId(int assetId)
		{
			return Data.FirstOrDefault(x => x.AssetId == assetId);
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
					return "Journey to Un\'Goro ";
				default:
					throw new ArgumentOutOfRangeException(nameof(cardSet), cardSet, null);
			}
		}

		public static string Statistics()
		{
			var standard = All.Where(c => c.Collectible && StandardSets.Contains(c.Set));
			var wild = All.Where(c => c.Collectible);
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
}
