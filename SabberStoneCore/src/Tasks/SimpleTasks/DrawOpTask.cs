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
	public class DrawOpTask : SimpleTask
	{
		public DrawOpTask(Card card = null, bool toStack = false)
		{
			Card = card;
			ToStack = toStack;
		}

		public Card Card { get; set; }

		public bool ToStack { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			IPlayable drawedCard = Card != null
				? Generic.DrawCardBlock.Invoke(controller.Opponent, Card)
				: Generic.Draw(controller.Opponent);
			if (ToStack && drawedCard != null) stack?.Playables.Add(drawedCard);

			return TaskState.COMPLETE;
		}
	}
}
