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
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
	public enum TriggerType
	{
		NONE, TURN_END, TURN_START, DEATH, INSPIRE, DAMAGE, PREDAMAGE, HEAL, ATTACK, AFTER_ATTACK, SUMMON, PLAY_CARD, PLAY_MINION, AFTER_PLAY_MINION, CAST_SPELL, AFTER_CAST, SECRET_REVEALED,
	}

	public enum TriggerSource
	{
		ALL, FRIENDLY, ENEMY, SELF, MINIONS, MINIONS_EXCEPT_SELF, OP_MINIONS, ALL_MINIONS, HERO, OP_HERO, ENCHANTMENT_TARGET
	}

	public enum TriggerActivation
	{
		PLAY, HAND, DECK
	}

	public enum SequenceType
	{
		None, PlayCard, PlayMinion, PlaySpell, Summon, DamageDealt, Attack
	}

    public class Trigger
    {
		public readonly Game Game;
	    private int _sourceId;
	    private int _controllerId;
	    public TriggerActivation TriggerActivation;
	    public readonly TriggerType TriggerType;
		public TriggerSource TriggerSource;
		public readonly SequenceType SequenceType;
		public ISimpleTask SingleTask;
	    public SelfCondition Condition;
	    public bool EitherTurn;
	    public bool FastExecution;
	    public bool RemoveAfterTriggered;

	    private bool _isSecret;
		//private IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_sourceId]);
	    private IPlayable Owner;
	    //private IPlayable _owner;

	    public Trigger(TriggerType type)
	    {
			TriggerType = type;

		    switch (type)
		    {
			    case TriggerType.PLAY_MINION:
			    case TriggerType.AFTER_PLAY_MINION:
				    SequenceType = SequenceType.PlayMinion;
					return;
			    case TriggerType.CAST_SPELL:
			    case TriggerType.AFTER_CAST:
				    SequenceType = SequenceType.PlaySpell;
					return;
			    case TriggerType.DAMAGE:
				case TriggerType.PREDAMAGE:
				    SequenceType = SequenceType.DamageDealt;
					return;
			    case TriggerType.ATTACK:
			    case TriggerType.AFTER_ATTACK:
				    SequenceType = SequenceType.Attack;
					Validated = true;
					return;
				case TriggerType.NONE:
			    case TriggerType.TURN_END:
			    case TriggerType.TURN_START:
			    case TriggerType.DEATH:
			    case TriggerType.INSPIRE:
			    case TriggerType.HEAL:
			    case TriggerType.SUMMON:
			    case TriggerType.PLAY_CARD:
			    case TriggerType.SECRET_REVEALED:
					return;
			    default:
				    throw new ArgumentOutOfRangeException(nameof(type), type, null);
		    }
	    }
	    private Trigger(Trigger prototype, IEntity owner)
	    {
			Game = owner.Game;
			_sourceId = owner.Id;
		    Owner = (IPlayable)owner;
		    _controllerId = owner.Controller?.Id ?? prototype._controllerId;
		    TriggerType = prototype.TriggerType;
		    SequenceType = prototype.SequenceType;
		    TriggerSource = prototype.TriggerSource;
			Condition = prototype.Condition;
		    SingleTask = prototype.SingleTask;
		    FastExecution = prototype.FastExecution;
			RemoveAfterTriggered = prototype.RemoveAfterTriggered;
		    _isSecret = prototype.Game == null ? owner.Card[GameTag.SECRET] == 1 : prototype._isSecret;
	    }

		public bool Validated { get; set; }

		public void Activate(IPlayable source)
		{
			var instance = new Trigger(this, source);

			source.ActivatedTriggers.Add(instance);
			source.Game.Triggers.Add(instance);

			switch (TriggerType)
			{
				case TriggerType.DAMAGE:
					if (TriggerSource == TriggerSource.SELF)
					{
						if (source is Minion m)
							m.PreDamageTrigger += instance.Process;
						else if (source is Weapon w)
							
						break;
					}
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
							((Minion)source).AfterAttackTrigger += instance.Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion)((Enchantment)source).Target).AfterAttackTrigger += instance.Process;
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
				case TriggerType.AFTER_PLAY_MINION:
					source.Game.TriggerManager.AfterPlayMinionTrigger += instance.Process;
					break;
				case TriggerType.CAST_SPELL:
					source.Game.TriggerManager.CastSpellTrigger += instance.Process;
					break;
				case TriggerType.AFTER_CAST:
					source.Game.TriggerManager.AfterCastTrigger += instance.Process;
					break;
				case TriggerType.PREDAMAGE:
					switch (TriggerSource)
					{
						case TriggerSource.HERO:
							source.Controller.Hero.PreDamageTrigger += instance.Process;
							break;
						case TriggerSource.SELF:
							((Minion)source).PreDamageTrigger += instance.Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion) ((Enchantment) source).Target).PreDamageTrigger += instance.Process;
							break;
					}
					break;
				case TriggerType.SECRET_REVEALED:
					source.Game.TriggerManager.SecretRevealedTrigger += instance.Process;
					break;
			}
		}

		private void Process(IEntity source)
	    {
		    if (TriggerType == TriggerType.AFTER_ATTACK)
			    Validate(source);

			if (!Validated)
				return;

		    if (FastExecution)
			    Game.TaskQueue.Execute(SingleTask, Owner.Controller, Owner, (IPlayable)source);
		    else
		    {
			    ISimpleTask taskInstance = SingleTask.Clone();
			    taskInstance.Game = Game;
			    taskInstance.Controller = Owner.Controller;
			    taskInstance.Source = Owner is Enchantment ec ? ec : Owner;
			    taskInstance.Target = source is IPlayable ? source : Owner is Enchantment ew && ew.Target is IPlayable p ? p : null;
			    taskInstance.IsTrigger = true;

			    if (TriggerType == TriggerType.PREDAMAGE)
				    taskInstance.Number = source[GameTag.PREDAMAGE];

			    Game.TaskQueue.Enqueue(taskInstance);
			}

		 //   if (extra)
		 //   {
			//    if (FastExecution)
			//	    Game.TaskQueue.Execute(SingleTask, Owner.Controller, Owner, (IPlayable)source);
			//    else
			//    {
			//	    ISimpleTask taskInstance = SingleTask.Clone();
			//	    taskInstance.Game = Game;
			//	    taskInstance.Controller = Owner.Controller;
			//	    taskInstance.Source = Owner is Enchantment ec ? (Game.History ? ec : ec.Target) : Owner;
			//	    taskInstance.Target = source is IPlayable ? source : Owner is Enchantment ew ? ew.Target : null;
			//	    taskInstance.IsTrigger = true;

			//	    if (TriggerType == TriggerType.PREDAMAGE)
			//		    taskInstance.Number = source[GameTag.PREDAMAGE];

			//	    Game.TaskQueue.Enqueue(taskInstance);
			//    }
			//}

		    if (RemoveAfterTriggered)
			    Remove();

			Validated = false;
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
			    case TriggerType.AFTER_CAST:
				    Game.TriggerManager.AfterCastTrigger -= Process;
				    break;
				case TriggerType.PREDAMAGE:
					if (TriggerSource == TriggerSource.HERO)
						Owner.Controller.Hero.PreDamageTrigger -= Process;
					else if (TriggerSource == TriggerSource.SELF)
						((Minion)Owner).PreDamageTrigger -= Process;
					break;
				case TriggerType.SECRET_REVEALED:
					Game.TriggerManager.SecretRevealedTrigger -= Process;
					break;
			}

		    Owner.ActivatedTriggers.Remove(this);
		    Owner.Game.Triggers.Remove(this);
	    }

	    public static void ValidateTriggers(Game game, IEntity source, SequenceType type)
	    {
			for (int i = 0; i < game.Triggers.Count; i++)
				if (game.Triggers[i].SequenceType == type)
					game.Triggers[i].Validate(source);
	    }

	    public static void ValidateTriggers(Game game, IEntity source, TriggerType type)
	    {
		    for (int i = 0; i < game.Triggers.Count; i++)
			    if (game.Triggers[i].TriggerType == type)
				    game.Triggers[i].Validate(source);
		}

	    private void Validate(IEntity source)
	    {
		    if (_isSecret && Owner.IsExhausted)
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
			    case TriggerSource.MINIONS:
				    if (!(source is Minion) || source.Controller.Id != _controllerId) return;
				    break;
			    case TriggerSource.MINIONS_EXCEPT_SELF:
				    if (!(source is Minion) || source.Controller.Id != _controllerId || source.Id == _sourceId ||
				        source.Zone.Type != Zone.PLAY) return;
				    break;
			    case TriggerSource.HERO:
				    if (!(source is Hero) || source.Controller.Id != _controllerId) return;
				    break;
			    case TriggerSource.ENCHANTMENT_TARGET:
				    if (!(Owner is Enchantment e) || e.Target.Id != source.Id) return;
				    break;
		    }

		    bool extra = false;

		    switch (TriggerType)
		    {
			    case TriggerType.PLAY_CARD when source.Id == Owner.Id:
			    case TriggerType.SUMMON when source.Id == Owner.Id:
			    case TriggerType.TURN_START when !EitherTurn && source.Id != _controllerId:
			    case TriggerType.DEATH when Owner.ToBeDestroyed:
				    return;
			    case TriggerType.TURN_END:
				    if (!EitherTurn && source.Id != _controllerId) return;
				    if (!(SingleTask is RemoveEnchantmentTask) && Owner.Controller.ExtraEndTurnEffect)
					    extra = true;
				    break;
		    }

		    if (Condition != null)
		    {
			    IPlayable s = source as IPlayable ?? Owner;
			    if (!Condition.Eval(s))
				    return;
		    }

		    Validated = true;
	    }
	}
}
