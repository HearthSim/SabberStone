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
		private int IMMUNE;
		private int LIFESTEAL;
		private int CANT_ATTACK;
		private int CANT_BE_TARGETED_BY_SPELLS;
		private int CARD_COST_HEALTH;
		private int RUSH;
		private int ECHO;
		private int CANTATTACKHEROES;

		private List<CostEffect> _costEffects;
		private AdaptiveCostEffect _adaptiveCostEffect;

		public AuraEffects(IEntity owner)
		{
			Owner = owner;
			if (owner is IPlayable)
				COST = owner.Card[GameTag.COST];
		}

		private AuraEffects(IEntity owner, AuraEffects other)
		{
			Owner = owner;
			Checker = Checker;
			_costEffects = other._costEffects?.Count > 0 ? new List<CostEffect>(other._costEffects) : null;
			COST = other.COST;
			CANT_BE_TARGETED_BY_SPELLS = other.CANT_BE_TARGETED_BY_SPELLS;
			IMMUNE = other.IMMUNE;
			ATK = other.ATK;
			CANTATTACKHEROES = other.CANTATTACKHEROES;
			if (!(owner is Minion)) return;
			HEALTH = other.HEALTH;
			CHARGE = other.CHARGE;
			WINDFURY = other.WINDFURY;
			LIFESTEAL = other.LIFESTEAL;
			CANT_ATTACK = other.CANT_ATTACK;
			CARD_COST_HEALTH = other.CARD_COST_HEALTH;
			RUSH = other.RUSH;
			ECHO = other.ECHO;
		}

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
					case GameTag.COST:
						return GetCost() - ((Entity)Owner)._data[GameTag.COST];
					case GameTag.CHARGE:
						return CHARGE > 0 ? 1 : 0;
					case GameTag.WINDFURY:
						return WINDFURY > 0 ? 1 : 0;
					case GameTag.IMMUNE:
						return IMMUNE;
					case GameTag.LIFESTEAL:
						return LIFESTEAL;
					//case GameTag.CANT_ATTACK:
					//	return CANT_ATTACK;
					case GameTag.CANT_BE_TARGETED_BY_SPELLS:
					case GameTag.CANT_BE_TARGETED_BY_HERO_POWERS:
						return CANT_BE_TARGETED_BY_SPELLS >= 1 ? 1 : 0;
					case GameTag.CARD_COSTS_HEALTH:
						return CARD_COST_HEALTH;
					case GameTag.RUSH:
						return RUSH > 0 ? 1 : 0;
					case GameTag.ECHO:
						return ECHO > 0 ? 1 : 0;
					case GameTag.CANNOT_ATTACK_HEROES:
						return CANTATTACKHEROES;
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
						if (value > 0 && Owner[GameTag.EXHAUSTED] == 1 && Owner[GameTag.NUM_ATTACKS_THIS_TURN] < 1)
							Owner[GameTag.EXHAUSTED] = 0;
						if (((Minion)Owner).AttackableByRush)
							Owner[GameTag.ATTACKABLE_BY_RUSH] = 0;
						return;
					case GameTag.COST:
						COST = value;
						return;
					case GameTag.WINDFURY:
						WINDFURY = value;
						if (value > 0 && Owner[GameTag.NUM_ATTACKS_THIS_TURN] == 1)
							Owner[GameTag.EXHAUSTED] = 0;
						return;
					case GameTag.HEALTH_MINIMUM:
						Owner[GameTag.HEALTH_MINIMUM] = value;
						return;
					case GameTag.IMMUNE:
						IMMUNE = value;
						return;
					case GameTag.LIFESTEAL:
						LIFESTEAL = value;
						return;
					//case GameTag.CANT_ATTACK:
					//	CANT_ATTACK = value;
					//	return;
					case GameTag.CANT_BE_TARGETED_BY_SPELLS:
					case GameTag.CANT_BE_TARGETED_BY_HERO_POWERS:
						CANT_BE_TARGETED_BY_SPELLS = value;
						return;
					case GameTag.CARD_COSTS_HEALTH:
						CARD_COST_HEALTH = value;
						return;
					case GameTag.RUSH:
						RUSH = value;
						if (value > 0 && Owner[GameTag.EXHAUSTED] == 1 && Owner[GameTag.NUM_ATTACKS_THIS_TURN] == 0)
						{
							Owner[GameTag.EXHAUSTED] = 0;
							Owner[GameTag.ATTACKABLE_BY_RUSH] = 1;
						}
						return;
					case GameTag.ECHO:
						ECHO = value;
						return;
					case GameTag.CANNOT_ATTACK_HEROES:
						CANTATTACKHEROES = value;
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
			if (_costEffects == null)
				return;
			Checker = true;
			for (int i = 0; i < _costEffects.Count; i++)
			{
				if (!_costEffects[i].Effect.Equals(e)) continue;

				_costEffects.Remove(_costEffects[i]);
				return;
			}

			throw new Exception($"Can't remove cost aura from {Owner}. Zone: {Owner.Zone.Type}, IsDead?: {Owner[GameTag.TO_BE_DESTROYED] == 1}");
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

			if (COST < 0)
				COST = 0;
			return COST;
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
			return new AuraEffects(clone, this);
		}

		public string Hash()
		{
			var hash = new StringBuilder();
			hash.Append("[AE:");
			hash.Append($"{{COST,{COST}}}");
			if (ATK > 0)
				hash.Append($"{{ATK,{ATK}}}");
			if (HEALTH > 0)
				hash.Append($"{{HEALTH,{HEALTH}}}");
			if (CHARGE > 0)
				hash.Append($"{{CHARGE,{CHARGE}}}");
			if (WINDFURY > 0)
				hash.Append($"{{WINDFURY,{WINDFURY}}}");
			if (LIFESTEAL > 0)
				hash.Append($"{{LIFESTEAL,{LIFESTEAL}}}");
			if (IMMUNE > 0)
				hash.Append($"{{IMMUNE,{IMMUNE}}}");
			if (CANT_BE_TARGETED_BY_SPELLS > 0)
				hash.Append($"{{CANT_BE_TARGETED_BY_SPELLS,{CANT_BE_TARGETED_BY_SPELLS}}}");
			if (CARD_COST_HEALTH > 0)
				hash.Append($"{{CARD_COST_HEALTH,{CARD_COST_HEALTH}}}");
			if (RUSH > 0)
				hash.Append($"{{RUSH,{RUSH}}}");
			if (ECHO > 0)
				hash.Append($"{{ECHO,{ECHO}}}");
			if (CANTATTACKHEROES == 1)
				hash.Append($"{{CANNOT_ATTACK_HEROES,{CANTATTACKHEROES}");
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
		private int _heroPowerDouble;
		private int _restoreToDamage;
		private int _extraBattecry;
		private int _chooseBoth;
		private int _spellsCostHealth;
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
					case GameTag.SPELL_HEALING_DOUBLE:
						return _spellPowerDouble;
					case GameTag.HERO_POWER_DOUBLE:
						return _heroPowerDouble;
					case GameTag.HEALING_DOES_DAMAGE:
						return _restoreToDamage >= 1 ? 1 : 0;
					case GameTag.CHOOSE_BOTH:
						return _chooseBoth >= 1 ? 1 : 0;
					case GameTag.SPELLS_COST_HEALTH:
						return _spellsCostHealth >= 1 ? 1 : 0;
					case GameTag.EXTRA_BATTLECRIES_BASE:
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
					case GameTag.SPELL_HEALING_DOUBLE:
						_spellPowerDouble = value;
						return;
					case GameTag.HERO_POWER_DOUBLE:
						_heroPowerDouble = value;
						return;
					case GameTag.HEALING_DOES_DAMAGE:
						_restoreToDamage = value;
						return;
					case GameTag.CHOOSE_BOTH:
						_chooseBoth = value;
						return;
					case GameTag.SPELLS_COST_HEALTH:
						_spellsCostHealth = value;
						return;
					case GameTag.EXTRA_BATTLECRIES_BASE:
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

		public string Hash()
		{
			var sb = new StringBuilder("[CAE:");
			sb.Append(_timeOut);
			sb.Append(_spellPowerDouble);
			sb.Append(_heroPowerDouble);
			sb.Append(_restoreToDamage);
			sb.Append(_extraBattecry);
			sb.Append(_chooseBoth);
			sb.Append(_spellsCostHealth);
			sb.Append(_extraEndTurnEffect);
			sb.Append(_heroPowerDisabled);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
