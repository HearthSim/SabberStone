using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetControllerManaTask : SimpleTask
	{
		public override TaskState Process()
		{
			Number = Controller.RemainingMana;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetControllerManaTask();
			clone.Copy(this);
			return clone;
		}
	}
}