using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomCardTask : SimpleTask
	{
		private RandomCardTask(EntityType type, CardType cardType, CardClass cardClass, CardSet cardSet, bool opposite)
		{
			Type = type;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = cardSet;
			Opposite = opposite;
		}

		public RandomCardTask(EntityType type, bool opposite = false)
		{
			Type = type;
			CardType = CardType.INVALID;
			CardSet = CardSet.INVALID;
			Opposite = opposite;
		}

		public RandomCardTask(CardType cardType, CardClass cardClass, bool opposite = false)
		{
			Type = EntityType.INVALID;
			CardType = cardType;
			CardClass = cardClass;
			CardSet = CardSet.INVALID;
			Opposite = opposite;
		}

		public RandomCardTask(CardSet cardSet)
		{
			Type = EntityType.INVALID;
			CardType = CardType.INVALID;
			CardClass = CardClass.INVALID;
			CardSet = cardSet;
			Opposite = false;
		}

		public EntityType Type { get; set; }
		public CardType CardType { get; set; }
		public CardClass CardClass { get; set; }
		public CardSet CardSet { get; set; }
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

			System.Collections.Generic.IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			System.Collections.Generic.IEnumerable<Card> cardsList = cards.Where(p =>
				(CardType == CardType.INVALID || p.Type == CardType) &&
				(CardClass == CardClass.INVALID || p.Class == CardClass) &&
				(CardSet == CardSet.INVALID || p.Set == CardSet));

			IPlayable randomCard = Entity.FromCard(Opposite ? Controller.Opponent : Controller, Util.Choose<Card>(cardsList.ToList()));
			Playables.Add(randomCard);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomCardTask(Type, CardType, CardClass, CardSet, Opposite);
			clone.Copy(this);
			return clone;
		}
	}
}