using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model.Zones;
using Xunit;
using Xunit.Abstractions;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class HeroesTrollTest
	{
		// ------------------------------------------ HERO - HUNTER
		// [TRL_065] Zul'jin - COST:10 [ATK:0/HP:30] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</bm> Cast all spells
		//       you've played this game
		//       <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 50579
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zuljin_TRL_065()
		{
			// TODO Zuljin_TRL_065 test
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
			//var testCard = (Hero) game.ProcessCard<Hero>("Zul'jin");
		}

	}

	public class HeroPowersTrollTest
	{
		// ------------------------------------ HERO_POWER - HUNTER
		// [TRL_065h] Berserker Throw (*) - COST:2 
		// - Set: troll, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BerserkerThrow_TRL_065h()
		{
			// TODO BerserkerThrow_TRL_065h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Berserker Throw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Berserker Throw"));
			//var testCard = (Hero_power) game.ProcessCard<Hero_power>("Berserker Throw");
		}

	}

	public class DruidTrollTest
	{
		// ----------------------------------------- MINION - DRUID
		// [TRL_223] Spirit of the Raptor - COST:1 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       After your hero attacks and
		//       __kills a minion, draw a card.__
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritOfTheRaptor_TRL_223()
		{
			// TODO SpiritOfTheRaptor_TRL_223 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Raptor"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Raptor");
		}

		// ----------------------------------------- MINION - DRUID
		// [TRL_232] Ironhide Direhorn - COST:7 [ATK:7/HP:7] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overkill:</b> Summon a 5/5_Ironhide Runt.
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronhideDirehorn_TRL_232()
		{
			// TODO IronhideDirehorn_TRL_232 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironhide Direhorn"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironhide Direhorn"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Ironhide Direhorn");
		}

		// ----------------------------------------- MINION - DRUID
		// [TRL_240] Savage Striker - COST:2 [ATK:2/HP:3] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage to an enemy minion equal to your hero's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK = 0
		// --------------------------------------------------------
		[Fact]
		public void SavageStriker_TRL_240()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Savage Striker"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savage Striker"));

			Minion target = game.ProcessCard<Minion>("Dalaran Mage");
			game.EndTurn();

			game.PlayHeroPower(autoRefresh: true);
			Assert.Equal(1, game.CurrentPlayer.Hero.AttackDamage);
			var testCard = (Minion)game.ProcessCard<Minion>("Savage Striker", target);
			Assert.Equal(1, target.Damage);

			game.PlayHeroPower();
			game.ProcessCard("Savage Striker", target);
			Assert.Equal(3, target.Damage);
		}

		// ----------------------------------------- MINION - DRUID
		// [TRL_241] Gonk, the Raptor - COST:7 [ATK:4/HP:9] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks and_kills a minion, it may_attack again.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void GonkTheRaptor_TRL_241()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gonk, the Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion target1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target2 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target3 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target4 = game.ProcessCard<Minion>("Bloodfen Raptor");
			game.EndTurn();
			//Minion target2 = game.Pro

			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gonk, the Raptor"));
			var testCard = (Minion)game.ProcessCard<Minion>("Gonk, the Raptor");
			game.PlayHeroPower();
			Hero hero = game.CurrentPlayer.Hero;
			hero.Attack(target1);
			hero.Attack(target2);
			hero.Attack(target3);
			hero.Attack(target4);

			Assert.False(hero.CanAttack);
			Assert.True(target1.IsDead);
			Assert.True(target2.IsDead);
			Assert.True(target3.IsDead);
		}

		// ----------------------------------------- MINION - DRUID
		// [TRL_341] Treespeaker - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform your Treants into 5/5 Ancients.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Treespeaker_TRL_341()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Treespeaker"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Landscaping");
			Assert.Equal("Treant", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Treant", game.CurrentPlayer.BoardZone[1].Card.Name);

			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Treespeaker"));
			var testCard = (Minion)game.ProcessCard<Minion>("Treespeaker");
			Assert.Equal("Ancient", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Ancient", game.CurrentPlayer.BoardZone[1].Card.Name);
		}

		// ----------------------------------------- MINION - DRUID
		// [TRL_343] Wardruid Loti - COST:3 [ATK:1/HP:2] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Choose One - </b>Transform into one of Loti's four dinosaur forms.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WardruidLoti_TRL_343()
		{
			// TODO WardruidLoti_TRL_343 test
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
			//var testCard = (Minion) game.ProcessCard<Minion>("Wardruid Loti");
		}

		// ------------------------------------------ SPELL - DRUID
		// [TRL_243] Pounce - COST:0 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Give your hero +2_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Pounce_TRL_243()
		{
			// TODO Pounce_TRL_243 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pounce"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pounce"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Pounce");
		}

		// ------------------------------------------ SPELL - DRUID
		// [TRL_244] Predatory Instincts - COST:4 
		// - Fac: neutral, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Draw a Beast from your
		//       deck. Double its Health.
		// --------------------------------------------------------
		[Fact]
		public void PredatoryInstincts_TRL_244()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Predatory Instincts"),
					Cards.FromName("Gonk, the Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Predatory Instincts"));
			var testCard = (Spell)game.ProcessCard<Spell>("Predatory Instincts");
			IPlayable drawn = game.IdEntityDic[game.CurrentPlayer.LastCardDrawn];

			Assert.True(drawn.Card.IsRace(Race.BEAST));
			Assert.Equal(drawn.Card.Health * 2, ((Minion)drawn).Health);
		}

		// ------------------------------------------ SPELL - DRUID
		// [TRL_254] Mark of the Loa - COST:4 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One</b> -
		//       Give a minion +2/+4
		//       and <b>Taunt</b>; or Summon
		//       two 3/2 Raptors.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkOfTheLoa_TRL_254()
		{
			// TODO MarkOfTheLoa_TRL_254 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mark of the Loa"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of the Loa"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Mark of the Loa");
		}

		// ------------------------------------------ SPELL - DRUID
		// [TRL_255] Stampeding Roar - COST:6 
		// - Fac: neutral, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon a random Beast from your hand and give it <b>Rush</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINION_OF_RACE_IN_HAND = 20
		// --------------------------------------------------------
		[Fact]
		public void StampedingRoar_TRL_255()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stampeding Roar"),
					Cards.FromName("Stampeding Roar"),
					Cards.FromName("Stampeding Roar"),
					Cards.FromName("Gonk, the Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stampeding Roar"));
			var testCard = (Spell)game.ProcessCard<Spell>("Stampeding Roar");
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[0].AttackableByRush);
		}

	}

	public class HunterTrollTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [TRL_348] Springpaw - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>
		//       <b>Battlecry:</b> Add a 1/1 Lynx
		//       with <b>Rush</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Springpaw_TRL_348()
		{
			// TODO Springpaw_TRL_348 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Springpaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Springpaw"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Springpaw");
		}

		// ---------------------------------------- MINION - HUNTER
		// [TRL_349] Bloodscalp Strategist - COST:3 [ATK:2/HP:4] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a weapon equipped, <b>Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodscalpStrategist_TRL_349()
		{
			// TODO BloodscalpStrategist_TRL_349 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodscalp Strategist"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodscalp Strategist"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Bloodscalp Strategist");
		}

		// ---------------------------------------- MINION - HUNTER
		// [TRL_900] Halazzi, the Lynx - COST:5 [ATK:3/HP:2] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Fill your hand with 1/1 Lynxes that have_<b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HalazziTheLynx_TRL_900()
		{
			// TODO HalazziTheLynx_TRL_900 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Halazzi, the Lynx"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Halazzi, the Lynx"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Halazzi, the Lynx");
		}

		// ---------------------------------------- MINION - HUNTER
		// [TRL_901] Spirit of the Lynx - COST:3 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       Whenever you summon a 
		//       Beast, give it +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheLynx_TRL_901()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Lynx"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Lynx"));
			var testCard = (Minion)game.ProcessCard<Minion>("Spirit of the Lynx");
			Assert.True(testCard.HasStealth);
			Minion beast = game.ProcessCard<Minion>("Stonetusk Boar");
			Assert.Equal(2, beast.AttackDamage);
			Assert.Equal(2, beast.Health);
			game.EndTurn();
			Assert.True(testCard.HasStealth);
			Minion opBeast = game.ProcessCard<Minion>("Stonetusk Boar");
			Assert.Equal(1, opBeast.AttackDamage);
			Assert.Equal(1, opBeast.Health);
			game.EndTurn();
			Assert.False(testCard.HasStealth);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [TRL_119] The Beast Within - COST:1 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a friendly Beast +1/+1, then it attacks a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheBeastWithin_TRL_119()
		{
			// TODO TheBeastWithin_TRL_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Beast Within"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Beast Within"));
			//var testCard = (Spell) game.ProcessCard<Spell>("The Beast Within");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [TRL_339] Master's Call - COST:3 
		// - Fac: neutral, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a minion in your deck.
		//       If all 3 are Beasts,
		//       draw them all.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void MastersCall_TRL_339()
		{
			// TODO MastersCall_TRL_339 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("River Crocolisk"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Master's Call"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master's Call"));
			var testCard = (Spell)game.ProcessCard<Spell>("Master's Call");
			Assert.Null(game.CurrentPlayer.Choice);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			Assert.Empty(game.CurrentPlayer.DeckZone);
			game.EndTurn();
			game.ProcessCard("Master's Call");
			Assert.NotNull(game.CurrentPlayer.Choice);

		}

		// ----------------------------------------- SPELL - HUNTER
		// [TRL_347] Baited Arrow - COST:5 
		// - Fac: neutral, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. <b>Overkill:</b> Summon a 5/5 Devilsaur. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaitedArrow_TRL_347()
		{
			// TODO BaitedArrow_TRL_347 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baited Arrow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baited Arrow"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Baited Arrow");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [TRL_566] Revenge of the Wild - COST:2 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon your Beasts that died this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN = 20
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void RevengeOfTheWild_TRL_566()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Revenge of the Wild"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Revenge of the Wild"));
			Assert.False(testCard.IsPlayable);

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target2 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Minion target3 = game.ProcessCard<Minion>("Wisp");
			target.Kill();
			target2.Kill();
			target3.Kill();

			Assert.True(testCard.IsPlayable);
			game.ProcessCard(testCard);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [TRL_111] Headhunter's Hatchet - COST:2 [ATK:2/HP:0] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you
		//       control a Beast, gain
		//       +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeadhuntersHatchet_TRL_111()
		{
			// TODO HeadhuntersHatchet_TRL_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Headhunter's Hatchet"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Headhunter's Hatchet"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Headhunter's Hatchet");
		}

	}

	public class MageTrollTest
	{
		// ------------------------------------------ MINION - MAGE
		// [TRL_311] Arcanosaur - COST:6 [ATK:3/HP:3] 
		// - Race: elemental, Fac: neutral, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you played an_Elemental last turn, deal_3_damage_to_all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Arcanosaur_TRL_311()
		{
			// TODO Arcanosaur_TRL_311 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcanosaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanosaur"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Arcanosaur");
		}

		// ------------------------------------------ MINION - MAGE
		// [TRL_315] Pyromaniac - COST:3 [ATK:3/HP:4] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever your Hero Power_kills a minion, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void Pyromaniac_TRL_315()
		{
			// TODO Pyromaniac_TRL_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pyromaniac"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyromaniac"));
			var testCard = (Minion)game.ProcessCard<Minion>("Pyromaniac");
			Minion target1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target2 = game.ProcessCard<Minion>("Bloodfen Raptor");

			int drawn = game.CurrentPlayer.NumCardsDrawnThisTurn;
			game.PlayHeroPower(target1, asZeroCost: true, autoRefresh: true);
			Assert.Equal(drawn + 1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			game.PlayHeroPower(target2, asZeroCost: true, autoRefresh: true);
			Assert.Equal(drawn + 1, game.CurrentPlayer.NumCardsDrawnThisTurn);
		}

		// ------------------------------------------ MINION - MAGE
		// [TRL_316] Jan'alai, the Dragonhawk - COST:7 [ATK:4/HP:4] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your Hero Power
		//       dealt 8 damage this game,
		//       summon Ragnaros the
		//       Firelord.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - PLAYER_TAG_THRESHOLD_TAG_ID = 1025
		// - PLAYER_TAG_THRESHOLD_VALUE = 8
		// --------------------------------------------------------
		[Fact]
		public void JanalaiTheDragonhawk_TRL_316()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jan'alai, the Dragonhawk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jan'alai, the Dragonhawk"));

			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);

			game.ProcessCard<Minion>("Jan'alai, the Dragonhawk", asZeroCost: true);
			Assert.Single(game.CurrentPlayer.BoardZone);

			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.ProcessCard<Minion>("Jan'alai, the Dragonhawk", asZeroCost: true);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.PlayHeroPower(game.CurrentOpponent.Hero, asZeroCost: true, autoRefresh: true);
			game.ProcessCard<Minion>("Jan'alai, the Dragonhawk", asZeroCost: true);
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);

			game.EndTurn();
			Assert.Equal(17, game.CurrentPlayer.Hero.Damage);
		}

		// ------------------------------------------ MINION - MAGE
		// [TRL_318] Hex Lord Malacrass - COST:8 [ATK:5/HP:5] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Add a copy of your opening hand to your hand <i>(except this card)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HexLordMalacrass_TRL_318()
		{
			// TODO HexLordMalacrass_TRL_318 test
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
			//var testCard = (Minion) game.ProcessCard<Minion>("Hex Lord Malacrass");
		}

		// ------------------------------------------ MINION - MAGE
		// [TRL_319] Spirit of the Dragonhawk - COST:2 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       Your Hero Power also targets
		//        adjacent minions.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheDragonhawk_TRL_319()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Dragonhawk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Dragonhawk"));

			var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Dragonhawk");

			Minion target1, target2, target3;
			target1 = game.ProcessCard<Minion>("Wisp");
			target2 = game.ProcessCard<Minion>("Wisp");
			target3 = game.ProcessCard<Minion>("Wisp");

			game.PlayHeroPower(target2, autoRefresh: true);
			Assert.True(target1.IsDead);
			Assert.True(target2.IsDead);
			Assert.True(target3.IsDead);

			game.ProcessCard("Daring Fire-Eater");
			target1 = game.ProcessCard<Minion>("River Crocolisk", asZeroCost: true);
			target2 = game.ProcessCard<Minion>("River Crocolisk", asZeroCost: true);
			target3 = game.ProcessCard<Minion>("River Crocolisk", asZeroCost: true);

			game.PlayHeroPower(target2, autoRefresh: true);
			Assert.True(target1.IsDead);
			Assert.True(target2.IsDead);
			Assert.True(target3.IsDead);

			game.PlayHeroPower(game.CurrentOpponent.Hero);
		}

		// ------------------------------------------ MINION - MAGE
		// [TRL_390] Daring Fire-Eater - COST:1 [ATK:1/HP:1] 
		// - Fac: neutral, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next Hero Power this turn deals 2_more damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DaringFireEater_TRL_390()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Daring Fire-Eater"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Daring Fire-Eater"));
			var testCard = (Minion) game.ProcessCard<Minion>("Daring Fire-Eater");
			game.PlayHeroPower(game.CurrentOpponent.Hero, autoRefresh: true);
			Assert.Equal(3, game.CurrentOpponent.Hero.Damage);
			game.PlayHeroPower(game.CurrentOpponent.Hero, autoRefresh: true);
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);
			game.EndTurn();
			Assert.Equal(0, game.CurrentOpponent.Hero.NativeTags[GameTag.HEROPOWER_DAMAGE]);
			game.ProcessCard<Minion>("Daring Fire-Eater");
			game.EndTurn();
			Assert.Equal(0, game.CurrentOpponent.Hero[GameTag.HEROPOWER_DAMAGE]);
		}

		// ------------------------------------------- SPELL - MAGE
		// [TRL_310] Elemental Evocation - COST:0 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: The next Elemental you_play this turn costs (2) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElementalEvocation_TRL_310()
		{
			// TODO ElementalEvocation_TRL_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elemental Evocation"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elemental Evocation"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Elemental Evocation");
		}

		// ------------------------------------------- SPELL - MAGE
		// [TRL_313] Scorch - COST:4 
		// - Fac: neutral, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Deal $4 damage to a
		//       minion. Costs (1) if you
		//       played an Elemental
		//       last turn. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Scorch_TRL_313()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scorch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Spell testCard = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scorch"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Scorch");

			Assert.Equal(testCard.Card.Cost, testCard.Cost);
			Minion elemental = game.ProcessCard<Minion>("Water Elemental");
			Assert.Equal(testCard.Card.Cost, testCard.Cost);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(1, testCard.Cost);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(testCard.Card.Cost, testCard.Cost);
			game.ProcessCard(testCard, elemental);
			Assert.Equal(4, elemental.Damage);
		}

		// ------------------------------------------- SPELL - MAGE
		// [TRL_317] Blast Wave - COST:5 
		// - Fac: neutral, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to_all minions.
		//       <b>Overkill</b>: Add a random Mage spell to your hand. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact]
		public void BlastWave_TRL_317()
		{
			// TODO BlastWave_TRL_317 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blast Wave"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blast Wave"));

			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("River Crocolisk");
			var testCard = (Spell)game.ProcessCard<Spell>("Blast Wave");

			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.Skip(4).ToList().TrueForAll(p => p.Card.Class == CardClass.MAGE));
		}

		// ------------------------------------------- SPELL - MAGE
		// [TRL_400] Splitting Image - COST:3 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void SplittingImage_TRL_400()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splitting Image"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splitting Image"));
			var testCard = (Spell)game.ProcessCard<Spell>("Splitting Image");
			Minion target = game.ProcessCard<Minion>("Argent Squire");
			game.EndTurn();

			Minion attacker = game.ProcessCard<Minion>("Stonetusk Boar");
			attacker.Attack(target);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Argent Squire", game.CurrentOpponent.BoardZone[1].Card.Name);
			Assert.True(game.CurrentOpponent.BoardZone[1].HasDivineShield);
		}

	}

	public class PaladinTrollTest
	{
		// --------------------------------------- MINION - PALADIN
		// [TRL_300] Shirvallah, the Tiger - COST:25 [ATK:7/HP:5] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>, <b>Rush</b>, <b>Lifesteal</b>
		//        Costs (1) less for each Mana
		//       you've spent on spells.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void ShirvallahTheTiger_TRL_300()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shirvallah, the Tiger"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Shirvallah, the Tiger");

			Assert.Equal(25, testCard.Cost);
			game.ProcessCard("Shrink Ray");
			Assert.Equal(20, testCard.Cost);
			game.ProcessCard("Shrink Ray");
			Assert.Equal(15, testCard.Cost);
		}

		// --------------------------------------- MINION - PALADIN
		// [TRL_306] Immortal Prelate - COST:2 [ATK:1/HP:3] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle this into your deck. It keeps any enchantments.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact]
		public void ImmortalPrelate_TRL_306()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			
			Minion testCard = game.ProcessCard<Minion>("Immortal Prelate");
			game.ProcessCard("Blessing of Kings", testCard, asZeroCost: true);
			Assert.Equal(5, testCard.AttackDamage);
			Assert.Equal(7, testCard.Health);

			testCard.Kill();
			Assert.Single(game.CurrentPlayer.DeckZone);
			Minion testCard2 = (Minion) Generic.Draw(game.CurrentPlayer);
			game.ProcessCard(testCard2, asZeroCost: true);
			Assert.Equal(5, testCard2.AttackDamage);
			Assert.Equal(7, testCard2.Health);

			game.ProcessCard("Sunfury Protector", asZeroCost: true);
			Assert.True(testCard2.HasTaunt);
			testCard2.Kill();
			Assert.Single(game.CurrentPlayer.DeckZone);
			Minion testCard3 = (Minion) Generic.Draw(game.CurrentPlayer);
			game.ProcessCard(testCard3, asZeroCost: true);
			Assert.Equal(5, testCard3.AttackDamage);
			Assert.Equal(7, testCard3.Health);
			Assert.True(testCard3.HasTaunt);

			game.ProcessCard("Abusive Sergeant", testCard3, asZeroCost: true);
			Assert.Equal(7, testCard3.AttackDamage);
			testCard3.Kill();
			game.EndTurn();
			game.EndTurn();

			Minion testCard4 = (Minion) game.CurrentPlayer.HandZone[0];
			game.ProcessCard(testCard4, asZeroCost: true);
			Assert.Equal(5, testCard4.AttackDamage);
			Assert.Equal(7, testCard4.Health);
			Assert.True(testCard4.HasTaunt);

			// May need more complicated tests.
			// Can't 100% sure about the implementation now.
		}

		// --------------------------------------- MINION - PALADIN
		// [TRL_308] High Priest Thekal - COST:3 [ATK:3/HP:4] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Convert all but 1_of your Hero's Health into Armor.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void HighPriestThekal_TRL_308()
		{
			// TODO HighPriestThekal_TRL_308 test
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
			var testCard = (Minion)game.ProcessCard<Minion>("High Priest Thekal");
			Assert.Equal(29, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(1, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - PALADIN
		// [TRL_309] Spirit of the Tiger - COST:4 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       After you cast a spell,
		//       summon a Tiger with stats
		//       equal to its Cost.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheTiger_TRL_309()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Tiger"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Tiger"));
			var testCard = (Minion)game.ProcessCard<Minion>("Spirit of the Tiger");
			game.ProcessCard("Blessing of Kings", testCard);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[1].Health);
		}

		// --------------------------------------- MINION - PALADIN
		// [TRL_545] Zandalari Templar - COST:4 [ATK:4/HP:4] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you've restored
		//       10 Health this game, gain
		//       +4/+4 and <b>Taunt</b>.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
		// - PLAYER_TAG_THRESHOLD_VALUE = 10
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZandalariTemplar_TRL_545()
		{
			// TODO ZandalariTemplar_TRL_545 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zandalari Templar"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zandalari Templar"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Zandalari Templar");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [TRL_302] Time Out! - COST:3 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Your hero is <b>Immune</b> until your next turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void TimeOut_TRL_302()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Time Out!"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Time Out!"));
			var testCard = (Spell)game.ProcessCard<Spell>("Time Out!");

			Assert.True(game.CurrentPlayer.Hero.IsImmune);
			game.EndTurn();
			Assert.True(game.CurrentOpponent.Hero.IsImmune);
			game.EndTurn();
			Assert.False(game.CurrentPlayer.Hero.IsImmune);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [TRL_305] A New Challenger... - COST:7 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a 6-Cost minion. Summon it with <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void ANewChallenger_TRL_305()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("A New Challenger..."),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var testCard = (Spell)game.ProcessCard<Spell>("A New Challenger...");
			Assert.NotNull(game.CurrentPlayer.Choice);
			game.ChooseNthChoice(1);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasTaunt);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasDivineShield);
			Assert.Equal(6, game.CurrentPlayer.BoardZone[0].Cost);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [TRL_307] Flash of Light - COST:2 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #4 Health.
		//       Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlashOfLight_TRL_307()
		{
			// TODO FlashOfLight_TRL_307 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flash of Light"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flash of Light"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Flash of Light");
		}

		// --------------------------------------- WEAPON - PALADIN
		// [TRL_304] Farraki Battleaxe - COST:5 [ATK:3/HP:0] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Overkill:</b> Give a minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FarrakiBattleaxe_TRL_304()
		{
			// TODO FarrakiBattleaxe_TRL_304 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Farraki Battleaxe"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Farraki Battleaxe"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Farraki Battleaxe");
		}

		// --------------------------------------- WEAPON - PALADIN
		// [TRL_543] Bloodclaw - COST:1 [ATK:2/HP:0] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodclaw_TRL_543()
		{
			// TODO Bloodclaw_TRL_543 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodclaw"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodclaw"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Bloodclaw");
		}

	}

	public class PriestTrollTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [TRL_131] Sand Drudge - COST:3 [ATK:3/HP:3] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a 1/1 Zombie with <b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SandDrudge_TRL_131()
		{
			// TODO SandDrudge_TRL_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sand Drudge"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sand Drudge"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Sand Drudge");
		}

		// ---------------------------------------- MINION - PRIEST
		// [TRL_259] Princess Talanji - COST:8 [ATK:7/HP:5] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon all minions from your hand that_didn't start in your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void PrincessTalanji_TRL_259()
		{
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

			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			var testCard = (Minion)game.ProcessCard<Minion>("Princess Talanji");

			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone
				.Skip(1).ToList().TrueForAll(m => m.Card.Name == "Wisp"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [TRL_260] Bwonsamdi, the Dead - COST:7 [ATK:7/HP:7] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw 1-Cost
		//       minions from your deck
		//       until your hand is full.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BwonsamdiTheDead_TRL_260()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bwonsamdi, the Dead"),
					Cards.FromName("Bwonsamdi, the Dead"),
					Cards.FromName("Bwonsamdi, the Dead"),
					Cards.FromName("Bwonsamdi, the Dead"),

					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),

					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bwonsamdi, the Dead"));
			var testCard = (Minion)game.ProcessCard<Minion>("Bwonsamdi, the Dead");
			Assert.True(game.CurrentPlayer.HandZone.IsFull);
			Assert.Equal(20, game.CurrentPlayer.DeckZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.Skip(4).ToList().TrueForAll(p => p.Card.Cost == 1));
		}

		// ---------------------------------------- MINION - PRIEST
		// [TRL_408] Grave Horror - COST:12 [ATK:7/HP:8] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Costs (1) less for each spell
		//       you've cast this game.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void GraveHorror_TRL_408()
		{
			// TODO GraveHorror_TRL_408 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grave Horror"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grave Horror"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Grave Horror");
		}

		// ---------------------------------------- MINION - PRIEST
		// [TRL_501] Auchenai Phantasm - COST:2 [ATK:3/HP:2] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> This turn, your healing effects deal damage instead.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void AuchenaiPhantasm_TRL_501()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Auchenai Phantasm"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Auchenai Phantasm"));
			var testCard = (Minion)game.ProcessCard<Minion>("Auchenai Phantasm");
			Assert.True(game.CurrentPlayer.RestoreToDamage);
			game.EndTurn();
			Assert.False(game.CurrentOpponent.RestoreToDamage);
		}

		// ---------------------------------------- MINION - PRIEST
		// [TRL_502] Spirit of the Dead - COST:1 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       After a friendly minion dies,
		//       shuffle a 1-Cost copy of it
		//       into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheDead_TRL_502()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Dead"),
					Cards.FromName("Spirit of the Dead"),
					Cards.FromName("Spirit of the Dead"),
					Cards.FromName("Spirit of the Dead"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Dead"));
			var testCard = (Minion)game.ProcessCard<Minion>("Spirit of the Dead");

			Assert.Empty(game.CurrentPlayer.DeckZone);

			Minion target1 = game.ProcessCard<Minion>("Bwonsamdi, the Dead", asZeroCost: true);
			Minion target2 = game.ProcessCard<Minion>("Bwonsamdi, the Dead", asZeroCost: true);
			Minion target3 = game.ProcessCard<Minion>("Bwonsamdi, the Dead", asZeroCost: true);
			Minion target4 = game.ProcessCard<Minion>("Bwonsamdi, the Dead", asZeroCost: true);
			Minion target5 = game.ProcessCard<Minion>("Bwonsamdi, the Dead", asZeroCost: true);
			target1.Kill();
			target2.Kill();
			target3.Kill();
			target4.Kill();
			target5.Kill();

			Assert.Equal(5, game.CurrentPlayer.DeckZone.Count);
			Assert.True(game.CurrentPlayer.DeckZone.ToList().TrueForAll(p => p.Card.Name == "Bwonsamdi, the Dead"));
			Assert.True(game.CurrentPlayer.DeckZone.ToList().TrueForAll(p => p.Cost == 1));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [TRL_097] Seance - COST:2 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Add_a copy of it to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Seance_TRL_097()
		{
			// TODO Seance_TRL_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seance"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seance"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Seance");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [TRL_128] Regenerate - COST:0 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #3 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Regenerate_TRL_128()
		{
			// TODO Regenerate_TRL_128 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Regenerate"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Regenerate"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Regenerate");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [TRL_258] Mass Hysteria - COST:5 
		// - Fac: neutral, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Force each minion to_attack another random minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void MassHysteria_TRL_258()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mass Hysteria"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mass Hysteria"));

			game.ProcessCard("Nightscale Matriarch", asZeroCost: true); // 4/9
			game.ProcessCard("Mountain Giant", asZeroCost: true); // 8/8

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			var testCard = (Spell)game.ProcessCard<Spell>("Mass Hysteria");
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Equal(2, game.CurrentPlayer.NumFriendlyMinionsThatAttackedThisTurn);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [TRL_500] Surrender to Madness - COST:3 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Destroy 3 of your Mana
		//       Crystals. Give all minions
		//       in your deck +2/+2.
		// --------------------------------------------------------
		[Fact]
		public void SurrenderToMadness_TRL_500()
		{
			// TODO SurrenderToMadness_TRL_500 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Surrender to Madness"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Surrender to Madness"));
			var testCard = (Spell)game.ProcessCard<Spell>("Surrender to Madness");
			Assert.Equal(7, game.CurrentPlayer.BaseMana);
			foreach (IPlayable p in game.CurrentPlayer.DeckZone)
				if (p is Minion m)
				{
					Assert.Equal(m.Card.ATK + 2, m.AttackDamage);
					Assert.Equal(m.Card.Health + 2, m.Health);
				}
		}

	}

	public class RogueTrollTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [TRL_071] Bloodsail Howler - COST:2 [ATK:1/HP:1] 
		// - Race: pirate, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>
		//       <b>Battlecry:</b> Gain +1/+1
		//       for each other Pirate
		//       you control.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodsailHowler_TRL_071()
		{
			// TODO BloodsailHowler_TRL_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsail Howler"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Howler"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Bloodsail Howler");
		}

		// ----------------------------------------- MINION - ROGUE
		// [TRL_077] Gurubashi Hypemon - COST:7 [ATK:5/HP:7] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a 1/1 copy of a <b>Battlecry</b> minion. It costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void GurubashiHypemon_TRL_077()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gurubashi Hypemon"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Hypemon"));
			var testCard = (Minion) game.ProcessCard<Minion>("Gurubashi Hypemon");
			Assert.Equal(3, game.CurrentPlayer.SetasideZone.Count);
			foreach (IPlayable p in game.CurrentPlayer.SetasideZone)
				Assert.Equal(1, p[GameTag.BATTLECRY]);

			Minion chosen = (Minion)game.ChooseNthChoice(1);
			Assert.Equal(1, chosen.AttackDamage);
			Assert.Equal(1, chosen.Health);
			Assert.Equal(1, chosen.Cost);
		}

		// ----------------------------------------- MINION - ROGUE
		// [TRL_092] Spirit of the Shark - COST:4 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       Your minions' <b>Battlecries</b>
		//       __and <b>Combos</b> trigger twice._
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheShark_TRL_092()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Shark"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Shark"));
			var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Shark");

			game.ProcessCard("SI:7 Agent", game.CurrentOpponent.Hero);
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);
			game.ProcessCard("Shattered Sun Cleric", testCard);
			Assert.Equal(2, testCard.AttackDamage);
			Assert.Equal(5, testCard.Health);
		}

		// ----------------------------------------- MINION - ROGUE
		// [TRL_126] Captain Hooktusk - COST:8 [ATK:6/HP:3] 
		// - Race: pirate, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon 3 Pirates from your deck. Give them <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CaptainHooktusk_TRL_126()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captain Hooktusk"),
					Cards.FromName("Captain Hooktusk"),
					Cards.FromName("Captain Hooktusk"),
					Cards.FromName("Captain Hooktusk"),
					Cards.FromName("Captain Hooktusk"),
					Cards.FromName("Captain Hooktusk"),
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
			var testCard = (Minion) game.ProcessCard<Minion>("Captain Hooktusk");

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			List<Minion> summoned = game.CurrentPlayer.BoardZone.Skip(1).ToList();
			Assert.True(summoned.TrueForAll(m => m.Card.IsRace(Race.PIRATE)));
			Assert.True(summoned.TrueForAll(m => m.AttackableByRush));
		}

		// ----------------------------------------- MINION - ROGUE
		// [TRL_409] Gral, the Shark - COST:5 [ATK:2/HP:2] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Eat a minion in
		//       your deck and gain its stats.
		//       <b>Deathrattle:</b> Add it to
		//       your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GralTheShark_TRL_409()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gral, the Shark"),
					Cards.FromName("Gral, the Shark"),
					Cards.FromName("Gral, the Shark"),
					Cards.FromName("Gral, the Shark"),
					Cards.FromName("Gral, the Shark"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gral, the Shark"));
			var testCard = (Minion) game.ProcessCard<Minion>("Gral, the Shark");

			Assert.Empty(game.CurrentPlayer.DeckZone);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(testCard.Card.ATK * 2, testCard.AttackDamage);
			Assert.Equal(testCard.Card.Health * 2, testCard.Health);

			testCard.Kill();
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Gral, the Shark", game.CurrentPlayer.HandZone[4].Card.Name);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [TRL_124] Raiding Party - COST:3 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw 2 Pirates from_your deck.
		//       <b>Combo:</b> And a weapon.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaidingParty_TRL_124()
		{
			// TODO RaidingParty_TRL_124 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raiding Party"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raiding Party"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Raiding Party");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [TRL_127] Cannon Barrage - COST:6 
		// - Fac: neutral, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $3 damage to a
		//       random enemy. Repeat
		//       for each of your Pirates. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CannonBarrage_TRL_127()
		{
			// TODO CannonBarrage_TRL_127 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cannon Barrage"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cannon Barrage"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Cannon Barrage");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [TRL_156] Stolen Steel - COST:2 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a weapon <i>(from another class)</i>.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void StolenSteel_TRL_156()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stolen Steel"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stolen Steel"));
			var testCard = (Spell) game.ProcessCard<Spell>("Stolen Steel");
			Assert.NotNull(game.CurrentPlayer.Choice);
			Assert.Equal(3, game.CurrentPlayer.SetasideZone.Count);
			IPlayable chosen = game.ChooseNthChoice(1);
			Assert.Equal(CardType.WEAPON, chosen.Card.Type);
			Assert.NotEqual(CardClass.ROGUE, chosen.Card.Class);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [TRL_157] Walk the Plank - COST:4 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy an undamaged minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_UNDAMAGED_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WalkThePlank_TRL_157()
		{
			// TODO WalkThePlank_TRL_157 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Walk the Plank"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Walk the Plank"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Walk the Plank");
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [TRL_074] Serrated Tooth - COST:1 [ATK:1/HP:0] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your minions <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SerratedTooth_TRL_074()
		{
			// TODO SerratedTooth_TRL_074 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Serrated Tooth"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Serrated Tooth"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Serrated Tooth");
		}

	}

	public class ShamanTrollTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [TRL_059] Bog Slosher - COST:3 [ATK:3/HP:3] 
		// - Race: elemental, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return a friendly minion to your hand and give it +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void BogSlosher_TRL_059()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bog Slosher"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bog Slosher"));

			Minion target = game.ProcessCard<Minion>("Wisp");
			var testCard = (Minion) game.ProcessCard<Minion>("Bog Slosher", target);

			Assert.Equal(Zone.HAND, target.Zone.Type);
			Assert.Equal(3, target.AttackDamage);
			Assert.Equal(3, target.Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [TRL_060] Spirit of the Frog - COST:3 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b> for 1 turn.
		//       Whenever you cast a spell,
		//       draw a spell from your deck
		//       that costs (1) more.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheFrog_TRL_060()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Frog"),
					Cards.FromName("Spirit of the Frog"),
					Cards.FromName("Spirit of the Frog"),
					Cards.FromName("Spirit of the Frog"),
					Cards.FromName("Frost Shock")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Frog"));
			var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Frog");
			game.ProcessCard("Totemic Might");
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, game.CurrentPlayer.HandZone[4].Cost);
			Assert.Equal(CardType.SPELL, game.CurrentPlayer.HandZone[4].Card.Type);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [TRL_085] Zentimo - COST:3 [ATK:1/HP:3] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever you target a
		//       minion with a spell, cast it
		//       again on its neighbors.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Zentimo_TRL_085()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard<Minion>("Zentimo");

			Minion target1 = game.ProcessCard<Minion>("Wisp");
			Minion target2 = game.ProcessCard<Minion>("Wisp");
			Minion target3 = game.ProcessCard<Minion>("Wisp");

			game.ProcessCard("Lightning Bolt", target2);
			Assert.True(target1.IsDead);
			Assert.True(target2.IsDead);
			Assert.True(target3.IsDead);
			Assert.Equal(3, game.CurrentPlayer.OverloadOwed);

			target1 = game.ProcessCard<Minion>("Salty Dog", asZeroCost: true);
			target2 = game.ProcessCard<Minion>("Salty Dog", asZeroCost: true);
			target3 = game.ProcessCard<Minion>("Salty Dog", asZeroCost: true);

			Minion fandral = game.ProcessCard<Minion>("Fandral Staghelm", asZeroCost: true);
			Assert.True(game.CurrentPlayer.ChooseBoth);

			game.ProcessCard("Wrath", target2);
			Assert.True(target1.IsDead);
			Assert.True(target2.IsDead);
			Assert.True(target3.IsDead);
			Assert.Equal(4, game.CurrentPlayer.NumCardsDrawnThisTurn);

			game.EndTurn();
			game.ProcessCard("Counterspell");
			game.EndTurn();

			target1 = game.ProcessCard<Minion>("Wisp");
			target2 = game.ProcessCard<Minion>("Wisp");
			target3 = game.ProcessCard<Minion>("Wisp");
			Spell spell = game.ProcessCard<Spell>("Moonfire", target2);
			Assert.True(spell.IsCountered);
			fandral.Attack(game.CurrentOpponent.Hero);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [TRL_345] Krag'wa, the Frog - COST:6 [ATK:4/HP:6] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return all spells you played last turn to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KragwaTheFrog_TRL_345()
		{
			// TODO KragwaTheFrog_TRL_345 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Krag'wa, the Frog"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Krag'wa, the Frog"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Krag'wa, the Frog");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [TRL_522] Wartbringer - COST:1 [ATK:2/HP:1] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you played 2_spells this turn, deal 2_damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wartbringer_TRL_522()
		{
			// TODO Wartbringer_TRL_522 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wartbringer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wartbringer"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Wartbringer");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [TRL_012] Totemic Smash - COST:1 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage. <b>Overkill</b>: Summon a basic Totem. @spelldmg
		// --------------------------------------------------------
		// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicSmash_TRL_012()
		{
			// TODO TotemicSmash_TRL_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totemic Smash"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Smash"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Totemic Smash");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [TRL_058] Haunting Visions - COST:3 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: The next spell you cast this turn costs (3) less. <b>Discover</b> a spell.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HauntingVisions_TRL_058()
		{
			// TODO HauntingVisions_TRL_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Haunting Visions"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Haunting Visions"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Haunting Visions");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [TRL_082] Big Bad Voodoo - COST:2 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a friendly minion "<b>Deathrattle:</b> Summon a random minion that costs (1) more."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void BigBadVoodoo_TRL_082()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Voodoo"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Voodoo"));

			Minion target = game.ProcessCard<Minion>("Wisp");

			var testCard = (Spell) game.ProcessCard<Spell>("Big Bad Voodoo", target);
			target.Kill();
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Cost);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [TRL_351] Rain of Toads - COST:6 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Summon three 2/4 Toads with <b>Taunt</b>. <b>Overload:</b> (3)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfToads_TRL_351()
		{
			// TODO RainOfToads_TRL_351 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Toads"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Toads"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Rain of Toads");
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [TRL_352] Likkim - COST:2 [ATK:1/HP:0] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Has +2 Attack while you have <b>Overloaded</b> Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Likkim_TRL_352()
		{
			// TODO Likkim_TRL_352 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Likkim"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Likkim"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Likkim");
		}

	}

	public class WarlockTrollTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [TRL_247] Soulwarden - COST:6 [ATK:6/HP:6] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 3 random cards you discarded this game to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Soulwarden_TRL_247()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulwarden"));

			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);
			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);
			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);
			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);

			Assert.Empty(game.CurrentPlayer.HandZone);

			var testCard = (Minion) game.ProcessCard<Minion>("Soulwarden");

			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.ToList().TrueForAll(p => p.Card.Name == "Wisp"));

		}

		// --------------------------------------- MINION - WARLOCK
		// [TRL_251] Spirit of the Bat - COST:2 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Stealth</b> for 1 turn.
		//       After a friendly minion dies, give a minion in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritOfTheBat_TRL_251()
		{
			// TODO SpiritOfTheBat_TRL_251 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Bat"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Bat"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Bat");
		}

		// --------------------------------------- MINION - WARLOCK
		// [TRL_252] High Priestess Jeklik - COST:4 [ATK:3/HP:4] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>, <b>Lifesteal</b>
		//       When you discard this,
		//       add 2 copies of it to
		//       your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - InvisibleDeathrattle = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void HighPriestessJeklik_TRL_252()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("High Priestess Jeklik"),
					Cards.FromName("High Priestess Jeklik"),
					Cards.FromName("High Priestess Jeklik"),
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
			//var testCard = (Minion) game.ProcessCard<Minion>("High Priestess Jeklik");

			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.Skip(3).ToList()
				.TrueForAll(p => p.Card.Name == "High Priestess Jeklik"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [TRL_253] Hir'eek, the Bat - COST:8 [ATK:1/HP:1] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Fill your board with copies of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void HireekTheBat_TRL_253()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hir'eek, the Bat"),
					Cards.FromName("Hir'eek, the Bat"),
					Cards.FromName("Hir'eek, the Bat"),
					Cards.FromName("Hir'eek, the Bat"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard<Minion>("Spirit of the Bat");
			Minion target = game.ProcessCard<Minion>("Wisp");
			target.Kill();
			Minion testCard = game.CurrentPlayer.HandZone.FirstOrDefault(p => p is Minion m && m.AttackDamage > 1) as Minion;
			Assert.NotNull(testCard);
			game.ProcessCard(testCard);
			Assert.True(game.CurrentPlayer.BoardZone.IsFull);
			Assert.True(game.CurrentPlayer.BoardZone.Skip(1).ToList().TrueForAll(m => m.AttackDamage > 1 && m.Health > 1));
		}

		// --------------------------------------- MINION - WARLOCK
		// [TRL_257] Blood Troll Sapper - COST:7 [ATK:5/HP:8] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: After a friendly minion dies, deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodTrollSapper_TRL_257()
		{
			// TODO BloodTrollSapper_TRL_257 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Troll Sapper"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Troll Sapper"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Blood Troll Sapper");
		}

		// --------------------------------------- MINION - WARLOCK
		// [TRL_551] Reckless Diretroll - COST:3 [ATK:2/HP:6] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Discard your lowest Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - DISCARD_CARDS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecklessDiretroll_TRL_551()
		{
			// TODO RecklessDiretroll_TRL_551 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reckless Diretroll"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Diretroll"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Reckless Diretroll");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [TRL_245] Shriek - COST:1 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Discard your lowest Cost card. Deal $2 damage to all minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - DISCARD_CARDS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shriek_TRL_245()
		{
			// TODO Shriek_TRL_245 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shriek"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shriek"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Shriek");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [TRL_246] Void Contract - COST:8 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy half of each player's deck.
		// --------------------------------------------------------
		[Fact]
		public void VoidContract_TRL_246()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Contract"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Contract"));

			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(26, game.CurrentOpponent.DeckZone.Count);

			var testCard = (Spell)game.ProcessCard<Spell>("Void Contract");
			Assert.Equal(13, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(13, game.CurrentOpponent.DeckZone.Count);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [TRL_249] Grim Rally - COST:1 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a friendly minion. Give your minions +1/+1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimRally_TRL_249()
		{
			// TODO GrimRally_TRL_249 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grim Rally"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grim Rally"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Grim Rally");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [TRL_555] Demonbolt - COST:8 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion. Costs (1) less for each minion you control.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demonbolt_TRL_555()
		{
			// TODO Demonbolt_TRL_555 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonbolt"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonbolt"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Demonbolt");
		}

	}

	public class WarriorTrollTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [TRL_323] Emberscale Drake - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain 5 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmberscaleDrake_TRL_323()
		{
			// TODO EmberscaleDrake_TRL_323 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emberscale Drake"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emberscale Drake"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Emberscale Drake");
		}

		// --------------------------------------- MINION - WARRIOR
		// [TRL_326] Smolderthorn Lancer - COST:3 [ATK:3/HP:2] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a damaged enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SmolderthornLancer_TRL_326()
		{
			// TODO SmolderthornLancer_TRL_326 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Smolderthorn Lancer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smolderthorn Lancer"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Smolderthorn Lancer");
		}

		// --------------------------------------- MINION - WARRIOR
		// [TRL_327] Spirit of the Rhino - COST:1 [ATK:0/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Stealth</b> for 1 turn.
		//       Your <b>Rush</b> minions are <b>Immune</b> the turn they're summoned.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritOfTheRhino_TRL_327()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit of the Rhino"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit of the Rhino"));
			var testCard = (Minion) game.ProcessCard<Minion>("Spirit of the Rhino");
			Minion test1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Assert.False(test1.IsImmune);
			Minion test2 = game.ProcessCard<Minion>("Akali, the Rhino");
			Assert.True(test2.IsImmune);
			game.EndTurn();
			Assert.False(test2.IsImmune);
		}

		// --------------------------------------- MINION - WARRIOR
		// [TRL_328] War Master Voone - COST:4 [ATK:4/HP:3] 
		// - Fac: neutral, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Copy all
		//       Dragons in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarMasterVoone_TRL_328()
		{
			// TODO WarMasterVoone_TRL_328 test
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
			//var testCard = (Minion) game.ProcessCard<Minion>("War Master Voone");
		}

		// --------------------------------------- MINION - WARRIOR
		// [TRL_329] Akali, the Rhino - COST:8 [ATK:5/HP:5] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Overkill:</b> Draw a <b>Rush</b> minion from your deck. Give it +5/+5.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - RUSH = 1
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AkaliTheRhino_TRL_329()
		{
			// TODO AkaliTheRhino_TRL_329 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Akali, the Rhino"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Akali, the Rhino"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Akali, the Rhino");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [TRL_321] Devastate - COST:1 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a damaged minion. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_DAMAGED_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Devastate_TRL_321()
		{
			// TODO Devastate_TRL_321 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devastate"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devastate"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Devastate");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [TRL_324] Heavy Metal! - COST:6 
		// - Fac: neutral, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Summon a random
		//       minion with Cost equal
		//       to your Armor <i>(up to 10).</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeavyMetal_TRL_324()
		{
			// TODO HeavyMetal_TRL_324 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heavy Metal!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heavy Metal!"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Heavy Metal!");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [TRL_362] Dragon Roar - COST:2 
		// - Fac: neutral, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Add 2 random Dragons to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonRoar_TRL_362()
		{
			// TODO DragonRoar_TRL_362 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Roar"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Roar"));
			//var testCard = (Spell) game.ProcessCard<Spell>("Dragon Roar");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [TRL_325] Sul'thraze - COST:6 [ATK:4/HP:0] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Overkill</b>: You may attack again.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact]
		public void Sulthraze_TRL_325()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sul'thraze"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sul'thraze"));

			Minion target1 = game.ProcessCard<Minion>("Wisp");
			Minion target2 = game.ProcessCard<Minion>("Wisp");
			game.EndTurn();

			var testCard = (Weapon) game.ProcessCard<Weapon>("Sul'thraze");
			game.CurrentPlayer.Hero.Attack(target1);
			Assert.True(target1.IsDead);
			Assert.True(game.CurrentPlayer.Hero.CanAttack);
			game.CurrentPlayer.Hero.Attack(target2);
			Assert.True(target2.IsDead);
			Assert.True(game.CurrentPlayer.Hero.CanAttack);
			game.CurrentPlayer.Hero.Attack(game.CurrentOpponent.Hero);
			Assert.False(game.CurrentPlayer.Hero.CanAttack);
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [TRL_360] Overlord's Whip - COST:3 [ATK:2/HP:0] 
		// - Fac: neutral, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a minion, deal 1 damage to it.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OverlordsWhip_TRL_360()
		{
			// TODO OverlordsWhip_TRL_360 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Overlord's Whip"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Overlord's Whip"));
			//var testCard = (Weapon) game.ProcessCard<Weapon>("Overlord's Whip");
		}

	}

	public class NeutralTrollTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [TRL_010] Half-Time Scavenger - COST:4 [ATK:3/HP:5] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Overkill</b>: Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact]
		public void HalfTimeScavenger_TRL_010()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Half-Time Scavenger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Half-Time Scavenger"));
			var testCard = (Minion)game.ProcessCard<Minion>("Half-Time Scavenger");
			testCard.IsExhausted = false;
			testCard.Attack(game.CurrentOpponent.Hero);
			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);
			game.EndTurn();

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion target2 = game.ProcessCard<Minion>("River Crocolisk");
			game.EndTurn();

			testCard.Attack(target);
			Assert.Equal(3, game.CurrentPlayer.Hero.Armor);
			testCard.IsExhausted = false;
			testCard.Attack(target2);
			Assert.True(target2.IsDead);
			Assert.Equal(3, game.CurrentPlayer.Hero.Armor);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_015] Ticket Scalper - COST:4 [ATK:5/HP:3] 
		// - Race: pirate, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overkill</b>: Draw 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TicketScalper_TRL_015()
		{
			// TODO TicketScalper_TRL_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ticket Scalper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ticket Scalper"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Ticket Scalper");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_020] Sightless Ranger - COST:5 [ATK:3/HP:4] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Overkill</b>: Summon two 1/1_Bats.
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SightlessRanger_TRL_020()
		{
			// TODO SightlessRanger_TRL_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sightless Ranger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sightless Ranger"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Sightless Ranger");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_057] Serpent Ward - COST:2 [ATK:0/HP:2] 
		// - Race: totem, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn,
		//       deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SerpentWard_TRL_057()
		{
			// TODO SerpentWard_TRL_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Serpent Ward"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Serpent Ward"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Serpent Ward");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_096] Griftah - COST:4 [ATK:4/HP:5] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> two
		//       cards. Give one to your
		//       opponent at random.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void Griftah_TRL_096()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Griftah"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Griftah"));
			var testCard = (Minion) game.ProcessCard<Minion>("Griftah");
			IPlayable chosen1 = game.ChooseNthChoice(1);
			IPlayable chosen2 = game.ChooseNthChoice(1);

			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);

			Assert.True(
				(game.CurrentPlayer.HandZone.Contains(chosen1) && game.CurrentOpponent.HandZone.Contains(chosen2)) ||
				(game.CurrentPlayer.HandZone.Contains(chosen2) && game.CurrentOpponent.HandZone.Contains(chosen1)));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_151] Former Champ - COST:5 [ATK:1/HP:1] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 5/5_Hotshot.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FormerChamp_TRL_151()
		{
			// TODO FormerChamp_TRL_151 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Former Champ"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Former Champ"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Former Champ");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_312] Spellzerker - COST:2 [ATK:2/HP:3] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Has <b>Spell Damage +2</b> while damaged.
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void Spellzerker_TRL_312()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellzerker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellzerker"));
			var testCard = (Minion)game.ProcessCard<Minion>("Spellzerker");
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
			game.PlayHeroPower(testCard);
			Assert.Equal(2, game.CurrentPlayer.CurrentSpellPower);
			game.ProcessCard("Regenerate", testCard);
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_363] Saronite Taskmaster - COST:1 [ATK:2/HP:3] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 0/3 Free Agent with <b>Taunt</b> for_your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SaroniteTaskmaster_TRL_363()
		{
			// TODO SaroniteTaskmaster_TRL_363 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Saronite Taskmaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saronite Taskmaster"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Saronite Taskmaster");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_405] Untamed Beastmaster - COST:3 [ATK:3/HP:4] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you draw a Beast, give it +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UntamedBeastmaster_TRL_405()
		{
			// TODO UntamedBeastmaster_TRL_405 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Untamed Beastmaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Untamed Beastmaster"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Untamed Beastmaster");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_406] Dozing Marksman - COST:2 [ATK:0/HP:4] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: Has +4 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DozingMarksman_TRL_406()
		{
			// TODO DozingMarksman_TRL_406 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dozing Marksman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dozing Marksman"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Dozing Marksman");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_407] Waterboy - COST:2 [ATK:2/HP:1] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next Hero Power this turn costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Waterboy_TRL_407()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Waterboy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Waterboy"));
			var testCard = (Minion)game.ProcessCard<Minion>("Waterboy");
			Assert.Equal(0, game.CurrentPlayer.Hero.HeroPower.Cost);
			game.EndTurn();
			Assert.Equal(2, game.CurrentPlayer.Hero.HeroPower.Cost);
			game.EndTurn();
			var testCard2 = (Minion)game.ProcessCard<Minion>("Waterboy");
			game.PlayHeroPower(game.CurrentOpponent.Hero);
			Assert.Equal(2, game.CurrentPlayer.Hero.HeroPower.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_503] Scarab Egg - COST:2 [ATK:0/HP:2] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon three 1/1 Scarabs.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScarabEgg_TRL_503()
		{
			// TODO ScarabEgg_TRL_503 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scarab Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scarab Egg"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Scarab Egg");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_504] Booty Bay Bookie - COST:2 [ATK:3/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your opponent a Coin.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BootyBayBookie_TRL_504()
		{
			// TODO BootyBayBookie_TRL_504 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Booty Bay Bookie"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Booty Bay Bookie"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Booty Bay Bookie");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_505] Helpless Hatchling - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Reduce the Cost of a Beast in your hand by (1).
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HelplessHatchling_TRL_505()
		{
			// TODO HelplessHatchling_TRL_505 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Helpless Hatchling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Helpless Hatchling"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Helpless Hatchling");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_506] Gurubashi Chicken - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overkill:</b> Gain +5 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GurubashiChicken_TRL_506()
		{
			// TODO GurubashiChicken_TRL_506 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gurubashi Chicken"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Chicken"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Gurubashi Chicken");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_507] Sharkfin Fan - COST:2 [ATK:2/HP:2] 
		// - Race: pirate, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: After your hero attacks, summon a 1/1 Pirate.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SharkfinFan_TRL_507()
		{
			// TODO SharkfinFan_TRL_507 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sharkfin Fan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sharkfin Fan"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Sharkfin Fan");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_508] Regeneratin' Thug - COST:4 [ATK:3/HP:5] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, restore #2 Health to this_minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RegeneratinThug_TRL_508()
		{
			// TODO RegeneratinThug_TRL_508 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Regeneratin' Thug"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Regeneratin' Thug"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Regeneratin' Thug");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_509] Banana Buffoon - COST:3 [ATK:2/HP:2] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BananaBuffoon_TRL_509()
		{
			// TODO BananaBuffoon_TRL_509 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Banana Buffoon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Banana Buffoon"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Banana Buffoon");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_512] Cheaty Anklebiter - COST:2 [ATK:2/HP:1] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CheatyAnklebiter_TRL_512()
		{
			// TODO CheatyAnklebiter_TRL_512 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cheaty Anklebiter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cheaty Anklebiter"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Cheaty Anklebiter");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_513] Mosh'Ogg Enforcer - COST:8 [ATK:2/HP:14] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoshoggEnforcer_TRL_513()
		{
			// TODO MoshoggEnforcer_TRL_513 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mosh'Ogg Enforcer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mosh'Ogg Enforcer"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Mosh'Ogg Enforcer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_514] Belligerent Gnome - COST:2 [ATK:1/HP:4] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> If your opponent
		//       has 2 or more minions,
		//       gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BelligerentGnome_TRL_514()
		{
			// TODO BelligerentGnome_TRL_514 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Belligerent Gnome"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Belligerent Gnome"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Belligerent Gnome");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_515] Rabble Bouncer - COST:7 [ATK:2/HP:7] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Costs (1) less for each enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RabbleBouncer_TRL_515()
		{
			// TODO RabbleBouncer_TRL_515 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rabble Bouncer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rabble Bouncer"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Rabble Bouncer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_516] Gurubashi Offering - COST:1 [ATK:0/HP:2] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, destroy this and gain 8_Armor.
		// --------------------------------------------------------
		// GameTag:
		// - 886 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GurubashiOffering_TRL_516()
		{
			// TODO GurubashiOffering_TRL_516 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gurubashi Offering"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Offering"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Gurubashi Offering");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_517] Arena Fanatic - COST:4 [ATK:2/HP:3] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArenaFanatic_TRL_517()
		{
			// TODO ArenaFanatic_TRL_517 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arena Fanatic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arena Fanatic"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Arena Fanatic");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_520] Murloc Tastyfin - COST:4 [ATK:3/HP:2] 
		// - Race: murloc, Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Draw 2 Murlocs
		//       from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocTastyfin_TRL_520()
		{
			// TODO MurlocTastyfin_TRL_520 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Tastyfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Tastyfin"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Murloc Tastyfin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_521] Arena Patron - COST:5 [ATK:3/HP:3] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Overkill:</b> Summon another Arena Patron.
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArenaPatron_TRL_521()
		{
			// TODO ArenaPatron_TRL_521 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arena Patron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arena Patron"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Arena Patron");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_523] Firetree Witchdoctor - COST:2 [ATK:2/HP:2] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       a Dragon, <b>Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FiretreeWitchdoctor_TRL_523()
		{
			// TODO FiretreeWitchdoctor_TRL_523 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Firetree Witchdoctor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Firetree Witchdoctor"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Firetree Witchdoctor");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_524] Shieldbreaker - COST:2 [ATK:2/HP:1] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> an enemy minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_MUST_TARGET_TAUNTER = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact]
		public void Shieldbreaker_TRL_524()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shieldbreaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion notTaunter = game.ProcessCard<Minion>("Wisp");
			Minion taunter = game.ProcessCard<Minion>("Shieldbearer");

			game.EndTurn();

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shieldbreaker"));
			Assert.False(testCard.IsValidPlayTarget(notTaunter));
			Assert.True(testCard.IsValidPlayTarget(taunter));
			game.ProcessCard(testCard, taunter);
			Assert.True(taunter.IsSilenced);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_525] Arena Treasure Chest - COST:4 [ATK:0/HP:4] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArenaTreasureChest_TRL_525()
		{
			// TODO ArenaTreasureChest_TRL_525 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arena Treasure Chest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arena Treasure Chest"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Arena Treasure Chest");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_526] Dragonmaw Scorcher - COST:5 [ATK:3/HP:6] 
		// - Race: dragon, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonmawScorcher_TRL_526()
		{
			// TODO DragonmawScorcher_TRL_526 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonmaw Scorcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonmaw Scorcher"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Dragonmaw Scorcher");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_527] Drakkari Trickster - COST:3 [ATK:3/HP:4] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give each player a
		//       copy of a random card from
		//       their opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DrakkariTrickster_TRL_527()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Wisp"),
				},
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Drakkari Trickster"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Single(game.CurrentPlayer.DeckZone);
			Assert.Single(game.CurrentOpponent.DeckZone);

			var testCard = (Minion)game.ProcessCard<Minion>("Drakkari Trickster");

			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.HandZone.Last().Card.Name);
			Assert.Equal("Wisp", game.CurrentOpponent.HandZone.Last().Card.Name);

			Assert.Single(game.CurrentPlayer.DeckZone);
			Assert.Single(game.CurrentOpponent.DeckZone);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_528] Linecracker - COST:7 [ATK:5/HP:10] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Overkill:</b> Double this minion's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact]
		public void Linecracker_TRL_528()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Linecracker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Linecracker"));
			var testCard = (Minion)game.ProcessCard<Minion>("Linecracker");
			game.EndTurn();

			Minion target1 = game.ProcessCard<Minion>("Wisp");
			Minion target2 = game.ProcessCard<Minion>("Wisp");
			game.EndTurn();

			testCard.Attack(target1);
			Assert.Equal(testCard.Card.ATK * 2, testCard.AttackDamage);
			testCard.IsExhausted = false;
			testCard.Attack(target2);
			Assert.Equal(testCard.Card.ATK * 4, testCard.AttackDamage);
			game.EndTurn();

			Minion attacker = game.ProcessCard<Minion>("Stonetusk Boar");
			attacker.Attack(testCard);
			Assert.Equal(testCard.Card.ATK * 4, testCard.AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_530] Masked Contender - COST:3 [ATK:2/HP:4] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a_<b>Secret</b>, cast a <b>Secret</b> from_your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MaskedContender_TRL_530()
		{
			// TODO MaskedContender_TRL_530 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Masked Contender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Masked Contender"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Masked Contender");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_531] Rumbletusk Shaker - COST:4 [ATK:3/HP:2] 
		// - Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/2 Rumbletusk Breaker.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RumbletuskShaker_TRL_531()
		{
			// TODO RumbletuskShaker_TRL_531 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rumbletusk Shaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rumbletusk Shaker"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Rumbletusk Shaker");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_532] Mosh'Ogg Announcer - COST:5 [ATK:6/HP:5] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Enemies attacking this
		//       have a 50% chance to
		//       attack someone else.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoshoggAnnouncer_TRL_532()
		{
			// TODO MoshoggAnnouncer_TRL_532 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mosh'Ogg Announcer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mosh'Ogg Announcer"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Mosh'Ogg Announcer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_533] Ice Cream Peddler - COST:4 [ATK:3/HP:5] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a_<b>Frozen</b> minion, gain 8_Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void IceCreamPeddler_TRL_533()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Cream Peddler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Cream Peddler"));
			var testCard = (Minion)game.ProcessCard<Minion>("Ice Cream Peddler");
			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);
			game.ProcessCard("Frostbolt", testCard);
			game.ProcessCard("Ice Cream Peddler");
			Assert.Equal(8, game.CurrentPlayer.Hero.Armor);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_535] Snapjaw Shellfighter - COST:5 [ATK:3/HP:8] 
		// - Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Whenever an adjacent
		//       minion takes damage, this
		//       _minion takes it instead.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SnapjawShellfighter_TRL_535()
		{
			// TODO SnapjawShellfighter_TRL_535 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snapjaw Shellfighter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snapjaw Shellfighter"));

			Minion target1 = game.ProcessCard<Minion>("Wisp");
			var testCard = (Minion)game.ProcessCard<Minion>("Snapjaw Shellfighter");
			Minion target2 = game.ProcessCard<Minion>("Wisp");
			Minion target3 = game.ProcessCard<Minion>("Wisp");

			game.ProcessCard("Fireball", target1);
			Assert.False(target1.IsDead);
			Assert.Equal(6, testCard.Damage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_537] Da Undatakah - COST:8 [ATK:8/HP:5] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain the
		//       <b>Deathrattle</b> effects of
		//       3 friendly minions that
		//       died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void DaUndatakah_TRL_537()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Da Undatakah"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Da Undatakah"));

			Minion target1 = game.ProcessCard<Minion>("Saronite Taskmaster", asZeroCost: true);
			Minion target2 = game.ProcessCard<Minion>("Rumbletusk Shaker", asZeroCost: true);
			Minion target3 = game.ProcessCard<Minion>("Arena Treasure Chest", asZeroCost: true);

			target1.Kill();
			target2.Kill();
			target3.Kill();

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);

			var testCard = (Minion) game.ProcessCard<Minion>("Da Undatakah");
			testCard.Kill();
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(8, game.CurrentPlayer.HandZone.Count);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_541] Hakkar, the Soulflayer - COST:10 [ATK:9/HP:6] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle a Corrupted Blood into each player's deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void HakkarTheSoulflayer_TRL_541()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hakkar, the Soulflayer"),
				},
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hakkar, the Soulflayer"));
			var testCard = (Minion)game.ProcessCard<Minion>("Hakkar, the Soulflayer");
			testCard.Kill();
			Assert.Equal(1, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(1, game.CurrentOpponent.DeckZone.Count);

			game.EndTurn();

			Assert.Equal(3 + 1, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(2, game.CurrentPlayer.DeckZone.Count);

			game.EndTurn();
			game.EndTurn();

			Assert.Equal(4 + 3 + 3 + 2, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(4, game.CurrentPlayer.DeckZone.Count);
		}

		public NeutralTrollTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		private readonly ITestOutputHelper output;

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_542] Oondasta - COST:9 [ATK:7/HP:7] 
		// - Race: beast, Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Overkill:</b> Summon a Beast from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - RUSH = 1
		// - OVERKILL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Oondasta_TRL_542()
		{
			// TODO Oondasta_TRL_542 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Oondasta"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oondasta"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Oondasta");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_546] Ornery Tortoise - COST:3 [ATK:3/HP:5] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OrneryTortoise_TRL_546()
		{
			// TODO OrneryTortoise_TRL_546 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ornery Tortoise"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ornery Tortoise"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Ornery Tortoise");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_550] Amani War Bear - COST:7 [ATK:5/HP:7] 
		// - Race: beast, Set: troll, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AmaniWarBear_TRL_550()
		{
			// TODO AmaniWarBear_TRL_550 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Amani War Bear"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Amani War Bear"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Amani War Bear");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_564] Mojomaster Zihi - COST:6 [ATK:5/HP:5] 
		// - Set: troll, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Set each player to 5 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MojomasterZihi_TRL_564()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mojomaster Zihi"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mojomaster Zihi"));
			game.ProcessCard("Bloodfen Raptor");
			var testCard = (Minion)game.ProcessCard<Minion>("Mojomaster Zihi");
			Assert.Equal(10 - 2 - testCard.Card.Cost, game.CurrentPlayer.RemainingMana);
			Assert.Equal(5, game.CurrentPlayer.BaseMana);
			Assert.Equal(5, game.CurrentOpponent.BaseMana);

			//Assert.True()
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_569] Crowd Roaster - COST:7 [ATK:7/HP:4] 
		// - Race: dragon, Set: troll, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       a Dragon, deal 7 damage
		//       to an enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrowdRoaster_TRL_569()
		{
			// TODO CrowdRoaster_TRL_569 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crowd Roaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crowd Roaster"));
			//var testCard = (Minion) game.ProcessCard<Minion>("Crowd Roaster");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [TRL_570] Soup Vendor - COST:2 [ATK:1/HP:4] 
		// - Set: troll, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you restore 3 or more Health to your hero, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void SoupVendor_TRL_570()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soup Vendor"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soup Vendor"));
			var testCard = (Minion)game.ProcessCard<Minion>("Soup Vendor");
			game.ProcessCard("Regenerate", game.CurrentPlayer.Hero);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);

			game.CurrentPlayer.Hero.Damage = 3;
			game.ProcessCard("Regenerate", game.CurrentPlayer.Hero);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);

			game.EndTurn();

			game.CurrentOpponent.Hero.Damage = 3;
			game.ProcessCard("Regenerate", game.CurrentOpponent.Hero);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
		}

	}

}
