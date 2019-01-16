﻿#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;


namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : LimitedZone<IPlayable>
	{
		public const int StartingCards = 30;

		public DeckZone(Controller controller) : base(60)
		{
			Game = controller.Game;
			Controller = controller;
			Type = Zone.DECK;
		}

		private DeckZone(Controller c, DeckZone zone) : base(c, zone)
		{
			Type = Zone.DECK;
		}

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			entity.Power?.Trigger?.Activate(entity, TriggerActivation.DECK);
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

				IPlayable entity = Entity.FromCard(Controller, card);
				Add(entity, 0);

				cardsToAdd--;
			}
		}

		public void Shuffle()
		{
			int n = _count;

			Random rnd = Util.Random;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"{Controller.Name} shuffles its deck.");

			var entities = (IPlayable[])Entities;
			for (int i = 0; i < n; i++)
			{
				int r = rnd.Next(i, n);
				IPlayable temp = entities[i];
				entities[i] = entities[r];
				entities[r] = temp;
			}
		}

		public DeckZone Clone(Controller c)
		{
			return new DeckZone(c, this);
		}
	}
}
