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
		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }
		public int Amount { get; set; }
		public RelaSign RelaSign { get; set; }

		private RandomMinionTask(GameTag tag, int value, EntityType type, int amount, RelaSign relaSign)
		{
			Tag = tag;
			Value = value;
			Type = type;
			Amount = amount;
			RelaSign = relaSign;
		}

		public RandomMinionTask(GameTag tag, EntityType type, int amount = 1)
		{
			Tag = tag;
			Value = -1;
			Type = type;
			Amount = amount;
			RelaSign = RelaSign.EQ;
		}

		public RandomMinionTask(GameTag tag, int value, int amount = 1, RelaSign relaSign = RelaSign.EQ)
		{
			Tag = tag;
			Value = value;
			Type = EntityType.INVALID;
			Amount = amount;
			RelaSign = relaSign;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
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
				Card card = Util.Choose(cardsList);
				cardsList.Remove(card);
				randomMinions.Add(Entity.FromCard(Controller, card));
			}

			Playables = randomMinions;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RandomMinionTask(Tag, Value, Type, Amount, RelaSign);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}