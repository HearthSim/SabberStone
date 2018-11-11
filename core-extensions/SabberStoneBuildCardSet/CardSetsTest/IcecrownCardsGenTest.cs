using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thrall, Deathseer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrall, Deathseer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thrall, Deathseer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Valeera the Hollow"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Valeera the Hollow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Valeera the Hollow"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathstalker Rexxar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathstalker Rexxar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathstalker Rexxar"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Uther of the Ebon Blade"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Uther of the Ebon Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Uther of the Ebon Blade"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowreaper Anduin"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowreaper Anduin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowreaper Anduin"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodreaver Gul'dan"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodreaver Gul'dan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodreaver Gul'dan"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malfurion the Pestilent"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malfurion the Pestilent"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malfurion the Pestilent"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Lich Jaina"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Lich Jaina"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Lich Jaina"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scourgelord Garrosh"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scourgelord Garrosh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scourgelord Garrosh"));
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
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TransmuteSpirit_ICC_481p()
		{
			// TODO TransmuteSpirit_ICC_481p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Transmute Spirit"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Transmute Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Transmute Spirit"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Death's Shadow"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death's Shadow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Death's Shadow"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Build-A-Beast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Build-A-Beast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Build-A-Beast"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Four Horsemen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Four Horsemen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Four Horsemen"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [ICC_830p] Voidform (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Deal $2 damage.
		//       After you play a card,
		//       refresh this. @spelldmg
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidform"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidform"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voidform"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_831p] Siphon Life (*) - COST:2 
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
		public void SiphonLife_ICC_831p()
		{
			// TODO SiphonLife_ICC_831p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Siphon Life"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Siphon Life"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Siphon Life"));
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
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueLord_ICC_832p()
		{
			// TODO PlagueLord_ICC_832p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague Lord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Lord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plague Lord"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_833h] Icy Touch (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage. If this kills a minion, summon a Water Elemental. @spelldmg
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Icy Touch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icy Touch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Icy Touch"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [ICC_834h] Bladestorm (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage to all_minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bladestorm_ICC_834h()
		{
			// TODO Bladestorm_ICC_834h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bladestorm"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladestorm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bladestorm"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fatespinner"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fatespinner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fatespinner"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Druid of the Swarm"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Swarm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Druid of the Swarm"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Strongshell Scavenger"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Strongshell Scavenger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Strongshell Scavenger"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crypt Lord"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crypt Lord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crypt Lord"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hadronox"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hadronox"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hadronox"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Webweave"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Webweave"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Webweave"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_054] Spreading Plague - COST:6 
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spreading Plague"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spreading Plague"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spreading Plague"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnash"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnash"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_085] Ultimate Infestation - COST:10 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage. Draw
		//       5 cards. Gain 5 Armor.
		//       Summon a 5/5 Ghoul. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UltimateInfestation_ICC_085()
		{
			// TODO UltimateInfestation_ICC_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ultimate Infestation"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ultimate Infestation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ultimate Infestation"));
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
		[Fact(Skip = "ignore")]
		public void ExplodingBloatbat_ICC_021()
		{
			// TODO ExplodingBloatbat_ICC_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Exploding Bloatbat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Exploding Bloatbat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Exploding Bloatbat"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Professor Putricide"),
				},
				Player2HeroClass = CardClass.HUNTER,
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corpse Widow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Widow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corpse Widow"));
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
		[Fact(Skip = "ignore")]
		public void StitchedTracker_ICC_415()
		{
			// TODO StitchedTracker_ICC_415 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stitched Tracker"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stitched Tracker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stitched Tracker"));
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
		[Fact(Skip = "ignore")]
		public void Bearshark_ICC_419()
		{
			// TODO Bearshark_ICC_419 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bearshark"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bearshark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bearshark"));
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
		[Fact(Skip = "ignore")]
		public void AbominableBowman_ICC_825()
		{
			// TODO AbominableBowman_ICC_825 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Abominable Bowman"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Abominable Bowman"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_049] Toxic Arrow - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToxicArrow_ICC_049()
		{
			// TODO ToxicArrow_ICC_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxic Arrow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxic Arrow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toxic Arrow"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_052] Play Dead - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Trigger a friendly minion's <b>Deathrattle</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlayDead_ICC_052()
		{
			// TODO PlayDead_ICC_052 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Play Dead"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Play Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Play Dead"));
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
		[Fact(Skip = "ignore")]
		public void VenomstrikeTrap_ICC_200()
		{
			// TODO VenomstrikeTrap_ICC_200 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Venomstrike Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomstrike Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Venomstrike Trap"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Walker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Walker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Walker"));
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
		[Fact(Skip = "ignore")]
		public void GhastlyConjurer_ICC_069()
		{
			// TODO GhastlyConjurer_ICC_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ghastly Conjurer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ghastly Conjurer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ghastly Conjurer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomed Apprentice"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomed Apprentice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomed Apprentice"));
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
		// - REQ_FROZEN_TARGET = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coldwraith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldwraith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coldwraith"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frozen Clone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frozen Clone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frozen Clone"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glacial Mysteries"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glacial Mysteries"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glacial Mysteries"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Simulacrum"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Simulacrum"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Simulacrum"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_836] Breath of Sindragosa - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. @spelldmg
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Breath of Sindragosa"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Breath of Sindragosa"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Breath of Sindragosa"));
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
		// - 974 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArrogantCrusader_ICC_034()
		{
			// TODO ArrogantCrusader_ICC_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arrogant Crusader"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arrogant Crusader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arrogant Crusader"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Righteous Protector"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Righteous Protector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Righteous Protector"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackguard"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackguard"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Howling Commander"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Howling Commander"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Howling Commander"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chillblade Champion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillblade Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chillblade Champion"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bolvar, Fireblood"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bolvar, Fireblood"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bolvar, Fireblood"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Conviction"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Conviction"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Conviction"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ICC_244] Desperate Stand - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desperate Stand"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desperate Stand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Desperate Stand"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Light's Sorrow"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Sorrow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Light's Sorrow"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Ascendant"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Ascendant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Ascendant"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acolyte of Agony"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acolyte of Agony"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Acolyte of Agony"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt, Lifesteal</b>
		//       <b>Deathrattle:</b> Destroy a
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Obsidian Statue"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Statue"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Obsidian Statue"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archbishop Benedictus"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archbishop Benedictus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archbishop Benedictus"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devour Mind"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devour Mind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Devour Mind"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_213] Eternal Servitude - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// - REQ_NUM_MINION_SLOTS = 1
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eternal Servitude"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eternal Servitude"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eternal Servitude"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Essence"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Essence"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Essence"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_802] Spirit Lash - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $1 damage to_all_minions. @spelldmg
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit Lash"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Lash"));
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
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmbraceDarkness_ICC_849()
		{
			// TODO EmbraceDarkness_ICC_849 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Embrace Darkness"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embrace Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Embrace Darkness"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Baron"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Baron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bone Baron"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Runeforge Haunter"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Runeforge Haunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Runeforge Haunter"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_FOR_COMBO = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague Scientist"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Scientist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plague Scientist"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lilian Voss"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lilian Voss"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lilian Voss"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spectral Pillager"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spectral Pillager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spectral Pillager"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Roll the Bones"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Roll the Bones"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Roll the Bones"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Leeching Poison"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leeching Poison"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leeching Poison"));
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
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomerang"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomerang"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomerang"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowblade"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowblade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowblade"));
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_ENEMY_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brrrloc"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brrrloc"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brrrloc"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Overload:</b> (3)
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drakkari Defender"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakkari Defender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakkari Defender"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voodoo Hexxer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoo Hexxer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voodoo Hexxer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snowfury Giant"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowfury Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Snowfury Giant"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Moorabi"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moorabi"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Moorabi"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_056] Cryostasis - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a minion +3/+3 and <b>Freeze</b> it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cryostasis"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cryostasis"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cryostasis"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_078] Avalanche - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Avalanche_ICC_078()
		{
			// TODO Avalanche_ICC_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Avalanche"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avalanche"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Avalanche"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Fishing"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Fishing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Fishing"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Breaker"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Breaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Breaker"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Despicable Dreadlord"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Despicable Dreadlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Despicable Dreadlord"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Howlfiend"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Howlfiend"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Howlfiend"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnomeferatu"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnomeferatu"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnomeferatu"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood-Queen Lana'thel"),
				},
				Player2HeroClass = CardClass.WARLOCK,
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SanguineReveler_ICC_903()
		{
			// TODO SanguineReveler_ICC_903 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sanguine Reveler"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sanguine Reveler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sanguine Reveler"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_041] Defile - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. If any die, cast this again. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Defile_ICC_041()
		{
			// TODO Defile_ICC_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Defile"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defile"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Defile"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_055] Drain Soul - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $2 damage
		//       to a minion. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrainSoul_ICC_055()
		{
			// TODO DrainSoul_ICC_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drain Soul"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drain Soul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drain Soul"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_206] Treachery - COST:3 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Choose a friendly minion and give it to_your opponent.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Treachery_ICC_206()
		{
			// TODO Treachery_ICC_206 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Treachery"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Treachery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Treachery"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_469] Unwilling Sacrifice - COST:3 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Choose a friendly minion. Destroy it and a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnwillingSacrifice_ICC_469()
		{
			// TODO UnwillingSacrifice_ICC_469 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unwilling Sacrifice"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unwilling Sacrifice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unwilling Sacrifice"));
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
		// - 974 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MountainfireArmor_ICC_062()
		{
			// TODO MountainfireArmor_ICC_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mountainfire Armor"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mountainfire Armor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mountainfire Armor"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Animated Berserker"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animated Berserker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Animated Berserker"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_405] Rotface - COST:8 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]After this minion
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rotface"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rotface"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rotface"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After this minion
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Val'kyr Soulclaimer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Val'kyr Soulclaimer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Val'kyr Soulclaimer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Death Revenant"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death Revenant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Death Revenant"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dead Man's Hand"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dead Man's Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dead Man's Hand"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forge of Souls"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forge of Souls"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forge of Souls"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bring It On!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bring It On!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bring It On!"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b>
		//       Deal 1 damage to all_minions.
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Razor"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Razor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Razor"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Phantom Freebooter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phantom Freebooter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Phantom Freebooter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - 974 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skelemancer_ICC_019()
		{
			// TODO Skelemancer_ICC_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skelemancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skelemancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skelemancer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snowflipper Penguin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowflipper Penguin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Snowflipper Penguin"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rattling Rascal"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rattling Rascal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rattling Rascal"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grim Necromancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grim Necromancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grim Necromancer"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bone Drake"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunborne Val'kyr"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunborne Val'kyr"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sunborne Val'kyr"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cobalt Scalebane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cobalt Scalebane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cobalt Scalebane"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Night Howler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Night Howler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Night Howler"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Venomancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Venomancer"));
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
		// - 974 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vryghoul_ICC_067()
		{
			// TODO Vryghoul_ICC_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vryghoul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vryghoul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vryghoul"));
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcherusVeteran_ICC_092()
		{
			// TODO AcherusVeteran_ICC_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acherus Veteran"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acherus Veteran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Acherus Veteran"));
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tuskarr Fisherman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Fisherman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tuskarr Fisherman"));
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FallenSunCleric_ICC_094()
		{
			// TODO FallenSunCleric_ICC_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fallen Sun Cleric"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fallen Sun Cleric"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fallen Sun Cleric"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Furnacefire Colossus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Furnacefire Colossus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Furnacefire Colossus"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grave Shambler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grave Shambler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grave Shambler"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Lurker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Lurker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tomb Lurker"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ticking Abomination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ticking Abomination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ticking Abomination"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deadscale Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadscale Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deadscale Knight"));
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
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corpse Raiser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Raiser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corpse Raiser"));
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
		[Fact(Skip = "ignore")]
		public void SaroniteChainGang_ICC_466()
		{
			// TODO SaroniteChainGang_ICC_466 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Saronite Chain Gang"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saronite Chain Gang"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Saronite Chain Gang"));
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
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathspeaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathspeaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathspeaker"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wretched Tiller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wretched Tiller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wretched Tiller"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Happy Ghoul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Happy Ghoul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Happy Ghoul"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skulking Geist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skulking Geist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skulking Geist"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shallow Gravedigger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shallow Gravedigger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shallow Gravedigger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_705] Bonemare - COST:8 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bonemare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bonemare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bonemare"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nerubian Unraveler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Unraveler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nerubian Unraveler"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathaxe Punisher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathaxe Punisher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathaxe Punisher"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Meat Wagon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Meat Wagon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Meat Wagon"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Keleseth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Keleseth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Keleseth"));
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
		// - REQ_TARGET_IF_AVAILABLE_AND_NO_3_COST_CARD_IN_DECK = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceTaldaram_ICC_852()
		{
			// TODO PrinceTaldaram_ICC_852 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Taldaram"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Taldaram"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Taldaram"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Valanar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Valanar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Valanar"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arfus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arfus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arfus"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hyldnir Frostrider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hyldnir Frostrider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hyldnir Frostrider"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellweaver"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellweaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spellweaver"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrotic Geist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Geist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrotic Geist"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drakkari Enchanter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakkari Enchanter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakkari Enchanter"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mindbreaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mindbreaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mindbreaker"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wicked Skeleton"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wicked Skeleton"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wicked Skeleton"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodworm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodworm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodworm"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keening Banshee"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keening Banshee"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Keening Banshee"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corpsetaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpsetaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corpsetaker"));
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
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tainted Zealot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tainted Zealot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tainted Zealot"));
		}

	}

}
