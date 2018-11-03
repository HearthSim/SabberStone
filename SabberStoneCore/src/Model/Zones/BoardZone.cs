﻿using System;
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : PositioningZone<Minion>
	{
		private int _untouchableCount;
		private bool _hasUntouchables;

		public List<AdjacentAura> AdjacentAuras = new List<AdjacentAura>();

		public BoardZone(Controller controller) : base(7)
		{
			Game = controller.Game;
			Controller = controller;
			//MaxSize = Game.MAX_MINIONS_ON_BOARD;
		}

		public int CountExceptUntouchables => _count - _untouchableCount;
		public bool HasUntouchables => _hasUntouchables;

		public override Zone Type => Zone.PLAY;

		public override void Add(Minion entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			if (entity.Controller == Controller)
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

				if (entity[GameTag.GHOSTLY] == 1)
					entity[GameTag.GHOSTLY] = 0;
			}

			entity.OrderOfPlay = Game.NextOop;

			ActivateAura(entity);

			for (int i = 0; i < AdjacentAuras.Count; i++)
				AdjacentAuras[i].BoardChanged = true;

			Game.TriggerManager.OnZoneTrigger(entity);

			if (entity.Card.Untouchable)
			{
				++_untouchableCount;
				_hasUntouchables = true;
			}
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
			Entities[pos] = newEntity;
			newEntity.ZonePosition = pos;
			newEntity[GameTag.ZONE] = (int)Type;
			newEntity.Zone = this;

			// Remove old Entity
			RemoveAura(oldEntity);
			for (int i = 0; i < Auras.Count; i++)
				Auras[i].EntityRemoved(oldEntity);
			oldEntity.ActivatedTrigger?.Remove();
			if (oldEntity.Card.Untouchable && --_untouchableCount == 0)
				_hasUntouchables = false;

			Controller.SetasideZone.Add(oldEntity);

			// Add new Entity
			newEntity.OrderOfPlay = Game.NextOop;
			ActivateAura(newEntity);
			if (newEntity.Card.Untouchable)
			{
				++_untouchableCount;
				_hasUntouchables = true;
			}

			Auras.ForEach(a => a.EntityAdded(newEntity));
			AdjacentAuras.ForEach(a => a.BoardChanged = true);
		}

		private static void ActivateAura(Minion entity)
		{
			entity.Power?.Trigger?.Activate(entity);
			entity.Power?.Aura?.Activate(entity);

			if (entity.Card[GameTag.SPELLPOWER] > 0)
				entity.Controller.CurrentSpellPower += entity.Card.Tags[GameTag.SPELLPOWER];
		}

		private static void RemoveAura(Minion entity)
		{
			entity.OngoingEffect?.Remove();
			int csp = entity.Controller.CurrentSpellPower;
			if (csp > 0)
			{
				int sp = entity[GameTag.SPELLPOWER];
				if (sp > 0)
					entity.Controller.CurrentSpellPower = csp - sp;
			}
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
				Array.Copy(GetAll(null), 0, destination, index, _count - _untouchableCount);
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

			Minion[] entities = Entities;
			Minion[] src = zone.Entities;
			for (int i = 0; i < _count; ++i)
			{
				Minion copy = (Minion)entities[i].Clone(zone.Controller);
				copy.Zone = zone;
				src[i] = copy;
			}
		}
	}
}
