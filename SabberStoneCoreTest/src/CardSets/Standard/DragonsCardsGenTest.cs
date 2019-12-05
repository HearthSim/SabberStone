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
	public class NeutralDragonsTest
	{
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
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
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

	}

}
