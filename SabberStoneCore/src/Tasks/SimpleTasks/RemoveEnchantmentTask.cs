using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveEnchantmentTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			// Remove applied effects of this enchantment
			//  if (_enchantmentCard != null &&
			//      _enchantmentCard[Enums.GameTag.TAG_ONE_TURN_EFFECT] != 1 &&
			//      _enchantmentCard.Power.Enchant?.Effects != null)
			//foreach (Effect effect in _enchantmentCard.Power.Enchant.Effects)
			//	effect.Remove(source is Enchantment ec ? ec.Target : source);

			if (!(source is Enchantment e)) throw new NotImplementedException();

			if (e.Power.Enchant?.Effects != null)
				if (!e.IsOneTurnActive || game.Step != Step.MAIN_CLEANUP)
					foreach (IEffect effect in e.Power.Enchant.Effects)
						effect.RemoveFrom(target);

			e.Remove();

			// Remove the enchantment entity
			//if (source is Enchantment e)
			// e.Remove();

			return TaskState.COMPLETE;
		}
	}
}
