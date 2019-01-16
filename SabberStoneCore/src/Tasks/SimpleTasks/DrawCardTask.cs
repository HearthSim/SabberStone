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

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawCardTask : SimpleTask
	{
		public override TaskState Process()
		{
			if (Playables.Count != 1)
			{
				return TaskState.STOP;
			}

			Model.Entities.IPlayable drawedCard = Generic.Draw(Controller, Playables[0]);

			if (drawedCard == null)
			{
				return TaskState.STOP;
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DrawCardTask();
			clone.Copy(this);
			return clone;
		}
	}
}