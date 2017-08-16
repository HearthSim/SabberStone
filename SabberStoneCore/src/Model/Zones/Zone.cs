﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Base implementation of IZone.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="IZone" />
	/// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
	public abstract class Zone<T> : IZone, IModelCollection<T> where T : class, IPlayable
	{
		public Game Game { get; }

		public Controller Controller { get; }

		public Zone Type { get; }

		public abstract int MaxSize { get; }

		public bool IsFull => !(Count < MaxSize);

		public bool IsEmpty => Count == 0;

		public bool IsReadOnly => false;

		public int Count => _entitiesAsList.Count;

		public T Random => Util.Choose(_entitiesAsList);

		private readonly List<T> _entitiesAsList = new List<T>();

		public List<Enchant> Enchants { get; private set; } = new List<Enchant>();

		public List<Trigger> Triggers { get; private set; } = new List<Trigger>();

		public List<IPlayable> GetAll
		{
			get
			{
				var list = new List<IPlayable>();
				_entitiesAsList.ForEach(p => list.Add(p));
				return list;
			}
		}

		/// <summary>Builds a new zone object.</summary>
		/// <param name="game">The game which contains the zone.</param>
		/// <param name="controller">The controller which owns the zone.</param>
		/// <param name="type">The kind of zone.</param>
		public Zone(Game game, Controller controller, Zone type)
		{
			Game = game;
			Controller = controller;
			Type = type;
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Zone", $"Created Zone {type} in Game with Controller {controller.Name}");
		}

		public IPlayable this[int zonePosition]
			=> zonePosition >= 0 && zonePosition < _entitiesAsList.Count ? _entitiesAsList[zonePosition] : default(T);

		public IPlayable Add(IPlayable entity, int zonePosition = -1)
		{
			if (zonePosition > _entitiesAsList.Count)
			{
				throw new ZoneException("Zoneposition '" + zonePosition + "' isn't in a valid range.");
			}

			// reset the card if it gets into the graveyard ...
			if (Type == Zone.GRAVEYARD)
				entity.Reset();

			MoveTo(entity, zonePosition < 0 ? _entitiesAsList.Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			// activate all zone changing enchantments
			entity.ApplyEnchantments(EnchantmentActivation.SETASIDE_ZONE, Zone.SETASIDE);
			entity.ApplyEnchantments(EnchantmentActivation.BOARD_ZONE, Zone.PLAY);
			entity.ApplyEnchantments(EnchantmentActivation.HAND_ZONE, Zone.HAND);
			entity.ApplyEnchantments(EnchantmentActivation.DECK_ZONE, Zone.DECK);

			entity.SetOrderOfPlay(Type.ToString());
			return entity;
		}

		public IPlayable Remove(IPlayable entity)
		{
			if (!_entitiesAsList.Remove((T)entity))
			{
				throw new ZoneException("Couldn't remove entity from zone.");
			}
			RePosition(entity.ZonePosition);
			entity.Zone = null;
			//entity[GameTag.ZONE] = (int) Zone.INVALID;
			//entity.ZonePosition = 0;
			return entity;
		}

		public void MoveTo(IPlayable entity, int zonePosition)
		{
			_entitiesAsList.Insert(zonePosition, (T)entity);
			entity.Zone = this;
			entity[GameTag.ZONE] = (int)Type;
			RePosition(zonePosition);
		}

		public IPlayable Replace(IPlayable oldEntity, IPlayable newEntity)
		{
			MoveTo(newEntity, _entitiesAsList.Count);
			Swap(oldEntity, newEntity);
			return Remove(oldEntity);
		}

		public void Swap(IPlayable oldEntity, IPlayable newEntity)
		{
			if (oldEntity.Zone != newEntity.Zone)
			{
				throw new ZoneException("Swap not possible because of zone missmatch.");
			}

			int oldPos = oldEntity.ZonePosition;
			int newPos = newEntity.ZonePosition;
			newEntity.ZonePosition = oldPos;
			oldEntity.ZonePosition = newPos;
			_entitiesAsList[newPos] = (T)oldEntity;
			_entitiesAsList[oldPos] = (T)newEntity;
		}

		private void RePosition(int zonePosition = 0)
		{
			for (int i = zonePosition; i < _entitiesAsList.Count; i++)
			{
				_entitiesAsList[i].ZonePosition = i;
			}
		}

		// TODO; Move out of core.
		public string FullPrint()
		{
			var str = new StringBuilder();
			str.Append($"{this}|");
			_entitiesAsList.ForEach(p =>
			{
				var m = p as Minion;
				var w = p as Weapon;
				var mStr = m != null ? $"[{m.AttackDamage}/{m.Health}]" : (w != null ? $"[{w.AttackDamage}/{w.Durability}]" : "");
				str.Append($"[P{p.ZonePosition}]{mStr}[C{p.Cost}]{p}|");
			});
			str.Append($"[ENCH {Enchants.Count}]");
			str.Append($"[TRIG {Triggers.Count}]");
			return str.ToString();
		}

		public override string ToString()
		{
			return $"[ZONE {Type} '{Controller.Name}']";
		}

		#region IMODEL_IMPLEMENTATION

		public IEnumerator<T> GetEnumerator()
		{
			return _entitiesAsList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		void ICollection<T>.Add(T item)
		{
			Add(item, -1);
		}

		void ICollection<T>.Clear()
		{
			_entitiesAsList.Clear();
		}

		bool ICollection<T>.Contains(T item)
		{
			return _entitiesAsList.Contains(item);
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
			_entitiesAsList.CopyTo(array, arrayIndex);
		}

		bool ICollection<T>.Remove(T item)
		{
			return Remove(item) != null;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public string ToHash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append("[Z:");
			str.Append($"{Type}");
			str.Append("][E:");
			List<IPlayable> list = GetAll;
			if (Type != Zone.PLAY)
			{
				list = list.OrderBy(p => p.Id).ToList();
				Array.Resize(ref ignore, ignore.Length + 1);
				ignore[ignore.Length - 1] = GameTag.ZONE_POSITION;
			}
			list.ForEach(p => str.Append(p.ToHash(ignore)));
			str.Append($"][EN:{Enchants.Count}");
			Enchants.ForEach(p => str.Append(p.Hash));
			str.Append($"][TR:{Triggers.Count}");
			Triggers.ForEach(p => str.Append(p.Hash));
			str.Append("]");
			return str.ToString();
		}

		public void Stamp(IModel other)
		{
			Zone<T> zone = other as Zone<T> ?? throw new InvalidOperationException("other's type is invalid");

			zone.GetAll.ToList().ForEach(p =>
			{
				IPlayable copy = Entity.FromCard(Controller, p.Card, null, null, p.Id);
				copy.Stamp(p as Entity);
				MoveTo(copy, copy.ZonePosition);
			});
			zone.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner, p.RemoveTriggers)));
			zone.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
		}

		public IModelCollection<T> Clone(Game newGame)
		{
			return ZoneClone(newGame);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		IModel IModel.Clone(Game newGame)
		{
			return ZoneClone(newGame);
		}

		IZone IModel<IZone>.Clone(Game newGame)
		{
			return ZoneClone(newGame);
		}

		private Zone<T> ZoneClone(Game newGame)
		{
			Zone<T> deepClone = InternalClone(newGame) ?? throw new InvalidOperationException("Implemented class returned null");
			_entitiesAsList.ForEach(p =>
			{
				var copy = p.Clone(newGame) as IPlayable;
				// Save copy of this entity in the new game instance.
				newGame.EntityContainer[copy.Id] = copy;

				// Is this still necessary?
				deepClone.MoveTo(copy, copy.ZonePosition);
			});
			Enchants.ForEach(p => deepClone.Enchants.Add(p.Copy(p.SourceId, newGame, p.Turn, deepClone.Enchants, p.Owner, p.RemoveTriggers)));
			Triggers.ForEach(p => deepClone.Triggers.Add(p.Copy(p.SourceId, newGame, p.Turn, deepClone.Triggers, p.Owner)));

			return deepClone;
		}

		/// <summary>
		/// Method definition forcing implementing classes to implement cloning behaviour.
		/// </summary>
		/// <returns></returns>
		protected abstract Zone<T> InternalClone(Game newGame);

		#endregion
	}
}
