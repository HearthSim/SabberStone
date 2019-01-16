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
	public class HeroesIcecrownTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA01_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42457
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheLichKing_ICCA01_001()
		{
			// TODO TheLichKing_ICCA01_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Lich King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Lich King"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [ICCA01_013] Tirion Fordring (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: icecrown, 
		// --------------------------------------------------------
		// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t1, ICC_314t6, ICC_314t5, ICC_314t7, ICC_314t8
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TirionFordring_ICCA01_013()
		{
			// TODO TirionFordring_ICCA01_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tirion Fordring"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tirion Fordring"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tirion Fordring"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA03_001] Secrets of the Citadel (*) - COST:0 [ATK:0/HP:100] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SecretsOfTheCitadel_ICCA03_001()
		{
			// TODO SecretsOfTheCitadel_ICCA03_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Secrets of the Citadel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secrets of the Citadel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Secrets of the Citadel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA04_001] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 45627
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sindragosa_ICCA04_001()
		{
			// TODO Sindragosa_ICCA04_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sindragosa"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sindragosa"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sindragosa"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA05_001] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 43194
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodQueenLanathel_ICCA05_001()
		{
			// TODO BloodQueenLanathel_ICCA05_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood-Queen Lana'thel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood-Queen Lana'thel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood-Queen Lana'thel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA06_001] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42447
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordMarrowgar_ICCA06_001()
		{
			// TODO LordMarrowgar_ICCA06_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Marrowgar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Marrowgar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Marrowgar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA07_001] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42876
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProfessorPutricide_ICCA07_001()
		{
			// TODO ProfessorPutricide_ICCA07_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Professor Putricide"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Professor Putricide"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA07_001h2] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42876
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProfessorPutricide_ICCA07_001h2()
		{
			// TODO ProfessorPutricide_ICCA07_001h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Professor Putricide"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Professor Putricide"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA07_001h3] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42876
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProfessorPutricide_ICCA07_001h3()
		{
			// TODO ProfessorPutricide_ICCA07_001h3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Professor Putricide"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Professor Putricide"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA08_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42457
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheLichKing_ICCA08_001()
		{
			// TODO TheLichKing_ICCA08_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Lich King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Lich King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA09_002] Deathbringer Saurfang (*) - COST:0 [ATK:0/HP:20] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 43038
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathbringerSaurfang_ICCA09_002()
		{
			// TODO DeathbringerSaurfang_ICCA09_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathbringer Saurfang"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathbringer Saurfang"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathbringer Saurfang"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [ICCA10_009] Lady Deathwhisper (*) - COST:0 [ATK:0/HP:30] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 45605
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LadyDeathwhisper_ICCA10_009()
		{
			// TODO LadyDeathwhisper_ICCA10_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lady Deathwhisper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady Deathwhisper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lady Deathwhisper"));
		}

	}

	public class HeroPowersIcecrownTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA04_008p] Frost Breath (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Permanently <b>Freeze</b> all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBreath_ICCA04_008p()
		{
			// TODO FrostBreath_ICCA04_008p test
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
		// [ICCA04_009p] Frost Breath (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Triggered Power</b>
		//       At 20 Health, transforms all enemy minions into blocks of ice.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBreath_ICCA04_009p()
		{
			// TODO FrostBreath_ICCA04_009p test
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
		// [ICCA04_010p] Frost Breath (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Triggered Power</b>
		//       At 10 Health, transforms all enemy minions into blocks of ice.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBreath_ICCA04_010p()
		{
			// TODO FrostBreath_ICCA04_010p test
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
		// [ICCA04_011p] Ice Claw (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceClaw_ICCA04_011p()
		{
			// TODO IceClaw_ICCA04_011p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Claw"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Claw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Claw"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA05_002p] Vampiric Bite (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a non-Vampire +2/+2. You <i>must</i> use this.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_NOT_VAMPIRE = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VampiricBite_ICCA05_002p()
		{
			// TODO VampiricBite_ICCA05_002p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vampiric Bite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vampiric Bite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vampiric Bite"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA05_004p] Vampiric Leech (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Lifesteal</b>
		//       Deal $3 damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VampiricLeech_ICCA05_004p()
		{
			// TODO VampiricLeech_ICCA05_004p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vampiric Leech"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vampiric Leech"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vampiric Leech"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA06_002p] Skeletal Reconstruction (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore your hero to full Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkeletalReconstruction_ICCA06_002p()
		{
			// TODO SkeletalReconstruction_ICCA06_002p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skeletal Reconstruction"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skeletal Reconstruction"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skeletal Reconstruction"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA07_002p] Mad Science (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All <b>Secrets</b> cost (0).
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadScience_ICCA07_002p()
		{
			// TODO MadScience_ICCA07_002p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mad Science"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Science"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mad Science"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA07_003p] Madder Science (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All weapons cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadderScience_ICCA07_003p()
		{
			// TODO MadderScience_ICCA07_003p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Madder Science"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Madder Science"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Madder Science"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA07_005p] Maddest Science (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All cards cost (5).
		//       Because SCIENCE!
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		// RefTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MaddestScience_ICCA07_005p()
		{
			// TODO MaddestScience_ICCA07_005p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maddest Science"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maddest Science"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maddest Science"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA08_002p] The Scourge (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 2/2 Ghoul.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheScourge_ICCA08_002p()
		{
			// TODO TheScourge_ICCA08_002p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Scourge"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Scourge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Scourge"));
		}

		// ------------------------------- HERO_POWER - DEATHKNIGHT
		// [ICCA08_030p] Remorseless Winter (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal @ damage to the enemy hero. +1 Damage each time.
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RemorselessWinter_ICCA08_030p()
		{
			// TODO RemorselessWinter_ICCA08_030p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DEATHKNIGHT,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Remorseless Winter"),
				},
				Player2HeroClass = CardClass.DEATHKNIGHT,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Remorseless Winter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Remorseless Winter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA08_032p] Harvest of Souls (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       You are <b>Immune</b> if you control a Trapped Soul.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HarvestOfSouls_ICCA08_032p()
		{
			// TODO HarvestOfSouls_ICCA08_032p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest of Souls"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest of Souls"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest of Souls"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA09_001p] Blood Rune (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Can only take damage from weapons.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodRune_ICCA09_001p()
		{
			// TODO BloodRune_ICCA09_001p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Rune"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Rune"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Rune"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA10_009p] Whisper of Death (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Damage all enemy
		//       minions until they have
		//       1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhisperOfDeath_ICCA10_009p()
		{
			// TODO WhisperOfDeath_ICCA10_009p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whisper of Death"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whisper of Death"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whisper of Death"));
		}

	}

}
