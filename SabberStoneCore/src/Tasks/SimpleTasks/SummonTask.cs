﻿using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonTask : SimpleTask
	{
		public Card Card { get; set; }

		public bool RemoveFromStack { get; set; }

		public SummonTask(Card card = null, bool removeFromStack = false)
		{
			Card = card;
			RemoveFromStack = removeFromStack;
		}

		public SummonTask(string cardId)
		{
			Card = Cards.FromId(cardId);
			RemoveFromStack = false;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

			Minion summonEntity = null;
			if (Card != null)
			{
				summonEntity = Entity.FromCard(Controller, Card) as Minion;
			}
			else if (Playables.Count > 0)
			{
				summonEntity = Playables[0] as Minion;
				if (RemoveFromStack)
				{
					Playables.Remove(summonEntity);
				}
			}

			if (summonEntity == null)
				return TaskState.STOP;

			bool success = Generic.SummonBlock.Invoke(Controller, summonEntity, -1);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SummonTask(Card, RemoveFromStack);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}