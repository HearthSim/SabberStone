using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;


namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : Zone<IPlayable>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? _count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.DECK_ZONE, Zone.DECK);
		}

		public DeckZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = 60;
			_entities = new IPlayable[MaxSize];
			Type = Zone.DECK;
		}

		public int StartingCards { get; set; } = 30;

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

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"{Controller.Name} shuffles its deck.");
			for (int i = 0; i < n; i++)
			{
				int r = i + Util.Random.Next(n - i);
				Swap(this[i], this[r]);
			}
		}
	}
}
