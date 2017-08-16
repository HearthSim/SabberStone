using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TempManaTask : SimpleTask
	{
		public int Amount { get; set; }

		public TempManaTask(int amount)
		{
			Amount = amount;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Generic.AddTempMana.Invoke(Controller, Amount);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new TempManaTask(Amount);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}