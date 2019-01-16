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
	public class HeroesBrmTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA01_1] Coren Direbrew (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 2314
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorenDirebrew_BRMA01_1()
		{
			// TODO CorenDirebrew_BRMA01_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coren Direbrew"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coren Direbrew"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coren Direbrew"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA01_1H] Coren Direbrew (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 2439
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorenDirebrew_BRMA01_1H()
		{
			// TODO CorenDirebrew_BRMA01_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coren Direbrew"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coren Direbrew"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coren Direbrew"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA02_1] High Justice Grimstone (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2317
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighJusticeGrimstone_BRMA02_1()
		{
			// TODO HighJusticeGrimstone_BRMA02_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Justice Grimstone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("High Justice Grimstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "High Justice Grimstone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA02_1H] High Justice Grimstone (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2588
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighJusticeGrimstone_BRMA02_1H()
		{
			// TODO HighJusticeGrimstone_BRMA02_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Justice Grimstone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("High Justice Grimstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "High Justice Grimstone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA03_1] Emperor Thaurissan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2321
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmperorThaurissan_BRMA03_1()
		{
			// TODO EmperorThaurissan_BRMA03_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emperor Thaurissan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Thaurissan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emperor Thaurissan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA03_1H] Emperor Thaurissan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2321
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmperorThaurissan_BRMA03_1H()
		{
			// TODO EmperorThaurissan_BRMA03_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emperor Thaurissan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Thaurissan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emperor Thaurissan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA04_1] Garr (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2325
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Garr_BRMA04_1()
		{
			// TODO Garr_BRMA04_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garr"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garr"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Garr"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA04_1H] Garr (*) - COST:0 [ATK:0/HP:45] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2325
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Garr_BRMA04_1H()
		{
			// TODO Garr_BRMA04_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garr"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garr"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Garr"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA05_1] Baron Geddon (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2329
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronGeddon_BRMA05_1()
		{
			// TODO BaronGeddon_BRMA05_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Geddon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Geddon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Geddon"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA05_1H] Baron Geddon (*) - COST:0 [ATK:0/HP:50] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2445
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronGeddon_BRMA05_1H()
		{
			// TODO BaronGeddon_BRMA05_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Geddon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Geddon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Geddon"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA06_1] Majordomo Executus (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2335
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MajordomoExecutus_BRMA06_1()
		{
			// TODO MajordomoExecutus_BRMA06_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Majordomo Executus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Majordomo Executus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA06_1H] Majordomo Executus (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2479
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MajordomoExecutus_BRMA06_1H()
		{
			// TODO MajordomoExecutus_BRMA06_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Majordomo Executus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Majordomo Executus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA06_3] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2319
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_BRMA06_3()
		{
			// TODO RagnarosTheFirelord_BRMA06_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ragnaros the Firelord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ragnaros the Firelord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ragnaros the Firelord"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA06_3H] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2448
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_BRMA06_3H()
		{
			// TODO RagnarosTheFirelord_BRMA06_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ragnaros the Firelord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ragnaros the Firelord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ragnaros the Firelord"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA07_1] Highlord Omokk (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2338
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighlordOmokk_BRMA07_1()
		{
			// TODO HighlordOmokk_BRMA07_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Highlord Omokk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Highlord Omokk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Highlord Omokk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA07_1H] Highlord Omokk (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2451
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighlordOmokk_BRMA07_1H()
		{
			// TODO HighlordOmokk_BRMA07_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Highlord Omokk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Highlord Omokk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Highlord Omokk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA08_1] General Drakkisath (*) - COST:0 [ATK:0/HP:50] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2341
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GeneralDrakkisath_BRMA08_1()
		{
			// TODO GeneralDrakkisath_BRMA08_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("General Drakkisath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("General Drakkisath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "General Drakkisath"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA08_1H] General Drakkisath (*) - COST:0 [ATK:0/HP:50] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2453
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GeneralDrakkisath_BRMA08_1H()
		{
			// TODO GeneralDrakkisath_BRMA08_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("General Drakkisath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("General Drakkisath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "General Drakkisath"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA09_1] Rend Blackhand (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2345
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RendBlackhand_BRMA09_1()
		{
			// TODO RendBlackhand_BRMA09_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rend Blackhand"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rend Blackhand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rend Blackhand"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA09_1H] Rend Blackhand (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2530
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RendBlackhand_BRMA09_1H()
		{
			// TODO RendBlackhand_BRMA09_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rend Blackhand"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rend Blackhand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rend Blackhand"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA10_1] Razorgore the Untamed (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2356
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazorgoreTheUntamed_BRMA10_1()
		{
			// TODO RazorgoreTheUntamed_BRMA10_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Razorgore the Untamed"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorgore the Untamed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Razorgore the Untamed"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA10_1H] Razorgore the Untamed (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2475
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazorgoreTheUntamed_BRMA10_1H()
		{
			// TODO RazorgoreTheUntamed_BRMA10_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Razorgore the Untamed"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorgore the Untamed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Razorgore the Untamed"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA11_1] Vaelastrasz the Corrupt (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2358
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VaelastraszTheCorrupt_BRMA11_1()
		{
			// TODO VaelastraszTheCorrupt_BRMA11_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vaelastrasz the Corrupt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vaelastrasz the Corrupt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vaelastrasz the Corrupt"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA11_1H] Vaelastrasz the Corrupt (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2456
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VaelastraszTheCorrupt_BRMA11_1H()
		{
			// TODO VaelastraszTheCorrupt_BRMA11_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vaelastrasz the Corrupt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vaelastrasz the Corrupt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vaelastrasz the Corrupt"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA12_1] Chromaggus (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2361
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chromaggus_BRMA12_1()
		{
			// TODO Chromaggus_BRMA12_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chromaggus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromaggus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chromaggus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA12_1H] Chromaggus (*) - COST:0 [ATK:0/HP:60] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2458
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chromaggus_BRMA12_1H()
		{
			// TODO Chromaggus_BRMA12_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chromaggus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromaggus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chromaggus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA12_9] Chromatic Dragonkin (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChromaticDragonkin_BRMA12_9()
		{
			// TODO ChromaticDragonkin_BRMA12_9 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chromatic Dragonkin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromatic Dragonkin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chromatic Dragonkin"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA13_1] Lord Victor Nefarius (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2379
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordVictorNefarius_BRMA13_1()
		{
			// TODO LordVictorNefarius_BRMA13_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Victor Nefarius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Victor Nefarius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Victor Nefarius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA13_1H] Lord Victor Nefarius (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2465
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordVictorNefarius_BRMA13_1H()
		{
			// TODO LordVictorNefarius_BRMA13_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Victor Nefarius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Victor Nefarius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Victor Nefarius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA13_3] Nefarian (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// Entourage: BRMA13_8, BRMA13_7, BRMA13_5, BRMA13_6
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2381
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_BRMA13_3()
		{
			// TODO Nefarian_BRMA13_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA13_3H] Nefarian (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// Entourage: BRMA13_8, BRMA13_7, BRMA13_6, BRMA13_5
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2467
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_BRMA13_3H()
		{
			// TODO Nefarian_BRMA13_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA14_1] Omnotron Defense System (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2388
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmnotronDefenseSystem_BRMA14_1()
		{
			// TODO OmnotronDefenseSystem_BRMA14_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omnotron Defense System"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omnotron Defense System"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omnotron Defense System"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA14_1H] Omnotron Defense System (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2469
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmnotronDefenseSystem_BRMA14_1H()
		{
			// TODO OmnotronDefenseSystem_BRMA14_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omnotron Defense System"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omnotron Defense System"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omnotron Defense System"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA15_1] Maloriak (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2397
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maloriak_BRMA15_1()
		{
			// TODO Maloriak_BRMA15_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maloriak"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maloriak"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maloriak"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA15_1H] Maloriak (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2592
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maloriak_BRMA15_1H()
		{
			// TODO Maloriak_BRMA15_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maloriak"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maloriak"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maloriak"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA16_1] Atramedes (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2401
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Atramedes_BRMA16_1()
		{
			// TODO Atramedes_BRMA16_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Atramedes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Atramedes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Atramedes"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA16_1H] Atramedes (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2489
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Atramedes_BRMA16_1H()
		{
			// TODO Atramedes_BRMA16_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Atramedes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Atramedes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Atramedes"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA17_2] Nefarian (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2433
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_BRMA17_2()
		{
			// TODO Nefarian_BRMA17_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA17_2H] Nefarian (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2561
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_BRMA17_2H()
		{
			// TODO Nefarian_BRMA17_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA17_3] Onyxia (*) - COST:0 [ATK:0/HP:15] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2548
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Onyxia_BRMA17_3()
		{
			// TODO Onyxia_BRMA17_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Onyxia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyxia"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Onyxia"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BRMA17_3H] Onyxia (*) - COST:0 [ATK:0/HP:30] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2559
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Onyxia_BRMA17_3H()
		{
			// TODO Onyxia_BRMA17_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Onyxia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyxia"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Onyxia"));
		}

	}

	public class HeroPowersBrmTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA01_2] Pile On! (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a minion from each deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PileOn_BRMA01_2()
		{
			// TODO PileOn_BRMA01_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pile On!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pile On!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pile On!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA01_2H] Pile On! (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put two minions from your deck and one from your opponent's into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PileOn_BRMA01_2H()
		{
			// TODO PileOn_BRMA01_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pile On!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pile On!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pile On!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA02_2] Jeering Crowd (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Spectator with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeeringCrowd_BRMA02_2()
		{
			// TODO JeeringCrowd_BRMA02_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeering Crowd"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeering Crowd"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeering Crowd"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA02_2H] Jeering Crowd (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Spectator with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeeringCrowd_BRMA02_2H()
		{
			// TODO JeeringCrowd_BRMA02_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeering Crowd"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeering Crowd"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeering Crowd"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA03_2] Power of the Firelord (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 30 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerOfTheFirelord_BRMA03_2()
		{
			// TODO PowerOfTheFirelord_BRMA03_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power of the Firelord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power of the Firelord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power of the Firelord"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA04_2] Magma Pulse (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagmaPulse_BRMA04_2()
		{
			// TODO MagmaPulse_BRMA04_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magma Pulse"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magma Pulse"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magma Pulse"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA05_2] Ignite Mana (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 5 damage to the enemy hero if they have any unspent Mana.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IgniteMana_BRMA05_2()
		{
			// TODO IgniteMana_BRMA05_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ignite Mana"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ignite Mana"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ignite Mana"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA05_2H] Ignite Mana (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 10 damage to the enemy hero if they have any unspent Mana.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IgniteMana_BRMA05_2H()
		{
			// TODO IgniteMana_BRMA05_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ignite Mana"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ignite Mana"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ignite Mana"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA06_2] The Majordomo (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/3 Flamewaker Acolyte.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMajordomo_BRMA06_2()
		{
			// TODO TheMajordomo_BRMA06_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Majordomo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Majordomo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Majordomo"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA06_2H] The Majordomo (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 3/3 Flamewaker Acolyte.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMajordomo_BRMA06_2H()
		{
			// TODO TheMajordomo_BRMA06_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Majordomo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Majordomo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Majordomo"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA07_2] ME SMASH (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a random damaged enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeSmash_BRMA07_2()
		{
			// TODO MeSmash_BRMA07_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("ME SMASH"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("ME SMASH"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "ME SMASH"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA07_2H] ME SMASH (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeSmash_BRMA07_2H()
		{
			// TODO MeSmash_BRMA07_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("ME SMASH"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("ME SMASH"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "ME SMASH"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA08_2] Intense Gaze (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All cards cost (1). Players are capped at 1 Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IntenseGaze_BRMA08_2()
		{
			// TODO IntenseGaze_BRMA08_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Intense Gaze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Intense Gaze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Intense Gaze"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA08_2H] Intense Gaze (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All cards cost (1). You are capped at 2 Mana Crystals, and opponent at 1.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IntenseGaze_BRMA08_2H()
		{
			// TODO IntenseGaze_BRMA08_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Intense Gaze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Intense Gaze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Intense Gaze"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_2] Open the Gates (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon three 1/1 Whelps. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_3, BRMA09_4
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OpenTheGates_BRMA09_2()
		{
			// TODO OpenTheGates_BRMA09_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Open the Gates"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Open the Gates"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Open the Gates"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_2H] Open the Gates (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon three 2/2 Whelps. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_3H, BRMA09_4H
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OpenTheGates_BRMA09_2H()
		{
			// TODO OpenTheGates_BRMA09_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Open the Gates"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Open the Gates"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Open the Gates"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_3] Old Horde (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Orcs with <b>Taunt</b>. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2, BRMA09_4, BRMA09_5
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OldHorde_BRMA09_3()
		{
			// TODO OldHorde_BRMA09_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Old Horde"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Old Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Old Horde"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_3H] Old Horde (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 2/2 Orcs with <b>Taunt</b>. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2H, BRMA09_4H, BRMA09_5H
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OldHorde_BRMA09_3H()
		{
			// TODO OldHorde_BRMA09_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Old Horde"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Old Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Old Horde"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_4] Blackwing (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 3/1 Dragonkin. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2, BRMA09_3, BRMA09_5
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blackwing_BRMA09_4()
		{
			// TODO Blackwing_BRMA09_4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwing"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_4H] Blackwing (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 5/4 Dragonkin. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2H, BRMA09_3H, BRMA09_5H
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blackwing_BRMA09_4H()
		{
			// TODO Blackwing_BRMA09_4H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwing"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_5] Dismount (*) - COST:4 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon Gyth. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2, BRMA09_3, BRMA09_4
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dismount_BRMA09_5()
		{
			// TODO Dismount_BRMA09_5 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dismount"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dismount"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dismount"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA09_5H] Dismount (*) - COST:4 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon Gyth. Get a new Hero Power.
		// --------------------------------------------------------
		// Entourage: BRMA09_2H, BRMA09_3H, BRMA09_4H
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dismount_BRMA09_5H()
		{
			// TODO Dismount_BRMA09_5H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dismount"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dismount"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dismount"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA10_3] The Rookery (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give all Corrupted Eggs +1 Health, then summon one.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheRookery_BRMA10_3()
		{
			// TODO TheRookery_BRMA10_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Rookery"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Rookery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Rookery"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA10_3H] The Rookery (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give all Corrupted Eggs +1 Health, then summon one.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheRookery_BRMA10_3H()
		{
			// TODO TheRookery_BRMA10_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Rookery"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Rookery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Rookery"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA11_2] Essence of the Red (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Each player draws 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EssenceOfTheRed_BRMA11_2()
		{
			// TODO EssenceOfTheRed_BRMA11_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Essence of the Red"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Essence of the Red"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Essence of the Red"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA11_2H] Essence of the Red (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Each player draws 3 cards. Gain a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EssenceOfTheRed_BRMA11_2H()
		{
			// TODO EssenceOfTheRed_BRMA11_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Essence of the Red"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Essence of the Red"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Essence of the Red"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA12_10] Mutation (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Discard a random card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mutation_BRMA12_10()
		{
			// TODO Mutation_BRMA12_10 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mutation"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mutation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mutation"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA12_2] Brood Affliction (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       At the end of your turn, add a Brood Affliction card to your opponent's hand.
		// --------------------------------------------------------
		// Entourage: BRMA12_6, BRMA12_5, BRMA12_7, BRMA12_4, BRMA12_3
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BroodAffliction_BRMA12_2()
		{
			// TODO BroodAffliction_BRMA12_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brood Affliction"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brood Affliction"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brood Affliction"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA12_2H] Brood Affliction (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       At the end of your turn, add a Brood Affliction card to your opponent's hand.
		// --------------------------------------------------------
		// Entourage: BRMA12_3H, BRMA12_4H, BRMA12_5H, BRMA12_6H, BRMA12_7H
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BroodAffliction_BRMA12_2H()
		{
			// TODO BroodAffliction_BRMA12_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brood Affliction"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brood Affliction"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brood Affliction"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA13_2] True Form (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Let the games begin!
		// --------------------------------------------------------
		// Entourage: BRMA13_6, BRMA13_8, BRMA13_7, BRMA13_5
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueForm_BRMA13_2()
		{
			// TODO TrueForm_BRMA13_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Form"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Form"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Form"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA13_2H] True Form (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Let the games begin!
		// --------------------------------------------------------
		// Entourage: BRMA13_6, BRMA13_8, BRMA13_7, BRMA13_5
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueForm_BRMA13_2H()
		{
			// TODO TrueForm_BRMA13_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Form"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Form"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Form"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA13_4] Wild Magic (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a random spell from your opponent's class into your hand.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildMagic_BRMA13_4()
		{
			// TODO WildMagic_BRMA13_4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wild Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Magic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wild Magic"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA13_4H] Wild Magic (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a random spell from your opponent's class into your hand.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildMagic_BRMA13_4H()
		{
			// TODO WildMagic_BRMA13_4H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wild Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Magic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wild Magic"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_10] Activate! (*) - COST:4 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate a random Tron.
		// --------------------------------------------------------
		// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Activate_BRMA14_10()
		{
			// TODO Activate_BRMA14_10 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_10H] Activate! (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate a random Tron.
		// --------------------------------------------------------
		// Entourage: BRMA14_3, BRMA14_5H, BRMA14_7H, BRMA14_9H
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Activate_BRMA14_10H()
		{
			// TODO Activate_BRMA14_10H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_2] Activate Arcanotron (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Arcanotron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateArcanotron_BRMA14_2()
		{
			// TODO ActivateArcanotron_BRMA14_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Arcanotron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Arcanotron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Arcanotron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_2H] Activate Arcanotron (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Arcanotron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateArcanotron_BRMA14_2H()
		{
			// TODO ActivateArcanotron_BRMA14_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Arcanotron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Arcanotron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Arcanotron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_4] Activate Toxitron (*) - COST:4 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Toxitron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateToxitron_BRMA14_4()
		{
			// TODO ActivateToxitron_BRMA14_4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Toxitron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Toxitron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Toxitron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_4H] Activate Toxitron (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Toxitron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateToxitron_BRMA14_4H()
		{
			// TODO ActivateToxitron_BRMA14_4H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Toxitron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Toxitron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Toxitron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_6] Activate Electron (*) - COST:6 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Electron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateElectron_BRMA14_6()
		{
			// TODO ActivateElectron_BRMA14_6 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Electron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Electron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Electron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_6H] Activate Electron (*) - COST:4 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Electron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateElectron_BRMA14_6H()
		{
			// TODO ActivateElectron_BRMA14_6H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Electron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Electron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Electron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_8] Activate Magmatron (*) - COST:8 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Magmatron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateMagmatron_BRMA14_8()
		{
			// TODO ActivateMagmatron_BRMA14_8 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Magmatron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Magmatron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Magmatron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA14_8H] Activate Magmatron (*) - COST:6 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate Magmatron!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateMagmatron_BRMA14_8H()
		{
			// TODO ActivateMagmatron_BRMA14_8H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate Magmatron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate Magmatron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Activate Magmatron"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA15_2] The Alchemist (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a minion is summoned, swap its Attack and Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheAlchemist_BRMA15_2()
		{
			// TODO TheAlchemist_BRMA15_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Alchemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Alchemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Alchemist"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA15_2H] The Alchemist (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Minions' Attack and Health are swapped.
		//       Your minions have +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheAlchemist_BRMA15_2H()
		{
			// TODO TheAlchemist_BRMA15_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Alchemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Alchemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Alchemist"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA16_2] Echolocate (*) - COST:1 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a weapon that grows as your opponent plays cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Echolocate_BRMA16_2()
		{
			// TODO Echolocate_BRMA16_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Echolocate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Echolocate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Echolocate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA16_2H] Echolocate (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a weapon that grows as your opponent plays cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Echolocate_BRMA16_2H()
		{
			// TODO Echolocate_BRMA16_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Echolocate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Echolocate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Echolocate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA17_5] Bone Minions (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 2/1 Bone Constructs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneMinions_BRMA17_5()
		{
			// TODO BoneMinions_BRMA17_5 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Minions"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Minions"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bone Minions"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA17_5H] Bone Minions (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 4/2 Bone Constructs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneMinions_BRMA17_5H()
		{
			// TODO BoneMinions_BRMA17_5H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Minions"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Minions"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bone Minions"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA17_8] Nefarian Strikes! (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Nefarian rains fire from above!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NefarianStrikes_BRMA17_8()
		{
			// TODO NefarianStrikes_BRMA17_8 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian Strikes!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian Strikes!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian Strikes!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA17_8H] Nefarian Strikes! (*) - COST:0 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Nefarian rains fire from above!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NefarianStrikes_BRMA17_8H()
		{
			// TODO NefarianStrikes_BRMA17_8H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian Strikes!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian Strikes!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian Strikes!"));
		}

	}

}
