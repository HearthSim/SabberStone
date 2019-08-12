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

using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddLackeyTask : SimpleTask
	{
		public static readonly Card[]
			Lackeys = Cards.All.Where(card => card[GameTag.MARK_OF_EVIL] == 1).ToArray();

		private readonly int _amount;
		public AddLackeyTask(int amount)
		{
			_amount = amount;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IPlayable target,
			in TaskStack stack = null)
		{
			game.OnRandomHappened(true);

			for (int i = 0; i < _amount && !controller.HandZone.IsFull; i++)
				Entity.FromCard(in controller, Lackeys.Choose(game.Random), zone: controller.HandZone);

			return TaskState.COMPLETE;
		}
	}
}
