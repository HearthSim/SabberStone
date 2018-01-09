using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

using Generic = SabberStoneCore.Actions.Generic;
using System.Linq;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class DruidLootapaloozaTest
	{
		// ----------------------------------------- MINION - DRUID
		// [LOOT_048] Ironwood Golem - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can only attack if you have 3 or more Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronwoodGolem_LOOT_048()
		{
			// TODO IronwoodGolem_LOOT_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironwood Golem"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironwood Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironwood Golem"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_056] Astral Tiger - COST:4 [ATK:3/HP:5] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle a
		//        copy of this minion into_your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AstralTiger_LOOT_056()
		{
			// TODO AstralTiger_LOOT_056 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astral Tiger"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Tiger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astral Tiger"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_314] Grizzled Guardian - COST:8 [ATK:3/HP:5] 
		// - Race: beast, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> <b>Recruit</b> 2_minions that cost (4)_or_less.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrizzledGuardian_LOOT_314()
		{
			// TODO GrizzledGuardian_LOOT_314 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grizzled Guardian"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grizzled Guardian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grizzled Guardian"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_329] Ixlid, Fungal Lord - COST:5 [ATK:2/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you play a minion, summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - 717 = 1
		// --------------------------------------------------------
		[Fact]
		public void IxlidFungalLord_LOOT_329()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ixlid, Fungal Lord"),
					Cards.FromName("Murloc Raider")
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ixlid, Fungal Lord"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Raider"));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_351] Greedy Sprite - COST:3 [ATK:3/HP:1] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreedySprite_LOOT_351()
		{
			// TODO GreedySprite_LOOT_351 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Greedy Sprite"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greedy Sprite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Greedy Sprite"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_047] Barkskin - COST:1 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +3 Health. Gain 3 Armor.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Barkskin_LOOT_047()
		{
			// TODO Barkskin_LOOT_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Barkskin"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barkskin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Barkskin"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_051] Lesser Jasper Spellstone - COST:1 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. @<i>(Gain 3 Armor to upgrade.)</i> @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - ARMOR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserJasperSpellstone_LOOT_051()
		{
			// TODO LesserJasperSpellstone_LOOT_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Jasper Spellstone"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Jasper Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Jasper Spellstone"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_054] Branching Paths - COST:4 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Choose Twice -</b> Draw a
		//       card; Give your minions 
		//       +1 Attack; Gain 6 Armor.
		// --------------------------------------------------------
		// Entourage: LOOT_054d, LOOT_054b, LOOT_054c
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BranchingPaths_LOOT_054()
		{
			// TODO BranchingPaths_LOOT_054 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Branching Paths"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Branching Paths"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Branching Paths"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_309] Oaken Summons - COST:4 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 6 Armor.
		//       <b>Recruit</b> a minion that costs (4) or less.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OakenSummons_LOOT_309()
		{
			// TODO OakenSummons_LOOT_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Oaken Summons"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oaken Summons"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Oaken Summons"));
		}

		// ----------------------------------------- WEAPON - DRUID
		// [LOOT_392] Twig of the World Tree - COST:4 [ATK:1/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain 10 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 5
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void TwigOfTheWorldTree_LOOT_392()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twig of the World Tree"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twig of the World Tree"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twig of the World Tree"));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Player1.BaseMana = 0;
			game.Player2.BaseMana = 0;

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			Assert.Equal(25, game.CurrentPlayer.Opponent.Hero.Health);

			Assert.Equal(10, game.CurrentPlayer.RemainingMana);
		}

	}

	public class HunterLootapaloozaTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [LOOT_078] Cave Hydra - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Also damages the minions next to whomever
		//       this attacks.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaveHydra_LOOT_078()
		{
			// TODO CaveHydra_LOOT_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cave Hydra"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cave Hydra"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cave Hydra"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOOT_511] Kathrena Winterwisp - COST:8 [ATK:6/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> <b>Recruit</b> a Beast.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KathrenaWinterwisp_LOOT_511()
		{
			// TODO KathrenaWinterwisp_LOOT_511 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kathrena Winterwisp"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kathrena Winterwisp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kathrena Winterwisp"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOOT_520] Seeping Oozeling - COST:6 [ATK:5/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain the <b>Deathrattle</b> of a random minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeepingOozeling_LOOT_520()
		{
			// TODO SeepingOozeling_LOOT_520 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seeping Oozeling"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seeping Oozeling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seeping Oozeling"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_077] Flanking Strike - COST:4 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage to a minion. Summon a 3/3 Wolf. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlankingStrike_LOOT_077()
		{
			// TODO FlankingStrike_LOOT_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flanking Strike"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flanking Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flanking Strike"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_079] Wandering Monster - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks your hero, summon a 3-Cost minion as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WanderingMonster_LOOT_079()
		{
			// TODO WanderingMonster_LOOT_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wandering Monster"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wandering Monster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wandering Monster"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_080] Lesser Emerald Spellstone - COST:5 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserEmeraldSpellstone_LOOT_080()
		{
			// TODO LesserEmeraldSpellstone_LOOT_080 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Emerald Spellstone"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Emerald Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Emerald Spellstone"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_217] To My Side! - COST:6 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Summon an Animal
		//       Companion, or 2 if your
		//       deck has no minions.
		// --------------------------------------------------------
		// Entourage: NEW1_032, NEW1_033, NEW1_034
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToMySide_LOOT_217()
		{
			// TODO ToMySide_LOOT_217 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("To My Side!"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("To My Side!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "To My Side!"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_522] Crushing Walls - COST:7 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy your opponent's left and right-most minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrushingWalls_LOOT_522()
		{
			// TODO CrushingWalls_LOOT_522 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crushing Walls"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crushing Walls"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crushing Walls"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [LOOT_085] Rhok'delar - COST:7 [ATK:4/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no minions, fill your_hand with Hunter_spells.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rhokdelar_LOOT_085()
		{
			// TODO Rhokdelar_LOOT_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rhok'delar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rhok'delar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rhok'delar"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [LOOT_222] Candleshot - COST:1 [ATK:1/HP:0] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Immune</b> while attacking.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Candleshot_LOOT_222()
		{
			// TODO Candleshot_LOOT_222 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candleshot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candleshot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Candleshot"));
		}

	}

	public class MageLootapaloozaTest
	{
		// ------------------------------------------ MINION - MAGE
		// [LOOT_170] Raven Familiar - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a spell in each deck. If yours costs more, draw it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavenFamiliar_LOOT_170()
		{
			// TODO RavenFamiliar_LOOT_170 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raven Familiar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raven Familiar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raven Familiar"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_231] Arcane Artificer - COST:1 [ATK:1/HP:2] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain Armor equal to its_Cost.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneArtificer_LOOT_231()
		{
			// TODO ArcaneArtificer_LOOT_231 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Artificer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Artificer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Artificer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_535] Dragoncaller Alanna - COST:9 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 5/5 Dragon for each spell you cast this game that costs (5) or more.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragoncallerAlanna_LOOT_535()
		{
			// TODO DragoncallerAlanna_LOOT_535 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragoncaller Alanna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragoncaller Alanna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragoncaller Alanna"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_537] Leyline Manipulator - COST:4 [ATK:4/HP:5] 
		// - Race: elemental, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding any cards that didn't start in your deck, reduce their Cost by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeylineManipulator_LOOT_537()
		{
			// TODO LeylineManipulator_LOOT_537 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Leyline Manipulator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leyline Manipulator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leyline Manipulator"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_101] Explosive Runes - COST:3 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, deal $6 damage to it and any excess to their hero. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplosiveRunes_LOOT_101()
		{
			// TODO ExplosiveRunes_LOOT_101 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explosive Runes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Runes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explosive Runes"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_103] Lesser Ruby Spellstone - COST:2 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Add 1 random Mage spell to your hand. @<i>(Play 2 Elementals to_upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserRubySpellstone_LOOT_103()
		{
			// TODO LesserRubySpellstone_LOOT_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Ruby Spellstone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Ruby Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Ruby Spellstone"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_104] Shifting Scroll - COST:0 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a random Mage spell.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		// PlayReq:
		// - 73 = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShiftingScroll_LOOT_104()
		{
			// TODO ShiftingScroll_LOOT_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shifting Scroll"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shifting Scroll"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shifting Scroll"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_106] Deck of Wonders - COST:5 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle 5 Scrolls into your deck. When drawn, cast a random spell.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeckOfWonders_LOOT_106()
		{
			// TODO DeckOfWonders_LOOT_106 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deck of Wonders"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deck of Wonders"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deck of Wonders"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_172] Dragon's Fury - COST:5 
		// - Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Reveal a spell from your deck. Deal damage equal to its Cost to all_minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonsFury_LOOT_172()
		{
			// TODO DragonsFury_LOOT_172 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon's Fury"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Fury"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon's Fury"));
		}

		// ------------------------------------------ WEAPON - MAGE
		// [LOOT_108] Aluneth - COST:6 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, draw 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact]
		public void Aluneth_LOOT_108()
		{
			// TODO Aluneth_LOOT_108 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aluneth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aluneth"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(10, game.CurrentOpponent.HandZone.Count);
		}
	}

	public class PaladinLootapaloozaTest
	{
		// --------------------------------------- MINION - PALADIN
		// [LOOT_216] Lynessa Sunsorrow - COST:7 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Cast each spell
		//       you cast on your minions
		//        this game on this one.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LynessaSunsorrow_LOOT_216()
		{
			// TODO LynessaSunsorrow_LOOT_216 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lynessa Sunsorrow"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lynessa Sunsorrow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lynessa Sunsorrow"));
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_313] Crystal Lion - COST:6 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       Costs (1) less for each Silver
		//       Hand Recruit you control.
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalLion_LOOT_313()
		{
			// TODO CrystalLion_LOOT_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystal Lion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystal Lion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystal Lion"));
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_363] Drygulch Jailor - COST:2 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add 3 Silver_Hand Recruits to_your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrygulchJailor_LOOT_363()
		{
			// TODO DrygulchJailor_LOOT_363 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drygulch Jailor"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drygulch Jailor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drygulch Jailor"));
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_398] Benevolent Djinn - COST:3 [ATK:2/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 3 Health to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BenevolentDjinn_LOOT_398()
		{
			// TODO BenevolentDjinn_LOOT_398 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Benevolent Djinn"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Benevolent Djinn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Benevolent Djinn"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_088] Potion of Heroism - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion <b>Divine_Shield</b>.
		//       Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PotionOfHeroism_LOOT_088()
		{
			// TODO PotionOfHeroism_LOOT_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Potion of Heroism"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Heroism"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Potion of Heroism"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_091] Lesser Pearl Spellstone - COST:2 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 2/2 Spirit with <b>Taunt</b>. @<i>(Restore 3 Health to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - HEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserPearlSpellstone_LOOT_091()
		{
			// TODO LesserPearlSpellstone_LOOT_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Pearl Spellstone"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Pearl Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Pearl Spellstone"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_093] Call to Arms - COST:4 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Recruit</b> 3 minions that
		//        cost (2) or less.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallToArms_LOOT_093()
		{
			// TODO CallToArms_LOOT_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call to Arms"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call to Arms"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call to Arms"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_333] Level Up! - COST:5 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - 717 = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LevelUp_LOOT_333()
		{
			// TODO LevelUp_LOOT_333 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Level Up!"),
				},
				Player2HeroClass = CardClass.PALADIN,
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

		// --------------------------------------- WEAPON - PALADIN
		// [LOOT_286] Unidentified Maul - COST:3 [ATK:2/HP:0] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_286t2, LOOT_286t3, LOOT_286t1, LOOT_286t4
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedMaul_LOOT_286()
		{
			// TODO UnidentifiedMaul_LOOT_286 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Maul"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Maul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unidentified Maul"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [LOOT_500] Val'anyr - COST:6 [ATK:4/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a minion in your hand +4/+2. When it dies, reequip this.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Valanyr_LOOT_500()
		{
			// TODO Valanyr_LOOT_500 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Val'anyr"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Val'anyr"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Val'anyr"));
		}

	}

	public class PriestLootapaloozaTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [LOOT_410] Duskbreaker - COST:4 [ATK:3/HP:3] 
		// - Race: dragon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding
		//       a Dragon, deal 3 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Duskbreaker_LOOT_410()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskbreaker"),
					Cards.FromName("Drakonid Operative")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			var minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lorewalker Cho"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskbreaker"));
			Assert.True(minion1.ToBeDestroyed);
			Assert.Equal(1, minion2.Health);

			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakonid Operative"));
			var testCard2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskbreaker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskbreaker"));
			Assert.Equal(1, minion2.Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_528] Twilight Acolyte - COST:3 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding
		//       a Dragon, swap this minion's Attack with another minion's.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// --------------------------------------------------------
		[Fact]
		public void TwilightAcolyte_LOOT_528()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Drake")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var testCard = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Acolyte"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var testTarget = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ysera"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testTarget));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, testTarget));
			Assert.Equal(2, testTarget.AttackDamage);
			Assert.Equal(4, testCard.AttackDamage);
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_534] Gilded Gargoyle - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a Coin to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GildedGargoyle_LOOT_534()
		{
			// TODO GildedGargoyle_LOOT_534 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gilded Gargoyle"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gilded Gargoyle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gilded Gargoyle"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_538] Temporus - COST:7 [ATK:6/HP:6] 
		// - Race: dragon, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent takes two turns. Then you take two turns.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Temporus_LOOT_538()
		{
			// TODO Temporus_LOOT_538 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temporus"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temporus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temporus"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_008] Psychic Scream - COST:7 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle all minions into your opponent's deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PsychicScream_LOOT_008()
		{
			// TODO PsychicScream_LOOT_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psychic Scream"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Psychic Scream"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Psychic Scream"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_187] Twilight's Call - COST:3 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 1/1 copies of 2 friendly <b>Deathrattle</b> minions
		//       that died this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		[Fact]
		public void TwilightsCall_LOOT_187()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight's Call"),
					Cards.FromName("Bloodmage Thalnos"),
					Cards.FromName("Spirit Lash"),
					Cards.FromName("Spirit Lash")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight's Call"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodmage Thalnos"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Lash"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight's Call"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Lash"));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight's Call"));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_278] Unidentified Elixir - COST:3 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2. Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_278t1, LOOT_278t2, LOOT_278t3, LOOT_278t4
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedElixir_LOOT_278()
		{
			// TODO UnidentifiedElixir_LOOT_278 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Elixir"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Elixir"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unidentified Elixir"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_353] Psionic Probe - COST:1 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Copy a spell in your opponent's deck and add it to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PsionicProbe_LOOT_353()
		{
			// TODO PsionicProbe_LOOT_353 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psionic Probe"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Psionic Probe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Psionic Probe"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_507] Lesser Diamond Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Resurrect 2 different friendly minions. @<i>(Cast 4 spells to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserDiamondSpellstone_LOOT_507()
		{
			// TODO LesserDiamondSpellstone_LOOT_507 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Diamond Spellstone"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Diamond Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Diamond Spellstone"));
		}

		// ---------------------------------------- WEAPON - PRIEST
		// [LOOT_209] Dragon Soul - COST:3 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast 3 spells in a turn, summon a 5/5 Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonSoul_LOOT_209()
		{
			// TODO DragonSoul_LOOT_209 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Soul"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Soul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon Soul"));
		}

	}

	public class RogueLootapaloozaTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOOT_026] Fal'dorei Strider - COST:4 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle 3
		//       Ambushes into your deck.
		//       When drawn, summon
		//       a 4/4 Spider.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FaldoreiStrider_LOOT_026()
		{
			// TODO FaldoreiStrider_LOOT_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fal'dorei Strider"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fal'dorei Strider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fal'dorei Strider"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_033] Cavern Shinyfinder - COST:2 [ATK:3/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a weapon from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CavernShinyfinder_LOOT_033()
		{
			// TODO CavernShinyfinder_LOOT_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cavern Shinyfinder"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cavern Shinyfinder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cavern Shinyfinder"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_165] Sonya Shadowdancer - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After a friendly minion dies, add a 1/1 copy of it to your hand. It costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SonyaShadowdancer_LOOT_165()
		{
			// TODO SonyaShadowdancer_LOOT_165 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sonya Shadowdancer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sonya Shadowdancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sonya Shadowdancer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_211] Elven Minstrel - COST:4 [ATK:3/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Draw 2 minions from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElvenMinstrel_LOOT_211()
		{
			// TODO ElvenMinstrel_LOOT_211 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elven Minstrel"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elven Minstrel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elven Minstrel"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_412] Kobold Illusionist - COST:4 [ATK:3/HP:3] 
		// - Fac: alliance, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 copy of a minion from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldIllusionist_LOOT_412()
		{
			// TODO KoboldIllusionist_LOOT_412 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Illusionist"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Illusionist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Illusionist"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_204] Cheat Death - COST:2 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
		//       It costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CheatDeath_LOOT_204()
		{
			// TODO CheatDeath_LOOT_204 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cheat Death"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cheat Death"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cheat Death"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_210] Sudden Betrayal - COST:2 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a minion attacks your hero, instead it attacks one of_its neighbors.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SuddenBetrayal_LOOT_210()
		{
			// TODO SuddenBetrayal_LOOT_210 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sudden Betrayal"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sudden Betrayal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sudden Betrayal"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_214] Evasion - COST:2 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your hero takes damage, become <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Evasion_LOOT_214()
		{
			// TODO Evasion_LOOT_214 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasion"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evasion"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_503] Lesser Onyx Spellstone - COST:5 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy 1 random enemy minion.
		//       @<i>(Play 3 <b>Deathrattle</b> cards to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserOnyxSpellstone_LOOT_503()
		{
			// TODO LesserOnyxSpellstone_LOOT_503 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Onyx Spellstone"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Onyx Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Onyx Spellstone"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [LOOT_542] Kingsbane - COST:1 [ATK:1/HP:3] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Shuffle
		//       this into your deck.
		//       It keeps any
		//       enchantments.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - DEATHRATTLE = 1
		// - 851 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kingsbane_LOOT_542()
		{
			// TODO Kingsbane_LOOT_542 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kingsbane"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kingsbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kingsbane"));
		}

	}

	public class ShamanLootapaloozaTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_062] Kobold Hermit - COST:2 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a basic Totem. Summon it.
		// --------------------------------------------------------
		// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldHermit_LOOT_062()
		{
			// TODO KoboldHermit_LOOT_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Hermit"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Hermit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Hermit"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_358] Grumble, Worldshaker - COST:6 [ATK:7/HP:7] 
		// - Race: elemental, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return your other minions to your hand. They cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrumbleWorldshaker_LOOT_358()
		{
			// TODO GrumbleWorldshaker_LOOT_358 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grumble, Worldshaker"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grumble, Worldshaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grumble, Worldshaker"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_517] Murmuring Elemental - COST:2 [ATK:1/HP:1] 
		// - Race: elemental, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next <b>Battlecry</b> this turn triggers_twice.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurmuringElemental_LOOT_517()
		{
			// TODO MurmuringElemental_LOOT_517 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murmuring Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murmuring Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murmuring Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_518] Windshear Stormcaller - COST:5 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control all 4 basic Totems, summon Al'Akir_the_Windlord.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WindshearStormcaller_LOOT_518()
		{
			// TODO WindshearStormcaller_LOOT_518 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Windshear Stormcaller"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Windshear Stormcaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Windshear Stormcaller"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_060] Crushing Hand - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $8 damage to a minion. <b><b>Overload</b>:</b> (3) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrushingHand_LOOT_060()
		{
			// TODO CrushingHand_LOOT_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crushing Hand"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crushing Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crushing Hand"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_064] Lesser Sapphire Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 1 copy of a friendly minion. @<i>(<b>Overload</b> 3 Mana Crystals to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserSapphireSpellstone_LOOT_064()
		{
			// TODO LesserSapphireSpellstone_LOOT_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Sapphire Spellstone"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Sapphire Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Sapphire Spellstone"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_344] Primal Talismans - COST:3 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Summon a random basic Totem."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalTalismans_LOOT_344()
		{
			// TODO PrimalTalismans_LOOT_344 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primal Talismans"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primal Talismans"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primal Talismans"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_373] Healing Rain - COST:3 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #12 Health randomly split among all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HealingRain_LOOT_373()
		{
			// TODO HealingRain_LOOT_373 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Healing Rain"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Rain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Healing Rain"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_504] Unstable Evolution - COST:1 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Transform a friendly minion into
		//       one that costs (1) more. Repeatable this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstableEvolution_LOOT_504()
		{
			// TODO UnstableEvolution_LOOT_504 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Evolution"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Evolution"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Evolution"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [LOOT_506] The Runespear - COST:8 [ATK:3/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks, <b>Discover</b> a spell
		//       and cast it with random targets.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheRunespear_LOOT_506()
		{
			// TODO TheRunespear_LOOT_506 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Runespear"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Runespear"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Runespear"));
		}

	}

	public class WarlockLootapaloozaTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [LOOT_013] Vulgar Homunculus - COST:2 [ATK:2/HP:4] 
		// - Race: demon, Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Deal 2 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void VulgarHomunculus_LOOT_013()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vulgar Homunculus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vulgar Homunculus"));
			int previousHealth = game.CurrentPlayer.Hero.Health;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vulgar Homunculus"));
			Assert.Equal(previousHealth-2, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_014] Kobold Librarian - COST:1 [ATK:2/HP:1] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card. Deal 2 damage to your_hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KoboldLibrarian_LOOT_014()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Librarian"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Librarian"));
			int previousHealth = game.CurrentPlayer.Hero.Health;
			int previousCardsInHand = game.CurrentPlayer.HandZone.Count;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Librarian"));
			Assert.Equal(previousCardsInHand, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(previousHealth - 2, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_018] Hooked Reaver - COST:4 [ATK:4/HP:4] 
		// - Race: demon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have 15 or_less Health, gain +3/+3_and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void HookedReaver_LOOT_018()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hooked Reaver"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooked Reaver"));
			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooked Reaver"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(testCard[GameTag.ATK], testCard.Card.Tags[GameTag.ATK]);
			Assert.Equal(testCard[GameTag.HEALTH], testCard.Card.Tags[GameTag.HEALTH]);
			Assert.True(testCard[GameTag.TAUNT] == 0, "Has Taunt with Hero at 30 Health");

			game.CurrentPlayer.Hero.Health = 15;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Equal(testCard2[GameTag.ATK], testCard2.Card.Tags[GameTag.ATK] + 3);
			Assert.Equal(testCard2[GameTag.HEALTH], testCard2.Card.Tags[GameTag.HEALTH] + 3);
			Assert.True(testCard2[GameTag.TAUNT] == 1, "Doesn't have Taunt with Hero at 15 Health");
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_306] Possessed Lackey - COST:5 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> <b>Recruit</b> a_Demon.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PossessedLackey_LOOT_306()
		{
			// TODO PossessedLackey_LOOT_306 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Possessed Lackey"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Possessed Lackey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Possessed Lackey"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_368] Voidlord - COST:9 [ATK:3/HP:9] 
		// - Race: demon, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//        <b>Deathrattle:</b> Summon three
		//       1/3 Demons with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voidlord_LOOT_368()
		{
			// TODO Voidlord_LOOT_368 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidlord"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voidlord"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_415] Rin, the First Disciple - COST:6 [ATK:3/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Add 'The First Seal' to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RinTheFirstDisciple_LOOT_415()
		{
			// TODO RinTheFirstDisciple_LOOT_415 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rin, the First Disciple"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rin, the First Disciple"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rin, the First Disciple"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_017] Dark Pact - COST:1 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a friendly minion. Restore #8 Health to your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPact_LOOT_017()
		{
			// TODO DarkPact_LOOT_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Pact"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Pact"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_043] Lesser Amethyst Spellstone - COST:4 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Lifesteal.</b> Deal $3 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserAmethystSpellstone_LOOT_043()
		{
			// TODO LesserAmethystSpellstone_LOOT_043 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Amethyst Spellstone"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Amethyst Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Amethyst Spellstone"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_417] Cataclysm - COST:4 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions. Discard your hand.
		// --------------------------------------------------------
		// GameTag:
		// - 890 = 10
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cataclysm_LOOT_417()
		{
			// TODO Cataclysm_LOOT_417 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cataclysm"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cataclysm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cataclysm"));
		}

		// --------------------------------------- WEAPON - WARLOCK
		// [LOOT_420] Skull of the Man'ari - COST:5 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your turn, summon a Demon from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkullOfTheManari_LOOT_420()
		{
			// TODO SkullOfTheManari_LOOT_420 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skull of the Man'ari"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skull of the Man'ari"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skull of the Man'ari"));
		}

	}

	public class WarriorLootapaloozaTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [LOOT_041] Kobold Barbarian - COST:3 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, attack a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldBarbarian_LOOT_041()
		{
			// TODO KoboldBarbarian_LOOT_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Barbarian"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Barbarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Barbarian"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_365] Gemstudded Golem - COST:6 [ATK:5/HP:9] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can only attack if you have 5 or more Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GemstuddedGolem_LOOT_365()
		{
			// TODO GemstuddedGolem_LOOT_365 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gemstudded Golem"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gemstudded Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gemstudded Golem"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_367] Drywhisker Armorer - COST:2 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For each enemy minion, gain 2 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrywhiskerArmorer_LOOT_367()
		{
			// TODO DrywhiskerArmorer_LOOT_367 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drywhisker Armorer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drywhisker Armorer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drywhisker Armorer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_519] Geosculptor Yip - COST:8 [ATK:4/HP:8] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a random minion with_Cost_equal_to_your Armor <i>(up to 10)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GeosculptorYip_LOOT_519()
		{
			// TODO GeosculptorYip_LOOT_519 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Geosculptor Yip"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Geosculptor Yip"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Geosculptor Yip"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_203] Lesser Mithril Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon one 5/5 Mithril Golem. <i>(Equip a weapon to upgrade.)</i>
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserMithrilSpellstone_LOOT_203()
		{
			// TODO LesserMithrilSpellstone_LOOT_203 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Mithril Spellstone"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Mithril Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Mithril Spellstone"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_285] Unidentified Shield - COST:6 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 5 Armor.
		//       Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_285t, LOOT_285t2, LOOT_285t3, LOOT_285t4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedShield_LOOT_285()
		{
			// TODO UnidentifiedShield_LOOT_285 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Shield"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Shield"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unidentified Shield"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_364] Reckless Flurry - COST:3 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Armor. Deal that much damage to all minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecklessFlurry_LOOT_364()
		{
			// TODO RecklessFlurry_LOOT_364 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reckless Flurry"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Flurry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reckless Flurry"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_370] Gather Your Party - COST:6 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Recruit</b> a minion.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GatherYourParty_LOOT_370()
		{
			// TODO GatherYourParty_LOOT_370 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gather Your Party"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gather Your Party"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gather Your Party"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOOT_044] Bladed Gauntlet - COST:2 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Has Attack equal to your Armor. Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BladedGauntlet_LOOT_044()
		{
			// TODO BladedGauntlet_LOOT_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bladed Gauntlet"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladed Gauntlet"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bladed Gauntlet"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOOT_380] Woecleaver - COST:8 [ATK:3/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks, <b>Recruit</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Woecleaver_LOOT_380()
		{
			// TODO Woecleaver_LOOT_380 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Woecleaver"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Woecleaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Woecleaver"));
		}

	}

	public class NeutralLootapaloozaTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_069] Sewer Crawler - COST:3 [ATK:1/HP:1] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/3_Giant Rat.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void SewerCrawler_LOOT_069()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sewer Crawler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sewer Crawler"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sewer Crawler"));
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card, testCard.Card);
			Assert.Equal(game.CurrentPlayer.BoardZone[1].Card, Cards.FromId("LOOT_069t"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_111] Scorp-o-matic - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion with 1 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_MAX_ATTACK = 1
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void ScorpOMatic_LOOT_111()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scorp-o-matic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scorp-o-matic"));
			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scorp-o-matic"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var elvenArcher = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elven Archer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, elvenArcher, game.CurrentPlayer.Opponent.Hero));

			var frostwolfGrunt = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, frostwolfGrunt, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard1, frostwolfGrunt));
			Assert.False(frostwolfGrunt.ToBeDestroyed, "Minion with more than 1 attack got destoryed");
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, elvenArcher));
			Assert.True(elvenArcher.ToBeDestroyed, "Minion with less than 1 attack didn't get destoryed");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_117] Wax Elemental - COST:1 [ATK:0/HP:2] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WaxElemental_LOOT_117()
		{
			// TODO WaxElemental_LOOT_117 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wax Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wax Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wax Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_118] Ebon Dragonsmith - COST:4 [ATK:3/HP:4] 
		// - Race: dragon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reduce the Cost of a random weapon in your hand by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void EbonDragonsmith_LOOT_118()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ebon Dragonsmith"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ebon Dragonsmith"));
			var warAxe = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			var reaper = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanite Reaper"));
			var yeti = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ebon Dragonsmith"));
			Assert.Equal(yeti.Cost, yeti.Card.Cost);
			Assert.True(warAxe.Cost == warAxe.Card.Cost - 2 || reaper.Cost == reaper.Card.Cost - 2, "Weapon Discount Failed. Fiery War Axe Cost:" + warAxe.Cost.ToString() + ". Arcanite Reaper Cost: " + reaper.Cost.ToString());
			Assert.False(warAxe.Cost == warAxe.Card.Cost - 2 && reaper.Cost == reaper.Card.Cost - 2, "Both Weapons were Discounted");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_122] Corrosive Sludge - COST:5 [ATK:5/HP:5] 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CorrosiveSludge_LOOT_122()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrosive Sludge"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrosive Sludge"));
			var yourWeapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, yourWeapon));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var theirWeapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, theirWeapon));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.False(game.CurrentPlayer.Hero.Weapon.ToBeDestroyed, "Your Weapon was destroyed");
			Assert.True(game.CurrentPlayer.Opponent.Hero.Weapon == null, "Opponent's Weapon wasn't destroyed");
			if (game.CurrentPlayer.Opponent.Hero.Weapon != null)
			{
				Assert.True(game.CurrentPlayer.Opponent.Hero.Weapon.ToBeDestroyed, "Opponent's Weapon wasn't destroyed");
			}
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_124] Lone Champion - COST:3 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control no other minions, gain <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void LoneChampion_LOOT_124()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lone Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.True(testCard[GameTag.TAUNT] == 1, "Doesn't have Taunt with a open board");
			Assert.True(testCard[GameTag.DIVINE_SHIELD] == 1, "Doesn't have Divine Shield with a open board");
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.True(testCard2[GameTag.TAUNT] == 1, "Doesn't have Taunt with no friendly minions");
			Assert.True(testCard2[GameTag.DIVINE_SHIELD] == 1, "Doesn't have Divine Shield with no friendly minions");

			var testCard3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard3));
			Assert.False(testCard3[GameTag.TAUNT] == 1, "Has Taunt with friendly minions");
			Assert.False(testCard3[GameTag.DIVINE_SHIELD] == 1, "Has Divine Shield with friendly minions");

		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_125] Stoneskin Basilisk - COST:3 [ATK:1/HP:1] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//        <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StoneskinBasilisk_LOOT_125()
		{
			// TODO StoneskinBasilisk_LOOT_125 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stoneskin Basilisk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stoneskin Basilisk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stoneskin Basilisk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_130] Arcane Tyrant - COST:5 [ATK:4/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (0) if you've cast a spell that costs (5) or more this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneTyrant_LOOT_130()
		{
			// TODO ArcaneTyrant_LOOT_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Tyrant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Tyrant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Tyrant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_131] Green Jelly - COST:5 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 1/2 Ooze with_<b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreenJelly_LOOT_131()
		{
			// TODO GreenJelly_LOOT_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Green Jelly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Green Jelly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Green Jelly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_132] Dragonslayer - COST:3 [ATK:4/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 6 damage to a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 24
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragonslayer_LOOT_132()
		{
			// TODO Dragonslayer_LOOT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonslayer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonslayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonslayer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_134] Toothy Chest - COST:3 [ATK:0/HP:4] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, set this minion's Attack to 4.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToothyChest_LOOT_134()
		{
			// TODO ToothyChest_LOOT_134 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toothy Chest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toothy Chest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toothy Chest"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_136] Sneaky Devil - COST:4 [ATK:2/HP:2] 
		// - Race: demon, Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       Your other minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SneakyDevil_LOOT_136()
		{
			// TODO SneakyDevil_LOOT_136 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sneaky Devil"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sneaky Devil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sneaky Devil"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_137] Sleepy Dragon - COST:9 [ATK:4/HP:12] 
		// - Race: dragon, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SleepyDragon_LOOT_137()
		{
			// TODO SleepyDragon_LOOT_137 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sleepy Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sleepy Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sleepy Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_144] Hoarding Dragon - COST:4 [ATK:5/HP:6] 
		// - Race: dragon, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your opponent two Coins.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoardingDragon_LOOT_144()
		{
			// TODO HoardingDragon_LOOT_144 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hoarding Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hoarding Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hoarding Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_149] Corridor Creeper - COST:7 [ATK:5/HP:5] 
		// - Race: beast, Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less whenever a minion dies while this is_in_your hand.
		// --------------------------------------------------------
		[Fact]
		public void CorridorCreeper_LOOT_149()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corridor Creeper"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corridor Creeper"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			IPlayable aoe = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, aoe));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, testCard.Card.Cost - testCard.Cost);


			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corridor Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_150] Furbolg Mossbinder - COST:5 [ATK:1/HP:1] 
		// - Fac: alliance, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform a friendly minion into a 6/6_Elemental.
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
		public void FurbolgMossbinder_LOOT_150()
		{
			// TODO FurbolgMossbinder_LOOT_150 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Furbolg Mossbinder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Furbolg Mossbinder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Furbolg Mossbinder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_152] Boisterous Bard - COST:3 [ATK:3/HP:2] 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other minions +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoisterousBard_LOOT_152()
		{
			// TODO BoisterousBard_LOOT_152 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boisterous Bard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boisterous Bard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boisterous Bard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_153] Violet Wurm - COST:8 [ATK:7/HP:7] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon seven 1/1 Grubs.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletWurm_LOOT_153()
		{
			// TODO VioletWurm_LOOT_153 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Wurm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Wurm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Wurm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_154] Gravelsnout Knight - COST:1 [ATK:2/HP:3] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GravelsnoutKnight_LOOT_154()
		{
			// TODO GravelsnoutKnight_LOOT_154 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gravelsnout Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gravelsnout Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gravelsnout Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_161] Carnivorous Cube - COST:5 [ATK:4/HP:6] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy
		//       a friendly minion.
		//       <b>Deathrattle:</b> Summon 2 copies of it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CarnivorousCube_LOOT_161()
		{
			// TODO CarnivorousCube_LOOT_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Carnivorous Cube"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Carnivorous Cube"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Carnivorous Cube"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_167] Fungalmancer - COST:5 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fungalmancer_LOOT_167()
		{
			// TODO Fungalmancer_LOOT_167 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungalmancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungalmancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungalmancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_184] Silver Vanguard - COST:7 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> <b>Recruit</b> an
		//       8-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverVanguard_LOOT_184()
		{
			// TODO SilverVanguard_LOOT_184 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silver Vanguard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silver Vanguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silver Vanguard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_193] Shimmering Courser - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Only you can target
		//       this with spells and
		//       Hero Powers.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShimmeringCourser_LOOT_193()
		{
			// TODO ShimmeringCourser_LOOT_193 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shimmering Courser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shimmering Courser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shimmering Courser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_218] Feral Gibberer - COST:1 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion attacks a hero, add a copy of it to_your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FeralGibberer_LOOT_218()
		{
			// TODO FeralGibberer_LOOT_218 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feral Gibberer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Gibberer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feral Gibberer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_233] Cursed Disciple - COST:4 [ATK:5/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 5/1 Revenant.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CursedDisciple_LOOT_233()
		{
			// TODO CursedDisciple_LOOT_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cursed Disciple"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cursed Disciple"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cursed Disciple"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_258] Dire Mole - COST:1 [ATK:1/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DireMole_LOOT_258()
		{
			// TODO DireMole_LOOT_258 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dire Mole"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dire Mole"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dire Mole"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_291] Shroom Brewer - COST:4 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 4_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShroomBrewer_LOOT_291()
		{
			// TODO ShroomBrewer_LOOT_291 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shroom Brewer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shroom Brewer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shroom Brewer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_315] Trogg Gloomeater - COST:5 [ATK:1/HP:5] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggGloomeater_LOOT_315()
		{
			// TODO TroggGloomeater_LOOT_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Gloomeater"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Gloomeater"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Gloomeater"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_347] Kobold Apprentice - COST:3 [ATK:2/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage randomly split among all_enemies.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldApprentice_LOOT_347()
		{
			// TODO KoboldApprentice_LOOT_347 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Apprentice"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Apprentice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Apprentice"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_357] Marin the Fox - COST:8 [ATK:6/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/8 Treasure Chest for your opponent. <i>(Break it for awesome loot!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarinTheFox_LOOT_357()
		{
			// TODO MarinTheFox_LOOT_357 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Marin the Fox"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Marin the Fox"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Marin the Fox"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_375] Guild Recruiter - COST:5 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Recruit</b> a minion that costs (4) or less.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GuildRecruiter_LOOT_375()
		{
			// TODO GuildRecruiter_LOOT_375 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Guild Recruiter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Guild Recruiter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Guild Recruiter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_382] Kobold Monk - COST:4 [ATK:3/HP:6] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can't be targeted by spells or Hero_Powers.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldMonk_LOOT_382()
		{
			// TODO KoboldMonk_LOOT_382 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Monk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Monk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Monk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_383] Hungry Ettin - COST:6 [ATK:4/HP:10] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Summon a random 2-Cost minion for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HungryEttin_LOOT_383()
		{
			// TODO HungryEttin_LOOT_383 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hungry Ettin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Ettin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hungry Ettin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_388] Fungal Enchanter - COST:3 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FungalEnchanter_LOOT_388()
		{
			// TODO FungalEnchanter_LOOT_388 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungal Enchanter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungal Enchanter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungal Enchanter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_389] Rummaging Kobold - COST:3 [ATK:1/HP:3] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return one of your destroyed weapons to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RummagingKobold_LOOT_389()
		{
			// TODO RummagingKobold_LOOT_389 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rummaging Kobold"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rummaging Kobold"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rummaging Kobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_394] Shrieking Shroom - COST:3 [ATK:1/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a random
		//       1-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShriekingShroom_LOOT_394()
		{
			// TODO ShriekingShroom_LOOT_394 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shrieking Shroom"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shrieking Shroom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shrieking Shroom"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_413] Plated Beetle - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlatedBeetle_LOOT_413()
		{
			// TODO PlatedBeetle_LOOT_413 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plated Beetle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plated Beetle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plated Beetle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_414] Grand Archivist - COST:8 [ATK:4/HP:7] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, cast a spell from your deck <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandArchivist_LOOT_414()
		{
			// TODO GrandArchivist_LOOT_414 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Archivist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Archivist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Archivist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_516] Zola the Gorgon - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZolaTheGorgon_LOOT_516()
		{
			// TODO ZolaTheGorgon_LOOT_516 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zola the Gorgon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zola the Gorgon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zola the Gorgon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_521] Master Oakheart - COST:9 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Recruit</b> a 1, 2, and 3-Attack minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterOakheart_LOOT_521()
		{
			// TODO MasterOakheart_LOOT_521 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master Oakheart"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Oakheart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master Oakheart"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_526] The Darkness - COST:4 [ATK:20/HP:20] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Starts dormant.
		//       <b>Battlecry:</b> Shuffle 3 Candles
		//       into the enemy deck. When
		//       drawn, this awakens.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheDarkness_LOOT_526()
		{
			// TODO TheDarkness_LOOT_526 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Darkness"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Darkness"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_529] Void Ripper - COST:3 [ATK:3/HP:3] 
		// - Race: demon, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap the
		//       Attack and Health of all_other_minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoidRipper_LOOT_529()
		{
			// TODO VoidRipper_LOOT_529 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Ripper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Ripper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Ripper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_539] Spiteful Summoner - COST:6 [ATK:4/HP:4] 
		// - Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Reveal a spell
		//       from your deck. Summon
		//        a random minion with
		//       the same Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpitefulSummoner_LOOT_539()
		{
			// TODO SpitefulSummoner_LOOT_539 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiteful Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiteful Summoner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiteful Summoner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_540] Dragonhatcher - COST:9 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, <b>Recruit</b> a Dragon.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragonhatcher_LOOT_540()
		{
			// TODO Dragonhatcher_LOOT_540 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonhatcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonhatcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonhatcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_541] King Togwaggle - COST:8 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Swap decks
		//       with your opponent.
		//       Give them a Ransom
		//       spell to swap back.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingTogwaggle_LOOT_541()
		{
			// TODO KingTogwaggle_LOOT_541 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Togwaggle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Togwaggle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King Togwaggle"));
		}

	}

}
