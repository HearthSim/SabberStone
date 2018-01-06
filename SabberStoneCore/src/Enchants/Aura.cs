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
		SELF, ADJACENT, BOARD, BOARD_EXCEPT_SOURCE, HAND, OP_HAND, HANDS, CONTROLLER, ADAPTIVE, TARGET
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
		private bool _on;
		private bool _toBeUpdated = true;
		private readonly Func<IPlayable, int> _adaptivePredicate;
		private readonly GameTag _adaptiveTag;
		protected Effect[] Effects;

		public readonly Game Game;
		public readonly AuraType Type;
		public SelfCondition Condition;
		public (TriggerType, SelfCondition) RemoveTrigger;
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

			Game.Auras.Add(instance);
			owner.OngoingEffect = instance;

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

		public void Activate(Controller controller)
		{
			throw new NotImplementedException();
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

			for (int i = 0; i < Effects.Length; i++)
				Effects[i].Apply(entity.AuraEffects);

			// history

			AppliedEntities.Add(entity);
			_appliedEntityIds.Add(entity.Id);
		}
	}
}
