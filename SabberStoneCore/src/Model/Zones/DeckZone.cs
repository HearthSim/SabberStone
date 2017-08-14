using System.Linq;
using SabberStoneCore.Enums;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : Zone<IPlayable>
	{
		public int StartingCards { get; set; } = 30;

		/// <summary>
		/// Array of <see cref="Card.Id"/>s which result in unpredictable test outcomes when included
		/// in a <see cref="Controller"/>'s deck.
		/// </summary>
		private static string[] _unpredictableCardIDs = { "KAR_096", // Prince Malchezaar
														};

		public DeckZone(Game game, Controller controller) : base(game, controller, Zone.DECK)
		{
		}

		/// <summary>
		/// Fills the deck of the current player with random cards, according to the defined format type.
		/// </summary>
		/// <param name="predictable">
		/// Do not include cards which directly impact the game state because they
		/// were simply added to the deck. (eg: Card Prince Malchezaar and Choose one cards)
		/// This also prevents multiple copies of the same card being added to the deck.
		/// </param>
		public void Fill(bool predictable = false)
		{
			IEnumerable<Card> eligibleCards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			int cardsToAdd = StartingCards - Count;

			List<Card> cardsToChooseFrom;
			if (predictable)
			{
				cardsToChooseFrom = eligibleCards.Where(c => !_unpredictableCardIDs.Contains(c.Id) && !c.Tags.ContainsKey(GameTag.CHOOSE_ONE)).ToList();
			}
			else
			{
				cardsToChooseFrom = eligibleCards.ToList();
			}

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", $"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
			while (cardsToAdd > 0)
			{
				Card card = Util.Choose(cardsToChooseFrom);

				// Check maximum allowed copies in deck.
				int numCopies = this.Count(c => c.Card == card);
				if ((predictable && numCopies > 0) || (numCopies >= card.MaxAllowedInDeck))
				{
					continue;
				}

				// Build an entity from this card and add it to this zone.
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
			for (var i = 0; i < times; i++)
			{
				Swap(Random, Random);
			}
		}
	}
}
