#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// A task that deals specific amount of damage to one of the equipped weapons.
	/// </summary>
    public class DamageWeaponTask : SimpleTask
    {
	    private int _amount;

	    private readonly bool _opponent;

		/// <summary>
		/// A task that deals specific amount of damage to one of the equipped weapons.
		/// </summary>
		/// <param name="opponent">True if the target is opponent's equipped weapon.</param>
		/// <param name="amount">The amount.</param>
		public DamageWeaponTask(bool opponent = true, int amount = 1)
	    {
			_amount = amount;
			_opponent = opponent;
	    }

		public override TaskState Process()
		{
			Weapon target = _opponent ? Source.Controller.Opponent.Hero.Weapon : Source.Controller.Hero.Weapon;

			if (target == null)
				return TaskState.COMPLETE;

			if (target.Durability < _amount)
				_amount = target.Durability;

			target.Damage += _amount;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DamageWeaponTask(_opponent, _amount);
			clone.Copy(this);
			return clone;
		}
	}
}
