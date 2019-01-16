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
	public class HeroesNaxxTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [NAX10_01] Patchwerk (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 1886
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Patchwerk_NAX10_01()
		{
			// TODO Patchwerk_NAX10_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patchwerk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patchwerk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patchwerk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX10_01H] Patchwerk (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 2133
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Patchwerk_NAX10_01H()
		{
			// TODO Patchwerk_NAX10_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patchwerk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patchwerk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patchwerk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX11_01] Grobbulus (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1888
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grobbulus_NAX11_01()
		{
			// TODO Grobbulus_NAX11_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grobbulus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grobbulus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grobbulus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX11_01H] Grobbulus (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2135
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grobbulus_NAX11_01H()
		{
			// TODO Grobbulus_NAX11_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grobbulus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grobbulus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grobbulus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX12_01] Gluth (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1891
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gluth_NAX12_01()
		{
			// TODO Gluth_NAX12_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gluth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gluth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gluth"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX12_01H] Gluth (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2141
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gluth_NAX12_01H()
		{
			// TODO Gluth_NAX12_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gluth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gluth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gluth"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX13_01] Thaddius (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1897
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thaddius_NAX13_01()
		{
			// TODO Thaddius_NAX13_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thaddius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thaddius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thaddius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX13_01H] Thaddius (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1897
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thaddius_NAX13_01H()
		{
			// TODO Thaddius_NAX13_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thaddius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thaddius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thaddius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX14_01] Sapphiron (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1905
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sapphiron_NAX14_01()
		{
			// TODO Sapphiron_NAX14_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sapphiron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sapphiron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sapphiron"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX14_01H] Sapphiron (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1905
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sapphiron_NAX14_01H()
		{
			// TODO Sapphiron_NAX14_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sapphiron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sapphiron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sapphiron"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX15_01] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1901
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_NAX15_01()
		{
			// TODO Kelthuzad_NAX15_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kel'Thuzad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kel'Thuzad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kel'Thuzad"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX15_01H] Kel'Thuzad (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2148
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_NAX15_01H()
		{
			// TODO Kelthuzad_NAX15_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kel'Thuzad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kel'Thuzad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kel'Thuzad"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX1_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1831
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anubrekhan_NAX1_01()
		{
			// TODO Anubrekhan_NAX1_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'Rekhan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'Rekhan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'Rekhan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX1h_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2103
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anubrekhan_NAX1h_01()
		{
			// TODO Anubrekhan_NAX1h_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'Rekhan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'Rekhan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'Rekhan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX2_01] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1840
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandWidowFaerlina_NAX2_01()
		{
			// TODO GrandWidowFaerlina_NAX2_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Widow Faerlina"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Widow Faerlina"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Widow Faerlina"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX2_01H] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2105
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandWidowFaerlina_NAX2_01H()
		{
			// TODO GrandWidowFaerlina_NAX2_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Widow Faerlina"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Widow Faerlina"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Widow Faerlina"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX3_01] Maexxna (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1867
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maexxna_NAX3_01()
		{
			// TODO Maexxna_NAX3_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maexxna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maexxna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maexxna"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX3_01H] Maexxna (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2107
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maexxna_NAX3_01H()
		{
			// TODO Maexxna_NAX3_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maexxna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maexxna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maexxna"));
		}

		// -------------------------------------------- HERO - MAGE
		// [NAX4_01] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1849
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NothThePlaguebringer_NAX4_01()
		{
			// TODO NothThePlaguebringer_NAX4_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Noth the Plaguebringer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Noth the Plaguebringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Noth the Plaguebringer"));
		}

		// -------------------------------------------- HERO - MAGE
		// [NAX4_01H] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2115
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NothThePlaguebringer_NAX4_01H()
		{
			// TODO NothThePlaguebringer_NAX4_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Noth the Plaguebringer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Noth the Plaguebringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Noth the Plaguebringer"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [NAX5_01] Heigan the Unclean (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1854
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeiganTheUnclean_NAX5_01()
		{
			// TODO HeiganTheUnclean_NAX5_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heigan the Unclean"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heigan the Unclean"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heigan the Unclean"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [NAX5_01H] Heigan the Unclean (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2117
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeiganTheUnclean_NAX5_01H()
		{
			// TODO HeiganTheUnclean_NAX5_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heigan the Unclean"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heigan the Unclean"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heigan the Unclean"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX6_01] Loatheb (*) - COST:0 [ATK:0/HP:75] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1862
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Loatheb_NAX6_01()
		{
			// TODO Loatheb_NAX6_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loatheb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loatheb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loatheb"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX6_01H] Loatheb (*) - COST:0 [ATK:0/HP:99] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2119
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Loatheb_NAX6_01H()
		{
			// TODO Loatheb_NAX6_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loatheb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loatheb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loatheb"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX7_01] Instructor Razuvious (*) - COST:0 [ATK:0/HP:40] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1870
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InstructorRazuvious_NAX7_01()
		{
			// TODO InstructorRazuvious_NAX7_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Instructor Razuvious"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Instructor Razuvious"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Instructor Razuvious"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX7_01H] Instructor Razuvious (*) - COST:0 [ATK:0/HP:55] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2129
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InstructorRazuvious_NAX7_01H()
		{
			// TODO InstructorRazuvious_NAX7_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Instructor Razuvious"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Instructor Razuvious"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Instructor Razuvious"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX8_01] Gothik the Harvester (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1872
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GothikTheHarvester_NAX8_01()
		{
			// TODO GothikTheHarvester_NAX8_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gothik the Harvester"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gothik the Harvester"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gothik the Harvester"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX8_01H] Gothik the Harvester (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2121
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GothikTheHarvester_NAX8_01H()
		{
			// TODO GothikTheHarvester_NAX8_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gothik the Harvester"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gothik the Harvester"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gothik the Harvester"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX9_01] Baron Rivendare (*) - COST:0 [ATK:0/HP:7] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1883
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronRivendare_NAX9_01()
		{
			// TODO BaronRivendare_NAX9_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Rivendare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Rivendare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Rivendare"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX9_01H] Baron Rivendare (*) - COST:0 [ATK:0/HP:14] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1883
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronRivendare_NAX9_01H()
		{
			// TODO BaronRivendare_NAX9_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Rivendare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Rivendare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Rivendare"));
		}

	}

	public class HeroPowersNaxxTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX10_03] Hateful Strike (*) - COST:4 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HatefulStrike_NAX10_03()
		{
			// TODO HatefulStrike_NAX10_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hateful Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hateful Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hateful Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX10_03H] Hateful Strike (*) - COST:4 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HatefulStrike_NAX10_03H()
		{
			// TODO HatefulStrike_NAX10_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hateful Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hateful Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hateful Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX11_02] Poison Cloud (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all minions. If any die, summon a slime.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonCloud_NAX11_02()
		{
			// TODO PoisonCloud_NAX11_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Cloud"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Cloud"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Cloud"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX11_02H] Poison Cloud (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to all enemies. If any die, summon a slime.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonCloud_NAX11_02H()
		{
			// TODO PoisonCloud_NAX11_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Cloud"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Cloud"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Cloud"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX12_02] Decimate (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Change the Health of all minions to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decimate_NAX12_02()
		{
			// TODO Decimate_NAX12_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decimate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decimate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decimate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX12_02H] Decimate (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Change the Health of enemy minions to 1.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decimate_NAX12_02H()
		{
			// TODO Decimate_NAX12_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decimate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decimate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decimate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX13_02] Polarity Shift (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Swap the Attack and Health of all minions.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PolarityShift_NAX13_02()
		{
			// TODO PolarityShift_NAX13_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Polarity Shift"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polarity Shift"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Polarity Shift"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX14_02] Frost Breath (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy all enemy minions that aren't <b>Frozen</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBreath_NAX14_02()
		{
			// TODO FrostBreath_NAX14_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Breath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Breath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_02] Frost Blast (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to the enemy hero and <b>Freeze</b> it.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBlast_NAX15_02()
		{
			// TODO FrostBlast_NAX15_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_02H] Frost Blast (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero and <b>Freeze</b> it.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBlast_NAX15_02H()
		{
			// TODO FrostBlast_NAX15_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_04] Chains (*) - COST:8 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Take control of a random enemy minion until end of turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chains_NAX15_04()
		{
			// TODO Chains_NAX15_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chains"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chains"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chains"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_04H] Chains (*) - COST:8 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Take control of a random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chains_NAX15_04H()
		{
			// TODO Chains_NAX15_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chains"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chains"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chains"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX1_04] Skitter (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 3/1 Nerubian.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skitter_NAX1_04()
		{
			// TODO Skitter_NAX1_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skitter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skitter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skitter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX1h_04] Skitter (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 4/4 Nerubian.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skitter_NAX1h_04()
		{
			// TODO Skitter_NAX1h_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skitter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skitter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skitter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX2_03] Rain of Fire (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Fire a missile for each card in your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfFire_NAX2_03()
		{
			// TODO RainOfFire_NAX2_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Fire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rain of Fire"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX2_03H] Rain of Fire (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Fire a missile for each card in your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfFire_NAX2_03H()
		{
			// TODO RainOfFire_NAX2_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Fire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rain of Fire"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX3_02] Web Wrap (*) - COST:3 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return a random enemy minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WebWrap_NAX3_02()
		{
			// TODO WebWrap_NAX3_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Web Wrap"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Web Wrap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Web Wrap"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX3_02H] Web Wrap (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return 2 random enemy minions to your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WebWrap_NAX3_02H()
		{
			// TODO WebWrap_NAX3_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Web Wrap"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Web Wrap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Web Wrap"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX4_04] Raise Dead (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever an enemy dies, raise a 1/1 Skeleton.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaiseDead_NAX4_04()
		{
			// TODO RaiseDead_NAX4_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raise Dead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raise Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raise Dead"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX4_04H] Raise Dead (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever an enemy dies, raise a 5/5 Skeleton.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaiseDead_NAX4_04H()
		{
			// TODO RaiseDead_NAX4_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raise Dead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raise Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raise Dead"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX5_02] Eruption (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to the left-most enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eruption_NAX5_02()
		{
			// TODO Eruption_NAX5_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eruption"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eruption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eruption"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX5_02H] Eruption (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the left-most enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eruption_NAX5_02H()
		{
			// TODO Eruption_NAX5_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eruption"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eruption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eruption"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX6_02] Necrotic Aura (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticAura_NAX6_02()
		{
			// TODO NecroticAura_NAX6_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrotic Aura"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Aura"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrotic Aura"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX6_02H] Necrotic Aura (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticAura_NAX6_02H()
		{
			// TODO NecroticAura_NAX6_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrotic Aura"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Aura"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrotic Aura"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX7_03] Unbalancing Strike (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnbalancingStrike_NAX7_03()
		{
			// TODO UnbalancingStrike_NAX7_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unbalancing Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbalancing Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unbalancing Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX7_03H] Unbalancing Strike (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 4 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnbalancingStrike_NAX7_03H()
		{
			// TODO UnbalancingStrike_NAX7_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unbalancing Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbalancing Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unbalancing Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX8_02] Harvest (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_NAX8_02()
		{
			// TODO Harvest_NAX8_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX8_02H] Harvest (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card. Gain a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_NAX8_02H()
		{
			// TODO Harvest_NAX8_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX9_06] Unholy Shadow (*) - COST:5 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 2 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnholyShadow_NAX9_06()
		{
			// TODO UnholyShadow_NAX9_06 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unholy Shadow"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unholy Shadow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unholy Shadow"));
		}

	}

}
