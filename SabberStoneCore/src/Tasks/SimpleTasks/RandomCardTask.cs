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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomCardTask : SimpleTask
	{
		private static readonly ConcurrentDictionary<(int, CardClass), Card[]> CachedCardLists =
			new ConcurrentDictionary<(int, CardClass), Card[]>();

		private readonly CardSet _cardSet;
		private readonly CardType _cardType;
		private readonly GameTag[] _gameTagFilter;
		private readonly bool _opposite;
		private readonly Race _race;
		private readonly Rarity _rarity;

		private readonly EntityType _type;
		private readonly CardClass _cardClass;


		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="type">EntityType to choose the random card from.</param>
		/// <param name="opposite">If the card is for the opponent</param>
		public RandomCardTask(EntityType type, bool opposite = false)
		{
			_type = type;
			_cardType = CardType.INVALID;
			_cardSet = CardSet.INVALID;
			_cardClass = CardClass.INVALID;
			_race = Race.INVALID;
			_rarity = Rarity.INVALID;
			_gameTagFilter = null;
			_opposite = opposite;
		}

		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="cardType">CardType filter</param>
		/// <param name="cardClass">Cardclass filter</param>
		/// <param name="gameTagFilter">GameTags that must be contained in the card</param>
		/// <param name="opposite">If the card is for the opponent</param>
		public RandomCardTask(CardType cardType, CardClass cardClass, Race race = Race.INVALID,
			Rarity rarity = Rarity.INVALID, GameTag[] gameTagFilter = null, bool opposite = false)
		{
			_type = EntityType.INVALID;
			_cardType = cardType;
			_cardClass = cardClass;
			_cardSet = CardSet.INVALID;
			_race = race;
			_rarity = rarity;
			_gameTagFilter = gameTagFilter;
			_opposite = opposite;
		}

		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="cardSet">CardSet to choose the random card from.</param>
		public RandomCardTask(CardSet cardSet)
		{
			_type = EntityType.INVALID;
			_cardType = CardType.INVALID;
			_cardClass = CardClass.INVALID;
			_cardSet = cardSet;
			_gameTagFilter = null;
			_opposite = false;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			CardClass cardClass;

			switch (_type)
			{
				case EntityType.HERO:
					cardClass = controller.HeroClass;
					break;
				case EntityType.OP_HERO:
					cardClass = controller.Opponent.HeroClass;
					break;
				case EntityType.INVALID:
					cardClass = _cardClass;
					break;
				default:
					throw new NotImplementedException();
			}


			IReadOnlyList<Card> cardsList =
				GetCardList(source, _cardType, cardClass, _cardSet, _race, _rarity, _gameTagFilter);


			IPlayable randomCard =
				Entity.FromCard(_opposite ? controller.Opponent : controller, cardsList.Choose(game.Random));
			stack.Playables = new []{randomCard};

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public static IReadOnlyList<Card> GetCardList(IEntity source, CardType cardType = CardType.INVALID,
			CardClass cardClass = CardClass.INVALID, CardSet cardSet = CardSet.INVALID, Race race = Race.INVALID,
			Rarity rarity = Rarity.INVALID, GameTag[] gameTagFilter = null)
		{
			IEnumerable<Card> cards = source.Game.FormatType == FormatType.FT_STANDARD
				? Cards.AllStandard
				: Cards.AllWild;

			if (!CachedCardLists.TryGetValue((source.Card.AssetId, cardClass), out Card[] cardsList))
			{
				cardsList = cards.Where(p =>
					(cardType == CardType.INVALID || p.Type == cardType) &&
					(cardClass == CardClass.INVALID || p.Class == cardClass) &&
					(cardSet == CardSet.INVALID || p.Set == cardSet) &&
					(race == Race.INVALID || p.IsRace(race)) &&
					(rarity == Rarity.INVALID || p.Rarity == rarity) &&
					(gameTagFilter == null ||
					 Array.TrueForAll(gameTagFilter, gameTag => p.Tags.ContainsKey(gameTag))) &&
					p[GameTag.QUEST] == 0).ToArray();

				CachedCardLists.TryAdd((source.Card.AssetId, cardClass), cardsList);
			}

			return cardsList;
		}
	}
}
