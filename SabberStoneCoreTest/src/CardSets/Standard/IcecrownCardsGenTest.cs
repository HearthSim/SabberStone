using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Actions;
using SabberStoneCore.Tasks.PlayerTasks;
using System.Collections.Generic;

namespace SabberStoneUnitTest.CardSets
{
	public class HeroesIcecrownTest
	{
		// ------------------------------------------ HERO - SHAMAN
		// [ICC_481] Thrall, Deathseer - COST:5 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform your minions into random ones that cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 42982
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThrallDeathseer_ICC_481()
		{
			// TODO ThrallDeathseer_ICC_481 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrall, Deathseer"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [ICC_827] Valeera the Hollow - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43188
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValeeraTheHollow_ICC_827()
		{
			// TODO ValeeraTheHollow_ICC_827 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Valeera the Hollow"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [ICC_828] Deathstalker Rexxar - COST:6 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 2 damage
		//       to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43183
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathstalkerRexxar_ICC_828()
		{
			// TODO DeathstalkerRexxar_ICC_828 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathstalker Rexxar"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [ICC_829] Uther of the Ebon Blade - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43013
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UtherOfTheEbonBlade_ICC_829()
		{
			// TODO UtherOfTheEbonBlade_ICC_829 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Uther of the Ebon Blade"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [ICC_830] Shadowreaper Anduin - COST:8 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 45397
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowreaperAnduin_ICC_830()
		{
			// TODO ShadowreaperAnduin_ICC_830 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowreaper Anduin"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [ICC_831] Bloodreaver Gul'dan - COST:10 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43181
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodreaverGuldan_ICC_831()
		{
			// TODO BloodreaverGuldan_ICC_831 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodreaver Gul'dan"));
		}

		// ------------------------------------------- HERO - DRUID
		// [ICC_832] Malfurion the Pestilent - COST:7 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b>
		//       Summon 2 <b>Poisonous</b>
		//       Spiders; or 2 Scarabs
		//       with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - ARMOR = 5
		// - HERO_POWER = 43182
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MalfurionThePestilent_ICC_832()
		{
			// TODO MalfurionThePestilent_ICC_832 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malfurion the Pestilent"));
		}

		// -------------------------------------------- HERO - MAGE
		// [ICC_833] Frost Lich Jaina - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       3/6 Water Elemental.
		//       Your Elementals have
		//       <b>Lifesteal</b> this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 42944
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostLichJaina_ICC_833()
		{
			// TODO FrostLichJaina_ICC_833 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Lich Jaina"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [ICC_834] Scourgelord Garrosh - COST:8 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 45585
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScourgelordGarrosh_ICC_834()
		{
			// TODO ScourgelordGarrosh_ICC_834 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scourgelord Garrosh"));
		}

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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
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
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tirion Fordring"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secrets of the Citadel"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sindragosa"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood-Queen Lana'thel"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Marrowgar"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathbringer Saurfang"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady Deathwhisper"));
		}

	}

	public class HeroPowersIcecrownTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_481p] Transmute Spirit (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TransmuteSpirit_ICC_481p()
		{
			// TODO TransmuteSpirit_ICC_481p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Transmute Spirit"));
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [ICC_827p] Death's Shadow (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       During your turn, add a 'Shadow Reflection' to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathsShadow_ICC_827p()
		{
			// TODO DeathsShadow_ICC_827p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death's Shadow"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_828p] Build-A-Beast (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Craft a custom Zombeast.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HAND_NOT_FULL = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BuildABeast_ICC_828p()
		{
			// TODO BuildABeast_ICC_828p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Build-A-Beast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_829p] The Four Horsemen (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 2/2 Horseman.
		//       If you have all 4, destroy
		//       the enemy hero.
		// --------------------------------------------------------
		// Entourage: ICC_829t2, ICC_829t3, ICC_829t4, ICC_829t5
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheFourHorsemen_ICC_829p()
		{
			// TODO TheFourHorsemen_ICC_829p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Four Horsemen"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [ICC_830p] Voidform (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage.
		//       After you play a card,
		//       refresh this. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voidform_ICC_830p()
		{
			// TODO Voidform_ICC_830p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidform"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_831p] Siphon Life (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Lifesteal</b>
		//       Deal $3 damage. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SiphonLife_ICC_831p()
		{
			// TODO SiphonLife_ICC_831p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Siphon Life"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_832p] Plague Lord (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       <b>Choose One -</b> +3 Attack
		//       this turn; or Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueLord_ICC_832p()
		{
			// TODO PlagueLord_ICC_832p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Lord"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_833h] Icy Touch (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage. If this kills a minion, summon a Water Elemental. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IcyTouch_ICC_833h()
		{
			// TODO IcyTouch_ICC_833h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icy Touch"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [ICC_834h] Bladestorm (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage to all_minions. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bladestorm_ICC_834h()
		{
			// TODO Bladestorm_ICC_834h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladestorm"));
		}

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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Breath"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Breath"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Breath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA04_011p] Ice Claw (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. *spelldmg
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Claw"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vampiric Bite"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICCA05_004p] Vampiric Leech (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Lifesteal</b>
		//       Deal $3 damage. *spelldmg
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vampiric Leech"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skeletal Reconstruction"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Science"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Madder Science"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maddest Science"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Scourge"));
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
				Player2HeroClass = CardClass.DEATHKNIGHT,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Remorseless Winter"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest of Souls"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Rune"));
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whisper of Death"));
		}

	}

	public class DruidIcecrownTest
	{
		// ----------------------------------------- MINION - DRUID
		// [ICC_047] Fatespinner - COST:5 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose a Deathrattle (Secretly) -</b> Deal 3 damage to all minions; or Give them +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// - 818 = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fatespinner_ICC_047()
		{
			// TODO Fatespinner_ICC_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fatespinner"));
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_051] Druid of the Swarm - COST:2 [ATK:1/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Transform into a 1/2 with <b>Poisonous</b>; or a 1/5 with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DruidOfTheSwarm_ICC_051()
		{
			// TODO DruidOfTheSwarm_ICC_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Swarm"));
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_807] Strongshell Scavenger - COST:4 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your <b>Taunt</b> minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StrongshellScavenger_ICC_807()
		{
			// TODO StrongshellScavenger_ICC_807 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Strongshell Scavenger"));
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_808] Crypt Lord - COST:3 [ATK:1/HP:6] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       After you summon a minion,
		//        gain +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CryptLord_ICC_808()
		{
			// TODO CryptLord_ICC_808 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crypt Lord"));
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_835] Hadronox - COST:9 [ATK:3/HP:7] 
		// - Race: beast, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon your <b>Taunt</b> minions that
		//       died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hadronox_ICC_835()
		{
			// TODO Hadronox_ICC_835 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hadronox"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_050] Webweave - COST:5 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Summon two 1/2 <b>Poisonous</b> Spiders.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Webweave_ICC_050()
		{
			// TODO Webweave_ICC_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Webweave"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_054] Spreading Plague - COST:5 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 1/5 Scarab with <b>Taunt</b>. If your_opponent has more minions, cast this again.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpreadingPlague_ICC_054()
		{
			// TODO SpreadingPlague_ICC_054 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spreading Plague"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_079] Gnash - COST:3 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Give your hero +3_Attack this turn. Gain 3 Armor.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gnash_ICC_079()
		{
			// TODO Gnash_ICC_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnash"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_085] Ultimate Infestation - COST:10 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage. Draw
		//       5 cards. Gain 5 Armor.
		//       Summon a 5/5 Ghoul. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void UltimateInfestation_ICC_085()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ultimate Infestation"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);  //4 from starting hand and 5 from the spell
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Equal("ICC_085t", game.CurrentPlayer.BoardZone[0].Card.Id);
		}

	}

	public class HunterIcecrownTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [ICC_021] Exploding Bloatbat - COST:4 [ATK:2/HP:1] 
		// - Race: beast, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b>
		//       Deal 2 damage to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ExplodingBloatbat_ICC_021()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Exploding Bloatbat"));
			IPlayable alarm = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alarm-o-Bot"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, alarm));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable aberrant = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aberrant Berserker"));
			IPlayable shot1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, aberrant));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot1, testCard));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, ((Minion)aberrant).Health);
			Assert.Equal(3, ((Minion)alarm).Health);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_204] Professor Putricide - COST:4 [ATK:5/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you play a <b>Secret</b>,
		//       put a random Hunter <b>Secret</b> into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProfessorPutricide_ICC_204()
		{
			// TODO ProfessorPutricide_ICC_204 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Professor Putricide"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_243] Corpse Widow - COST:5 [ATK:4/HP:6] 
		// - Race: beast, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your <b>Deathrattle</b> cards cost_(2) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorpseWidow_ICC_243()
		{
			// TODO CorpseWidow_ICC_243 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Widow"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_415] Stitched Tracker - COST:3 [ATK:2/HP:2] 
		// - Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a copy of a minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void StitchedTracker_ICC_415()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Shot"), Cards.FromName("Arcane Shot"),
					Cards.FromName("Hunter's Mark"), Cards.FromName("Hunter's Mark"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Kill Command"), Cards.FromName("Kill Command"),
					Cards.FromName("Multi-Shot"), Cards.FromName("Multi-Shot"),
					Cards.FromName("Play Dead"), Cards.FromName("Play Dead"),
					Cards.FromName("Deadly Shot"), Cards.FromName("Deadly Shot"),
					Cards.FromName("Explosive Trap"), Cards.FromName("Explosive Trap")
				},
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stitched Tracker"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			int choice = game.CurrentPlayer.Choice.Choices[0];
			game.Process(ChooseTask.Pick(game.CurrentPlayer, choice));
			Assert.Equal(CardType.MINION, game.CurrentPlayer.HandZone[4].Card.Type);
			Assert.Equal("Murloc Raider", game.CurrentPlayer.HandZone[4].Card.Name);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Null(game.CurrentPlayer.Choice);
			Assert.Equal("Murloc Raider", game.CurrentPlayer.HandZone[5].Card.Name);
			Assert.False(game.CurrentPlayer.DeckZone.GetAll.Exists(p => p is Minion));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stitched Tracker"));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Null(game.CurrentPlayer.Choice);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_419] Bearshark - COST:3 [ATK:4/HP:3] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact]
		public void Bearshark_ICC_419()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bearshark"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(3, ((Minion)testCard).Health);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.False(((Minion)testCard).IsDead);
			Assert.Equal(3, ((Minion)testCard).Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_825] Abominable Bowman - COST:7 [ATK:6/HP:7] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon
		//       a random friendly Beast
		//       that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void AbominableBowman_ICC_825()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			IPlayable beast = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable murloc = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, beast));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, murloc));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable mark1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			IPlayable shot1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			IPlayable shot2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			IPlayable shot3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot3, murloc));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, mark1, testCard1));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot1, testCard1));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot2, beast));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable mark2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			IPlayable shot4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, mark2, testCard2));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot4, testCard2));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Stonetusk Boar", game.CurrentOpponent.BoardZone[0].Card.Name);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_049] Toxic Arrow - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void ToxicArrow_ICC_049()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxic Arrow"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aberrant Berserker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.True(((Minion)minion).Poisonous);
			Assert.True(((Minion)minion).IsEnraged);
			Assert.Equal(3, ((Minion)minion).Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_052] Play Dead - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Trigger a friendly minion's <b>Deathrattle</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void PlayDead_ICC_052()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Play Dead"));
			var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_200] Venomstrike Trap - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, summon a 2/3_<b>Poisonous</b> Cobra.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void VenomstrikeTrap_ICC_200()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomstrike Trap"));
			var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Triggers.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Triggers.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

	}

	public class MageIcecrownTest
	{
		// ------------------------------------------ MINION - MAGE
		// [ICC_068] Ice Walker - COST:2 [ATK:1/HP:3] 
		// - Race: elemental, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your Hero Power also <b><b>Freeze</b>s</b> the target.
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceWalker_ICC_068()
		{
			// TODO IceWalker_ICC_068 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Walker"));
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_069] Ghastly Conjurer - COST:4 [ATK:2/HP:6] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a 'Mirror Image' spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GhastlyConjurer_ICC_069()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard =  Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ghastly Conjurer"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("CS2_027", game.CurrentPlayer.HandZone[4].Card.Id);
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_083] Doomed Apprentice - COST:3 [ATK:3/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your opponent's spells cost (1) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DoomedApprentice_ICC_083()
		{
			// TODO DoomedApprentice_ICC_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomed Apprentice"));
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_252] Coldwraith - COST:3 [ATK:3/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FROZEN_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Coldwraith_ICC_252()
		{
			// TODO Coldwraith_ICC_252 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldwraith"));
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_838] Sindragosa - COST:8 [ATK:8/HP:8] 
		// - Race: dragon, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 0/1 Frozen Champions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sindragosa_ICC_838()
		{
			// TODO Sindragosa_ICC_838 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sindragosa"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_082] Frozen Clone - COST:3 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, add two copies of it to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrozenClone_ICC_082()
		{
			// TODO FrozenClone_ICC_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frozen Clone"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_086] Glacial Mysteries - COST:8 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Put one of each <b>Secret</b> from your deck into
		//       the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlacialMysteries_ICC_086()
		{
			// TODO GlacialMysteries_ICC_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glacial Mysteries"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_823] Simulacrum - COST:3 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Copy the lowest Cost minion in your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Simulacrum_ICC_823()
		{
			// TODO Simulacrum_ICC_823 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Simulacrum"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_836] Breath of Sindragosa - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BreathOfSindragosa_ICC_836()
		{
			// TODO BreathOfSindragosa_ICC_836 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Breath of Sindragosa"));
		}

	}

	public class PaladinIcecrownTest
	{
		// --------------------------------------- MINION - PALADIN
		// [ICC_034] Arrogant Crusader - COST:4 [ATK:5/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon a 2/2 Ghoul.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArrogantCrusader_ICC_034()
		{
			// TODO ArrogantCrusader_ICC_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arrogant Crusader"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_038] Righteous Protector - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RighteousProtector_ICC_038()
		{
			// TODO RighteousProtector_ICC_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Righteous Protector"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_245] Blackguard - COST:6 [ATK:3/HP:9] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever your hero is healed, deal that much damage to a random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blackguard_ICC_245()
		{
			// TODO Blackguard_ICC_245 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackguard"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_801] Howling Commander - COST:3 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a <b>Divine_Shield</b> minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HowlingCommander_ICC_801()
		{
			// TODO HowlingCommander_ICC_801 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Howling Commander"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_820] Chillblade Champion - COST:4 [ATK:3/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChillbladeChampion_ICC_820()
		{
			// TODO ChillbladeChampion_ICC_820 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillblade Champion"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_858] Bolvar, Fireblood - COST:5 [ATK:1/HP:7] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       After a friendly minion loses_<b>Divine Shield</b>, gain +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BolvarFireblood_ICC_858()
		{
			// TODO BolvarFireblood_ICC_858 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bolvar, Fireblood"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ICC_039] Dark Conviction - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Set a minion's Attack and Health to 3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkConviction_ICC_039()
		{
			// TODO DarkConviction_ICC_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Conviction"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ICC_244] Desperate Stand - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesperateStand_ICC_244()
		{
			// TODO DesperateStand_ICC_244 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desperate Stand"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [ICC_071] Light's Sorrow - COST:4 [ATK:1/HP:0] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: After a friendly minion loses <b>Divine Shield</b>, gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsSorrow_ICC_071()
		{
			// TODO LightsSorrow_ICC_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Sorrow"));
		}

	}

	public class PriestIcecrownTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [ICC_210] Shadow Ascendant - COST:2 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       give another random
		//       friendly minion +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowAscendant_ICC_210()
		{
			// TODO ShadowAscendant_ICC_210 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Ascendant"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_212] Acolyte of Agony - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcolyteOfAgony_ICC_212()
		{
			// TODO AcolyteOfAgony_ICC_212 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acolyte of Agony"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>. <b>Lifesteal</b>.
		//        <b>Deathrattle:</b> Destroy a
		//        random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObsidianStatue_ICC_214()
		{
			// TODO ObsidianStatue_ICC_214 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Statue"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_215] Archbishop Benedictus - COST:7 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle a copy of_your opponent's deck into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArchbishopBenedictus_ICC_215()
		{
			// TODO ArchbishopBenedictus_ICC_215 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archbishop Benedictus"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_207] Devour Mind - COST:5 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Copy 3 cards in your opponent's deck and add them to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DevourMind_ICC_207()
		{
			// TODO DevourMind_ICC_207 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devour Mind"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_213] Eternal Servitude - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EternalServitude_ICC_213()
		{
			// TODO EternalServitude_ICC_213 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eternal Servitude"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_235] Shadow Essence - COST:6 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 5/5 copy of_a random minion in_your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowEssence_ICC_235()
		{
			// TODO ShadowEssence_ICC_235 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Essence"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_802] Spirit Lash - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $1 damage to_all_minions. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritLash_ICC_802()
		{
			// TODO SpiritLash_ICC_802 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_849] Embrace Darkness - COST:6 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Choose an enemy minion.
		//       At the start of your turn,
		//       gain control of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmbraceDarkness_ICC_849()
		{
			// TODO EmbraceDarkness_ICC_849 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embrace Darkness"));
		}

	}

	public class RogueIcecrownTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [ICC_065] Bone Baron - COST:5 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add two 1/1 Skeletons to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneBaron_ICC_065()
		{
			// TODO BoneBaron_ICC_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Baron"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_240] Runeforge Haunter - COST:4 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: During your turn, your weapon doesn't lose Durability.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RuneforgeHaunter_ICC_240()
		{
			// TODO RuneforgeHaunter_ICC_240 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Runeforge Haunter"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_809] Plague Scientist - COST:3 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Give a friendly minion <b>Poisonous</b>.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueScientist_ICC_809()
		{
			// TODO PlagueScientist_ICC_809 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Scientist"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_811] Lilian Voss - COST:4 [ATK:4/HP:5] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Replace spells in your hand with random spells <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LilianVoss_ICC_811()
		{
			// TODO LilianVoss_ICC_811 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lilian Voss"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_910] Spectral Pillager - COST:6 [ATK:5/HP:5] 
		// - Fac: neutral, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Combo:</b> Deal damage equal
		//       to the number of other cards
		//       you've played this turn.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpectralPillager_ICC_910()
		{
			// TODO SpectralPillager_ICC_910 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spectral Pillager"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_201] Roll the Bones - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card.
		//       If it has <b>Deathrattle</b>, cast this again.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RollTheBones_ICC_201()
		{
			// TODO RollTheBones_ICC_201 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Roll the Bones"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_221] Leeching Poison - COST:2 
		// - Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Give your weapon <b>Lifesteal</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeechingPoison_ICC_221()
		{
			// TODO LeechingPoison_ICC_221 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leeching Poison"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_233] Doomerang - COST:1 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Throw your weapon at a minion. It deals its damage, then returns to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doomerang_ICC_233()
		{
			// TODO Doomerang_ICC_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomerang"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [ICC_850] Shadowblade - COST:3 [ATK:3/HP:0] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your hero is <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowblade_ICC_850()
		{
			// TODO Shadowblade_ICC_850 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowblade"));
		}

	}

	public class ShamanIcecrownTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [ICC_058] Brrrloc - COST:2 [ATK:2/HP:2] 
		// - Race: murloc, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Freeze</b> an_enemy.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brrrloc_ICC_058()
		{
			// TODO Brrrloc_ICC_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brrrloc"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Overload</b>: (3)
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrakkariDefender_ICC_081()
		{
			// TODO DrakkariDefender_ICC_081 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakkari Defender"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_088] Voodoo Hexxer - COST:5 [ATK:2/HP:7] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Freeze</b> any character damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoodooHexxer_ICC_088()
		{
			// TODO VoodooHexxer_ICC_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoo Hexxer"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_090] Snowfury Giant - COST:11 [ATK:8/HP:8] 
		// - Race: elemental, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each Mana Crystal you've <b><b>Overload</b>ed</b> this game.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SnowfuryGiant_ICC_090()
		{
			// TODO SnowfuryGiant_ICC_090 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowfury Giant"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_289] Moorabi - COST:6 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever another minion is <b>Frozen</b>, add a copy of it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Moorabi_ICC_289()
		{
			// TODO Moorabi_ICC_289 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moorabi"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_056] Cryostasis - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a minion +3/+3 and <b>Freeze</b> it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cryostasis_ICC_056()
		{
			// TODO Cryostasis_ICC_056 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cryostasis"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_078] Avalanche - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Avalanche_ICC_078()
		{
			// TODO Avalanche_ICC_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avalanche"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_089] Ice Fishing - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 Murlocs from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceFishing_ICC_089()
		{
			// TODO IceFishing_ICC_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Fishing"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [ICC_236] Ice Breaker - COST:3 [ATK:1/HP:0] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy any <b>Frozen</b> minion damaged by_this.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceBreaker_ICC_236()
		{
			// TODO IceBreaker_ICC_236 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Breaker"));
		}

	}

	public class WarlockIcecrownTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [ICC_075] Despicable Dreadlord - COST:5 [ATK:4/HP:5] 
		// - Race: demon, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 1 damage to all enemy minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DespicableDreadlord_ICC_075()
		{
			// TODO DespicableDreadlord_ICC_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Despicable Dreadlord"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_218] Howlfiend - COST:3 [ATK:3/HP:6] 
		// - Race: demon, Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, discard a_random card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Howlfiend_ICC_218()
		{
			// TODO Howlfiend_ICC_218 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Howlfiend"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_407] Gnomeferatu - COST:2 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Remove
		//       the top card of your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gnomeferatu_ICC_407()
		{
			// TODO Gnomeferatu_ICC_407 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnomeferatu"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_841] Blood-Queen Lana'thel - COST:5 [ATK:1/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Lifesteal</b>
		//       Has +1 Attack for each
		//       card you've discarded
		//       this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodQueenLanathel_ICC_841()
		{
			// TODO BloodQueenLanathel_ICC_841 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood-Queen Lana'thel"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_903] Sanguine Reveler - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a friendly minion and gain_+2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SanguineReveler_ICC_903()
		{
			// TODO SanguineReveler_ICC_903 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sanguine Reveler"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_041] Defile - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. If any die, cast this again. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Defile_ICC_041()
		{
			// TODO Defile_ICC_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defile"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_055] Drain Soul - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $2 damage
		//       to a minion. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrainSoul_ICC_055()
		{
			// TODO DrainSoul_ICC_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drain Soul"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_206] Treachery - COST:3 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Choose a friendly minion and give it to_your opponent.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Treachery_ICC_206()
		{
			// TODO Treachery_ICC_206 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Treachery"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_469] Unwilling Sacrifice - COST:3 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Choose a friendly minion. Destroy it and a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnwillingSacrifice_ICC_469()
		{
			// TODO UnwillingSacrifice_ICC_469 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unwilling Sacrifice"));
		}

	}

	public class WarriorIcecrownTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [ICC_062] Mountainfire Armor - COST:3 [ATK:4/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn,
		//       gain 6 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MountainfireArmor_ICC_062()
		{
			// TODO MountainfireArmor_ICC_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mountainfire Armor"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_238] Animated Berserker - COST:1 [ATK:1/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a minion, deal 1 damage to it.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnimatedBerserker_ICC_238()
		{
			// TODO AnimatedBerserker_ICC_238 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animated Berserker"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_405] Rotface - COST:8 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever this minion
		//       survives damage,
		//       summon a random
		//       <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rotface_ICC_405()
		{
			// TODO Rotface_ICC_405 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rotface"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Whenever this minion
		//       survives damage,
		//       summon a 2/2 Ghoul.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValkyrSoulclaimer_ICC_408()
		{
			// TODO ValkyrSoulclaimer_ICC_408 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Val'kyr Soulclaimer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_450] Death Revenant - COST:5 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each damaged minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathRevenant_ICC_450()
		{
			// TODO DeathRevenant_ICC_450 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death Revenant"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_091] Dead Man's Hand - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle a copy of your hand into your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadMansHand_ICC_091()
		{
			// TODO DeadMansHand_ICC_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dead Man's Hand"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_281] Forge of Souls - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 weapons from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForgeOfSouls_ICC_281()
		{
			// TODO ForgeOfSouls_ICC_281 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forge of Souls"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_837] Bring It On! - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BringItOn_ICC_837()
		{
			// TODO BringItOn_ICC_837 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bring It On!"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b>
		//       Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodRazor_ICC_064()
		{
			// TODO BloodRazor_ICC_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Razor"));
		}

	}

	public class NeutralIcecrownTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [ICC_018] Phantom Freebooter - COST:4 [ATK:3/HP:3] 
		// - Race: pirate, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain stats equal to your weapon's.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PhantomFreebooter_ICC_018()
		{
			// TODO PhantomFreebooter_ICC_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phantom Freebooter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skelemancer_ICC_019()
		{
			// TODO Skelemancer_ICC_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skelemancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_023] Snowflipper Penguin - COST:0 [ATK:1/HP:1] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SnowflipperPenguin_ICC_023()
		{
			// TODO SnowflipperPenguin_ICC_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowflipper Penguin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_025] Rattling Rascal - COST:4 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       5/5 Skeleton.
		//       <b>Deathrattle:</b> Summon one
		//       for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RattlingRascal_ICC_025()
		{
			// TODO RattlingRascal_ICC_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rattling Rascal"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_026] Grim Necromancer - COST:4 [ATK:2/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Skeletons.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimNecromancer_ICC_026()
		{
			// TODO GrimNecromancer_ICC_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grim Necromancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_027] Bone Drake - COST:6 [ATK:6/HP:5] 
		// - Race: dragon, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneDrake_ICC_027()
		{
			// TODO BoneDrake_ICC_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_028] Sunborne Val'kyr - COST:5 [ATK:5/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions +2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunborneValkyr_ICC_028()
		{
			// TODO SunborneValkyr_ICC_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunborne Val'kyr"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_029] Cobalt Scalebane - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +3 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CobaltScalebane_ICC_029()
		{
			// TODO CobaltScalebane_ICC_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cobalt Scalebane"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_031] Night Howler - COST:4 [ATK:3/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes
		//       damage, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightHowler_ICC_031()
		{
			// TODO NightHowler_ICC_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Night Howler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_032] Venomancer - COST:5 [ATK:2/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Venomancer_ICC_032()
		{
			// TODO Venomancer_ICC_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_067] Vryghoul - COST:3 [ATK:3/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> If it's your
		//       opponent's turn,
		//       summon a 2/2 Ghoul.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vryghoul_ICC_067()
		{
			// TODO Vryghoul_ICC_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vryghoul"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_092] Acherus Veteran - COST:1 [ATK:2/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcherusVeteran_ICC_092()
		{
			// TODO AcherusVeteran_ICC_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acherus Veteran"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_093] Tuskarr Fisherman - COST:2 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TuskarrFisherman_ICC_093()
		{
			// TODO TuskarrFisherman_ICC_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Fisherman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_094] Fallen Sun Cleric - COST:2 [ATK:2/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FallenSunCleric_ICC_094()
		{
			// TODO FallenSunCleric_ICC_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fallen Sun Cleric"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_096] Furnacefire Colossus - COST:6 [ATK:6/HP:6] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Discard all weapons from your hand and gain their stats.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FurnacefireColossus_ICC_096()
		{
			// TODO FurnacefireColossus_ICC_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Furnacefire Colossus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_097] Grave Shambler - COST:4 [ATK:4/HP:4] 
		// - Race: elemental, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your weapon is destroyed, gain +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GraveShambler_ICC_097()
		{
			// TODO GraveShambler_ICC_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grave Shambler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_098] Tomb Lurker - COST:5 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add a random
		//       <b>Deathrattle</b> minion that died
		//       this game to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombLurker_ICC_098()
		{
			// TODO TombLurker_ICC_098 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Lurker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_099] Ticking Abomination - COST:4 [ATK:5/HP:6] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 5 damage to your minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TickingAbomination_ICC_099()
		{
			// TODO TickingAbomination_ICC_099 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ticking Abomination"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_220] Deadscale Knight - COST:1 [ATK:1/HP:1] 
		// - Race: murloc, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadscaleKnight_ICC_220()
		{
			// TODO DeadscaleKnight_ICC_220 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadscale Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_257] Corpse Raiser - COST:5 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give a friendly
		//       minion "<b>Deathrattle:</b>
		//         Resummon this minion."
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DEATH_KNIGHT = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorpseRaiser_ICC_257()
		{
			// TODO CorpseRaiser_ICC_257 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Raiser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_314] The Lich King - COST:8 [ATK:8/HP:8] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       At the end of your turn,
		//       add a random <b>Death Knight</b>
		//       card to your hand.
		// --------------------------------------------------------
		// Entourage: ICC_314t3, ICC_314t2, ICC_314t7, ICC_314t4, ICC_314t5, ICC_314t6, ICC_314t8, ICC_314t1
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheLichKing_ICC_314()
		{
			// TODO TheLichKing_ICC_314 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_466] Saronite Chain Gang - COST:4 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Summon a copy of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SaroniteChainGang_ICC_466()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saronite Chain Gang"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.Player1.BoardZone.Count);
			Assert.Equal("ICC_466", game.Player1.BoardZone[0].Card.Id);
			Assert.Equal("ICC_466", game.Player1.BoardZone[1].Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_467] Deathspeaker - COST:3 [ATK:2/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Deathspeaker_ICC_467()
		{
			// TODO Deathspeaker_ICC_467 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathspeaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_468] Wretched Tiller - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion attacks, deal 2 damage to_the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WretchedTiller_ICC_468()
		{
			// TODO WretchedTiller_ICC_468 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wretched Tiller"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_700] Happy Ghoul - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Costs (0) if your hero was healed this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HappyGhoul_ICC_700()
		{
			// TODO HappyGhoul_ICC_700 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Happy Ghoul"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_701] Skulking Geist - COST:6 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all
		//       1-Cost spells in both hands and decks.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkulkingGeist_ICC_701()
		{
			// TODO SkulkingGeist_ICC_701 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skulking Geist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_702] Shallow Gravedigger - COST:3 [ATK:3/HP:1] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShallowGravedigger_ICC_702()
		{
			// TODO ShallowGravedigger_ICC_702 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shallow Gravedigger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_705] Bonemare - COST:7 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bonemare_ICC_705()
		{
			// TODO Bonemare_ICC_705 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bonemare"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_706] Nerubian Unraveler - COST:6 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Spells cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NerubianUnraveler_ICC_706()
		{
			// TODO NerubianUnraveler_ICC_706 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Unraveler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_810] Deathaxe Punisher - COST:4 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathaxePunisher_ICC_810()
		{
			// TODO DeathaxePunisher_ICC_810 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathaxe Punisher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_812] Meat Wagon - COST:4 [ATK:1/HP:4] 
		// - Race: mechanical, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       minion from your deck
		//       with less Attack than
		//       this minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeatWagon_ICC_812()
		{
			// TODO MeatWagon_ICC_812 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Meat Wagon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_851] Prince Keleseth - COST:2 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has_no 2-Cost cards, give_all minions in your deck +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceKeleseth_ICC_851()
		{
			// TODO PrinceKeleseth_ICC_851 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Keleseth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_852] Prince Taldaram - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has_no 3-Cost cards, transform into a 3/3 copy of a minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_DRAG_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceTaldaram_ICC_852()
		{
			// TODO PrinceTaldaram_ICC_852 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Taldaram"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_853] Prince Valanar - COST:4 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceValanar_ICC_853()
		{
			// TODO PrinceValanar_ICC_853 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Valanar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_854] Arfus - COST:4 [ATK:2/HP:2] 
		// - Race: beast, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your_hand.
		// --------------------------------------------------------
		// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t5, ICC_314t7, ICC_314t8, ICC_314t6, ICC_314t1
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Arfus_ICC_854()
		{
			// TODO Arfus_ICC_854 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arfus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_855] Hyldnir Frostrider - COST:3 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Freeze</b> your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HyldnirFrostrider_ICC_855()
		{
			// TODO HyldnirFrostrider_ICC_855 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hyldnir Frostrider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_856] Spellweaver - COST:6 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Spellweaver_ICC_856()
		{
			// TODO Spellweaver_ICC_856 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellweaver"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_900] Necrotic Geist - COST:6 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever one of your other minions dies, summon a 2/2 Ghoul.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticGeist_ICC_900()
		{
			// TODO NecroticGeist_ICC_900 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Geist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_901] Drakkari Enchanter - COST:3 [ATK:1/HP:5] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Your end of turn effects trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrakkariEnchanter_ICC_901()
		{
			// TODO DrakkariEnchanter_ICC_901 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakkari Enchanter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_902] Mindbreaker - COST:3 [ATK:2/HP:5] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Hero Powers are disabled.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mindbreaker_ICC_902()
		{
			// TODO Mindbreaker_ICC_902 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mindbreaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_904] Wicked Skeleton - COST:4 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for_each minion that died_this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WickedSkeleton_ICC_904()
		{
			// TODO WickedSkeleton_ICC_904 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wicked Skeleton"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_905] Bloodworm - COST:5 [ATK:4/HP:4] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodworm_ICC_905()
		{
			// TODO Bloodworm_ICC_905 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodworm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_911] Keening Banshee - COST:4 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play a card, remove the top 3 cards of_your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KeeningBanshee_ICC_911()
		{
			// TODO KeeningBanshee_ICC_911 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keening Banshee"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_912] Corpsetaker - COST:4 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain <b>Taunt</b> if your
		//       deck has a <b>Taunt</b> minion.
		//       Repeat for <b>Divine Shield</b>,
		//       <b>Lifesteal</b>, <b>Windfury</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Corpsetaker_ICC_912()
		{
			// TODO Corpsetaker_ICC_912 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpsetaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_913] Tainted Zealot - COST:2 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TaintedZealot_ICC_913()
		{
			// TODO TaintedZealot_ICC_913 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tainted Zealot"));
		}

	}

}
