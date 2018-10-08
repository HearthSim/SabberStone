using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawStackTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack?.Playables.Count == 0) return TaskState.STOP;

			var list = new List<IPlayable>();
			foreach (IPlayable p in stack?.Playables) list.Add(Generic.DrawBlock(controller, p));

			stack.Playables = list;
			return TaskState.COMPLETE;
		}
	}
}
