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

	    public event TriggerHandler HealTrigger;

	    public event TriggerHandler EndTurnTrigger;

	    public event TriggerHandler TurnStartTrigger;

	    public event TriggerHandler SummonTrigger;

	    public event TriggerHandler AttackTrigger;

	    public void OnDamageTrigger(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }

	    public void OnHealTrigger(IEntity sender)
	    {
		    HealTrigger?.Invoke(sender);
	    }

	    public void OnEndTurnTrigger(IEntity sender)
	    {
		    EndTurnTrigger?.Invoke(sender);
	    }

	    public void OnTurnStartTrigger(IEntity sender)
	    {
		    TurnStartTrigger?.Invoke(sender);
	    }

	    public void OnSummonTrigger(IEntity sender)
	    {
		    SummonTrigger?.Invoke(sender);
	    }

	    public void OnAttackTrigger(IEntity sender)
	    {
		    AttackTrigger?.Invoke(sender);
	    }
    }
}
