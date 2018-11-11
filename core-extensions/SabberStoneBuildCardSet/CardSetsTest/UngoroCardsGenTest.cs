using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroPowersUngoroTest
	{
		// ------------------------------------ HERO_POWER - HUNTER
		// [UNG_917t1] Dinomancy (*) - COST:2 
		// - Set: ungoro, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a Beast +2/+2.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_RACE = 20
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dinomancy_UNG_917t1()
		{
			// TODO Dinomancy_UNG_917t1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dinomancy"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dinomancy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dinomancy"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [UNG_934t2] DIE, INSECT! (*) - COST:2 
		// - Set: ungoro, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $8 damage to a random enemy. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DieInsect_UNG_934t2()
		{
			// TODO DieInsect_UNG_934t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("DIE, INSECT!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("DIE, INSECT!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "DIE, INSECT!"));
		}

	}

	public class DruidUngoroTest
	{
		// ----------------------------------------- MINION - DRUID
		// [UNG_078] Tortollan Forager - COST:2 [ATK:2/HP:2] 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random minion with 5 or more Attack to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TortollanForager_UNG_078()
		{
			// TODO TortollanForager_UNG_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tortollan Forager"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tortollan Forager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tortollan Forager"));
		}

		// ----------------------------------------- MINION - DRUID
		// [UNG_086] Giant Anaconda - COST:7 [ATK:5/HP:3] 
		// - Race: beast, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a minion from your hand with 5 or more Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantAnaconda_UNG_086()
		{
			// TODO GiantAnaconda_UNG_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Anaconda"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Anaconda"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Anaconda"));
		}

		// ----------------------------------------- MINION - DRUID
		// [UNG_100] Verdant Longneck - COST:5 [ATK:5/HP:4] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Adapt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VerdantLongneck_UNG_100()
		{
			// TODO VerdantLongneck_UNG_100 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Verdant Longneck"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Verdant Longneck"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Verdant Longneck"));
		}

		// ----------------------------------------- MINION - DRUID
		// [UNG_101] Shellshifter - COST:4 [ATK:3/HP:3] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Choose One - </b>Transform
		//       into a 5/3 with <b>Stealth</b>;
		//       or a 3/5 with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shellshifter_UNG_101()
		{
			// TODO Shellshifter_UNG_101 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shellshifter"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shellshifter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shellshifter"));
		}

		// ----------------------------------------- MINION - DRUID
		// [UNG_109] Elder Longneck - COST:3 [ATK:5/HP:1] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a minion with 5 or more Attack, <b>Adapt</b>.
		// --------------------------------------------------------
		// Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElderLongneck_UNG_109()
		{
			// TODO ElderLongneck_UNG_109 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elder Longneck"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elder Longneck"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elder Longneck"));
		}

		// ----------------------------------------- MINION - DRUID
		// [UNG_852] Tyrantus - COST:10 [ATK:12/HP:12] 
		// - Race: beast, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Tyrantus_UNG_852()
		{
			// TODO Tyrantus_UNG_852 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tyrantus"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tyrantus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tyrantus"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [UNG_103] Evolving Spores - COST:4 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Adapt</b> your minions.
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvolvingSpores_UNG_103()
		{
			// TODO EvolvingSpores_UNG_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evolving Spores"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evolving Spores"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evolving Spores"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [UNG_108] Earthen Scales - COST:1 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a friendly minion +1/+1, then gain Armor equal to its Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EarthenScales_UNG_108()
		{
			// TODO EarthenScales_UNG_108 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earthen Scales"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earthen Scales"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Earthen Scales"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [UNG_111] Living Mana - COST:5 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Transform your Mana Crystals into 2/2 Treants. Recover the mana when they die.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LivingMana_UNG_111()
		{
			// TODO LivingMana_UNG_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Living Mana"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Mana"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Living Mana"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [UNG_116] Jungle Giants - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Summon
		//       5 minions with
		//       5 or more Attack.
		//       <b>Reward:</b> Barnabus.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 5
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JungleGiants_UNG_116()
		{
			// TODO JungleGiants_UNG_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jungle Giants"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jungle Giants"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jungle Giants"));
		}

	}

	public class HunterUngoroTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [UNG_800] Terrorscale Stalker - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
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
		public void TerrorscaleStalker_UNG_800()
		{
			// TODO TerrorscaleStalker_UNG_800 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terrorscale Stalker"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terrorscale Stalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terrorscale Stalker"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [UNG_912] Jeweled Macaw - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Beast to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeweledMacaw_UNG_912()
		{
			// TODO JeweledMacaw_UNG_912 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeweled Macaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeweled Macaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeweled Macaw"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [UNG_913] Tol'vir Warden - COST:5 [ATK:3/HP:5] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw two 1-Cost minions from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TolvirWarden_UNG_913()
		{
			// TODO TolvirWarden_UNG_913 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tol'vir Warden"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tol'vir Warden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tol'vir Warden"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [UNG_914] Raptor Hatchling - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle a 4/3 Raptor into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaptorHatchling_UNG_914()
		{
			// TODO RaptorHatchling_UNG_914 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raptor Hatchling"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raptor Hatchling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raptor Hatchling"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [UNG_915] Crackling Razormaw - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Adapt</b> a friendly_Beast.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CracklingRazormaw_UNG_915()
		{
			// TODO CracklingRazormaw_UNG_915 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crackling Razormaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crackling Razormaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crackling Razormaw"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [UNG_919] Swamp King Dred - COST:7 [ATK:9/HP:9] 
		// - Race: beast, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your opponent plays a minion, attack_it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwampKingDred_UNG_919()
		{
			// TODO SwampKingDred_UNG_919 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swamp King Dred"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swamp King Dred"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swamp King Dred"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [UNG_910] Grievous Bite - COST:2 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion and $1 damage to adjacent ones. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrievousBite_UNG_910()
		{
			// TODO GrievousBite_UNG_910 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grievous Bite"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grievous Bite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grievous Bite"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [UNG_916] Stampede - COST:1 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Each time you play a Beast this turn, add_a_random Beast to_your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stampede_UNG_916()
		{
			// TODO Stampede_UNG_916 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stampede"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stampede"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stampede"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [UNG_917] Dinomancy - COST:2 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power becomes 'Give a Beast +2/+2.'
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dinomancy_UNG_917()
		{
			// TODO Dinomancy_UNG_917 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dinomancy"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dinomancy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dinomancy"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [UNG_920] The Marsh Queen - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Play seven
		//       1-Cost minions.
		//       <b>Reward:</b> Queen Carnassa.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 7
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMarshQueen_UNG_920()
		{
			// TODO TheMarshQueen_UNG_920 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Marsh Queen"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Marsh Queen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Marsh Queen"));
		}

	}

	public class MageUngoroTest
	{
		// ------------------------------------------ MINION - MAGE
		// [UNG_020] Arcanologist - COST:2 [ATK:2/HP:3] 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a <b>Secret</b> from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Arcanologist_UNG_020()
		{
			// TODO Arcanologist_UNG_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcanologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanologist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcanologist"));
		}

		// ------------------------------------------ MINION - MAGE
		// [UNG_021] Steam Surger - COST:4 [ATK:5/HP:4] 
		// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you played
		//       an Elemental last turn,
		//       add a 'Flame Geyser'
		//       to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteamSurger_UNG_021()
		{
			// TODO SteamSurger_UNG_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Steam Surger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steam Surger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Steam Surger"));
		}

		// ------------------------------------------ MINION - MAGE
		// [UNG_027] Pyros - COST:2 [ATK:2/HP:2] 
		// - Race: elemental, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return this to_your hand as a 6/6 that costs (6).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Pyros_UNG_027()
		{
			// TODO Pyros_UNG_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pyros"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyros"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pyros"));
		}

		// ------------------------------------------ MINION - MAGE
		// [UNG_846] Shimmering Tempest - COST:2 [ATK:2/HP:1] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Mage spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShimmeringTempest_UNG_846()
		{
			// TODO ShimmeringTempest_UNG_846 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shimmering Tempest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shimmering Tempest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shimmering Tempest"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_018] Flame Geyser - COST:2 
		// - Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage.
		//       Add a 1/2 Elemental to_your hand. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameGeyser_UNG_018()
		{
			// TODO FlameGeyser_UNG_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flame Geyser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flame Geyser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flame Geyser"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_024] Mana Bind - COST:3 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your opponent casts a spell, add a copy to your hand that costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaBind_UNG_024()
		{
			// TODO ManaBind_UNG_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Bind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Bind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Bind"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_028] Open the Waygate - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Cast 6 spells that
		//       didn't start in your deck.
		//       <b>Reward:</b> Time Warp.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 6
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OpenTheWaygate_UNG_028()
		{
			// TODO OpenTheWaygate_UNG_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Open the Waygate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Open the Waygate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Open the Waygate"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_941] Primordial Glyph - COST:2 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a spell. Reduce its Cost by (2).
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimordialGlyph_UNG_941()
		{
			// TODO PrimordialGlyph_UNG_941 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primordial Glyph"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primordial Glyph"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primordial Glyph"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_948] Molten Reflection - COST:4 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Choose a friendly minion. Summon a copy of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoltenReflection_UNG_948()
		{
			// TODO MoltenReflection_UNG_948 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Molten Reflection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Reflection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Molten Reflection"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [UNG_955] Meteor - COST:6 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $15 damage to a minion and $3 damage to adjacent ones. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Meteor_UNG_955()
		{
			// TODO Meteor_UNG_955 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Meteor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Meteor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Meteor"));
		}

	}

	public class PaladinUngoroTest
	{
		// --------------------------------------- MINION - PALADIN
		// [UNG_011] Hydrologist - COST:2 [ATK:2/HP:2] 
		// - Race: murloc, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hydrologist_UNG_011()
		{
			// TODO Hydrologist_UNG_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hydrologist"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hydrologist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hydrologist"));
		}

		// --------------------------------------- MINION - PALADIN
		// [UNG_015] Sunkeeper Tarim - COST:6 [ATK:3/HP:7] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Set all other minions' Attack and Health to 3.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunkeeperTarim_UNG_015()
		{
			// TODO SunkeeperTarim_UNG_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunkeeper Tarim"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunkeeper Tarim"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sunkeeper Tarim"));
		}

		// --------------------------------------- MINION - PALADIN
		// [UNG_953] Primalfin Champion - COST:2 [ATK:1/HP:2] 
		// - Race: murloc, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Return any
		//       spells you cast on this
		//       minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - 537 = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalfinChampion_UNG_953()
		{
			// TODO PrimalfinChampion_UNG_953 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primalfin Champion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primalfin Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primalfin Champion"));
		}

		// --------------------------------------- MINION - PALADIN
		// [UNG_962] Lightfused Stegodon - COST:4 [ATK:3/HP:4] 
		// - Race: beast, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Adapt</b> your Silver_Hand Recruits.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightfusedStegodon_UNG_962()
		{
			// TODO LightfusedStegodon_UNG_962 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightfused Stegodon"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightfused Stegodon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightfused Stegodon"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [UNG_004] Dinosize - COST:8 
		// - Fac: neutral, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Set a minion's Attack and Health to 10.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dinosize_UNG_004()
		{
			// TODO Dinosize_UNG_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dinosize"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dinosize"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dinosize"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [UNG_952] Spikeridged Steed - COST:6 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion +2/+6 and <b>Taunt</b>. When it dies, summon a Stegodon.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpikeridgedSteed_UNG_952()
		{
			// TODO SpikeridgedSteed_UNG_952 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spikeridged Steed"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spikeridged Steed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spikeridged Steed"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [UNG_954] The Last Kaleidosaur - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Cast 6 spells
		//       on your minions.
		//       <b>Reward:</b> Galvadon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 6
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheLastKaleidosaur_UNG_954()
		{
			// TODO TheLastKaleidosaur_UNG_954 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Last Kaleidosaur"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Last Kaleidosaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Last Kaleidosaur"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [UNG_960] Lost in the Jungle - COST:1 
		// - Fac: alliance, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Summon two 1/1 Silver Hand Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LostInTheJungle_UNG_960()
		{
			// TODO LostInTheJungle_UNG_960 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lost in the Jungle"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lost in the Jungle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lost in the Jungle"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [UNG_961] Adaptation - COST:1 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Adapt</b> a friendly minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Adaptation_UNG_961()
		{
			// TODO Adaptation_UNG_961 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Adaptation"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Adaptation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Adaptation"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [UNG_950] Vinecleaver - COST:7 [ATK:4/HP:0] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After your hero attacks,
		//       summon two 1/1 Silver
		//       Hand Recruits.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vinecleaver_UNG_950()
		{
			// TODO Vinecleaver_UNG_950 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vinecleaver"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vinecleaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vinecleaver"));
		}

	}

	public class PriestUngoroTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [UNG_022] Mirage Caller - COST:3 [ATK:2/HP:3] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Summon a 1/1 copy of it.
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
		public void MirageCaller_UNG_022()
		{
			// TODO MirageCaller_UNG_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mirage Caller"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirage Caller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mirage Caller"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [UNG_032] Crystalline Oracle - COST:1 [ATK:1/HP:1] 
		// - Race: elemental, Fac: horde, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Copy a card
		//       from your opponent's deck
		//       _and add it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystallineOracle_UNG_032()
		{
			// TODO CrystallineOracle_UNG_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystalline Oracle"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystalline Oracle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystalline Oracle"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [UNG_034] Radiant Elemental - COST:2 [ATK:2/HP:3] 
		// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Your spells cost (1) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RadiantElemental_UNG_034()
		{
			// TODO RadiantElemental_UNG_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Radiant Elemental"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Radiant Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Radiant Elemental"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [UNG_035] Curious Glimmerroot - COST:3 [ATK:3/HP:3] 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Look at 3 cards.
		//       Guess which one started
		//       in your opponent's deck
		//       to get a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CuriousGlimmerroot_UNG_035()
		{
			// TODO CuriousGlimmerroot_UNG_035 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curious Glimmerroot"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curious Glimmerroot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curious Glimmerroot"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [UNG_037] Tortollan Shellraiser - COST:4 [ATK:2/HP:6] 
		// - Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Deathrattle:</b> Give a random
		//       _friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TortollanShellraiser_UNG_037()
		{
			// TODO TortollanShellraiser_UNG_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tortollan Shellraiser"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tortollan Shellraiser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tortollan Shellraiser"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [UNG_963] Lyra the Sunshard - COST:5 [ATK:3/HP:5] 
		// - Race: elemental, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, add a random Priest spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LyraTheSunshard_UNG_963()
		{
			// TODO LyraTheSunshard_UNG_963 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lyra the Sunshard"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lyra the Sunshard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lyra the Sunshard"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [UNG_029] Shadow Visions - COST:2 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a copy of a spell in your deck.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowVisions_UNG_029()
		{
			// TODO ShadowVisions_UNG_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Visions"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Visions"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Visions"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [UNG_030] Binding Heal - COST:1 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #5 Health to a minion and your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BindingHeal_UNG_030()
		{
			// TODO BindingHeal_UNG_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Binding Heal"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Binding Heal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Binding Heal"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [UNG_854] Free From Amber - COST:8 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a minion that costs (8) or more. Summon it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FreeFromAmber_UNG_854()
		{
			// TODO FreeFromAmber_UNG_854 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Free From Amber"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Free From Amber"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Free From Amber"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [UNG_940] Awaken the Makers - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Quest:</b> Summon
		//       7 <b>Deathrattle</b> minions.<b>
		//       Reward:</b> Amara, Warden of Hope.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 7
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AwakenTheMakers_UNG_940()
		{
			// TODO AwakenTheMakers_UNG_940 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Awaken the Makers"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Awaken the Makers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Awaken the Makers"));
		}

	}

	public class RogueUngoroTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [UNG_058] Razorpetal Lasher - COST:2 [ATK:2/HP:2] 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add a
		//       Razorpetal to your hand
		//       that deals 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazorpetalLasher_UNG_058()
		{
			// TODO RazorpetalLasher_UNG_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Razorpetal Lasher"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorpetal Lasher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Razorpetal Lasher"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [UNG_063] Biteweed - COST:2 [ATK:1/HP:1] 
		// - Fac: neutral, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +1/+1 for each other card you've played this turn.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Biteweed_UNG_063()
		{
			// TODO Biteweed_UNG_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Biteweed"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Biteweed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Biteweed"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [UNG_064] Vilespine Slayer - COST:5 [ATK:3/HP:4] 
		// - Fac: neutral, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Destroy a minion.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VilespineSlayer_UNG_064()
		{
			// TODO VilespineSlayer_UNG_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vilespine Slayer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vilespine Slayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vilespine Slayer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [UNG_065] Sherazin, Corpse Flower - COST:4 [ATK:5/HP:3] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Go dormant. Play 4 cards in a turn to revive this minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SherazinCorpseFlower_UNG_065()
		{
			// TODO SherazinCorpseFlower_UNG_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sherazin, Corpse Flower"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sherazin, Corpse Flower"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sherazin, Corpse Flower"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [UNG_057] Razorpetal Volley - COST:2 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Add two Razorpetals to_your hand that deal_1 damage.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazorpetalVolley_UNG_057()
		{
			// TODO RazorpetalVolley_UNG_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Razorpetal Volley"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorpetal Volley"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Razorpetal Volley"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [UNG_060] Mimic Pod - COST:3 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card, then add a copy of it to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MimicPod_UNG_060()
		{
			// TODO MimicPod_UNG_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mimic Pod"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mimic Pod"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mimic Pod"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [UNG_067] The Caverns Below - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Play five minions
		//       with the same name.
		//       <b>Reward:</b> Crystal Core.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 5
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCavernsBelow_UNG_067()
		{
			// TODO TheCavernsBelow_UNG_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Caverns Below"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Caverns Below"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Caverns Below"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [UNG_823] Envenom Weapon - COST:3 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your weapon <b>Poisonous</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnvenomWeapon_UNG_823()
		{
			// TODO EnvenomWeapon_UNG_823 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Envenom Weapon"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Envenom Weapon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Envenom Weapon"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [UNG_856] Hallucination - COST:1 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a card from your opponent's class.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hallucination_UNG_856()
		{
			// TODO Hallucination_UNG_856 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hallucination"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hallucination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hallucination"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [UNG_061] Obsidian Shard - COST:4 [ATK:3/HP:0] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Costs (1) less for each
		//       card you've played from
		//       another class.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObsidianShard_UNG_061()
		{
			// TODO ObsidianShard_UNG_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Obsidian Shard"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Shard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Obsidian Shard"));
		}

	}

	public class ShamanUngoroTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [UNG_019] Air Elemental - COST:1 [ATK:2/HP:1] 
		// - Race: elemental, Fac: horde, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AirElemental_UNG_019()
		{
			// TODO AirElemental_UNG_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Air Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Air Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Air Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [UNG_201] Primalfin Totem - COST:2 [ATK:0/HP:3] 
		// - Race: totem, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 1/1 Murloc.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalfinTotem_UNG_201()
		{
			// TODO PrimalfinTotem_UNG_201 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primalfin Totem"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primalfin Totem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primalfin Totem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [UNG_202] Fire Plume Harbinger - COST:2 [ATK:1/HP:1] 
		// - Race: elemental, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reduce the Cost of Elementals in your hand_by (1).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FirePlumeHarbinger_UNG_202()
		{
			// TODO FirePlumeHarbinger_UNG_202 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Plume Harbinger"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Plume Harbinger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire Plume Harbinger"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [UNG_208] Stone Sentinel - COST:7 [ATK:4/HP:4] 
		// - Race: elemental, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you played an Elemental last turn, summon two 2/3 Elementals with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StoneSentinel_UNG_208()
		{
			// TODO StoneSentinel_UNG_208 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stone Sentinel"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stone Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stone Sentinel"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [UNG_211] Kalimos, Primal Lord - COST:8 [ATK:7/HP:7] 
		// - Race: elemental, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you played an
		//       Elemental last turn, cast an
		//       Elemental Invocation.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KalimosPrimalLord_UNG_211()
		{
			// TODO KalimosPrimalLord_UNG_211 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kalimos, Primal Lord"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kalimos, Primal Lord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kalimos, Primal Lord"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [UNG_938] Hot Spring Guardian - COST:3 [ATK:2/HP:4] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Restore #3_Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HotSpringGuardian_UNG_938()
		{
			// TODO HotSpringGuardian_UNG_938 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hot Spring Guardian"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hot Spring Guardian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hot Spring Guardian"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [UNG_025] Volcano - COST:5 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $15 damage randomly split among all_minions.
		//       <b>Overload:</b> (2) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Volcano_UNG_025()
		{
			// TODO Volcano_UNG_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volcano"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcano"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volcano"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [UNG_817] Tidal Surge - COST:4 
		// - Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. Restore #4 Health to your hero. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TidalSurge_UNG_817()
		{
			// TODO TidalSurge_UNG_817 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tidal Surge"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tidal Surge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tidal Surge"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [UNG_942] Unite the Murlocs - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Summon
		//       10 Murlocs.
		//       <b>Reward:</b> Megafin.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 10
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UniteTheMurlocs_UNG_942()
		{
			// TODO UniteTheMurlocs_UNG_942 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unite the Murlocs"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unite the Murlocs"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unite the Murlocs"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [UNG_956] Spirit Echo - COST:3 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Return _this to your hand."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritEcho_UNG_956()
		{
			// TODO SpiritEcho_UNG_956 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit Echo"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Echo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Echo"));
		}

	}

	public class WarlockUngoroTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [UNG_047] Ravenous Pterrordax - COST:4 [ATK:4/HP:4] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a friendly minion to <b>Adapt</b>_twice.
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
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavenousPterrordax_UNG_047()
		{
			// TODO RavenousPterrordax_UNG_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravenous Pterrordax"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ravenous Pterrordax"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravenous Pterrordax"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [UNG_049] Tar Lurker - COST:5 [ATK:1/HP:7] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +3 Attack during your opponent's turn.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TarLurker_UNG_049()
		{
			// TODO TarLurker_UNG_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tar Lurker"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tar Lurker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tar Lurker"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [UNG_830] Cruel Dinomancer - COST:6 [ATK:5/HP:5] 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       random minion you
		//       discarded this game.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CruelDinomancer_UNG_830()
		{
			// TODO CruelDinomancer_UNG_830 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cruel Dinomancer"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cruel Dinomancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cruel Dinomancer"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [UNG_833] Lakkari Felhound - COST:4 [ATK:3/HP:8] 
		// - Race: demon, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Discard two random cards.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - DISCARD_CARDS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LakkariFelhound_UNG_833()
		{
			// TODO LakkariFelhound_UNG_833 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lakkari Felhound"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lakkari Felhound"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lakkari Felhound"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [UNG_835] Chittering Tunneler - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a spell. Deal damage to your hero equal to its Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChitteringTunneler_UNG_835()
		{
			// TODO ChitteringTunneler_UNG_835 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chittering Tunneler"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chittering Tunneler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chittering Tunneler"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [UNG_836] Clutchmother Zavas - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you discard this, give it +2/+2 and return it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClutchmotherZavas_UNG_836()
		{
			// TODO ClutchmotherZavas_UNG_836 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clutchmother Zavas"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clutchmother Zavas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Clutchmother Zavas"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [UNG_829] Lakkari Sacrifice - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Discard 6 cards.
		//       <b>Reward:</b> Nether Portal.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 6
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LakkariSacrifice_UNG_829()
		{
			// TODO LakkariSacrifice_UNG_829 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lakkari Sacrifice"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lakkari Sacrifice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lakkari Sacrifice"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [UNG_831] Corrupting Mist - COST:2 
		// - Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Corrupt every minion. Destroy them at the start of your next turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptingMist_UNG_831()
		{
			// TODO CorruptingMist_UNG_831 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrupting Mist"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrupting Mist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corrupting Mist"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [UNG_832] Bloodbloom - COST:2 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: The next spell you cast this turn costs Health instead of Mana.
		// --------------------------------------------------------
		// Entourage: UNG_999t10, UNG_999t2, UNG_999t3, UNG_999t4, UNG_999t5, UNG_999t6, UNG_999t7, UNG_999t8, UNG_999t13, UNG_999t14
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodbloom_UNG_832()
		{
			// TODO Bloodbloom_UNG_832 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodbloom"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodbloom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodbloom"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [UNG_834] Feeding Time - COST:5 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to a minion. Summon three 1/1 Pterrordaxes. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FeedingTime_UNG_834()
		{
			// TODO FeedingTime_UNG_834 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feeding Time"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feeding Time"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feeding Time"));
		}

	}

	public class WarriorUngoroTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [UNG_838] Tar Lord - COST:7 [ATK:1/HP:11] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +4 Attack during your opponent’s turn.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TarLord_UNG_838()
		{
			// TODO TarLord_UNG_838 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tar Lord"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tar Lord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tar Lord"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [UNG_925] Ornery Direhorn - COST:6 [ATK:5/HP:5] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> <b>Adapt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OrneryDirehorn_UNG_925()
		{
			// TODO OrneryDirehorn_UNG_925 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ornery Direhorn"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ornery Direhorn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ornery Direhorn"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [UNG_926] Cornered Sentry - COST:2 [ATK:2/HP:6] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Summon three 1/1 Raptors for your_opponent.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorneredSentry_UNG_926()
		{
			// TODO CorneredSentry_UNG_926 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cornered Sentry"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cornered Sentry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cornered Sentry"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [UNG_933] King Mosh - COST:9 [ATK:9/HP:7] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all damaged minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingMosh_UNG_933()
		{
			// TODO KingMosh_UNG_933 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Mosh"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Mosh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King Mosh"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [UNG_957] Direhorn Hatchling - COST:5 [ATK:3/HP:6] 
		// - Race: beast, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Shuffle a 6/9 Direhorn with <b>Taunt</b> into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DirehornHatchling_UNG_957()
		{
			// TODO DirehornHatchling_UNG_957 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Direhorn Hatchling"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Direhorn Hatchling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Direhorn Hatchling"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [UNG_922] Explore Un'Goro - COST:2 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Replace your deck with_copies of "<b>Discover</b> a card."
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExploreUngoro_UNG_922()
		{
			// TODO ExploreUngoro_UNG_922 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explore Un'Goro"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explore Un'Goro"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explore Un'Goro"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [UNG_923] Iron Hide - COST:1 
		// - Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 5 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronHide_UNG_923()
		{
			// TODO IronHide_UNG_923 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Iron Hide"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Iron Hide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Iron Hide"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [UNG_927] Sudden Genesis - COST:5 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon copies of your damaged minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SuddenGenesis_UNG_927()
		{
			// TODO SuddenGenesis_UNG_927 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sudden Genesis"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sudden Genesis"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sudden Genesis"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [UNG_934] Fire Plume's Heart - COST:1 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Quest:</b> Play
		//       7 <b>Taunt</b> minions.
		//       <b>Reward:</b> Sulfuras.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - QUEST = 1
		// - QUEST_PROGRESS_TOTAL = 7
		// - 676 = 1
		// - 839 = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FirePlumesHeart_UNG_934()
		{
			// TODO FirePlumesHeart_UNG_934 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Plume's Heart"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Plume's Heart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire Plume's Heart"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [UNG_929] Molten Blade - COST:1 [ATK:1/HP:0] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a new weapon.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoltenBlade_UNG_929()
		{
			// TODO MoltenBlade_UNG_929 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Molten Blade"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Molten Blade"));
		}

	}

	public class NeutralUngoroTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [UNG_001] Pterrordax Hatchling - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b><b>Battlecry:</b> Adapt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PterrordaxHatchling_UNG_001()
		{
			// TODO PterrordaxHatchling_UNG_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pterrordax Hatchling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pterrordax Hatchling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pterrordax Hatchling"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_002] Volcanosaur - COST:7 [ATK:5/HP:6] 
		// - Race: beast, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Adapt</b>, then_<b>Adapt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Volcanosaur_UNG_002()
		{
			// TODO Volcanosaur_UNG_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volcanosaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanosaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volcanosaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_009] Ravasaur Runt - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control at_least 2 other minions, <b>Adapt.</b>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavasaurRunt_UNG_009()
		{
			// TODO RavasaurRunt_UNG_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravasaur Runt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ravasaur Runt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravasaur Runt"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_010] Sated Threshadon - COST:7 [ATK:5/HP:7] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon three 1/1 Murlocs.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SatedThreshadon_UNG_010()
		{
			// TODO SatedThreshadon_UNG_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sated Threshadon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sated Threshadon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sated Threshadon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_070] Tol'vir Stoneshaper - COST:4 [ATK:3/HP:5] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you played an
		//       Elemental last turn, gain
		//       _<b>Taunt</b> and <b>Divine_Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TolvirStoneshaper_UNG_070()
		{
			// TODO TolvirStoneshaper_UNG_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tol'vir Stoneshaper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tol'vir Stoneshaper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tol'vir Stoneshaper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_071] Giant Mastodon - COST:9 [ATK:6/HP:10] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantMastodon_UNG_071()
		{
			// TODO GiantMastodon_UNG_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Mastodon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Mastodon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Mastodon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_072] Stonehill Defender - COST:3 [ATK:1/HP:4] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> <b>Discover</b> a <b>Taunt</b>_minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StonehillDefender_UNG_072()
		{
			// TODO StonehillDefender_UNG_072 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonehill Defender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonehill Defender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonehill Defender"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_073] Rockpool Hunter - COST:2 [ATK:2/HP:3] 
		// - Race: murloc, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Murloc +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 14
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RockpoolHunter_UNG_073()
		{
			// TODO RockpoolHunter_UNG_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rockpool Hunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rockpool Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rockpool Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_075] Vicious Fledgling - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion attacks a_hero, <b>Adapt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ViciousFledgling_UNG_075()
		{
			// TODO ViciousFledgling_UNG_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vicious Fledgling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vicious Fledgling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vicious Fledgling"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_076] Eggnapper - COST:3 [ATK:3/HP:1] 
		// - Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 1/1 Raptors.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eggnapper_UNG_076()
		{
			// TODO Eggnapper_UNG_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eggnapper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eggnapper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eggnapper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_079] Frozen Crusher - COST:6 [ATK:8/HP:8] 
		// - Race: elemental, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion attacks, <b>Freeze</b> it.
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrozenCrusher_UNG_079()
		{
			// TODO FrozenCrusher_UNG_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frozen Crusher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frozen Crusher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frozen Crusher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_082] Thunder Lizard - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: If you played an_Elemental last turn, <b>Adapt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThunderLizard_UNG_082()
		{
			// TODO ThunderLizard_UNG_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thunder Lizard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thunder Lizard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thunder Lizard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_083] Devilsaur Egg - COST:3 [ATK:0/HP:3] 
		// - Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 5/5 Devilsaur.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DevilsaurEgg_UNG_083()
		{
			// TODO DevilsaurEgg_UNG_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devilsaur Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devilsaur Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Devilsaur Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_084] Fire Plume Phoenix - COST:4 [ATK:3/HP:3] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FirePlumePhoenix_UNG_084()
		{
			// TODO FirePlumePhoenix_UNG_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Plume Phoenix"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Plume Phoenix"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire Plume Phoenix"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_085] Emerald Hive Queen - COST:1 [ATK:2/HP:3] 
		// - Race: beast, Fac: horde, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Your minions cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmeraldHiveQueen_UNG_085()
		{
			// TODO EmeraldHiveQueen_UNG_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emerald Hive Queen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emerald Hive Queen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emerald Hive Queen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_087] Bittertide Hydra - COST:5 [ATK:8/HP:8] 
		// - Race: beast, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, deal 3 damage to_your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BittertideHydra_UNG_087()
		{
			// TODO BittertideHydra_UNG_087 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bittertide Hydra"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bittertide Hydra"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bittertide Hydra"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_088] Tortollan Primalist - COST:8 [ATK:5/HP:4] 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a spell_and cast it with random targets.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TortollanPrimalist_UNG_088()
		{
			// TODO TortollanPrimalist_UNG_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tortollan Primalist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tortollan Primalist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tortollan Primalist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_089] Gentle Megasaur - COST:4 [ATK:5/HP:4] 
		// - Race: beast, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Adapt</b> your_Murlocs.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - ADAPT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GentleMegasaur_UNG_089()
		{
			// TODO GentleMegasaur_UNG_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gentle Megasaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gentle Megasaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gentle Megasaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_099] Charged Devilsaur - COST:8 [ATK:7/HP:7] 
		// - Race: beast, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Battlecry:</b> Can't attack heroes this turn.
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChargedDevilsaur_UNG_099()
		{
			// TODO ChargedDevilsaur_UNG_099 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Charged Devilsaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charged Devilsaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Charged Devilsaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_113] Bright-Eyed Scout - COST:4 [ATK:3/HP:4] 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card. Change its Cost to (5).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrightEyedScout_UNG_113()
		{
			// TODO BrightEyedScout_UNG_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bright-Eyed Scout"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bright-Eyed Scout"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bright-Eyed Scout"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_205] Glacial Shard - COST:1 [ATK:2/HP:1] 
		// - Race: elemental, Set: ungoro, Rarity: common
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
		public void GlacialShard_UNG_205()
		{
			// TODO GlacialShard_UNG_205 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glacial Shard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glacial Shard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glacial Shard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_801] Nesting Roc - COST:5 [ATK:4/HP:7] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control at_least 2 other minions, gain <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NestingRoc_UNG_801()
		{
			// TODO NestingRoc_UNG_801 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nesting Roc"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nesting Roc"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nesting Roc"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_803] Emerald Reaver - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmeraldReaver_UNG_803()
		{
			// TODO EmeraldReaver_UNG_803 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emerald Reaver"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emerald Reaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emerald Reaver"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_806] Ultrasaur - COST:10 [ATK:7/HP:14] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ultrasaur_UNG_806()
		{
			// TODO Ultrasaur_UNG_806 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ultrasaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ultrasaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ultrasaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_807] Golakka Crawler - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a Pirate and gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 23
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GolakkaCrawler_UNG_807()
		{
			// TODO GolakkaCrawler_UNG_807 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Golakka Crawler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Golakka Crawler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Golakka Crawler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_808] Stubborn Gastropod - COST:2 [ATK:1/HP:2] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//         <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StubbornGastropod_UNG_808()
		{
			// TODO StubbornGastropod_UNG_808 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stubborn Gastropod"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stubborn Gastropod"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stubborn Gastropod"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_809] Fire Fly - COST:1 [ATK:1/HP:2] 
		// - Race: elemental, Fac: alliance, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Add a 1/2 Elemental to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireFly_UNG_809()
		{
			// TODO FireFly_UNG_809 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Fly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Fly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire Fly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_810] Stegodon - COST:4 [ATK:2/HP:6] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stegodon_UNG_810()
		{
			// TODO Stegodon_UNG_810 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stegodon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stegodon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stegodon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_812] Sabretooth Stalker - COST:6 [ATK:8/HP:2] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SabretoothStalker_UNG_812()
		{
			// TODO SabretoothStalker_UNG_812 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sabretooth Stalker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sabretooth Stalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sabretooth Stalker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_813] Stormwatcher - COST:7 [ATK:4/HP:8] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stormwatcher_UNG_813()
		{
			// TODO Stormwatcher_UNG_813 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormwatcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwatcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormwatcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_814] Giant Wasp - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//        <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantWasp_UNG_814()
		{
			// TODO GiantWasp_UNG_814 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Wasp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Wasp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Wasp"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_816] Servant of Kalimos - COST:5 [ATK:4/HP:5] 
		// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you played
		//       an Elemental last turn,
		//       _<b>Discover</b> an Elemental.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ServantOfKalimos_UNG_816()
		{
			// TODO ServantOfKalimos_UNG_816 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Servant of Kalimos"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Servant of Kalimos"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Servant of Kalimos"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_818] Volatile Elemental - COST:2 [ATK:1/HP:1] 
		// - Race: elemental, Fac: neutral, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 3 damage to a random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VolatileElemental_UNG_818()
		{
			// TODO VolatileElemental_UNG_818 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volatile Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volatile Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volatile Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_840] Hemet, Jungle Hunter - COST:6 [ATK:6/HP:6] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all cards in your deck that cost (3)_or less.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HemetJungleHunter_UNG_840()
		{
			// TODO HemetJungleHunter_UNG_840 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hemet, Jungle Hunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hemet, Jungle Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hemet, Jungle Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_843] The Voraxx - COST:4 [ATK:3/HP:3] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]After you cast a spell on
		//       this minion, summon a
		//       1/1 Plant and cast
		//       another copy on it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheVoraxx_UNG_843()
		{
			// TODO TheVoraxx_UNG_843 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Voraxx"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Voraxx"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Voraxx"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_844] Humongous Razorleaf - COST:3 [ATK:4/HP:8] 
		// - Fac: alliance, Set: ungoro, Rarity: rare
		// --------------------------------------------------------
		// Text: Can't attack.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HumongousRazorleaf_UNG_844()
		{
			// TODO HumongousRazorleaf_UNG_844 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Humongous Razorleaf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Humongous Razorleaf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Humongous Razorleaf"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_845] Igneous Elemental - COST:3 [ATK:2/HP:3] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add two 1/2 Elementals to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IgneousElemental_UNG_845()
		{
			// TODO IgneousElemental_UNG_845 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Igneous Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Igneous Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Igneous Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_847] Blazecaller - COST:7 [ATK:6/HP:6] 
		// - Race: elemental, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal 5 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blazecaller_UNG_847()
		{
			// TODO Blazecaller_UNG_847 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blazecaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blazecaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blazecaller"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_848] Primordial Drake - COST:8 [ATK:4/HP:8] 
		// - Race: dragon, Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Deal 2 damage
		//       to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimordialDrake_UNG_848()
		{
			// TODO PrimordialDrake_UNG_848 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primordial Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primordial Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primordial Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_851] Elise the Trailblazer - COST:5 [ATK:5/HP:5] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle a sealed_<b>Un'Goro</b> pack into_your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliseTheTrailblazer_UNG_851()
		{
			// TODO EliseTheTrailblazer_UNG_851 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elise the Trailblazer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elise the Trailblazer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elise the Trailblazer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_900] Spiritsinger Umbra - COST:4 [ATK:3/HP:4] 
		// - Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you summon a minion, trigger its <b>Deathrattle</b> effect.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritsingerUmbra_UNG_900()
		{
			// TODO SpiritsingerUmbra_UNG_900 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiritsinger Umbra"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiritsinger Umbra"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiritsinger Umbra"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_907] Ozruk - COST:9 [ATK:5/HP:5] 
		// - Race: elemental, Set: ungoro, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Gain +5 Health
		//       for each Elemental you
		//       played last turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ozruk_UNG_907()
		{
			// TODO Ozruk_UNG_907 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ozruk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ozruk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ozruk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_928] Tar Creeper - COST:3 [ATK:1/HP:5] 
		// - Race: elemental, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +2 Attack during your opponent's turn.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TarCreeper_UNG_928()
		{
			// TODO TarCreeper_UNG_928 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tar Creeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tar Creeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tar Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_937] Primalfin Lookout - COST:3 [ATK:3/HP:2] 
		// - Race: murloc, Set: ungoro, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control another Murloc, <b>Discover</b> a_Murloc.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalfinLookout_UNG_937()
		{
			// TODO PrimalfinLookout_UNG_937 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primalfin Lookout"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primalfin Lookout"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primalfin Lookout"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [UNG_946] Gluttonous Ooze - COST:3 [ATK:3/HP:3] 
		// - Set: ungoro, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon and gain Armor equal to its Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GluttonousOoze_UNG_946()
		{
			// TODO GluttonousOoze_UNG_946 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gluttonous Ooze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gluttonous Ooze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gluttonous Ooze"));
		}

	}

}
