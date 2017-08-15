using System.Collections.Generic;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ClearStackTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Playables = new List<IPlayable>();
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(ClearStackTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ClearStackTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}