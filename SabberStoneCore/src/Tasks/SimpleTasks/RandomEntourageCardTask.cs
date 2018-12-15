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
		 
		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || source.Card.Entourage.Length < 1)
			{
				return TaskState.STOP;
			}

			if (_count > 1)
			{
				if (_count > source.Card.Entourage.Length)
					throw new System.ArgumentOutOfRangeException();

				var ids = new string[_count];
				int i = 0;
				do
				{
					string pick = Util.Choose(source.Card.Entourage);
					if (Array.IndexOf(ids, pick) > -1)
						continue;
					ids[i] = pick;
					i++;
				} while (i != _count);

				var list = new List<IPlayable>(_count);
				for (int j = 0; j < _count; j++)
					list.Add(Entity.FromCard(_opponent? Controller.Opponent : Controller, Cards.FromId(ids[j])));

				Playables = list;
			}
			else
			{
				IPlayable randomCard = Entity.FromCard(_opponent ? Controller.Opponent : Controller, Cards.FromId(Util.Choose<string>(source.Card.Entourage)));
				Playables = new List<IPlayable> { randomCard };
			}

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomEntourageTask(_count, _opponent);
			clone.Copy(this);
			return clone;
		}
	}
}
