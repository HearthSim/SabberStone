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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class WeaponTask : SimpleTask
	{
		private readonly Card _card;

		public WeaponTask(string cardId = null)
		{
			if (cardId != null)
				_card = Cards.FromId(cardId);
		}

		private WeaponTask(Card card)
		{
			_card = card;
		}

		public override TaskState Process()
		{
			if (_card == null && Playables.Count != 1)
			{
				return TaskState.STOP;
			}

			if (Controller.Hero.Weapon != null)
			{
				Controller.Hero.Weapon.ToBeDestroyed = true;
			}

			
			Weapon weapon = _card != null ?
				Entity.FromCard(Controller, _card) as Weapon :
				Playables[0] as Weapon;

			Generic.PlayWeapon.Invoke(Controller, weapon, null, 0);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new WeaponTask(_card);
			clone.Copy(this);
			return clone;
		}
	}
}
