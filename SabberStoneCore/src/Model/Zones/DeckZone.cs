using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;


namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : LimitedZone<IPlayable>
	{
		public const int StartingCards = 30;

		public DeckZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
			MaxSize = 60;
			Entities = new IPlayable[MaxSize];
			Type = Zone.DECK;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			base.Add(entity, zonePosition);

			if (entity.Power?.Trigger?.TriggerActivation == TriggerActivation.DECK)
				entity.Power.Trigger.Activate(entity);
		}

		public IPlayable TopCard => Entities[_count - 1];

		public void Fill(List<string> excludeIds = null)
		{
			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			int cardsToAdd = StartingCards - _count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
			while (cardsToAdd > 0)
			{
				Card card = Util.Choose<Card>(cards.ToList());

				// don't add cards that have to be excluded here.
				if (excludeIds != null && excludeIds.Contains(card.Id))
					continue;

				// don't add cards that have already reached max occurence in deck.
				if (this.Count(c => c.Card == card) >= card.MaxAllowedInDeck)
					continue;

				Controller.DeckCards.Add(card);

				Entity.FromCard(Controller, card, null, this);

				cardsToAdd--;
			}
		}

		public void Shuffle()
		{
			int n = _count;

			Random rnd = Util.Random;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"{Controller.Name} shuffles its deck.");

			for (int i = 0; i < n; i++)
			{
				int r = rnd.Next(i, n);
				IPlayable temp = Entities[i];
				Entities[i] = Entities[r];
				Entities[r] = temp;
			}
		}
	}
}
