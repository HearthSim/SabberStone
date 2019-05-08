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
using SabberStoneCore.Kettle;
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


		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (_both)
				Generic.ChangeManaCrystal.Invoke(controller.Opponent, Amount, true);
			bool success = Generic.ChangeManaCrystal.Invoke(controller, Amount, true);
			return TaskState.COMPLETE;
		}
	}

	public class ManaCrystalEmptyTask : SimpleTask
	{
		private readonly int _amount;
		private readonly bool _opponent;
		private readonly bool _useNumber;

		public ManaCrystalEmptyTask(int amount, bool opponent = false, bool useNumber = false)
		{
			_amount = amount;
			_opponent = opponent;
			_useNumber = useNumber;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			int amount = _useNumber ? stack.Number : _amount;

			bool success =
				Generic.ChangeManaCrystal.Invoke(!_opponent ? controller : controller.Opponent, amount, false);
			return TaskState.COMPLETE;
		}
	}

	public class ManaCrystalSetTask : SimpleTask
	{
		private readonly int _amount;
		private readonly bool _both;
		public ManaCrystalSetTask(int amount, bool both = true)
		{
			_amount = amount;
			_both = both;
		}
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IPlayable target,
			in TaskStack stack = null)
		{
			if (game.History)
			{
				game.PowerHistory.Add(new PowerHistoryMetaData
				{
					Type = Enums.MetaDataType.TARGET,
					Info = new System.Collections.Generic.List<int> { controller.Hero.Id }
				});
				if (_both)
					game.PowerHistory.Add(new PowerHistoryMetaData
					{
						Type = Enums.MetaDataType.TARGET,
						Info = new System.Collections.Generic.List<int> { controller.Opponent.Hero.Id }
					});
			}

			int amount = _amount;
			int remaining = controller.RemainingMana;
			controller.UsedMana = amount > remaining ? amount - remaining : 0;
			controller.BaseMana = amount;

			if (_both)
			{
				remaining = controller.Opponent.RemainingMana;
				controller.Opponent.UsedMana = amount > remaining ? amount - remaining : 0;
				controller.Opponent.BaseMana = amount;
			}

			return TaskState.COMPLETE;
		}
	}

}
