using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TempManaTask : SimpleTask
	{
		public TempManaTask(int amount)
		{
			Amount = amount;
		}

		public int Amount { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			Generic.AddTempMana.Invoke(controller, Amount);

			return TaskState.COMPLETE;
		}
	}
}
