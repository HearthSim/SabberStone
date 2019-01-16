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
using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		private readonly Action<IPlayable, int> _action;
		private readonly Func<IPlayable, int> _function;
		private readonly Func<IList<IPlayable>, int> _stackFunction;

		/// <summary>
		///     Process a custom delegate which takes <see cref="ISimpleTask.source" /> entity as a parameter and save the
		///     returning <see cref="Int32" /> to <see cref="TaskStack.Number" />.
		/// </summary>
		public FuncNumberTask(Func<IPlayable, int> function)
		{
			_function = function;
		}

		/// <summary>
		///     Process a custom delegate which takes <see cref="TaskStack.Number" /> as the first parameter and
		///     <see cref="TaskStack.Number" /> as the second parameter.
		/// </summary>
		public FuncNumberTask(Action<IPlayable, int> function)
		{
			_action = function;
		}

		/// <summary>
		/// Process a custom delegate which takes the current stack of entities as a parameter and
		/// save the returning <see cref="Int32"/> to <see cref="TaskStack.Number"/>.
		/// </summary>
		/// <param name="function"></param>
		public FuncNumberTask(Func<IList<IPlayable>, int> stackFunction)
		{
			_stackFunction = stackFunction;
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

			if (_stackFunction != null)
			{
				stack.Number = _stackFunction(stack.Playables);
				return TaskState.COMPLETE;
			}

			if (stack != null)
				stack.Number = _function(playable);
			else
				_function(playable);

			return TaskState.COMPLETE;
		}
	}
}
