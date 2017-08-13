using System;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		public Func<IPlayable, int> Function { get; set; }

		public FuncNumberTask(Func<IPlayable, int> function)
		{
			Function = function;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}

			Number = Function(source);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new FuncNumberTask(Function);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}