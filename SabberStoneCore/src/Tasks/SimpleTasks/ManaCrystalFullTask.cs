using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ManaCrystalFullTask : SimpleTask
	{
		private readonly bool _both;

		public ManaCrystalFullTask(int amount, bool both = false)
		{
			Amount = amount;
			_both = both;
		}

		public int Amount { get; set; }


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_both)
				Generic.ChangeManaCrystal.Invoke(controller.Opponent, Amount, true);
			bool success = Generic.ChangeManaCrystal.Invoke(controller, Amount, true);
			return TaskState.COMPLETE;
		}
	}
}
