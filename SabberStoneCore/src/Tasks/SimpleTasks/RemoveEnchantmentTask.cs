using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RemoveEnchantmentTask : SimpleTask
    {
		public override TaskState Process()
	    {
			// Remove applied effects of this enchantment
		  //  if (_enchantmentCard != null &&
		  //      _enchantmentCard[Enums.GameTag.TAG_ONE_TURN_EFFECT] != 1 &&
		  //      _enchantmentCard.Power.Enchant?.Effects != null)
				//foreach (Effect effect in _enchantmentCard.Power.Enchant.Effects)
				//	effect.Remove(Source is Enchantment ec ? ec.Target : Source);

		    if (!(Source is Enchantment e)) throw new NotImplementedException();

			if (!e.IsOneTurnActive && e.Power.Enchant?.Effects != null)
				foreach (Effect effect in e.Power.Enchant.Effects)
					effect.RemoveFrom(Target);

		    e.Remove();

			// Remove the enchantment entity
		    //if (Source is Enchantment e)
			   // e.Remove();

			return TaskState.COMPLETE;
	    }
		
	    public override ISimpleTask Clone()
	    {
		    return new RemoveEnchantmentTask();
	    }
    }
}
