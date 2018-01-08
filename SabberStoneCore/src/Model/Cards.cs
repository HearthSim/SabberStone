using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Loader;

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
		private static readonly CardContainer Data;

		/// <summary>
		/// Specifies which card sets combine into the STANDARD set.
		/// </summary>
		public static CardSet[] StandardSets { get; } = {
			CardSet.CORE,
			CardSet.EXPERT1,
			//CardSet.OG,
			//CardSet.KARA,
			//CardSet.GANGS,
			//CardSet.UNGORO,
			//CardSet.ICECROWN,
			//CardSet.LOOTAPALOOZA
		};

		/// <summary>
		/// Specifies which card sets combine into the WILD set.
		/// </summary>
		public static CardSet[] WildSets { get; } = {
			// standard
			CardSet.CORE,
			CardSet.EXPERT1,
			//CardSet.OG,
			//CardSet.KARA,
			//CardSet.GANGS,
			//CardSet.UNGORO,
			//CardSet.ICECROWN,
			//CardSet.LOOTAPALOOZA,
			// wild
			//CardSet.BRM,
			//CardSet.GVG,
			//CardSet.HOF,
			//CardSet.NAXX,
			//CardSet.LOE,
			//CardSet.TGT
		};

		/// <summary>
		/// Defines all card classes that can be used for deck creation.
		/// </summary>
		public static CardClass[] HeroClasses => new[]
		{
			CardClass.DRUID,
			CardClass.HUNTER,
			CardClass.PALADIN,
			CardClass.ROGUE,
			CardClass.SHAMAN,
			CardClass.WARLOCK,
			CardClass.MAGE,
			CardClass.PRIEST,
			CardClass.WARRIOR
		};

		#region CARD_SETUP

		static Cards()
		{
			// Fetch all cards.
			var cardLoader = new CardLoader();
			List<Card> cards = cardLoader.Load();

			//string json = File.ReadAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardData.json");
			//string json = File.ReadAllText(Environment.CurrentDirectory + @"\cardData.json");
			//var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(Resources.cardDataJson);
			//File.WriteAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardDataJson.txt", JsonConvert.SerializeObject(cards, Formatting.Indented));
			// Set as card definitions

			Data = new CardContainer();
			Data.Load(cards);

			//Log.Debug("Standard:");
			Enum.GetValues(typeof(CardClass)).Cast<CardClass>().ToList().ForEach(heroClass =>
			{
				Standard.Add(heroClass, All.Where(c =>
				c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
					 c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO && StandardSets.Contains(c.Set)).ToList().AsReadOnly());
				//Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count} cards.");
			});

			//Log.Debug("AllStandard:");
			AllStandard = All.Where(c => c.Collectible && c.Type != CardType.HERO && StandardSets.Contains(c.Set)).ToList().AsReadOnly();

			//Log.Debug("Wild:");
			Enum.GetValues(typeof(CardClass)).Cast<CardClass>().ToList().ForEach(heroClass =>
			{
				Wild.Add(heroClass, All.Where(c =>
				c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
					 c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER || c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID || c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE || c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					 c.Type != CardType.HERO).ToList().AsReadOnly());
				//Log.Debug($"-> [{heroClass}] - {Wild[heroClass].Count} cards.");
			});

			//Log.Debug("AllWild:");
			AllWild = All.Where(c => c.Collectible && c.Type != CardType.HERO).ToList().AsReadOnly();

			StandardCostMinionCards = AllStandard.Where(c => c.Type == CardType.MINION).GroupBy(c => c.Cost).ToDictionary(g => g.Key, g => g.ToList());
			WildCostMinionCards = AllWild.Where(c => c.Type == CardType.MINION).GroupBy(c => c.Cost).ToDictionary(g => g.Key, g => g.ToList());
		}

		#endregion

		#region FILTERS

		/// <summary>
		/// Returns all known cards.
		/// </summary>
		public static IEnumerable<Card> All => Data.Cards.Values;

		/// <summary>
		/// Returns the count of all known cards.
		/// </summary>
		public static int Count => Data.Cards.Count;

		/// <summary>
		/// Retrieves all wild cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, IEnumerable<Card>> Wild { get; } = new Dictionary<CardClass, IEnumerable<Card>>();

		/// <summary>
		/// Retrieves all standard cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, IEnumerable<Card>> Standard { get; } = new Dictionary<CardClass, IEnumerable<Card>>();

		/// <summary>
		/// All cards belonging to the Standard set.
		/// </summary>
		public static IEnumerable<Card> AllStandard { get; }

		/// <summary>
		/// All cards belonging to the Wild set.
		/// </summary>
		public static IEnumerable<Card> AllWild { get; }

		/// <summary>
		/// Retrieves the specified set of cards, sorted by <see cref="CardClass"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<CardClass, IEnumerable<Card>> FormatTypeClassCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? Cards.Standard : Cards.Wild;

		/// <summary>
		/// Retrieves the specifified set of cards.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static IEnumerable<Card> FormatTypeCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;

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
		/// Retrieves the specified set of cards, sorted by <see cref="GameTag.COST"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<int, List<Card>> CostMinionCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? StandardCostMinionCards : WildCostMinionCards;

		private static readonly Dictionary<int, List<Card>> StandardCostMinionCards = new Dictionary<int, List<Card>>();
		private static readonly Dictionary<int, List<Card>> WildCostMinionCards = new Dictionary<int, List<Card>>();


		/// <summary>
		/// Return a specific card from the given ID.
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
		public static Card FromId(string cardId)
		{
			return Data.Cards.ContainsKey(cardId) ? Data.Cards[cardId] : null;
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
			return Data.Cards.FirstOrDefault(x => x.Value.Name == cardName && x.Value.Collectible).Value;
		}

		/// <summary>
		/// Returns the first card that matches the provided asset id.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public static Card FromAssetId(int assetId)
		{
			return Data.Cards.Values.FirstOrDefault(x => x.AssetId == assetId);
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
				case CardSet.LOOTAPALOOZA:
					return "Kobolds and Catacombs";
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
