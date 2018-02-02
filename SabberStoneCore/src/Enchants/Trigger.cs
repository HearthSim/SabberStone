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
    public class Trigger
    {
		public readonly Game Game;
	    private readonly int _sourceId;
	    private readonly int _controllerId;
	    private readonly TriggerType _triggerType;
		private readonly SequenceType _sequenceType;
	    /// <summary>
	    /// Indicates the Zone at which the effect is triggered.
	    /// </summary>
		public TriggerActivation TriggerActivation;
	    /// <summary>
	    /// Indicates which entities can trigger the effect.
	    /// </summary>
		public TriggerSource TriggerSource;
		/// <summary>
		/// Task to do when this effect is triggered.
		/// </summary>
		public ISimpleTask SingleTask;

	    /// <summary> Additional condition for trigger sources </summary>
	    public SelfCondition Condition;

		/// <summary> 
		/// This option is only meaningful when this the type of this trigger is <see cref="TriggerType.TURN_END"/> or <see cref="TriggerType.TURN_START"/>.
		/// </summary>
		/// <value>	<see cref="true"/> means the effect can be triggered at both player's turn.</value>
		public bool EitherTurn;
	    public bool FastExecution;
		/// <value> <see cref="true"/> means this trigger will be immediately disposed after triggered.</value>
	    public bool RemoveAfterTriggered;

	    private readonly bool _isSecret;
		//private IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_sourceId]);
	    private IPlayable Owner;
	    //private IPlayable _owner;

	    public Trigger(TriggerType type)
	    {
			_triggerType = type;

		    switch (type)
		    {
			    case TriggerType.PLAY_MINION:
			    case TriggerType.AFTER_PLAY_MINION:
				    _sequenceType = SequenceType.PlayMinion;
					return;
			    case TriggerType.CAST_SPELL:
			    case TriggerType.AFTER_CAST:
				    _sequenceType = SequenceType.PlaySpell;
					return;
			    case TriggerType.DAMAGE:
				case TriggerType.PREDAMAGE:
				    _sequenceType = SequenceType.DamageDealt;
					return;
			    case TriggerType.ATTACK:
			    case TriggerType.AFTER_ATTACK:
				case TriggerType.NONE:
				case TriggerType.DEAL_DAMAGE:
				case TriggerType.TURN_END:
			    case TriggerType.TURN_START:
			    case TriggerType.DEATH:
			    case TriggerType.INSPIRE:
			    case TriggerType.HEAL:
				case TriggerType.PRE_SUMMON:
			    case TriggerType.SUMMON:
			    case TriggerType.PLAY_CARD:
			    case TriggerType.SECRET_REVEALED:
				case TriggerType.ZONE:
				case TriggerType.GAME_START:
				case TriggerType.DISCARD:
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
		    _triggerType = prototype._triggerType;
		    _sequenceType = prototype._sequenceType;
		    TriggerSource = prototype.TriggerSource;
			Condition = prototype.Condition;
		    SingleTask = prototype.SingleTask;
		    EitherTurn = prototype.EitherTurn;
			FastExecution = prototype.FastExecution;
			RemoveAfterTriggered = prototype.RemoveAfterTriggered;
		    _isSecret = prototype.Game == null ? owner.Card[GameTag.SECRET] == 1 : prototype._isSecret;
	    }

		public bool Validated { get; set; }

		/// <summary>
		/// Create a new instance of <see cref="Trigger"/> object in source's Game. During activation, the instance's <see cref="Process(IEntity)"/> subscribes to the events in <see cref="Game.GamesEventManager"/>.
		/// </summary>
		public void Activate(IPlayable source, TriggerActivation activation = TriggerActivation.PLAY)
		{
			if (source.ActivatedTrigger != null)
				return;

			if (activation != TriggerActivation)
			{
				if (TriggerActivation != TriggerActivation.HAND_OR_PLAY)
					return;

				if (activation == TriggerActivation.DECK)
					return;
			}

			var instance = new Trigger(this, source);

			source.ActivatedTrigger = instance;

			if (_sequenceType != SequenceType.None)
				source.Game.Triggers.Add(instance);

			switch (_triggerType)
			{
				case TriggerType.DEAL_DAMAGE:
					source.Game.TriggerManager.DealDamageTrigger += instance.Process;
					break;
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
				case TriggerType.PRE_SUMMON:
					source.Game.TriggerManager.PreSummonTrigger += instance.Process;
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
				case TriggerType.ZONE:
					source.Game.TriggerManager.ZoneTrigger += instance.Process;
					break;
				case TriggerType.DISCARD:
					source.Game.TriggerManager.DiscardTrigger += instance.Process;
					break;
				case TriggerType.GAME_START:
					source.Game.TriggerManager.GameStartTrigger += instance.Process;
					break;
			}
		}

		private void Process(IEntity source, int number = 0)
		{
			if (_sequenceType == SequenceType.None)
				Validate(source);

			if (!Validated)
				return;

		    ProcessInternal(source, number);
	    }

	    private void ProcessInternal(IEntity source, int number)
	    {
		    Game.Log(LogLevel.INFO, BlockType.TRIGGER, "Trigger",
			    !Game.Logging ? "" : $"{Owner}'s {_triggerType} Trigger is triggered by {source}.");

		    if (FastExecution)
			    Game.TaskQueue.Execute(SingleTask, Owner.Controller, Owner, (IPlayable)source, number);
		    else
		    {
			    ISimpleTask taskInstance = SingleTask.Clone();
			    taskInstance.Game = Game;
			    taskInstance.Controller = Owner.Controller;
			    taskInstance.Source = Owner is Enchantment ec ? ec : Owner;
			    taskInstance.Target = source is IPlayable ? source : Owner is Enchantment ew && ew.Target is IPlayable p ? p : null;
			    taskInstance.IsTrigger = true;
				taskInstance.Number = number;

			    Game.TaskQueue.Enqueue(taskInstance);
		    }

		    if (RemoveAfterTriggered)
			    Remove();

		    Validated = false;
		}

		/// <summary>
		/// Remove this object from the Game and unsubscribe from the related event.
		/// </summary>
	    public void Remove()
	    {
			switch (_triggerType)
		    {
				case TriggerType.DEAL_DAMAGE:
					Game.TriggerManager.DealDamageTrigger -= Process;
					break;
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
				case TriggerType.PRE_SUMMON:
					Game.TriggerManager.PreSummonTrigger -= Process;
					break;
				case TriggerType.SUMMON:
				    Game.TriggerManager.SummonTrigger -= Process;
				    break;
				case TriggerType.ATTACK:
					Game.TriggerManager.AttackTrigger -= Process;
					break;
				case TriggerType.AFTER_ATTACK:
					switch (TriggerSource)
					{
						case TriggerSource.HERO:
							Owner.Controller.Hero.AfterAttackTrigger -= Process;
							break;
						case TriggerSource.SELF:
							((Minion)Owner).AfterAttackTrigger -= Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion)((Enchantment)Owner).Target).AfterAttackTrigger -= Process;
							break;
						default:
							throw new NotImplementedException();
					}
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
				case TriggerType.AFTER_PLAY_MINION:
					Game.TriggerManager.AfterPlayMinionTrigger -= Process;
					break;
			    case TriggerType.CAST_SPELL:
				    Game.TriggerManager.CastSpellTrigger -= Process;
				    break;
			    case TriggerType.AFTER_CAST:
				    Game.TriggerManager.AfterCastTrigger -= Process;
				    break;
				case TriggerType.PREDAMAGE:
					switch (TriggerSource)
					{
						case TriggerSource.HERO:
							Owner.Controller.Hero.PreDamageTrigger -= Process;
							break;
						case TriggerSource.SELF:
							((Minion)Owner).PreDamageTrigger -= Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion)((Enchantment)Owner).Target).PreDamageTrigger -= Process;
							break;
						default:
							throw new NotImplementedException();
					}
					break;
				case TriggerType.SECRET_REVEALED:
					Game.TriggerManager.SecretRevealedTrigger -= Process;
					break;
				case TriggerType.ZONE:
					Game.TriggerManager.ZoneTrigger -= Process;
					break;
			    case TriggerType.NONE:
				    break;
			    case TriggerType.INSPIRE:
				    break;
				case TriggerType.DISCARD:
					Game.TriggerManager.DiscardTrigger -= Process;
					break;
				case TriggerType.GAME_START:
					Game.TriggerManager.GameStartTrigger -= Process;
					break;
			    default:
				    throw new ArgumentOutOfRangeException();
		    }

			Owner.ActivatedTrigger = null;
			Game.Triggers.Remove(this);

		    Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger",
			    !Game.Logging ? "" : $"{Owner}'s {_triggerType} Trigger is removed.");
	    }

		/// <summary>
		/// Checks triggers related to the current Sequence at once before the Sequence starts.
		/// </summary>
	    public static void ValidateTriggers(Game game, IEntity source, SequenceType type)
	    {
			for (int i = 0; i < game.Triggers.Count; i++)
				if (game.Triggers[i]._sequenceType == type)
					game.Triggers[i].Validate(source);
	    }

	    public static void ValidateTriggers(Game game, IEntity source, TriggerType type)
	    {
		    for (int i = 0; i < game.Triggers.Count; i++)
			    if (game.Triggers[i]._triggerType == type)
				    game.Triggers[i].Validate(source);
		}

	    public static void Invalidate(Game game, SequenceType type)
	    {
		    game.Triggers.ForEach(p =>
		    {
			    if (p._sequenceType == type)
				    p.Validated = false;
		    });

		    if (game.TaskQueue.Count <= 0) return;
		    if (game.TaskQueue.CurrentEventTasks.Count > 0)
			    game.TaskQueue.CurrentEventTasks.Clear();
		    else if
			   (game.TaskQueue.TaskList.Count > 0)
			    game.TaskQueue.TaskList.Clear();
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

		    //bool extra = false;

		    switch (_triggerType)
		    {
			    case TriggerType.PLAY_CARD when source.Id == Owner.Id:
			    case TriggerType.SUMMON when source.Id == Owner.Id:
			    case TriggerType.TURN_START when !EitherTurn && source.Id != _controllerId:
			    case TriggerType.DEATH when Owner.ToBeDestroyed:
				    return;
			    case TriggerType.TURN_END:
				    if (!EitherTurn && source.Id != _controllerId) return;
				    //if (!(SingleTask is RemoveEnchantmentTask) && Owner.Controller.ExtraEndTurnEffect)
					   // extra = true;
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
