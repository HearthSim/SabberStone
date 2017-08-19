using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomMinionTask : SimpleTask
	{
		private RandomMinionTask(GameTag tag, int value, EntityType type, int amount, RelaSign relaSign, bool classAndMultiOnlyFlag, bool maxInDeckFlag)
		{
			Tag = tag;
			Value = value;
			Type = type;
			Amount = amount;
			RelaSign = relaSign;
			ClassAndMultiOnlyFlag = classAndMultiOnlyFlag;
			MaxInDeckFlag = maxInDeckFlag;
		}

		public RandomMinionTask(GameTag tag, EntityType type, int amount = 1)
		{
			Tag = tag;
			Value = -1;
			Type = type;
			Amount = amount;
			ClassAndMultiOnlyFlag = false;
			MaxInDeckFlag = false;
			RelaSign = RelaSign.EQ;
		}

		public RandomMinionTask(GameTag tag, int value, int amount = 1, RelaSign relaSign = RelaSign.EQ, bool classAndMultiOnlyFlag = false, bool maxInDeckFlag = false)
		{
			Tag = tag;
			Value = value;
			Type = EntityType.INVALID;
			Amount = amount;
			ClassAndMultiOnlyFlag = classAndMultiOnlyFlag;
			MaxInDeckFlag = maxInDeckFlag;
			RelaSign = relaSign;
		}

		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }
		public int Amount { get; set; }
		public bool ClassAndMultiOnlyFlag { get; set; }
		public bool MaxInDeckFlag { get; set; }
		public RelaSign RelaSign { get; set; }

		public override TaskState Process()
		{
			if (Type != EntityType.INVALID)
			{
				if (Type == EntityType.TARGET && Tag == GameTag.COST)
				{
					Value = ((IPlayable)Target).Cost;
				}
				else
				{
					throw new NotImplementedException();
				}
			}

			IEnumerable<Card> cards;
			if (Game.FormatType == FormatType.FT_STANDARD)
			{
				cards = ClassAndMultiOnlyFlag ? Controller.Standard : Cards.AllStandard;
			}
			else
			{
				cards = ClassAndMultiOnlyFlag ? Controller.Wild : Cards.AllWild;
			}

			var cardsList = cards.Where(p => p.Type == CardType.MINION
				&& (RelaSign == RelaSign.EQ && p[Tag] == Value
				 || RelaSign == RelaSign.GEQ && p[Tag] >= Value
				 || RelaSign == RelaSign.LEQ && p[Tag] <= Value)).ToList();
			if (!cardsList.Any())
			{
				return TaskState.STOP;
			}

			var randomMinions = new List<IPlayable>();
			while (randomMinions.Count < Amount && cardsList.Count > 0)
			{
				Card card = Util.Choose<Card>(cardsList);
				cardsList.Remove(card);

				// check for deck rules
				if (MaxInDeckFlag && Controller.DeckCards.Where(p => p.Id == card.Id).Count() >= card.MaxAllowedInDeck)
					continue;

				randomMinions.Add(Entity.FromCard(Controller, card));
			}

			Playables = randomMinions;

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomMinionTask(Tag, Value, Type, Amount, RelaSign, ClassAndMultiOnlyFlag, MaxInDeckFlag);
			clone.Copy(this);
			return clone;
		}
	}
}
