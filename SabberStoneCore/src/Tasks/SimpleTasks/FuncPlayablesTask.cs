using System;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
	{
		public Func<List<IPlayable>, List<IPlayable>> Function { get; }

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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(FuncPlayablesTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new FuncPlayablesTask(Function);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}