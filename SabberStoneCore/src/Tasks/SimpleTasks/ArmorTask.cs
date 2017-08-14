using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ArmorTask : SimpleTask
	{
		public bool UseNumber { get; set; }
		public int Amount { get; set; }

		private ArmorTask(bool useNumber, int amount)
		{
			UseNumber = useNumber;
			Amount = amount;
		}

		/// <summary>
		/// Adding the amount as Armor.
		/// </summary>
		public ArmorTask(int amount)
		{
			UseNumber = false;
			Amount = amount;
		}

		/// <summary>
		/// Adding the value contained in Number as Armor.
		/// </summary>
		public ArmorTask()
		{
			UseNumber = true;
			Amount = 0;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}
			Controller.Hero.GainArmor(source, UseNumber ? Number : Amount);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ArmorTask(UseNumber, Amount);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}