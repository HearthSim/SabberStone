using System;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
	{
		public Func<List<IPlayable>, List<IPlayable>> Function { get; set; }

		public FuncPlayablesTask(Func<List<IPlayable>, List<IPlayable>> function)
		{
			Function = function;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Playables = Function(Playables);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new FuncPlayablesTask(Function);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}