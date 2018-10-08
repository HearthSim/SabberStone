using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueNumberTask : SimpleTask
	{
		private readonly bool _spellDmg;
		private readonly ISimpleTask _task;

		public EnqueueNumberTask(ISimpleTask task, bool spellDmg = false)
		{
			_task = task;
			_spellDmg = spellDmg;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack.Number < 1) return TaskState.STOP;

			int times = _spellDmg ? stack.Number + controller.CurrentSpellPower : stack.Number;

			for (int i = 0; i < times; i++)
				game.TaskQueue.Enqueue(in _task, in controller, in source, in target);
			//Controller.game.TaskQueue.EnqueueBase(
			//	new ClearStackTask
			//	{
			//		Game = controller.Game,
			//		Controller = in controller,
			//		source = source as IPlayable,
			//		target = target as IPlayable
			//	});

			return TaskState.COMPLETE;
		}
	}
}
