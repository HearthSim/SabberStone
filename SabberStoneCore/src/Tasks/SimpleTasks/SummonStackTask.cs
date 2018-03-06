using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;


namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// Summon minions included in the stack.
	/// </summary>
	/// <seealso cref="SimpleTask" />
    public class SummonStackTask : SimpleTask
    {
		public SummonStackTask(bool removeFromZone = false, bool removeFromStack = false)
		{
			RemoveFromZone = removeFromZone;
			RemoveFromStack = removeFromStack;
		}

		/// <summary>
		/// True if entity must be removed before it is summoned.
		/// </summary>
		public bool RemoveFromZone { get; set; }

		public bool RemoveFromStack { get; set; }

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull || Playables.Count == 0)
			{
				return TaskState.STOP;
			}

			for (int i = 0; i < Playables.Count && !Controller.BoardZone.IsFull; i++)
			{
				IPlayable p = Playables[i];

				if (RemoveFromZone)
					p.Zone.Remove(p);
				Generic.SummonBlock(p.Controller, (Minion) p, -1);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonStackTask(RemoveFromZone, RemoveFromStack);
			clone.Copy(this);
			return clone;
		}
	}
}
