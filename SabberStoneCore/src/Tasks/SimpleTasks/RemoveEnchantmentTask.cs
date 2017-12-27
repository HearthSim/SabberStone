using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RemoveEnchantmentTask : SimpleTask
    {
	    public override TaskState Process()
	    {
		    if (Source is Enchantment enchantment)
			    foreach (Effect effect in enchantment.EffectsToBeRemoved)
			    {
				    effect.Remove(enchantment.Target);
			    }
		    else
			    throw new NotImplementedException();

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
			return this;
	    }
    }
}
