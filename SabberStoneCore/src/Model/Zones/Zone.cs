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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Auras;

namespace SabberStoneCore.Model.Zones
{
	/// <inheritdoc cref="IZone" />
	/// <summary>
	/// Base implementation of IZone.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="T:SabberStoneCore.Model.Zones.IZone" />
	/// <seealso cref="T:System.Collections.Generic.IEnumerable`1" />
	public abstract class Zone<T> : IZone, IEnumerable<T> where T : IPlayable
	{
		protected Zone() { }

		protected Zone(Controller c)
		{
			Controller = c;
			Game = c.Game;
		}

		/// <inheritdoc />
		/// <summary>
		/// Get the number of entities in this zone.
		/// </summary>
		public abstract int Count { get; }

		/// <summary>
		/// Gets a value indicating whether this zone is full.
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		public abstract bool IsFull { get; }

		public abstract Zone Type { get; }

		/// <summary>
		/// Gets a random entity in this zone.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public abstract T Random { get; }

		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The zero-based position inside the zone.</param>
		/// <returns></returns>
		public abstract T this[int zonePosition] { get; }

		/// <summary>Gets the game which contains the zone.</summary>
		/// <value><see cref="Model.Game"/></value>
		public Game Game { get; protected set; }
		/// <summary>
		/// Gets the owner of the zone.
		/// </summary>
		/// <value><see cref="SabberStoneCore.Model.Entities.Controller"/></value>
		public Controller Controller { get; set; }

		/// <summary>
		/// Gets a value indicating whether this contains entities or not.
		/// </summary>
		/// <value><c>true</c> if this zone is empty; otherwise, <c>false</c>.</value>
		public bool IsEmpty => Count == 0;

		public abstract void Add(T entity, int zonePosition = -1);

		public abstract T Remove(T entity);

		/// <summary>
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		public abstract void MoveTo(T entity, int zonePosition = -1);

		/// <summary>
		/// Returns TRUE if at least one of entities
		///	in this Zone satisfies the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public abstract bool Any(Func<T, bool> predicate);

		public string Hash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append("[Z:");
			str.Append($"{Type}");
			str.Append("][E:");
			var list = this.ToList();
			if (Type != Zone.PLAY)
			{
				list = list.OrderBy(p => p.Id).ToList();
				Array.Resize(ref ignore, ignore.Length + 1);
				ignore[ignore.Length - 1] = GameTag.ZONE_POSITION;
			}
			list.ForEach(p => str.Append(p.Hash(ignore)));
			if (this is PositioningZone<T> pZone)
			{
				str.Append("[As:");
				pZone.Auras.OrderBy(p => p.Owner.Id).ToList().ForEach(p => str.Append(p));
				str.Append("]");
			}
			str.Append("]");
			return str.ToString();
		}

		public override string ToString()
		{
			return $"[ZONE {Type} '{Controller.Name}']";
		}

		public abstract IEnumerator<T> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public string FullPrint()
		{
			var str = new StringBuilder();
			str.Append($"{this}|");
			foreach (T p in this)
			{
				var m = p as Minion;
				var w = p as Weapon;
				string mStr = m != null ? $"[{m.AttackDamage}/{m.Health}]" : (w != null ? $"[{w.AttackDamage}/{w.Durability}]" : "");
				str.Append($"[P{p.ZonePosition}]{mStr}[C{p.Cost}]{p}|");
			}
			return str.ToString();
		}

		void IZone.Add(IPlayable entity, int zonePosition)
		{
			Add((T)entity, zonePosition);
		}

		IPlayable IZone.Remove(IPlayable entity)
		{
			return Remove((T)entity);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		List<IPlayable> IZone.GetAll => this.Cast<IPlayable>().ToList();
	}

	/// <summary>
	/// Base implementation of <see cref="GraveyardZone"/> and <see cref="SetasideZone"/>.
	/// This kind of zones never be full.
	/// </summary>
	public abstract class UnlimitedZone : Zone<IPlayable>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly List<IPlayable> _entities;

		public override int Count => _entities.Count;
		public override bool IsFull => false;

		protected UnlimitedZone(Controller controller)
		{
			_entities = new List<IPlayable>();
			Controller = controller;
			Game = controller.Game;
		}

		protected UnlimitedZone(Controller c, UnlimitedZone zone) : base(c)
		{
			var entities = new List<IPlayable>(zone.Count);
			IList<IPlayable> src = zone._entities;
			for (int i = 0; i < src.Count; ++i)
			{
				IPlayable copy = src[i].Clone(c);
				copy.Zone = this;
				entities.Add(copy);
			}
			_entities = entities;
		}

		public override IPlayable this[int zonePosition]
		{
			get => _entities[zonePosition];
		}

		public override IPlayable Random => Count == 0 ? default : _entities[Util.Random.Next(Count)];

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			if (entity.Controller != Controller)
				throw new ZoneException("Can't add an opponent's entity to own Zones");
			MoveTo(entity, zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}'.");
		}

		public override IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			_entities.Remove(entity);

			return entity;
		}

		public override void MoveTo(IPlayable entity, int zonePosition = -1)
		{
			_entities.Add(entity);
			entity.Zone = this;
			if (Game.History)
				entity[GameTag.ZONE] = (int) Type;
		}

		public override bool Any(Func<IPlayable, bool> predicate)
		{
			List<IPlayable> entities = _entities;
			for (int i = 0; i < entities.Count; i++)
				if (predicate(entities[i]))
					return true;

			return false;
		}

		public override IEnumerator<IPlayable> GetEnumerator()
		{
			return _entities.GetEnumerator();
		}
	}

	/// <summary>
	/// Base implementation of zones which have a maximum size.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class LimitedZone<T> : Zone<T> where T: IPlayable
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected readonly T[] _entities;
		protected int _count;

		protected LimitedZone()
		{
			_entities = new T[MaxSize];
		}
		protected LimitedZone(Controller c, LimitedZone<T> zone) : base(c)
		{
			_count = zone._count;
			var entities = new T[MaxSize];
			T[] src = zone._entities;
			for (int i = 0; i < _count; ++i)
			{
				T copy = (T)src[i].Clone(c);
				copy.Zone = this;
				entities[i] = copy;
			}
			_entities = entities;
		}

		/// <summary>
		/// Gets the maximum amount of entities this zone can hold.
		/// </summary>
		/// <value>The maximum size.</value>
		public abstract int MaxSize { get; }

		public override T this[int zonePosition] => zonePosition >= _count ? throw new IndexOutOfRangeException() : _entities[zonePosition];

		public override int Count => _count;

		public override T Random => _count == 0 ? default : _entities[Util.Random.Next(_count)];

		public int FreeSpace => MaxSize - _count;

		public override void Add(T entity, int zonePosition = -1)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");
			if (entity.Controller != Controller)
				throw new ZoneException("Can't add an opponent's entity to own Zones");

			MoveTo(entity, zonePosition < 0 ? _count : zonePosition);

			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");
		}

		public override void MoveTo(T entity, int zonePosition = -1)
		{
			if (entity == null)
				throw new ZoneException();

			int c = _count;

			if (c == MaxSize)
				throw new ZoneException($"Can't move {entity} to {this}. The Zone is full.");

			if (zonePosition < 0 || zonePosition == c)
				_entities[c] = entity;
			else
			{
				T[] entities = _entities;
				//for (int i = c - 1; i >= zonePosition; --i)
				//	entities[i + 1] = entities[i];
				Array.Copy(entities, zonePosition, entities, zonePosition + 1, c - zonePosition);
				entities[zonePosition] = entity;
			}

			_count = c + 1;

			entity.Zone = this;
			if (Game.History)
				entity[GameTag.ZONE] = (int)Type;
		}

		public override T Remove(T entity)
		{
			//if (entity.Zone == null || entity.Zone.Type != Type)
			if (entity.Zone != this)
				throw new ZoneException("Couldn't remove entity from zone.");

			T[] entities = _entities;
			int pos;
			for (pos = _count - 1; pos >= 0; --pos)
				if (ReferenceEquals(entities[pos], entity)) break;

			if (pos < --_count)
				Array.Copy(entities, pos + 1, entities, pos, _count - pos);

			entity.Zone = null;

			entity.ActivatedTrigger?.Remove();

			return entity;
		}

		public override bool Any(Func<T, bool> predicate)
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; i++)
				if (predicate(entities[i]))
					return true;
			return false;
		}

		public virtual T[] GetAll()
		{
			T[] array = new T[_count];
			Array.Copy(_entities, array, array.Length);
			return array;
		}

		public virtual T[] GetAll(Func<T, bool> predicate)
		{
			T[] buffer = new T[_count];
			int i = 0;
			T[] entities = _entities;
			for (int k = 0; k < buffer.Length; ++k)
			{
				if (!predicate(entities[k])) continue;
				buffer[i] = entities[k];
				++i;
			}

			if (i != _count)
			{
				T[] array = new T[i];
				Array.Copy(buffer, array, i);
				return array;
			}
			return buffer;
		}

		public ReadOnlySpan<T> GetSpan()
		{
			var span = new ReadOnlySpan<T>( _entities);
			return span.Slice(0, _count);
		}

		internal virtual void CopyTo(Array destination, int index)
		{
			Array.Copy(_entities, 0, destination, index, _count);
		}

		public void ForEach(Action<T> action)
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i]);
		}

		public void ForEach<T2>(Action<T, T2> action, T2 arg2)
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i], arg2);
		}

		public void ForEach<T2, T3>(Action<T, T2, T3> action, T2 arg2, T3 arg3)
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i], arg2, arg3);
		}

		public override IEnumerator<T> GetEnumerator()
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; i++)
				yield return entities[i];
		}
	}

	/// <summary>
	/// Base implementation of zones performing strict recalculation of its containing entities' ZonePosition when any member comes and goes.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class PositioningZone<T> : LimitedZone<T> where T : IPlayable
	{
		protected PositioningZone() { }
		protected PositioningZone(Controller c, PositioningZone<T> zone) : base(c, zone) { }

		public readonly List<Aura> Auras = new List<Aura>();

		private void Reposition(int zonePosition = 0)
		{
			if (zonePosition < 0)
			{
				_entities[_count - 1].ZonePosition = _count - 1;
				return;
			}

			T[] entities = _entities;
			for (int i = _count - 1; i >= zonePosition; --i)
				entities[i].ZonePosition = i;
		}

		public override void Add(T entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			Reposition(zonePosition);

			for (int i = Auras.Count - 1; i >= 0; i--)
				Auras[i].EntityAdded(entity);
		}

		public override T Remove(T entity)
		{
			//if (entity.Zone == null || entity.Zone.Type != Type)
			if (entity.Zone != this)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos = entity.ZonePosition;
			int count = _count;
			T[] entities = _entities;
			//for (pos = count - 1; pos >= 0; --pos)
			//	if (ReferenceEquals(entities[pos], entity)) break;

			if (pos < --count)
				Array.Copy(entities, pos + 1, entities, pos, count - pos);

			_count = count;

			Reposition(pos);

			entity.Zone = null;

			entity.ActivatedTrigger?.Remove();

			for (int i = Auras.Count - 1; i >= 0; i--)
				Auras[i].EntityRemoved(entity);

			return entity;
		}

		/// <summary>
		/// Swaps the positions of both entities in this zone.
		/// Both entities must be contained by this zone.
		/// </summary>
		/// <param name="oldEntity">The one entity.</param>
		/// <param name="newEntity">The other entity.</param>
		public void Swap(T oldEntity, T newEntity)
		{
			if (oldEntity.Zone.Type != newEntity.Zone.Type)
				throw new ZoneException("Swap not possible because of zone mismatch");

			int oldPos = oldEntity.ZonePosition;
			int newPos = newEntity.ZonePosition;
			newEntity.ZonePosition = oldPos;
			oldEntity.ZonePosition = newPos;
			_entities[newPos] = oldEntity;
			_entities[oldPos] = newEntity;
		}

		/// <summary>
		/// Replaces an entity in the given position internally. (i.e. not create any history packets)
		/// </summary>
		internal void ChangeEntity(T oldEntity, T newEntity)
		{
			int pos = oldEntity.ZonePosition;
			_entities[pos] = newEntity;
			newEntity.ZonePosition = pos;
			newEntity.Zone = this;
		}
	}
}
