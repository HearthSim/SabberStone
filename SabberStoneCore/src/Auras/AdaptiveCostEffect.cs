using System;
using System.Text;
using SabberStoneCore.Conditions;
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
		private Playable _owner;
		private readonly int _value;
		private readonly Func<IPlayable, int> _costFunction;

		private readonly TriggerType _triggerType;
		private readonly TriggerSource _triggerSource;
		private readonly SelfCondition _condition;
		private readonly TriggerManager.TriggerHandler _updateHandler;
		private readonly TriggerManager.TriggerHandler _removedHandler;
		private bool _isTriggered;
		private bool _isAppliedThisTurn;

		//public (TriggerType Type, TriggerSource Source, SelfCondition Condition) UpdateTrigger;

		/// <summary>
		/// Creates an Adaptive Cost Effect. The owner costs less for the calculated value
		/// from the given cost function. (e.g. Giants) The argument of the cost function is
		/// the owner entity.
		/// </summary>
		/// <param name="costFunc">The cost function to calculate the amount the owner costs less than the card's cost.</param>
		public AdaptiveCostEffect(Func<IPlayable, int> costFunc)
		{
			_costFunction = costFunc;
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

		private AdaptiveCostEffect(AdaptiveCostEffect prototype, IPlayable owner)
		{
			if (!(owner is Playable p))
				throw new Exception($"Can't activate {this} to non-playable {owner}");

			_owner = p;

			if (prototype._triggerType != TriggerType.NONE)
			{
				_value = prototype._value;
				_triggerType = prototype._triggerType;
				_triggerSource = prototype._triggerSource;
				_condition = prototype._condition;
				_updateHandler = Trigger;
				_removedHandler = RemoveAtEnd;
				_isTriggered = prototype._isTriggered;
				_isAppliedThisTurn = prototype._isAppliedThisTurn;
			}
			else
			{
				_costFunction = prototype._costFunction;
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
			}

			owner.Game.Auras.Add(instance);
		}

		public int Apply(int value)
		{
			if (_costFunction != null)
				return value - _costFunction.Invoke(_owner);

			if (_isAppliedThisTurn)
				return _value;

			return value;
		}

		public void Remove()
		{
			_owner.OngoingEffect = null;
			_owner.Game.Auras.Remove(this);
			_owner._costManager?.DeactivateAdaptiveEffect();
		}

		void IAura.Activate(IPlayable owner)
		{
			Activate((Playable)owner, false);
		}

		public void Update()
		{
			if (_triggerType != TriggerType.NONE)
			{
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
				if (!(sender is IPlayable p)) return;

				if (!(_condition.Eval(p))) return;
			}

			_owner.Game.TriggerManager.EndTurnTrigger += _removedHandler;

			_isTriggered = true;
		}

		private void RemoveAtEnd(IEntity sender)
		{
			_owner._costManager?.UpdateAdaptiveEffect();
			_isTriggered = false;
			_isAppliedThisTurn = false;
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
