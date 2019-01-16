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
using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesKaraTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_01] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39753
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_00_01()
		{
			// TODO PrinceMalchezaar_KARA_00_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_01H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:60] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40080
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_00_01H()
		{
			// TODO PrinceMalchezaar_KARA_00_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_00_03] Medivh (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40081
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03()
		{
			// TODO Medivh_KARA_00_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_03c] Medivh (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03c()
		{
			// TODO Medivh_KARA_00_03c test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_00_03H] Medivh (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39756
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03H()
		{
			// TODO Medivh_KARA_00_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_04_01h] The Crone (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39281
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCrone_KARA_04_01h()
		{
			// TODO TheCrone_KARA_04_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Crone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Crone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Crone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_04_01heroic] The Crone (*) - COST:0 [ATK:0/HP:50] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39281
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCrone_KARA_04_01heroic()
		{
			// TODO TheCrone_KARA_04_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Crone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Crone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Crone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01b] Kindly Grandmother (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39298
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KindlyGrandmother_KARA_05_01b()
		{
			// TODO KindlyGrandmother_KARA_05_01b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kindly Grandmother"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kindly Grandmother"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kindly Grandmother"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01h] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39298
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigBadWolf_KARA_05_01h()
		{
			// TODO BigBadWolf_KARA_05_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Wolf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Bad Wolf"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01hheroic] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40266
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigBadWolf_KARA_05_01hheroic()
		{
			// TODO BigBadWolf_KARA_05_01hheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Wolf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Bad Wolf"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_06_02] Julianne (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39563
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Julianne_KARA_06_02()
		{
			// TODO Julianne_KARA_06_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Julianne"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Julianne"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Julianne"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_06_02heroic] Julianne (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40276
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Julianne_KARA_06_02heroic()
		{
			// TODO Julianne_KARA_06_02heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Julianne"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Julianne"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Julianne"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_07_01] Curator (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39641
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_07_01()
		{
			// TODO Curator_KARA_07_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_07_01heroic] Curator (*) - COST:0 [ATK:0/HP:40] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39641
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_07_01heroic()
		{
			// TODO Curator_KARA_07_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_08_01] Netherspite (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39680
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Netherspite_KARA_08_01()
		{
			// TODO Netherspite_KARA_08_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Netherspite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Netherspite"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_08_01H] Netherspite (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40062
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Netherspite_KARA_08_01H()
		{
			// TODO Netherspite_KARA_08_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Netherspite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Netherspite"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_01] Terestian Illhoof (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TerestianIllhoof_KARA_09_01()
		{
			// TODO TerestianIllhoof_KARA_09_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terestian Illhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terestian Illhoof"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terestian Illhoof"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_01heroic] Terestian Illhoof (*) - COST:0 [ATK:0/HP:40] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TerestianIllhoof_KARA_09_01heroic()
		{
			// TODO TerestianIllhoof_KARA_09_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terestian Illhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terestian Illhoof"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terestian Illhoof"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_02] Curator (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_09_02()
		{
			// TODO Curator_KARA_09_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_11_01] Nightbane (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39667
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightbane_KARA_11_01()
		{
			// TODO Nightbane_KARA_11_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightbane"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_11_01heroic] Nightbane (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39667
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightbane_KARA_11_01heroic()
		{
			// TODO Nightbane_KARA_11_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightbane"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_12_01] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39669
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadeOfAran_KARA_12_01()
		{
			// TODO ShadeOfAran_KARA_12_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shade of Aran"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shade of Aran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shade of Aran"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_12_01H] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40107
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadeOfAran_KARA_12_01H()
		{
			// TODO ShadeOfAran_KARA_12_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shade of Aran"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shade of Aran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shade of Aran"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [KARA_13_01] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39771
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NazraWildaxe_KARA_13_01()
		{
			// TODO NazraWildaxe_KARA_13_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nazra Wildaxe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nazra Wildaxe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nazra Wildaxe"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [KARA_13_01H] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40733
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NazraWildaxe_KARA_13_01H()
		{
			// TODO NazraWildaxe_KARA_13_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nazra Wildaxe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nazra Wildaxe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nazra Wildaxe"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_13_06] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Race: demon, Set: kara, 
		// --------------------------------------------------------
		// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40563
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_13_06()
		{
			// TODO PrinceMalchezaar_KARA_13_06 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_13_06H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Race: demon, Set: kara, 
		// --------------------------------------------------------
		// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40763
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_13_06H()
		{
			// TODO PrinceMalchezaar_KARA_13_06H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

	}

	public class HeroPowersKaraTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_02] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_00_02()
		{
			// TODO Legion_KARA_00_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_02H] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_00_02H()
		{
			// TODO Legion_KARA_00_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_04] Brilliance (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 3 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brilliance_KARA_00_04()
		{
			// TODO Brilliance_KARA_00_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brilliance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brilliance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brilliance"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_04H] Brilliance (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 3 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brilliance_KARA_00_04H()
		{
			// TODO Brilliance_KARA_00_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brilliance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brilliance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brilliance"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_04_02hp] Twister (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 100 damage. Can't be used if Dorothee is alive.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Twister_KARA_04_02hp()
		{
			// TODO Twister_KARA_04_02hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twister"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twister"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twister"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_05_01hp] Trembling (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b> Enemy minions are 1/1 and cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Trembling_KARA_05_01hp()
		{
			// TODO Trembling_KARA_05_01hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trembling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trembling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trembling"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_05_01hpheroic] Trembling (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b> Minions cost (1). Enemy minions are 1/1.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Trembling_KARA_05_01hpheroic()
		{
			// TODO Trembling_KARA_05_01hpheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trembling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trembling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trembling"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_06_03hp] True Love (*) - COST:4 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       If you don't have Romulo, summon him.
		// --------------------------------------------------------
		// Entourage: KARA_06_01
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueLove_KARA_06_03hp()
		{
			// TODO TrueLove_KARA_06_03hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Love"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Love"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Love"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_06_03hpheroic] True Love (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       If you don't have Romulo, summon him.
		// --------------------------------------------------------
		// Entourage: KARA_06_01
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueLove_KARA_06_03hpheroic()
		{
			// TODO TrueLove_KARA_06_03hpheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Love"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Love"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Love"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_07_02] Gallery Protection (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero has <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalleryProtection_KARA_07_02()
		{
			// TODO GalleryProtection_KARA_07_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gallery Protection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gallery Protection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gallery Protection"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_08_02] Nether Rage (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your hero +3 Attack this turn.
		// --------------------------------------------------------
		// Entourage: KARA_08_06, KARA_08_08
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherRage_KARA_08_02()
		{
			// TODO NetherRage_KARA_08_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nether Rage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nether Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nether Rage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_08_02H] Nether Rage (*) - COST:1 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your hero +8 Attack this turn.
		// --------------------------------------------------------
		// Entourage: KARA_08_06, KARA_08_08
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherRage_KARA_08_02H()
		{
			// TODO NetherRage_KARA_08_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nether Rage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nether Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nether Rage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_09_04] Dark Pact (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Only Icky Imps can damage Illhoof!
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPact_KARA_09_04()
		{
			// TODO DarkPact_KARA_09_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Pact"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Pact"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_11_02] Manastorm (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Players start with 10 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Manastorm_KARA_11_02()
		{
			// TODO Manastorm_KARA_11_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Manastorm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Manastorm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Manastorm"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_12_02] Ley Lines (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Both players have
		//       <b>Spell Damage +3</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeyLines_KARA_12_02()
		{
			// TODO LeyLines_KARA_12_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ley Lines"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ley Lines"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ley Lines"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_12_02H] Ley Lines (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Both players have
		//       <b>Spell Damage +5</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeyLines_KARA_12_02H()
		{
			// TODO LeyLines_KARA_12_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ley Lines"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ley Lines"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ley Lines"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [KARA_13_02] The Horde (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 3/2 Orc.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheHorde_KARA_13_02()
		{
			// TODO TheHorde_KARA_13_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Horde"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Horde"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [KARA_13_02H] The Horde (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 3/3 Orc
		//       with <b>Charge</b>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheHorde_KARA_13_02H()
		{
			// TODO TheHorde_KARA_13_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Horde"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Horde"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_13_13] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_13_13()
		{
			// TODO Legion_KARA_13_13 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_13_13H] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 6/6 Abyssals.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_13_13H()
		{
			// TODO Legion_KARA_13_13H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

	}

}
