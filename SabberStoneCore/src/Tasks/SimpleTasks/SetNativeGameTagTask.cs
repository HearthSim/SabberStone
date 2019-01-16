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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetNativeGameTagTask : SimpleTask
	{
		public SetNativeGameTagTask(GameTag tag, int value, EntityType entityType)
		{
			Tag = tag;
			Value = value;
			Type = entityType;
		}

		public GameTag Tag { get; set; }
		public int Value { get; set; }
		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			//if (entities.Count != 1)
			//{
			//	return TaskState.STOP;
			//}

			//((Entity)entities[0]).SetNativeGameTag(Tag, Value);

			using (IEnumerator<IPlayable> e = IncludeTask
				.GetEntities(Type, in controller, source, target, stack?.Playables).GetEnumerator())
			{
				if (e.Current != null)
					e.Current[Tag] = Value;
			}

			return TaskState.COMPLETE;
		}
	}
}
