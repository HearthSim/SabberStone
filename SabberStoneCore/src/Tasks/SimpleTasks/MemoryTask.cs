using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MemoryTask : SimpleTask
	{
		private readonly Action<IPlayable, IList<int>> _action;
		private readonly EntityType _type;

		/// <summary>
		///     Add the stored stack.Number to the entities' memory
		/// </summary>
		public MemoryTask(EntityType type)
		{
			_type = type;
		}

		/// <summary>
		///     Process the given action with the memory of entities
		/// </summary>
		public MemoryTask(EntityType type, Action<IPlayable, IList<int>> action)
		{
			_type = type;
			_action = action;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
			{
				if (_action != null)
				{
					if (p.Memory == null)
						break;
					_action(p, p.Memory);
					continue;
				}

				if (p.Memory == null)
					p.Memory = new List<int> {stack.Number};
				else
					p.Memory.Add(stack.Number);
			}

			return TaskState.COMPLETE;
		}
	}
}
