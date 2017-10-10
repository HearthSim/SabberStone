using System;
using System.Collections.Concurrent;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomCardTask : SimpleTask
	{
		private RandomCardTask(EntityType type, CardType cardType, CardClass cardClass, CardSet cardSet, Race race, List<GameTag> gameTagFilter, bool opposite)
		{
			Type = type;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = cardSet;
			Race = race;
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
			CardClass = CardClass.INVALID;
			Race = Race.INVALID;
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
		public RandomCardTask(CardType cardType, CardClass cardClass, Race race = Race.INVALID, List<GameTag> gameTagFilter = null, bool opposite = false)
		{
			Type = EntityType.INVALID;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = CardSet.INVALID;
			Race = race;
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
		public Race Race { get; set; }
		public List<GameTag> GameTagFilter { get; set; }
		public bool Opposite { get; set; }

		private static ConcurrentDictionary<int, List<Card>> MemorisedCards = new ConcurrentDictionary<int, List<Card>>();

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

			MemorisedCards.TryGetValue(Source.Card.AssetId, out List<Card> cardsList);
			if (cardsList == null)
			{
				cardsList = cards.Where(p =>
				(CardType == CardType.INVALID || p.Type == CardType) &&
				(CardClass == CardClass.INVALID || p.Class == CardClass) &&
				(CardSet == CardSet.INVALID || p.Set == CardSet) &&
				(Race == Race.INVALID || p.Race == Race) &&
				(GameTagFilter == null || GameTagFilter.TrueForAll(gameTag => p.Tags.ContainsKey(gameTag))) &&
				(p[GameTag.QUEST] == 0)).ToList();

				MemorisedCards.TryAdd(Source.Card.AssetId, cardsList);
			}


			IPlayable randomCard = Entity.FromCard(Opposite ? Controller.Opponent : Controller, Util.Choose(cardsList));
			Playables = new List<IPlayable> { randomCard };

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomCardTask(Type, CardType, CardClass, CardSet, Race, GameTagFilter, Opposite);
			clone.Copy(this);
			return clone;
		}
	}
}
