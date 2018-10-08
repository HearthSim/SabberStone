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
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
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
