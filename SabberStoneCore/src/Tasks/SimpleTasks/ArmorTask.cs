using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ArmorTask : SimpleTask
	{
		private ArmorTask(bool useNumber, int amount)
		{
			UseNumber = useNumber;
			Amount = amount;
		}

		/// <summary>
		///     Adding the amount as Armor.
		/// </summary>
		public ArmorTask(int amount)
		{
			UseNumber = false;
			Amount = amount;
		}

		/// <summary>
		///     Adding the value contained in stack.Number as Armor.
		/// </summary>
		public ArmorTask()
		{
			UseNumber = true;
			Amount = 0;
		}

		public bool UseNumber { get; set; }
		public int Amount { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var playableSource = source as IPlayable;
			if (source == null) return TaskState.STOP;

			controller.Hero.GainArmor(playableSource, UseNumber ? stack.Number : Amount);
			return TaskState.COMPLETE;
		}
	}
}
