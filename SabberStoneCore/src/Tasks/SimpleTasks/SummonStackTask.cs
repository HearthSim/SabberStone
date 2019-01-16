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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	///     Summon minions included in the stack.
	/// </summary>
	/// <seealso cref="SimpleTask" />
	public class SummonStackTask : SimpleTask
	{
		public SummonStackTask(bool removeFromZone = false, bool removeFromStack = false)
		{
			RemoveFromZone = removeFromZone;
			RemoveFromStack = removeFromStack;
		}

		/// <summary>
		///     True if entity must be removed before it is summoned.
		/// </summary>
		public bool RemoveFromZone { get; set; }

		public bool RemoveFromStack { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (controller.BoardZone.IsFull || stack?.Playables.Count == 0) return TaskState.STOP;

			for (int i = 0; i < stack?.Playables.Count && !controller.BoardZone.IsFull; i++)
			{
				IPlayable p = stack.Playables[i];

				if (RemoveFromZone)
					p.Zone.Remove(p);
				Generic.SummonBlock(game, (Minion) p, -1);
			}

			return TaskState.COMPLETE;
		}
	}
}
