using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueTask : SimpleTask
	{
		public EnqueueTask(int amount, ISimpleTask task, bool spellDmg = false)
		{
			Amount = amount;
			Task = task;
			SpellDmg = spellDmg;
		}

		public int Amount { get; set; }
		public ISimpleTask Task { get; set; }
		public bool SpellDmg { get; set; }

		public override TaskState Process()
		{
			var times = SpellDmg ? Amount + Controller.Hero.SpellPowerDamage : Amount;

			for (var i = 0; i < times; i++)
			{
				// clone task here
				var clone = Task.Clone();
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

		public override ISimpleTask Clone()
		{
			var clone = new EnqueueTask(Amount, Task.Clone(), SpellDmg);
			clone.Copy(this);
			return clone;
		}
	}
}