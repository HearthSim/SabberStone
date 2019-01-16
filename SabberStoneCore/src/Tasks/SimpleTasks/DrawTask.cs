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
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		private readonly int _count;
		private readonly bool _toStack;

		public DrawTask(bool toStack = false, int count = 1)
		{
			_toStack = toStack;
			_count = count;
		}

		public DrawTask(int count) : this(false, count)
		{
		}


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//Model.Entities.IPlayable drawedCard = Generic.Draw(controller);
			//bool nullFlag = false;
			List<IPlayable> cards = _toStack ? new List<IPlayable>(_count) : null;
			for (int i = 0; i < _count; i++)
			{
				IPlayable draw = Generic.Draw(controller);
				if (draw == null)
				{
					//nullFlag = true;
					break;
				}

				cards?.Add(draw);
			}

			if (cards != null)
			{ 
				//if (nullFlag)
					//stack?.Playables.AddRange(cards.Where(p => p != null));
				//else
					//stack?.Playables.AddRange(cards);

				if (cards.Count == 0)
					return TaskState.STOP;

				stack.Playables = cards;
			}

			return TaskState.COMPLETE;
		}
	}
}
