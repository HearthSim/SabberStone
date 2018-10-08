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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_card == null && stack?.Playables.Count != 1) return TaskState.STOP;

			if (controller.Hero.Weapon != null) controller.Hero.Weapon.ToBeDestroyed = true;


			Weapon weapon = _card != null
				? Entity.FromCard(controller, _card) as Weapon
				: stack?.Playables[0] as Weapon;

			Generic.PlayWeapon.Invoke(controller, weapon, null, 0);

			return TaskState.COMPLETE;
		}
	}
}
