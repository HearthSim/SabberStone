using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagGameTask : SimpleTask
	{
		public GetGameTagGameTask(GameTag tag)
		{
			Tag = tag;
		}

		public GameTag Tag { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			stack.Number = game[Tag];
			return TaskState.COMPLETE;
		}
	}
}
