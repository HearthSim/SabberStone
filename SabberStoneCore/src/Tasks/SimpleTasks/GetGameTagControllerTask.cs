using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagControllerTask : SimpleTask
	{
		public GetGameTagControllerTask(GameTag tag)
		{
			Tag = tag;
		}

		public GameTag Tag { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			stack.Number = Tag == GameTag.CURRENT_SPELLPOWER ? controller.CurrentSpellPower : controller[Tag];
			return TaskState.COMPLETE;
		}
	}
}
