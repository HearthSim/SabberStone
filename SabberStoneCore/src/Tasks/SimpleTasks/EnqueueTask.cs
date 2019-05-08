#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion

using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueTask : SimpleTask
	{
		private readonly int _amount;
		private readonly bool _spellDmg;
		private readonly ISimpleTask _task;

		public EnqueueTask(int amount, ISimpleTask task, bool spellDmg = false)
		{
			_amount = amount;
			_task = task;
			_spellDmg = spellDmg;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			int times = _spellDmg ? _amount + controller.CurrentSpellPower : _amount;

			for (int i = 0; i < times; i++)
				game.TaskQueue.Enqueue(in _task, in controller, source, target);
			//Controller.game.TaskQueue.Enqueue(
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

	public class EnqueuePendingTask : SimpleTask
	{
		private readonly ISimpleTask _task;
		private readonly EntityType _targetType;

		public EnqueuePendingTask(ISimpleTask task, EntityType targetType)
		{
			_task = task;
			_targetType = targetType;
		}

		public EnqueuePendingTask(EntityType targetType)
		{
			_targetType = targetType;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IPlayable target,
			in TaskStack stack = null)
		{
			IList<IPlayable> targets = IncludeTask.GetEntities(in _targetType, in controller, source, target, stack?.Playables);

			if (_task == null)
			{
				ISimpleTask task = source.Card.Power.PowerTask;
				if (source.Card.HasOverload)
					task = ComplexTask.Create(task, OverloadTask.Task);
				foreach (IPlayable p in targets)
					game.TaskQueue.EnqueuePendingTask(in task, in controller, in source, in p);
			}
			else
				foreach (IPlayable p in targets)
					game.TaskQueue.EnqueuePendingTask(in _task, in controller, in source, in p);

			return TaskState.COMPLETE;
		}
	}

	public class OverloadTask : SimpleTask
	{
		private OverloadTask() { }

		public static readonly OverloadTask Task = new OverloadTask();

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			Generic.OverloadBlock(controller, (IPlayable) source, game.History);
			return TaskState.COMPLETE;
		}
	}
}
