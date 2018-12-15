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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncNumberTask : SimpleTask
	{
		private readonly Func<IPlayable, int> _function;
		private readonly Action<IPlayable, int> _action;

		/// <summary>
		/// Process a custom delegate which takes <see cref="ISimpleTask.Source"/> entity as a parameter and save the returning <see cref="Int32"/> to <see cref="ISimpleTask.Number"/>.
		/// </summary>
		public FuncNumberTask(Func<IPlayable, int> function)
		{
			_function = function;
		}
		/// <summary>
		/// Process a custom delegate which takes <see cref="ISimpleTask.Number"/> as the first parameter and <see cref="ISimpleTask.Number"/> as the second parameter.
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

		public override TaskState Process()
		{
			if (!(Source is IPlayable source))
			{
				return TaskState.STOP;
			}

			if (_action != null)
			{
				_action(source, Number);
				return TaskState.COMPLETE;
			}

			Number = _function(source);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new FuncNumberTask(_function, _action);
			clone.Copy(this);
			return clone;
		}
	}
}
