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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public interface ISimpleTask
	{
		TaskState State { get; set; }

		TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target, in TaskStack stack = null);

		bool IsTrigger { get; set; }
	}

	public abstract class SimpleTask : ISimpleTask
	{
		internal static Random Random => Util.Random;

		public TaskState State { get; set; } = TaskState.READY;

		public abstract TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target, in TaskStack stack = null);

		public void ResetState()
		{
			State = TaskState.READY;
		}

		public bool IsTrigger { get; set; }

		public override string ToString()
		{
			return GetType().Name;
		}
	}
}
