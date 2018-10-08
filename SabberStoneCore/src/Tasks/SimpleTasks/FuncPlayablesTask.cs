using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
	{
		public FuncPlayablesTask(Func<List<IPlayable>, List<IPlayable>> function)
		{
			Function = function;
		}

		public Func<List<IPlayable>, List<IPlayable>> Function { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			List<IPlayable> results = Function(stack?.Playables);

			if (stack != null)
				stack.Playables = results;

			return TaskState.COMPLETE;
		}
	}
}
