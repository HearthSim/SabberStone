using System.Linq;
using SabberStoneCore.Enums;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;
using System;

namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : Zone<IPlayable>
	{
		public int StartingCards { get; set; } = 30;

		public override int MaxSize => 9999;

		public DeckZone(Game game, Controller controller) : base(game, controller, Zone.DECK)
		{
		}

		public void Fill()
		{
			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			var cardsToAdd = StartingCards - Count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", $"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
			while (cardsToAdd > 0)
			{
				var card = Util.Choose<Card>(cards.ToList());
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
			for (var i = 0; i < times; i++)
			{
				Swap(Random, Random);
			}
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override Zone<IPlayable> InternalClone(Game newGame)
		{
			return new DeckZone(newGame, newGame.ControllerById(Controller.Id));
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
