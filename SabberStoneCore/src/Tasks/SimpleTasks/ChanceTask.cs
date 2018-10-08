using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChanceTask : SimpleTask
	{
		public ChanceTask(bool useFlag = false)
		{
			UseFlag = useFlag;
		}

		public bool UseFlag { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			int random = Util.Random.Next(0, 2);

			if (!UseFlag) return random == 0 ? TaskState.COMPLETE : TaskState.STOP;

			stack.Flag = random != 0;
			return TaskState.COMPLETE;
		}
	}
}
