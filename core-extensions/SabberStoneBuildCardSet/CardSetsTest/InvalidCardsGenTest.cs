using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class MageInvalidTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [EX1_295] Ice Block - COST:3 
		// - Fac: neutral, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceBlock_EX1_295()
		{
			// TODO IceBlock_EX1_295 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Block"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Block"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Block"));
		}

	}

	public class NeutralInvalidTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [EX1_050] Coldlight Oracle - COST:3 [ATK:2/HP:2] 
		// - Race: murloc, Fac: neutral, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Each player draws 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColdlightOracle_EX1_050()
		{
			// TODO ColdlightOracle_EX1_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coldlight Oracle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldlight Oracle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coldlight Oracle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_620] Molten Giant - COST:20 [ATK:8/HP:8] 
		// - Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each damage your hero has taken.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoltenGiant_EX1_620()
		{
			// TODO MoltenGiant_EX1_620 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Molten Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Molten Giant"));
		}

	}

}
