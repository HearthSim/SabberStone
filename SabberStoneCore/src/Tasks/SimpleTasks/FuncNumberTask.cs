using System;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		private readonly Action<IPlayable, int> _action;
		private readonly Func<IPlayable, int> _function;

		/// <summary>
		///     Process a custom delegate which takes <see cref="ISimpleTask.source" /> entity as a parameter and save the
		///     returning <see cref="Int32" /> to <see cref="ISimpleTask.stack.Number" />.
		/// </summary>
		public FuncNumberTask(Func<IPlayable, int> function)
		{
			_function = function;
		}

		/// <summary>
		///     Process a custom delegate which takes <see cref="ISimpleTask.stack.Number" /> as the first parameter and
		///     <see cref="ISimpleTask.stack.Number" /> as the second parameter.
		/// </summary>
		public FuncNumberTask(Action<IPlayable, int> function)
		{
			_action = function;
		}

		private FuncNumberTask(Func<IPlayable, int> function, Action<IPlayable, int> action)
		{
			_function = function;
			_action = action;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (!(source is IPlayable playable)) return TaskState.STOP;

			if (_action != null)
			{
				_action(playable, stack.Number);
				return TaskState.COMPLETE;
			}

			stack.Number = _function(playable);
			return TaskState.COMPLETE;
		}
	}
}
