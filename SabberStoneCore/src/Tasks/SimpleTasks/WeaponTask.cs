using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class WeaponTask : SimpleTask
	{
		private readonly Card _card;
		private readonly bool _op;

		public WeaponTask(string cardId = null, bool opponent = false)
		{
			if (cardId != null)
				_card = Cards.FromId(cardId);

			_op = opponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_card == null && stack?.Playables.Count != 1) return TaskState.STOP;

			Controller c = _op ? controller.Opponent : controller;

			if (c.Hero.Weapon != null)
				c.Hero.Weapon.ToBeDestroyed = true;

			Weapon weapon = _card != null
				? Entity.FromCard(c, _card) as Weapon
				: stack?.Playables[0] as Weapon;

			Generic.PlayWeapon.Invoke(c, weapon, null, 0);

			return TaskState.COMPLETE;
		}
	}
}
