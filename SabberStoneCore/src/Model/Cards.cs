#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Loader;
using static SabberStoneCore.Model.Cards;

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

			CardSet.GILNEAS, // 2018 The Witchwood
			CardSet.BOOMSDAY, // 2018 The Boomsday Project
			CardSet.TROLL, // 2018 Rastakhan’s Rumble

			CardSet.DALARAN, // 2019 Rise of Shadows
			CardSet.ULDUM, // 2019 Saviors of Uldum
			CardSet.DRAGONS // 2019 Descent of Dragons
		};

		/// <summary>
		/// Specifies which card sets combine into the WILD set.
		/// </summary>
		public static CardSet[] WildSets { get; } = {

			// standard
			CardSet.CORE,
			CardSet.EXPERT1,

			CardSet.GILNEAS,
			CardSet.BOOMSDAY,
			CardSet.TROLL,
			CardSet.DALARAN,
			CardSet.ULDUM,
			CardSet.DRAGONS,

			// wild
			CardSet.BRM,
			CardSet.GVG,
			CardSet.NAXX,
			CardSet.LOE,
			CardSet.TGT,
			CardSet.OG,
			CardSet.KARA,
			CardSet.GANGS,
			CardSet.UNGORO,
			CardSet.ICECROWN,
			CardSet.LOOTAPALOOZA,

			// hall of fame
			CardSet.HOF
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
			Card[] cards = cardLoader.Load();

			//string json = File.ReadAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardData.json");
			//string json = File.ReadAllText(Environment.CurrentDirectory + @"\cardData.json");
			//var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(Resources.cardDataJson);
			//File.WriteAllText(CardLoader.Path + @"SabberStone\HSProtoSim\Loader\Data\cardDataJson.txt", JsonConvert.SerializeObject(cards, Formatting.Indented));
			// Set as card definitions

			Data = new CardContainer();
			Data.Load(cards);

			//Log.Debug("Standard:");
			//Enum.GetValues(typeof(CardClass)).Cast<CardClass>().ToList().ForEach(heroClass =>
			for (int i = 0; i < HeroClasses.Length; i++)
			{
				CardClass heroClass = HeroClasses[i];
				Standard.Add(heroClass, All.Where(c =>
					c.Collectible &&
					(c.Class == heroClass ||
					 c.Class == CardClass.NEUTRAL && c.MultiClassGroup == 0 ||
					 c.MultiClassGroup == 1 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.HUNTER ||
					                            c.Class == CardClass.PALADIN || c.Class == CardClass.WARRIOR) ||
					 c.MultiClassGroup == 2 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.DRUID ||
					                            c.Class == CardClass.ROGUE || c.Class == CardClass.SHAMAN) ||
					 c.MultiClassGroup == 3 && (c.Class == CardClass.NEUTRAL || c.Class == CardClass.MAGE ||
					                            c.Class == CardClass.PRIEST || c.Class == CardClass.WARLOCK)) &&
					c.Type != CardType.HERO && StandardSets.Contains(c.Set)).ToList().AsReadOnly());
				//Log.Debug($"-> [{heroClass}] - {Standard[heroClass].Count} cards.");
				//});
			}

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

			// Temporary fix for Lotus Assassin
			Data.Cards["CFM_634"].Stealth = true;
			Data.Cards["CFM_634"].Tags.Add(GameTag.STEALTH, 1);

			// Basic Totems
			BasicTotems = new[]
			{
				FromId("NEW1_009"),	// Healing Totem
				FromId("CS2_050"),	// Searing Totem
				FromId("CS2_051"),	// Stoneclaw Totem
				FromId("CS2_052")	// Wraith of Air Totem
			};

			// filtered out cards ... cosmetic purpose
			Data.Cards.Remove("HERO_01c"); // HERO Deathwing
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
		public static Dictionary<CardClass, IReadOnlyList<Card>> Wild { get; } = new Dictionary<CardClass, IReadOnlyList<Card>>();

		/// <summary>
		/// Retrieves all standard cards ordered by card class.
		/// </summary>
		public static Dictionary<CardClass, IReadOnlyList<Card>> Standard { get; } = new Dictionary<CardClass, IReadOnlyList<Card>>();

		/// <summary>
		/// All cards belonging to the Standard set.
		/// </summary>
		public static ReadOnlyCollection<Card> AllStandard { get; }

		/// <summary>
		/// All cards belonging to the Wild set.
		/// </summary>
		public static ReadOnlyCollection<Card> AllWild { get; }

		/// <summary>
		/// A list of the four basic totems.
		/// [0]: Healing
		/// [1]: Searing
		/// [2]: Stoneclaw
		/// [3]: Wraith of Air
		/// </summary>
		public static IReadOnlyList<Card> BasicTotems { get; private set; }

		/// <summary>
		/// Retrieves the specified set of cards, sorted by <see cref="CardClass"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<CardClass, IReadOnlyList<Card>> FormatTypeClassCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? Standard : Wild;

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
		public static Card HeroCard(CardClass cardClass)
		{
			//return All.FirstOrDefault(c => c.Type == CardType.HERO && c.Id.StartsWith("HERO") && c.Class == cardClass);
			switch (cardClass)
			{
				case CardClass.DRUID:
					return FromId("HERO_06");
				case CardClass.HUNTER:
					return FromId("HERO_05");
				case CardClass.MAGE:
					return FromId("HERO_08");
				case CardClass.PALADIN:
					return FromId("HERO_04");
				case CardClass.PRIEST:
					return FromId("HERO_09");
				case CardClass.ROGUE:
					return FromId("HERO_03");
				case CardClass.SHAMAN:
					return FromId("HERO_02");
				case CardClass.WARLOCK:
					return FromId("HERO_07");
				case CardClass.WARRIOR:
					return FromId("HERO_01");
				default:
					throw new NotImplementedException();
			}
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
		/// Returns matching DK HeroPower Card of given Asset Id using direct mapping.
		/// </summary>
		public static Card GetHeroPower(int assetId)
		{
			switch (assetId)
			{
				case 42982:
					return FromId("ICC_481p");
				case 43188:
					return FromId("ICC_827p");
				case 43183:
					return FromId("ICC_828p");
				case 43013:
					return FromId("ICC_829p");
				case 45397:
					return FromId("ICC_830p");
				case 43181:
					return FromId("ICC_831p");
				case 43182:
					return FromId("ICC_832p");
				case 42944:
					return FromId("ICC_833h");
				case 45585:
					return FromId("ICC_834h");
				case 47631:
					return FromId("GIL_504h");
				case 48145:
					return FromId("BOT_238p");
				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Retrieves the specified set of cards, sorted by <see cref="GameTag.COST"/>.
		/// </summary>
		/// <param name="formatType"></param>
		/// <returns></returns>
		public static Dictionary<int, List<Card>> CostMinionCards(FormatType formatType) => formatType == FormatType.FT_STANDARD ? StandardCostMinionCards : WildCostMinionCards;

		private static readonly Dictionary<int, List<Card>> StandardCostMinionCards;
		private static readonly Dictionary<int, List<Card>> WildCostMinionCards;


		/// <summary>
		/// Return a specific card from the given ID.
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
		public static Card FromId(string cardId)
		{
			return Data.Cards[cardId];
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
				case CardSet.GILNEAS:
					return "The Witchwood";
				case CardSet.BOOMSDAY:
					return "The Boomsday Project";
				case CardSet.TROLL:
					return "Rastakhan\'s Rumble";
				case CardSet.DALARAN:
					return "Rise of Shadows";
				case CardSet.ULDUM:
					return "Saviors of Uldum";
				case CardSet.DRAGONS:
					return "Descent of Dragons";
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

			var str = new StringBuilder();

			int totImpl = 0;
			int totCards = 0;
			foreach (CardSet set in StandardSets)
			{
				int impl = implemented.FirstOrDefault(p => p.Key == set)?.Count ?? 0;
				totImpl += impl;
				int tot = all.FirstOrDefault(p => p.Key == set).Count;
				str.AppendLine($"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards");
				totCards += tot;
			}

			str.AppendLine($"Total Standard => {totImpl * 100 / totCards}% from {totCards} Cards");
			str.AppendLine();

			totImpl = 0;
			totCards = 0;
			foreach (CardSet set in WildSets)
			{
				int impl = implementedWild.FirstOrDefault(p => p.Key == set)?.Count ?? 0;
				totImpl += impl;
				int tot = allWild.FirstOrDefault(p => p.Key == set).Count;
				str.AppendLine($"{CardSetToName(set)} => {impl * 100 / tot}% from {tot} Cards");
				totCards += tot;
			}

			str.AppendLine($"Total Wild => {totImpl * 100 / totCards}% from {totCards} Cards");

			IEnumerable<IGrouping<CardSet, Card>> notImplementedStandard = standard
				.Where(c => !c.Implemented)
				.GroupBy(c => c.Set);

			str.AppendLine("### Not yet implemented standard cards");
			foreach (IGrouping<CardSet, Card> group in notImplementedStandard)
			{
				str.AppendLine($"#### {CardSetToName(group.Key)}");
				foreach (Card c in group)
				{
					str.AppendLine($"- [{c.Id}] {c.Name}");
				}
			}

			str.AppendLine();

			IEnumerable<IGrouping<CardSet, Card>> notImplementedWild = wild
				.Where(c => !c.Implemented)
				.GroupBy(c => c.Set)
				.Where(c => WildSets.Contains(c.Key) && !StandardSets.Contains(c.Key));

			str.AppendLine("### Not yet implemented wild cards");
			foreach (IGrouping<CardSet, Card> group in notImplementedWild)
			{
				str.AppendLine($"#### {CardSetToName(group.Key)}");
				foreach (Card c in group)
				{
					str.AppendLine($"- [{c.Id}] {c.Name}");
				}
			}

			return str.ToString();
		}
	}
}
