using System;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Implementation of the specific effects of varying cost. e.g. Giants
	/// </summary>
	public class AdaptiveCostEffect : Aura
	{
		private readonly EffectOperator _operator;
		private readonly Predicate<IPlayable> _predicate;
		private readonly int _value;
		private readonly Func<IPlayable, int> _costFunction;

		//public (TriggerType Type, TriggerSource Source, SelfCondition Condition) UpdateTrigger;

		public AdaptiveCostEffect(EffectOperator @operator, Func<IPlayable, int> costFunc) : base(AuraType.ADAPTIVE)
		{
			_costFunction = costFunc;
			_operator = @operator;
		}

		/// <summary>
		/// Creates an Adaptive Cost Effect that sets cost of the target to a specific value
		/// when the given criterion is satisfied. (e.g. Happy Ghoul, Arcane Tyrant)
		/// </summary>
		public AdaptiveCostEffect(int value, Predicate<IPlayable> predicate) : base(AuraType.ADAPTIVE)
		{
			_predicate = predicate;
			_value = value;
		}

		private AdaptiveCostEffect(AdaptiveCostEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			_operator = prototype._operator;
			//UpdateTrigger = prototype.UpdateTrigger;
			_predicate = prototype._predicate;
			_costFunction = prototype._costFunction;
			_value = prototype._value;
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			if (!cloning && !(owner.Zone is HandZone)) return;

			var instance = new AdaptiveCostEffect(this, owner);

			owner.AuraEffects.AdaptiveCostEffect = instance;
			owner.OngoingEffect = instance;
			owner.Game.Auras.Add(instance);

			//if (UpdateTrigger.Type != TriggerType.NONE)
			//{
			//	owner.Game.TriggerManager.AddTrigger(UpdateTrigger.Type, instance.TriggeredUpdate);
			//}
			//else
			//	_toBeUpdated = true;
		}

		public int Apply(int value)
		{
			if (_predicate != null)
				return _predicate(Owner) ? _value : value;

			switch (_operator)
			{
				case EffectOperator.ADD:
					return value + _costFunction(Owner);
				case EffectOperator.SUB:
					return value - _costFunction(Owner);
				case EffectOperator.SET:
					return _costFunction(Owner);
				case EffectOperator.MUL:
					return value * _costFunction(Owner);
			}

			return 0;
		}

		public override void Remove()
		{
			Owner.AuraEffects.AdaptiveCostEffect = null;
			Owner.OngoingEffect = null;
			Owner.Game.Auras.Remove(this);
			//if (UpdateTrigger.Type != 0)
			//	Owner.Game.TriggerManager.RemoveTrigger(UpdateTrigger.Type, TriggeredUpdate);
		}

		public override void Update()
		{
			//if (!_toBeUpdated) return;
			Owner.AuraEffects.ToBeUpdated = true;
			//if (UpdateTrigger.Type != TriggerType.NONE)
			//	_toBeUpdated = false;
		}

		//private void TriggeredUpdate(IEntity sender)
		//{
		//	switch (UpdateTrigger.Source)
		//	{
		//		case TriggerSource.ALL:
		//			break;
		//		case TriggerSource.FRIENDLY:
		//			if (sender.Controller != Owner.Controller) return;
		//			break;
		//		default:
		//			throw new NotImplementedException();
		//	}

		//	if (UpdateTrigger.Condition != null && sender is IPlayable p)
		//	{
		//		if (!UpdateTrigger.Condition.Eval(p))
		//			return;
		//	}

		//	_toBeUpdated = true;
		//}

		public override void Clone(IPlayable clone)
		{
			Activate(clone, true);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[ACE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
