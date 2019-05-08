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
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model
{
    public class TriggerManager
    {
	    public delegate void TriggerHandler(IEntity sender);

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

	    public event TriggerHandler ArmorTrigger;

	    public event TriggerHandler EquipWeaponTrigger;

	    public event TriggerHandler ShuffleIntoDeckTrigger;

	    public event TriggerHandler OverloadTrigger;

		public bool HasTargetTrigger => TargetTrigger != null;
		public bool HasOnSummonTrigger => SummonTrigger != null;
		public bool HasShuffleIntoDeckTrigger => ShuffleIntoDeckTrigger != null;

	    internal void OnDealDamageTrigger(IEntity sender)
	    {
		    DealDamageTrigger?.Invoke(sender);
	    }

		internal void OnDamageTrigger(IEntity sender)
	    {
		    DamageTrigger?.Invoke(sender);
	    }

	    internal void OnHealTrigger(IEntity sender)
	    {
			HealTrigger?.Invoke(sender);
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
		    if (ZoneTrigger == null) return;
		    sender.Game.TaskQueue.StartEvent();
		    ZoneTrigger.Invoke(sender);
		    sender.Game.ProcessTasks();
		    sender.Game.TaskQueue.EndEvent();
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

	    internal void OnArmorTrigger(IEntity sender)
	    {
		    ArmorTrigger?.Invoke(sender);
	    }

	    internal void OnEquipWeaponTrigger(IEntity sender)
	    {
		    EquipWeaponTrigger?.Invoke(sender);
	    }

	    internal void OnShuffleIntoDeckTrigger(IEntity sender)
	    {
		    ShuffleIntoDeckTrigger?.Invoke(sender);
	    }

	    internal void OnOverloadTrigger(IPlayable sender, int amount)
	    {
			if (OverloadTrigger == null)
				return;

			EventMetaData temp = sender.Game.CurrentEventData;
			sender.Game.CurrentEventData = new EventMetaData(sender, null, amount);
			OverloadTrigger.Invoke(sender);
			sender.Game.CurrentEventData = temp;
	    }

	    public void AddTrigger(TriggerType type, TriggerHandler method)
	    {
			switch (type)
			{
				case TriggerType.TURN_END:
					EndTurnTrigger += method;
					return;
				case TriggerType.TURN_START:
					TurnStartTrigger += method;
					return;
				case TriggerType.DEATH:
					DeathTrigger += method;
					return;
				case TriggerType.INSPIRE:
					InspireTrigger += method;
					return;
				case TriggerType.DEAL_DAMAGE:
					DealDamageTrigger += method;
					return;
				case TriggerType.TAKE_DAMAGE:
					DamageTrigger += method;
					return;
				case TriggerType.HEAL:
					HealTrigger += method;
					return;
				case TriggerType.LOSE_DIVINE_SHIELD:
					LoseDivineShield += method;
					return;
				case TriggerType.ATTACK:
					AttackTrigger += method;
					return;
				case TriggerType.SUMMON:
					SummonTrigger += method;
					return;
				case TriggerType.AFTER_SUMMON:
					AfterSummonTrigger += method;
					return;
				case TriggerType.PLAY_CARD:
					PlayCardTrigger += method;
					return;
				case TriggerType.AFTER_PLAY_CARD:
					AfterPlayMinionTrigger += method;
					return;
				case TriggerType.PLAY_MINION:
					PlayMinionTrigger += method;
					return;
				case TriggerType.AFTER_PLAY_MINION:
					AfterPlayMinionTrigger += method;
					return;
				case TriggerType.CAST_SPELL:
					CastSpellTrigger += method;
					return;
				case TriggerType.AFTER_CAST:
					AfterCastTrigger += method;
					return;
				case TriggerType.SECRET_REVEALED:
					SecretRevealedTrigger += method;
					return;
				case TriggerType.ZONE:
					ZoneTrigger += method;
					return;
				case TriggerType.DISCARD:
					DiscardTrigger += method;
					return;
				case TriggerType.GAME_START:
					GameStartTrigger += method;
					return;
				case TriggerType.DRAW:
					DrawTrigger += method;
					return;
				case TriggerType.TARGET:
					TargetTrigger += method;
					return;
				case TriggerType.FROZEN:
					FreezeTrigger += method;
					return;
				case TriggerType.ARMOR:
					ArmorTrigger += method;
					return;
				case TriggerType.EQUIP_WEAPON:
					EquipWeaponTrigger += method;
					return;
				default:
					throw new System.NotImplementedException();
			}
		}

	    public void RemoveTrigger(TriggerType type, TriggerHandler method)
	    {
		    switch (type)
		    {
			    case TriggerType.TURN_END:
				    EndTurnTrigger -= method;
				    return;
			    case TriggerType.TURN_START:
				    TurnStartTrigger -= method;
				    return;
			    case TriggerType.DEATH:
				    DeathTrigger -= method;
				    return;
			    case TriggerType.INSPIRE:
				    InspireTrigger -= method;
				    return;
			    case TriggerType.DEAL_DAMAGE:
				    DealDamageTrigger -= method;
				    return;
			    case TriggerType.TAKE_DAMAGE:
				    DamageTrigger -= method;
				    return;
			    case TriggerType.HEAL:
				    HealTrigger -= method;
				    return;
				case TriggerType.LOSE_DIVINE_SHIELD:
				    LoseDivineShield -= method;
				    return;
			    case TriggerType.ATTACK:
				    AttackTrigger -= method;
				    return;
			    case TriggerType.SUMMON:
				    SummonTrigger -= method;
				    return;
			    case TriggerType.AFTER_SUMMON:
				    AfterSummonTrigger -= method;
				    return;
			    case TriggerType.PLAY_CARD:
				    PlayCardTrigger -= method;
				    return;
			    case TriggerType.AFTER_PLAY_CARD:
				    AfterPlayMinionTrigger -= method;
				    return;
			    case TriggerType.PLAY_MINION:
				    PlayMinionTrigger -= method;
				    return;
			    case TriggerType.AFTER_PLAY_MINION:
				    AfterPlayMinionTrigger -= method;
				    return;
			    case TriggerType.CAST_SPELL:
				    CastSpellTrigger -= method;
				    return;
			    case TriggerType.AFTER_CAST:
				    AfterCastTrigger -= method;
				    return;
			    case TriggerType.SECRET_REVEALED:
				    SecretRevealedTrigger -= method;
				    return;
			    case TriggerType.ZONE:
				    ZoneTrigger -= method;
				    return;
			    case TriggerType.DISCARD:
				    DiscardTrigger -= method;
				    return;
			    case TriggerType.GAME_START:
				    GameStartTrigger -= method;
				    return;
			    case TriggerType.DRAW:
				    DrawTrigger -= method;
				    return;
			    case TriggerType.TARGET:
				    TargetTrigger -= method;
				    return;
			    case TriggerType.FROZEN:
				    FreezeTrigger -= method;
				    return;
			    case TriggerType.ARMOR:
				    ArmorTrigger -= method;
				    return;
			    case TriggerType.EQUIP_WEAPON:
				    EquipWeaponTrigger -= method;
				    return;
			    default:
				    throw new System.NotImplementedException();
		    }
	    }
    }
}
