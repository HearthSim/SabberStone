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
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesTrollTest
	{
		// ----------------------------------------- HERO - WARRIOR
		// [TRLA_200h] War Master Voone (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>The Warmaster is a triple threat:_He_rocks. He_rolls._He_trolls!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 725
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarMasterVoone_TRLA_200h()
		{
			// TODO WarMasterVoone_TRLA_200h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("War Master Voone"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("War Master Voone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "War Master Voone"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [TRLA_201h] Zentimo (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>This creepy swamp shaman is packing some_bad_voodoo.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 687
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zentimo_TRLA_201h()
		{
			// TODO Zentimo_TRLA_201h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zentimo"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zentimo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zentimo"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [TRLA_202h] Captain Hooktusk (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Those who say her cheating goes over[d]board_soon_follow_suit.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 730
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaptainHooktusk_TRLA_202h()
		{
			// TODO CaptainHooktusk_TRLA_202h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captain Hooktusk"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Captain Hooktusk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Captain Hooktusk"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [TRLA_203h] High Priest Thekal (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Floats like a feather. Stings like a troll punching_your_face.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 472
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighPriestThekal_TRLA_203h()
		{
			// TODO HighPriestThekal_TRLA_203h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Priest Thekal"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("High Priest Thekal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "High Priest Thekal"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [TRLA_204h] Zul'jin (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Zul'jin's not ready to bury the hatchet. Unless it's in your shrine.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 53943
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zuljin_TRLA_204h()
		{
			// TODO Zuljin_TRLA_204h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zul'jin"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zul'jin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zul'jin"));
		}

		// ------------------------------------------- HERO - DRUID
		// [TRLA_205h] Wardruid Loti (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>She and her raptors aim to prove the wild side is_the_winning_side.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1123
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WardruidLoti_TRLA_205h()
		{
			// TODO WardruidLoti_TRLA_205h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wardruid Loti"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wardruid Loti"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wardruid Loti"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [TRLA_206h] High Priestess Jeklik (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Her blood magic brings on spells,_demons, and_hurt_feelings.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 300
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighPriestessJeklik_TRLA_206h()
		{
			// TODO HighPriestessJeklik_TRLA_206h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Priestess Jeklik"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("High Priestess Jeklik"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "High Priestess Jeklik"));
		}

		// -------------------------------------------- HERO - MAGE
		// [TRLA_207h] Hex Lord Malacrass (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Malacrass is on fire this year! And sometimes frost.</I>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 807
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HexLordMalacrass_TRLA_207h()
		{
			// TODO HexLordMalacrass_TRLA_207h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hex Lord Malacrass"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hex Lord Malacrass"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hex Lord Malacrass"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [TRLA_208h] Princess Talanji (*) - COST:0 [ATK:0/HP:10] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <i>Her family bargained with the loa of death. That's_bad._For_you.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 479
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrincessTalanji_TRLA_208h()
		{
			// TODO PrincessTalanji_TRLA_208h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Princess Talanji"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Princess Talanji"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Princess Talanji"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TRLA_209h] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 479
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h()
		{
			// TODO Rikkar_TRLA_209h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ------------------------------------------- HERO - DRUID
		// [TRLA_209h_Druid] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1123
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Druid()
		{
			// TODO Rikkar_TRLA_209h_Druid test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [TRLA_209h_Hunter] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 229
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Hunter()
		{
			// TODO Rikkar_TRLA_209h_Hunter test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// -------------------------------------------- HERO - MAGE
		// [TRLA_209h_Mage] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 807
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Mage()
		{
			// TODO Rikkar_TRLA_209h_Mage test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [TRLA_209h_Paladin] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 472
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Paladin()
		{
			// TODO Rikkar_TRLA_209h_Paladin test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [TRLA_209h_Priest] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 479
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Priest()
		{
			// TODO Rikkar_TRLA_209h_Priest test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [TRLA_209h_Rogue] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 730
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Rogue()
		{
			// TODO Rikkar_TRLA_209h_Rogue test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [TRLA_209h_Shaman] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 687
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Shaman()
		{
			// TODO Rikkar_TRLA_209h_Shaman test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [TRLA_209h_Warlock] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 300
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Warlock()
		{
			// TODO Rikkar_TRLA_209h_Warlock test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [TRLA_209h_Warrior] Rikkar (*) - COST:0 [ATK:0/HP:20] 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 725
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rikkar_TRLA_209h_Warrior()
		{
			// TODO Rikkar_TRLA_209h_Warrior test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rikkar"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rikkar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rikkar"));
		}

	}

	public class HeroPowersTrollTest
	{
		// ------------------------------------ HERO_POWER - HUNTER
		// [TRLA_065p] Steady Throw (*) - COST:2 
		// - Fac: neutral, Set: troll, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to the enemy hero.@<b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2738
		// - HIDE_WATERMARK = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteadyThrow_TRLA_065p()
		{
			// TODO SteadyThrow_TRLA_065p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Steady Throw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steady Throw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Steady Throw"));
		}

	}

}
