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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CountTask : SimpleTask
	{
		private readonly int _numberIndex;

		public CountTask(EntityType type, int numberIndex = 0)
		{
			Type = type;
			_numberIndex = numberIndex;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack == null)
				throw new ArgumentException();

			switch (_numberIndex)
			{
				case 0:
					stack.Number = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables).Count;
					break;
				case 1:
					stack.Number1 = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables)
						.Count;
					break;
				case 2:
					stack.Number2 = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables)
						.Count;
					break;
				case 3:
					stack.Number3 = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables)
						.Count;
					break;
				case 4:
					stack.Number4 = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables)
						.Count;
					break;
				default:
					throw new ArgumentOutOfRangeException("Number Index must be in range [0, 4]");
			}

			return TaskState.COMPLETE;
		}
	}
}
