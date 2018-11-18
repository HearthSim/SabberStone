using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Enchants
{
	//public abstract class AuraEffectBase
	//{
	//	public IEntity Owner { get; }
	//	public abstract int this[GameTag t] { get; set; }

	//	public abstract AuraEffectBase Clone(AuraEffectBase other);
	//	public abstract string Hash();
	//}


	/// <summary>
	/// A simple container for saving tag value perturbations from external Auras. Call indexer to get value for a particular Tag.
	/// </summary>
	public class AuraEffects
	{
		//private int WINDFURY;
		//private int CANT_ATTACK;
		private int CANT_BE_TARGETED_BY_SPELLS;
		private int CARD_COST_HEALTH;
		private int CANTATTACKHEROES;
		private List<Effect> _costEffects;
		private AdaptiveCostEffect _adaptiveCostEffect;

		public Entity Owner { get; private set; }
		public AdaptiveCostEffect AdaptiveCostEffect
		{
			get => _adaptiveCostEffect;
			set
			{
				_adaptiveCostEffect = value;
				ToBeUpdated = true;
			}
		}

		internal bool ToBeUpdated { get; set; }

		// Playable
		internal int Cost;
		internal int Echo { get; set; }

		// Minion
		internal int AttackDamage { get; set; }
		internal int Health { get; set; }
		internal int Charge { get; set; }
		internal int Lifesteal { get; set; }
		internal int Rush { get; set; }

		// Hero
		internal int Immune { get; set; }

		public int this[in GameTag t]
		{
			get
			{
				switch (t)
				{
					case GameTag.ATK:
						return AttackDamage;
					case GameTag.HEALTH:
						return Health;
					case GameTag.COST:
						//return GetCost() - ((Entity)Owner)._data[GameTag.COST];
						return GetCost() - Owner.GetNativeGameTag(GameTag.COST);
					case GameTag.CHARGE:
						return Charge > 0 ? 1 : 0;
					//case GameTag.WINDFURY:
					//	return WINDFURY > 0 ? 1 : 0;
					case GameTag.IMMUNE:
						return Immune;
					case GameTag.LIFESTEAL:
						return Lifesteal;
					//case GameTag.CANT_ATTACK:
					//	return CANT_ATTACK;
					case GameTag.CANT_BE_TARGETED_BY_SPELLS:
					case GameTag.CANT_BE_TARGETED_BY_HERO_POWERS:
						return CANT_BE_TARGETED_BY_SPELLS >= 1 ? 1 : 0;
					case GameTag.CARD_COSTS_HEALTH:
						return CARD_COST_HEALTH;
					case GameTag.RUSH:
						return Rush > 0 ? 1 : 0;
					case GameTag.ECHO:
						return Echo > 0 ? 1 : 0;
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
						AttackDamage = value;
						return;
					case GameTag.HEALTH:
						Health = value;
						return;
					case GameTag.CHARGE:
						{
							Charge = value;
							var m = (Minion)Owner;
							if (value > 0 && m.IsExhausted && m.NumAttacksThisTurn < 1)
								m.IsExhausted = false;
							if (m.AttackableByRush)
								m.AttackableByRush = false;
							return;
						}
					case GameTag.COST:
						Cost = value;
						return;
					//case GameTag.WINDFURY:
					//	WINDFURY = value;
					//	if (value > 0 && Owner[GameTag.NUM_ATTACKS_THIS_TURN] == 1)
					//		Owner[GameTag.EXHAUSTED] = 0;
					//	return;
					case GameTag.HEALTH_MINIMUM:
						Owner[GameTag.HEALTH_MINIMUM] = value;
						return;
					case GameTag.IMMUNE:
						Immune = value;
						return;
					case GameTag.LIFESTEAL:
						Lifesteal = value;
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
						{
							Rush = value;
							var m = (Minion)Owner;
							if (value > 0)
							{
								if (m.IsExhausted && m.NumAttacksThisTurn == 0)
								{
									m.IsExhausted = false;
									m.AttackableByRush = true;
									Owner.Game.RushMinions.Add(Owner.Id);
								}
							}
							else
							{
								if (m.AttackableByRush && !m.IsExhausted)
								{
									if (m.IsRush || Owner.Card.Rush)
										return;

									m.AttackableByRush = false;
									m.IsExhausted = true;
									Owner.Game.RushMinions.Remove(Owner.Id);
								}
							}
							return;
						}
					case GameTag.ECHO:
						Echo = value;
						return;
					case GameTag.CANNOT_ATTACK_HEROES:
						CANTATTACKHEROES = value;
						return;
					default:
						return;
				}
			}
		}

		internal AuraEffects(in Entity owner)
		{
			Owner = owner;
			ToBeUpdated = true;
		}
		private AuraEffects(in Entity owner, in AuraEffects other)
		{
			Owner = owner;
			ToBeUpdated = other.ToBeUpdated;
			_costEffects = other._costEffects?.Count > 0 ? new List<Effect>(other._costEffects) : null;
			Cost = other.Cost;
			CANT_BE_TARGETED_BY_SPELLS = other.CANT_BE_TARGETED_BY_SPELLS;
			Immune = other.Immune;
			AttackDamage = other.AttackDamage;
			CANTATTACKHEROES = other.CANTATTACKHEROES;
			if (!(owner is Minion)) return;
			Health = other.Health;
			Charge = other.Charge;
			//WINDFURY = other.WINDFURY;
			Lifesteal = other.Lifesteal;
			//CANT_ATTACK = other.CANT_ATTACK;
			CARD_COST_HEALTH = other.CARD_COST_HEALTH;
			Rush = other.Rush;
			Echo = other.Echo;
		}

		/// <summary>
		/// Add a new Cost related effect to the owner.
		/// </summary>
		public void AddCostAura(in Effect e)
		{
			ToBeUpdated = true;

			if (_costEffects == null)
				_costEffects = new List<Effect>{e};
			else
				_costEffects.Add(e);
		}

		/// <summary>
		/// Remove a Cost related effect from the owner.
		/// </summary>
		public void RemoveCostAura(in Effect e)
		{
			if (_costEffects == null)
				return;
			ToBeUpdated = true;
			if (_costEffects.Remove(e)) return;

			throw new Exception($"Can't remove cost aura from {Owner}. Zone: {Owner.Zone.Type}, IsDead?: {Owner[GameTag.TO_BE_DESTROYED] == 1}");
		}

		/// <summary>
		/// Add a new Cost effect that should be applied before any others
		/// </summary>
		public void AddPriorCostAura(in Effect e)
		{
			ToBeUpdated = true;

			if (_costEffects == null)
				_costEffects = new List<Effect> {e};
			else
				_costEffects.Insert(0, e);
		}

		/// <summary>
		/// Gets the estimated Cost of the owner.
		/// </summary>
		/// <returns></returns>
		public int GetCost()
		{
			return !ToBeUpdated ? Cost : GetCostInternal();
		}

		private int GetCostInternal()
		{
			// Obtain the Card Cost
			if (!Owner.NativeTags.TryGetValue(GameTag.COST, out int c))
				c = Owner.Card.Cost;
			// Apply Cost effects
			if (_costEffects != null)
				foreach (Effect e in _costEffects)
				{
					switch (e.Operator)
					{
						case EffectOperator.ADD:
							c += e.Value;
							break;
						case EffectOperator.SUB:
							c -= e.Value;
							if (c < 0) c = 0;
							break;
						case EffectOperator.SET:
							c = e.Value;
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}
			ToBeUpdated = false;

			// Lastly apply Adaptive Cost effect (Giants + Naga Sea Witch)
			if (AdaptiveCostEffect != null)
			{
				c = AdaptiveCostEffect.Apply(c);
			}

			if (c < 0) c = 0;

			Cost = c;
			return c;
		}

		public void ResetCost()
		{
			if (_costEffects == null && AdaptiveCostEffect == null && !Owner.NativeTags.ContainsKey(GameTag.COST)) return;

			_costEffects = null;
			Owner.NativeTags.Remove(GameTag.COST);
			AdaptiveCostEffect?.Remove();
			Cost = Owner.Card.Cost;
			if (Owner.Game.History)
				Owner.Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Owner.Id, GameTag.COST, Cost));
		}

		public AuraEffects Clone(Entity clone)
		{
			return new AuraEffects(in clone, this);
		}

		public string Hash()
		{
			var hash = new StringBuilder();
			hash.Append("[AE:");
			hash.Append($"{{COST,{Cost}}}");
			if (AttackDamage > 0)
				hash.Append($"{{ATK,{AttackDamage}}}");
			if (Health > 0)
				hash.Append($"{{HEALTH,{Health}}}");
			if (Charge > 0)
				hash.Append($"{{CHARGE,{Charge}}}");
			//if (WINDFURY > 0)
			//	hash.Append($"{{WINDFURY,{WINDFURY}}}");
			if (Lifesteal > 0)
				hash.Append($"{{LIFESTEAL,{Lifesteal}}}");
			if (Immune > 0)
				hash.Append($"{{IMMUNE,{Immune}}}");
			if (CANT_BE_TARGETED_BY_SPELLS > 0)
				hash.Append($"{{CANT_BE_TARGETED_BY_SPELLS,{CANT_BE_TARGETED_BY_SPELLS}}}");
			if (CARD_COST_HEALTH > 0)
				hash.Append($"{{CARD_COST_HEALTH,{CARD_COST_HEALTH}}}");
			if (Rush > 0)
				hash.Append($"{{RUSH,{Rush}}}");
			if (Echo > 0)
				hash.Append($"{{ECHO,{Echo}}}");
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
		private int _allHealingDouble;

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
					case GameTag.RESTORE_TO_DAMAGE:
						return _restoreToDamage >= 1 ? 1 : 0;
					case GameTag.CHOOSE_BOTH:
						return _chooseBoth >= 1 ? 1 : 0;
					case GameTag.SPELLS_COST_HEALTH:
						return _spellsCostHealth >= 1 ? 1 : 0;
					case GameTag.EXTRA_BATTLECRY:
						return _extraBattecry;
					case GameTag.EXTRA_END_TURN_EFFECT:
						return _extraEndTurnEffect;
					case GameTag.HERO_POWER_DISABLED:
						return _heroPowerDisabled >= 1 ? 1 : 0;
					case GameTag.ALL_HEALING_DOUBLE:
						return _allHealingDouble;
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
					case GameTag.RESTORE_TO_DAMAGE:
						_restoreToDamage = value;
						return;
					case GameTag.CHOOSE_BOTH:
						_chooseBoth = value;
						return;
					case GameTag.SPELLS_COST_HEALTH:
						_spellsCostHealth = value;
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
					case GameTag.ALL_HEALING_DOUBLE:
						_allHealingDouble = value;
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
			sb.Append(_allHealingDouble);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
