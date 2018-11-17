using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Auras can affect entities and change the applied entities' ATK, COST, etc. 
	/// Aura must be activated first to affect entities. 
	/// The effect of an aura is applied or removed during <see cref="Game.AuraUpdate"/>.
	/// </summary>
	public class Aura : IAura
	{
		private protected enum Instruction
		{
			Invalid, RemoveAll, AddAll, Add, Remove, /*CheckAdjacency*/
		}
		private protected readonly struct AuraUpdateInstruction : IEquatable<AuraUpdateInstruction>
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

		private protected readonly Util.PriorityQueue<AuraUpdateInstruction> AuraUpdateInstructionsQueue;
		private protected readonly Util.SmallFastCollection AppliedEntityIdCollection;

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

			AppliedEntityIdCollection = prototype.AppliedEntityIdCollection != null
				? new Util.SmallFastCollection(prototype.AppliedEntityIdCollection)
				: new Util.SmallFastCollection();

			AuraUpdateInstructionsQueue = new Util.PriorityQueue<AuraUpdateInstruction>();

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
				instance.AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.AddAll), 1);

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

				AppliedEntityIdCollection.ForEach(Game.IdEntityDic, this,
					(i, dict, aura) => aura.DeApply(dict[i]));

				UpdateInternal();

				return;
			}

			var queue = AuraUpdateInstructionsQueue;
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
			AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.RemoveAll), 0);
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

			var instruction = new AuraUpdateInstruction(playable, Instruction.Add);

			if (!AuraUpdateInstructionsQueue.Contains(in instruction))
				AuraUpdateInstructionsQueue.Enqueue(instruction, 2);
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

			AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(playable, Instruction.Remove), 1);
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
				AppliedEntityIdCollection.ForEach(Game.IdEntityDic, effects,
					(id, idDict, effs) =>
					{
						IPlayable entity = idDict[id];
						for (int i = 0; i < effs.Length; i++)
							effs[i].RemoveFrom(entity.AuraEffects);
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
				AppliedEntityIdCollection.ForEach(_ownerId, Game.IdEntityDic,
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
			if (!AppliedEntityIdCollection.Remove(entity.Id))
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

			AppliedEntityIdCollection.Add(entity.Id);
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
			if (/*_appliedEntityIds*/AppliedEntityIdCollection != null)
			{
				sb.Append("[AEs:");
				//foreach (int i in _appliedEntityIds)
				//	sb.Append($"{{{i}}}");
				AppliedEntityIdCollection.ForEach(i => sb.Append($"{{{Game.IdEntityDic[i]}}}"));
				sb.Append("]");
			}
			sb.Append(On ? "[ON]" : "[OFF]");
			//sb.Append(ToBeUpdated ? "[U]" : "[NU]");
			return sb.ToString();
		}
	}
}
