using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroPowersOgTest
	{
		// ----------------------------------- HERO_POWER - PALADIN
		// [OG_006b] The Tidal Hand (*) - COST:2 
		// - Set: og, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Murloc.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheTidalHand_OG_006b()
		{
			// TODO TheTidalHand_OG_006b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Tidal Hand"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Tidal Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Tidal Hand"));
		}

	}

	public class DruidOgTest
	{
		// ----------------------------------------- MINION - DRUID
		// [OG_044] Fandral Staghelm - COST:4 [ATK:3/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your <b>Choose One</b> cards and powers have both effects combined.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FandralStaghelm_OG_044()
		{
			// TODO FandralStaghelm_OG_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fandral Staghelm"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fandral Staghelm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fandral Staghelm"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_051] Forbidden Ancient - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Spend all your Mana. Gain +1/+1 for each mana spent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForbiddenAncient_OG_051()
		{
			// TODO ForbiddenAncient_OG_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Ancient"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Ancient"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forbidden Ancient"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_188] Klaxxi Amber-Weaver - COST:4 [ATK:4/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain +5 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KlaxxiAmberWeaver_OG_188()
		{
			// TODO KlaxxiAmberWeaver_OG_188 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Klaxxi Amber-Weaver"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Klaxxi Amber-Weaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Klaxxi Amber-Weaver"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_202] Mire Keeper - COST:4 [ATK:3/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Summon a
		//       2/2 Slime; or Gain an
		//       empty Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MireKeeper_OG_202()
		{
			// TODO MireKeeper_OG_202 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mire Keeper"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mire Keeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mire Keeper"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_293] Dark Arakkoa - COST:6 [ATK:5/HP:7] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       +3/+3 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkArakkoa_OG_293()
		{
			// TODO DarkArakkoa_OG_293 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Arakkoa"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Arakkoa"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Arakkoa"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_313] Addled Grizzly - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: After you summon a minion, give it +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AddledGrizzly_OG_313()
		{
			// TODO AddledGrizzly_OG_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Addled Grizzly"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Addled Grizzly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Addled Grizzly"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [OG_047] Feral Rage - COST:3 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give your hero +4 Attack this turn; or Gain 8 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FeralRage_OG_047()
		{
			// TODO FeralRage_OG_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feral Rage"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feral Rage"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [OG_048] Mark of Y'Shaarj - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2.
		//       If it's a Beast, draw
		//       a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkOfYshaarj_OG_048()
		{
			// TODO MarkOfYshaarj_OG_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mark of Y'Shaarj"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of Y'Shaarj"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mark of Y'Shaarj"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [OG_195] Wisps of the Old Gods - COST:7 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Summon seven 1/1 Wisps; or Give your minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WispsOfTheOldGods_OG_195()
		{
			// TODO WispsOfTheOldGods_OG_195 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisps of the Old Gods"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisps of the Old Gods"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisps of the Old Gods"));
		}

	}

	public class HunterOgTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [OG_179] Fiery Bat - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FieryBat_OG_179()
		{
			// TODO FieryBat_OG_179 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fiery Bat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery Bat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiery Bat"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_216] Infested Wolf - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 1/1 Spiders.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InfestedWolf_OG_216()
		{
			// TODO InfestedWolf_OG_216 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infested Wolf"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infested Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Infested Wolf"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_292] Forlorn Stalker - COST:3 [ATK:4/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all <b>Deathrattle</b> minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForlornStalker_OG_292()
		{
			// TODO ForlornStalker_OG_292 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forlorn Stalker"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forlorn Stalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forlorn Stalker"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_308] Giant Sand Worm - COST:8 [ATK:8/HP:8] 
		// - Race: beast, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this attacks and kills a minion, it may attack again.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantSandWorm_OG_308()
		{
			// TODO GiantSandWorm_OG_308 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Sand Worm"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Sand Worm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Sand Worm"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_309] Princess Huhuran - COST:5 [ATK:6/HP:5] 
		// - Race: beast, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrincessHuhuran_OG_309()
		{
			// TODO PrincessHuhuran_OG_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Princess Huhuran"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Princess Huhuran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Princess Huhuran"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_325] Carrion Grub - COST:3 [ATK:2/HP:5] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CarrionGrub_OG_325()
		{
			// TODO CarrionGrub_OG_325 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Carrion Grub"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Carrion Grub"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Carrion Grub"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [OG_045] Infest - COST:3 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Add a random Beast to your hand."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Infest_OG_045()
		{
			// TODO Infest_OG_045 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infest"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Infest"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [OG_061] On the Hunt - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage.
		//       Summon a 1/1 Mastiff. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OnTheHunt_OG_061()
		{
			// TODO OnTheHunt_OG_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("On the Hunt"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("On the Hunt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "On the Hunt"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [OG_211] Call of the Wild - COST:9 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon all three Animal Companions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallOfTheWild_OG_211()
		{
			// TODO CallOfTheWild_OG_211 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call of the Wild"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call of the Wild"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call of the Wild"));
		}

	}

	public class MageOgTest
	{
		// ------------------------------------------ MINION - MAGE
		// [OG_083] Twilight Flamecaller - COST:3 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightFlamecaller_OG_083()
		{
			// TODO TwilightFlamecaller_OG_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Flamecaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Flamecaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Flamecaller"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_085] Demented Frostcaller - COST:4 [ATK:2/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, <b>Freeze</b> a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DementedFrostcaller_OG_085()
		{
			// TODO DementedFrostcaller_OG_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demented Frostcaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demented Frostcaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demented Frostcaller"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_087] Servant of Yogg-Saron - COST:5 [ATK:5/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Cast a random spell that costs (5) or less <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ServantOfYoggSaron_OG_087()
		{
			// TODO ServantOfYoggSaron_OG_087 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Servant of Yogg-Saron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Servant of Yogg-Saron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Servant of Yogg-Saron"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_120] Anomalus - COST:8 [ATK:8/HP:6] 
		// - Race: elemental, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 8 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anomalus_OG_120()
		{
			// TODO Anomalus_OG_120 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anomalus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anomalus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anomalus"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_207] Faceless Summoner - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random 3-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessSummoner_OG_207()
		{
			// TODO FacelessSummoner_OG_207 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Summoner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faceless Summoner"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_303] Cult Sorcerer - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b><b>Spell Damage</b> +1</b>
		//       After you cast a spell,
		//       give your C'Thun +1/+1
		//       <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CultSorcerer_OG_303()
		{
			// TODO CultSorcerer_OG_303 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cult Sorcerer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Sorcerer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cult Sorcerer"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [OG_081] Shatter - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a <b>Frozen</b> minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FROZEN_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shatter_OG_081()
		{
			// TODO Shatter_OG_081 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shatter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shatter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shatter"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [OG_086] Forbidden Flame - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Deal that much damage to a minion. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForbiddenFlame_OG_086()
		{
			// TODO ForbiddenFlame_OG_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Flame"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Flame"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forbidden Flame"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [OG_090] Cabalist's Tome - COST:5 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Add 3 random Mage spells to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CabalistsTome_OG_090()
		{
			// TODO CabalistsTome_OG_090 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cabalist's Tome"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cabalist's Tome"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cabalist's Tome"));
		}

	}

	public class PaladinOgTest
	{
		// --------------------------------------- MINION - PALADIN
		// [OG_006] Vilefin Inquisitor - COST:1 [ATK:1/HP:3] 
		// - Race: murloc, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your Hero Power becomes 'Summon a   1/1 Murloc.'
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VilefinInquisitor_OG_006()
		{
			// TODO VilefinInquisitor_OG_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vilefin Inquisitor"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vilefin Inquisitor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vilefin Inquisitor"));
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_221] Selfless Hero - COST:1 [ATK:2/HP:1] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SelflessHero_OG_221()
		{
			// TODO SelflessHero_OG_221 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Selfless Hero"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Selfless Hero"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Selfless Hero"));
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_229] Ragnaros, Lightlord - COST:8 [ATK:8/HP:8] 
		// - Race: elemental, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 8 Health to a damaged friendly character.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosLightlord_OG_229()
		{
			// TODO RagnarosLightlord_OG_229 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ragnaros, Lightlord"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ragnaros, Lightlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ragnaros, Lightlord"));
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_310] Steward of Darkshire - COST:3 [ATK:3/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a 1-Health minion, give it <b>Divine Shield</b>.
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StewardOfDarkshire_OG_310()
		{
			// TODO StewardOfDarkshire_OG_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Steward of Darkshire"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steward of Darkshire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Steward of Darkshire"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_198] Forbidden Healing - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Restore twice that much Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForbiddenHealing_OG_198()
		{
			// TODO ForbiddenHealing_OG_198 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Healing"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Healing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forbidden Healing"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_223] Divine Strength - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +1/+2.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivineStrength_OG_223()
		{
			// TODO DivineStrength_OG_223 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Divine Strength"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Strength"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Divine Strength"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_273] Stand Against Darkness - COST:5 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Summon five 1/1 Silver Hand Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StandAgainstDarkness_OG_273()
		{
			// TODO StandAgainstDarkness_OG_273 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stand Against Darkness"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stand Against Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stand Against Darkness"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_311] A Light in the Darkness - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a minion.
		//       Give it +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ALightInTheDarkness_OG_311()
		{
			// TODO ALightInTheDarkness_OG_311 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("A Light in the Darkness"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("A Light in the Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "A Light in the Darkness"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [OG_222] Rallying Blade - COST:3 [ATK:3/HP:0] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give +1/+1 to your minions with <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RallyingBlade_OG_222()
		{
			// TODO RallyingBlade_OG_222 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rallying Blade"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rallying Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rallying Blade"));
		}

	}

	public class PriestOgTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [OG_096] Twilight Darkmender - COST:5 [ATK:6/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun  has at least 10 Attack, restore 10 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightDarkmender_OG_096()
		{
			// TODO TwilightDarkmender_OG_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Darkmender"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Darkmender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Darkmender"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_234] Darkshire Alchemist - COST:5 [ATK:4/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 5 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkshireAlchemist_OG_234()
		{
			// TODO DarkshireAlchemist_OG_234 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkshire Alchemist"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkshire Alchemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkshire Alchemist"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_316] Herald Volazj - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 copy of each of your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeraldVolazj_OG_316()
		{
			// TODO HeraldVolazj_OG_316 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Herald Volazj"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Herald Volazj"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Herald Volazj"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_334] Hooded Acolyte - COST:4 [ATK:3/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a character is healed, give your
		//       C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoodedAcolyte_OG_334()
		{
			// TODO HoodedAcolyte_OG_334 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hooded Acolyte"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooded Acolyte"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hooded Acolyte"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_335] Shifting Shade - COST:4 [ATK:4/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Copy a card
		//       from your opponent's deck
		//       _and add it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShiftingShade_OG_335()
		{
			// TODO ShiftingShade_OG_335 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shifting Shade"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shifting Shade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shifting Shade"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_094] Power Word: Tentacles - COST:5 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+6.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerWordTentacles_OG_094()
		{
			// TODO PowerWordTentacles_OG_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power Word: Tentacles"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Tentacles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power Word: Tentacles"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_100] Shadow Word: Horror - COST:4 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy all minions with 2 or less Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowWordHorror_OG_100()
		{
			// TODO ShadowWordHorror_OG_100 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Word: Horror"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Horror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Word: Horror"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_101] Forbidden Shaping - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Summon a random minion that costs that much.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForbiddenShaping_OG_101()
		{
			// TODO ForbiddenShaping_OG_101 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Shaping"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Shaping"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forbidden Shaping"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_104] Embrace the Shadow - COST:2 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: This turn, your healing effects deal damage instead.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmbraceTheShadow_OG_104()
		{
			// TODO EmbraceTheShadow_OG_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Embrace the Shadow"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embrace the Shadow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Embrace the Shadow"));
		}

	}

	public class RogueOgTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [OG_070] Bladed Cultist - COST:1 [ATK:1/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BladedCultist_OG_070()
		{
			// TODO BladedCultist_OG_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bladed Cultist"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladed Cultist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bladed Cultist"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_080] Xaril, Poisoned Mind - COST:4 [ATK:3/HP:2] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Add a random Toxin card to your hand.
		// --------------------------------------------------------
		// Entourage: OG_080d, OG_080e, OG_080f, OG_080c, OG_080b
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void XarilPoisonedMind_OG_080()
		{
			// TODO XarilPoisonedMind_OG_080 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Xaril, Poisoned Mind"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Xaril, Poisoned Mind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Xaril, Poisoned Mind"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_267] Southsea Squidface - COST:4 [ATK:4/HP:4] 
		// - Race: pirate, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your weapon +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SouthseaSquidface_OG_267()
		{
			// TODO SouthseaSquidface_OG_267 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Southsea Squidface"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Squidface"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Southsea Squidface"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_282] Blade of C'Thun - COST:9 [ATK:4/HP:4] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. Add its Attack and Health to_your C'Thun's <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BladeOfCthun_OG_282()
		{
			// TODO BladeOfCthun_OG_282 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blade of C'Thun"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blade of C'Thun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blade of C'Thun"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_291] Shadowcaster - COST:5 [ATK:4/HP:4] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Add a 1/1 copy to_your hand that costs_(1).
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
		public void Shadowcaster_OG_291()
		{
			// TODO Shadowcaster_OG_291 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowcaster"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowcaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowcaster"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_330] Undercity Huckster - COST:2 [ATK:2/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random card to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UndercityHuckster_OG_330()
		{
			// TODO UndercityHuckster_OG_330 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Undercity Huckster"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Undercity Huckster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Undercity Huckster"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [OG_072] Journey Below - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Deathrattle</b> card.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JourneyBelow_OG_072()
		{
			// TODO JourneyBelow_OG_072 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Journey Below"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Journey Below"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Journey Below"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [OG_073] Thistle Tea - COST:6 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card. Add 2 extra copies of it to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThistleTea_OG_073()
		{
			// TODO ThistleTea_OG_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thistle Tea"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thistle Tea"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thistle Tea"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [OG_176] Shadow Strike - COST:3 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage to an undamaged character. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_UNDAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowStrike_OG_176()
		{
			// TODO ShadowStrike_OG_176 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Strike"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Strike"));
		}

	}

	public class ShamanOgTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [OG_024] Flamewreathed Faceless - COST:4 [ATK:7/HP:7] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlamewreathedFaceless_OG_024()
		{
			// TODO FlamewreathedFaceless_OG_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flamewreathed Faceless"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamewreathed Faceless"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flamewreathed Faceless"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_026] Eternal Sentinel - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Unlock your <b>Overloaded</b> Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EternalSentinel_OG_026()
		{
			// TODO EternalSentinel_OG_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eternal Sentinel"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eternal Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eternal Sentinel"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_028] Thing from Below - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Costs (1) less for each
		//       Totem you've summoned
		//       this game.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThingFromBelow_OG_028()
		{
			// TODO ThingFromBelow_OG_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thing from Below"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thing from Below"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thing from Below"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_209] Hallazeal the Ascended - COST:5 [ATK:4/HP:6] 
		// - Race: elemental, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your spells deal damage, restore that much Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HallazealTheAscended_OG_209()
		{
			// TODO HallazealTheAscended_OG_209 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hallazeal the Ascended"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hallazeal the Ascended"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hallazeal the Ascended"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_328] Master of Evolution - COST:4 [ATK:4/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform a friendly minion into a random one that costs (1) more.
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
		public void MasterOfEvolution_OG_328()
		{
			// TODO MasterOfEvolution_OG_328 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master of Evolution"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master of Evolution"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master of Evolution"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [OG_023] Primal Fusion - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +1/+1 for each of your Totems.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalFusion_OG_023()
		{
			// TODO PrimalFusion_OG_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primal Fusion"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primal Fusion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primal Fusion"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [OG_027] Evolve - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform your minions into random minions that cost (1) more.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Evolve_OG_027()
		{
			// TODO Evolve_OG_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evolve"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evolve"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evolve"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [OG_206] Stormcrack - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. <b>Overload:</b> (1) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stormcrack_OG_206()
		{
			// TODO Stormcrack_OG_206 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormcrack"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormcrack"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormcrack"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [OG_031] Hammer of Twilight - COST:5 [ATK:4/HP:0] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 4/2 Elemental.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HammerOfTwilight_OG_031()
		{
			// TODO HammerOfTwilight_OG_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hammer of Twilight"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hammer of Twilight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hammer of Twilight"));
		}

	}

	public class WarlockOgTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [OG_109] Darkshire Librarian - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b>
		//       Discard a random card. <b>Deathrattle:</b>
		//       Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// - 890 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkshireLibrarian_OG_109()
		{
			// TODO DarkshireLibrarian_OG_109 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkshire Librarian"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkshire Librarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkshire Librarian"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_113] Darkshire Councilman - COST:3 [ATK:1/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]After you summon a minion,
		//        gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkshireCouncilman_OG_113()
		{
			// TODO DarkshireCouncilman_OG_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkshire Councilman"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkshire Councilman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkshire Councilman"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_121] Cho'gall - COST:7 [ATK:7/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> The next spell you cast this turn costs Health instead of Mana.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chogall_OG_121()
		{
			// TODO Chogall_OG_121 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cho'gall"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cho'gall"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cho'gall"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_241] Possessed Villager - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 Shadowbeast.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PossessedVillager_OG_241()
		{
			// TODO PossessedVillager_OG_241 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Possessed Villager"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Possessed Villager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Possessed Villager"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_302] Usher of Souls - COST:5 [ATK:5/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a friendly minion dies, give your C'Thun +1/+1
		//       <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UsherOfSouls_OG_302()
		{
			// TODO UsherOfSouls_OG_302 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Usher of Souls"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Usher of Souls"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Usher of Souls"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_114] Forbidden Ritual - COST:0 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Spend all your Mana. Summon that many 1/1 Tentacles.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForbiddenRitual_OG_114()
		{
			// TODO ForbiddenRitual_OG_114 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Ritual"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Ritual"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forbidden Ritual"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_116] Spreading Madness - COST:3 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $9 damage randomly split among ALL characters. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpreadingMadness_OG_116()
		{
			// TODO SpreadingMadness_OG_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spreading Madness"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spreading Madness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spreading Madness"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_118] Renounce Darkness - COST:2 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Replace your Hero Power and Warlock cards with another class's. The cards cost (1) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RenounceDarkness_OG_118()
		{
			// TODO RenounceDarkness_OG_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Renounce Darkness"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Renounce Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Renounce Darkness"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_239] DOOM! - COST:10 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions. Draw a card for each.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doom_OG_239()
		{
			// TODO Doom_OG_239 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("DOOM!"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("DOOM!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "DOOM!"));
		}

	}

	public class WarriorOgTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [OG_149] Ravaging Ghoul - COST:3 [ATK:3/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavagingGhoul_OG_149()
		{
			// TODO RavagingGhoul_OG_149 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravaging Ghoul"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ravaging Ghoul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravaging Ghoul"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_218] Bloodhoof Brave - COST:4 [ATK:2/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +3 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodhoofBrave_OG_218()
		{
			// TODO BloodhoofBrave_OG_218 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodhoof Brave"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodhoof Brave"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodhoof Brave"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_220] Malkorok - COST:7 [ATK:6/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a random weapon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Malkorok_OG_220()
		{
			// TODO Malkorok_OG_220 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malkorok"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malkorok"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malkorok"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_301] Ancient Shieldbearer - COST:7 [ATK:6/HP:6] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain 10 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientShieldbearer_OG_301()
		{
			// TODO AncientShieldbearer_OG_301 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Shieldbearer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Shieldbearer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Shieldbearer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_312] N'Zoth's First Mate - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 1/3 Rusty Hook.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NzothsFirstMate_OG_312()
		{
			// TODO NzothsFirstMate_OG_312 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("N'Zoth's First Mate"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("N'Zoth's First Mate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "N'Zoth's First Mate"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_315] Bloodsail Cultist - COST:3 [ATK:3/HP:4] 
		// - Race: pirate, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control another Pirate, give your weapon +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodsailCultist_OG_315()
		{
			// TODO BloodsailCultist_OG_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsail Cultist"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Cultist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodsail Cultist"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [OG_276] Blood Warriors - COST:3 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Add a copy of each damaged friendly minion to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodWarriors_OG_276()
		{
			// TODO BloodWarriors_OG_276 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Warriors"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Warriors"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Warriors"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [OG_314] Blood To Ichor - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion. If it survives, summon a 2/2 Slime. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodToIchor_OG_314()
		{
			// TODO BloodToIchor_OG_314 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood To Ichor"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood To Ichor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood To Ichor"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [OG_033] Tentacles for Arms - COST:5 [ATK:2/HP:0] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return this to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TentaclesForArms_OG_033()
		{
			// TODO TentaclesForArms_OG_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tentacles for Arms"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tentacles for Arms"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tentacles for Arms"));
		}

	}

	public class NeutralOgTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [OG_034] Silithid Swarmer - COST:3 [ATK:3/HP:5] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Can only attack if your hero attacked this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilithidSwarmer_OG_034()
		{
			// TODO SilithidSwarmer_OG_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silithid Swarmer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silithid Swarmer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silithid Swarmer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_042] Y'Shaarj, Rage Unbound - COST:10 [ATK:10/HP:10] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, put a minion from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YshaarjRageUnbound_OG_042()
		{
			// TODO YshaarjRageUnbound_OG_042 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Y'Shaarj, Rage Unbound"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Y'Shaarj, Rage Unbound"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Y'Shaarj, Rage Unbound"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_082] Evolved Kobold - COST:4 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvolvedKobold_OG_082()
		{
			// TODO EvolvedKobold_OG_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evolved Kobold"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evolved Kobold"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evolved Kobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_102] Darkspeaker - COST:5 [ATK:3/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap stats with a friendly minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Darkspeaker_OG_102()
		{
			// TODO Darkspeaker_OG_102 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkspeaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkspeaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkspeaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_122] Mukla, Tyrant of the Vale - COST:6 [ATK:5/HP:5] 
		// - Race: beast, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuklaTyrantOfTheVale_OG_122()
		{
			// TODO MuklaTyrantOfTheVale_OG_122 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mukla, Tyrant of the Vale"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mukla, Tyrant of the Vale"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mukla, Tyrant of the Vale"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_123] Shifter Zerus - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a random minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShifterZerus_OG_123()
		{
			// TODO ShifterZerus_OG_123 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shifter Zerus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shifter Zerus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shifter Zerus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_131] Twin Emperor Vek'lor - COST:7 [ATK:4/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b><b>Taunt</b>
		//       Battlecry:</b> If your C'Thun has
		//       at least 10 Attack, summon
		//       another Emperor.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwinEmperorVeklor_OG_131()
		{
			// TODO TwinEmperorVeklor_OG_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twin Emperor Vek'lor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twin Emperor Vek'lor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twin Emperor Vek'lor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_133] N'Zoth, the Corruptor - COST:10 [ATK:5/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon your <b>Deathrattle</b> minions that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NzothTheCorruptor_OG_133()
		{
			// TODO NzothTheCorruptor_OG_133 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("N'Zoth, the Corruptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("N'Zoth, the Corruptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "N'Zoth, the Corruptor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_134] Yogg-Saron, Hope's End - COST:10 [ATK:7/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Cast a random spell for each spell you've cast this game <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YoggSaronHopesEnd_OG_134()
		{
			// TODO YoggSaronHopesEnd_OG_134 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Yogg-Saron, Hope's End"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Yogg-Saron, Hope's End"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Yogg-Saron, Hope's End"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_138] Nerubian Prophet - COST:6 [ATK:4/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, reduce this card's
		//       Cost by (1).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NerubianProphet_OG_138()
		{
			// TODO NerubianProphet_OG_138 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nerubian Prophet"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Prophet"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nerubian Prophet"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_141] Faceless Behemoth - COST:10 [ATK:10/HP:10] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessBehemoth_OG_141()
		{
			// TODO FacelessBehemoth_OG_141 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Behemoth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Behemoth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faceless Behemoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_142] Eldritch Horror - COST:8 [ATK:6/HP:10] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EldritchHorror_OG_142()
		{
			// TODO EldritchHorror_OG_142 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eldritch Horror"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eldritch Horror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eldritch Horror"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_145] Psych-o-Tron - COST:5 [ATK:3/HP:4] 
		// - Race: mechanical, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PsychOTron_OG_145()
		{
			// TODO PsychOTron_OG_145 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psych-o-Tron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Psych-o-Tron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Psych-o-Tron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_147] Corrupted Healbot - COST:5 [ATK:6/HP:6] 
		// - Race: mechanical, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 8 Health to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptedHealbot_OG_147()
		{
			// TODO CorruptedHealbot_OG_147 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrupted Healbot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrupted Healbot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corrupted Healbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_150] Aberrant Berserker - COST:4 [ATK:3/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Has +2 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AberrantBerserker_OG_150()
		{
			// TODO AberrantBerserker_OG_150 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aberrant Berserker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aberrant Berserker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aberrant Berserker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_151] Tentacle of N'Zoth - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TentacleOfNzoth_OG_151()
		{
			// TODO TentacleOfNzoth_OG_151 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tentacle of N'Zoth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tentacle of N'Zoth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tentacle of N'Zoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_152] Grotesque Dragonhawk - COST:7 [ATK:5/HP:5] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrotesqueDragonhawk_OG_152()
		{
			// TODO GrotesqueDragonhawk_OG_152 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grotesque Dragonhawk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grotesque Dragonhawk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grotesque Dragonhawk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_153] Bog Creeper - COST:7 [ATK:6/HP:8] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BogCreeper_OG_153()
		{
			// TODO BogCreeper_OG_153 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bog Creeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bog Creeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bog Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_156] Bilefin Tidehunter - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 Ooze with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BilefinTidehunter_OG_156()
		{
			// TODO BilefinTidehunter_OG_156 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bilefin Tidehunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bilefin Tidehunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bilefin Tidehunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_158] Zealous Initiate - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZealousInitiate_OG_158()
		{
			// TODO ZealousInitiate_OG_158 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zealous Initiate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zealous Initiate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zealous Initiate"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_161] Corrupted Seer - COST:6 [ATK:2/HP:3] 
		// - Race: murloc, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage to all non-Murloc minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptedSeer_OG_161()
		{
			// TODO CorruptedSeer_OG_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrupted Seer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrupted Seer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corrupted Seer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_162] Disciple of C'Thun - COST:3 [ATK:2/HP:1] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage. Give your C'Thun +2/+2 <i>(wherever it is)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DiscipleOfCthun_OG_162()
		{
			// TODO DiscipleOfCthun_OG_162 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Disciple of C'Thun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Disciple of C'Thun"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_173] Blood of The Ancient One - COST:9 [ATK:9/HP:9] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: If you control two of these
		//       at the end of your turn, merge them into 'The Ancient One'.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodOfTheAncientOne_OG_173()
		{
			// TODO BloodOfTheAncientOne_OG_173 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood of The Ancient One"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood of The Ancient One"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood of The Ancient One"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_174] Faceless Shambler - COST:4 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Copy a friendly minion's Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessShambler_OG_174()
		{
			// TODO FacelessShambler_OG_174 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Shambler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Shambler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faceless Shambler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_200] Validated Doomsayer - COST:5 [ATK:0/HP:7] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, set this minion's Attack to 7.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValidatedDoomsayer_OG_200()
		{
			// TODO ValidatedDoomsayer_OG_200 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Validated Doomsayer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Validated Doomsayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Validated Doomsayer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_247] Twisted Worgen - COST:2 [ATK:3/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwistedWorgen_OG_247()
		{
			// TODO TwistedWorgen_OG_247 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twisted Worgen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisted Worgen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twisted Worgen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_248] Am'gam Rager - COST:3 [ATK:1/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AmgamRager_OG_248()
		{
			// TODO AmgamRager_OG_248 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Am'gam Rager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Am'gam Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Am'gam Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_249] Infested Tauren - COST:4 [ATK:2/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Summon a 2/2 Slime.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InfestedTauren_OG_249()
		{
			// TODO InfestedTauren_OG_249 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infested Tauren"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infested Tauren"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Infested Tauren"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_254] Eater of Secrets - COST:4 [ATK:2/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>. Gain +1/+1 for each.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EaterOfSecrets_OG_254()
		{
			// TODO EaterOfSecrets_OG_254 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eater of Secrets"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eater of Secrets"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eater of Secrets"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_255] Doomcaller - COST:8 [ATK:7/HP:9] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i> If it's dead, shuffle it into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doomcaller_OG_255()
		{
			// TODO Doomcaller_OG_255 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomcaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomcaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomcaller"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_256] Spawn of N'Zoth - COST:3 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpawnOfNzoth_OG_256()
		{
			// TODO SpawnOfNzoth_OG_256 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spawn of N'Zoth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spawn of N'Zoth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spawn of N'Zoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_271] Scaled Nightmare - COST:6 [ATK:2/HP:8] 
		// - Race: dragon, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, double this minion's Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScaledNightmare_OG_271()
		{
			// TODO ScaledNightmare_OG_271 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scaled Nightmare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scaled Nightmare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scaled Nightmare"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_272] Twilight Summoner - COST:4 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 5/5 Faceless Destroyer.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightSummoner_OG_272()
		{
			// TODO TwilightSummoner_OG_272 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Summoner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Summoner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_280] C'Thun - COST:10 [ATK:6/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cthun_OG_280()
		{
			// TODO Cthun_OG_280 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("C'Thun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "C'Thun"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_281] Beckoner of Evil - COST:2 [ATK:2/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeckonerOfEvil_OG_281()
		{
			// TODO BeckonerOfEvil_OG_281 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beckoner of Evil"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beckoner of Evil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beckoner of Evil"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_283] C'Thun's Chosen - COST:4 [ATK:4/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CthunsChosen_OG_283()
		{
			// TODO CthunsChosen_OG_283 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("C'Thun's Chosen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun's Chosen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "C'Thun's Chosen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_284] Twilight Geomancer - COST:2 [ATK:1/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       <b>Taunt</b> <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightGeomancer_OG_284()
		{
			// TODO TwilightGeomancer_OG_284 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Geomancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Geomancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Geomancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_286] Twilight Elder - COST:3 [ATK:3/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give your C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightElder_OG_286()
		{
			// TODO TwilightElder_OG_286 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Elder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Elder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Elder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_290] Ancient Harbinger - COST:6 [ATK:4/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, put a 10-Cost minion from your deck into your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientHarbinger_OG_290()
		{
			// TODO AncientHarbinger_OG_290 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Harbinger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Harbinger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Harbinger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_295] Cult Apothecary - COST:5 [ATK:4/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For each enemy minion, restore 2 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CultApothecary_OG_295()
		{
			// TODO CultApothecary_OG_295 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cult Apothecary"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Apothecary"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cult Apothecary"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_300] The Boogeymonster - COST:8 [ATK:6/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this attacks and kills a minion, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheBoogeymonster_OG_300()
		{
			// TODO TheBoogeymonster_OG_300 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Boogeymonster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Boogeymonster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Boogeymonster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_317] Deathwing, Dragonlord - COST:10 [ATK:12/HP:12] 
		// - Race: dragon, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Put all Dragons from your hand into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathwingDragonlord_OG_317()
		{
			// TODO DeathwingDragonlord_OG_317 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathwing, Dragonlord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathwing, Dragonlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathwing, Dragonlord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_318] Hogger, Doom of Elwynn - COST:7 [ATK:6/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 2/2 Gnoll with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoggerDoomOfElwynn_OG_318()
		{
			// TODO HoggerDoomOfElwynn_OG_318 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hogger, Doom of Elwynn"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hogger, Doom of Elwynn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hogger, Doom of Elwynn"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_320] Midnight Drake - COST:4 [ATK:1/HP:4] 
		// - Race: dragon, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1 Attack for each other card
		//       in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MidnightDrake_OG_320()
		{
			// TODO MidnightDrake_OG_320 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Midnight Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Midnight Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Midnight Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_321] Crazed Worshipper - COST:5 [ATK:3/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt.</b> Whenever this minion takes damage, give your C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrazedWorshipper_OG_321()
		{
			// TODO CrazedWorshipper_OG_321 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crazed Worshipper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crazed Worshipper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crazed Worshipper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_322] Blackwater Pirate - COST:4 [ATK:2/HP:5] 
		// - Race: pirate, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Your weapons cost (2) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackwaterPirate_OG_322()
		{
			// TODO BlackwaterPirate_OG_322 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwater Pirate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwater Pirate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwater Pirate"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_323] Polluted Hoarder - COST:4 [ATK:4/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PollutedHoarder_OG_323()
		{
			// TODO PollutedHoarder_OG_323 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Polluted Hoarder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polluted Hoarder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Polluted Hoarder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_326] Duskboar - COST:2 [ATK:4/HP:1] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Duskboar_OG_326()
		{
			// TODO Duskboar_OG_326 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskboar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskboar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskboar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_327] Squirming Tentacle - COST:3 [ATK:2/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SquirmingTentacle_OG_327()
		{
			// TODO SquirmingTentacle_OG_327 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Squirming Tentacle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Squirming Tentacle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Squirming Tentacle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_337] Cyclopian Horror - COST:4 [ATK:3/HP:3] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Gain      +1 Health for each enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CyclopianHorror_OG_337()
		{
			// TODO CyclopianHorror_OG_337 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cyclopian Horror"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cyclopian Horror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cyclopian Horror"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_338] Nat, the Darkfisher - COST:2 [ATK:2/HP:4] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your opponent's turn, they have a 50% chance to draw an extra card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NatTheDarkfisher_OG_338()
		{
			// TODO NatTheDarkfisher_OG_338 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nat, the Darkfisher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nat, the Darkfisher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nat, the Darkfisher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_339] Skeram Cultist - COST:6 [ATK:7/HP:6] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkeramCultist_OG_339()
		{
			// TODO SkeramCultist_OG_339 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skeram Cultist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skeram Cultist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skeram Cultist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_340] Soggoth the Slitherer - COST:9 [ATK:5/HP:9] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoggothTheSlitherer_OG_340()
		{
			// TODO SoggothTheSlitherer_OG_340 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soggoth the Slitherer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soggoth the Slitherer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soggoth the Slitherer"));
		}

	}

}
