using System.Linq;
using SabberStoneCore.Enums;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : Zone<IPlayable>
	{
		public int StartingCards { get; set; } = 30;

		public DeckZone(Game game, Controller controller) : base(game, controller, Zone.DECK)
		{
		}

		public void Fill(List<string> excludeIds = null)
		{
			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			int cardsToAdd = StartingCards - Count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", $"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
			while (cardsToAdd > 0)
			{
				Card card = Util.Choose<Card>(cards.ToList());

				// don't add cards that have to be excluded here.
				if (excludeIds != null && excludeIds.Contains(card.Id))
					continue;

				// don't add cards that have already reached max occurence in deck.
				if (this.Count(c => c.Card == card) >= card.MaxAllowedInDeck)
					continue;

				Entity.FromCard(Controller, card, null, this);

				cardsToAdd--;
			}
		}

		public void Shuffle(int times = 100)
		{
			// no need to shuffle something that has no or only one entity ...
			if (Count < 2)
			{
				return;
			}

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", $"Deck[{Game.FormatType}] from {Controller.Name} shuffling ({times}x).");
			for (int i = 0; i < times; i++)
			{
				Swap(Random, Random);
			}
		}
	}
}
