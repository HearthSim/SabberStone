using Xunit;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class HeroesDragonsTest
	{
		// ----------------------------------------- HERO - WARLOCK
		// [DRG_600] Galakrond, the Wretched - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon
		//       1 random Demon.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55807
		// - 676 = 1
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheWretched_DRG_600()
		{
			// TODO GalakrondTheWretched_DRG_600 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Wretched"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Wretched"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Wretched");
		}

		// ----------------------------------------- HERO - WARLOCK
		// [DRG_600t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon
		//       2 random Demons.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55807
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheApocalypse_DRG_600t2()
		{
			// TODO GalakrondTheApocalypse_DRG_600t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Apocalypse"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Apocalypse"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Apocalypse");
		}

		// ----------------------------------------- HERO - WARLOCK
		// [DRG_600t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon
		//       4 random Demons.
		//       Equip a 5/2 Claw.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55807
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondAzerothsEnd_DRG_600t3()
		{
			// TODO GalakrondAzerothsEnd_DRG_600t3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, Azeroth's End"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, Azeroth's End"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, Azeroth's End");
		}

		// ------------------------------------------- HERO - ROGUE
		// [DRG_610] Galakrond, the Nightmare - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 1 card.
		//       It costs (0).
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55806
		// - 676 = 1
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheNightmare_DRG_610()
		{
			// TODO GalakrondTheNightmare_DRG_610 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Nightmare"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Nightmare"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Nightmare");
		}

		// ------------------------------------------- HERO - ROGUE
		// [DRG_610t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 2 cards.
		//       They cost (0).
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55806
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheApocalypse_DRG_610t2()
		{
			// TODO GalakrondTheApocalypse_DRG_610t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Apocalypse"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Apocalypse"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Apocalypse");
		}

		// ------------------------------------------- HERO - ROGUE
		// [DRG_610t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 4 cards.
		//       They cost (0).
		//       Equip a 5/2 Claw.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55806
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondAzerothsEnd_DRG_610t3()
		{
			// TODO GalakrondAzerothsEnd_DRG_610t3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, Azeroth's End"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, Azeroth's End"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, Azeroth's End");
		}

		// ------------------------------------------ HERO - SHAMAN
		// [DRG_620] Galakrond, the Tempest - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon two
		//       2/2 Storms with <b>Rush</b>.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55808
		// - 676 = 1
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheTempest_DRG_620()
		{
			// TODO GalakrondTheTempest_DRG_620 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Tempest"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Tempest"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Tempest");
		}

		// ------------------------------------------ HERO - SHAMAN
		// [DRG_620t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon two
		//       4/4 Storms with <b>Rush</b>.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55808
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheApocalypse_DRG_620t2()
		{
			// TODO GalakrondTheApocalypse_DRG_620t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Apocalypse"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Apocalypse"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Apocalypse");
		}

		// ------------------------------------------ HERO - SHAMAN
		// [DRG_620t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon two
		//       8/8 Storms with <b>Rush</b>.
		//       Equip a 5/2 Claw.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55808
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondAzerothsEnd_DRG_620t3()
		{
			// TODO GalakrondAzerothsEnd_DRG_620t3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, Azeroth's End"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, Azeroth's End"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, Azeroth's End");
		}

		// ----------------------------------------- HERO - WARRIOR
		// [DRG_650] Galakrond, the Unbreakable - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 1 minion.
		//       Give it +4/+4.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55805
		// - 676 = 1
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheUnbreakable_DRG_650()
		{
			// TODO GalakrondTheUnbreakable_DRG_650 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Unbreakable"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Unbreakable"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Unbreakable");
		}

		// ----------------------------------------- HERO - WARRIOR
		// [DRG_650t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 2 minions.
		//       Give them +4/+4.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55805
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheApocalypse_DRG_650t2()
		{
			// TODO GalakrondTheApocalypse_DRG_650t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Apocalypse"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Apocalypse"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Apocalypse");
		}

		// ----------------------------------------- HERO - WARRIOR
		// [DRG_650t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 4 minions.
		//       Give them +4/+4.
		//       Equip a 5/2 Claw.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55805
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondAzerothsEnd_DRG_650t3()
		{
			// TODO GalakrondAzerothsEnd_DRG_650t3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, Azeroth's End"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, Azeroth's End"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, Azeroth's End");
		}

		// ------------------------------------------ HERO - PRIEST
		// [DRG_660] Galakrond, the Unspeakable - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy 1
		//       random enemy minion.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55810
		// - 676 = 1
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheUnspeakable_DRG_660()
		{
			// TODO GalakrondTheUnspeakable_DRG_660 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Unspeakable"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Unspeakable"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Unspeakable");
		}

		// ------------------------------------------ HERO - PRIEST
		// [DRG_660t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy 2
		//       random enemy minions.
		//       <i>(@)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55810
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondTheApocalypse_DRG_660t2()
		{
			// TODO GalakrondTheApocalypse_DRG_660t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, the Apocalypse"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, the Apocalypse"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, the Apocalypse");
		}

		// ------------------------------------------ HERO - PRIEST
		// [DRG_660t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy 4
		//       random enemy minions.
		//       Equip a 5/2 Claw.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 55810
		// - GALAKROND_HERO_CARD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondAzerothsEnd_DRG_660t3()
		{
			// TODO GalakrondAzerothsEnd_DRG_660t3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond, Azeroth's End"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond, Azeroth's End"));
			//Hero testCard = game.ProcessCard<Hero>("Galakrond, Azeroth's End");
		}

	}

	public class HeroPowersDragonsTest
	{
		// ----------------------------------- HERO_POWER - WARRIOR
		// [DRG_238p] Galakrond's Might (*) - COST:2 
		// - Set: dragons, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your hero +3_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondsMight_DRG_238p()
		{
			// TODO GalakrondsMight_DRG_238p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond's Might"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond's Might"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Galakrond's Might");
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [DRG_238p2] Galakrond's Guile (*) - COST:2 
		// - Set: dragons, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a <b>Lackey</b> to
		//       your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondsGuile_DRG_238p2()
		{
			// TODO GalakrondsGuile_DRG_238p2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond's Guile"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond's Guile"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Galakrond's Guile");
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [DRG_238p3] Galakrond's Malice (*) - COST:2 
		// - Set: dragons, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon two 1/1 Imps.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondsMalice_DRG_238p3()
		{
			// TODO GalakrondsMalice_DRG_238p3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond's Malice"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond's Malice"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Galakrond's Malice");
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [DRG_238p4] Galakrond's Fury (*) - COST:2 
		// - Set: dragons, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 2/1 Elemental with <b>Rush</b>.
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondsFury_DRG_238p4()
		{
			// TODO GalakrondsFury_DRG_238p4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond's Fury"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond's Fury"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Galakrond's Fury");
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [DRG_238p5] Galakrond's Wit (*) - COST:2 
		// - Set: dragons, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random Priest minion to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalakrondsWit_DRG_238p5()
		{
			// TODO GalakrondsWit_DRG_238p5 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galakrond's Wit"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galakrond's Wit"));
			//Hero_power testCard = game.ProcessCard<Hero_power>("Galakrond's Wit");
		}

	}

	public class DruidDragonsTest
	{
		// ----------------------------------------- MINION - DRUID
		// [DRG_312] Shrubadier - COST:2 [ATK:1/HP:1] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/2_Treant.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shrubadier_DRG_312()
		{
			// TODO Shrubadier_DRG_312 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shrubadier"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shrubadier"));
			//Minion testCard = game.ProcessCard<Minion>("Shrubadier");
		}

		// ----------------------------------------- MINION - DRUID
		// [DRG_313] Emerald Explorer - COST:6 [ATK:4/HP:8] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmeraldExplorer_DRG_313()
		{
			// TODO EmeraldExplorer_DRG_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emerald Explorer"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emerald Explorer"));
			//Minion testCard = game.ProcessCard<Minion>("Emerald Explorer");
		}

		// ----------------------------------------- MINION - DRUID
		// [DRG_319] Goru the Mightree - COST:7 [ATK:5/HP:10] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> For the rest of
		//       the game, your Treants
		//       have +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoruTheMightree_DRG_319()
		{
			// TODO GoruTheMightree_DRG_319 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Goru the Mightree"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goru the Mightree"));
			//Minion testCard = game.ProcessCard<Minion>("Goru the Mightree");
		}

		// ----------------------------------------- MINION - DRUID
		// [DRG_320] Ysera, Unleashed - COST:9 [ATK:4/HP:12] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle 7 Dream
		//       Portals into your deck.
		//       When drawn, summon
		//       a random Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YseraUnleashed_DRG_320()
		{
			// TODO YseraUnleashed_DRG_320 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ysera, Unleashed"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ysera, Unleashed"));
			//Minion testCard = game.ProcessCard<Minion>("Ysera, Unleashed");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_051] Strength in Numbers - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Sidequest:</b> Spend 10 Mana on minions.
		//       <b>Reward:</b> Summon a minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 10
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StrengthInNumbers_DRG_051()
		{
			// TODO StrengthInNumbers_DRG_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Strength in Numbers"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Strength in Numbers"));
			//Spell testCard = game.ProcessCard<Spell>("Strength in Numbers");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_311] Treenforcements - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Give a
		//       minion +2 Health and
		//       <b>Taunt</b>; or Summon a
		//       2/2 Treant.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Treenforcements_DRG_311()
		{
			// TODO Treenforcements_DRG_311 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Treenforcements"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Treenforcements"));
			//Spell testCard = game.ProcessCard<Spell>("Treenforcements");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_314] Aeroponics - COST:5 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw 2 cards.
		//       Costs (2) less for each Treant you control.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Aeroponics_DRG_314()
		{
			// TODO Aeroponics_DRG_314 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aeroponics"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aeroponics"));
			//Spell testCard = game.ProcessCard<Spell>("Aeroponics");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_315] Embiggen - COST:0 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Give all minions in your deck +2/+2. They cost (1) more <i>(up to 10)</i>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Embiggen_DRG_315()
		{
			// TODO Embiggen_DRG_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Embiggen"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embiggen"));
			//Spell testCard = game.ProcessCard<Spell>("Embiggen");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_317] Secure the Deck - COST:1 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Sidequest:</b> Attack twice with your hero. <b>Reward:</b> Add 3 'Claw' spells to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 2
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SecureTheDeck_DRG_317()
		{
			// TODO SecureTheDeck_DRG_317 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Secure the Deck"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secure the Deck"));
			//Spell testCard = game.ProcessCard<Spell>("Secure the Deck");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DRG_318] Breath of Dreams - COST:2 
		// - Fac: neutral, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card. If you're holding a Dragon, gain an empty Mana Crystal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BreathOfDreams_DRG_318()
		{
			// TODO BreathOfDreams_DRG_318 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Breath of Dreams"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Breath of Dreams"));
			//Spell testCard = game.ProcessCard<Spell>("Breath of Dreams");
		}

	}

	public class HunterDragonsTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [DRG_010] Diving Gryphon - COST:3 [ATK:4/HP:1] 
		// - Race: beast, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> Draw a <b>Rush</b> minion_from_your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivingGryphon_DRG_010()
		{
			// TODO DivingGryphon_DRG_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Diving Gryphon"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Diving Gryphon"));
			//Minion testCard = game.ProcessCard<Minion>("Diving Gryphon");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DRG_095] Veranus - COST:6 [ATK:7/HP:6] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Change the Health of all enemy minions to 1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Veranus_DRG_095()
		{
			// TODO Veranus_DRG_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Veranus"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Veranus"));
			//Minion testCard = game.ProcessCard<Minion>("Veranus");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DRG_252] Phase Stalker - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you use your Hero
		//       Power, cast a <b>Secret</b>
		//       from your deck.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PhaseStalker_DRG_252()
		{
			// TODO PhaseStalker_DRG_252 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Phase Stalker"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phase Stalker"));
			//Minion testCard = game.ProcessCard<Minion>("Phase Stalker");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DRG_253] Dwarven Sharpshooter - COST:1 [ATK:1/HP:3] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Your Hero Power can target_minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DwarvenSharpshooter_DRG_253()
		{
			// TODO DwarvenSharpshooter_DRG_253 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dwarven Sharpshooter"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dwarven Sharpshooter"));
			//Minion testCard = game.ProcessCard<Minion>("Dwarven Sharpshooter");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DRG_254] Primordial Explorer - COST:3 [ATK:2/HP:3] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - POISONOUS = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimordialExplorer_DRG_254()
		{
			// TODO PrimordialExplorer_DRG_254 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primordial Explorer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primordial Explorer"));
			//Minion testCard = game.ProcessCard<Minion>("Primordial Explorer");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DRG_256] Dragonbane - COST:4 [ATK:3/HP:5] 
		// - Race: mechanical, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you use your Hero Power, deal 5 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragonbane_DRG_256()
		{
			// TODO Dragonbane_DRG_256 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonbane"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonbane"));
			//Minion testCard = game.ProcessCard<Minion>("Dragonbane");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DRG_006] Corrosive Breath - COST:2 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Deal $3 damage to a
		//       minion. If you're holding
		//       a Dragon, it also hits
		//       the enemy hero. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorrosiveBreath_DRG_006()
		{
			// TODO CorrosiveBreath_DRG_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrosive Breath"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrosive Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Corrosive Breath");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DRG_251] Clear the Way - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Sidequest:</b> Summon
		//       3 <b>Rush</b> minions.
		//       <b>Reward:</b> Summon a
		//       4/4 Gryphon with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 3
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClearTheWay_DRG_251()
		{
			// TODO ClearTheWay_DRG_251 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clear the Way"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clear the Way"));
			//Spell testCard = game.ProcessCard<Spell>("Clear the Way");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DRG_255] Toxic Reinforcements - COST:1 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Sidequest:</b> Use your Hero
		//       Power three times.
		//       <b>Reward:</b> Summon three
		//       1/1 Leper Gnomes.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 3
		// - QUEST_REWARD_DATABASE_ID = 41127
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToxicReinforcements_DRG_255()
		{
			// TODO ToxicReinforcements_DRG_255 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxic Reinforcements"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxic Reinforcements"));
			//Spell testCard = game.ProcessCard<Spell>("Toxic Reinforcements");
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [DRG_007] Stormhammer - COST:3 [ATK:3/HP:0] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Doesn't lose Durability while you control a_Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stormhammer_DRG_007()
		{
			// TODO Stormhammer_DRG_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormhammer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormhammer"));
			//Weapon testCard = game.ProcessCard<Weapon>("Stormhammer");
		}

	}

	public class MageDragonsTest
	{
		// ------------------------------------------ MINION - MAGE
		// [DRG_102] Azure Explorer - COST:4 [ATK:2/HP:3] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzureExplorer_DRG_102()
		{
			// TODO AzureExplorer_DRG_102 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Explorer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azure Explorer"));
			//Minion testCard = game.ProcessCard<Minion>("Azure Explorer");
		}

		// ------------------------------------------ MINION - MAGE
		// [DRG_104] Chenvaala - COST:3 [ATK:2/HP:5] 
		// - Race: elemental, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast three spells in a turn, summon a 5/5_Elemental.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chenvaala_DRG_104()
		{
			// TODO Chenvaala_DRG_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chenvaala"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chenvaala"));
			//Minion testCard = game.ProcessCard<Minion>("Chenvaala");
		}

		// ------------------------------------------ MINION - MAGE
		// [DRG_107] Violet Spellwing - COST:1 [ATK:1/HP:1] 
		// - Race: elemental, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add an 'Arcane Missiles' spell to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletSpellwing_DRG_107()
		{
			// TODO VioletSpellwing_DRG_107 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Spellwing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Spellwing"));
			//Minion testCard = game.ProcessCard<Minion>("Violet Spellwing");
		}

		// ------------------------------------------ MINION - MAGE
		// [DRG_109] Mana Giant - COST:8 [ATK:8/HP:8] 
		// - Race: elemental, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Costs (1) less for each
		//       card you've played this
		//       game that didn't start
		//       in your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaGiant_DRG_109()
		{
			// TODO ManaGiant_DRG_109 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Giant"));
			//Minion testCard = game.ProcessCard<Minion>("Mana Giant");
		}

		// ------------------------------------------ MINION - MAGE
		// [DRG_270] Malygos, Aspect of Magic - COST:5 [ATK:2/HP:8] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       a Dragon, <b>Discover</b> an
		//        upgraded Mage spell.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MalygosAspectOfMagic_DRG_270()
		{
			// TODO MalygosAspectOfMagic_DRG_270 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malygos, Aspect of Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malygos, Aspect of Magic"));
			//Minion testCard = game.ProcessCard<Minion>("Malygos, Aspect of Magic");
		}

		// ------------------------------------------ MINION - MAGE
		// [DRG_322] Dragoncaster - COST:6 [ATK:4/HP:4] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, your next spell this turn costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragoncaster_DRG_322()
		{
			// TODO Dragoncaster_DRG_322 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragoncaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragoncaster"));
			//Minion testCard = game.ProcessCard<Minion>("Dragoncaster");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DRG_106] Arcane Breath - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If you're holding a Dragon, <b>Discover</b> a spell. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneBreath_DRG_106()
		{
			// TODO ArcaneBreath_DRG_106 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Arcane Breath");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DRG_321] Rolling Fireball - COST:5 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $8 damage to a minion. Any excess damage continues to
		//       the left or right. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RollingFireball_DRG_321()
		{
			// TODO RollingFireball_DRG_321 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rolling Fireball"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rolling Fireball"));
			//Spell testCard = game.ProcessCard<Spell>("Rolling Fireball");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DRG_323] Learn Draconic - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Sidequest:</b> Spend
		//       8 Mana on spells.
		//       <b>Reward:</b> Summon a
		//       6/6 Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 8
		// - QUEST_REWARD_DATABASE_ID = 55282
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LearnDraconic_DRG_323()
		{
			// TODO LearnDraconic_DRG_323 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Learn Draconic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Learn Draconic"));
			//Spell testCard = game.ProcessCard<Spell>("Learn Draconic");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DRG_324] Elemental Allies - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Sidequest:</b> Play an
		//       Elemental 2 turns in a row.
		//       <b>Reward:</b> Draw 3 spells
		//       from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 2
		// - QUEST_REWARD_DATABASE_ID = 395
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElementalAllies_DRG_324()
		{
			// TODO ElementalAllies_DRG_324 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elemental Allies"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elemental Allies"));
			//Spell testCard = game.ProcessCard<Spell>("Elemental Allies");
		}

	}

	public class PaladinDragonsTest
	{
		// --------------------------------------- MINION - PALADIN
		// [DRG_225] Sky Claw - COST:3 [ATK:1/HP:2] 
		// - Race: mechanical, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Your other Mechs
		//       have +1 Attack.
		//       <b>Battlecry:</b> Summon two 1/1 Microcopters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkyClaw_DRG_225()
		{
			// TODO SkyClaw_DRG_225 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sky Claw"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sky Claw"));
			//Minion testCard = game.ProcessCard<Minion>("Sky Claw");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_226] Amber Watcher - COST:5 [ATK:4/HP:6] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore #8_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AmberWatcher_DRG_226()
		{
			// TODO AmberWatcher_DRG_226 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Amber Watcher"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Amber Watcher"));
			//Minion testCard = game.ProcessCard<Minion>("Amber Watcher");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_229] Bronze Explorer - COST:3 [ATK:2/HP:3] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - LIFESTEAL = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BronzeExplorer_DRG_229()
		{
			// TODO BronzeExplorer_DRG_229 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bronze Explorer"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bronze Explorer"));
			//Minion testCard = game.ProcessCard<Minion>("Bronze Explorer");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_231] Lightforged Crusader - COST:7 [ATK:7/HP:7] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck
		//       has no Neutral cards,
		//       add 5 random Paladin
		//       cards to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightforgedCrusader_DRG_231()
		{
			// TODO LightforgedCrusader_DRG_231 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightforged Crusader"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightforged Crusader"));
			//Minion testCard = game.ProcessCard<Minion>("Lightforged Crusader");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_232] Lightforged Zealot - COST:4 [ATK:4/HP:2] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no Neutral cards, equip a __4/2_Truesilver_Champion._
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightforgedZealot_DRG_232()
		{
			// TODO LightforgedZealot_DRG_232 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightforged Zealot"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightforged Zealot"));
			//Minion testCard = game.ProcessCard<Minion>("Lightforged Zealot");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_235] Dragonrider Talritha - COST:3 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a Dragon in your hand +3/+3 and this <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonriderTalritha_DRG_235()
		{
			// TODO DragonriderTalritha_DRG_235 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonrider Talritha"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonrider Talritha"));
			//Minion testCard = game.ProcessCard<Minion>("Dragonrider Talritha");
		}

		// --------------------------------------- MINION - PALADIN
		// [DRG_309] Nozdormu the Timeless - COST:4 [ATK:8/HP:8] 
		// - Race: dragon, Fac: neutral, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Set each player to 10 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NozdormuTheTimeless_DRG_309()
		{
			// TODO NozdormuTheTimeless_DRG_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nozdormu the Timeless"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nozdormu the Timeless"));
			//Minion testCard = game.ProcessCard<Minion>("Nozdormu the Timeless");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DRG_008] Righteous Cause - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Sidequest:</b> Summon 5 minions.
		//       <b>Reward:</b> Give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 5
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RighteousCause_DRG_008()
		{
			// TODO RighteousCause_DRG_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Righteous Cause"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Righteous Cause"));
			//Spell testCard = game.ProcessCard<Spell>("Righteous Cause");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DRG_233] Sand Breath - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Give a minion +1/+2.
		//       Give it <b>Divine Shield</b> if
		//       you're holding a Dragon.
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SandBreath_DRG_233()
		{
			// TODO SandBreath_DRG_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sand Breath"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sand Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Sand Breath");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DRG_258] Sanctuary - COST:2 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Sidequest:</b> Take no
		//       damage for a turn.
		//       <b>Reward:</b> Summon a 3/6
		//       minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - QUEST_PROGRESS_TOTAL = 1
		// - QUEST_REWARD_DATABASE_ID = 57723
		// - SIDEQUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sanctuary_DRG_258()
		{
			// TODO Sanctuary_DRG_258 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sanctuary"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sanctuary"));
			//Spell testCard = game.ProcessCard<Spell>("Sanctuary");
		}

	}

	public class PriestDragonsTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [DRG_090] Murozond the Infinite - COST:8 [ATK:8/HP:8] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Play all cards your opponent played last_turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurozondTheInfinite_DRG_090()
		{
			// TODO MurozondTheInfinite_DRG_090 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murozond the Infinite"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murozond the Infinite"));
			//Minion testCard = game.ProcessCard<Minion>("Murozond the Infinite");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DRG_300] Fate Weaver - COST:4 [ATK:3/HP:6] 
		// - Race: dragon, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
		//       twice, reduce the Cost of
		//       cards in your hand by (1).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// --------------------------------------------------------
		// RefTag:
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FateWeaver_DRG_300()
		{
			// TODO FateWeaver_DRG_300 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fate Weaver"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fate Weaver"));
			//Minion testCard = game.ProcessCard<Minion>("Fate Weaver");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DRG_303] Disciple of Galakrond - COST:1 [ATK:1/HP:2] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DiscipleOfGalakrond_DRG_303()
		{
			// TODO DiscipleOfGalakrond_DRG_303 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Disciple of Galakrond"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of Galakrond"));
			//Minion testCard = game.ProcessCard<Minion>("Disciple of Galakrond");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DRG_304] Chronobreaker - COST:5 [ATK:4/HP:5] 
		// - Race: dragon, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> If you're holding
		//       a Dragon, deal 3 damage
		//       to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chronobreaker_DRG_304()
		{
			// TODO Chronobreaker_DRG_304 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chronobreaker"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chronobreaker"));
			//Minion testCard = game.ProcessCard<Minion>("Chronobreaker");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DRG_306] Envoy of Lazul - COST:2 [ATK:2/HP:2] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Look at 3 cards.
		//       Guess which one is in
		//       your opponent's hand
		//       to get a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnvoyOfLazul_DRG_306()
		{
			// TODO EnvoyOfLazul_DRG_306 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Envoy of Lazul"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Envoy of Lazul"));
			//Minion testCard = game.ProcessCard<Minion>("Envoy of Lazul");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DRG_308] Mindflayer Kaahrj - COST:3 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose an
		//       enemy minion.
		//       <b>Deathrattle:</b> Summon a new copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindflayerKaahrj_DRG_308()
		{
			// TODO MindflayerKaahrj_DRG_308 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mindflayer Kaahrj"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mindflayer Kaahrj"));
			//Minion testCard = game.ProcessCard<Minion>("Mindflayer Kaahrj");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DRG_246] Time Rip - COST:5 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a minion.
		//       <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TimeRip_DRG_246()
		{
			// TODO TimeRip_DRG_246 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Time Rip"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Time Rip"));
			//Spell testCard = game.ProcessCard<Spell>("Time Rip");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DRG_301] Whispers of EVIL - COST:0 
		// - Fac: neutral, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Add a <b>Lackey</b> to your_hand.
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhispersOfEvil_DRG_301()
		{
			// TODO WhispersOfEvil_DRG_301 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whispers of EVIL"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whispers of EVIL"));
			//Spell testCard = game.ProcessCard<Spell>("Whispers of EVIL");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DRG_302] Grave Rune - COST:4 
		// - Fac: neutral, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Summon 2 copies of this."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GraveRune_DRG_302()
		{
			// TODO GraveRune_DRG_302 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grave Rune"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grave Rune"));
			//Spell testCard = game.ProcessCard<Spell>("Grave Rune");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DRG_307] Breath of the Infinite - COST:3 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to all minions. If you're holding a Dragon, only damage enemies. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BreathOfTheInfinite_DRG_307()
		{
			// TODO BreathOfTheInfinite_DRG_307 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Breath of the Infinite"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Breath of the Infinite"));
			//Spell testCard = game.ProcessCard<Spell>("Breath of the Infinite");
		}

	}

	public class RogueDragonsTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [DRG_027] Umbral Skulker - COST:4 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
		//       twice, add 3 Coins to
		//       your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// --------------------------------------------------------
		// RefTag:
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UmbralSkulker_DRG_027()
		{
			// TODO UmbralSkulker_DRG_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Umbral Skulker"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Umbral Skulker"));
			//Minion testCard = game.ProcessCard<Minion>("Umbral Skulker");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DRG_031] Necrium Apothecary - COST:4 [ATK:2/HP:5] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Draw a <b>Deathrattle</b> minion from your deck and gain its <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecriumApothecary_DRG_031()
		{
			// TODO NecriumApothecary_DRG_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrium Apothecary"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrium Apothecary"));
			//Minion testCard = game.ProcessCard<Minion>("Necrium Apothecary");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DRG_034] Stowaway - COST:5 [ATK:4/HP:4] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If there are cards
		//       in your deck that didn't start
		//       there, draw 2 of them.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stowaway_DRG_034()
		{
			// TODO Stowaway_DRG_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stowaway"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stowaway"));
			//Minion testCard = game.ProcessCard<Minion>("Stowaway");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DRG_035] Bloodsail Flybooter - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add two 1/1 Pirates to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodsailFlybooter_DRG_035()
		{
			// TODO BloodsailFlybooter_DRG_035 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsail Flybooter"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Flybooter"));
			//Minion testCard = game.ProcessCard<Minion>("Bloodsail Flybooter");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DRG_036] Waxadred - COST:5 [ATK:7/HP:5] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Shuffle a
		//       Candle into your deck that
		//       resummons Waxadred
		//       when drawn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Waxadred_DRG_036()
		{
			// TODO Waxadred_DRG_036 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Waxadred"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Waxadred"));
			//Minion testCard = game.ProcessCard<Minion>("Waxadred");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DRG_037] Flik Skyshiv - COST:6 [ATK:4/HP:4] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy a
		//       minion and all copies of it
		//       <i>(wherever they are)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlikSkyshiv_DRG_037()
		{
			// TODO FlikSkyshiv_DRG_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flik Skyshiv"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flik Skyshiv"));
			//Minion testCard = game.ProcessCard<Minion>("Flik Skyshiv");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DRG_028] Dragon's Hoard - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Legendary</b>_minion from another class.
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonsHoard_DRG_028()
		{
			// TODO DragonsHoard_DRG_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon's Hoard"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Hoard"));
			//Spell testCard = game.ProcessCard<Spell>("Dragon's Hoard");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DRG_030] Praise Galakrond! - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Give a minion +1 Attack.
		//       <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PraiseGalakrond_DRG_030()
		{
			// TODO PraiseGalakrond_DRG_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Praise Galakrond!"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Praise Galakrond!"));
			//Spell testCard = game.ProcessCard<Spell>("Praise Galakrond!");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DRG_033] Candle Breath - COST:6 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 3 cards. Costs (3)_less while you're holding a Dragon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CandleBreath_DRG_033()
		{
			// TODO CandleBreath_DRG_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candle Breath"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candle Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Candle Breath");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DRG_247] Seal Fate - COST:3 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to an undamaged character. <b>Invoke</b> Galakrond. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SealFate_DRG_247()
		{
			// TODO SealFate_DRG_247 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seal Fate"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seal Fate"));
			//Spell testCard = game.ProcessCard<Spell>("Seal Fate");
		}

	}

	public class ShamanDragonsTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [DRG_096] Bandersmosh - COST:5 [ATK:5/HP:5] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Each turn this is in your
		//       hand, transform it into a
		//       5/5 copy of a random
		//       <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bandersmosh_DRG_096()
		{
			// TODO Bandersmosh_DRG_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bandersmosh"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bandersmosh"));
			//Minion testCard = game.ProcessCard<Minion>("Bandersmosh");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DRG_211] Squallhunter - COST:4 [ATK:5/HP:7] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		//       <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// - OVERLOAD = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Squallhunter_DRG_211()
		{
			// TODO Squallhunter_DRG_211 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Squallhunter"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Squallhunter"));
			//Minion testCard = game.ProcessCard<Minion>("Squallhunter");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DRG_216] Surging Tempest - COST:1 [ATK:1/HP:3] 
		// - Race: elemental, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Has +1 Attack while you_have <b>Overloaded</b> Mana Crystals.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SurgingTempest_DRG_216()
		{
			// TODO SurgingTempest_DRG_216 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Surging Tempest"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Surging Tempest"));
			//Minion testCard = game.ProcessCard<Minion>("Surging Tempest");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DRG_218] Corrupt Elementalist - COST:5 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond twice.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptElementalist_DRG_218()
		{
			// TODO CorruptElementalist_DRG_218 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrupt Elementalist"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrupt Elementalist"));
			//Minion testCard = game.ProcessCard<Minion>("Corrupt Elementalist");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DRG_223] Cumulo-Maximus - COST:5 [ATK:5/HP:5] 
		// - Race: elemental, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have <b>Overloaded</b> Mana Crystals, deal 5 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CumuloMaximus_DRG_223()
		{
			// TODO CumuloMaximus_DRG_223 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cumulo-Maximus"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cumulo-Maximus"));
			//Minion testCard = game.ProcessCard<Minion>("Cumulo-Maximus");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DRG_224] Nithogg - COST:6 [ATK:5/HP:5] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon two
		//       0/3 Eggs. Next turn they
		//       hatch into 4/4 Drakes
		//       with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nithogg_DRG_224()
		{
			// TODO Nithogg_DRG_224 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nithogg"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nithogg"));
			//Minion testCard = game.ProcessCard<Minion>("Nithogg");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DRG_215] Storm's Wrath - COST:1 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions +1/+1.
		//       <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormsWrath_DRG_215()
		{
			// TODO StormsWrath_DRG_215 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Storm's Wrath"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Storm's Wrath"));
			//Spell testCard = game.ProcessCard<Spell>("Storm's Wrath");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DRG_217] Dragon's Pack - COST:5 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon two 2/3 Spirit Wolves with <b>Taunt</b>. If you've <b>Invoked</b> twice, give them +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonsPack_DRG_217()
		{
			// TODO DragonsPack_DRG_217 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon's Pack"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Pack"));
			//Spell testCard = game.ProcessCard<Spell>("Dragon's Pack");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DRG_219] Lightning Breath - COST:3 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Deal $4 damage to a
		//       minion. If you're holding
		//       a Dragon, also damage
		//       its neighbors. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightningBreath_DRG_219()
		{
			// TODO LightningBreath_DRG_219 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightning Breath"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Lightning Breath");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DRG_248] Invocation of Frost - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> an enemy. 
		//       <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InvocationOfFrost_DRG_248()
		{
			// TODO InvocationOfFrost_DRG_248 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Invocation of Frost"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Invocation of Frost"));
			//Spell testCard = game.ProcessCard<Spell>("Invocation of Frost");
		}

	}

	public class WarlockDragonsTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [DRG_201] Crazed Netherwing - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Fac: neutral, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding
		//       a Dragon, deal 3 damage to all other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrazedNetherwing_DRG_201()
		{
			// TODO CrazedNetherwing_DRG_201 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crazed Netherwing"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crazed Netherwing"));
			//Minion testCard = game.ProcessCard<Minion>("Crazed Netherwing");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DRG_202] Dragonblight Cultist - COST:3 [ATK:1/HP:1] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Invoke</b> Galakrond.
		//       Gain +1 Attack for each
		//       other friendly minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonblightCultist_DRG_202()
		{
			// TODO DragonblightCultist_DRG_202 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonblight Cultist"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonblight Cultist"));
			//Minion testCard = game.ProcessCard<Minion>("Dragonblight Cultist");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DRG_203] Veiled Worshipper - COST:4 [ATK:5/HP:4] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
		//       twice, draw 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// --------------------------------------------------------
		// RefTag:
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VeiledWorshipper_DRG_203()
		{
			// TODO VeiledWorshipper_DRG_203 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Veiled Worshipper"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Veiled Worshipper"));
			//Minion testCard = game.ProcessCard<Minion>("Veiled Worshipper");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DRG_207] Abyssal Summoner - COST:6 [ATK:2/HP:2] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       Demon with <b>Taunt</b> and stats
		//       equal to your hand size.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AbyssalSummoner_DRG_207()
		{
			// TODO AbyssalSummoner_DRG_207 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Abyssal Summoner"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abyssal Summoner"));
			//Minion testCard = game.ProcessCard<Minion>("Abyssal Summoner");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DRG_208] Valdris Felgorge - COST:7 [ATK:4/HP:4] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Increase your maximum hand size to 12. Draw 4 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValdrisFelgorge_DRG_208()
		{
			// TODO ValdrisFelgorge_DRG_208 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Valdris Felgorge"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Valdris Felgorge"));
			//Minion testCard = game.ProcessCard<Minion>("Valdris Felgorge");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DRG_209] Zzeraku the Warped - COST:8 [ATK:4/HP:12] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever your hero
		//       takes damage, summon
		//       a 6/6 Nether Drake.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZzerakuTheWarped_DRG_209()
		{
			// TODO ZzerakuTheWarped_DRG_209 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zzeraku the Warped"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zzeraku the Warped"));
			//Minion testCard = game.ProcessCard<Minion>("Zzeraku the Warped");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DRG_204] Dark Skies - COST:3 
		// - Fac: neutral, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $1 damage to a
		//       random minion. Repeat
		//       for each card in your hand. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkSkies_DRG_204()
		{
			// TODO DarkSkies_DRG_204 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Skies"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Skies"));
			//Spell testCard = game.ProcessCard<Spell>("Dark Skies");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DRG_205] Nether Breath - COST:2 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage.
		//       If you're holding a Dragon, deal $4 damage with <b>Lifesteal</b> instead. @spelldmg
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherBreath_DRG_205()
		{
			// TODO NetherBreath_DRG_205 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nether Breath"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nether Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Nether Breath");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DRG_206] Rain of Fire - COST:1 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to all_characters. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfFire_DRG_206()
		{
			// TODO RainOfFire_DRG_206 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Fire"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Fire"));
			//Spell testCard = game.ProcessCard<Spell>("Rain of Fire");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DRG_250] Fiendish Rites - COST:3 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Invoke</b> Galakrond.
		//       Give your minions +1_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FiendishRites_DRG_250()
		{
			// TODO FiendishRites_DRG_250 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fiendish Rites"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiendish Rites"));
			//Spell testCard = game.ProcessCard<Spell>("Fiendish Rites");
		}

	}

	public class WarriorDragonsTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [DRG_019] Scion of Ruin - COST:3 [ATK:3/HP:2] 
		// - Race: dragon, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Rush</b>. <b>Battlecry:</b> If you've <b>Invoked</b> twice, summon 2_copies of this.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// - RUSH = 1
		// --------------------------------------------------------
		// RefTag:
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScionOfRuin_DRG_019()
		{
			// TODO ScionOfRuin_DRG_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scion of Ruin"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scion of Ruin"));
			//Minion testCard = game.ProcessCard<Minion>("Scion of Ruin");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DRG_020] EVIL Quartermaster - COST:3 [ATK:2/HP:3] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to your hand. Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilQuartermaster_DRG_020()
		{
			// TODO EvilQuartermaster_DRG_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Quartermaster"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Quartermaster"));
			//Minion testCard = game.ProcessCard<Minion>("EVIL Quartermaster");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DRG_023] Skybarge - COST:3 [ATK:2/HP:5] 
		// - Race: mechanical, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you summon a
		//       Pirate, deal 2 damage
		//       to a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skybarge_DRG_023()
		{
			// TODO Skybarge_DRG_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skybarge"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skybarge"));
			//Minion testCard = game.ProcessCard<Minion>("Skybarge");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DRG_024] Sky Raider - COST:1 [ATK:1/HP:2] 
		// - Race: pirate, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Pirate to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkyRaider_DRG_024()
		{
			// TODO SkyRaider_DRG_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sky Raider"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sky Raider"));
			//Minion testCard = game.ProcessCard<Minion>("Sky Raider");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DRG_026] Deathwing, Mad Aspect - COST:8 [ATK:12/HP:12] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Attack ALL
		//       other minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathwingMadAspect_DRG_026()
		{
			// TODO DeathwingMadAspect_DRG_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathwing, Mad Aspect"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathwing, Mad Aspect"));
			//Minion testCard = game.ProcessCard<Minion>("Deathwing, Mad Aspect");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DRG_022] Ramming Speed - COST:3 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Force a minion to attack one of its neighbors.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RammingSpeed_DRG_022()
		{
			// TODO RammingSpeed_DRG_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ramming Speed"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ramming Speed"));
			//Spell testCard = game.ProcessCard<Spell>("Ramming Speed");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DRG_249] Awaken! - COST:3 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Invoke</b> Galakrond. Deal_$1 damage to all_minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Awaken_DRG_249()
		{
			// TODO Awaken_DRG_249 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Awaken!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Awaken!"));
			//Spell testCard = game.ProcessCard<Spell>("Awaken!");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DRG_500] Molten Breath - COST:4 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage to a
		//       minion. If you're holding
		//       a Dragon, gain 5 Armor. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoltenBreath_DRG_500()
		{
			// TODO MoltenBreath_DRG_500 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Molten Breath"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Breath"));
			//Spell testCard = game.ProcessCard<Spell>("Molten Breath");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [DRG_021] Ritual Chopper - COST:2 [ATK:1/HP:0] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RitualChopper_DRG_021()
		{
			// TODO RitualChopper_DRG_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ritual Chopper"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ritual Chopper"));
			//Weapon testCard = game.ProcessCard<Weapon>("Ritual Chopper");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [DRG_025] Ancharrr - COST:3 [ATK:2/HP:0] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks, draw a Pirate from your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ancharrr_DRG_025()
		{
			// TODO Ancharrr_DRG_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancharrr"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancharrr"));
			//Weapon testCard = game.ProcessCard<Weapon>("Ancharrr");
		}

	}

	public class NeutralDragonsTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [DRG_049] Tasty Flyfish - COST:2 [ATK:2/HP:2] 
		// - Race: murloc, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a Dragon in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TastyFlyfish_DRG_049()
		{
			// TODO TastyFlyfish_DRG_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tasty Flyfish"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tasty Flyfish"));
			//Minion testCard = game.ProcessCard<Minion>("Tasty Flyfish");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_050] Devoted Maniac - COST:4 [ATK:2/HP:2] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - 676 = 1
		// - RUSH = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DevotedManiac_DRG_050()
		{
			// TODO DevotedManiac_DRG_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devoted Maniac"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devoted Maniac"));
			//Minion testCard = game.ProcessCard<Minion>("Devoted Maniac");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_054] Big Ol' Whelp - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigOlWhelp_DRG_054()
		{
			// TODO BigOlWhelp_DRG_054 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Ol' Whelp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Ol' Whelp"));
			//Minion testCard = game.ProcessCard<Minion>("Big Ol' Whelp");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_055] Hoard Pillager - COST:4 [ATK:4/HP:2] 
		// - Race: pirate, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip one of your destroyed weapons.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoardPillager_DRG_055()
		{
			// TODO HoardPillager_DRG_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hoard Pillager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hoard Pillager"));
			//Minion testCard = game.ProcessCard<Minion>("Hoard Pillager");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_056] Parachute Brigand - COST:2 [ATK:2/HP:2] 
		// - Race: pirate, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: [x]After you play a Pirate,
		//       summon this minion
		//       from your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ParachuteBrigand_DRG_056()
		{
			// TODO ParachuteBrigand_DRG_056 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Parachute Brigand"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Parachute Brigand"));
			//Minion testCard = game.ProcessCard<Minion>("Parachute Brigand");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_057] Hot Air Balloon - COST:1 [ATK:1/HP:2] 
		// - Race: mechanical, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, gain +1 Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HotAirBalloon_DRG_057()
		{
			// TODO HotAirBalloon_DRG_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hot Air Balloon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hot Air Balloon"));
			//Minion testCard = game.ProcessCard<Minion>("Hot Air Balloon");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_058] Wing Commander - COST:4 [ATK:2/HP:5] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Has +2 Attack for each Dragon in your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WingCommander_DRG_058()
		{
			// TODO WingCommander_DRG_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wing Commander"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wing Commander"));
			//Minion testCard = game.ProcessCard<Minion>("Wing Commander");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_059] Goboglide Tech - COST:3 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a_Mech, gain +1/+1 and_<b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoboglideTech_DRG_059()
		{
			// TODO GoboglideTech_DRG_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Goboglide Tech"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goboglide Tech"));
			//Minion testCard = game.ProcessCard<Minion>("Goboglide Tech");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_060] Fire Hawk - COST:3 [ATK:1/HP:3] 
		// - Race: elemental, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1 Attack for each card in your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireHawk_DRG_060()
		{
			// TODO FireHawk_DRG_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Hawk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Hawk"));
			//Minion testCard = game.ProcessCard<Minion>("Fire Hawk");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_061] Gyrocopter - COST:6 [ATK:4/HP:5] 
		// - Race: mechanical, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gyrocopter_DRG_061()
		{
			// TODO Gyrocopter_DRG_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gyrocopter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gyrocopter"));
			//Minion testCard = game.ProcessCard<Minion>("Gyrocopter");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_062] Wyrmrest Purifier - COST:2 [ATK:3/HP:2] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Transform all
		//       Neutral cards in your deck
		//       into random cards from
		//       your class.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WyrmrestPurifier_DRG_062()
		{
			// TODO WyrmrestPurifier_DRG_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wyrmrest Purifier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wyrmrest Purifier"));
			//Minion testCard = game.ProcessCard<Minion>("Wyrmrest Purifier");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_063] Dragonmaw Poacher - COST:4 [ATK:4/HP:4] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your opponent controls a Dragon, gain +4/+4 and <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonmawPoacher_DRG_063()
		{
			// TODO DragonmawPoacher_DRG_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonmaw Poacher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonmaw Poacher"));
			//Minion testCard = game.ProcessCard<Minion>("Dragonmaw Poacher");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_064] Zul'Drak Ritualist - COST:4 [ATK:3/HP:9] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//        <b>Battlecry:</b> Summon three
		//       random 1-Cost minions
		//       for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZuldrakRitualist_DRG_064()
		{
			// TODO ZuldrakRitualist_DRG_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zul'Drak Ritualist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zul'Drak Ritualist"));
			//Minion testCard = game.ProcessCard<Minion>("Zul'Drak Ritualist");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_065] Hippogryph - COST:4 [ATK:2/HP:6] 
		// - Race: beast, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hippogryph_DRG_065()
		{
			// TODO Hippogryph_DRG_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hippogryph"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hippogryph"));
			//Minion testCard = game.ProcessCard<Minion>("Hippogryph");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_066] Evasive Chimaera - COST:2 [ATK:2/HP:1] 
		// - Race: beast, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvasiveChimaera_DRG_066()
		{
			// TODO EvasiveChimaera_DRG_066 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasive Chimaera"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasive Chimaera"));
			//Minion testCard = game.ProcessCard<Minion>("Evasive Chimaera");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_067] Troll Batrider - COST:4 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to a random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrollBatrider_DRG_067()
		{
			// TODO TrollBatrider_DRG_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Troll Batrider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Troll Batrider"));
			//Minion testCard = game.ProcessCard<Minion>("Troll Batrider");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_068] Living Dragonbreath - COST:3 [ATK:3/HP:4] 
		// - Race: elemental, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Your minions can't be_<b>Frozen</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LivingDragonbreath_DRG_068()
		{
			// TODO LivingDragonbreath_DRG_068 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Living Dragonbreath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Dragonbreath"));
			//Minion testCard = game.ProcessCard<Minion>("Living Dragonbreath");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_069] Platebreaker - COST:5 [ATK:5/HP:5] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Platebreaker_DRG_069()
		{
			// TODO Platebreaker_DRG_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Platebreaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Platebreaker"));
			//Minion testCard = game.ProcessCard<Minion>("Platebreaker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_070] Dragon Breeder - COST:2 [ATK:2/HP:3] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly Dragon. Add a copy of it to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonBreeder_DRG_070()
		{
			// TODO DragonBreeder_DRG_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Breeder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Breeder"));
			//Minion testCard = game.ProcessCard<Minion>("Dragon Breeder");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_071] Bad Luck Albatross - COST:3 [ATK:4/HP:3] 
		// - Race: beast, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle two 1/1 Albatross into your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BadLuckAlbatross_DRG_071()
		{
			// TODO BadLuckAlbatross_DRG_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bad Luck Albatross"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bad Luck Albatross"));
			//Minion testCard = game.ProcessCard<Minion>("Bad Luck Albatross");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_072] Skyfin - COST:5 [ATK:3/HP:3] 
		// - Race: murloc, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, summon 2 random Murlocs.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skyfin_DRG_072()
		{
			// TODO Skyfin_DRG_072 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skyfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skyfin"));
			//Minion testCard = game.ProcessCard<Minion>("Skyfin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_073] Evasive Feywing - COST:4 [ATK:5/HP:4] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvasiveFeywing_DRG_073()
		{
			// TODO EvasiveFeywing_DRG_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasive Feywing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasive Feywing"));
			//Minion testCard = game.ProcessCard<Minion>("Evasive Feywing");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_074] Camouflaged Dirigible - COST:6 [ATK:6/HP:6] 
		// - Race: mechanical, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other Mechs <b>Stealth</b> until your_next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CamouflagedDirigible_DRG_074()
		{
			// TODO CamouflagedDirigible_DRG_074 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Camouflaged Dirigible"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Camouflaged Dirigible"));
			//Minion testCard = game.ProcessCard<Minion>("Camouflaged Dirigible");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_075] Cobalt Spellkin - COST:5 [ATK:3/HP:5] 
		// - Race: dragon, Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add two 1-Cost spells from your class to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CobaltSpellkin_DRG_075()
		{
			// TODO CobaltSpellkin_DRG_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cobalt Spellkin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cobalt Spellkin"));
			//Minion testCard = game.ProcessCard<Minion>("Cobalt Spellkin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_076] Faceless Corruptor - COST:5 [ATK:5/HP:4] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>. <b>Battlecry:</b> Transform
		//       one of your minions into
		//       a copy of this.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessCorruptor_DRG_076()
		{
			// TODO FacelessCorruptor_DRG_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Corruptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Corruptor"));
			//Minion testCard = game.ProcessCard<Minion>("Faceless Corruptor");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_077] Utgarde Grapplesniper - COST:6 [ATK:5/HP:5] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Both players draw a card. If it's a Dragon, summon it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UtgardeGrapplesniper_DRG_077()
		{
			// TODO UtgardeGrapplesniper_DRG_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Utgarde Grapplesniper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Utgarde Grapplesniper"));
			//Minion testCard = game.ProcessCard<Minion>("Utgarde Grapplesniper");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_078] Depth Charge - COST:1 [ATK:0/HP:5] 
		// - Set: dragons, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 5 damage to ALL_minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DepthCharge_DRG_078()
		{
			// TODO DepthCharge_DRG_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Depth Charge"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Depth Charge"));
			//Minion testCard = game.ProcessCard<Minion>("Depth Charge");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_079] Evasive Wyrm - COST:6 [ATK:5/HP:3] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>. <b>Rush</b>.
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// - RUSH = 1
		// - 1211 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvasiveWyrm_DRG_079()
		{
			// TODO EvasiveWyrm_DRG_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasive Wyrm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasive Wyrm"));
			//Minion testCard = game.ProcessCard<Minion>("Evasive Wyrm");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_081] Scalerider - COST:3 [ATK:3/HP:3] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Scalerider_DRG_081()
		{
			// TODO Scalerider_DRG_081 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scalerider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scalerider"));
			//Minion testCard = game.ProcessCard<Minion>("Scalerider");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_082] Kobold Stickyfinger - COST:5 [ATK:4/HP:4] 
		// - Race: pirate, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Steal your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldStickyfinger_DRG_082()
		{
			// TODO KoboldStickyfinger_DRG_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Stickyfinger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Stickyfinger"));
			//Minion testCard = game.ProcessCard<Minion>("Kobold Stickyfinger");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_084] Tentacled Menace - COST:5 [ATK:6/HP:5] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Each player draws a card. Swap their_Costs.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TentacledMenace_DRG_084()
		{
			// TODO TentacledMenace_DRG_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tentacled Menace"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tentacled Menace"));
			//Minion testCard = game.ProcessCard<Minion>("Tentacled Menace");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_086] Chromatic Egg - COST:5 [ATK:0/HP:3] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Secretly <b>Discover</b>
		//       a Dragon to hatch into.
		//       <b>Deathrattle:</b> Hatch!
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// - USE_DISCOVER_VISUALS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChromaticEgg_DRG_086()
		{
			// TODO ChromaticEgg_DRG_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chromatic Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromatic Egg"));
			//Minion testCard = game.ProcessCard<Minion>("Chromatic Egg");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_088] Dread Raven - COST:3 [ATK:3/HP:4] 
		// - Race: beast, Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Has +3 Attack for each other Dread Raven you_control.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DreadRaven_DRG_088()
		{
			// TODO DreadRaven_DRG_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dread Raven"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Raven"));
			//Minion testCard = game.ProcessCard<Minion>("Dread Raven");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_089] Dragonqueen Alexstrasza - COST:9 [ATK:8/HP:8] 
		// - Race: dragon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, add 2 random Dragons to your hand. They cost (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonqueenAlexstrasza_DRG_089()
		{
			// TODO DragonqueenAlexstrasza_DRG_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonqueen Alexstrasza"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonqueen Alexstrasza"));
			//Minion testCard = game.ProcessCard<Minion>("Dragonqueen Alexstrasza");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_091] Shu'ma - COST:7 [ATK:1/HP:7] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn,
		//       fill your board with 1/1_Tentacles.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shuma_DRG_091()
		{
			// TODO Shuma_DRG_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shu'ma"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shu'ma"));
			//Minion testCard = game.ProcessCard<Minion>("Shu'ma");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_092] Transmogrifier - COST:2 [ATK:2/HP:3] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you draw a card, transform it into a random <b>Legendary</b> minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Transmogrifier_DRG_092()
		{
			// TODO Transmogrifier_DRG_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Transmogrifier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Transmogrifier"));
			//Minion testCard = game.ProcessCard<Minion>("Transmogrifier");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_099] Kronx Dragonhoof - COST:6 [ATK:6/HP:6] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw Galakrond.
		//       If you're already Galakrond,
		//       unleash a Devastation.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - 676 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KronxDragonhoof_DRG_099()
		{
			// TODO KronxDragonhoof_DRG_099 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kronx Dragonhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kronx Dragonhoof"));
			//Minion testCard = game.ProcessCard<Minion>("Kronx Dragonhoof");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_213] Twin Tyrant - COST:8 [ATK:4/HP:10] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 4 damage to two random enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwinTyrant_DRG_213()
		{
			// TODO TwinTyrant_DRG_213 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twin Tyrant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twin Tyrant"));
			//Minion testCard = game.ProcessCard<Minion>("Twin Tyrant");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_239] Blazing Battlemage - COST:1 [ATK:2/HP:2] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlazingBattlemage_DRG_239()
		{
			// TODO BlazingBattlemage_DRG_239 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blazing Battlemage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blazing Battlemage"));
			//Minion testCard = game.ProcessCard<Minion>("Blazing Battlemage");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_242] Shield of Galakrond - COST:5 [ATK:4/HP:5] 
		// - Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> <b>Invoke</b> Galakrond.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - 676 = 1
		// - EMPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShieldOfGalakrond_DRG_242()
		{
			// TODO ShieldOfGalakrond_DRG_242 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shield of Galakrond"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shield of Galakrond"));
			//Minion testCard = game.ProcessCard<Minion>("Shield of Galakrond");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_257] Frizz Kindleroost - COST:4 [ATK:5/HP:4] 
		// - Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reduce the Cost of Dragons in your deck by_(2).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrizzKindleroost_DRG_257()
		{
			// TODO FrizzKindleroost_DRG_257 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frizz Kindleroost"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frizz Kindleroost"));
			//Minion testCard = game.ProcessCard<Minion>("Frizz Kindleroost");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_310] Evasive Drakonid - COST:7 [ATK:7/HP:7] 
		// - Race: dragon, Set: dragons, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvasiveDrakonid_DRG_310()
		{
			// TODO EvasiveDrakonid_DRG_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasive Drakonid"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasive Drakonid"));
			//Minion testCard = game.ProcessCard<Minion>("Evasive Drakonid");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_401] Grizzled Wizard - COST:2 [ATK:3/HP:2] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap Hero Powers with your opponent until your next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrizzledWizard_DRG_401()
		{
			// TODO GrizzledWizard_DRG_401 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grizzled Wizard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grizzled Wizard"));
			//Minion testCard = game.ProcessCard<Minion>("Grizzled Wizard");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_402] Sathrovarr - COST:9 [ATK:5/HP:5] 
		// - Race: demon, Set: dragons, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Add a copy of it to_your hand, deck, and battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sathrovarr_DRG_402()
		{
			// TODO Sathrovarr_DRG_402 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sathrovarr"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sathrovarr"));
			//Minion testCard = game.ProcessCard<Minion>("Sathrovarr");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DRG_403] Blowtorch Saboteur - COST:3 [ATK:3/HP:4] 
		// - Set: dragons, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent's next Hero Power costs (3).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlowtorchSaboteur_DRG_403()
		{
			// TODO BlowtorchSaboteur_DRG_403 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blowtorch Saboteur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blowtorch Saboteur"));
			//Minion testCard = game.ProcessCard<Minion>("Blowtorch Saboteur");
		}

	}

}
