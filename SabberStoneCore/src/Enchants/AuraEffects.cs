using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class AuraEffects
	{
		private class CostEffect
		{
			private readonly Func<int, int> _func;

			public readonly int Hash;

			public CostEffect(Effect e)
			{
				Effect = e;

				switch (e.Operator)
				{
					case EffectOperator.ADD:
						_func = p => p + e.Value;
						break;
					case EffectOperator.SUB:
						_func = p => p >= e.Value ? p - e.Value : 0;
						break;
					case EffectOperator.SET:
						_func = p => e.Value;
						break;
					case EffectOperator.MUL:
						throw new NotImplementedException();
				}
			}

			public Effect Effect { get; }

			public int Apply(int c)
			{
				return _func(c);
			}
		}

		private int ATK;
		private int HEALTH;
		private int COST;
		private int CHARGE;

		private List<CostEffect> _costEffects;
		private AdaptiveCostEffect _adaptiveCostEffect;

		public AuraEffects(IEntity owner)
		{
			Owner = owner;
			if (owner is IPlayable)
				COST = owner.Card[GameTag.COST];
		}
		private AuraEffects() { }

		public IEntity Owner { get; private set; }

		public AdaptiveCostEffect AdaptiveCostEffect
		{
			get => _adaptiveCostEffect;
			set
			{
				_adaptiveCostEffect = value;
				Checker = true;
			}
		}
		public bool Checker { get; set; }

		public int this[GameTag t]
		{
			get
			{
				switch (t)
				{
					case GameTag.ATK:
						return ATK;
					case GameTag.HEALTH:
						return HEALTH;
					case GameTag.CHARGE:
						return CHARGE;
					case GameTag.COST:
						return GetCost() - ((Entity) Owner)._data[GameTag.COST];
					default:
						return 0;
				}
			}
			set
			{
				switch (t)
				{
					case GameTag.ATK:
						ATK = value;
						return;
					case GameTag.HEALTH:
						HEALTH = value;
						return;
					case GameTag.CHARGE:
						CHARGE = value;
						return;
					case GameTag.COST:
						COST = value;
						return;
					default:
						return;
				}
			}
		}

		public void AddCostAura(Effect e)
		{
			Checker = true;

			if (_costEffects == null)
				_costEffects = new List<CostEffect>(1);

			_costEffects.Add(new CostEffect(e));
		}

		public void RemoveCostAura(Effect e)
		{
			Checker = true;
			for (int i = 0; i < _costEffects.Count; i++)
			{
				if (!_costEffects[i].Effect.Equals(e)) continue;

				_costEffects.Remove(_costEffects[i]);
				return;
			}

			throw new Exception();
		}

		public int GetCost()
		{
			if (!Checker) return COST;

			int c = Owner[GameTag.COST];
			for (int i = 0; i < _costEffects?.Count; i++)
				c = _costEffects[i].Apply(c);
			COST = c;
			Checker = false;

			if (AdaptiveCostEffect != null)
				COST = AdaptiveCostEffect.Apply(COST);

			return COST > 0 ? COST : 0;
		}

		public AuraEffects Clone(IEntity clone)
		{
			return new AuraEffects()
			{
				ATK = ATK,
				HEALTH = HEALTH,
				COST = COST,
				CHARGE = CHARGE,
				Owner = clone,
				_costEffects = _costEffects != null ? new List<CostEffect>(_costEffects) : null
			};
		}
	}

	public class ControllerAuraEffects
	{
		private int _timeOut;
		private int _spellPowerDouble;
		private int _restoreToDamage;
		private int _extraBattecry;
		private int _chooseBoth;
		private int _extraEndTurnEffect;
		private int _heroPowerDisabled;

		public int this[GameTag t]
		{
			get
			{
				switch (t)
				{
					case GameTag.TIMEOUT:
						return _timeOut;
					case GameTag.SPELLPOWER_DOUBLE:
					case GameTag.HERO_POWER_DOUBLE:
					case GameTag.HEALING_DOUBLE:
						return _spellPowerDouble;
					case GameTag.RESTORE_TO_DAMAGE:
						return _restoreToDamage >= 1 ? 1 : 0;
					case GameTag.CHOOSE_BOTH:
						return _chooseBoth >= 1 ? 1 : 0;
					case GameTag.EXTRA_BATTLECRY:
						return _extraBattecry;
					case GameTag.EXTRA_END_TURN_EFFECT:
						return _extraEndTurnEffect;
					case GameTag.HERO_POWER_DISABLED:
						return _heroPowerDisabled >= 1 ? 1 : 0;
					default:
						return 0;
				}
			}
			set
			{
				switch (t)
				{
					case GameTag.TIMEOUT:
						_timeOut = value;
						return;
					case GameTag.SPELLPOWER_DOUBLE:
					case GameTag.HERO_POWER_DOUBLE:
					case GameTag.HEALING_DOUBLE:
						_spellPowerDouble = value;
						return;
					case GameTag.RESTORE_TO_DAMAGE:
						_restoreToDamage = value;
						return;
					case GameTag.CHOOSE_BOTH:
						_chooseBoth = value;
						return;
					case GameTag.EXTRA_BATTLECRY:
						_extraBattecry = value;
						return;
					case GameTag.EXTRA_END_TURN_EFFECT:
						_extraEndTurnEffect = value;
						return;
					default:
						return;
				}
			}
		}

		public ControllerAuraEffects Clone()
		{
			return (ControllerAuraEffects)MemberwiseClone();
		}
	}
}
