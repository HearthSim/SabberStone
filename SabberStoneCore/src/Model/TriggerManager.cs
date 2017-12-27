using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.Model
{
    public class TriggerManager
    {
	    public delegate void TriggerHandler(IEntity sender);

	    public event TriggerHandler DamageTrigger;

	    public event TriggerHandler EndTurnTrigger;

	    public event TriggerHandler SummonTrigger;

	    public void OnDamageTrigger(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }

	    public void OnEndTurnTrigger(IEntity sender)
	    {
		    EndTurnTrigger?.Invoke(sender);
	    }

	    public void OnSummonTrigger(IEntity sender)
	    {
		    SummonTrigger?.Invoke(sender);
	    }
    }
}
