using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
    public static class Triggers
    {
		public static Trigger EnrageTrigger(string enchantmentId)
	    {
		    return new Trigger(TriggerType.PREDAMAGE)
		    {
			    TriggerSource = TriggerSource.SELF,
			    Condition = SelfCondition.IsUndamaged,
			    SingleTask = new AddEnchantmentTask(enchantmentId, EntityType.SOURCE)
		    };
	    }

	    public static readonly Trigger RevealUnidentifiedItem
		    = new Trigger(TriggerType.ZONE)
		    {
			    TriggerActivation = TriggerActivation.HAND,
			    TriggerSource = TriggerSource.SELF,
			    RemoveAfterTriggered = true,
			    SingleTask = new ChangeUnidentifiedTask()
		    };
    }
}
