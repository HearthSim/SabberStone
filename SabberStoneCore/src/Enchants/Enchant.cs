using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Enchants
{
	public enum AuraType
	{
		SELF, ADJACENT, BOARD, BOARD_EXCEPT_SOURCE, HAND, OP_HAND, HANDS, CONTROLLER, SPELLPOWER
	}

	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}

	public interface IAura
	{
		void Update();
		void Remove();
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
			if (!entity.NativeTags.ContainsKey(Tag))
				entity.NativeTags.Add(Tag, entity.Card[Tag]);

			switch (Operator)
			{
				case EffectOperator.ADD:
					entity.NativeTags[Tag] += Value;
					break;
				case EffectOperator.SUB:
					entity.NativeTags[Tag] -= Value;
					break;
				case EffectOperator.MUL:
					entity.NativeTags[Tag] *= Value;
					break;
				case EffectOperator.SET:
					entity.NativeTags[Tag] = Value;
					break;
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
	    public bool UseScriptTag;
		
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
			if (!UseScriptTag)
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Apply(entity);
			else
				for (int i = 0; i < Effects.Length; i++)
					new Effect(Effects[i].Tag, Effects[i].Operator, enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity);

			if (IsOneTurnEffect)
			    enchantment.EffectsToBeRemoved = Effects;
		}
    }

	public class OngoingEnchant : Enchant, IAura
	{
		private int _count;
		private int _lastCount;
		private int _targetId;
		private int _controllerId;
		private IEntity _target;
		private Controller _controller;

		public OngoingEnchant(params Effect[] effects) : base(effects) { }
		private OngoingEnchant() { }

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
			var instance = new OngoingEnchant(Effects)
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

		public void Remove()
		{
			Target.OngoingEffect = null;
			Target.Game.Auras.Remove(this);
		}
	}

	public class Aura : IAura
	{
		private readonly int _ownerId;
		private IPlayable _owner;
		private readonly List<int> _appliedEntityIds = new List<int>();
		private List<IPlayable> _appliedEntities;
		private List<IPlayable> _tempList;
		private bool _on;
		private Effect[] Effects;
		public readonly Game Game;
		public readonly AuraType Type;
		public SelfCondition Condition;
		public readonly Card EnchantmentCard;
		public bool Restless;
		private bool _toBeUpdated = true;

		public Aura(AuraType type, params Effect[] effects)
		{
			Type = type;
			Effects = effects;
		}

		public Aura(AuraType type, string enchantmentId)
		{
			Type = type;
			EnchantmentCard = Cards.FromId(enchantmentId);
		}

		private Aura(Aura prototype, IPlayable owner)
		{
			Type = prototype.Type;
			Effects = prototype.Effects;
			Condition = prototype.Condition;
			Game = owner.Game;
			Restless = prototype.Restless;
			_on = true;
			_appliedEntityIds = new List<int>();
			_owner = owner;
			_ownerId = owner.Id;

			Game.Auras.Add(this);
			owner.OngoingEffect = this;

			switch (Type)
			{
				case AuraType.BOARD:
				case AuraType.BOARD_EXCEPT_SOURCE:
				case AuraType.ADJACENT:
					Owner.Controller.BoardZone.Auras.Add(this);
					break;
				case AuraType.HAND:
					Owner.Controller.HandZone.Auras.Add(this);
					break;
				case AuraType.OP_HAND:
					Owner.Controller.Opponent.HandZone.Auras.Add(this);
					break;
			}
		}

		public bool ToBeUpdated
		{
			set => _toBeUpdated = value;
		}

		public IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_ownerId]);

		public List<IPlayable> AppliedEntities
		{
			get
			{
				if (_appliedEntities != null)
					return _appliedEntities;
				_appliedEntities = new List<IPlayable>(_appliedEntityIds.Count);
				for (int i = 0; i < _appliedEntityIds.Count; i++)
					_appliedEntities.Add(Game.IdEntityDic[_appliedEntityIds[i]]);
				return _appliedEntities;
			}
		}

		public void Activate(IPlayable owner)
		{
			Effects = EnchantmentCard.Powers[0].Enchant.Effects;
			var instance = new Aura(this, owner);
			if (owner.Game.History)
			{
				switch (Type)
				{
					case AuraType.BOARD_EXCEPT_SOURCE:
						_tempList = new List<IPlayable>();
						foreach (Minion minion in (BoardZone)owner.Zone)
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
				if (_tempList != null)
				{
					for (int i = 0; i < _tempList.Count; i++)
					{
						var minion = _tempList[i];

						Apply(minion);
					}
				}
				switch (Type)
				{
					case AuraType.BOARD:
						foreach (Minion minion in Owner.Controller.BoardZone)
							Apply(minion);
						break;

					case AuraType.BOARD_EXCEPT_SOURCE:
						foreach (Minion minion in Owner.Controller.BoardZone)
							if (minion != Owner)
								Apply(minion);
						return;

					case AuraType.ADJACENT:
						int pos = Owner.ZonePosition;
						for (int i = 0; i < AppliedEntities.Count; i++)
						{
							if (Math.Abs(pos - AppliedEntities[i].ZonePosition) == 1) continue;

							for (int j = 0; j < Effects.Length; j++)
								Effects[i].Remove(AppliedEntities[i].AuraEffects);
						}
						if (pos > 0)
							Apply(Owner.Controller.BoardZone[pos - 1]);
						if (pos < Owner.Controller.BoardZone.Count - 1)
							Apply(Owner.Controller.BoardZone[pos + 1]);
						break;

					case AuraType.SPELLPOWER:
						Apply(Owner.Controller.Hero);
						break;	
				}
			}
			else
			{
				foreach (IPlayable entity in AppliedEntities)
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Remove(entity.AuraEffects);

				Game.Auras.Remove(this);
			}

			if (!Restless)
				_toBeUpdated = false;
		}

		public void Remove()
		{
			_on = false;
			_toBeUpdated = true;
			Owner.OngoingEffect = null;
		}

		public void EntityRemoved(Minion m)
		{
			if (AppliedEntities.Remove(m))
			{
				_appliedEntityIds.Remove(m.Id);
			}
			else if (m == Owner)
			{
				Remove();
			}
		}

		private void Apply(IPlayable entity)
		{
			if (_appliedEntityIds.Contains(entity.Id))
			{
				if (!Restless || Condition.Eval(entity)) return;

				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Remove(entity.AuraEffects);

				_appliedEntityIds.Remove(entity.Id);
				AppliedEntities.Remove(entity);

				return;
			}

			if (Condition != null)
				if (!Condition.Eval(entity))
					return;

			for (int i = 0; i < Effects.Length; i++)
				Effects[i].Apply(entity.AuraEffects);

			// history

			AppliedEntities.Add(entity);
			_appliedEntityIds.Add(entity.Id);
		}
	}

	public class SpellPowerAura : Aura
	{
		public SpellPowerAura(int spellPwrAmount) : base(AuraType.SPELLPOWER, new Effect(GameTag.SPELLPOWER, EffectOperator.ADD, spellPwrAmount))
		{

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
					case GameTag.CHARGE:
						return CHARGE;
					case GameTag.CURRENT_SPELLPOWER:
						return SPELLPOWER;
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
					case GameTag.CURRENT_SPELLPOWER:
						SPELLPOWER = value;
						return;
					default:
						return;
				}
			}
		}

		public void Update(IPlayable p)
		{
			//p[GameTag.ATK] = p.NativeTags[GameTag.ATK] + ATK;
			//p[GameTag.HEALTH] = p.NativeTags[GameTag.HEALTH] + HEALTH;
			//p[GameTag.COST] = p.NativeTags[GameTag.COST] + COST;
			//p[GameTag.SPELLPOWER] = p.NativeTags[GameTag.SPELLPOWER] + SPELLPOWER;
			//if (p.NativeTags[GameTag.CHARGE] == 0)
			//	p[GameTag.CHARGE] = CHARGE;
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
