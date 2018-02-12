using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
    public static class Triggers
    {
	    public static Trigger OneTurnEffectRemovalTrigger(string enchantmentCardId)
	    {
		    return new Trigger(TriggerType.TURN_END)
		    {
			    TriggerActivation = TriggerActivation.PLAY,
				EitherTurn = true,
			    SingleTask = new RemoveEnchantmentTask(enchantmentCardId),
			    RemoveAfterTriggered = true
		    };
	    }

	    public static Trigger EnrageTrigger(string enchantmentId)
	    {
		    return new Trigger(TriggerType.PREDAMAGE)
		    {
			    TriggerSource = TriggerSource.SELF,
			    Condition = SelfCondition.IsUndamaged,
			    SingleTask = new AddEnchantmentTask(enchantmentId, EntityType.SOURCE)
		    };
	    }

	    public static Trigger ShadowReflectionTrigger	//	should make this as inherited class ?...
		    => new Trigger(TriggerType.CUSTOMTRIGGER_SHADOW_REFLECTION)
		    {
			    SingleTask = ComplexTask.Create(
				    new ConditionTask(EntityType.SOURCE, new SelfCondition(p => p.Game.Step == Step.MAIN_END)),
				    new FlagTask(true, ComplexTask.Create(
						    new RemoveEnchantmentTask("ICC_827e"),
							new MoveToSetaside(EntityType.TARGET))),
				    new FlagTask(false, new ChangeEntityTask()))
		    };
    }

	internal delegate bool Condition(IEntity e);

	internal static class Conditions
	{
		internal static Condition IsRace(Race race)
		{
			return e => e is Minion m && m.Race == race;
		}

		internal static Condition IsMyTurn => e => e.Game.CurrentPlayer == e.Controller;
	}
}
