using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetControllerManaTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number = Controller.RemainingMana;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new GetControllerManaTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}