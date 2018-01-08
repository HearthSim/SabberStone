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
	    public event TriggerHandler DeathTrigger;
	    public event TriggerHandler PlayCardTrigger;
		public event TriggerHandler PlayMinionTrigger;
	    public event TriggerHandler CastSpellTrigger;
	    public event TriggerHandler SecretRevealedTrigger;


	    internal void OnDamageTrigger(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }

	    internal void OnHealTrigger(IEntity sender)
	    {
		    HealTrigger?.Invoke(sender);
	    }

	    internal void OnEndTurnTrigger(IEntity sender)
	    {
		    EndTurnTrigger?.Invoke(sender);
	    }

	    internal void OnTurnStartTrigger(IEntity sender)
	    {
		    TurnStartTrigger?.Invoke(sender);
	    }

	    internal void OnSummonTrigger(IEntity sender)
	    {
		    SummonTrigger?.Invoke(sender);
	    }

	    internal void OnAttackTrigger(IEntity sender)
	    {
		    AttackTrigger?.Invoke(sender);
	    }

	    internal void OnDeathTrigger(IEntity sender)
	    {
		    DeathTrigger?.Invoke(sender);
	    }

	    internal void OnPlayCardTrigger(IEntity sender)
	    {
		    PlayCardTrigger?.Invoke(sender);
	    }

	    internal void OnPlayMinionTrigger(IEntity sender)
	    {
		    PlayMinionTrigger?.Invoke(sender);
	    }

	    internal void OnCastSpellTrigger(IEntity sender)
	    {
		    CastSpellTrigger?.Invoke(sender);
	    }

	    internal void OnSecretRevealedTrigger(IEntity sender)
	    {
		    SecretRevealedTrigger?.Invoke(sender);
	    }
    }
}
