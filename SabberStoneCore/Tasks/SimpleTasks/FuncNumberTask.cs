using System;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		public FuncNumberTask(Func<IPlayable, int> function)
		{
			Function = function;
		}

		public Func<IPlayable, int> Function { get; set; }

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

		public override ISimpleTask Clone()
		{
			var clone = new FuncNumberTask(Function);
			clone.Copy(this);
			return clone;
		}
	}
}