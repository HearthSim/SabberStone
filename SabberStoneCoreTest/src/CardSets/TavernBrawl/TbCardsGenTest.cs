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

namespace SabberStoneCoreTest.CardSets.TavernBrawl
{
	public class HeroesTbTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [FB_LK008h] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 43194
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodQueenLanathel_FB_LK008h()
		{
			// TODO BloodQueenLanathel_FB_LK008h test
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
		// [FB_LK_012h] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42447
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordMarrowgar_FB_LK_012h()
		{
			// TODO LordMarrowgar_FB_LK_012h test
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
		// [FB_LK_013h] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42876
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProfessorPutricide_FB_LK_013h()
		{
			// TODO ProfessorPutricide_FB_LK_013h test
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
		// [FB_LK_014h] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 45627
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sindragosa_FB_LK_014h()
		{
			// TODO Sindragosa_FB_LK_014h test
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
		// [FB_LK_Raid_Hero] Supreme Lich King (*) - COST:0 [ATK:0/HP:400] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42457
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SupremeLichKing_FB_LK_Raid_Hero()
		{
			// TODO SupremeLichKing_FB_LK_Raid_Hero test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Supreme Lich King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Supreme Lich King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Supreme Lich King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42457
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SupremeLichKing_FB_LK_Raid_Hero_Battledamaged()
		{
			// TODO SupremeLichKing_FB_LK_Raid_Hero_Battledamaged test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Supreme Lich King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Supreme Lich King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Supreme Lich King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss1H_TB] White King (*) - COST:0 [ATK:0/HP:10] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40086
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhiteKing_KAR_a10_Boss1H_TB()
		{
			// TODO WhiteKing_KAR_a10_Boss1H_TB test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("White King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "White King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss1H_TB22] White King (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40086
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhiteKing_KAR_a10_Boss1H_TB22()
		{
			// TODO WhiteKing_KAR_a10_Boss1H_TB22 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("White King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "White King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss2H_TB] Black King (*) - COST:0 [ATK:0/HP:10] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39801
		// - CANT_BE_FATIGUED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackKing_KAR_a10_Boss2H_TB()
		{
			// TODO BlackKing_KAR_a10_Boss2H_TB test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Black King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Black King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Black King"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [TB_BossRumble_001] Han'Cho (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hancho_TB_BossRumble_001()
		{
			// TODO Hancho_TB_BossRumble_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Han'Cho"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Han'Cho"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Han'Cho"));
		}

		// ------------------------------------------- HERO - DRUID
		// [TB_BossRumble_002] Aya Blackpaw (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AyaBlackpaw_TB_BossRumble_002()
		{
			// TODO AyaBlackpaw_TB_BossRumble_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aya Blackpaw"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aya Blackpaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aya Blackpaw"));
		}

		// -------------------------------------------- HERO - MAGE
		// [TB_BossRumble_003] Kazakus (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kazakus_TB_BossRumble_003()
		{
			// TODO Kazakus_TB_BossRumble_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kazakus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kazakus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kazakus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_CoopHero_H_001] Coop Boss (*) - COST:0 [ATK:0/HP:100] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40221
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoopBoss_TB_CoopHero_H_001()
		{
			// TODO CoopBoss_TB_CoopHero_H_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coop Boss"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coop Boss"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coop Boss"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_FW_Rag] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2660
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_TB_FW_Rag()
		{
			// TODO RagnarosTheFirelord_TB_FW_Rag test
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
		// [TB_KTRAF_H_1] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_TB_KTRAF_H_1()
		{
			// TODO Kelthuzad_TB_KTRAF_H_1 test
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
		// [TB_KTRAF_H_2] Rafaam (*) - COST:0 [ATK:0/HP:60] 
		// - Fac: neutral, Set: tb, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39236
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rafaam_TB_KTRAF_H_2()
		{
			// TODO Rafaam_TB_KTRAF_H_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_MechWar_Boss1] Annoy-o-Tron (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnnoyOTron_TB_MechWar_Boss1()
		{
			// TODO AnnoyOTron_TB_MechWar_Boss1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Annoy-o-Tron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Annoy-o-Tron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Annoy-o-Tron"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_MechWar_Boss2] Boom Bot (*) - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: tb, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoomBot_TB_MechWar_Boss2()
		{
			// TODO BoomBot_TB_MechWar_Boss2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boom Bot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boom Bot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boom Bot"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_SPT_Boss] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39537
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CityOfStormwind_TB_SPT_Boss()
		{
			// TODO CityOfStormwind_TB_SPT_Boss test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("City of Stormwind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("City of Stormwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "City of Stormwind"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [TB_SPT_DPromo_Hero] Dark Wanderer (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 42156
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkWanderer_TB_SPT_DPromo_Hero()
		{
			// TODO DarkWanderer_TB_SPT_DPromo_Hero test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Wanderer"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Wanderer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Wanderer"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [TB_SPT_DPromo_Hero2] The Cow King (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// - HERO_POWER = 42156
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCowKing_TB_SPT_DPromo_Hero2()
		{
			// TODO TheCowKing_TB_SPT_DPromo_Hero2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Cow King"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Cow King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Cow King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_SPT_MTH_Boss] Decorated Stormwind (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39537
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DecoratedStormwind_TB_SPT_MTH_Boss()
		{
			// TODO DecoratedStormwind_TB_SPT_MTH_Boss test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decorated Stormwind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decorated Stormwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decorated Stormwind"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_SPT_MTH_Boss0] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39537
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CityOfStormwind_TB_SPT_MTH_Boss0()
		{
			// TODO CityOfStormwind_TB_SPT_MTH_Boss0 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("City of Stormwind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("City of Stormwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "City of Stormwind"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_SPT_MTH_Boss2] Partytown Stormwind (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39537
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PartytownStormwind_TB_SPT_MTH_Boss2()
		{
			// TODO PartytownStormwind_TB_SPT_MTH_Boss2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Partytown Stormwind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Partytown Stormwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Partytown Stormwind"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TB_SPT_MTH_Boss3] Party Capital (*) - COST:0 [ATK:0/HP:1] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39537
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PartyCapital_TB_SPT_MTH_Boss3()
		{
			// TODO PartyCapital_TB_SPT_MTH_Boss3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Party Capital"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Party Capital"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Party Capital"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TBA01_1] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2660
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_TBA01_1()
		{
			// TODO RagnarosTheFirelord_TBA01_1 test
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
		// [TBA01_4] Nefarian (*) - COST:0 [ATK:0/HP:30] 
		// - Set: tb, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2653
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_TBA01_4()
		{
			// TODO Nefarian_TBA01_4 test
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

	}

	public class HeroPowersTbTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA01_2H_2_TB] Pile On!!! (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a minion from each deck into the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PileOn_BRMA01_2H_2_TB()
		{
			// TODO PileOn_BRMA01_2H_2_TB test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pile On!!!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pile On!!!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pile On!!!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRMA02_2_2_TB] Jeering Crowd (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Spectator with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeeringCrowd_BRMA02_2_2_TB()
		{
			// TODO JeeringCrowd_BRMA02_2_2_TB test
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
		// [BRMA06_2H_TB] The Majordomo (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 3/3 Flamewaker Acolyte.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMajordomo_BRMA06_2H_TB()
		{
			// TODO TheMajordomo_BRMA06_2H_TB test
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
		// [BRMA07_2_2_TB] ME SMASH (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeSmash_BRMA07_2_2_TB()
		{
			// TODO MeSmash_BRMA07_2_2_TB test
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
		// [BRMA09_2_TB] Open the Gates (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon three 1/1 Whelps.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OpenTheGates_BRMA09_2_TB()
		{
			// TODO OpenTheGates_BRMA09_2_TB test
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
		// [BRMA11_2H_2_TB] Essence of the Red (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Each player draws 3 cards. Gain a Mana Crystal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EssenceOfTheRed_BRMA11_2H_2_TB()
		{
			// TODO EssenceOfTheRed_BRMA11_2H_2_TB test
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
		// [BRMA13_4_2_TB] Wild Magic (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a random spell from your opponent's class into your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildMagic_BRMA13_4_2_TB()
		{
			// TODO WildMagic_BRMA13_4_2_TB test
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
		// [BRMA14_10H_TB] Activate! (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Activate a random Tron.
		// --------------------------------------------------------
		// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Activate_BRMA14_10H_TB()
		{
			// TODO Activate_BRMA14_10H_TB test
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
		// [BRMA17_5_TB] Bone Minions (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 2/1 Bone Constructs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneMinions_BRMA17_5_TB()
		{
			// TODO BoneMinions_BRMA17_5_TB test
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
		// [EX1_tk33_2_TB] INFERNO! (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Infernal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Inferno_EX1_tk33_2_TB()
		{
			// TODO Inferno_EX1_tk33_2_TB test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("INFERNO!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("INFERNO!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "INFERNO!"));
		}

		// ------------------------------- HERO_POWER - DEATHKNIGHT
		// [FB_LK005] Remorseless Winter (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal @ damage to the enemy hero. +1 Damage each time.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RemorselessWinter_FB_LK005()
		{
			// TODO RemorselessWinter_FB_LK005 test
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
		// [FB_LK007p] Freezing Blast (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Freeze</b>  a random enemy minion and deal 1 damage to it.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FreezingBlast_FB_LK007p()
		{
			// TODO FreezingBlast_FB_LK007p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Freezing Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Freezing Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Freezing Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX11_02H_2_TB] Poison Cloud (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all enemy minions. If any die, summon a slime.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonCloud_NAX11_02H_2_TB()
		{
			// TODO PoisonCloud_NAX11_02H_2_TB test
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
		// [NAX12_02H_2_TB] Decimate (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Change the Health of enemy minions to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decimate_NAX12_02H_2_TB()
		{
			// TODO Decimate_NAX12_02H_2_TB test
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
		// [NAX3_02_TB] Web Wrap (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return a random enemy minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WebWrap_NAX3_02_TB()
		{
			// TODO WebWrap_NAX3_02_TB test
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
		// [NAX8_02H_TB] Harvest (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card. Gain a Mana Crystal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_NAX8_02H_TB()
		{
			// TODO Harvest_NAX8_02H_TB test
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

		// ------------------------------------- HERO_POWER - ROGUE
		// [TB_BlingBrawl_Hero1p] Sharpen (*) - COST:2 
		// - Set: tb, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Increase your weapon's attack by 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sharpen_TB_BlingBrawl_Hero1p()
		{
			// TODO Sharpen_TB_BlingBrawl_Hero1p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sharpen"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sharpen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sharpen"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_BossRumble_001hp] Smuggle (*) - COST:2 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a random minion in your hand +2/+2
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Smuggle_TB_BossRumble_001hp()
		{
			// TODO Smuggle_TB_BossRumble_001hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Smuggle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smuggle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Smuggle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_BossRumble_002hp] Construct Golem (*) - COST:4 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a {0} <b>Jade Golem</b>.@Summon a <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConstructGolem_TB_BossRumble_002hp()
		{
			// TODO ConstructGolem_TB_BossRumble_002hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Construct Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Construct Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Construct Golem"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_BossRumble_003hp] Brew Potion (*) - COST:2 
		// - Fac: neutral, Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random Potion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39240
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrewPotion_TB_BossRumble_003hp()
		{
			// TODO BrewPotion_TB_BossRumble_003hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brew Potion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brew Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brew Potion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_BRMA01_2H_2] Pile On!!! (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a minion from each deck into the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PileOn_TB_BRMA01_2H_2()
		{
			// TODO PileOn_TB_BRMA01_2H_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pile On!!!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pile On!!!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pile On!!!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_BRMA10_3H] The Rookery (*) - COST:1 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give all Corrupted Eggs +1 Health, then summon one.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheRookery_TB_BRMA10_3H()
		{
			// TODO TheRookery_TB_BRMA10_3H test
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
		// [TB_CoopHero_HP_001] Madness (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Armies!!
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2379
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Madness_TB_CoopHero_HP_001()
		{
			// TODO Madness_TB_CoopHero_HP_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Madness"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Madness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Madness"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_KTRAF_HP_KT_3] Necromancy (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random Naxxramas minion to your hand. It costs (3) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Necromancy_TB_KTRAF_HP_KT_3()
		{
			// TODO Necromancy_TB_KTRAF_HP_KT_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necromancy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necromancy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necromancy"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_KTRAF_HP_RAF3] Staff, First Piece (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Add a random rare card to your hand. It costs (2) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StaffFirstPiece_TB_KTRAF_HP_RAF3()
		{
			// TODO StaffFirstPiece_TB_KTRAF_HP_RAF3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Staff, First Piece"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Staff, First Piece"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Staff, First Piece"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_KTRAF_HP_RAF4] Staff, Two Pieces (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Add a random epic card to your hand. It costs (3) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StaffTwoPieces_TB_KTRAF_HP_RAF4()
		{
			// TODO StaffTwoPieces_TB_KTRAF_HP_RAF4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Staff, Two Pieces"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Staff, Two Pieces"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Staff, Two Pieces"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_KTRAF_HP_RAF5] Staff of Origination (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Add a random legendary minion to your hand. It costs (4) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StaffOfOrigination_TB_KTRAF_HP_RAF5()
		{
			// TODO StaffOfOrigination_TB_KTRAF_HP_RAF5 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Staff of Origination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Staff of Origination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Staff of Origination"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_LevelUp_001] Level Up! (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Level up all the spells in your hand and deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LevelUp_TB_LevelUp_001()
		{
			// TODO LevelUp_TB_LevelUp_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Level Up!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Level Up!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Level Up!"));
		}

		// ------------------------------------- HERO_POWER - DRUID
		// [TB_LOEA13_2] Ancient Power (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give each player a random card. It costs (0).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientPower_TB_LOEA13_2()
		{
			// TODO AncientPower_TB_LOEA13_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Power"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Power"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Power"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_MammothParty_hp001] Decorate (*) - COST:10 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Create *{0}* |4(decoration, decorations) for the Tavern.
		//       Progress: {1}/25
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decorate_TB_MammothParty_hp001()
		{
			// TODO Decorate_TB_MammothParty_hp001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decorate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decorate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decorate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_MammothParty_hp002] Pelt (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the Piñata.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Pelt_TB_MammothParty_hp002()
		{
			// TODO Pelt_TB_MammothParty_hp002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pelt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pelt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pelt"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your lowest attack minion <b>Divine Shield</b> and <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HelloHelloHello_TB_MechWar_Boss1_HeroPower()
		{
			// TODO HelloHelloHello_TB_MechWar_Boss1_HeroPower test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hello! Hello! Hello!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hello! Hello! Hello!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hello! Hello! Hello!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage randomly split among all enemies.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoomBotJr_TB_MechWar_Boss2_HeroPower()
		{
			// TODO BoomBotJr_TB_MechWar_Boss2_HeroPower test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boom Bot Jr."),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boom Bot Jr."));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boom Bot Jr."));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_SPT_BossHeroPower] Barracks (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Play a random Stormwind Soldier.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Barracks_TB_SPT_BossHeroPower()
		{
			// TODO Barracks_TB_SPT_BossHeroPower test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Barracks"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barracks"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Barracks"));
		}

		// ----------------------------------- HERO_POWER - INVALID
		// [TB_SPT_DPromoHP] Diabolical Powers (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Summon a random Imp.
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38981
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DiabolicalPowers_TB_SPT_DPromoHP()
		{
			// TODO DiabolicalPowers_TB_SPT_DPromoHP test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Diabolical Powers"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Diabolical Powers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Diabolical Powers"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_SPT_DPromoHP2] So Many... (*) - COST:0 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Whenever a Hell Bovine Dies, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38981
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoMany_TB_SPT_DPromoHP2()
		{
			// TODO SoMany_TB_SPT_DPromoHP2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("So Many..."),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("So Many..."));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "So Many..."));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TB_SPT_MTH_BossHeroPower] Party Barracks (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Play a random Stormwind Partygoer.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PartyBarracks_TB_SPT_MTH_BossHeroPower()
		{
			// TODO PartyBarracks_TB_SPT_MTH_BossHeroPower test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Party Barracks"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Party Barracks"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Party Barracks"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TBA01_5] Wild Magic (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random spell from any class to your hand. It costs (0).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildMagic_TBA01_5()
		{
			// TODO WildMagic_TBA01_5 test
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
		// [TBA01_6] Molten Rage (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 5/1 Magma Rager.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoltenRage_TBA01_6()
		{
			// TODO MoltenRage_TBA01_6 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Molten Rage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Molten Rage"));
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [TP_Bling_HP2] Cash In (*) - COST:2 
		// - Set: tb, 
		// --------------------------------------------------------
		// Text: Destroy your weapon, gaining a random one.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CashIn_TP_Bling_HP2()
		{
			// TODO CashIn_TP_Bling_HP2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cash In"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cash In"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cash In"));
		}

	}

}
