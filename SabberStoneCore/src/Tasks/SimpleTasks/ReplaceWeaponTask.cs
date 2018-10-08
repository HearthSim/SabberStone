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
			if (!(source is IPlayable playable))
				return TaskState.STOP;

			controller.Hero.AddWeapon(Entity.FromCard(in controller, in _weaponCard) as Weapon);
			return TaskState.COMPLETE;
		}
	}
}
