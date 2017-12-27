using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
    public static class Triggers
    {
	    public static Trigger OneTurnEffectRemovalTrigger => new Trigger
	    {
		    TriggerActivation = TriggerActivation.PLAY,
		    TriggerType = TriggerType.TURN_END,
		    SingleTask = new RemoveEnchantmentTask(),
			RemoveAfterTriggered = true
	    };

    }
}
