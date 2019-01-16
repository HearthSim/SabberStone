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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ArmorTask : SimpleTask
	{
		private readonly bool _useNumber;
		private readonly int _amount;
		private readonly bool _op;

		/// <summary>
		///     Adding the amount as Armor.
		/// </summary>
		/// <param name="opponent">True if should add armour to the opponent of the source.</param>
		public ArmorTask(int amount, bool opponent = false)
		{
			_amount = amount;
			_op = opponent;
		}

		/// <summary>
		///     Adding the value contained in stack.Number as Armor.
		/// </summary>
		public ArmorTask(bool opponent = false)
		{
			_useNumber = true;
			_amount = 0;
			_op = opponent;
		}



		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (source == null) return TaskState.STOP;

			if (_op)
				controller.Opponent.Hero.GainArmor((IPlayable)source, _useNumber ? stack.Number : _amount);
			else
				controller.Hero.GainArmor((IPlayable)source, _useNumber ? stack.Number : _amount);

			return TaskState.COMPLETE;
		}
	}
}
