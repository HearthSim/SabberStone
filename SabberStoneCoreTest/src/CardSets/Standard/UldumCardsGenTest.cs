using Xunit;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroPowersUldumTest
	{
		// ------------------------------------- HERO_POWER - DRUID
		// [ULD_131p] Ossirian Tear (*) - COST:0 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your <b>Choose One</b> cards have both effects combined.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OssirianTear_ULD_131p()
		{
			// TODO OssirianTear_ULD_131p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ossirian Tear"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ossirian Tear"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Ossirian Tear");
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [ULD_140p] Tome of Origination (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card.
		//       It costs (0).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TomeOfOrigination_ULD_140p()
		{
			// TODO TomeOfOrigination_ULD_140p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tome of Origination"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tome of Origination"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Tome of Origination");
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [ULD_155p] Ramkahen Roar (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your minions +2_Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RamkahenRoar_ULD_155p()
		{
			// TODO RamkahenRoar_ULD_155p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ramkahen Roar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ramkahen Roar"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Ramkahen Roar");
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [ULD_291p] Heart of Vir'naal (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Your <b>Battlecries</b> trigger twice this turn.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeartOfVirnaal_ULD_291p()
		{
			// TODO HeartOfVirnaal_ULD_291p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heart of Vir'naal"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heart of Vir'naal"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Heart of Vir'naal");
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [ULD_326p] Ancient Blades (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Equip a 3/2 Blade with
		//        <b>Immune</b> while attacking.
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientBlades_ULD_326p()
		{
			// TODO AncientBlades_ULD_326p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Blades"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Blades"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Ancient Blades");
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [ULD_431p] Emperor Wraps (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 2/2 copy
		//       of a friendly minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmperorWraps_ULD_431p()
		{
			// TODO EmperorWraps_ULD_431p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emperor Wraps"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Wraps"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Emperor Wraps");
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [ULD_433p] Ascendant Scroll (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random Mage
		//       spell to your hand.
		//       It costs (2) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HAND_NOT_FULL = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AscendantScroll_ULD_433p()
		{
			// TODO AscendantScroll_ULD_433p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ascendant Scroll"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ascendant Scroll"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Ascendant Scroll");
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [ULD_711p3] Anraphet's Core (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 4/3 Golem.
		//       After your hero attacks,
		//       refresh this.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnraphetsCore_ULD_711p3()
		{
			// TODO AnraphetsCore_ULD_711p3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anraphet's Core"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anraphet's Core"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Anraphet's Core");
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [ULD_724p] Obelisk's Eye (*) - COST:2 
		// - Set: uldum, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #3 Health.
		//       If you target a minion, also give it +3/+3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObelisksEye_ULD_724p()
		{
			// TODO ObelisksEye_ULD_724p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Obelisk's Eye"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obelisk's Eye"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Obelisk's Eye");
		}

	}

	public class DruidUldumTest
	{
		// ----------------------------------------- MINION - DRUID
		// [ULD_133] Crystal Merchant - COST:2 [ATK:1/HP:4] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: If you have any unspent Mana at the end of your turn, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalMerchant_ULD_133()
		{
			// TODO CrystalMerchant_ULD_133 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystal Merchant"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystal Merchant"));
			//Minion testCard = game.ProcessCard<Minion>("Crystal Merchant");
		}

		// ----------------------------------------- MINION - DRUID
		// [ULD_137] Garden Gnome - COST:4 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       a spell that costs (5) or more,
		//       summon two 2/2 Treants.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GardenGnome_ULD_137()
		{
			// TODO GardenGnome_ULD_137 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garden Gnome"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garden Gnome"));
			//Minion testCard = game.ProcessCard<Minion>("Garden Gnome");
		}

		// ----------------------------------------- MINION - DRUID
		// [ULD_138] Anubisath Defender - COST:5 [ATK:3/HP:5] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. Costs (0) if you've cast a spell that costs (5) or more this turn.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnubisathDefender_ULD_138()
		{
			// TODO AnubisathDefender_ULD_138 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anubisath Defender"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anubisath Defender"));
			//Minion testCard = game.ProcessCard<Minion>("Anubisath Defender");
		}

		// ----------------------------------------- MINION - DRUID
		// [ULD_139] Elise the Enlightened - COST:5 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, duplicate your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliseTheEnlightened_ULD_139()
		{
			// TODO EliseTheEnlightened_ULD_139 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elise the Enlightened"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elise the Enlightened"));
			//Minion testCard = game.ProcessCard<Minion>("Elise the Enlightened");
		}

		// ----------------------------------------- MINION - DRUID
		// [ULD_292] Oasis Surger - COST:5 [ATK:3/HP:3] 
		// - Race: elemental, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Choose One -</b> Gain +2/+2; or Summon a copy of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OasisSurger_ULD_292()
		{
			// TODO OasisSurger_ULD_292 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Oasis Surger"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Surger"));
			//Minion testCard = game.ProcessCard<Minion>("Oasis Surger");
		}

		// ------------------------------------------ SPELL - DRUID
		// [ULD_131] Untapped Potential - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> End 4 turns
		//       with any unspent Mana.
		//       <b>Reward:</b> Ossirian Tear.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 4
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 53499
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UntappedPotential_ULD_131()
		{
			// TODO UntappedPotential_ULD_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Untapped Potential"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Untapped Potential"));
			//Spell testCard = game.ProcessCard<Spell>("Untapped Potential");
		}

		// ------------------------------------------ SPELL - DRUID
		// [ULD_134] BEEEES!!! - COST:3 [ATK:1/HP:4] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Choose a minion.
		//       Summon four 1/1 Bees
		//       that attack it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Beeees_ULD_134()
		{
			// TODO Beeees_ULD_134 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("BEEEES!!!"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("BEEEES!!!"));
			//Spell testCard = game.ProcessCard<Spell>("BEEEES!!!");
		}

		// ------------------------------------------ SPELL - DRUID
		// [ULD_135] Hidden Oasis - COST:6 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One</b> - Summon a 6/6 Ancient with <b>Taunt</b>; or Restore #12 Health.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HiddenOasis_ULD_135()
		{
			// TODO HiddenOasis_ULD_135 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hidden Oasis"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hidden Oasis"));
			//Spell testCard = game.ProcessCard<Spell>("Hidden Oasis");
		}

		// ------------------------------------------ SPELL - DRUID
		// [ULD_136] Worthy Expedition - COST:1 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Choose One</b> card.
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WorthyExpedition_ULD_136()
		{
			// TODO WorthyExpedition_ULD_136 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Worthy Expedition"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worthy Expedition"));
			//Spell testCard = game.ProcessCard<Spell>("Worthy Expedition");
		}

		// ------------------------------------------ SPELL - DRUID
		// [ULD_273] Overflow - COST:7 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #5 Health
		//       to all characters.
		//       Draw 5 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Overflow_ULD_273()
		{
			// TODO Overflow_ULD_273 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Overflow"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Overflow"));
			//Spell testCard = game.ProcessCard<Spell>("Overflow");
		}

	}

	public class HunterUldumTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [ULD_151] Ramkahen Wildtamer - COST:3 [ATK:4/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Copy a random Beast in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RamkahenWildtamer_ULD_151()
		{
			// TODO RamkahenWildtamer_ULD_151 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ramkahen Wildtamer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ramkahen Wildtamer"));
			//Minion testCard = game.ProcessCard<Minion>("Ramkahen Wildtamer");
		}

		// ---------------------------------------- MINION - HUNTER
		// [ULD_154] Hyena Alpha - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you control
		//       a <b>Secret</b>, summon two
		//       2/2 Hyenas.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HyenaAlpha_ULD_154()
		{
			// TODO HyenaAlpha_ULD_154 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hyena Alpha"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hyena Alpha"));
			//Minion testCard = game.ProcessCard<Minion>("Hyena Alpha");
		}

		// ---------------------------------------- MINION - HUNTER
		// [ULD_156] Dinotamer Brann - COST:7 [ATK:2/HP:4] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, summon King Krush.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DinotamerBrann_ULD_156()
		{
			// TODO DinotamerBrann_ULD_156 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dinotamer Brann"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dinotamer Brann"));
			//Minion testCard = game.ProcessCard<Minion>("Dinotamer Brann");
		}

		// ---------------------------------------- MINION - HUNTER
		// [ULD_212] Wild Bloodstinger - COST:6 [ATK:6/HP:9] 
		// - Race: beast, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a minion from your opponent's hand. Attack it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildBloodstinger_ULD_212()
		{
			// TODO WildBloodstinger_ULD_212 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wild Bloodstinger"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Bloodstinger"));
			//Minion testCard = game.ProcessCard<Minion>("Wild Bloodstinger");
		}

		// ---------------------------------------- MINION - HUNTER
		// [ULD_410] Scarlet Webweaver - COST:6 [ATK:5/HP:5] 
		// - Race: beast, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reduce the Cost of a random Beast in your_hand by (5).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScarletWebweaver_ULD_410()
		{
			// TODO ScarletWebweaver_ULD_410 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scarlet Webweaver"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scarlet Webweaver"));
			//Minion testCard = game.ProcessCard<Minion>("Scarlet Webweaver");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ULD_152] Pressure Plate - COST:2 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent casts a spell, destroy a random enemy_minion.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PressurePlate_ULD_152()
		{
			// TODO PressurePlate_ULD_152 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pressure Plate"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pressure Plate"));
			//Spell testCard = game.ProcessCard<Spell>("Pressure Plate");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ULD_155] Unseal the Vault - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Summon 20_minions.
		//       <b>Reward:</b> Ramkahen Roar.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 20
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 53925
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnsealTheVault_ULD_155()
		{
			// TODO UnsealTheVault_ULD_155 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unseal the Vault"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unseal the Vault"));
			//Spell testCard = game.ProcessCard<Spell>("Unseal the Vault");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ULD_429] Hunter's Pack - COST:3 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Add a random Hunter Beast, <b>Secret</b>, and weapon to your_hand.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HuntersPack_ULD_429()
		{
			// TODO HuntersPack_ULD_429 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hunter's Pack"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Pack"));
			//Spell testCard = game.ProcessCard<Spell>("Hunter's Pack");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ULD_713] Swarm of Locusts - COST:6 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon seven 1/1 Locusts with <b>Rush</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwarmOfLocusts_ULD_713()
		{
			// TODO SwarmOfLocusts_ULD_713 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swarm of Locusts"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swarm of Locusts"));
			//Spell testCard = game.ProcessCard<Spell>("Swarm of Locusts");
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [ULD_430] Desert Spear - COST:3 [ATK:1/HP:0] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: After your hero attacks, summon a 1/1 Locust with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesertSpear_ULD_430()
		{
			// TODO DesertSpear_ULD_430 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desert Spear"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desert Spear"));
			//Weapon testCard = game.ProcessCard<Weapon>("Desert Spear");
		}

	}

	public class MageUldumTest
	{
		// ------------------------------------------ MINION - MAGE
		// [ULD_236] Tortollan Pilgrim - COST:8 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry</b>: <b>Discover</b> a copy of
		//       a spell in your deck and cast
		//       it with random targets.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TortollanPilgrim_ULD_236()
		{
			// TODO TortollanPilgrim_ULD_236 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tortollan Pilgrim"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tortollan Pilgrim"));
			//Minion testCard = game.ProcessCard<Minion>("Tortollan Pilgrim");
		}

		// ------------------------------------------ MINION - MAGE
		// [ULD_238] Reno the Relicologist - COST:6 [ATK:4/HP:6] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, deal 10 damage randomly split among all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RenoTheRelicologist_ULD_238()
		{
			// TODO RenoTheRelicologist_ULD_238 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reno the Relicologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reno the Relicologist"));
			//Minion testCard = game.ProcessCard<Minion>("Reno the Relicologist");
		}

		// ------------------------------------------ MINION - MAGE
		// [ULD_240] Arcane Flakmage - COST:2 [ATK:3/HP:2] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: After you play a <b>Secret</b>, deal 2 damage to all enemy minions.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneFlakmage_ULD_240()
		{
			// TODO ArcaneFlakmage_ULD_240 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Flakmage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Flakmage"));
			//Minion testCard = game.ProcessCard<Minion>("Arcane Flakmage");
		}

		// ------------------------------------------ MINION - MAGE
		// [ULD_293] Cloud Prince - COST:5 [ATK:4/HP:4] 
		// - Race: elemental, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 6 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CloudPrince_ULD_293()
		{
			// TODO CloudPrince_ULD_293 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cloud Prince"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cloud Prince"));
			//Minion testCard = game.ProcessCard<Minion>("Cloud Prince");
		}

		// ------------------------------------------ MINION - MAGE
		// [ULD_329] Dune Sculptor - COST:3 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you cast a spell,
		//       add a random Mage
		//       minion to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DuneSculptor_ULD_329()
		{
			// TODO DuneSculptor_ULD_329 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dune Sculptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dune Sculptor"));
			//Minion testCard = game.ProcessCard<Minion>("Dune Sculptor");
		}

		// ------------------------------------------ MINION - MAGE
		// [ULD_435] Naga Sand Witch - COST:5 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Change the Cost
		//       of spells in your hand to (5).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NagaSandWitch_ULD_435()
		{
			// TODO NagaSandWitch_ULD_435 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Naga Sand Witch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Sand Witch"));
			//Minion testCard = game.ProcessCard<Minion>("Naga Sand Witch");
		}

		// ------------------------------------------- SPELL - MAGE
		// [ULD_216] Puzzle Box of Yogg-Saron - COST:10 
		// - Fac: neutral, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Cast 10 random spells <i>(targets chosen randomly).</i>
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PuzzleBoxOfYoggSaron_ULD_216()
		{
			// TODO PuzzleBoxOfYoggSaron_ULD_216 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Puzzle Box of Yogg-Saron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Puzzle Box of Yogg-Saron"));
			//Spell testCard = game.ProcessCard<Spell>("Puzzle Box of Yogg-Saron");
		}

		// ------------------------------------------- SPELL - MAGE
		// [ULD_239] Flame Ward - COST:3 
		// - Fac: neutral, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After a minion attacks your hero, deal $3 damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameWard_ULD_239()
		{
			// TODO FlameWard_ULD_239 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flame Ward"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flame Ward"));
			//Spell testCard = game.ProcessCard<Spell>("Flame Ward");
		}

		// ------------------------------------------- SPELL - MAGE
		// [ULD_433] Raid the Sky Temple - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Cast 10 spells.
		//       <b>Reward: </b>Ascendant Scroll.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 10
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 53946
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaidTheSkyTemple_ULD_433()
		{
			// TODO RaidTheSkyTemple_ULD_433 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raid the Sky Temple"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raid the Sky Temple"));
			//Spell testCard = game.ProcessCard<Spell>("Raid the Sky Temple");
		}

		// ------------------------------------------- SPELL - MAGE
		// [ULD_726] Ancient Mysteries - COST:2 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Draw a <b>Secret</b> from your deck. It costs (0).
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientMysteries_ULD_726()
		{
			// TODO AncientMysteries_ULD_726 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Mysteries"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Mysteries"));
			//Spell testCard = game.ProcessCard<Spell>("Ancient Mysteries");
		}

	}

	public class PaladinUldumTest
	{
		// --------------------------------------- MINION - PALADIN
		// [ULD_145] Brazen Zealot - COST:1 [ATK:2/HP:1] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a minion, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrazenZealot_ULD_145()
		{
			// TODO BrazenZealot_ULD_145 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brazen Zealot"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brazen Zealot"));
			//Minion testCard = game.ProcessCard<Minion>("Brazen Zealot");
		}

		// --------------------------------------- MINION - PALADIN
		// [ULD_207] Ancestral Guardian - COST:4 [ATK:4/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestralGuardian_ULD_207()
		{
			// TODO AncestralGuardian_ULD_207 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancestral Guardian"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Guardian"));
			//Minion testCard = game.ProcessCard<Minion>("Ancestral Guardian");
		}

		// --------------------------------------- MINION - PALADIN
		// [ULD_217] Micro Mummy - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Reborn</b>
		//       At the end of your turn, give
		//       another random friendly
		//       minion +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MicroMummy_ULD_217()
		{
			// TODO MicroMummy_ULD_217 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Micro Mummy"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Micro Mummy"));
			//Minion testCard = game.ProcessCard<Minion>("Micro Mummy");
		}

		// --------------------------------------- MINION - PALADIN
		// [ULD_438] Salhet's Pride - COST:3 [ATK:3/HP:1] 
		// - Race: beast, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw two
		//       1-Health minions from your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SalhetsPride_ULD_438()
		{
			// TODO SalhetsPride_ULD_438 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Salhet's Pride"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Salhet's Pride"));
			//Minion testCard = game.ProcessCard<Minion>("Salhet's Pride");
		}

		// --------------------------------------- MINION - PALADIN
		// [ULD_439] Sandwasp Queen - COST:2 [ATK:3/HP:1] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add two 2/1 Sandwasps to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SandwaspQueen_ULD_439()
		{
			// TODO SandwaspQueen_ULD_439 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sandwasp Queen"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sandwasp Queen"));
			//Minion testCard = game.ProcessCard<Minion>("Sandwasp Queen");
		}

		// --------------------------------------- MINION - PALADIN
		// [ULD_500] Sir Finley of the Sands - COST:2 [ATK:2/HP:3] 
		// - Race: murloc, Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck has
		//       no duplicates, <b>Discover</b> an
		//       upgraded Hero Power.
		// --------------------------------------------------------
		// Entourage: AT_132_DRUID, AT_132_HUNTER, AT_132_MAGE, AT_132_PALADIN, AT_132_PRIEST, AT_132_SHAMAN, AT_132_ROGUE, AT_132_WARLOCK, AT_132_WARRIOR
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SirFinleyOfTheSands_ULD_500()
		{
			// TODO SirFinleyOfTheSands_ULD_500 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sir Finley of the Sands"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sir Finley of the Sands"));
			//Minion testCard = game.ProcessCard<Minion>("Sir Finley of the Sands");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ULD_143] Pharaoh's Blessing - COST:6 
		// - Fac: neutral, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion +4/+4, <b>Divine Shield</b>, and <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PharaohsBlessing_ULD_143()
		{
			// TODO PharaohsBlessing_ULD_143 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pharaoh's Blessing"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pharaoh's Blessing"));
			//Spell testCard = game.ProcessCard<Spell>("Pharaoh's Blessing");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ULD_431] Making Mummies - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Play 5 <b>Reborn</b>
		//       minions.
		//       <b>Reward:</b> Emperor Wraps.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 5
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 53908
		// --------------------------------------------------------
		// RefTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MakingMummies_ULD_431()
		{
			// TODO MakingMummies_ULD_431 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Making Mummies"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Making Mummies"));
			//Spell testCard = game.ProcessCard<Spell>("Making Mummies");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ULD_716] Tip the Scales - COST:8 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon 7 Murlocs from your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TipTheScales_ULD_716()
		{
			// TODO TipTheScales_ULD_716 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tip the Scales"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tip the Scales"));
			//Spell testCard = game.ProcessCard<Spell>("Tip the Scales");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ULD_728] Subdue - COST:2 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Set a minion's Attack and Health to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Subdue_ULD_728()
		{
			// TODO Subdue_ULD_728 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Subdue"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Subdue"));
			//Spell testCard = game.ProcessCard<Spell>("Subdue");
		}

	}

	public class PriestUldumTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [ULD_262] High Priest Amet - COST:4 [ATK:2/HP:7] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever you summon a
		//       minion, set its Health equal
		//       to this minion's.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HighPriestAmet_ULD_262()
		{
			// TODO HighPriestAmet_ULD_262 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Priest Amet"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("High Priest Amet"));
			//Minion testCard = game.ProcessCard<Minion>("High Priest Amet");
		}

		// ---------------------------------------- MINION - PRIEST
		// [ULD_266] Grandmummy - COST:2 [ATK:1/HP:2] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Reborn</b>
		//        <b>Deathrattle:</b> Give a random
		//       friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grandmummy_ULD_266()
		{
			// TODO Grandmummy_ULD_266 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grandmummy"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grandmummy"));
			//Minion testCard = game.ProcessCard<Minion>("Grandmummy");
		}

		// ---------------------------------------- MINION - PRIEST
		// [ULD_268] Psychopomp - COST:4 [ATK:3/HP:1] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       random friendly minion
		//       that died this game.
		//       Give it <b>Reborn</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Psychopomp_ULD_268()
		{
			// TODO Psychopomp_ULD_268 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psychopomp"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Psychopomp"));
			//Minion testCard = game.ProcessCard<Minion>("Psychopomp");
		}

		// ---------------------------------------- MINION - PRIEST
		// [ULD_269] Wretched Reclaimer - COST:3 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy a friendly
		//       minion, then return it to life
		//       with full Health.
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
		public void WretchedReclaimer_ULD_269()
		{
			// TODO WretchedReclaimer_ULD_269 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wretched Reclaimer"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wretched Reclaimer"));
			//Minion testCard = game.ProcessCard<Minion>("Wretched Reclaimer");
		}

		// ---------------------------------------- MINION - PRIEST
		// [ULD_270] Sandhoof Waterbearer - COST:5 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, restore #5 Health to a damaged friendly character.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SandhoofWaterbearer_ULD_270()
		{
			// TODO SandhoofWaterbearer_ULD_270 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sandhoof Waterbearer"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sandhoof Waterbearer"));
			//Minion testCard = game.ProcessCard<Minion>("Sandhoof Waterbearer");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ULD_265] Embalming Ritual - COST:1 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion <b>Reborn</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmbalmingRitual_ULD_265()
		{
			// TODO EmbalmingRitual_ULD_265 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Embalming Ritual"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embalming Ritual"));
			//Spell testCard = game.ProcessCard<Spell>("Embalming Ritual");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ULD_272] Holy Ripple - COST:2 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all enemies. Restore #1_Health to all friendly characters. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyRipple_ULD_272()
		{
			// TODO HolyRipple_ULD_272 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Ripple"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Ripple"));
			//Spell testCard = game.ProcessCard<Spell>("Holy Ripple");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ULD_714] Penance - COST:2 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $3 damage to a_minion. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Penance_ULD_714()
		{
			// TODO Penance_ULD_714 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Penance"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Penance"));
			//Spell testCard = game.ProcessCard<Spell>("Penance");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ULD_718] Plague of Death - COST:9 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Silence</b> and destroy all_minions.
		// --------------------------------------------------------
		// GameTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueOfDeath_ULD_718()
		{
			// TODO PlagueOfDeath_ULD_718 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague of Death"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague of Death"));
			//Spell testCard = game.ProcessCard<Spell>("Plague of Death");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ULD_724] Activate the Obelisk - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Restore 15_Health.
		//       <b>Reward:</b> Obelisk's Eye.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 15
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 54750
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ActivateTheObelisk_ULD_724()
		{
			// TODO ActivateTheObelisk_ULD_724 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Activate the Obelisk"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Activate the Obelisk"));
			//Spell testCard = game.ProcessCard<Spell>("Activate the Obelisk");
		}

	}

	public class RogueUldumTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [ULD_186] Pharaoh Cat - COST:1 [ATK:1/HP:2] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random <b>Reborn</b> minion to your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PharaohCat_ULD_186()
		{
			// TODO PharaohCat_ULD_186 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pharaoh Cat"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pharaoh Cat"));
			//Minion testCard = game.ProcessCard<Minion>("Pharaoh Cat");
		}

		// ----------------------------------------- MINION - ROGUE
		// [ULD_231] Whirlkick Master - COST:2 [ATK:1/HP:2] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you play a <b>Combo</b> card, add a random <b>Combo</b> card to your hand.
		// --------------------------------------------------------
		// RefTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhirlkickMaster_ULD_231()
		{
			// TODO WhirlkickMaster_ULD_231 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whirlkick Master"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whirlkick Master"));
			//Minion testCard = game.ProcessCard<Minion>("Whirlkick Master");
		}

		// ----------------------------------------- MINION - ROGUE
		// [ULD_280] Sahket Sapper - COST:4 [ATK:4/HP:4] 
		// - Race: pirate, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return a _random enemy minion to_ your_opponent's_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SahketSapper_ULD_280()
		{
			// TODO SahketSapper_ULD_280 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sahket Sapper"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sahket Sapper"));
			//Minion testCard = game.ProcessCard<Minion>("Sahket Sapper");
		}

		// ----------------------------------------- MINION - ROGUE
		// [ULD_288] Anka, the Buried - COST:5 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Change each <b>Deathrattle</b> minion in your hand into a 1/1 that costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnkaTheBuried_ULD_288()
		{
			// TODO AnkaTheBuried_ULD_288 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anka, the Buried"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anka, the Buried"));
			//Minion testCard = game.ProcessCard<Minion>("Anka, the Buried");
		}

		// ----------------------------------------- MINION - ROGUE
		// [ULD_327] Bazaar Mugger - COST:5 [ATK:3/HP:5] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> Add a random minion from another class to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BazaarMugger_ULD_327()
		{
			// TODO BazaarMugger_ULD_327 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bazaar Mugger"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bazaar Mugger"));
			//Minion testCard = game.ProcessCard<Minion>("Bazaar Mugger");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ULD_286] Shadow of Death - COST:4 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Choose a minion. Shuffle 3 'Shadows' into your deck that summon a copy when drawn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowOfDeath_ULD_286()
		{
			// TODO ShadowOfDeath_ULD_286 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow of Death"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow of Death"));
			//Spell testCard = game.ProcessCard<Spell>("Shadow of Death");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ULD_326] Bazaar Burglary - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Add 4 cards from
		//       other classes to your hand.
		//       <b>Reward: </b>Ancient Blades.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 4
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 54312
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BazaarBurglary_ULD_326()
		{
			// TODO BazaarBurglary_ULD_326 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bazaar Burglary"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bazaar Burglary"));
			//Spell testCard = game.ProcessCard<Spell>("Bazaar Burglary");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ULD_328] Clever Disguise - COST:2 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Add 2 random spells from another class to_your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CleverDisguise_ULD_328()
		{
			// TODO CleverDisguise_ULD_328 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clever Disguise"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clever Disguise"));
			//Spell testCard = game.ProcessCard<Spell>("Clever Disguise");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ULD_715] Plague of Madness - COST:1 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Each player equips
		//       a 2/2 Knife with <b>Poisonous</b>.
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 2451
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueOfMadness_ULD_715()
		{
			// TODO PlagueOfMadness_ULD_715 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague of Madness"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague of Madness"));
			//Spell testCard = game.ProcessCard<Spell>("Plague of Madness");
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [ULD_285] Hooked Scimitar - COST:3 [ATK:2/HP:0] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Combo:</b> Gain +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HookedScimitar_ULD_285()
		{
			// TODO HookedScimitar_ULD_285 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hooked Scimitar"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooked Scimitar"));
			//Weapon testCard = game.ProcessCard<Weapon>("Hooked Scimitar");
		}

	}

	public class ShamanUldumTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [ULD_158] Sandstorm Elemental - COST:2 [ATK:2/HP:2] 
		// - Race: elemental, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all enemy minions. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SandstormElemental_ULD_158()
		{
			// TODO SandstormElemental_ULD_158 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sandstorm Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sandstorm Elemental"));
			//Minion testCard = game.ProcessCard<Minion>("Sandstorm Elemental");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ULD_169] Mogu Fleshshaper - COST:7 [ATK:3/HP:4] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>. Costs (1) less for each
		//       minion on the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoguFleshshaper_ULD_169()
		{
			// TODO MoguFleshshaper_ULD_169 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mogu Fleshshaper"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mogu Fleshshaper"));
			//Minion testCard = game.ProcessCard<Minion>("Mogu Fleshshaper");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ULD_170] Weaponized Wasp - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control
		//       a <b>Lackey</b>, deal 3_damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - 88 = 0
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeaponizedWasp_ULD_170()
		{
			// TODO WeaponizedWasp_ULD_170 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Weaponized Wasp"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Weaponized Wasp"));
			//Minion testCard = game.ProcessCard<Minion>("Weaponized Wasp");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ULD_173] Vessina - COST:4 [ATK:2/HP:6] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: While you're <b>Overloaded</b>, your other minions have +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vessina_ULD_173()
		{
			// TODO Vessina_ULD_173 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vessina"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vessina"));
			//Minion testCard = game.ProcessCard<Minion>("Vessina");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ULD_276] EVIL Totem - COST:2 [ATK:0/HP:2] 
		// - Race: totem, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn,
		//       add a <b>Lackey</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - 1359 = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilTotem_ULD_276()
		{
			// TODO EvilTotem_ULD_276 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Totem"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Totem"));
			//Minion testCard = game.ProcessCard<Minion>("EVIL Totem");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ULD_171] Totemic Surge - COST:0 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Give your Totems +2_Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicSurge_ULD_171()
		{
			// TODO TotemicSurge_ULD_171 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totemic Surge"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Surge"));
			//Spell testCard = game.ProcessCard<Spell>("Totemic Surge");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ULD_172] Plague of Murlocs - COST:3 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Transform all minions into random Murlocs.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueOfMurlocs_ULD_172()
		{
			// TODO PlagueOfMurlocs_ULD_172 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague of Murlocs"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague of Murlocs"));
			//Spell testCard = game.ProcessCard<Spell>("Plague of Murlocs");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ULD_181] Earthquake - COST:7 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage to all minions, then deal $2 damage to all minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Earthquake_ULD_181()
		{
			// TODO Earthquake_ULD_181 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earthquake"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earthquake"));
			//Spell testCard = game.ProcessCard<Spell>("Earthquake");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ULD_291] Corrupt the Waters - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Play 6 <b>Battlecry</b>
		//       cards.
		//       <b>Reward:</b> Heart of Vir'naal.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 6
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 54370
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptTheWaters_ULD_291()
		{
			// TODO CorruptTheWaters_ULD_291 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrupt the Waters"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrupt the Waters"));
			//Spell testCard = game.ProcessCard<Spell>("Corrupt the Waters");
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [ULD_413] Splitting Axe - COST:4 [ATK:3/HP:0] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon copies of your Totems.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SplittingAxe_ULD_413()
		{
			// TODO SplittingAxe_ULD_413 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splitting Axe"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splitting Axe"));
			//Weapon testCard = game.ProcessCard<Weapon>("Splitting Axe");
		}

	}

	public class WarlockUldumTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [ULD_161] Neferset Thrasher - COST:3 [ATK:4/HP:5] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this attacks, deal 3 damage to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NefersetThrasher_ULD_161()
		{
			// TODO NefersetThrasher_ULD_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Neferset Thrasher"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Neferset Thrasher"));
			//Minion testCard = game.ProcessCard<Minion>("Neferset Thrasher");
		}

		// --------------------------------------- MINION - WARLOCK
		// [ULD_162] EVIL Recruiter - COST:3 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a friendly <b>Lackey</b> to summon a 5/5 Demon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 1359 = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - 87 = 0
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilRecruiter_ULD_162()
		{
			// TODO EvilRecruiter_ULD_162 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Recruiter"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Recruiter"));
			//Minion testCard = game.ProcessCard<Minion>("EVIL Recruiter");
		}

		// --------------------------------------- MINION - WARLOCK
		// [ULD_163] Expired Merchant - COST:2 [ATK:2/HP:1] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Discard your
		//       highest Cost card.
		//       <b>Deathrattle:</b> Add 2 copies
		//       of it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExpiredMerchant_ULD_163()
		{
			// TODO ExpiredMerchant_ULD_163 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Expired Merchant"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Expired Merchant"));
			//Minion testCard = game.ProcessCard<Minion>("Expired Merchant");
		}

		// --------------------------------------- MINION - WARLOCK
		// [ULD_165] Riftcleaver - COST:6 [ATK:7/HP:5] 
		// - Race: demon, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. Your hero takes damage equal to its Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Riftcleaver_ULD_165()
		{
			// TODO Riftcleaver_ULD_165 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Riftcleaver"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Riftcleaver"));
			//Minion testCard = game.ProcessCard<Minion>("Riftcleaver");
		}

		// --------------------------------------- MINION - WARLOCK
		// [ULD_167] Diseased Vulture - COST:4 [ATK:3/HP:5] 
		// - Race: beast, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: After your hero takes damage on your turn, summon a random
		//       3-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DiseasedVulture_ULD_167()
		{
			// TODO DiseasedVulture_ULD_167 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Diseased Vulture"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Diseased Vulture"));
			//Minion testCard = game.ProcessCard<Minion>("Diseased Vulture");
		}

		// --------------------------------------- MINION - WARLOCK
		// [ULD_168] Dark Pharaoh Tekahn - COST:5 [ATK:4/HP:4] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For the rest of the game, your <b>Lackeys</b> are 4/4.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPharaohTekahn_ULD_168()
		{
			// TODO DarkPharaohTekahn_ULD_168 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Pharaoh Tekahn"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pharaoh Tekahn"));
			//Minion testCard = game.ProcessCard<Minion>("Dark Pharaoh Tekahn");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ULD_140] Supreme Archaeology - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Draw 20 cards.
		//       <b>Reward:</b> Tome of Origination.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 20
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 53740
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SupremeArchaeology_ULD_140()
		{
			// TODO SupremeArchaeology_ULD_140 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Supreme Archaeology"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Supreme Archaeology"));
			//Spell testCard = game.ProcessCard<Spell>("Supreme Archaeology");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ULD_160] Sinister Deal - COST:1 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Lackey</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// - 1359 = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SinisterDeal_ULD_160()
		{
			// TODO SinisterDeal_ULD_160 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sinister Deal"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sinister Deal"));
			//Spell testCard = game.ProcessCard<Spell>("Sinister Deal");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ULD_324] Impbalming - COST:4 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a minion. Shuffle 3 Worthless Imps into your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Impbalming_ULD_324()
		{
			// TODO Impbalming_ULD_324 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Impbalming"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Impbalming"));
			//Spell testCard = game.ProcessCard<Spell>("Impbalming");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ULD_717] Plague of Flames - COST:1 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Destroy all your minions.
		//       For each one, destroy a
		//       random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueOfFlames_ULD_717()
		{
			// TODO PlagueOfFlames_ULD_717 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague of Flames"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague of Flames"));
			//Spell testCard = game.ProcessCard<Spell>("Plague of Flames");
		}

	}

	public class WarriorUldumTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [ULD_195] Frightened Flunky - COST:2 [ATK:2/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrightenedFlunky_ULD_195()
		{
			// TODO FrightenedFlunky_ULD_195 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frightened Flunky"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frightened Flunky"));
			//Minion testCard = game.ProcessCard<Minion>("Frightened Flunky");
		}

		// --------------------------------------- MINION - WARRIOR
		// [ULD_206] Restless Mummy - COST:4 [ATK:3/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RestlessMummy_ULD_206()
		{
			// TODO RestlessMummy_ULD_206 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Restless Mummy"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Restless Mummy"));
			//Minion testCard = game.ProcessCard<Minion>("Restless Mummy");
		}

		// --------------------------------------- MINION - WARRIOR
		// [ULD_253] Tomb Warden - COST:8 [ATK:3/HP:6] 
		// - Race: mechanical, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Summon a copy of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombWarden_ULD_253()
		{
			// TODO TombWarden_ULD_253 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Warden"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Warden"));
			//Minion testCard = game.ProcessCard<Minion>("Tomb Warden");
		}

		// --------------------------------------- MINION - WARRIOR
		// [ULD_258] Armagedillo - COST:6 [ATK:4/HP:7] 
		// - Race: beast, Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       At the end of your turn,
		//       give all <b>Taunt</b> minions
		//       in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Armagedillo_ULD_258()
		{
			// TODO Armagedillo_ULD_258 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Armagedillo"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armagedillo"));
			//Minion testCard = game.ProcessCard<Minion>("Armagedillo");
		}

		// --------------------------------------- MINION - WARRIOR
		// [ULD_709] Armored Goon - COST:6 [ATK:6/HP:7] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your hero attacks, gain 5 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArmoredGoon_ULD_709()
		{
			// TODO ArmoredGoon_ULD_709 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Armored Goon"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armored Goon"));
			//Minion testCard = game.ProcessCard<Minion>("Armored Goon");
		}

		// --------------------------------------- MINION - WARRIOR
		// [ULD_720] Bloodsworn Mercenary - COST:3 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry</b>: Choose a
		//       damaged friendly minion.
		//       Summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodswornMercenary_ULD_720()
		{
			// TODO BloodswornMercenary_ULD_720 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsworn Mercenary"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsworn Mercenary"));
			//Minion testCard = game.ProcessCard<Minion>("Bloodsworn Mercenary");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ULD_256] Into the Fray - COST:1 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Give all <b>Taunt</b> minions in your hand +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IntoTheFray_ULD_256()
		{
			// TODO IntoTheFray_ULD_256 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Into the Fray"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Into the Fray"));
			//Spell testCard = game.ProcessCard<Spell>("Into the Fray");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ULD_707] Plague of Wrath - COST:5 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy all damaged minions.
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 41425
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueOfWrath_ULD_707()
		{
			// TODO PlagueOfWrath_ULD_707 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plague of Wrath"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague of Wrath"));
			//Spell testCard = game.ProcessCard<Spell>("Plague of Wrath");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ULD_711] Hack the System - COST:1 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Attack 5 times
		//       with your hero.
		//       <b>Reward:</b> Anraphet's Core.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 5
		// - 676 = 1
		// - 839 = 1
		// - QUEST_REWARD_DATABASE_ID = 54416
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HackTheSystem_ULD_711()
		{
			// TODO HackTheSystem_ULD_711 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hack the System"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hack the System"));
			//Spell testCard = game.ProcessCard<Spell>("Hack the System");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [ULD_708] Livewire Lance - COST:3 [ATK:2/HP:0] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: After your Hero attacks, add a <b>Lackey</b> to your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - 1359 = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LivewireLance_ULD_708()
		{
			// TODO LivewireLance_ULD_708 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Livewire Lance"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Livewire Lance"));
			//Weapon testCard = game.ProcessCard<Weapon>("Livewire Lance");
		}

	}

	public class NeutralUldumTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [ULD_003] Zephrys the Great - COST:2 [ATK:3/HP:2] 
		// - Race: elemental, Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, wish for the perfect card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZephrysTheGreat_ULD_003()
		{
			// TODO ZephrysTheGreat_ULD_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zephrys the Great"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zephrys the Great"));
			//Minion testCard = game.ProcessCard<Minion>("Zephrys the Great");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_157] Questing Explorer - COST:2 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Quest</b>, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void QuestingExplorer_ULD_157()
		{
			// TODO QuestingExplorer_ULD_157 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Questing Explorer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Questing Explorer"));
			//Minion testCard = game.ProcessCard<Minion>("Questing Explorer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_174] Serpent Egg - COST:2 [ATK:0/HP:3] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/4 Sea Serpent.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SerpentEgg_ULD_174()
		{
			// TODO SerpentEgg_ULD_174 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Serpent Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Serpent Egg"));
			//Minion testCard = game.ProcessCard<Minion>("Serpent Egg");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_177] Octosari - COST:8 [ATK:8/HP:8] 
		// - Race: beast, Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw 8 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Octosari_ULD_177()
		{
			// TODO Octosari_ULD_177 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Octosari"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Octosari"));
			//Minion testCard = game.ProcessCard<Minion>("Octosari");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_178] Siamat - COST:7 [ATK:6/HP:6] 
		// - Race: elemental, Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain 2 of <b>Rush</b>,
		//       <b>Taunt</b>, <b>Divine Shield</b>, or
		//       <b>Windfury</b> <i>(your choice).</i>
		// --------------------------------------------------------
		// Entourage: ULD_178a2, ULD_178a, ULD_178a3, ULD_178a4
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Siamat_ULD_178()
		{
			// TODO Siamat_ULD_178 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Siamat"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Siamat"));
			//Minion testCard = game.ProcessCard<Minion>("Siamat");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_179] Phalanx Commander - COST:5 [ATK:4/HP:5] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: Your <b>Taunt</b> minions
		//       have +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// - 1429 = 58385
		// - TECH_LEVEL = 3
		// - 1456 = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PhalanxCommander_ULD_179()
		{
			// TODO PhalanxCommander_ULD_179 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Phalanx Commander"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phalanx Commander"));
			//Minion testCard = game.ProcessCard<Minion>("Phalanx Commander");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_180] Sunstruck Henchman - COST:4 [ATK:6/HP:5] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, this has a 50% chance to_fall asleep.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunstruckHenchman_ULD_180()
		{
			// TODO SunstruckHenchman_ULD_180 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunstruck Henchman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunstruck Henchman"));
			//Minion testCard = game.ProcessCard<Minion>("Sunstruck Henchman");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_182] Spitting Camel - COST:2 [ATK:2/HP:4] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       __deal 1 damage to another__
		//       random friendly minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpittingCamel_ULD_182()
		{
			// TODO SpittingCamel_ULD_182 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spitting Camel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spitting Camel"));
			//Minion testCard = game.ProcessCard<Minion>("Spitting Camel");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_183] Anubisath Warbringer - COST:9 [ATK:9/HP:6] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give all minions in your hand +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnubisathWarbringer_ULD_183()
		{
			// TODO AnubisathWarbringer_ULD_183 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anubisath Warbringer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anubisath Warbringer"));
			//Minion testCard = game.ProcessCard<Minion>("Anubisath Warbringer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_184] Kobold Sandtrooper - COST:2 [ATK:2/HP:1] 
		// - Fac: alliance, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 3 damage to the enemy_hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldSandtrooper_ULD_184()
		{
			// TODO KoboldSandtrooper_ULD_184 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Sandtrooper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Sandtrooper"));
			//Minion testCard = game.ProcessCard<Minion>("Kobold Sandtrooper");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_185] Temple Berserker - COST:2 [ATK:1/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Reborn</b>
		//       Has +2 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TempleBerserker_ULD_185()
		{
			// TODO TempleBerserker_ULD_185 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temple Berserker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temple Berserker"));
			//Minion testCard = game.ProcessCard<Minion>("Temple Berserker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_188] Golden Scarab - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b><b>Battlecry:</b> Discover</b> a
		//       4-Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoldenScarab_ULD_188()
		{
			// TODO GoldenScarab_ULD_188 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Golden Scarab"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Golden Scarab"));
			//Minion testCard = game.ProcessCard<Minion>("Golden Scarab");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_189] Faceless Lurker - COST:5 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Double this minion's Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessLurker_ULD_189()
		{
			// TODO FacelessLurker_ULD_189 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Lurker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Lurker"));
			//Minion testCard = game.ProcessCard<Minion>("Faceless Lurker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_190] Pit Crocolisk - COST:8 [ATK:5/HP:6] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 5 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitCrocolisk_ULD_190()
		{
			// TODO PitCrocolisk_ULD_190 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pit Crocolisk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pit Crocolisk"));
			//Minion testCard = game.ProcessCard<Minion>("Pit Crocolisk");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_191] Beaming Sidekick - COST:1 [ATK:1/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +2 Health.
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
		public void BeamingSidekick_ULD_191()
		{
			// TODO BeamingSidekick_ULD_191 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beaming Sidekick"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beaming Sidekick"));
			//Minion testCard = game.ProcessCard<Minion>("Beaming Sidekick");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_193] Living Monument - COST:10 [ATK:10/HP:10] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LivingMonument_ULD_193()
		{
			// TODO LivingMonument_ULD_193 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Living Monument"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Monument"));
			//Minion testCard = game.ProcessCard<Minion>("Living Monument");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_194] Wasteland Scorpid - COST:7 [ATK:3/HP:9] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WastelandScorpid_ULD_194()
		{
			// TODO WastelandScorpid_ULD_194 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wasteland Scorpid"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wasteland Scorpid"));
			//Minion testCard = game.ProcessCard<Minion>("Wasteland Scorpid");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_196] Neferset Ritualist - COST:2 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore adjacent minions to full_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NefersetRitualist_ULD_196()
		{
			// TODO NefersetRitualist_ULD_196 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Neferset Ritualist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Neferset Ritualist"));
			//Minion testCard = game.ProcessCard<Minion>("Neferset Ritualist");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_197] Quicksand Elemental - COST:2 [ATK:3/HP:2] 
		// - Race: elemental, Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all enemy minions -2 Attack this_turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void QuicksandElemental_ULD_197()
		{
			// TODO QuicksandElemental_ULD_197 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Quicksand Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quicksand Elemental"));
			//Minion testCard = game.ProcessCard<Minion>("Quicksand Elemental");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_198] Conjured Mirage - COST:4 [ATK:3/HP:10] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       At the start of your turn, shuffle this minion into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConjuredMirage_ULD_198()
		{
			// TODO ConjuredMirage_ULD_198 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Conjured Mirage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Conjured Mirage"));
			//Minion testCard = game.ProcessCard<Minion>("Conjured Mirage");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_205] Candletaker - COST:3 [ATK:3/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Candletaker_ULD_205()
		{
			// TODO Candletaker_ULD_205 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candletaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candletaker"));
			//Minion testCard = game.ProcessCard<Minion>("Candletaker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_208] Khartut Defender - COST:6 [ATK:3/HP:4] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>, <b>Reborn</b>
		//       <b>Deathrattle:</b> Restore #3
		//       Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KhartutDefender_ULD_208()
		{
			// TODO KhartutDefender_ULD_208 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Khartut Defender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Khartut Defender"));
			//Minion testCard = game.ProcessCard<Minion>("Khartut Defender");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_209] Vulpera Scoundrel - COST:3 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: <b>Discover</b> a spell or pick a mystery choice.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VulperaScoundrel_ULD_209()
		{
			// TODO VulperaScoundrel_ULD_209 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vulpera Scoundrel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vulpera Scoundrel"));
			//Minion testCard = game.ProcessCard<Minion>("Vulpera Scoundrel");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_214] Generous Mummy - COST:3 [ATK:5/HP:4] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Reborn</b>
		//       Your opponent's cards cost (1) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GenerousMummy_ULD_214()
		{
			// TODO GenerousMummy_ULD_214 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Generous Mummy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Generous Mummy"));
			//Minion testCard = game.ProcessCard<Minion>("Generous Mummy");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_215] Wrapped Golem - COST:7 [ATK:7/HP:5] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Reborn</b>
		//       At the end of your turn,
		//       summon a 1/1 Scarab
		//       with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - REBORN = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WrappedGolem_ULD_215()
		{
			// TODO WrappedGolem_ULD_215 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wrapped Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrapped Golem"));
			//Minion testCard = game.ProcessCard<Minion>("Wrapped Golem");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_229] Mischief Maker - COST:3 [ATK:3/HP:3] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap the top card of your deck with your_opponent's.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MischiefMaker_ULD_229()
		{
			// TODO MischiefMaker_ULD_229 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mischief Maker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mischief Maker"));
			//Minion testCard = game.ProcessCard<Minion>("Mischief Maker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_250] Infested Goblin - COST:3 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Add two 1/1 Scarabs with <b>Taunt</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InfestedGoblin_ULD_250()
		{
			// TODO InfestedGoblin_ULD_250 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infested Goblin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infested Goblin"));
			//Minion testCard = game.ProcessCard<Minion>("Infested Goblin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_271] Injured Tol'vir - COST:2 [ATK:2/HP:6] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Deal 3 damage to this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InjuredTolvir_ULD_271()
		{
			// TODO InjuredTolvir_ULD_271 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Injured Tol'vir"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Tol'vir"));
			//Minion testCard = game.ProcessCard<Minion>("Injured Tol'vir");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_274] Wasteland Assassin - COST:5 [ATK:4/HP:2] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WastelandAssassin_ULD_274()
		{
			// TODO WastelandAssassin_ULD_274 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wasteland Assassin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wasteland Assassin"));
			//Minion testCard = game.ProcessCard<Minion>("Wasteland Assassin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_275] Bone Wraith - COST:4 [ATK:2/HP:5] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneWraith_ULD_275()
		{
			// TODO BoneWraith_ULD_275 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Wraith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Wraith"));
			//Minion testCard = game.ProcessCard<Minion>("Bone Wraith");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_282] Jar Dealer - COST:1 [ATK:1/HP:1] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Add a random
		//       1-Cost minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JarDealer_ULD_282()
		{
			// TODO JarDealer_ULD_282 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jar Dealer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jar Dealer"));
			//Minion testCard = game.ProcessCard<Minion>("Jar Dealer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_289] Fishflinger - COST:2 [ATK:3/HP:2] 
		// - Race: murloc, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a
		//       random Murloc to each player's_hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fishflinger_ULD_289()
		{
			// TODO Fishflinger_ULD_289 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fishflinger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fishflinger"));
			//Minion testCard = game.ProcessCard<Minion>("Fishflinger");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_290] History Buff - COST:3 [ATK:3/HP:4] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you play a minion, give a random minion in your hand +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HistoryBuff_ULD_290()
		{
			// TODO HistoryBuff_ULD_290 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("History Buff"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("History Buff"));
			//Minion testCard = game.ProcessCard<Minion>("History Buff");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_304] King Phaoris - COST:10 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> For each spell
		//       in your hand, summon a
		//       random minion of the
		//       same Cost.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingPhaoris_ULD_304()
		{
			// TODO KingPhaoris_ULD_304 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Phaoris"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Phaoris"));
			//Minion testCard = game.ProcessCard<Minion>("King Phaoris");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_309] Dwarven Archaeologist - COST:2 [ATK:2/HP:3] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: After you <b>Discover</b> a card, reduce its cost by (1).
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DwarvenArchaeologist_ULD_309()
		{
			// TODO DwarvenArchaeologist_ULD_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dwarven Archaeologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dwarven Archaeologist"));
			//Minion testCard = game.ProcessCard<Minion>("Dwarven Archaeologist");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_450] Vilefiend - COST:2 [ATK:2/HP:2] 
		// - Race: demon, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vilefiend_ULD_450()
		{
			// TODO Vilefiend_ULD_450 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vilefiend"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vilefiend"));
			//Minion testCard = game.ProcessCard<Minion>("Vilefiend");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_702] Mortuary Machine - COST:5 [ATK:8/HP:8] 
		// - Race: mechanical, Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: After your opponent plays a minion, give it <b>Reborn</b>.
		// --------------------------------------------------------
		// RefTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MortuaryMachine_ULD_702()
		{
			// TODO MortuaryMachine_ULD_702 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mortuary Machine"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mortuary Machine"));
			//Minion testCard = game.ProcessCard<Minion>("Mortuary Machine");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_703] Desert Obelisk - COST:5 [ATK:0/HP:5] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]If you control 3 of these
		//       at the end of your turn,
		//       deal 5 damage to a
		//       random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesertObelisk_ULD_703()
		{
			// TODO DesertObelisk_ULD_703 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desert Obelisk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desert Obelisk"));
			//Minion testCard = game.ProcessCard<Minion>("Desert Obelisk");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_705] Mogu Cultist - COST:1 [ATK:1/HP:1] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your board is full of Mogu Cultists, sacrifice them all and summon Highkeeper Ra.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoguCultist_ULD_705()
		{
			// TODO MoguCultist_ULD_705 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mogu Cultist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mogu Cultist"));
			//Minion testCard = game.ProcessCard<Minion>("Mogu Cultist");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_706] Blatant Decoy - COST:6 [ATK:5/HP:5] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Each player
		//       summons the lowest Cost
		//       minion from their hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlatantDecoy_ULD_706()
		{
			// TODO BlatantDecoy_ULD_706 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blatant Decoy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blatant Decoy"));
			//Minion testCard = game.ProcessCard<Minion>("Blatant Decoy");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_712] Bug Collector - COST:2 [ATK:2/HP:1] 
		// - Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 Locust with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BugCollector_ULD_712()
		{
			// TODO BugCollector_ULD_712 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bug Collector"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bug Collector"));
			//Minion testCard = game.ProcessCard<Minion>("Bug Collector");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_719] Desert Hare - COST:3 [ATK:1/HP:1] 
		// - Race: beast, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Desert Hares.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesertHare_ULD_719()
		{
			// TODO DesertHare_ULD_719 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desert Hare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desert Hare"));
			//Minion testCard = game.ProcessCard<Minion>("Desert Hare");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_721] Colossus of the Moon - COST:10 [ATK:10/HP:10] 
		// - Set: uldum, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColossusOfTheMoon_ULD_721()
		{
			// TODO ColossusOfTheMoon_ULD_721 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Colossus of the Moon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Colossus of the Moon"));
			//Minion testCard = game.ProcessCard<Minion>("Colossus of the Moon");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_723] Murmy - COST:1 [ATK:1/HP:1] 
		// - Race: murloc, Set: uldum, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Reborn</b>
		// --------------------------------------------------------
		// GameTag:
		// - REBORN = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Murmy_ULD_723()
		{
			// TODO Murmy_ULD_723 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murmy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murmy"));
			//Minion testCard = game.ProcessCard<Minion>("Murmy");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ULD_727] Body Wrapper - COST:4 [ATK:4/HP:4] 
		// - Set: uldum, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a friendly minion that died this game. Shuffle it into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BodyWrapper_ULD_727()
		{
			// TODO BodyWrapper_ULD_727 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Body Wrapper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Body Wrapper"));
			//Minion testCard = game.ProcessCard<Minion>("Body Wrapper");
		}

	}

}
