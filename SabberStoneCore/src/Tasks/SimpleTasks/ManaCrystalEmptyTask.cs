using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ManaCrystalEmptyTask : SimpleTask
	{
		public ManaCrystalEmptyTask(int amount, bool opponent = false, bool useNumber = false)
		{
			Amount = amount;
			Opponent = opponent;
			UseNumber = useNumber;
		}

		public int Amount { get; set; }
		public bool Opponent { get; set; }
		public bool UseNumber { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (UseNumber) Amount = stack.Number;

			bool success =
				Generic.ChangeManaCrystal.Invoke(!Opponent ? controller : controller.Opponent, Amount, false);
			return TaskState.COMPLETE;
		}
	}
}
