﻿using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomCardTask : SimpleTask
	{
		private RandomCardTask(EntityType type, CardType cardType, CardClass cardClass, CardSet cardSet, List<GameTag> gameTagFilter, bool opposite)
		{
			Type = type;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = cardSet;
			GameTagFilter = gameTagFilter;
			Opposite = opposite;
		}

		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="type">EntityType to choose the random card from.</param>
		/// <param name="opposite">If the card is for the opponent</param>
		public RandomCardTask(EntityType type, bool opposite = false)
		{
			Type = type;
			CardType = CardType.INVALID;
			CardSet = CardSet.INVALID;
			GameTagFilter = null;
			Opposite = opposite;
		}

		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="cardType">CardType filter</param>
		/// <param name="cardClass">Cardclass filter</param>
		/// <param name="gameTagFilter">GameTags that must be contained in the card</param>
		/// <param name="opposite">If the card is for the opponent</param>
		public RandomCardTask(CardType cardType, CardClass cardClass, List<GameTag> gameTagFilter = null, bool opposite = false)
		{
			Type = EntityType.INVALID;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = CardSet.INVALID;
			GameTagFilter = gameTagFilter;
			Opposite = opposite;
		}

		/// <summary>
		/// Choose a random card that fits the criterias.
		/// </summary>
		/// <param name="cardSet">CardSet to choose the random card from.</param>
		public RandomCardTask(CardSet cardSet)
		{
			Type = EntityType.INVALID;
			CardType = CardType.INVALID;
			CardClass = CardClass.INVALID;
			CardSet = cardSet;
			GameTagFilter = null;
			Opposite = false;
		}

		public EntityType Type { get; set; }
		public CardType CardType { get; set; }
		public CardClass CardClass { get; set; }
		public CardSet CardSet { get; set; }
		public List<GameTag> GameTagFilter { get; set; }
		public bool Opposite { get; set; }

		public override TaskState Process()
		{

			switch (Type)
			{
				case EntityType.HERO:
					CardClass = Controller.HeroClass;
					break;
				case EntityType.OP_HERO:
					CardClass = Controller.Opponent.HeroClass;
					break;
				case EntityType.INVALID:
					break;
				default:
					throw new NotImplementedException();
			}

			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			IEnumerable<Card> cardsList = cards.Where(p =>
				(CardType == CardType.INVALID || p.Type == CardType) &&
				(CardClass == CardClass.INVALID || p.Class == CardClass) &&
				(CardSet == CardSet.INVALID || p.Set == CardSet) &&
				(GameTagFilter == null || GameTagFilter.TrueForAll(gameTag => p.Tags.ContainsKey(gameTag))));

			IPlayable randomCard = Entity.FromCard(Opposite ? Controller.Opponent : Controller, Util.Choose<Card>(cardsList.ToList()));
			Playables.Add(randomCard);

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomCardTask(Type, CardType, CardClass, CardSet, GameTagFilter, Opposite);
			clone.Copy(this);
			return clone;
		}
	}
}
