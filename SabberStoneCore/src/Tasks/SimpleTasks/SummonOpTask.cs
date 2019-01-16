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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (controller.Opponent.BoardZone.IsFull)
				return TaskState.STOP;

			if (Card == null && stack?.Playables.Count < 1)
				return TaskState.STOP;

			Minion summonEntity = Card != null
				? Entity.FromCard(controller.Opponent, Card) as Minion
				: stack?.Playables[0] as Minion;

			if (summonEntity == null)
				return TaskState.STOP;

			Generic.SummonBlock.Invoke(game, summonEntity, -1);

			return TaskState.COMPLETE;
		}
	}
}
