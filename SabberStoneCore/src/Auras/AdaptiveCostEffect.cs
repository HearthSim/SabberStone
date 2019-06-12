using System;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Implementation of the specific effects of varying cost. e.g. Giants
	/// </summary>
	public class AdaptiveCostEffect : IAura
	{
		private readonly Playable _owner;
		private readonly int _value;
		private readonly EffectOperator _operator;
		private readonly Func<IPlayable, int> _costFunction;

		private readonly TriggerType _triggerType;
		private readonly TriggerSource _triggerSource;
		private readonly SelfCondition _condition;
		private readonly TriggerManager.TriggerHandler _updateHandler;
		private readonly TriggerManager.TriggerHandler _removedHandler;

		private readonly Func<Playable, int> _initialisationFunction;
		private int _cachedValue = -1;

		private bool _isTriggered;
		private bool _isAppliedThisTurn;

		//public (TriggerType Type, TriggerSource Source, SelfCondition Condition) UpdateTrigger;

		/// <summary>
		/// Creates an Adaptive Cost Effect that varies the owner's cost.
		/// (e.g. Giants needs subtraction. They costs less for the calculated value from the given cost function.)
		/// The argument of the cost function is the owner entity.
		/// </summary>
		/// <param name="costFunc">The cost function to calculate the amount the owner costs varies.</param>
		/// <param name="operator">This determines how cost varies.</param>
		public AdaptiveCostEffect(Func<IPlayable, int> costFunc, EffectOperator @operator = EffectOperator.SUB)
		{
			_costFunction = costFunc;
			_operator = @operator;
		}

		/// <summary>
		/// Creates an Adaptive Cost Effect that sets cost of the owner to a specific value
		/// until the end of the turn when the given criterion is satisfied. (e.g. Happy Ghoul, Arcane Tyrant)
		/// </summary>
		/// <param name="value">The value to set.</param>
		/// <param name="trigger">The type of trigger this effect should check.</param>
		/// <param name="triggerSource">The specific type of source entities that can invoke the trigger.</param>
		/// <param name="triggerCondition">Condition to be applied to the source of the trigger.</param>
		public AdaptiveCostEffect(int value, TriggerType trigger,
			TriggerSource triggerSource = TriggerSource.ALL, SelfCondition triggerCondition = null)
		{
			_value = value;
			_triggerType = trigger;
			_triggerSource = triggerSource;
			_condition = triggerCondition;
		}

		public AdaptiveCostEffect(Func<Playable, int> initialisationFunction, Func<IPlayable, int> triggerValueFunction, TriggerType trigger,
			TriggerSource triggerSource = TriggerSource.ALL, SelfCondition triggerCondition = null)
		{
			_initialisationFunction = initialisationFunction;
			_costFunction = triggerValueFunction;
			_triggerType = trigger;
			_triggerSource = triggerSource;
			_condition = triggerCondition;
		}

		private AdaptiveCostEffect(AdaptiveCostEffect prototype, IPlayable owner)
		{
			if (!(owner is Playable p))
				throw new Exception($"Can't activate {this} to non-playable {owner}");

			_owner = p;

			if (prototype._triggerType != TriggerType.NONE)
			{
				_costFunction = prototype._costFunction;
				_value = prototype._value;
				_triggerType = prototype._triggerType;
				_triggerSource = prototype._triggerSource;
				_condition = prototype._condition;
				_updateHandler = Trigger;
				_removedHandler = RemoveAtEnd;
				_isTriggered = prototype._isTriggered;
				_isAppliedThisTurn = prototype._isAppliedThisTurn;

				if (prototype._initialisationFunction != null)
				{
					_initialisationFunction = prototype._initialisationFunction;
					_cachedValue = prototype._initialisationFunction.Invoke(p);
				}
			}
			else if (prototype._condition != null)
			{
				_condition = prototype._condition;
			}
			else
			{
				_costFunction = prototype._costFunction;
				_operator = prototype._operator;
			}
		}

		public IPlayable Owner => _owner;

		public void Activate(Playable owner, bool cloning = false)
		{
			if (!cloning && !(owner.Zone is HandZone)) return;

			var instance = new AdaptiveCostEffect(this, owner);

			if (owner._costManager == null)
				owner._costManager = new Playable.CostManager();

			owner._costManager.ActivateAdaptiveEffect(instance);
			owner.OngoingEffect = instance;

			switch (_triggerType)
			{
				case TriggerType.NONE:
					break;
				case TriggerType.HEAL:
					owner.Game.TriggerManager.HealTrigger += instance._updateHandler;
					break;
				case TriggerType.DEATH:
					owner.Game.TriggerManager.DeathTrigger += instance._updateHandler;
					break;
				case TriggerType.CAST_SPELL:
					owner.Game.TriggerManager.CastSpellTrigger += instance._updateHandler;
					break;
				case TriggerType.TURN_START:
					owner.Game.TriggerManager.TurnStartTrigger += instance._updateHandler;
					break;
				case TriggerType.ZONE:
					owner.Game.TriggerManager.ZoneTrigger += instance._updateHandler;
					break;
				default:
					throw new NotImplementedException();
			}

			owner.Game.Auras.Add(instance);
		}

		public int Apply(int value)
		{
			if (_initialisationFunction != null)
				return _cachedValue;

			if (_costFunction != null)
			{
				if (_operator == EffectOperator.SUB)
					return value - _costFunction.Invoke(_owner);
				if (_operator == EffectOperator.SET)
					return _costFunction.Invoke(_owner);
				if (_operator == EffectOperator.ADD)
					return value + _costFunction.Invoke(_owner);
				if (_operator == EffectOperator.MUL)
					return value * _costFunction.Invoke(_owner);
			}
				

			if (_isAppliedThisTurn)
				return _value;

			return value;
		}

		public void Remove()
		{
			_owner.OngoingEffect = null;
			_owner.Game.Auras.Remove(this);
			_owner._costManager?.DeactivateAdaptiveEffect();

			switch (_triggerType)
			{
				case TriggerType.NONE:
					break;
				case TriggerType.HEAL:
					_owner.Game.TriggerManager.HealTrigger -= _updateHandler;
					break;
				case TriggerType.DEATH:
					_owner.Game.TriggerManager.DeathTrigger -= _updateHandler;
					break;
				case TriggerType.CAST_SPELL:
					_owner.Game.TriggerManager.CastSpellTrigger -= _updateHandler;
					break;
				case TriggerType.TURN_START:
					_owner.Game.TriggerManager.TurnStartTrigger -= _updateHandler;
					break;
				case TriggerType.ZONE:
					_owner.Game.TriggerManager.ZoneTrigger -= _updateHandler;
					break;
				default:
					throw new NotImplementedException();
			}
		}

		void IAura.Activate(IPlayable owner)
		{
			Activate((Playable)owner, false);
		}

		public void Update()
		{
			if (_triggerType != TriggerType.NONE)
			{
				if (_initialisationFunction != null)
				{
					_owner._costManager.UpdateAdaptiveEffect(_cachedValue);
					return;
				}

				if (!_isTriggered) return;

				if (_isAppliedThisTurn) return;

				_owner._costManager.UpdateAdaptiveEffect(_value);

				_isAppliedThisTurn = true;
			}
			else
			{
				_owner._costManager.UpdateAdaptiveEffect();
			}
			// TODO History
		}

		private void Trigger(IEntity sender)
		{
			if (_isTriggered)
				return;

			switch (_triggerSource)
			{
				case TriggerSource.ALL:
					break;
				case TriggerSource.FRIENDLY:
					if (sender.Controller != Owner.Controller)
						return;
					break;
				default:
					throw new NotImplementedException();
			}

			if (_condition != null)
			{
				if (!(sender is IPlayable p)) p = _owner;

				if (!(_condition.Eval(p))) return;
			}

			if (_initialisationFunction != null)
				_cachedValue += _costFunction.Invoke((IPlayable)sender);
			else
			{
				_isTriggered = true;

				_owner.Game.TriggerManager.EndTurnTrigger += _removedHandler;
			}
		}

		private void RemoveAtEnd(IEntity sender)
		{
			_owner._costManager?.UpdateAdaptiveEffect();
			_isTriggered = false;
			_isAppliedThisTurn = false;
			_owner.Game.TriggerManager.EndTurnTrigger -= _removedHandler;
		}

		public void Clone(IPlayable clone)
		{
			Activate((Playable)clone, true);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[ACE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}

		public static readonly AdaptiveCostEffect NumEachMinionDiedThisTurn
			= new AdaptiveCostEffect(p => p.Controller.NumFriendlyMinionsThatDiedThisTurn
			                              + p.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn);
	}
}
