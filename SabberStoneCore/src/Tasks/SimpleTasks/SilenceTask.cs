﻿#region copyright
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
	[Serializable]
	public class SilenceTask : SimpleTask
	{
		public SilenceTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			//if (entities.Count > 0)
			//{
			//	entities.ForEach(p =>
			//	{
			//		var minion = p as Minion;
			//		minion.Silence();
			//	});
			//}
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.Silence();
			}

			return TaskState.COMPLETE;
		}
	}
}
