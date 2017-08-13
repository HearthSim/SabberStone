using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ManaCrystalFullTask : SimpleTask
	{
		public int Amount { get; set; }

		public ManaCrystalFullTask(int amount)
		{
			Amount = amount;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = Generic.ChangeManaCrystal.Invoke(Controller, Amount, true);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new ManaCrystalFullTask(Amount);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}