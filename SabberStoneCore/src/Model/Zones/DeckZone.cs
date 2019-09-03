#region copyright
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
using SabberStoneCore.Exceptions;


namespace SabberStoneCore.Model.Zones
{
	public class DeckZone : LimitedZone<IPlayable>
	{
		public const int StartingCards = 30;
		public const int DeckMaximumCapcity = 60;

		public bool DrawWithRandom { get; set; }

		// TODO: Barnabus the Stomper
		public bool NoEvenCostCards { get; private set; } = true;
		public bool NoOddCostCards { get; private set; } = true;

		public DeckZone(Controller controller) : base(Zone.DECK, DeckMaximumCapcity)
		{
			Game = controller.Game;
			Controller = controller;
		}

		private DeckZone(Controller c, DeckZone zone) : base(c, zone)
		{
			NoEvenCostCards = zone.NoEvenCostCards;
			NoOddCostCards = zone.NoOddCostCards;
			DrawWithRandom = zone.DrawWithRandom;
		}

		public IPlayable Draw(IPlayable cardToDraw = null)
		{
			if (cardToDraw != null)
				return Remove(cardToDraw);

			if (DrawWithRandom)
				return Remove(Game.Random.Next(Count));

			return Remove(Count - 1);
		}

		public override bool IsFull => _count == DeckMaximumCapcity;

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			entity.Power?.Trigger?.Activate(entity, TriggerActivation.DECK);

			CheckParity(entity.Cost);
		}

		public override void ChangeEntity(IPlayable oldEntity, IPlayable newEntity)
		{
			Span<IPlayable> span = new Span<IPlayable>(_entities, 0, _count);
			bool flag = false;
			for (int i = 0; i < span.Length; i++)
				if (span[i] == oldEntity)
				{
					span[i] = newEntity;
					flag = true;
					break;
				}
			if (!flag) throw new ZoneException($"ChangeEntity: Can't find {oldEntity} in {this}.");
			newEntity.Zone = this;
		}

		public IPlayable TopCard => _entities[_count - 1];

		public void Fill(IReadOnlyCollection<string> excludeIds = null)
		{
			IReadOnlyList<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			int cardsToAdd = StartingCards - _count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" :
				$"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");

			Util.DeepCloneableRandom rnd = Game.Random;
			while (cardsToAdd > 0)
			{
				Card card = cards.Choose(rnd);

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

			Util.DeepCloneableRandom rnd = Game.Random;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"{Controller.Name} shuffles its deck.");

			var entities = _entities;
			for (int i = 0; i < n; i++)
			{
				int r = rnd.Next(i, n);
				IPlayable temp = entities[i];
				entities[i] = entities[r];
				entities[r] = temp;
			}
		}

		public void AddAtRandomPosition(IPlayable entity)
		{
			Add(entity, _count == 0 ? - 1 : Game.Random.Next(_count + 1));
		}

		public DeckZone Clone(Controller c)
		{
			return new DeckZone(c, this);
		}

		internal void SetEntity(int index, IPlayable newEntity)
		{
			_entities[index] = newEntity;
			newEntity.Zone = this;
			CheckParity(newEntity.Cost);
		}

		private void CheckParity(int cost)
		{
			if (!NoEvenCostCards && !NoOddCostCards) return;

			if ((cost & 1) == 0)
				NoEvenCostCards = false;
			else if (NoOddCostCards)
				NoOddCostCards = false;
		}
	}
}
