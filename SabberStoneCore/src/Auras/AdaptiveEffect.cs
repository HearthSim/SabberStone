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
	public class AdaptiveEffect : IAura
	{
		private readonly bool _isSwitching;
		private readonly Func<Playable, int> _valueFunction;
		private readonly SelfCondition _condition;
		private readonly Playable _owner;
		private readonly GameTag _tag;
		private readonly EffectOperator _operator;

		private bool _on = true;
		private int _lastValue;

		/// <summary>
		/// Defines a kind of effects in which the given tag varies with the value from the given function. (e.g. giants)
		/// </summary>
		public AdaptiveEffect(GameTag tag, EffectOperator @operator, Func<Playable, int> valueFunc)
		{
			_tag = tag;
			_operator = @operator;
			_valueFunction = valueFunc;
		}

		/// <summary>
		/// Defines a kind of effects in which the given tags are boolean and determined by a specific condition. (e.g. Southsea Deckhand)
		/// </summary>
		public AdaptiveEffect(SelfCondition condition, GameTag tag)
		{
			_isSwitching = true;
			_tag = tag;
			_condition = condition;
			_operator = EffectOperator.SET;
		}

		private AdaptiveEffect(AdaptiveEffect prototype, Playable owner)
		{
			_isSwitching = prototype._isSwitching;
			_valueFunction = prototype._valueFunction;
			_tag = prototype._tag;
			_operator = prototype._operator;
			_condition = prototype._condition;
			_lastValue = prototype._lastValue;
			_on = prototype._on;

			_owner = owner;
		}

		IPlayable IAura.Owner => _owner;

		public void Activate(IPlayable owner)
		{
			if (!(owner is Playable m))
				throw new Exception($"Can't activate Adaptive Effect on non-Playable entity {owner}.");

			IAura instance = new AdaptiveEffect(this, m);

			if (!_isSwitching)
			{
				if (m is Weapon)
				{
					if (m.Controller.Hero.AuraEffects == null)
						m.Controller.Hero.AuraEffects = new AuraEffects(CardType.HERO);
				}
				else if (m.AuraEffects == null)
					m.AuraEffects = new AuraEffects(CardType.MINION);
			}

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public void Update()
		{
			if (_on)
			{
				int value;

				if (_isSwitching)
				{
					value = _condition.Eval(_owner) ? 1 : 0;

					if (value == _lastValue)
						return;


					if (_tag == GameTag.ATK)
					{
						ATK.Effect(_operator, _lastValue).RemoveFrom(_owner);
						ATK.Effect(_operator, value).ApplyTo(_owner);
					}
					else
					{
						new Effect(_tag, _operator, _lastValue).RemoveFrom(_owner);
						new Effect(_tag, _operator, value).ApplyTo(_owner);
					}
				}
				else
				{
					value = _valueFunction(_owner);

					if (_tag == GameTag.ATK)
					{
						if (!(_owner is Character c))
						{
							if (_owner is Weapon)
								c = _owner.Controller.Hero;
							else
								throw new Exception($"Can't apply ATK aura {this} to entity {_owner}");
						}

						if (_operator == EffectOperator.SET)
						{
							c._modifiedATK = 0;
							ATK.Effect(EffectOperator.ADD, _lastValue).RemoveAuraFrom(c);
							value = value - (c.AuraEffects?.ATK ?? 0);
							ATK.Effect(EffectOperator.ADD, value).ApplyAuraTo(c);
						}
						else
						{
							ATK.Effect(_operator, _lastValue).RemoveAuraFrom(c);
							ATK.Effect(_operator, value).ApplyAuraTo(c);
						}
					}
					else
					{
						new Effect(_tag, _operator, _lastValue).RemoveAuraFrom(_owner);
						new Effect(_tag, _operator, value).ApplyAuraTo(_owner);
					}
				}

				_lastValue = value;
			}
			else
			{
				if (_isSwitching)
				{
					if (_tag == GameTag.ATK)
						ATK.Effect(_operator, _lastValue).RemoveFrom(_owner);
					else
						new Effect(_tag, _operator, _lastValue).RemoveFrom(_owner);
				}
				else
				{
					if (_tag == GameTag.ATK)
						ATK.Effect(_operator, _lastValue).RemoveAuraFrom(_owner is Weapon ? _owner.Controller.Hero : _owner);
					else
						new Effect(_tag, _operator, _lastValue).RemoveAuraFrom(_owner);
				}

				_owner.Game.Auras.Remove(this);
			}
		}

		public void Remove()
		{
			_owner.OngoingEffect = null;
			_on = false;
		}

		public void Clone(IPlayable clone)
		{
			Activate(clone);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[AE:");
			sb.Append(_owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
