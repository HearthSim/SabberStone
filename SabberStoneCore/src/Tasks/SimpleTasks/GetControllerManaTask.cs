using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetControllerManaTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			stack.Number = controller.RemainingMana;
			return TaskState.COMPLETE;
		}
	}
}
