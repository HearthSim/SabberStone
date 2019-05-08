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
	/// <summary>
	///     A task that deals specific amount of damage to one of the equipped weapons.
	/// </summary>
	public class DamageWeaponTask : SimpleTask
	{
		private readonly bool _opponent;
		private int _amount;

		/// <summary>
		///     A task that deals specific amount of damage to one of the equipped weapons.
		/// </summary>
		/// <param name="opponent">True if the target is opponent's equipped weapon.</param>
		/// <param name="amount">The amount.</param>
		public DamageWeaponTask(bool opponent = true, int amount = 1)
		{
			_amount = amount;
			_opponent = opponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			Weapon weapon = _opponent ? source.Controller.Opponent.Hero.Weapon : source.Controller.Hero.Weapon;

			if (weapon == null)
				return TaskState.COMPLETE;

			if (weapon.Durability < _amount)
				_amount = weapon.Durability;

			weapon.Damage += _amount;

			return TaskState.COMPLETE;
		}
	}
}
