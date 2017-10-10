using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// Removing the Weapon from the hero. Without triggering deathrattle event.
	/// </summary>
	public class MoveWeaponToSetaside : SimpleTask
	{
		public override TaskState Process()
		{
			if (Controller.Hero.Weapon == null)
				return TaskState.STOP;

			Weapon weapon = Controller.Hero.Weapon;

			// clear weapon from hero, with out triggering deathrattle.
			Controller.Hero.ClearWeapon();

			Game.Log(LogLevel.INFO, BlockType.PLAY, "MoveWeaponToSetaside", !Game.Logging? "":$"{Controller.Name}'s {weapon} is moved to the setaside zone.");
			Controller.SetasideZone.Add(weapon);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new MoveWeaponToSetaside();
			clone.Copy(this);
			return clone;
		}
	}
}
