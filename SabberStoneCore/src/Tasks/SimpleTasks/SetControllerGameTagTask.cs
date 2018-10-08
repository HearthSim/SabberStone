using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetControllerGameTagTask : SimpleTask
	{
		public SetControllerGameTagTask(GameTag tag, int amount, bool opFlag = false)
		{
			Tag = tag;
			Amount = amount;
			OpFlag = opFlag;
		}

		public GameTag Tag { get; set; }

		public int Amount { get; set; }

		public bool OpFlag { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			Controller c = OpFlag ? controller.Opponent : controller;

			c[Tag] = Amount;

			return TaskState.COMPLETE;
		}
	}
}
