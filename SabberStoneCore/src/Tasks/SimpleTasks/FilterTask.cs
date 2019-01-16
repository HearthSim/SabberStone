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
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FilterStackTask : SimpleTask
	{
		private readonly RelaCondition[] _relaConditions;
		private readonly SelfCondition[] _selfConditions;

		private readonly EntityType _type;

		private FilterStackTask(EntityType type, SelfCondition[] selfConditions, RelaCondition[] relaConditions)
		{
			_type = type;
			_selfConditions = selfConditions;
			_relaConditions = relaConditions;
		}

		public FilterStackTask(params SelfCondition[] selfConditions)
		{
			_selfConditions = selfConditions;
		}

		public FilterStackTask(EntityType type, params RelaCondition[] relaConditions)
		{
			_type = type;
			_relaConditions = relaConditions;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_relaConditions != null)
			{
				IList<IPlayable> entities =
					IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables);

				if (entities.Count != 1)
					return TaskState.STOP;
				
				var filtered = new List<IPlayable>(stack.Playables.Count);
				foreach (IPlayable p in stack.Playables)
				{
					bool flag = true;
					for (int i = 0; i < _relaConditions.Length; i++)
						flag = flag && _relaConditions[i].Eval(entities[0], p);
					if (flag)
						filtered.Add(p);
				}

				stack.Playables = filtered;
			}

			if (_selfConditions != null)
			{
				var filtered = new List<IPlayable>(stack.Playables.Count);
				foreach (IPlayable p in stack?.Playables)
				{
					bool flag = true;
					for (int i = 0; i < _selfConditions.Length; i++)
						if (_selfConditions[i] != null)
							flag = flag && _selfConditions[i].Eval(p);

					if (flag)
						filtered.Add(p);
				}

				stack.Playables = filtered;
			}

			return TaskState.COMPLETE;
		}
	}
}
