#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
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
