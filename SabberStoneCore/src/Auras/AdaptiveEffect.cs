using System;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Effects of this kind of Auras are influenced by other factors in game, in real time. e.g. Lightspawn, Southsea Deckhand.
	/// </summary>
	public class AdaptiveEffect : Aura
	{
		//private readonly GameTag _tag;
		//private readonly EffectOperator _operator;
		//private int _lastValue;
		//private readonly GameTag[] _tags;
		//private readonly int[] _lastValues;
		private readonly bool _isSwitching;
		private readonly ConditionalEffect _effect;

		/// <summary>
		/// Defines a kind of effects in which the given tag varies with the value from the given function. (e.g. giants)
		/// </summary>
		public AdaptiveEffect(GameTag tag, EffectOperator @operator, Func<IPlayable, int> valueFunc) : base(AuraType.ADAPTIVE)
		{
			//ValueFunc = valueFunc;
			//_tag = tag;
			//_operator = @operator;

			_effect = new ConditionalEffect(tag, @operator, valueFunc);
		}

		/// <summary>
		/// Defines a kind of effects in which the given tags are boolean and determined by a specific condition. (e.g. Southsea Deckhand)
		/// </summary>
		public AdaptiveEffect(SelfCondition condition, GameTag tag) : base(AuraType.ADAPTIVE)
		{
			//Condition = condition;
			_isSwitching = true;
			//_tags = tags;
			//_lastValues = new int[tags.Length];
			_effect = new ConditionalEffect(tag, condition);
		}

		private AdaptiveEffect(AdaptiveEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			//if (prototype._isSwitching)
			//{
			//	_isSwitching = true;
			//	_tags = prototype._tags;
			//	_lastValues = new int[_tags.Length];
			//	Array.Copy(prototype._lastValues, _lastValues, _lastValues.Length);
			//	Condition = prototype.Condition;
			//	return;
			//}
			//_tag = prototype._tag;
			//_operator = prototype._operator;
			//_lastValue = prototype._lastValue;

			_isSwitching = prototype._isSwitching;

			_effect = prototype._effect.Clone();
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			var instance = new AdaptiveEffect(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public override void Update()
		{
			if (On)
			{
				if (_isSwitching)
					_effect.ReApplyTo(Owner);
				else
					_effect.ReApplyTo(Owner.AuraEffects);
			}
			else
			{
				if (_isSwitching)
					_effect.RemoveFrom(Owner);
				else
					_effect.RemoveFrom(Owner.AuraEffects);

				Game.Auras.Remove(this);
			}



			//if (_isSwitching)
			//{
			//	GameTag[] tags = _tags;
			//	for (int i = 0; i < tags.Length; i++)
			//	{
			//		int val = Condition.Eval(Owner) ? 1 : 0;
			//		if (_lastValues[i] == val) continue;

			//		//Owner[_tags[i]] = val;
			//		switch (tags[i])
			//		{
			//			case GameTag.ATK:
			//				new AttackEffect(EffectOperator.SET, val).ApplyTo(Owner);
			//				break;
			//			case GameTag.HEALTH:
			//				new HealthEffect(EffectOperator.SET, val).ApplyTo(Owner);
			//				break;
			//			default:
			//				new Effect(_tags[i], EffectOperator.SET, val).ApplyTo(Owner);
			//				break;
			//		}
			//		_lastValues[i] = val;
			//	}


			//	return;
			//}


			//switch (_operator)
			//{
			//	case EffectOperator.ADD:
			//	{
			//		Owner.AuraEffects[_tag] -= _lastValue;
			//		int val = ValueFunc(Owner);
			//		Owner.AuraEffects[_tag] += val;
			//		_lastValue = val;
			//		return;
			//	}
			//	case EffectOperator.SUB:
			//	{
			//		Owner.AuraEffects[_tag] += _lastValue;
			//		int val = ValueFunc(Owner);
			//		Owner.AuraEffects[_tag] -= val;
			//		_lastValue = val;
			//		return;
			//	}
			//	case EffectOperator.SET:
			//		if (Owner is Character c)
			//		{
			//			switch (_tag)
			//			{
			//				case GameTag.ATK:
			//					c._atkModifier = 0;
			//					break;
			//				case GameTag.HEALTH:
			//					c._healthModifier = 0;
			//					break;
			//			}
			//		}
			//		else
			//			Owner[_tag] = 0;

			//		Owner.AuraEffects[_tag] = ValueFunc(Owner);
			//		return;
			//}
		}

		public override void Remove()
		{
			Owner.OngoingEffect = null;
			On = false;

			//switch (_operator)
			//{
			//	case EffectOperator.ADD:
			//		Owner.AuraEffects[_tag] -= _lastValue;
			//		return;
			//	case EffectOperator.SUB:
			//		Owner.AuraEffects[_tag] += _lastValue;
			//		return;
			//	case EffectOperator.SET:
			//		Owner.AuraEffects[_tag] = 0;
			//		if (Owner.Zone is BoardZone board)
			//			board.Auras.ForEach(p => p.EntityRemoved(Owner));
			//		return;
			//}
			//_effect.RemoveFrom(Owner);

		}

		public override void Clone(IPlayable clone)
		{
			Activate(clone);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[AE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
