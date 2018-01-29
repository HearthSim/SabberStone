using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// A simple container for saving tag value perturbations from external Auras. Call indexer to get value for a particular Tag.
	/// </summary>
	public class AuraEffects
	{
		private class CostEffect
		{
			private readonly Func<int, int> _func;

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

			public readonly Effect Effect;

			public int Apply(int c)
			{
				return _func(c);
			}
		}

		private int ATK;
		private int HEALTH;
		private int COST;
		private int CHARGE;
		private int WINDFURY;

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
						return CHARGE > 0 ? 1 : 0;
					case GameTag.WINDFURY:
						return WINDFURY > 0 ? 1 : 0;
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
					case GameTag.WINDFURY:
						WINDFURY = value;
						return;
					case GameTag.HEALTH_MINIMUM:
						Owner[GameTag.HEALTH_MINIMUM] = value;
						return;
					default:
						return;
				}
			}
		}

		/// <summary>
		/// Add a new Cost related effect to the owner.
		/// </summary>
		public void AddCostAura(Effect e)
		{
			Checker = true;

			if (_costEffects == null)
				_costEffects = new List<CostEffect>{ new CostEffect(e) };
			else
				_costEffects.Add(new CostEffect(e));
		}

		/// <summary>
		/// Remove a Cost related effect from the owner.
		/// </summary>
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

		/// <summary>
		/// Gets the estimated Cost of the owner.
		/// </summary>
		/// <returns></returns>
		public int GetCost()
		{
			if (!Checker) return COST;

			// Obtain the Card Cost
			if (!Owner.NativeTags.TryGetValue(GameTag.COST, out int c))
				Owner.Card.Tags.TryGetValue(GameTag.COST, out c);
			// Apply Cost effects
			for (int i = 0; i < _costEffects?.Count; i++)
				c = _costEffects[i].Apply(c);
			COST = c;
			Checker = false;

			// Lastly apply Adaptive Cost effect (Giants + Naga Sea Witch)
			if (AdaptiveCostEffect != null)
				COST = AdaptiveCostEffect.Apply(COST);

			return COST > 0 ? COST : 0;
		}

		public void ResetCost()
		{
			if (_costEffects == null && AdaptiveCostEffect == null && !Owner.NativeTags.ContainsKey(GameTag.COST)) return;

			_costEffects = null;
			Owner.NativeTags.Remove(GameTag.COST);
			AdaptiveCostEffect?.Remove();
			COST = Owner.Card[GameTag.COST];
			if (Owner.Game.History)
				Owner.Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Owner.Id, GameTag.COST, COST));
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
				Checker = Checker,
				_costEffects = _costEffects != null ? new List<CostEffect>(_costEffects) : null
			};
		}

		public string Hash()
		{
			var hash = new StringBuilder();
			hash.Append("[AE:");
			hash.Append($"{{ATK,{ATK}}}");
			hash.Append($"{{HEALTH,{HEALTH}}}");
			hash.Append($"{{COST,{COST}}}");
			hash.Append($"{{CHARGE,{CHARGE}}}");
			hash.Append($"{{WINDFURY,{WINDFURY}}}");
			hash.Append("]");
			return hash.ToString();
		}
	}

	/// <summary>
	/// A collecton of controller Tag increments from Auras. These tags tends to be checked when a player plays any cards.
	/// </summary>
	public class ControllerAuraEffects
	{
		private int _timeOut;
		private int _spellPowerDouble;
		private int _restoreToDamage;
		private int _extraBattecry;
		private int _chooseBoth;
		private int _spells_cost_health;
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
					case GameTag.SPELLS_COST_HEALTH:
						return _spells_cost_health >= 1 ? 1 : 0;
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
					case GameTag.SPELLS_COST_HEALTH:
						_spells_cost_health = value;
						return;
					case GameTag.EXTRA_BATTLECRY:
						_extraBattecry = value;
						return;
					case GameTag.EXTRA_END_TURN_EFFECT:
						_extraEndTurnEffect = value;
						return;
					case GameTag.HERO_POWER_DISABLED:
						_heroPowerDisabled = value;
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
