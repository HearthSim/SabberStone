using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
    public static class Triggers
    {
		//public static Trigger EnrageTrigger(string enchantmentId)
	 //   {
		//    return new Trigger(TriggerType.PREDAMAGE)
		//    {
		//	    TriggerSource = TriggerSource.SELF,
		//	    Condition = SelfCondition.IsUndamaged,
		//	    SingleTask = new AddEnchantmentTask(enchantmentId, EntityType.SOURCE)
		//    };
	 //   }

	    public static readonly Trigger RevealUnidentifiedItem
		    = new Trigger(TriggerType.ZONE)
		    {
			    TriggerActivation = TriggerActivation.HAND,
			    TriggerSource = TriggerSource.SELF,
			    RemoveAfterTriggered = true,
			    SingleTask = new ChangeUnidentifiedTask()
		    };

	    // TODO: maybe need some more work here
		public static Trigger WorgenTransform(string cardId, string enchantmentId)
	    {
		    return new Trigger(TriggerType.WORGEN_TRANSFORM)
		    {
			    TriggerActivation = TriggerActivation.HAND,
			    SingleTask = ComplexTask.Create(
				    new SwapAttackHealthTask(EntityType.SOURCE, enchantmentId),
				    new ChangeEntityTask(cardId)),
			    RemoveAfterTriggered = true
		    };
	    }
    }
}
