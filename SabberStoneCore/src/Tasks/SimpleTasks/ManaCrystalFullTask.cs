﻿#region copyright
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
	public class ManaCrystalFullTask : SimpleTask
	{
		private readonly bool _both;

		public ManaCrystalFullTask(int amount, bool both = false)
		{
			Amount = amount;
			_both = both;
		}

		public int Amount { get; set; }


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_both)
				Generic.ChangeManaCrystal.Invoke(controller.Opponent, Amount, true);
			bool success = Generic.ChangeManaCrystal.Invoke(controller, Amount, true);
			return TaskState.COMPLETE;
		}
	}
}
