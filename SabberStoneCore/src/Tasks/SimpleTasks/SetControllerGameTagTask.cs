using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetControllerGameTagTask : SimpleTask
	{
		public GameTag Tag { get; set; }

		public int Amount { get; set; }

		public bool OpFlag { get; set; }

		public SetControllerGameTagTask(GameTag tag, int amount, bool opFlag = false)
		{
			Tag = tag;
			Amount = amount;
			OpFlag = opFlag;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Controller controller = OpFlag ? Controller.Opponent : Controller;

			controller[Tag] = Amount;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetControllerGameTagTask(Tag, Amount, OpFlag);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}