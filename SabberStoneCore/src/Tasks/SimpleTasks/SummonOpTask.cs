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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonOpTask : SimpleTask
	{
		public SummonOpTask(Card card = null)
		{
			Card = card;
		}

		public SummonOpTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

		public Card Card { get; set; }

		public override TaskState Process()
		{
			if (Controller.Opponent.BoardZone.IsFull)
				return TaskState.STOP;

			if (Card == null && Playables.Count < 1)
				return TaskState.STOP;

			Minion summonEntity = Card != null ?
				Entity.FromCard(Controller.Opponent, Card) as Minion :
				Playables[0] as Minion;

			if (summonEntity == null)
				return TaskState.STOP;

			bool success = Generic.SummonBlock.Invoke(Controller.Opponent, summonEntity, -1);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonOpTask(Card);
			clone.Copy(this);
			return clone;
		}
	}
}