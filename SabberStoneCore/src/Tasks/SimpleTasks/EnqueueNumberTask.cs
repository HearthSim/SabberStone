using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueNumberTask : SimpleTask
	{
		public int Amount { get; set; }
		public ISimpleTask Task { get; set; }
		public bool SpellDmg { get; set; }

		public EnqueueNumberTask(ISimpleTask task, bool spellDmg = false)
		{
			Task = task;
			SpellDmg = spellDmg;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Number < 1)
			{
				return TaskState.STOP;
			}

			int times = SpellDmg ? Number + Controller.Hero.SpellPowerDamage : Number;

			for (int i = 0; i < times; i++)
			{
				// clone task here
				ISimpleTask clone = Task.Clone(null);
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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(EnqueueNumberTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new EnqueueNumberTask(Task.Clone(newGame), SpellDmg);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}