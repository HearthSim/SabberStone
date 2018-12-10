using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
	{
		public FuncPlayablesTask(Func<IList<IPlayable>, IList<IPlayable>> function)
		{
			Function = function;
		}

		public Func<IList<IPlayable>, IList<IPlayable>> Function { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			IList<IPlayable> results = Function(stack?.Playables);

			if (stack != null)
				stack.Playables = results;

			return TaskState.COMPLETE;
		}
	}
}
