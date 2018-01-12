using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Enchants
{
	public enum TriggerType
	{
		NONE, TURN_END, TURN_START, DEATH, INSPIRE, DAMAGE, HEAL, ATTACK, AFTER_ATTACK, SUMMON, PLAY_CARD, PLAY_MINION, CAST_SPELL, SECRET_REVEALED, ICEBLOCK, PREDAMAGE
	}

	public enum TriggerSource
	{
		NONE, FRIENDLY, ENEMY, SELF, MINIONS, MINIONS_EXCEPT_SELF, OP_MINIONS, ALL_MINIONS, HERO, OP_HERO, ALL_CHARACTERS, SPELLS, ENCHANTMENT_TARGET
	}

	public enum TriggerActivation
	{
		PLAY, HAND, DECK
	}

    public class Trigger
    {
		public readonly Game Game;
	    private int _sourceId;
	    private int _controllerId;
	    public TriggerActivation TriggerActivation;
	    public TriggerType TriggerType;
		public TriggerSource TriggerSource;
		public ISimpleTask SingleTask;
	    public SelfCondition Condition;
	    public bool EitherTurn;
	    public bool FastExecution;
	    public bool RemoveAfterTriggered;

	    private bool IsSecret => Owner[GameTag.SECRET] == 1;
		private IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_sourceId]);
	    private IPlayable _owner;

		public Trigger() { }
	    private Trigger(Trigger prototype, IEntity owner)
	    {
			Game = owner.Game;
			_sourceId = owner.Id;
		    _controllerId = owner.Controller?.Id ?? prototype._controllerId;
		    TriggerType = prototype.TriggerType;
		    TriggerSource = prototype.TriggerSource;
			Condition = prototype.Condition;
		    SingleTask = prototype.SingleTask;
		    FastExecution = prototype.FastExecution;
			RemoveAfterTriggered = prototype.RemoveAfterTriggered;
	    }

	    protected virtual void Process(IEntity source)
	    {
			if (IsSecret && Owner.IsExhausted)
				return;

		    switch (TriggerSource)
		    {
				case TriggerSource.FRIENDLY:
					if (source.Controller.Id != _controllerId) return;
					break;
				case TriggerSource.ENEMY when source.Controller.Id == _controllerId: return;
				case TriggerSource.SELF:
					if (source.Id != _sourceId) return;
					break;
				case TriggerSource.ALL_MINIONS:
					if (!(source is Minion)) return;
					break;
				case TriggerSource.MINIONS_EXCEPT_SELF:
					if (!(source is Minion) || source.Controller.Id != _controllerId || source.Id == _sourceId || source.Zone.Type != Zone.PLAY) return;
					break;
				case TriggerSource.HERO:
					if (!(source is Hero) || source.Controller.Id != _controllerId) return;
					break;
				case TriggerSource.ENCHANTMENT_TARGET:
					if (!(Owner is Enchantment e) || e.Target.Id != source.Id) return;
					break;
		    }

			switch (TriggerType)
			{
				case TriggerType.TURN_START when !EitherTurn && source.Id != _controllerId:
					return;
				case TriggerType.TURN_END when !EitherTurn && source.Id !=_controllerId:
					return;
				case TriggerType.DEATH when Owner.Zone is GraveyardZone:
					return;
				case TriggerType.ICEBLOCK:
					var h = source as Hero;
					if (h.PreDamage < h.Health) return;
					break;
			}

		    if (Condition != null)
		    {
				if (!Condition.Eval((IPlayable)source))
					return;
		    }

		    if (Owner.Game != source.Game)
			    ;

		    if (FastExecution)
			    Game.TaskQueue.Execute(SingleTask, Owner.Controller, Owner, (IPlayable)source);
		    else
		    {
			    ISimpleTask taskInstance = SingleTask.Clone();
			    taskInstance.Game = Game;
			    taskInstance.Controller = Owner.Controller;
			    taskInstance.Source = Owner is Enchantment ec ? (Game.History ? ec : ec.Target) : Owner;
			    taskInstance.Target = source is IPlayable ? source : Owner is Enchantment ew ? ew.Target : null;
			    taskInstance.IsTrigger = true;

			    if (TriggerType == TriggerType.PREDAMAGE)
				    taskInstance.Number = source[GameTag.PREDAMAGE];

			    Game.TaskQueue.Enqueue(taskInstance);
			}

		    if (RemoveAfterTriggered)
			    Remove();
	    }

	    public void Activate(IPlayable source)
	    {
		    var instance = new Trigger(this, source);

		    source.ActivatedTriggers.Add(instance);
		    
		    switch (TriggerType)
		    {
			    case TriggerType.DAMAGE:
				    source.Game.TriggerManager.DamageTrigger += instance.Process;
				    break;
				case TriggerType.HEAL:
					source.Game.TriggerManager.HealTrigger += instance.Process;
					break;
			    case TriggerType.TURN_END:
				    source.Game.TriggerManager.EndTurnTrigger += instance.Process;
				    break;
			    case TriggerType.TURN_START:
				    source.Game.TriggerManager.TurnStartTrigger += instance.Process;
				    break;
				case TriggerType.SUMMON:
					source.Game.TriggerManager.SummonTrigger += instance.Process;
				    break;
				case TriggerType.ATTACK:
					source.Game.TriggerManager.AttackTrigger += instance.Process;
					break;
				case TriggerType.AFTER_ATTACK:
					switch (TriggerSource)
					{
						case TriggerSource.HERO:
							source.Controller.Hero.AfterAttackTrigger += instance.Process;
							break;
						case TriggerSource.SELF:
							((Minion) source).AfterAttackTrigger += instance.Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion) ((Enchantment) source).Target).AfterAttackTrigger += instance.Process;
							break;
						default:
							throw new NotImplementedException();
					}
					break;
				case TriggerType.DEATH:
					source.Game.TriggerManager.DeathTrigger += instance.Process;
					break;
				case TriggerType.PLAY_CARD:
					source.Game.TriggerManager.PlayCardTrigger += instance.Process;
					break;
				case TriggerType.PLAY_MINION:
					source.Game.TriggerManager.PlayMinionTrigger += instance.Process;
					break;
				case TriggerType.CAST_SPELL:
					source.Game.TriggerManager.CastSpellTrigger += instance.Process;
					break;
				case TriggerType.ICEBLOCK:
					source.Controller.Hero.PreDamageTrigger += instance.Process;
					break;
				case TriggerType.PREDAMAGE:
					if (TriggerSource == TriggerSource.HERO)
						source.Controller.Hero.PreDamageTrigger += instance.Process;
					else if (TriggerSource == TriggerSource.SELF)
						((Minion)source).PreDamageTrigger += instance.Process;
					break;
		    }
	    }

	    public void Remove()
	    {
			switch (TriggerType)
		    {
				case TriggerType.DAMAGE:
					Game.TriggerManager.DamageTrigger -= Process;
					break;
			    case TriggerType.HEAL:
				    Game.TriggerManager.HealTrigger += Process;
				    break;
				case TriggerType.TURN_END:
				    Game.TriggerManager.EndTurnTrigger -= Process;
				    break;
			    case TriggerType.TURN_START:
				    Game.TriggerManager.TurnStartTrigger -= Process;
				    break;
				case TriggerType.SUMMON:
				    Game.TriggerManager.SummonTrigger -= Process;
				    break;
				case TriggerType.ATTACK:
					Game.TriggerManager.AttackTrigger -= Process;
					break;
			    case TriggerType.DEATH:
				    Game.TriggerManager.DeathTrigger -= Process;
				    break;
				case TriggerType.PLAY_CARD:
					Game.TriggerManager.PlayCardTrigger -= Process;
					break;
			    case TriggerType.PLAY_MINION:
				    Game.TriggerManager.PlayMinionTrigger -= Process;
				    break;
			    case TriggerType.CAST_SPELL:
				    Game.TriggerManager.CastSpellTrigger -= Process;
				    break;
			    case TriggerType.ICEBLOCK:
				    Owner.Controller.Hero.PreDamageTrigger -= Process;
				    break;
				case TriggerType.PREDAMAGE:
					((Minion)Owner).PreDamageTrigger -= Process;
					break;
			}

		    Owner.ActivatedTriggers.Remove(this);
	    }
    }
}
