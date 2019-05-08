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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	///     Removing the Weapon from the hero. Without triggering deathrattle event.
	/// </summary>
	public class MoveWeaponToSetaside : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (controller.Hero.Weapon == null)
				return TaskState.STOP;

			Weapon weapon = controller.Hero.Weapon;

			// clear weapon from hero, with out triggering deathrattle.
			controller.Hero.ClearWeapon();

			game.Log(LogLevel.INFO, BlockType.PLAY, "MoveWeaponToSetaside",
				!game.Logging ? "" : $"{controller.Name}'s {weapon} is moved to the setaside zone.");
			controller.SetasideZone.Add(weapon);

			return TaskState.COMPLETE;
		}
	}
}
