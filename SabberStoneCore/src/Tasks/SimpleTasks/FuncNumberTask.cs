using System;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		public Func<IPlayable, int> Function { get; }

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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(FuncNumberTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new FuncNumberTask(Function);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}