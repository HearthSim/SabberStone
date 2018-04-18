using System;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Enchants
{
    public class Trigger
    {
		public readonly Game Game;
	    private readonly int _sourceId;
	    protected readonly IPlayable _owner;
		private readonly TriggerType _triggerType;
		private readonly SequenceType _sequenceType;
	    private readonly bool _isSecret;
	    private bool _removed;
	    internal bool IsAncillaryTrigger;
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

	    public Trigger(TriggerType type)
	    {
			_triggerType = type;

		    switch (type)
		    {
				case TriggerType.PLAY_CARD:
				case TriggerType.AFTER_PLAY_CARD:
					_sequenceType = SequenceType.PlayCard;
					return;
			    case TriggerType.PLAY_MINION:
			    case TriggerType.AFTER_PLAY_MINION:
				    _sequenceType = SequenceType.PlayMinion;
					return;
			    case TriggerType.CAST_SPELL:
			    case TriggerType.AFTER_CAST:
				    _sequenceType = SequenceType.PlaySpell;
					return;
				case TriggerType.TARGET:
					_sequenceType = SequenceType.Target;
					return;
				case TriggerType.TURN_END:
				case TriggerType.WORGEN_TRANSFORM:
					FastExecution = true;
					return;
		    }
	    }

	    protected Trigger(Trigger prototype, IEntity owner)
	    {
			Game = owner.Game;
			_sourceId = owner.Id;
		    _owner = (IPlayable)owner;
		    _triggerType = prototype._triggerType;
		    _sequenceType = prototype._sequenceType;
		    TriggerSource = prototype.TriggerSource;
			Condition = prototype.Condition;
		    SingleTask = prototype.SingleTask;
		    EitherTurn = prototype.EitherTurn;
			FastExecution = prototype.FastExecution;
			RemoveAfterTriggered = prototype.RemoveAfterTriggered;
		    _isSecret = prototype.Game == null ? owner.Card.IsSecret : prototype._isSecret;
		    IsAncillaryTrigger = prototype.IsAncillaryTrigger;
	    }

		public bool Validated { get; set; }

		/// <summary>
		/// Create a new instance of <see cref="Trigger"/> object in source's Game. During activation, the instance's <see cref="Process(IEntity)"/> subscribes to the events in <see cref="Game.GamesEventManager"/>.
		/// </summary>
		public virtual Trigger Activate(IPlayable source, TriggerActivation activation = TriggerActivation.PLAY, bool cloning = false)
		{
			if (source.ActivatedTrigger != null && !IsAncillaryTrigger)
				throw new Exceptions.EntityException($"{source} already has an activated trigger.");

			if (!cloning && activation != TriggerActivation)
			{
				if (TriggerActivation != TriggerActivation.HAND_OR_PLAY)
					return null;

				if (activation == TriggerActivation.DECK)
					return null;
			}

			var instance = new Trigger(this, source);

			if (!IsAncillaryTrigger)
				source.ActivatedTrigger = instance;

			if (_sequenceType != SequenceType.None)
				source.Game.Triggers.Add(instance);

			switch (_triggerType)
			{
				case TriggerType.DEAL_DAMAGE:
					source.Game.TriggerManager.DealDamageTrigger += instance.Process;
					break;
				case TriggerType.TAKE_DAMAGE:
					if (TriggerSource == TriggerSource.SELF)
					{
						if (source is Minion m)
							m.TakeDamageTrigger += instance.Process;
						else
							throw new NotImplementedException();
						break;
					}
					if (TriggerSource == TriggerSource.HERO)
					{
						source.Controller.Hero.TakeDamageTrigger += instance.Process;
						break;
					}
					source.Game.TriggerManager.DamageTrigger += instance.Process;
					break;
				case TriggerType.HEAL:
					source.Game.TriggerManager.HealTrigger += instance.Process;
					break;
				case TriggerType.TURN_END:
				case TriggerType.WORGEN_TRANSFORM:
					source.Game.TriggerManager.EndTurnTrigger += instance.Process;
					break;
				case TriggerType.TURN_START:
					source.Game.TriggerManager.TurnStartTrigger += instance.Process;
					break;
				case TriggerType.SUMMON:
					source.Game.TriggerManager.SummonTrigger += instance.Process;
					break;
				case TriggerType.AFTER_SUMMON:
					source.Game.TriggerManager.AfterSummonTrigger += instance.Process;
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
				case TriggerType.AFTER_PLAY_CARD:
					source.Game.TriggerManager.AfterPlayCardTrigger += instance.Process;
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
				case TriggerType.DRAW:
					source.Game.TriggerManager.DrawTrigger += instance.Process;
					break;
				case TriggerType.TARGET:
					source.Game.TriggerManager.TargetTrigger += instance.Process;
					break;
				case TriggerType.LOSE_DIVINE_SHIELD:
					source.Game.TriggerManager.LoseDivineShield += instance.Process;
					break;
				case TriggerType.INSPIRE:
					source.Game.TriggerManager.InspireTrigger += instance.Process;
					break;
				case TriggerType.FROZEN:
					source.Game.TriggerManager.FreezeTrigger += instance.Process;
					break;
				case TriggerType.ARMOR:
					source.Game.TriggerManager.ArmorTrigger += instance.Process;
					break;
				case TriggerType.EQUIP_WEAPON:
					source.Game.TriggerManager.EquipWeaponTrigger += instance.Process;
					break;
			}

			return instance;
		}

		private void Process(IEntity source)
		{
			if (_sequenceType == SequenceType.None)
				Validate(source);

			if (!Validated)
				return;

		    ProcessInternal(source);

			if (_triggerType == TriggerType.TURN_END && _owner.Controller.ExtraEndTurnEffect)
				ProcessInternal(source);
		}

	    private void ProcessInternal(IEntity source)
	    {
		    Validated = false;

			Game.Log(LogLevel.INFO, BlockType.TRIGGER, "Trigger",
			    !Game.Logging ? "" : $"{_owner}'s {_triggerType} Trigger is triggered by {source}.");

		    if (RemoveAfterTriggered)
			    Remove();

			if (FastExecution)
			    Game.TaskQueue.Execute(SingleTask, _owner.Controller, _owner,
				    source is IPlayable ? (IPlayable)source
										: _owner is Enchantment ew && ew.Target is IPlayable p ? p
										: null);
		    else
		    {
			    ISimpleTask taskInstance = SingleTask.Clone();
			    taskInstance.Game = Game;
			    taskInstance.Controller = _owner.Controller;
			    taskInstance.Source = _owner is Enchantment ec ? ec : _owner;
				taskInstance.Target = source is IPlayable ? source : _owner is Enchantment ew && ew.Target is IPlayable p ? p : null;
			    taskInstance.IsTrigger = true;

			    Game.TaskQueue.Enqueue(taskInstance);
		    }

		    Validated = false;
		}

		/// <summary>
		/// Remove this object from the Game and unsubscribe from the related event.
		/// </summary>
	    public virtual void Remove()
		{
			if (_removed) return;

			switch (_triggerType)
		    {
				case TriggerType.DEAL_DAMAGE:
					Game.TriggerManager.DealDamageTrigger -= Process;
					break;
				case TriggerType.TAKE_DAMAGE:
					if (TriggerSource == TriggerSource.SELF)
					{
						if (_owner is Minion m)
							m.TakeDamageTrigger -= Process;
						else
							throw new NotImplementedException();
						break;
					}
					if (TriggerSource == TriggerSource.HERO)
					{
						_owner.Controller.Hero.TakeDamageTrigger -= Process;
						break;
					}
					Game.TriggerManager.DamageTrigger -= Process;
					break;
			    case TriggerType.HEAL:
				    Game.TriggerManager.HealTrigger -= Process;
				    break;
				case TriggerType.TURN_END:
				case TriggerType.WORGEN_TRANSFORM:
					Game.TriggerManager.EndTurnTrigger -= Process;
				    break;
			    case TriggerType.TURN_START:
				    Game.TriggerManager.TurnStartTrigger -= Process;
				    break;
				case TriggerType.SUMMON:
					Game.TriggerManager.SummonTrigger -= Process;
					break;
				case TriggerType.AFTER_SUMMON:
				    Game.TriggerManager.AfterSummonTrigger -= Process;
				    break;
				case TriggerType.ATTACK:
					Game.TriggerManager.AttackTrigger -= Process;
					break;
				case TriggerType.AFTER_ATTACK:
					switch (TriggerSource)
					{
						case TriggerSource.HERO:
							_owner.Controller.Hero.AfterAttackTrigger -= Process;
							break;
						case TriggerSource.SELF:
							((Minion)_owner).AfterAttackTrigger -= Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion)((Enchantment)_owner).Target).AfterAttackTrigger -= Process;
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
			    case TriggerType.AFTER_PLAY_CARD:
					Game.TriggerManager.AfterPlayCardTrigger -= Process;
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
							_owner.Controller.Hero.PreDamageTrigger -= Process;
							break;
						case TriggerSource.SELF:
							((Minion)_owner).PreDamageTrigger -= Process;
							break;
						case TriggerSource.ENCHANTMENT_TARGET:
							((Minion)((Enchantment)_owner).Target).PreDamageTrigger -= Process;
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
				case TriggerType.DISCARD:
					Game.TriggerManager.DiscardTrigger -= Process;
					break;
				case TriggerType.GAME_START:
					Game.TriggerManager.GameStartTrigger -= Process;
					break;
				case TriggerType.DRAW:
					Game.TriggerManager.DrawTrigger -= Process;
					break;
				case TriggerType.TARGET:
					Game.TriggerManager.TargetTrigger -= Process;
					break;
				case TriggerType.LOSE_DIVINE_SHIELD:
					Game.TriggerManager.LoseDivineShield -= Process;
					break;
				case TriggerType.INSPIRE:
					Game.TriggerManager.InspireTrigger -= Process;
					break;
				case TriggerType.FROZEN:
					Game.TriggerManager.FreezeTrigger -= Process;
					break;
			    case TriggerType.ARMOR:
				    Game.TriggerManager.ArmorTrigger -= Process;
				    break;
				case TriggerType.EQUIP_WEAPON:
					Game.TriggerManager.EquipWeaponTrigger -= Process;
					break;
				default:
				    throw new ArgumentOutOfRangeException();
		    }

			if (!IsAncillaryTrigger)
				_owner.ActivatedTrigger = null;

			if (_sequenceType != SequenceType.None)
				Game.Triggers.Remove(this);

			_removed = true;

		    Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger",
			    !Game.Logging ? "" : $"{_owner}'s {_triggerType} Trigger is removed.");
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

			//if (game.TaskQueue.Count <= 0) return;
			//if (game.TaskQueue.CurrentEventTasks.Count > 0)
			// game.TaskQueue.CurrentEventTasks.Clear();
			//else if
			//(game.TaskQueue.TaskList.Count > 0)
			// game.TaskQueue.TaskList.Clear();

			if (game.TaskQueue.IsEmpty) return;
		    game.TaskQueue.ClearCurrentEvent();
	    }

	    private void Validate(IEntity source)
	    {
		    if (_isSecret && _owner.IsExhausted)
			    return;

		    switch (TriggerSource)
		    {
				case TriggerSource.FRIENDLY:
				    if (source.Controller != _owner.Controller) return;
				    break;
			    case TriggerSource.ENEMY when source.Controller == _owner.Controller: return;
			    case TriggerSource.SELF:
				    if (source.Id != _sourceId) return;
				    break;
			    case TriggerSource.ALL_MINIONS:
				    if (!(source is Minion)) return;
				    break;
			    case TriggerSource.MINIONS:
				    if (!(source is Minion) || source.Controller != _owner.Controller) return;
				    break;
			    case TriggerSource.MINIONS_EXCEPT_SELF:
				    if (!(source is Minion) || source.Controller != _owner.Controller || source.Id == _sourceId ||
				        source.Zone.Type != Zone.PLAY) return;
					break;
				case TriggerSource.ALL_MINIONS_EXCEPT_SELF:
					if (!(source is Minion) || source == _owner) return;
				    break;
				case TriggerSource.OP_MINIONS:
					if (!(source is Minion) || source.Controller == _owner.Controller) return;
					break;
			    case TriggerSource.HERO:
				    if (!(source is Hero) || source.Controller != _owner.Controller) return;
				    break;
			    case TriggerSource.ENCHANTMENT_TARGET:
				    if (!(_owner is Enchantment e) || e.Target.Id != source.Id) return;
				    break;
				case TriggerSource.WEAPON:
					if (!(source is Weapon w) || w.Controller != source.Controller) return;
					break;
				case TriggerSource.HERO_POWER:
					if (!(source is HeroPower hp) || hp.Controller != source.Controller) return;
					break;
				case TriggerSource.FRIENDLY_SPELL_CASTED_ON_THE_OWNER:
					if (!(source is Spell) || source.Controller != _owner.Controller || Game.CurrentEventData?.EventTarget != _owner) return;
					break;
				case TriggerSource.FRIENDLY_SPELL_CASTED_ON_OWN_MINIONS:
					if (!(source is Spell) || source.Controller != _owner.Controller || Game.CurrentEventData?.EventTarget?.Controller != _owner.Controller) return;
					break;
			}

		    //bool extra = false;

		    switch (_triggerType)
		    {
			    case TriggerType.PLAY_CARD when source.Id == _owner.Id:
				case TriggerType.SUMMON when source == _owner:
			    case TriggerType.AFTER_SUMMON when source.Id == _owner.Id:
			    case TriggerType.TURN_START when !EitherTurn && source != _owner.Controller:
			    case TriggerType.DEATH when _owner.ToBeDestroyed:
			    case TriggerType.INSPIRE when !EitherTurn && Game.CurrentPlayer != _owner.Controller:
					return;
			    case TriggerType.TURN_END:
			    case TriggerType.WORGEN_TRANSFORM:
					if (!EitherTurn && source != _owner.Controller) return;
				    //if (!(SingleTask is RemoveEnchantmentTask) && Owner.Controller.ExtraEndTurnEffect)
					   // extra = true;
				    break;
		    }

		    if (Condition != null)
		    {
			    IPlayable s = source as IPlayable ?? _owner;
			    if (!Condition.Eval(s))
				    return;
		    }

		    Validated = true;
	    }

		public override string ToString()
		{
			return $"{{Owner:{_owner}}}[Type:{_triggerType}]";
		}
	}
}
