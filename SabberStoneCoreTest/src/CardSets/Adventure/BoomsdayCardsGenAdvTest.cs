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
	public class HeroesBoomsdayTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_01h2] Test Subject (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52176
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TestSubject_BOTA_BOSS_01h2()
		{
			// TODO TestSubject_BOTA_BOSS_01h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Test Subject"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Test Subject"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Test Subject"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_03h] Astromancer Arwyn (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52175
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AstromancerArwyn_BOTA_BOSS_03h()
		{
			// TODO AstromancerArwyn_BOTA_BOSS_03h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astromancer Arwyn"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astromancer Arwyn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astromancer Arwyn"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_04h] Stargazer Luna (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52175
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StargazerLuna_BOTA_BOSS_04h()
		{
			// TODO StargazerLuna_BOTA_BOSS_04h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stargazer Luna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stargazer Luna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stargazer Luna"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_05h] Zerek, Master Cloner (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52176
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZerekMasterCloner_BOTA_BOSS_05h()
		{
			// TODO ZerekMasterCloner_BOTA_BOSS_05h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zerek, Master Cloner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zerek, Master Cloner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zerek, Master Cloner"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_06h] Dexter the Dendrologist (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52177
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DexterTheDendrologist_BOTA_BOSS_06h()
		{
			// TODO DexterTheDendrologist_BOTA_BOSS_06h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dexter the Dendrologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dexter the Dendrologist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dexter the Dendrologist"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_07h] Flobbidinous Floop (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52177
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlobbidinousFloop_BOTA_BOSS_07h()
		{
			// TODO FlobbidinousFloop_BOTA_BOSS_07h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flobbidinous Floop"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flobbidinous Floop"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flobbidinous Floop"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_08h] Demonologist Draan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52178
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DemonologistDraan_BOTA_BOSS_08h()
		{
			// TODO DemonologistDraan_BOTA_BOSS_08h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonologist Draan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonologist Draan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demonologist Draan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_09h] Dr. Morrigan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52178
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrMorrigan_BOTA_BOSS_09h()
		{
			// TODO DrMorrigan_BOTA_BOSS_09h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Morrigan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Morrigan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dr. Morrigan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_10h] Poisonmaster Pollark (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52180
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonmasterPollark_BOTA_BOSS_10h()
		{
			// TODO PoisonmasterPollark_BOTA_BOSS_10h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poisonmaster Pollark"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poisonmaster Pollark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poisonmaster Pollark"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_12h] Lil' Stormy (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52179
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LilStormy_BOTA_BOSS_12h()
		{
			// TODO LilStormy_BOTA_BOSS_12h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lil' Stormy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lil' Stormy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lil' Stormy"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_13h] Electra Stormsurge (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52179
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElectraStormsurge_BOTA_BOSS_13h()
		{
			// TODO ElectraStormsurge_BOTA_BOSS_13h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Electra Stormsurge"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Electra Stormsurge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Electra Stormsurge"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_14h] Myra Rotspring (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52180
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MyraRotspring_BOTA_BOSS_14h()
		{
			// TODO MyraRotspring_BOTA_BOSS_14h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Myra Rotspring"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Myra Rotspring"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Myra Rotspring"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_15h] Boomnician Breena (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52181
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoomnicianBreena_BOTA_BOSS_15h()
		{
			// TODO BoomnicianBreena_BOTA_BOSS_15h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boomnician Breena"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boomnician Breena"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boomnician Breena"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_16h] Boommaster Flark (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52182
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoommasterFlark_BOTA_BOSS_16h()
		{
			// TODO BoommasterFlark_BOTA_BOSS_16h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boommaster Flark"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boommaster Flark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boommaster Flark"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_17h] Glow-Tron 2000 (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52183
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlowTron2000_BOTA_BOSS_17h()
		{
			// TODO GlowTron2000_BOTA_BOSS_17h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glow-Tron 2000"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glow-Tron 2000"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glow-Tron 2000"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_18h] Crystalsmith Kangor (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 52184
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalsmithKangor_BOTA_BOSS_18h()
		{
			// TODO CrystalsmithKangor_BOTA_BOSS_18h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystalsmith Kangor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystalsmith Kangor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystalsmith Kangor"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_20h] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47494
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrBoom_BOTA_BOSS_20h()
		{
			// TODO DrBoom_BOTA_BOSS_20h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Boom"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Boom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dr. Boom"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [BOTA_BOSS_20h2] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47494
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrBoom_BOTA_BOSS_20h2()
		{
			// TODO DrBoom_BOTA_BOSS_20h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Boom"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Boom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dr. Boom"));
		}

	}

	public class HeroPowersBoomsdayTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_04p] Duality (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>There's symmetry in the stars.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Duality_BOTA_BOSS_04p()
		{
			// TODO Duality_BOTA_BOSS_04p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duality"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duality"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duality"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_05p] Perfection (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>Everything must be perfect.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Perfection_BOTA_BOSS_05p()
		{
			// TODO Perfection_BOTA_BOSS_05p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Perfection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Perfection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Perfection"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_07p] Gloop Sprayer (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>The most effective fertilizer this side of Outland.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GloopSprayer_BOTA_BOSS_07p()
		{
			// TODO GloopSprayer_BOTA_BOSS_07p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gloop Sprayer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gloop Sprayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gloop Sprayer"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_09p] Soul Battery (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>Stores souls...
		//       for science.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoulBattery_BOTA_BOSS_09p()
		{
			// TODO SoulBattery_BOTA_BOSS_09p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soul Battery"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul Battery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soul Battery"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_13p] Stormsurge (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>These puzzles are elementary.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stormsurge_BOTA_BOSS_13p()
		{
			// TODO Stormsurge_BOTA_BOSS_13p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormsurge"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormsurge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormsurge"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_14p] Experimental Necrium (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>Good poisons work instantly.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExperimentalNecrium_BOTA_BOSS_14p()
		{
			// TODO ExperimentalNecrium_BOTA_BOSS_14p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Experimental Necrium"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Experimental Necrium"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Experimental Necrium"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_15p] Firework Volley (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: Heal to full to survive this experiment!
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 29
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireworkVolley_BOTA_BOSS_15p()
		{
			// TODO FireworkVolley_BOTA_BOSS_15p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Firework Volley"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Firework Volley"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Firework Volley"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_16p] Firework Barrage (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: Heal to full to survive this experiment!
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 29
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireworkBarrage_BOTA_BOSS_16p()
		{
			// TODO FireworkBarrage_BOTA_BOSS_16p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Firework Barrage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Firework Barrage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Firework Barrage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_17p] Glowing Laser (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: Heal to full to survive this experiment!
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 29
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlowingLaser_BOTA_BOSS_17p()
		{
			// TODO GlowingLaser_BOTA_BOSS_17p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glowing Laser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glowing Laser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glowing Laser"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_18p] Radiant Laser (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: Heal to full to survive this experiment!
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 40
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RadiantLaser_BOTA_BOSS_18p()
		{
			// TODO RadiantLaser_BOTA_BOSS_18p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Radiant Laser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Radiant Laser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Radiant Laser"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_20p1] True Perfection (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>Have you ever seen such a magnificent reflection?</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TruePerfection_BOTA_BOSS_20p1()
		{
			// TODO TruePerfection_BOTA_BOSS_20p1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Perfection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Perfection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Perfection"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_20p2] Fusion Core (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>Why stop at souls?</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FusionCore_BOTA_BOSS_20p2()
		{
			// TODO FusionCore_BOTA_BOSS_20p2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fusion Core"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fusion Core"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fusion Core"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_20p3] Kadoom Bot (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <i>The fuse is lit.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KadoomBot_BOTA_BOSS_20p3()
		{
			// TODO KadoomBot_BOTA_BOSS_20p3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kadoom Bot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kadoom Bot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kadoom Bot"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BOTA_BOSS_20p4] Death Ray (*) - COST:0 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 40 damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 40
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathRay_BOTA_BOSS_20p4()
		{
			// TODO DeathRay_BOTA_BOSS_20p4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Death Ray"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death Ray"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Death Ray"));
		}

	}

}
