using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
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
