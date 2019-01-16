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
using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomEntourageTask : SimpleTask
	{
		private readonly int _count;
		private readonly bool _opponent;

		public RandomEntourageTask(int count = 1, bool opponent = false)
		{
			_count = count;
			_opponent = opponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var playable = source as IPlayable;
			if (playable == null || playable.Card.Entourage.Length < 1) return TaskState.STOP;

			if (_count > 1)
			{
				if (_count > playable.Card.Entourage.Length)
					throw new ArgumentOutOfRangeException();

				var ids = new string[_count];
				int i = 0;
				do
				{
					string pick = Util.Choose(playable.Card.Entourage);
					if (Array.IndexOf(ids, pick) > -1)
						continue;
					ids[i] = pick;
					i++;
				} while (i != _count);

				var list = new List<IPlayable>(_count);
				for (int j = 0; j < _count; j++)
					list.Add(Entity.FromCard(_opponent ? controller.Opponent : controller, Cards.FromId(ids[j])));

				stack.Playables = list;
			}
			else
			{
				IPlayable randomCard = Entity.FromCard(_opponent ? controller.Opponent : controller,
					Cards.FromId(Util.Choose(playable.Card.Entourage)));
				stack.Playables = new List<IPlayable> {randomCard};
			}

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
