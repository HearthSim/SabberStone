using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawStackTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Playables.Count == 0)
			{
				return TaskState.STOP;
			}

			var list = new List<IPlayable>();
			Playables.ForEach(p =>
			{
				list.Add(Generic.DrawBlock(Controller, p));
			});
			Playables = list;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DrawStackTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}