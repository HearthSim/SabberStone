using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// Creates new entity instance from the captured Card of an Enchantment.
	/// </summary>
	public class GetCapturedCardTask : SimpleTask
	{
		private static readonly GetCapturedCardTask _singleton = new GetCapturedCardTask();

		/// <summary>
		/// Gets a singleton of this task.
		/// </summary>
		public static GetCapturedCardTask Task = _singleton;

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack == null)
				throw new Exception($"{this} should contained in StateTaskList");

			if (!(target is Enchantment e))
				throw new Exception($"Target of {this} is not Enchantment.");

			Card c = e.CapturedCard;

			if (c == null)
				throw new Exception($"{e} does not have any captured Card.");

			IPlayable entity = Entity.FromCard(in controller, in c);

			stack.Playables = new[] {entity};

			return TaskState.COMPLETE;
		}
	}

	/// <summary>
	/// Activates the captured card's Deathrattle Task.
	/// </summary>
	public class ActivateCapturedDeathrattleTask : SimpleTask
	{
		private static readonly ActivateCapturedDeathrattleTask _singleton = new ActivateCapturedDeathrattleTask();

		/// <summary>
		/// Gets a singleton of this task.
		/// </summary>
		public static ActivateCapturedDeathrattleTask Task = _singleton;

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack == null)
				throw new Exception($"{this} should contained in StateTaskList");

			if (!(target is Enchantment e))
				throw new Exception($"Target of {this} is not Enchantment.");

			Card c = e.CapturedCard;

			if (c == null)
				throw new Exception($"{e} does not have any captured Card.");

			ISimpleTask task = c.Power.DeathrattleTask;

			if (task == null)
				throw new Exception($"Captured card {c} doesn't have Deathrattle Task.");

			game.TaskQueue.Enqueue(in task, in controller, in source, null);

			return TaskState.COMPLETE;
		}
	}
}
