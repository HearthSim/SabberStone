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
	public class ReplaceWeaponTask : SimpleTask
	{
		private readonly Card _weaponCard;

		public ReplaceWeaponTask(Card cardWeapon)
		{
			_weaponCard = cardWeapon;
		}

		public ReplaceWeaponTask(string cardIdWeapon)
		{
			_weaponCard = Cards.FromId(cardIdWeapon);
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (!(source is IPlayable))
				return TaskState.STOP;

			controller.Hero.AddWeapon(Entity.FromCard(in controller, in _weaponCard) as Weapon);
			return TaskState.COMPLETE;
		}
	}
}
