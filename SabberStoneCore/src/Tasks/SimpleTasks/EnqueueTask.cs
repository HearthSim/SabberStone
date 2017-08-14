using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueTask : SimpleTask
	{
		public int Amount { get; set; }
		public ISimpleTask Task { get; set; }
		public bool SpellDmg { get; set; }

		public EnqueueTask(int amount, ISimpleTask task, bool spellDmg = false)
		{
			Amount = amount;
			Task = task;
			SpellDmg = spellDmg;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			int times = SpellDmg ? Amount + Controller.Hero.SpellPowerDamage : Amount;

			for (int i = 0; i < times; i++)
			{
				// clone task here
				ISimpleTask clone = Task.Clone(null);
				clone.ResetState();
				clone.Game = Controller.Game;
				clone.Controller = Controller;
				clone.Source = Source as IPlayable;
				clone.Target = Target as IPlayable;

				Controller.Game.TaskQueue.Enqueue(clone);
				Controller.Game.TaskQueue.Enqueue(
					new ClearStackTask
					{
						Game = Controller.Game,
						Controller = Controller,
						Source = Source as IPlayable,
						Target = Target as IPlayable
					});
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new EnqueueTask(Amount, Task.Clone(newGame), SpellDmg);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}