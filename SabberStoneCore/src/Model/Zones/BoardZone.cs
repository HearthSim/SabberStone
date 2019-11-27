#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : PositioningZone<Minion>
	{
		private int _untouchableCount;
		private bool _hasUntouchables;

		public List<AdjacentAura> AdjacentAuras = new List<AdjacentAura>();

		public BoardZone(Controller controller) : base(Zone.PLAY, Game.MAX_MINIONS_ON_BOARD)
		{
			Game = controller.Game;
			Controller = controller;
		}

		public int CountExceptUntouchables => _count - _untouchableCount;
		public bool HasUntouchables => _hasUntouchables;

		public override bool IsFull => _count == Game.MAX_MINIONS_ON_BOARD;

		public override void Add(Minion entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			if (entity.Controller == Game.CurrentPlayer)
			{
				if (!entity.HasCharge)
				{
					if (entity.IsRush)
					{
						entity.AttackableByRush = true;
						Game.RushMinions.Add(entity.Id);
					}
					else
						entity.IsExhausted = true;
				}
			}

			entity.OrderOfPlay = Game.NextOop;

			ActivateAura(entity);

			for (int i = AdjacentAuras.Count - 1; i >= 0; i--)
				AdjacentAuras[i].BoardChanged = true;

			Game.TriggerManager.OnZoneTrigger(entity);

			if (entity.Card.Untouchable)
			{
				++_untouchableCount;
				_hasUntouchables = true;
			}
		}

		internal static void InitialiseMinion(Minion entity)
		{
			if (entity.Game.CurrentPlayer != entity.Controller) return;
			if (entity.HasCharge) return;
			if (entity.IsRush)
			{
				entity.AttackableByRush = true;
				entity.Game.RushMinions.Add(entity.Id);
			}
			else
				entity.IsExhausted = true;
		}

		public override Minion Remove(Minion entity)
		{
			RemoveAura(entity);
			for (int i = 0; i < AdjacentAuras.Count; i++)
				AdjacentAuras[i].BoardChanged = true;
			if (entity.Card.Untouchable && --_untouchableCount == 0)
				_hasUntouchables = false;
			return base.Remove(entity);
		}

		//internal override void ChangeEntity(Minion oldEntity, Minion newEntity)
		//{
		//	if (oldEntity.Untouchable)
		//		if (!newEntity.Untouchable && --_untouchableCount == 0)
		//			_hasUntouchables = false;

		//	base.ChangeEntity(oldEntity, newEntity);
		//}

		/// <summary>
		/// Replaces an entity in this zone to new entity and returns the old entity.
		/// The position of the new entity is the same position the old entity had.
		/// </summary>
		/// <param name="oldEntity">The entity to be replaced.</param>
		/// <param name="newEntity">The new entity.</param>
		/// <returns></returns>
		public void Replace(Minion oldEntity, Minion newEntity)
		{
			int pos = oldEntity.ZonePosition;

			// Remove old Entity
			RemoveAura(oldEntity);
			for (int i = 0; i < Auras.Count; i++)
				Auras[i].EntityRemoved(oldEntity);
			oldEntity.ActivatedTrigger?.Remove();
			if (oldEntity.Card.Untouchable && --_untouchableCount == 0)
				_hasUntouchables = false;
			oldEntity.ZonePosition = 0;
			oldEntity.Controller.SetasideZone.Add(oldEntity);

			// Add new Entity
			newEntity.OrderOfPlay = Game.NextOop;
			_entities[pos] = newEntity;
			if (newEntity.Game.History)
				newEntity[GameTag.ZONE] = (int)Type;
			newEntity.Zone = this;
			newEntity.ZonePosition = pos;
			ActivateAura(newEntity);
			if (newEntity.Card.Untouchable)
			{
				++_untouchableCount;
				_hasUntouchables = true;
			}
			Auras.ForEach(a => a.EntityAdded(newEntity));
			AdjacentAuras.ForEach(a => a.BoardChanged = true);
			if (!newEntity.HasCharge)
			{
				if (newEntity.IsRush)
				{
					newEntity.AttackableByRush = true;
					Game.RushMinions.Add(newEntity.Id);
				}
				else
					newEntity.IsExhausted = true;
			}
		}

		/// <summary>
		/// Activates a <see cref="Minion"/>'s <see cref="Triggers.Trigger"/> and <see cref="Aura"/> and
		/// applies it's Spell Power increment.
		/// </summary>
		/// <param name="entity"></param>
		public static void ActivateAura(Minion entity)
		{
			entity.Power?.Trigger?.Activate(entity);
			entity.Power?.Aura?.Activate(entity);
		}

		private static void RemoveAura(Minion entity)
		{
			entity.OngoingEffect?.Remove();
		}

		/// <summary>
		/// Gets all board minions except untouchables(dormant).
		/// </summary>
		/// <returns></returns>
		public override Minion[] GetAll()
		{
			return HasUntouchables ? GetAll(null) : base.GetAll();
		}

		/// <summary>
		/// Gets all board minions satisfying the given predicate except untouchables(dormant).
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public override Minion[] GetAll(Func<Minion, bool> predicate)
		{
			if (_hasUntouchables)
			{
				if (predicate == null)
					predicate = p => !p.Card.Untouchable;
				else
				{
					Func<Minion, bool> predicate1 = predicate;
					predicate = p => predicate1(p) && !p.Card.Untouchable;
				}
			}
			return base.GetAll(predicate);
		}

		internal override void CopyTo(Array destination, int index)
		{
			if (_hasUntouchables)
			{
				Array.Copy(GetAll(null), 0, destination, index, CountExceptUntouchables);
				return;
			}

			base.CopyTo(destination, index);
		}

		internal void DecrementUntouchablesCount()
		{
			if (!_hasUntouchables) return;
			if (--_untouchableCount == 0)
				_hasUntouchables = false;
		}

		public void Stamp(BoardZone zone)
		{
			zone._hasUntouchables = _hasUntouchables;
			zone._untouchableCount = _untouchableCount;
			zone._count = _count;

			Minion[] entities = _entities;
			Minion[] src = zone._entities;
			for (int i = 0; i < _count; ++i)
			{
				Minion copy = (Minion)entities[i].Clone(zone.Controller);
				copy.Zone = zone;
				src[i] = copy;
			}
		}
	}
}
