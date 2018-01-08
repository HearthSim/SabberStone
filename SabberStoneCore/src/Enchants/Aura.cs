using System;
using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Enchants
{
	public enum AuraType
	{
		SELF, ADJACENT, BOARD, BOARD_EXCEPT_SOURCE, HAND, OP_HAND, HANDS, CONTROLLER, ADAPTIVE, TARGET, ENRAGE
	}

	public interface IAura
	{
		string EnchantmentCardId { get; }
		void Update();
		void Remove();
	}

	public class Aura : IAura
	{
		private readonly int _ownerId;
		private IPlayable _owner;
		private readonly List<int> _appliedEntityIds = new List<int>();
		private List<IPlayable> _appliedEntities;
		private List<IPlayable> _tempList;
		protected bool _on;
		private bool _toBeUpdated = true;
		private readonly Func<IPlayable, int> _adaptivePredicate;
		private readonly GameTag _adaptiveTag;
		//private Trigger _removeTrigger;
		protected Effect[] Effects;

		public readonly Game Game;
		public readonly AuraType Type;
		public SelfCondition Condition;
		public Func<IPlayable, int> Predicate;
		public (TriggerType Type, SelfCondition Condition) RemoveTrigger;
		public readonly Card EnchantmentCard;
		public bool Restless;


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

		public Aura(Func<IPlayable, int> adaptivePredicate, GameTag adaptiveTag)
		{
			Type = AuraType.ADAPTIVE;
			_adaptivePredicate = adaptivePredicate;
			_adaptiveTag = adaptiveTag;
		}

		protected Aura(Aura prototype, IPlayable owner)
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
		public string EnchantmentCardId => EnchantmentCard?.Id ?? "";


		public virtual void Activate(IPlayable owner)
		{
			if (Effects == null)
				Effects = EnchantmentCard.Powers[0].Enchant.Effects;

			var instance = new Aura(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;

			switch (Type)
			{
				case AuraType.BOARD:
				case AuraType.BOARD_EXCEPT_SOURCE:
				case AuraType.ADJACENT:
					owner.Controller.BoardZone.Auras.Add(instance);
					break;
				case AuraType.HAND:
					owner.Controller.HandZone.Auras.Add(instance);
					break;
				case AuraType.OP_HAND:
					owner.Controller.Opponent.HandZone.Auras.Add(instance);
					break;
			}

			if (RemoveTrigger.Type != TriggerType.NONE)
			{
				switch (RemoveTrigger.Type)
				{
					case TriggerType.CAST_SPELL:
						Game.TriggerManager.CastSpellTrigger += instance.TriggeredRemove;
						break;
				}
			}

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

		public virtual void Update()
		{
			if (!_toBeUpdated || Type == AuraType.ADAPTIVE) return;

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

					case AuraType.HAND:
						foreach (IPlayable p in Owner.Controller.HandZone)
							Apply(p);
						break;

					case AuraType.OP_HAND:
						foreach (IPlayable p in Owner.Controller.Opponent.HandZone)
							Apply(p);
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

		public virtual void Remove()
		{
			_on = false;
			_toBeUpdated = true;
			Owner.OngoingEffect = null;
		}

		private void TriggeredRemove(IEntity source)
		{
			if (RemoveTrigger.Condition != null && !RemoveTrigger.Condition.Eval((IPlayable)source))
				return;

			Remove();

			switch (RemoveTrigger.Type)
			{
				case TriggerType.CAST_SPELL:
					Game.TriggerManager.CastSpellTrigger -= TriggeredRemove;
					return;
			}

			if (Owner is Enchantment e)
				e.Remove();
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

		protected void Apply(IPlayable entity)
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

			if (Predicate != null)
			{
				var effect = new Effect(Effects[0].Tag, Effects[0].Operator, Predicate(entity));
				effect.Apply(entity.AuraEffects);
			}
			else
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Apply(entity.AuraEffects);

			// history

			AppliedEntities.Add(entity);
			_appliedEntityIds.Add(entity.Id);
		}
	}

	public class AdaptiveEffect : Aura
	{
		private readonly Func<IPlayable, int> _predicate;
		private readonly GameTag _tag;
		private readonly EffectOperator _operator;
		private int _lastValue;

		public AdaptiveEffect(GameTag tag, EffectOperator @operator, Func<IPlayable, int> predicate) : base(AuraType.SELF)
		{
			_predicate = predicate;
			_tag = tag;
			_operator = @operator;
		}

		private AdaptiveEffect(AdaptiveEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			_predicate = prototype._predicate;
			_tag = prototype._tag;
			_operator = prototype._operator;
		}

		public override void Activate(IPlayable owner)
		{
			var instance = new AdaptiveEffect(this, owner);
		}

		public override void Update()
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
				{
					Owner.AuraEffects[_tag] -= _lastValue;
					int val = _predicate(Owner);
					Owner.AuraEffects[_tag] += val;
					_lastValue = val;
					return;
				}
				case EffectOperator.SUB:
				{
					Owner.AuraEffects[_tag] += _lastValue;
					int val = _predicate(Owner);
					Owner.AuraEffects[_tag] -= val;
					_lastValue = val;
					return;
				}
				case EffectOperator.SET:
					_lastValue += Owner.AuraEffects[_tag];
					Owner.AuraEffects[_tag] = 0;
					Owner[_tag] = _predicate(Owner);
					return;
			}
		}

		public override void Remove()
		{
			Owner.OngoingEffect = null;

			switch (_operator)
			{
				case EffectOperator.ADD:
					Owner.AuraEffects[_tag] -= _lastValue;
					return;
				case EffectOperator.SUB:
					Owner.AuraEffects[_tag] += _lastValue;
					return;
				case EffectOperator.SET:
					Owner.AuraEffects[_tag] = _lastValue;
					return;
			}
		}
	}

	public class EnrageEffect : Aura
	{
		private bool _enraged;

		public EnrageEffect(AuraType type, params Effect[] effects) : base(type, effects)
		{
		}

		public EnrageEffect(AuraType type, string enchantmentId) : base(type, enchantmentId)
		{
		}

		protected EnrageEffect(Aura prototype, IPlayable owner) : base(prototype, owner)
		{
		}

		public override void Activate(IPlayable owner)
		{
			if (owner is Enchantment e)
				owner = (IPlayable)e.Target;

			base.Activate(owner);

			Restless = true;
		}

		public override void Update()
		{
			var m = Owner as Minion;
			if (!_enraged)
			{
				if (m.Damage == 0) return;
				Apply(m);
				_enraged = true;
			}
			else
			{
				if (m.Damage != 0) return;
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Remove(m.AuraEffects);
				_enraged = false;
			}

			if (!_on)
			{
				Game.Auras.Remove(this);
				if (!_enraged) return;
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Remove(m.AuraEffects);
			}
		}
	}
}
