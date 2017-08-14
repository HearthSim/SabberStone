using SabberStoneCore.Model;
using System;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	[Obsolete("Unused and marked for removal!")]
	public class FuncCardIdsTask : SimpleTask
	{
		public Func<List<string>, List<string>> Function { get; }

		public FuncCardIdsTask(Func<List<string>, List<string>> function)
		{
			Function = function;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			CardIds = Function(CardIds);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new FuncCardIdsTask(Function);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}