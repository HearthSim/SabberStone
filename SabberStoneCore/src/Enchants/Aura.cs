using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// Auras can affect entities and change the applied entities' ATK, COST, etc. 
	/// Aura must be activated first to affect entities. 
	/// The effect of an aura is applied or removed during <see cref="Game.AuraUpdate"/>.
	/// </summary>
	public class Aura : IAura
	{
		private enum Instruction
		{
			Invalid, RemoveAll, AddAll, Add, Remove, /*CheckAdjacency*/
		}
		private readonly struct AuraUpdateInstruction : IEquatable<AuraUpdateInstruction>
		{
			public readonly IPlayable Src;
			public readonly Instruction Instruction;

			public AuraUpdateInstruction(IPlayable src, Instruction instruction)
			{
				Src = src;
				Instruction = instruction;
			}

			public AuraUpdateInstruction(Instruction instruction)
			{
				Src = null;
				Instruction = instruction;
			}

			public bool Equals(AuraUpdateInstruction other)
			{
				return Equals(Src, other.Src) && Instruction == other.Instruction;
			}

			public override string ToString()
			{
				if (Src != null)
					return $"{Instruction} - {Src}";
				else
					return Instruction.ToString();
			}

			public override bool Equals(object obj) => obj != null && (obj is AuraUpdateInstruction instruction && Equals(instruction));

			public override int GetHashCode()
			{
				unchecked
				{
					return ((Src != null ? Src.GetHashCode() : 0) * 397) ^ (int) Instruction;
				}
			}
		}

		private readonly Util.PriorityQueue<AuraUpdateInstruction> _auraUpdateInstructionsQueue;
		//private readonly HashSet<int> _appliedEntityIds;
		private readonly Util.SmallFastCollection _appliedEntityIdCollection;
		private readonly TriggerManager.TriggerHandler _removeHandler;
		private readonly int _ownerId;

		private IPlayable _owner;
		//private List<IPlayable> _appliedEntities;
		//private List<IPlayable> _tempList;

		protected bool On = true;
		protected IEffect[] Effects;

		public readonly Game Game;
		public readonly AuraType Type;
		public readonly Card EnchantmentCard;

		/// <summary>
		/// True if this aura should check the condition of the applied entities every time.
		/// </summary>
		public bool Restless;
		/// <summary>
		/// Only entities satisfying this condtion will be affected by this aura.
		/// </summary>
		public SelfCondition Condition;
		/// <summary>
		/// This aura will be removed when the given type of trigger is handled.
		/// Condition checks the trigger sender.
		/// </summary>
		public (TriggerType Type, SelfCondition Condition) RemoveTrigger;
		//public Func<IPlayable, int> ValueFunc;

		//public bool ToBeUpdated { private get; set; }

		public IPlayable Owner => _owner ?? (_owner = Game.IdEntityDic[_ownerId]);

		//public List<IPlayable> AppliedEntities
		//{
		//	get
		//	{
		//		if (_appliedEntities != null)
		//			return _appliedEntities;

		//		_appliedEntities = new List<IPlayable>(_appliedEntityIds.Count);
		//		//_appliedEntities = new LinkedList<IPlayable>();

		//		foreach (int id in _appliedEntityIds)
		//			_appliedEntities.Add(Game.IdEntityDic[id]);

		//		return _appliedEntities;
		//	}
		//}

		public Aura(AuraType type, params IEffect[] effects)
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
			//ValueFunc = prototype.ValueFunc;
			RemoveTrigger = prototype.RemoveTrigger;
			EnchantmentCard = prototype.EnchantmentCard;
			Restless = prototype.Restless;
			On = prototype.On;
			//_appliedEntityIds = prototype._appliedEntityIds != null
			//	? new HashSet<int>(prototype._appliedEntityIds)
			//	: new HashSet<int>();

			_appliedEntityIdCollection = prototype._appliedEntityIdCollection != null
				? new Util.SmallFastCollection(prototype._appliedEntityIdCollection)
				: new Util.SmallFastCollection();

			_auraUpdateInstructionsQueue = new Util.PriorityQueue<AuraUpdateInstruction>();

			Game = owner.Game;
			_owner = owner;
			_ownerId = owner.Id;

			_removeHandler = TriggeredRemove;
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

			//if (!cloning)
				instance.AddToZone();

			if (RemoveTrigger.Type != TriggerType.NONE)
			{
				switch (RemoveTrigger.Type)
				{
					case TriggerType.PLAY_MINION:
						owner.Game.TriggerManager.PlayMinionTrigger += instance._removeHandler;
						break;
					case TriggerType.CAST_SPELL:
						owner.Game.TriggerManager.CastSpellTrigger += instance._removeHandler;
						break;
					case TriggerType.TURN_END:
						owner.Game.TriggerManager.EndTurnTrigger += instance._removeHandler;
						break;
					case TriggerType.PLAY_CARD:
						owner.Game.TriggerManager.PlayCardTrigger += instance._removeHandler;
						break;
					case TriggerType.AFTER_PLAY_CARD:
						owner.Game.TriggerManager.AfterPlayCardTrigger += instance._removeHandler;
						break;
				}
			}

			if (!cloning)
				instance._auraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.AddAll), 1);

			if (cloning || !owner.Game.History) return;


			if (EnchantmentCard == null) return;

			Controller c = owner.Controller;
			switch (Type)
			{
				case AuraType.BOARD_EXCEPT_SOURCE:
					//instance._tempList = new List<IPlayable>();
					foreach (Minion minion in (BoardZone)owner.Zone)
					{
						if (minion == owner) continue;
						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(in c, in owner, minion, in EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						//instance._tempList.Add(minion);
					}
					break;
				case AuraType.BOARD:
					//instance._tempList = new List<IPlayable>();
					foreach (Minion minion in (BoardZone)owner.Zone)
					{
						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(in c, in owner, minion, in EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						//instance._tempList.Add(minion);
					}
					break;
				case AuraType.HAND_AND_BOARD:
					//instance._tempList = new List<IPlayable>();
					foreach (Minion minion in owner.Controller.BoardZone)
					{
						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(in c, in owner, minion, in EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						//instance._tempList.Add(minion);
					}
					foreach (IPlayable p in owner.Controller.HandZone)
					{
						if (!(p is Minion minion)) continue;

						if (Condition == null || Condition.Eval(minion))
						{
							Enchantment e = Enchantment.GetInstance(in c, in owner, minion, in EnchantmentCard);
							EnchantmentCard.Power.Trigger?.Activate(e);
						}

						//instance._tempList.Add(minion);
					}
					break;
				case AuraType.SUMMONING_PORTAL:
					foreach (IPlayable p in owner.Controller.HandZone.Where(p => p.Card.Type == CardType.MINION))
						Enchantment.GetInstance(in c, in owner, p, in EnchantmentCard);
					break;
			}
		}

		/// <summary>
		/// Apply this aura to the target entities or remove this aura if the owner is nullified.
		/// </summary>
		public virtual void Update()
		{
			if (Restless)
			{
				if (!On)
				{
					RemoveInternal();
					return;
				}

				_appliedEntityIdCollection.ForEach(Game.IdEntityDic, this,
					(i, dict, aura) => aura.DeApply(dict[i]));

				UpdateInternal();

				return;
			}

			var queue = _auraUpdateInstructionsQueue;
			bool addAllProcessed = false;
			while (queue.Count != 0)
			{
				AuraUpdateInstruction inst = queue.Dequeue();
				switch (inst.Instruction)
				{
					case Instruction.RemoveAll:
						RemoveInternal();
						break;
					case Instruction.AddAll:
						if (On)
						{
							addAllProcessed = true;
							UpdateInternal();
						}
						break;
					case Instruction.Add:
						if (On && !addAllProcessed)
							Apply(inst.Src);
						break;
					case Instruction.Remove:
						if (On)
							DeApply(inst.Src);
						break;
					//case Instruction.CheckAdjacency:
					//	if (!adjacencyChecked && !addAllProcessed && On)
					//	{
					//		CheckAdjacency();
					//		adjacencyChecked = true;
					//	}
					//	break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		/// <summary>
		/// Removes this aura instance from the game.
		/// </summary>
		public virtual void Remove()
		{
			On = false;
			//ToBeUpdated = true;
			_auraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.RemoveAll), 0);
			Owner.OngoingEffect = null;

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
				case AuraType.HAND_AND_BOARD:
					Owner.Controller.HandZone.Auras.Remove(this);
					Owner.Controller.BoardZone.Auras.Remove(this);
					break;
			}

			switch (RemoveTrigger.Type)
			{
				case TriggerType.CAST_SPELL:
					Game.TriggerManager.CastSpellTrigger -= _removeHandler;
					return;
				case TriggerType.TURN_END:
					Game.TriggerManager.EndTurnTrigger -= _removeHandler;
					break;
				case TriggerType.PLAY_MINION:
					Game.TriggerManager.PlayMinionTrigger -= _removeHandler;
					break;
				case TriggerType.PLAY_CARD:
					Game.TriggerManager.PlayCardTrigger -= _removeHandler;
					break;
				case TriggerType.AFTER_PLAY_CARD:
					Game.TriggerManager.AfterPlayCardTrigger -= _removeHandler;
					break;
			}

			if (Owner is Enchantment e)
				e.Remove();
		}

		void IAura.Activate(IPlayable owner)
		{
			Activate(owner);
		}

		/// <summary>
		/// Notices this aura instance that the given entity is added to the corresponding zone.
		/// </summary>
		public void EntityAdded(IPlayable playable)
		{
			if (!On)
				return;

			//if (Type == AuraType.ADJACENT)
			//{
			//	_auraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.CheckAdjacency), 2);
			//	return;
			//}

			var instruction = new AuraUpdateInstruction(playable, Instruction.Add);

			if (!_auraUpdateInstructionsQueue.Contains(in instruction))
				_auraUpdateInstructionsQueue.Enqueue(instruction, 2);
		}

		/// <summary>
		/// Notices this aura instance that the given entity is removed from the corresponding zone.
		/// </summary>
		public void EntityRemoved(IPlayable playable)
		{
			if (!On)
				return;
			if (playable == Owner)
				return;
			//if (Type == AuraType.ADJACENT)
			//{
			//	_auraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.CheckAdjacency), 2);
			//	return;
			//}

			_auraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(playable, Instruction.Remove), 1);
		}

		private void UpdateInternal()
		{
			//if (_tempList != null)
			//{
			//	for (int i = 0; i < _tempList.Count; i++)
			//		Apply(_tempList[i]);

			//	_tempList = null;
			//}

			switch (Type)
			{
				case AuraType.BOARD:
					Owner.Controller.BoardZone.ForEach(Apply);
					break;
				case AuraType.BOARD_EXCEPT_SOURCE:
				{
					IPlayable owner = Owner;
					owner.Controller.BoardZone.ForEach((minion, source, apply) =>
					{
						if (minion != source)
							apply(minion);
					}, owner, new Action<IPlayable>(Apply));
					return;
				}
				case AuraType.ADJACENT:
				{
					var board = (BoardZone) Owner.Zone;
					if (board.Count == 1)
						return;
					int pos = Owner.ZonePosition;
						if (pos > 0)
						Apply(board[pos - 1]);
					if (pos < board.Count - 1)
						Apply(board[pos + 1]);
					break;
				}
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
				case AuraType.HAND_AND_BOARD:
					Owner.Controller.HandZone.ForEach(Apply);
					Owner.Controller.BoardZone.ForEach(Apply);
					break;
				case AuraType.WEAPON:
					if (Owner.Controller.Hero.Weapon == null) break;
					Apply(Owner.Controller.Hero.Weapon);
					break;
				case AuraType.CONTROLLER:
					for (int i = 0; i < Effects.Length; i++)
						Effects[i].ApplyTo(Owner.Controller.ControllerAuraEffects);
					break;
				case AuraType.CONTROLLERS:
					for (int i = 0; i < Effects.Length; i++)
					{
						Effects[i].ApplyTo(Owner.Controller.ControllerAuraEffects);
						Effects[i].ApplyTo(Owner.Controller.Opponent.ControllerAuraEffects);
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
				case AuraType.SUMMONING_PORTAL:
					break;
			}
		}

		private void RemoveInternal()
		{
			IEffect[] effects = Effects;
			// Remove effects from applied entities

			if (Type == AuraType.CONTROLLER)
			{
				for (int i = 0; i < effects.Length; i++)
					effects[i].RemoveFrom(Owner.Controller.ControllerAuraEffects);
			}
			else if (Type == AuraType.CONTROLLERS)
			{
				for (int i = 0; i < effects.Length; i++)
				{
					effects[i].RemoveFrom(Owner.Controller.ControllerAuraEffects);
					effects[i].RemoveFrom(Owner.Controller.Opponent.ControllerAuraEffects);
				}
			}
			else
			{
				//foreach (IPlayable entity in AppliedEntities)
				//{
				//	//if (ValueFunc != null)
				//	//{
				//	//	IEffect effect = effects[0].ChangeValue(ValueFunc(entity));
				//	//	effect.RemoveFrom(entity.AuraEffects);
				//	//	continue;
				//	//}

				//	for (int i = 0; i < effects.Length; i++)
				//	{
				//		if (effects[i] is ConditionalEffect ce)
				//			ce.RemoveValueFrom(entity.AuraEffects);
				//		else
				//			effects[i].RemoveFrom(entity.AuraEffects);
				//	}
				//}
				_appliedEntityIdCollection.ForEach(Game.IdEntityDic, effects,
					(id, idDict, effs) =>
					{
						IPlayable entity = idDict[id];
						for (int i = 0; i < effs.Length; i++)
						{
							if (effs[i] is ConditionalEffect ce)
								ce.RemoveValueFrom(entity.AuraEffects);
							else
								effs[i].RemoveFrom(entity.AuraEffects);
						}
					});
			}

			Game.Auras.Remove(this);

			// Remove enchantments from applied entities
			//if (EnchantmentCard != null && (Game.History || EnchantmentCard.Power.Trigger != null))
			//	foreach (IPlayable entity in AppliedEntities)
			//		for (int i = entity.AppliedEnchantments.Count - 1; i >= 0; i--)
			//			if (entity.AppliedEnchantments[i].Creator.Id == _ownerId)
			//				entity.AppliedEnchantments[i].Remove();
			if (EnchantmentCard != null && (Game.History || EnchantmentCard.Power.Trigger != null))
			{
				_appliedEntityIdCollection.ForEach(_ownerId, Game.IdEntityDic,
					(id, ownerId, idDict) =>
					{
						IPlayable entity = idDict[id];
						for (int i = entity.AppliedEnchantments.Count - 1; i >= 0; i--)
							if (entity.AppliedEnchantments[i].Creator.Id == ownerId)
								entity.AppliedEnchantments[i].Remove();
					});
			}
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

		private void DeApply(IPlayable entity)
		{
			//if (!_appliedEntityIds.Remove(entity.Id))
			//	return;
			if (!_appliedEntityIdCollection.Remove(entity.Id))
				return;

			for (int i = 0; i < Effects.Length; i++)
			{
				if (Effects[i] is ConditionalEffect ce)
					ce.RemoveValueFrom(entity.AuraEffects);
				else
					Effects[i].RemoveFrom(entity.AuraEffects);
			}

			if (EnchantmentCard != null && (Game.History || EnchantmentCard.Power.Trigger != null))
			{
				int cardId = EnchantmentCard.AssetId;
				List<Enchantment> enchantments = entity.AppliedEnchantments;
				for (int i = enchantments.Count - 1; i >= 0; i--)
					if (enchantments[i].Creator == Owner && enchantments[i].Card.AssetId == cardId)
					{
						enchantments.RemoveAt(i);
						break;
					}
			}


			//if (_appliedEntities != null)
			//	AppliedEntities.Remove(entity);
		}

		/// <summary>
		/// Apply this aura's effect(s) to the target entity.
		/// </summary>
		private void Apply(IPlayable entity)
		{
			if (entity == null)
				throw new ArgumentNullException();

			IEffect[] effects = Effects;

			//if (_appliedEntityIds.Contains(entity.Id))
			//{
			//	if (!Restless || Condition.Eval(entity)) return;

			//	for (int i = 0; i < effects.Length; i++)
			//		effects[i].RemoveFrom(entity.AuraEffects);

			//	_appliedEntityIds.Remove(entity.Id);
			//	AppliedEntities.Remove(entity);
			//}

			if (Condition != null)
				if (!Condition.Eval(entity))
					return;

			//if (ValueFunc != null)
			//{
			//	IEffect effect = effects[0].ChangeValue(ValueFunc(entity));
			//	effect.ApplyTo(entity.AuraEffects);
			//}
			//else
				for (int i = 0; i < effects.Length; i++)
					effects[i].ApplyTo(entity.AuraEffects);

			if (EnchantmentCard != null && ((Game.History /*&& _tempList == null*/) || EnchantmentCard.Power.Trigger != null))
			{
				Enchantment instance = Enchantment.GetInstance(entity.Controller, Owner, entity, in EnchantmentCard);
				EnchantmentCard.Power.Trigger?.Activate(instance);
			}

			//AppliedEntities.Add(entity);
			//_appliedEntityIds.Add(entity.Id);

			_appliedEntityIdCollection.Add(entity.Id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void AddToZone()
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
				case AuraType.HAND_AND_BOARD:
					Owner.Controller.HandZone.Auras.Add(this);
					Owner.Controller.BoardZone.Auras.Add(this);
					break;
			}
		}

		public virtual void Clone(IPlayable clone)
		{
			Activate(clone, true);
			//((Aura)clone.OngoingEffect).ToBeUpdated = ToBeUpdated;
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[A:");
			sb.Append("[O:");
			sb.Append(Owner);
			sb.Append("]");
			sb.Append("[T:");
			sb.Append(Type);
			sb.Append("]");
			if (/*_appliedEntityIds*/_appliedEntityIdCollection != null)
			{
				sb.Append("[AEs:");
				//foreach (int i in _appliedEntityIds)
				//	sb.Append($"{{{i}}}");
				_appliedEntityIdCollection.ForEach(i => sb.Append($"{{{Game.IdEntityDic[i]}}}"));
				sb.Append("]");
			}
			sb.Append(On ? "[ON]" : "[OFF]");
			//sb.Append(ToBeUpdated ? "[U]" : "[NU]");
			return sb.ToString();
		}
	}

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

	/// <summary>
	/// Implementation of the specific effects of varying cost. e.g. Giants
	/// </summary>
	public class AdaptiveCostEffect : Aura
	{
		private readonly EffectOperator _operator;
		private readonly Predicate<IPlayable> _predicate;
		private readonly int _value;
		private readonly Func<IPlayable, int> _costFunction;

		//public (TriggerType Type, TriggerSource Source, SelfCondition Condition) UpdateTrigger;

		public AdaptiveCostEffect(EffectOperator @operator, Func<IPlayable, int> costFunc) : base(AuraType.ADAPTIVE)
		{
			_costFunction = costFunc;
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
			_costFunction = prototype._costFunction;
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
					return value + _costFunction(Owner);
				case EffectOperator.SUB:
					return value - _costFunction(Owner);
				case EffectOperator.SET:
					return _costFunction(Owner);
				case EffectOperator.MUL:
					return value * _costFunction(Owner);
			}

			return 0;
		}

		public override void Remove()
		{
			Owner.AuraEffects.AdaptiveCostEffect = null;
			Owner.OngoingEffect = null;
			Owner.Game.Auras.Remove(this);
			//if (UpdateTrigger.Type != 0)
			//	Owner.Game.TriggerManager.RemoveTrigger(UpdateTrigger.Type, TriggeredUpdate);
		}

		public override void Update()
		{
			//if (!_toBeUpdated) return;
			Owner.AuraEffects.ToBeUpdated = true;
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
		private Enchantment _currentInstance;

		public EnrageEffect(AuraType type, params IEffect[] effects) : base(type, effects)
		{
		}

		public EnrageEffect(AuraType type, string enchantmentId) : base(type, enchantmentId)
		{

		}

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
			//if (owner is Enchantment e)
			//	owner = (IPlayable)e.Target;

			var instance = new EnrageEffect(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public override void Update()
		{
			var m = Owner as Minion;

			if (!On)
			{
				Game.Auras.Remove(this);

				if (!_enraged) return;

				if (Type == AuraType.WEAPON)
				{
					Weapon weapon = m.Controller.Hero.Weapon;
					if (weapon == null)
						return;

					_target = weapon;
				}

				foreach (IEffect eff in EnchantmentCard.Power.Enchant.Effects)
				{
					eff.RemoveFrom(_target);
				}
				_currentInstance?.Remove();
				//if (_target != null)
				//	for (int i = 0; i < Effects.Length; i++)
				//		Effects[i].RemoveFrom(_target.AuraEffects);
			}

			if (Type == AuraType.WEAPON)
			{
				Weapon weapon = m.Controller.Hero.Weapon;
				if (weapon == null)
					return;

				_target = weapon;
			}

			if (!_enraged)
			{
				if (m.Damage == 0) return;
				//if (_target != null)
				//	for (int i = 0; i < Effects.Length; i++)
				//		Effects[i].ApplyTo(_target.AuraEffects);
				Generic.AddEnchantmentBlock.Invoke(m.Controller, EnchantmentCard, m, _target, 0, 0);
				if (Game.History)
					_currentInstance = _target.AppliedEnchantments.Last();
				_enraged = true;
			}
			else
			{
				if (m.Damage != 0) return;
				//if (_target != null)
				//	for (int i = 0; i < Effects.Length; i++)
				//		Effects[i].RemoveFrom(_target.AuraEffects);
				if (_currentInstance != null)
					_target.AppliedEnchantments.Remove(_currentInstance);
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
