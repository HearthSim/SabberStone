using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MemoryTask : SimpleTask
    {
		private readonly EntityType _type;
		private readonly Action<IPlayable, IList<int>> _action;

		/// <summary>
		/// Add the stored Number to the entities' memory
		/// </summary>
	    public MemoryTask(EntityType type)
	    {
			_type = type;
	    }
		/// <summary>
		/// Process the given action with the memory of entities
		/// </summary>
	    public MemoryTask(EntityType type, Action<IPlayable, IList<int>> action)
	    {
			_type = type;
			_action = action;
	    }

	    public override TaskState Process()
	    {
		    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
		    {
			    if (_action != null)
			    {
					if (p.Memory == null)
						break;
				    _action(p, p.Memory);
					continue;
			    }
				
			    if (p.Memory == null)
				    p.Memory = new List<int> {Number};
			    else
				    p.Memory.Add(Number);
		    }

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new MemoryTask(_type, _action);
	    }
    }

	public class MemoryToNumbersTask : SimpleTask
	{
		private readonly EntityType _type;

		/// <summary>
		/// Copies the memory of the given entity to the stack.
		/// </summary>
		/// <param name="type"></param>
		public MemoryToNumbersTask(EntityType type)
		{
			_type = type;
		}

		public override TaskState Process()
		{
			IEnumerable<IPlayable> entityList = IncludeTask.GetEntities(_type, Controller, Source, Target, Playables);
			if (entityList.Count() != 1) throw new NotImplementedException();

			IPlayable entity = entityList.First();

			entity.Memory.CopyTo(Game.TaskStack.Numbers);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return new MemoryToNumbersTask(_type);
		}
	}
}
