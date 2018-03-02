using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// Aura types. Indicates the range of auras. 
	/// </summary>
	public enum AuraType
	{
		/// <summary> This type of aura only affects the source of the aura. </summary>
		SELF,
		/// <summary> This type of aura affects the minions adjacent to the source of the aura. </summary>
		ADJACENT,
		/// <summary> This type of aura affects all friendly minions. </summary>
		BOARD,
		/// <summary> This type of aura affects all friendly minions except the source of the aura. </summary>
		BOARD_EXCEPT_SOURCE,
		/// <summary> This type of aura affects all entities in the hand of the source's controller. </summary>
		HAND,
		/// <summary> This type of aura affects all entities in the hand of the opponent of the source's controller. </summary>
		OP_HAND,
		/// <summary> This type of aura affects all entities in the both player's hand. </summary>
		HANDS,
		/// <summary> This type of aura only affects the controller of the source of the aura. </summary>
		CONTROLLER,
		/// <summary> This type of aura affects the both controllers. </summary>
		CONTROLLERS,
		/// <summary> This type of aura affects the weapon of the source's controller. </summary>
		WEAPON,

		ADAPTIVE,

		HERO,

		HEROPOWER
	}

	/// <summary>
	/// Interface for effects of enchantments that should be updated during <see cref="Game.AuraUpdate"/>.
	/// </summary>
	public interface IAura
	{
		/// <summary> Update this effect to apply the effect to recently modified entities. </summary>
		void Update();
		/// <summary> Remove this effect from the game to stop affecting entities. </summary>
		void Remove();

		void Clone(IPlayable clone);
	}

	/// <summary>
	/// Auras can affect entities and changes the applied entities' ATK, COST, etc. 
	/// Aura must be activated first to affect entities. 
	/// The effect of an aura is applied or removed during <see cref="Game.AuraUpdate"/>.
	/// </summary>
	public class Aura : IAura
	{
		private readonly int _ownerId;
		private IPlayable _owner;
		//private readonly List<int> _appliedEntityIds;
		private readonly HashSet<int> _appliedEntityIds;
		private List<IPlayable> _appliedEntities;
		private List<IPlayable> _tempList;
		protected bool On = true;
		protected bool _toBeUpdated = true;
		//private Trigger _removeTrigger;
		protected Effect[] Effects;

		public readonly Game Game;
		public readonly AuraType Type;
		public SelfCondition Condition;
		public Func<IPlayable, int> ValueFunc;
		public (TriggerType Type, SelfCondition Condition) RemoveTrigger;
		public readonly Card EnchantmentCard;

		/// <summary> True if this aura should check the condition of the applied entities every time. </summary>
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

		protected Aura(Aura prototype, IPlayable owner)
		{
			Type = prototype.Type;
			Effects = prototype.Effects;
			Condition = prototype.Condition;
			ValueFunc = prototype.ValueFunc;
			RemoveTrigger = prototype.RemoveTrigger;
			EnchantmentCard = prototype.EnchantmentCard;
			Restless = prototype.Restless;
			On = prototype.On;
			//_appliedEntityIds = prototype._appliedEntityIds != null ? new List<int>(prototype._appliedEntityIds) : new List<int>();
			_appliedEntityIds = prototype._appliedEntityIds != null
				? new HashSet<int>(prototype._appliedEntityIds)
				: new HashSet<int>();

			Game = owner.Game;
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
				//for (int i = 0; i < _appliedEntityIds.Count; i++)
				//	_appliedEntities.Add(Game.IdEntityDic[_appliedEntityIds[i]]);
				foreach (int id in _appliedEntityIds)
					_appliedEntities.Add(Game.IdEntityDic[id]);
				return _appliedEntities;
			}
		}

		/// <summary>
		/// Create new Aura instance to the owner's Game.
		/// </summary>
		public virtual void Activate(IPlayable owner, bool cloning = false)
		{
			if (Effects == null)
				Effects = EnchantmentCard.Power.Enchant.Effects;

			var instance = new Aura(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;

			if (!cloning)
				instance.AddToZone();

			if (RemoveTrigger.Type != TriggerType.NONE)
			{
				switch (RemoveTrigger.Type)
				{
					case TriggerType.PLAY_MINION:
						owner.Game.TriggerManager.PlayMinionTrigger += instance.TriggeredRemove;
						break;
					case TriggerType.CAST_SPELL:
						owner.Game.TriggerManager.CastSpellTrigger += instance.TriggeredRemove;
						break;
					case TriggerType.TURN_END:
						owner.Game.TriggerManager.EndTurnTrigger += instance.TriggeredRemove;
						break;
					case TriggerType.PLAY_CARD:
						owner.Game.TriggerManager.PlayCardTrigger += instance.TriggeredRemove;
						break;
					case TriggerType.AFTER_PLAY_CARD:
						owner.Game.TriggerManager.AfterPlayCardTrigger += instance.TriggeredRemove;
						break;
				}
			}

			if (cloning || !owner.Game.History) return;

			if (EnchantmentCard == null) return;

			switch (Type)
			{
				case AuraType.BOARD_EXCEPT_SOURCE:
					_tempList = new List<IPlayable>();
					foreach (Minion minion in (BoardZone)owner.Zone)
					{
						if (minion == owner) continue;
						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(owner.Controller, owner, minion, EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						_tempList.Add(minion);
					}
					break;
				case AuraType.BOARD:
					_tempList = new List<IPlayable>();
					foreach (Minion minion in (BoardZone)owner.Zone)
					{
						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(owner.Controller, owner, minion, EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						_tempList.Add(minion);
					}
					break;

			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AddToZone()
		{
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
				case AuraType.HANDS:
					Owner.Controller.HandZone.Auras.Add(this);
					Owner.Controller.Opponent.HandZone.Auras.Add(this);
					break;
			}
		}

		/// <summary>
		/// Apply this aura to the target entities or remove this aura if the owner is nullified.
		/// </summary>
		public virtual void Update()
		{
			if (!_toBeUpdated) return;

			UpdateInternal();
		}

		private void UpdateInternal()
		{
			if (On)
			{
				if (_tempList != null)
				{
					for (int i = 0; i < _tempList.Count; i++)
					{
						IPlayable minion = _tempList[i];

						Apply(minion);
					}

					_tempList = null;
				}

				switch (Type)
				{
					case AuraType.BOARD:
						Owner.Controller.BoardZone.ForEach(Apply);
						break;
					case AuraType.BOARD_EXCEPT_SOURCE:
						Owner.Controller.BoardZone.ForEach(minion =>
						{
							if (minion != Owner)
								Apply(minion);
						});
						return;
					case AuraType.ADJACENT:
						int pos = Owner.ZonePosition;
						for (int i = AppliedEntities.Count - 1; i >= 0; i--)
						{
							IPlayable entity = AppliedEntities[i];

							if (entity.Zone == Owner.Zone && Math.Abs(pos - entity.ZonePosition) == 1) continue;

							for (int j = 0; j < Effects.Length; j++)
								Effects[j].Remove(entity.AuraEffects);

							_appliedEntityIds.Remove(entity.Id);
							_appliedEntities.Remove(entity);
						}
						if (pos > 0)
							Apply(Owner.Controller.BoardZone[pos - 1]);
						if (pos < Owner.Controller.BoardZone.Count - 1 && Owner.Controller.BoardZone.Count > pos)
							Apply(Owner.Controller.BoardZone[pos + 1]);
						break;
					case AuraType.HAND:
						Owner.Controller.HandZone.ForEach(Apply);
						break;
					case AuraType.OP_HAND:
						Owner.Controller.Opponent.HandZone.ForEach(Apply);
						break;
					case AuraType.HANDS:
						Owner.Controller.HandZone.ForEach(Apply);
						Owner.Controller.Opponent.HandZone.ForEach(Apply);
						break;
					case AuraType.WEAPON:
						if (Owner.Controller.Hero.Weapon == null) break;
						Apply(Owner.Controller.Hero.Weapon);
						break;
					case AuraType.CONTROLLER:
						for (int i = 0; i < Effects.Length; i++)
							Effects[i].Apply(Owner.Controller.ControllerAuraEffects);
						break;
					case AuraType.CONTROLLERS:
						for (int i = 0; i < Effects.Length; i++)
						{
							Effects[i].Apply(Owner.Controller.ControllerAuraEffects);
							Effects[i].Apply(Owner.Controller.Opponent.ControllerAuraEffects);
						}
						break;
					case AuraType.HERO:
						Apply(Owner.Controller.Hero);
						break;
					case AuraType.HEROPOWER:
						Apply(Owner.Controller.Hero.HeroPower);
						break;
					case AuraType.SELF:
						Apply(Owner);
						break;
				}

				if (!Restless)
					_toBeUpdated = false;
			}
			else
				RemoveInternal();
		}

		private void RemoveInternal()
		{
			// Remove effects from applied entities
			switch (Type)
			{
				case AuraType.ADJACENT:
				case AuraType.BOARD:
				case AuraType.BOARD_EXCEPT_SOURCE:
					Owner.Controller.BoardZone.Auras.Remove(this);
					break;
				case AuraType.HAND:
					Owner.Controller.HandZone.Auras.Remove(this);
					break;
				case AuraType.OP_HAND:
					Owner.Controller.Opponent.HandZone.Auras.Remove(this);
					break;
				case AuraType.HANDS:
					Owner.Controller.HandZone.Auras.Remove(this);
					Owner.Controller.Opponent.HandZone.Auras.Remove(this);
					break;
				case AuraType.CONTROLLER:
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Remove(Owner.Controller.ControllerAuraEffects);
					break;
				case AuraType.CONTROLLERS:
					for (int i = 0; i < Effects.Length; i++)
					{
						Effects[i].Remove(Owner.Controller.ControllerAuraEffects);
						Effects[i].Remove(Owner.Controller.Opponent.ControllerAuraEffects);
					}
					break;
			}

			if (Type != AuraType.CONTROLLER || Type != AuraType.CONTROLLERS)
			{
				foreach (IPlayable entity in AppliedEntities)
				{
					if (ValueFunc != null)
					{
						var effect = new Effect(Effects[0].Tag, Effects[0].Operator, ValueFunc(entity));
						effect.Remove(entity.AuraEffects);
						continue;
					}

					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Remove(entity.AuraEffects);
				}
			}

			Game.Auras.Remove(this);

			// Remove enchantments from applied entities
			if (EnchantmentCard != null && (Game.History || EnchantmentCard.Power.Trigger != null))
				foreach (IPlayable entity in AppliedEntities)
					for (int i = entity.AppliedEnchantments.Count - 1; i >= 0; i--)
						if (entity.AppliedEnchantments[i].Creator.Id == _ownerId)
							entity.AppliedEnchantments[i].Remove();
		}
	
		public virtual void Remove()
		{
			On = false;
			_toBeUpdated = true;
			Owner.OngoingEffect = null;

			switch (RemoveTrigger.Type)
			{
				case TriggerType.CAST_SPELL:
					Game.TriggerManager.CastSpellTrigger -= TriggeredRemove;
					return;
				case TriggerType.TURN_END:
					Game.TriggerManager.EndTurnTrigger -= TriggeredRemove;
					break;
				case TriggerType.PLAY_MINION:
					Game.TriggerManager.PlayMinionTrigger -= TriggeredRemove;
					break;
				case TriggerType.PLAY_CARD:
					Game.TriggerManager.PlayCardTrigger -= TriggeredRemove;
					break;
				case TriggerType.AFTER_PLAY_CARD:
					Game.TriggerManager.AfterPlayCardTrigger -= TriggeredRemove;
					break;
			}

			if (Owner is Enchantment e)
				e.Remove();
		}

		private void TriggeredRemove(IEntity source)
		{
			if (RemoveTrigger.Condition != null)
			{
				if (source is Controller)
					source = Owner;
				if (!RemoveTrigger.Condition.Eval((IPlayable)source))
					return;
			}

			Remove();
		}

		public void EntityRemoved(IPlayable m)
		{
			if (AppliedEntities.Remove(m))
			{
				_appliedEntityIds.Remove(m.Id);
				//for (int i = 0; i < Effects.Length; i++)
				//	Effects[i].Remove(m.AuraEffects);
			}
			else if (m == Owner)
			{
				Remove();
			}
		}

		/// <summary>
		/// Apply this aura's effect(s) to the target entity.
		/// </summary>
		private void Apply(IPlayable entity)
		{
			if (entity == null)
				throw new ArgumentNullException();

			if (_appliedEntityIds.Contains(entity.Id))
			{
				if (!Restless || Condition.Eval(entity)) return;

				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Remove(entity.AuraEffects);

				_appliedEntityIds.Remove(entity.Id);
				AppliedEntities.Remove(entity);
			}

			if (Condition != null)
				if (!Condition.Eval(entity))
					return;

			if (ValueFunc != null)
			{
				var effect = new Effect(Effects[0].Tag, Effects[0].Operator, ValueFunc(entity));
				effect.Apply(entity.AuraEffects);
			}
			else
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Apply(entity.AuraEffects);

			if (EnchantmentCard != null && ((Game.History && _tempList == null) || EnchantmentCard.Power.Trigger != null))
			{
				Enchantment instance = Enchantment.GetInstance(entity.Controller, Owner, entity, EnchantmentCard);
				EnchantmentCard.Power.Trigger?.Activate(instance);
			}

			AppliedEntities.Add(entity);
			_appliedEntityIds.Add(entity.Id);
		}

		public virtual void Clone(IPlayable clone)
		{
			Activate(clone, true);
			((Aura)clone.OngoingEffect).ToBeUpdated = _toBeUpdated;
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[A:");
			sb.Append("[O:");
			sb.Append(_ownerId);
			sb.Append("]");
			sb.Append("[T:");
			sb.Append(Type);
			sb.Append("]");
			sb.Append("[AEs:");
			foreach (int i in _appliedEntityIds)
				sb.Append($"{{{i}}}");
			sb.Append("]");
			sb.Append(On ? "[ON]" : "[OFF]");
			sb.Append(_toBeUpdated ? "[U]" : "[NU]");
			return sb.ToString();
		}
	}

	/// <summary>
	/// Effects of this kind of Auras are influenced by other factors in game, in real time. e.g. Lightspawn, Southsea Deckhand.
	/// </summary>
	public class AdaptiveEffect : Aura
	{
		private readonly GameTag _tag;
		private readonly EffectOperator _operator;
		private int _lastValue;

		public AdaptiveEffect(GameTag tag, EffectOperator @operator, Func<IPlayable, int> valueFunc) : base(AuraType.ADAPTIVE)
		{
			ValueFunc = valueFunc;
			_tag = tag;
			_operator = @operator;
		}

		private AdaptiveEffect(AdaptiveEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			_tag = prototype._tag;
			_operator = prototype._operator;
			_lastValue = prototype._lastValue;
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			var instance = new AdaptiveEffect(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public override void Update()
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
				{
					Owner.AuraEffects[_tag] -= _lastValue;
					int val = ValueFunc(Owner);
					Owner.AuraEffects[_tag] += val;
					_lastValue = val;
					return;
				}
				case EffectOperator.SUB:
				{
					Owner.AuraEffects[_tag] += _lastValue;
					int val = ValueFunc(Owner);
					Owner.AuraEffects[_tag] -= val;
					_lastValue = val;
					return;
				}
				case EffectOperator.SET:
					_lastValue += Owner.AuraEffects[_tag];
					Owner.AuraEffects[_tag] = 0;
					Owner[_tag] = ValueFunc(Owner);
					return;
			}
		}

		public override void Remove()
		{
			Owner.OngoingEffect = null;
			Game.Auras.Remove(this);

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

	/// <summary>
	/// Implementation of the specific effects of varying cost. e.g. Giants
	/// </summary>
	public class AdaptiveCostEffect : Aura
	{
		private readonly EffectOperator _operator;
		private readonly Predicate<IPlayable> _predicate;
		private readonly int _value;

		//public (TriggerType Type, TriggerSource Source, SelfCondition Condition) UpdateTrigger;

		public AdaptiveCostEffect(EffectOperator @operator, Func<IPlayable, int> costFunc) : base(AuraType.ADAPTIVE)
		{
			ValueFunc = costFunc;
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
					return value + ValueFunc(Owner);
				case EffectOperator.SUB:
					return value - ValueFunc(Owner);
				case EffectOperator.SET:
					return ValueFunc(Owner);
				case EffectOperator.MUL:
					return value * ValueFunc(Owner);
			}

			return 0;
		}

		public override void Remove()
		{
			Owner.AuraEffects.AdaptiveCostEffect = null;
			Owner.OngoingEffect = null;
			//if (UpdateTrigger.Type != 0)
			//	Owner.Game.TriggerManager.RemoveTrigger(UpdateTrigger.Type, TriggeredUpdate);
		}

		public override void Update()
		{
			//if (!_toBeUpdated) return;
			Owner.AuraEffects.Checker = true;
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

	/// <summary>
	/// Implementation of the Enrage effect.
	/// </summary>
	public class EnrageEffect : Aura
	{
		private bool _enraged;
		private IPlayable _target;

		public EnrageEffect(AuraType type, params Effect[] effects) : base(type, effects)
		{
		}

		//public EnrageEffect(AuraType type, string enchantmentId) : base(type, enchantmentId)
		//{
		//}

		private EnrageEffect(EnrageEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			_enraged = prototype._enraged;
			Restless = true;            //	can cause performance issue; should replace with heal trigger ?
			switch (Type)
			{
				case AuraType.SELF:
					_target = owner;
					break;
				case AuraType.WEAPON:
					_target = owner.Controller.Hero.Weapon;
					break;
			}
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			if (owner is Enchantment e)
				owner = (IPlayable)e.Target;

			var instance = new EnrageEffect(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public override void Update()
		{
			var m = Owner as Minion;

			if (Type == AuraType.WEAPON)
				_target = m.Controller.Hero.Weapon;

			if (!On)
			{
				Game.Auras.Remove(this);
				if (!_enraged) return;
				if (_target != null)
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Remove(_target.AuraEffects);
			}

			if (!_enraged)
			{
				if (m.Damage == 0) return;
				if (_target != null)
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Apply(_target.AuraEffects);
				_enraged = true;
			}
			else
			{
				if (m.Damage != 0) return;
				if (_target != null)
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].Remove(_target.AuraEffects);
				_enraged = false;
			}
		}

		public override void Clone(IPlayable clone)
		{
			Activate(clone, true);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[EE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
