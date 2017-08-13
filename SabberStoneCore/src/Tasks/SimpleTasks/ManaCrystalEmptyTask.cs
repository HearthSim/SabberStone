using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ManaCrystalEmptyTask : SimpleTask
	{
		public int Amount { get; set; }
		public bool Opponent { get; set; }
		public bool UseNumber { get; set; }

		public ManaCrystalEmptyTask(int amount, bool opponent = false, bool useNumber = false)
		{
			Amount = amount;
			Opponent = opponent;
			UseNumber = useNumber;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (UseNumber)
			{
				Amount = Number;
			}

			bool success = Generic.ChangeManaCrystal.Invoke(!Opponent ? Controller : Controller.Opponent, Amount, false);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new ManaCrystalEmptyTask(Amount, Opponent, UseNumber);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}