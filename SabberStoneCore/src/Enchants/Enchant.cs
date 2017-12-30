using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Enchants
{
	public enum AuraType
	{
		SELF, ADJACENT, BOARD_EXCEPT_SOURCE, HAND, OP_HAND, HANDS, CONTROLLER
	}

	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}

	public interface IAura
	{
		void Update();
	}

	public struct Effect : IEquatable<Effect>
	{
		public readonly GameTag Tag;
		public readonly EffectOperator Operator;
		public readonly int Value;

		public Effect(GameTag tag, EffectOperator @operator, int value)
		{
			Tag = tag;
			Operator = @operator;
			Value = value;
		}

		public void Apply(IEntity entity)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					entity.NativeTags[Tag] += Value;
					return;
				case EffectOperator.SUB:
					entity.NativeTags[Tag] -= Value;
					return;
				case EffectOperator.MUL:
					entity.NativeTags[Tag] *= Value;
					return;
				case EffectOperator.SET:
					entity.NativeTags[Tag] = Value;
					return;
				default:
					throw new ArgumentException();
			}
		}

		public void Apply(AuraEffects auraEffects)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SET:
					auraEffects[Tag] = Value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void Remove(IEntity entity)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					entity[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					entity[Tag] += Value;
					return;
				case EffectOperator.SET:
					entity[Tag] = 0;
					return;
			}
		}

		public void Remove(AuraEffects auraEffects)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					auraEffects[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SET:
					auraEffects[Tag] = 0;
					return;
			}
		}

		public bool Equals(Effect other)
		{
			return Tag == other.Tag && Operator == other.Operator && Value == other.Value;
		}

		public override bool Equals(object obj)
		{
			if (obj is null) return false;
			return obj is Effect effect && Equals(effect);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (int) Tag;
				hashCode = (hashCode * 397) ^ (int) Operator;
				hashCode = (hashCode * 397) ^ Value;
				return hashCode;
			}
		}
	}

	public class Enchant
    {
		public Game Game;
	    public readonly Effect[] Effects;

		public Enchant() { }

	    public Enchant(GameTag tag, EffectOperator @operator, int value)
	    {
		    Effects = new[] {new Effect(tag, @operator, value)};
	    }

	    public Enchant(params Effect[] effects)
	    {
			Effects = effects;
	    }


		public bool IsOneTurnEffect { get; set; }

		public virtual void ActivateTo(IEntity entity, Enchantment enchantment)
	    {
		    for (int i = 0; i < Effects.Length; i++)
		    {
			    Effects[i].Apply(entity);
		    }

		    if (IsOneTurnEffect)
			    enchantment.EffectsToBeRemoved = Effects;
	    }
    }

	public class OngoingEffect : Enchant, IAura
	{
		private int _count;
		private int _targetId;
		private int _controllerId;
		private IEntity _target;
		private Controller _controller;

		public OngoingEffect(params Effect[] effects) : base(effects) { }
		private OngoingEffect() { }

		public int Count
		{
			get => _count;
			set
			{
				_count = value;
				ToBeUpdated = true;
			}
		}

		public IEntity Target
		{
			get => _target ?? (_target = Game.IdEntityDic[_targetId]);
			set
			{
				_targetId = value.Id;
				_target = value;
			}
		}

		public Controller Controller
		{
			get => _controller ?? (_controller = Game.ControllerById(_controllerId));
			set
			{
				_controllerId = Controller.Id;
				_controller = Controller;
			}
		}

		public bool ToBeUpdated { get; internal set; }

		public override void ActivateTo(IEntity entity, Enchantment enchantment)
		{
			var instance = new OngoingEffect(Effects)
			{
				Game = entity.Game,
				//Controller = entity.Controller,
				Target = entity
			};
			entity.OngoingEffect = instance;
			entity.Game.Auras.Add(instance);

			base.ActivateTo(entity, enchantment);
		}

		public void Update()
		{
			if (!ToBeUpdated) return;

			base.ActivateTo(Target, null);
		}
	}

	public class Aura : IAura
	{
		private readonly int _ownerId;
		private IPlayable _owner;
		private List<int> _appliedEntities = new List<int>();
		private List<IPlayable> _tempList;
		private bool _toBeUpdated;
		private bool _on;
		private readonly Effect[] Effects;
		public readonly Game Game;
		public readonly AuraType Type;
		public SelfCondition Condition;
		public Card EnchantmentCard;

		public Aura(AuraType type, params Effect[] effects)
		{
			Type = type;
			Effects = effects;
		}

		private Aura(Aura prototype, IPlayable owner)
		{
			Type = prototype.Type;
			Effects = prototype.Effects;
			Game = owner.Game;
			_on = true;
			_appliedEntities = new List<int>();
			_owner = owner;
			_ownerId = owner.Id;
			_toBeUpdated = true;

			Game.Auras.Add(this);
		}

		public IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_ownerId]);

		public void Activate(IPlayable owner)
		{
			var instance = new Aura(this, owner);
			if (owner.Game.History)
			{
				switch (Type)
				{
					case AuraType.BOARD_EXCEPT_SOURCE:
						_tempList = new List<IPlayable>();
						foreach (var minion in (BoardZone)owner.Zone)
						{
							if (minion == owner) continue;
							if (Condition != null && Condition.Eval(minion))
							{
								Enchantment.GetInstance(owner.Controller, owner, minion, EnchantmentCard);
							}

							_tempList.Add(minion);
						}
						break;
				}
			}
			
		}

		public void Update()
		{
			if (!_toBeUpdated) return;

			if (_on)
			{
				switch (Type)
				{
					case AuraType.BOARD_EXCEPT_SOURCE:
						if (_tempList != null)
						{
							for (int i = 0; i < _tempList.Count; i++)
							{
								var minion = _tempList[i];

								if (minion.AuraEffects == null)
									minion.AuraEffects = new AuraEffects();

								foreach (Effect effect in Effects)
								{
									effect.Apply(minion.AuraEffects);
								}

								minion.AuraEffects.Update(minion);

								_appliedEntities.Add(minion.Id);
							}
						}
						foreach (Minion minion in Owner.Controller.BoardZone)
						{
							if (Condition != null && !Condition.Eval(minion))
								continue;

							if (!_appliedEntities.Contains(minion.Id) && minion.Id != _ownerId)
							{

								if (minion.AuraEffects == null)
									minion.AuraEffects = new AuraEffects();

								foreach (Effect effect in Effects)
								{
									effect.Apply(minion.AuraEffects);
								}

								minion.AuraEffects.Update(minion);

								_appliedEntities.Add(minion.Id);
							}
						}
						return;
				}
			}
			else
			{
				foreach (var i in _appliedEntities)
				{
					var minion = Game.IdEntityDic[i];

					foreach (var effect in Effects)
					{
						effect.Remove(minion.AuraEffects);
					}

					minion.AuraEffects.Update(minion);
				}
			}
		}
	}

	public class AuraEffects
	{
		private int ATK;
		private int HEALTH;
		private int COST;
		private int SPELLPOWER;
		private int CHARGE;

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
					default:
						return;
				}
			}
		}

		public void Update(IPlayable p)
		{
			p[GameTag.ATK] = p.NativeTags[GameTag.ATK] + ATK;
			p[GameTag.HEALTH] = p.NativeTags[GameTag.HEALTH] + HEALTH;
			p[GameTag.COST] = p.NativeTags[GameTag.COST] + COST;
			p[GameTag.SPELLPOWER] = p.NativeTags[GameTag.SPELLPOWER] + SPELLPOWER;
			if (p.NativeTags[GameTag.CHARGE] == 0)
				p[GameTag.CHARGE] = CHARGE;
		}
	}

	public class ComplexEffects : ICollection<Effect>
	{
		private readonly GameTag _tag;

		private readonly List<Effect> _effects = new List<Effect>();

		public ComplexEffects(GameTag tag)
		{
			_tag = tag;
		}

		public void Add(Effect effect)
		{
			_effects.Add(effect);
		}

		public void Clear()
		{
			_effects.Clear();
		}

		public bool Contains(Effect item)
		{
			return _effects.Contains(item);
		}

		public void CopyTo(Effect[] array, int arrayIndex)
		{
			_effects.CopyTo(array, arrayIndex);
		}

		public bool Remove(Effect item)
		{
			return _effects.Remove(item);
		}

		public int Count => _effects.Count;
		public bool IsReadOnly => false;

		public IEnumerator<Effect> GetEnumerator()
		{
			return _effects.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
