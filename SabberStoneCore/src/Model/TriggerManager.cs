using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class TriggerManager
    {
	    public delegate void TriggerHandler(IEntity sender, int number = 0);

	    public event TriggerHandler DealDamageTrigger;
	    public event TriggerHandler DamageTrigger;
	    public event TriggerHandler HealTrigger;
	    public event TriggerHandler LoseDivineShield;

	    public event TriggerHandler EndTurnTrigger;
	    public event TriggerHandler TurnStartTrigger;

	    public event TriggerHandler SummonTrigger;
	    public event TriggerHandler AfterSummonTrigger;

	    public event TriggerHandler AttackTrigger;

	    public event TriggerHandler DeathTrigger;

	    public event TriggerHandler PlayCardTrigger;
	    public event TriggerHandler AfterPlayCardTrigger;

		public event TriggerHandler PlayMinionTrigger;
	    public event TriggerHandler AfterPlayMinionTrigger;

	    public event TriggerHandler CastSpellTrigger;
	    public event TriggerHandler AfterCastTrigger;

	    public event TriggerHandler SecretRevealedTrigger;

	    public event TriggerHandler ZoneTrigger;

	    public event TriggerHandler DiscardTrigger;

	    public event TriggerHandler GameStartTrigger;

	    public event TriggerHandler DrawTrigger;

	    public event TriggerHandler TargetTrigger;

	    public event TriggerHandler InspireTrigger;

	    public event TriggerHandler FreezeTrigger;


	    internal void OnDealDamageTrigger(IEntity sender, int number)
	    {
		    DealDamageTrigger?.Invoke(sender, number);
	    }

		internal void OnDamageTrigger(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }

	    internal void OnHealTrigger(IEntity sender, int number)
	    {
			HealTrigger?.Invoke(sender, number);
	    }

	    internal void OnLoseDivineShield(IEntity sender)
	    {
		    LoseDivineShield?.Invoke(sender);
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

	    internal void OnAfterSummonTrigger(IEntity sender)
	    {
			AfterSummonTrigger?.Invoke(sender);
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

	    internal void OnAfterPlayCardTrigger(IEntity sender)
	    {
		    AfterPlayCardTrigger?.Invoke(sender);
	    }

	    internal void OnPlayMinionTrigger(IEntity sender)
	    {
		    PlayMinionTrigger?.Invoke(sender);
	    }

	    internal void OnAfterPlayMinionTrigger(IEntity sender)
	    {
		    AfterPlayMinionTrigger?.Invoke(sender);
	    }

	    internal void OnCastSpellTrigger(IEntity sender)
	    {
		    CastSpellTrigger?.Invoke(sender);
	    }

	    internal void OnAfterCastTrigger(IEntity sender)
	    {
		    AfterCastTrigger?.Invoke(sender);
	    }

	    internal void OnSecretRevealedTrigger(IEntity sender)
	    {
			SecretRevealedTrigger?.Invoke(sender);
	    }

	    internal void OnZoneTrigger(IEntity sender)
	    {
		    ZoneTrigger?.Invoke(sender);
	    }

	    internal void OnDiscardTrigger(IEntity sender)
	    {
		    DiscardTrigger?.Invoke(sender);
	    }

	    internal void OnGameStartTrigger()
	    {
		    GameStartTrigger?.Invoke(null);
	    }

	    internal void OnDrawTrigger(IEntity sender)
	    {
		    DrawTrigger?.Invoke(sender);
	    }

	    internal void OnTargetTrigger(IEntity sender)
	    {
		    TargetTrigger?.Invoke(sender);
	    }

	    internal void OnInspireTrigger(IEntity sender)
	    {
		    InspireTrigger?.Invoke(sender);
	    }

	    internal void OnFreezeTrigger(IEntity sender)
	    {
		    FreezeTrigger?.Invoke(sender);
	    }
    }
}
