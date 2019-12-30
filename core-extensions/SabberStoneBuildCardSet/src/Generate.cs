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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SabberStoneBuildCardSet
{
	public class Generate
	{
		private static readonly string Path = Directory.GetCurrentDirectory(); // @"C:\Users\admin\Source\Repos\";
		private static readonly Regex Rgx = new Regex("[^a-zA-Z0-9 -]");

		private static bool Adventure;

		private static string[] MapCardSetAdventureString(CardSet cardSet)
		{
			switch(cardSet)
			{
				case CardSet.BRM:
					return new[] { "BRMA" };
				case CardSet.NAXX:
					return new[] { "NAX" };
				case CardSet.LOE:
					return new[] { "LOEA" };
				case CardSet.KARA:
					return new[] { "KARA", "KAR_A", "KAR_a" };
				case CardSet.ICECROWN:
					return new[] { "ICCA" };
				case CardSet.LOOTAPALOOZA:
					return new[] { "LOOTA" };
				case CardSet.GILNEAS:
					return new[] { "GILA" };
				case CardSet.BOOMSDAY:
					return new[] { "BOTA" };
				case CardSet.TROLL:
					return new[] { "TRLA" };
				case CardSet.DALARAN:
					return new[] { "DALA" };
				case CardSet.ULDUM:
					return new[] { "ULDA" };
				default:
					return new[] { String.Empty};
			}
		}

		private static string UpperCaseFirst(string s)
		{
			if (String.IsNullOrEmpty(s))
			{
				return String.Empty;
			}
			char[] a = s.ToLower().ToCharArray();
			a[0] = Char.ToUpper(a[0]);
			return new string(a);
		}

		public static void CardSetFile(IEnumerable<Card> values, bool adventure = true)
		{
			// set static for adventure implementation ... ugly impl. who cares!!!
			Adventure = adventure;

			//var cardSets = new[] // {CardSet.EXPERT1}; //Enum.GetValues(typeof(CardSet));
			//   // {CardSet.FP2, CardSet.TGT, CardSet.LOE, CardSet.OG, CardSet.KARA, CardSet.GANGS};
			//{ CardSet.GVG};
			//CardSet[] cardSets = new[] { CardSet.NAXX, CardSet.KARA, CardSet.BRM, CardSet.LOE, CardSet.ICECROWN  };
			//CardSet[] cardSets = new[] { CardSet.CORE, CardSet.EXPERT1, CardSet.UNGORO, CardSet.LOOTAPALOOZA, CardSet.ICECROWN, CardSet.GILNEAS, CardSet.BOOMSDAY, CardSet.TROLL, CardSet.HOF };
			//CardSet[] cardSets = new[] { CardSet.ULDUM };
			var cardSets = Enum.GetValues(typeof(CardSet));
			foreach (CardSet cardSet in cardSets)
			{
				string className = UpperCaseFirst(cardSet.ToString()) + "CardsGen" + (adventure?"Adv":"");
				string path = Path + @"\CardSets\";
				string classNameTest = UpperCaseFirst(cardSet.ToString()) + "CardsGen"+ (adventure?"Adv":"") +"Test";
				string pathTest = Path + @"\CardSetsTest\";

				WriteCardSetFile(cardSet, className, path, values);
				WriteCardSetTestFile(cardSet, classNameTest, pathTest, values);
			}
			Console.ReadKey();
		}

		private static void WriteCardSetFile(CardSet cardSet, string className, string path, IEnumerable<Card> values)
		{
			Array cardClasses = Enum.GetValues(typeof(CardClass));
			var methods = new List<string>();

			var str = new StringBuilder();
			str.AppendLine("using System.Collections.Generic;");
			str.AppendLine("using SabberStoneCore.Actions;");
			str.AppendLine("using SabberStoneCore.Auras;");
			str.AppendLine("using SabberStoneCore.Enchants;");
			str.AppendLine("using SabberStoneCore.Conditions;");
			str.AppendLine("using SabberStoneCore.Enums;");
			str.AppendLine("using SabberStoneCore.Model;");
			str.AppendLine("using SabberStoneCore.Model.Zones;");
			str.AppendLine("using SabberStoneCore.Model.Entities;");
			str.AppendLine("using SabberStoneCore.Tasks;");
			str.AppendLine("using SabberStoneCore.Tasks.SimpleTasks;");
			str.AppendLine("using SabberStoneCore.Triggers;");
			str.AppendLine("// ReSharper disable RedundantEmptyObjectOrCollectionInitializer");
			str.AppendLine();
			str.AppendLine("namespace SabberStoneCore.CardSets.Undefined");
			str.AppendLine("{");
			str.AppendLine($"\tpublic class {className}");
			str.AppendLine("\t{");

			string heroes = CreateMethode("Heroes", values, null, cardSet, CardType.HERO, CardClass.INVALID);
			if (heroes != null)
			{
				methods.Add("Heroes");
				str.Append(heroes);
				str.AppendLine();
			}

			string heroPowers = CreateMethode("HeroPowers", values, null, cardSet, CardType.HERO_POWER, CardClass.INVALID);
			if (heroPowers != null)
			{
				methods.Add("HeroPowers");
				str.Append(heroPowers);
				str.AppendLine();
			}

			foreach (CardClass cardClass in cardClasses)
			{
				if (cardClass == CardClass.NEUTRAL || cardClass == CardClass.INVALID)
					continue;

				string cardClassString = CreateMethode(UpperCaseFirst(cardClass.ToString()), values, true, cardSet, CardType.INVALID, cardClass);
				if (cardClassString != null)
				{
					methods.Add(UpperCaseFirst(cardClass.ToString()));
					str.Append(cardClassString);
					str.AppendLine();
				}
				string cardClassNonCollectString = CreateMethode(UpperCaseFirst(cardClass.ToString()) + "NonCollect", values, false, cardSet, CardType.INVALID, cardClass);
				if (cardClassNonCollectString != null)
				{
					methods.Add(UpperCaseFirst(cardClass.ToString()) + "NonCollect");
					str.Append(cardClassNonCollectString);
					str.AppendLine();
				}
			}

			string neutralClassString = CreateMethode(UpperCaseFirst(CardClass.NEUTRAL.ToString()), values, true, cardSet,
				CardType.INVALID, CardClass.NEUTRAL);
			if (neutralClassString != null)
			{
				methods.Add(UpperCaseFirst(CardClass.NEUTRAL.ToString()));
				str.Append(neutralClassString);
				str.AppendLine();
			}

			string neutralNonCollectClassString = CreateMethode(UpperCaseFirst(CardClass.NEUTRAL.ToString()) + "NonCollect", values, false,
				cardSet, CardType.INVALID, CardClass.NEUTRAL);
			if (neutralNonCollectClassString != null)
			{
				methods.Add(UpperCaseFirst(CardClass.NEUTRAL.ToString()) + "NonCollect");
				str.Append(neutralNonCollectClassString);
				str.AppendLine();
			}

			str.AppendLine("\t\tpublic static void AddAll(Dictionary<string, CardDef> cards)");
			str.AppendLine("\t\t{");
			methods.ForEach(p => str.AppendLine($"\t\t\t{p}(cards);"));
			str.AppendLine("\t\t}");
			str.AppendLine("\t}");
			str.AppendLine("}");

			string file = path + className + ".cs";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			Console.WriteLine($"Writing cardset class: {file}.");
			File.WriteAllText(file, str.ToString());
		}

		private static string CreateMethode(string name,
			IEnumerable<Card> values, bool? collect, CardSet set, CardType type,
			CardClass cardClass)
		{
			string[] idString = MapCardSetAdventureString(set);
			IOrderedEnumerable<Card> valuesOrdered = values
				.Where(p => p.Set == set
							&& (collect == null || p.Collectible == collect)
							&& (type == CardType.INVALID && p.Type != CardType.HERO && p.Type != CardType.HERO_POWER || p.Type == type)
							&& (cardClass == CardClass.INVALID || p.Class == cardClass)
							&& (idString[0] == String.Empty || Adventure && idString.Any(t => p.Id.StartsWith(t)) || !Adventure && !idString.Any(t => p.Id.StartsWith(t))))
							.OrderBy(p => p.Type.ToString());

			if (!valuesOrdered.Any())
			{
				return null;
			}
			var str = new StringBuilder();
			str.AppendLine($"\t\tprivate static void {name}(IDictionary<string, CardDef> cards)");
			str.AppendLine("\t\t{");
			foreach (Card card in valuesOrdered)
			{
				str.Append(AddCardString(card));
				str.Append(AddCardCode(card));
			}
			str.AppendLine("\t\t}");
			return str.ToString();
		}

		private static string AddCardString(Card card, int tabs = 2)
		{
			string tab = tabs == 2 ? "\t\t" : "\t";
			string atkHpStr = "";
			if (card.Tags.ContainsKey(GameTag.ATK) || card.Tags.ContainsKey(GameTag.HEALTH))
			{
				int atk = card[GameTag.ATK];
				int hp = card[GameTag.HEALTH];
				atkHpStr = $"[ATK:{atk}/HP:{hp}] ";
			}

			string cardRace = "";
			if (card.GetRawRace() != Race.INVALID)
				cardRace = $"Race: {card.GetRawRace().ToString().ToLower()}, ";
			string cardFac = "";
			if (card.Faction != Faction.INVALID)
				cardFac = $"Fac: {card.Faction.ToString().ToLower()}, ";
			string cardSet = "";
			if (card.Set != CardSet.INVALID)
				cardSet = $"Set: {card.Set.ToString().ToLower()}, ";
			string cardRarity = "";
			if (card.Rarity != Rarity.INVALID)
				cardRarity = $"Rarity: {card.Rarity.ToString().ToLower()}";

			var except = new List<GameTag>
			{
				GameTag.COST,
				GameTag.ATK,
				GameTag.HEALTH,
				GameTag.CARD_SET,
				GameTag.CARDTYPE,
				GameTag.RARITY,
				GameTag.AttackVisualType,
				GameTag.CLASS,
				GameTag.CARDRACE,
				GameTag.FACTION,
				GameTag.COLLECTIBLE,
				GameTag.DevState,
				GameTag.ENCHANTMENT_BIRTH_VISUAL,
				GameTag.ENCHANTMENT_IDLE_VISUAL,
				GameTag.TRIGGER_VISUAL
			};

			string cardType = card.Type.ToString();

			var str = new StringBuilder();
			str.AppendLine($"{tab}\t// ----------------{(" " + cardType + " - " + card.Class).PadLeft(40, '-')}");
			str.AppendLine(
				$"{tab}\t// [{card.Id}] {card.Name} {(!card.Collectible ? "(*) " : "")}- COST:{card.Cost} {atkHpStr}");
			str.AppendLine($"{tab}\t// - {cardRace}{cardFac}{cardSet}{cardRarity}");
			if (card.Text != null)
			{
				str.AppendLine($"{tab}\t// --------------------------------------------------------");
				str.Append($"{tab}\t// Text: {card.Text.Replace("\n", $"\n{tab}\t//       ")}\n");
			}
			if (card.Entourage != null && card.Entourage.Length > 0)
			{
				str.AppendLine($"{tab}\t// --------------------------------------------------------");
				str.AppendLine($"{tab}\t// Entourage: {String.Join(", ", card.Entourage)}");
			}
			bool wHead = true;
			foreach (GameTag key in card.Tags.Keys)
			{
				if (except.Contains(key))
					continue;

				if (wHead)
				{
					str.AppendLine($"{tab}\t// --------------------------------------------------------");
					str.AppendLine($"{tab}\t// GameTag:");
					wHead = false;
				}
				string t = null;
				if (Tag.TypedTags.ContainsKey(key))
				{
					t = Enum.GetName(Tag.TypedTags[key], card.Tags[key]);
				}

				str.AppendLine($"{tab}\t// - {key} = {(t ?? card.Tags[key].ToString())}");
			}

			if (card.PlayRequirements.Count > 0)
			{
				str.AppendLine($"{tab}\t// --------------------------------------------------------");
				str.AppendLine($"{tab}\t// PlayReq:");
			}
			foreach (PlayReq key in card.PlayRequirements.Keys)
			{
				str.AppendLine($"{tab}\t// - {key} = {card.PlayRequirements[key]}");
			}

			wHead = true;
			foreach (GameTag key in card.RefTags.Keys)
			{
				if (wHead)
				{
					str.AppendLine($"{tab}\t// --------------------------------------------------------");
					str.AppendLine($"{tab}\t// RefTag:");
					wHead = false;
				}
				string t = null;
				if (Tag.TypedTags.ContainsKey(key))
				{
					t = Enum.GetName(Tag.TypedTags[key], card.Tags[key]);
				}
				str.AppendLine($"{tab}\t// - {key} = {t ?? card.RefTags[key].ToString()}");
			}
			str.AppendLine($"{tab}\t// --------------------------------------------------------");
			return str.ToString();
		}

		internal static void EnchantmentLeftOver(Card c)
		{
			throw new NotImplementedException();
		}

		private static string AddCardCode(Card card)
		{
			var str = new StringBuilder();

			string enchantId = Cards.All
				.Where(p => p.Id.Contains(card.Id) && p.Id.Length > card.Id.Length && p.Type == CardType.ENCHANTMENT)
				.Select(p => p.Id).FirstOrDefault();
			string playReqs = String.Join(',', card.PlayRequirements.Select(p => $"{{PlayReq.{p.Key},{p.Value}}}"));
			string entourages = String.Join(',', card.Entourage.Select(p => $"\"{p}\""));
			str.AppendLine($"\t\t\tcards.Add(\"{card.Id}\", new CardDef(" +
				$"{(entourages.Length == 0 ? "" : $"new[] {{{entourages}}}, ")}" +
				$"{(playReqs.Length == 0? "" : $"new Dictionary<PlayReq, int>() {{{playReqs}}}, ")}" +
				$"new Power");
			str.AppendLine($"\t\t\t{{");
			str.AppendLine($"\t\t\t\t// TODO [{card.Id}] {card.Name} && Test: {card.Name}_{card.Id}");
			if (enchantId != null)
				str.AppendLine($"\t\t\t\tInfoCardId = \"{enchantId}\",");
			if (card.Type == CardType.ENCHANTMENT)
				str.AppendLine($"\t\t\t\t//Enchant = Enchants.Enchants.GetAutoEnchantFromText(\"{card.Id}\")");
			else
			{
				str.AppendLine($"\t\t\t\t//PowerTask = null,");
				str.AppendLine($"\t\t\t\t//Trigger = null,");
			}

			str.AppendLine($"\t\t\t}}));\n");
			return str.ToString();
		}

		private static void WriteCardSetTestFile(CardSet cardSet, string className, string path, IEnumerable<Card> values)
		{
			Array cardClasses = Enum.GetValues(typeof(CardClass));

			var str = new StringBuilder();
			str.AppendLine("using Xunit;");
			str.AppendLine("using SabberStoneCore.Actions;");
			str.AppendLine("using SabberStoneCore.Auras;");
			str.AppendLine("using SabberStoneCore.Enums;");
			str.AppendLine("using SabberStoneCore.Config;");
			str.AppendLine("using SabberStoneCore.Model;");
			str.AppendLine("using SabberStoneCore.Model.Entities;");
			str.AppendLine("using System.Collections.Generic;");
			str.AppendLine("using System.Linq;");
			str.AppendLine();
			str.AppendLine("namespace SabberStoneCoreTest.CardSets.Undefined");
			str.AppendLine("{");

			string heroes = CreateMethodeTest("Heroes", values, null, cardSet, CardType.HERO, CardClass.INVALID);
			if (heroes != null)
			{
				str.Append(heroes);
				str.AppendLine();
			}

			string heroPowers = CreateMethodeTest("HeroPowers", values, null, cardSet, CardType.HERO_POWER, CardClass.INVALID);
			if (heroPowers != null)
			{
				str.Append(heroPowers);
				str.AppendLine();
			}

			foreach (CardClass cardClass in cardClasses)
			{
				if (cardClass == CardClass.NEUTRAL || cardClass == CardClass.INVALID)
					continue;

				string cardClassString = CreateMethodeTest(UpperCaseFirst(cardClass.ToString()), values, true, cardSet,
					CardType.INVALID, cardClass);
				if (cardClassString != null)
				{
					str.Append(cardClassString);
					str.AppendLine();
				}
			}

			string neutralCardString = CreateMethodeTest(UpperCaseFirst(CardClass.NEUTRAL.ToString()), values, true, cardSet,
				CardType.INVALID, CardClass.NEUTRAL);
			if (neutralCardString != null)
			{
				str.Append(neutralCardString);
				str.AppendLine();
			}

			str.AppendLine("}");

			string file = path + className + ".cs";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			Console.WriteLine($"Writing test class: {file}.");
			File.WriteAllText(file, str.ToString());
		}

		private static string CreateMethodeTest(string name,
			IEnumerable<Card> values, bool? collect, CardSet set, CardType type,
			CardClass cardClass)
		{
			string[] idString = MapCardSetAdventureString(set);
			IOrderedEnumerable<Card> valuesOrdered = values.Where(p => p.Set == set
							&& (collect == null || p.Collectible == collect)
							&& (type == CardType.INVALID && p.Type != CardType.HERO && p.Type != CardType.HERO_POWER || p.Type == type)
							&& (cardClass == CardClass.INVALID || p.Class == cardClass)
							&& (idString[0] == String.Empty || Adventure && idString.Any(t => p.Id.StartsWith(t)) || !Adventure && !idString.Any(t => p.Id.StartsWith(t))))
							.OrderBy(p => p.Type.ToString());
			if (!valuesOrdered.Any())
			{
				return null;
			}
			var str = new StringBuilder();
			//str.AppendLine("\t[TestClass]");
			str.AppendLine($"\tpublic class {name}{UpperCaseFirst(set.ToString())}Test");
			str.AppendLine("\t{");
			foreach (Card card in valuesOrdered)
			{
				var cardNameRx = Rgx.Replace(card.Name, "").Split(' ', '-').ToList();
				string cardName = String.Join("", cardNameRx.Select(p => UpperCaseFirst(p)).ToList());
				string typeName = UpperCaseFirst(card.Type.ToString().ToLower());
				CardClass heroClass1 = card.Class == CardClass.INVALID || card.Class == CardClass.NEUTRAL
					? CardClass.MAGE
					: card.Class;
				CardClass heroClass2 = card.Class == CardClass.INVALID || card.Class == CardClass.NEUTRAL
					? CardClass.MAGE
					: card.Class;
				str.Append(AddCardString(card, 1));
				str.AppendLine("\t\t[Fact(Skip = \"ignore\")]");
				str.AppendLine($"\t\tpublic void {cardName}_{card.Id}()");
				str.AppendLine("\t\t{");
				str.AppendLine($"\t\t\t// TODO {cardName}_{card.Id} test");
				str.AppendLine("\t\t\tvar game = new Game(new GameConfig");
				str.AppendLine("\t\t\t{");
				str.AppendLine("\t\t\t\tStartPlayer = 1,");
				str.AppendLine($"\t\t\t\tPlayer1HeroClass = CardClass.{heroClass1},");
				str.AppendLine($"\t\t\t\tPlayer1Deck = new List<Card>()");
				str.AppendLine("\t\t\t\t{");
				str.AppendLine($"\t\t\t\t\tCards.FromName(\"{card.Name}\"),");
				str.AppendLine("\t\t\t\t},");
				str.AppendLine($"\t\t\t\tPlayer2HeroClass = CardClass.{heroClass2},");
				str.AppendLine("\t\t\t\tShuffle = false,");
				str.AppendLine("\t\t\t\tFillDecks = true,");
				str.AppendLine("\t\t\t\tFillDecksPredictably = true");
				str.AppendLine("\t\t\t});");
				str.AppendLine("\t\t\tgame.StartGame();");
				str.AppendLine("\t\t\tgame.Player1.BaseMana = 10;");
				str.AppendLine("\t\t\tgame.Player2.BaseMana = 10;");
				str.AppendLine($"\t\t\t//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(\"{card.Name}\"));");
				str.AppendLine($"\t\t\t//{typeName} testCard = game.ProcessCard<{typeName}>(\"{card.Name}\");");
				str.AppendLine("\t\t}");
				str.AppendLine();
			}
			str.AppendLine("\t}");
			return str.ToString();
		}

		public static void EnchantmentLeftOver(IEnumerable<Card> cardsValues)
		{
			var str = new StringBuilder();
			str.AppendLine($"CARD_ID|IMPL.|SET|FORMAT|TYPE|CLASS|NAME|TEXT");
			foreach (Card card in cardsValues)
			{
				if (!card.Collectible || !Cards.StandardSets.Contains(card.Set) && !card.Implemented)
					continue;

				str.AppendLine($"{card.Id}|{card.Implemented}|{card.Set}|{(Cards.StandardSets.Contains(card.Set) ? "S" : "W")}|{card.Type}|{card.Class}|{card.Name}|{RemoveLineEndings(card.Text)}");

				//if (!card.Collectible || card.Implemented)
				//    continue;
				//str.AppendLine($"{card.AssetId}");
			}

			string path = Path + @"\Statistics\";
			string file = path + "echantmentsleft.csv";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			Console.WriteLine($"Writing statistics: {file}.");
			File.WriteAllText(file, str.ToString());
			Console.ReadKey();
		}

		public static string RemoveLineEndings(string value)
		{
			if (String.IsNullOrEmpty(value))
			{
				return value;
			}
			string lineSeparator = ((char)0x2028).ToString();
			string paragraphSeparator = ((char)0x2029).ToString();

			return value
				.Replace("\r\n", String.Empty)
				.Replace("\n", " ")
				.Replace("\r", " ")
				.Replace(lineSeparator, " ")
				.Replace(paragraphSeparator, " ")
				.Replace("[x]", String.Empty).Trim()
				;
		}

		internal static void NamingConventions(IEnumerable<Card> cardsValues)
		{
			var str = new StringBuilder();

			var dict = new Dictionary<string, int>();

			foreach (Card card in cardsValues)
			{
				string[] splits = card.Id.Split('_');

				if (dict.ContainsKey(splits[0]))
				{
					dict[splits[0]]++;
				}
				else
				{
					dict[splits[0]] = 1;
				}


				//str.AppendLine($"{card.Id}|{card.Implemented}|{card.Set}|{(Cards.StandardSets.Contains(card.Set) ? "S" : "W")}|{card.Type}|{card.Class}|{card.Name}|{RemoveLineEndings(card.Text)}");

				//if (!card.Collectible || card.Implemented)
				//    continue;
				//str.AppendLine($"{card.AssetId}");
			}

			foreach(KeyValuePair<string, int> keyValue in dict.OrderBy(x => x.Key))
			{
				Console.WriteLine($"key: {keyValue.Key} -> {keyValue.Value}");
			}

			//string path = Path + @"\Statistics\";
			//string file = path + "echantmentsleft.csv";
			//if (!Directory.Exists(path))
			//	Directory.CreateDirectory(path);
			//Console.WriteLine($"Writing statistics: {file}.");
			//File.WriteAllText(file, str.ToString());
			Console.ReadKey();
		}
	}
}
