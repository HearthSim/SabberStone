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
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected T[] _entities;
		protected int _count;

		protected Zone(Zone type)
		{
			Type = type;
		}

		protected Zone(Controller c, Zone type)
		{
			Controller = c;
			Game = c.Game;
			Type = type;
		}
		public Zone Type { get; }

		/// <inheritdoc />
		/// <summary>
		/// Get the number of entities in this zone.
		/// </summary>
		public int Count => _count;

		/// <summary>
		/// Gets a value indicating whether this zone is full.
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		public abstract bool IsFull { get; }

		/// <summary>
		/// Gets the size of available space of this zone.
		/// </summary>
		public abstract int FreeSpace { get; }



		/// <summary>Gets the game which contains the zone.</summary>
		/// <value><see cref="Model.Game"/></value>
		public Game Game { get; protected set; }
		/// <summary>
		/// Gets the owner of the zone.
		/// </summary>
		/// <value><see cref="SabberStoneCore.Model.Entities.Controller"/></value>
		public Controller Controller { get; set; }

		public abstract void Add(T entity, int zonePosition = -1);

		public abstract T Remove(T entity);

		/// <summary>
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		public abstract void MoveTo(T entity, int zonePosition = -1);

		/// <summary>
		/// Gets a value indicating whether this contains entities or not.
		/// </summary>
		/// <value><c>true</c> if this zone is empty; otherwise, <c>false</c>.</value>
		public bool IsEmpty => Count == 0;

		/// <summary>
		/// Gets a random entity in this zone.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Random => _count == 0 ? default : _entities[Game.Random.Next(_count)];

		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The zero-based position inside the zone.</param>
		/// <returns></returns>
		public T this[int zonePosition] => zonePosition >= _count ? throw new IndexOutOfRangeException() : _entities[zonePosition];

		/// <summary>
		/// Replaces an entity in the given position internally. (i.e. not create any history packets)
		/// </summary>
		public abstract void ChangeEntity(T oldEntity, T newEntity);

		/// <summary>
		/// Returns TRUE if at least one of entities
		///	in this Zone satisfies the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public bool Any(Func<T, bool> predicate)
		{
			T[] entities = _entities;
			for (int i = 0; i < _count; i++)
				if (predicate(entities[i]))
					return true;
			return false;
		}

		/// <summary>
		/// Returns the number of entities in this Zone
		/// that matches the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public int CountOf(Predicate<T> predicate)
		{
			T[] entities = _entities;
			int count = 0;
			for (int i = 0; i < _count; i++)
				if (predicate(entities[i]))
					count++;
			return count;
		}

		/// <summary>
		/// Gets a deep-copied array of entities in this zone.
		/// </summary>
		/// <returns></returns>
		public virtual T[] GetAll()
		{
			T[] array = new T[_count];
			Array.Copy(_entities, array, array.Length);
			return array;
		}

		/// <summary>
		/// Gets a deep-copied array of entities in this zone
		/// that matches the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Gets a <see cref="ReadOnlySpan{T}"/> of this Zone.
		/// </summary>
		/// <returns></returns>
		public ReadOnlySpan<T> GetSpan()
		{
			return new ReadOnlySpan<T>(_entities, 0, _count);
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
		internal virtual void CopyTo(Array destination, int index)
		{
			Array.Copy(_entities, 0, destination, index, _count);
		}

		public string Hash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append("[Z:");
			str.Append($"{Type} ");
			//str.Append("][E:");
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

		public virtual IEnumerator<T> GetEnumerator()
		{
			return new Enumerator(this);
		}

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

		void IZone.MoveTo(IPlayable entity, int zonePosition)
		{
			MoveTo((T) entity, zonePosition);
		}

		IPlayable IZone.Remove(IPlayable entity)
		{
			return Remove((T)entity);
		}

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		List<IPlayable> IZone.GetAll => this.Cast<IPlayable>().ToList();

		private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private readonly int _count;
			private readonly T[] _entities;
			private int _index;
			private T _current;

			internal Enumerator(Zone<T> zone)
			{
				_count = zone._count;
				_entities = zone._entities;
				_index = 0;
				_current = default;
			}

			#region Implementation of IEnumerator

			public bool MoveNext()
			{
				if (_index >= _count)
					return false;
				_current = _entities[_index++];
				return true;
			}

			public void Reset()
			{
				_index = 0;
				_current = default;
			}

			public T Current => _current;

			object IEnumerator.Current => _current;

			#endregion

			#region Implementation of IDisposable

			public void Dispose()
			{
			}

			#endregion
		}
	}

	/// <summary>
	/// Base implementation of <see cref="GraveyardZone"/> and <see cref="SetasideZone"/>.
	/// This kind of zones never be full.
	/// </summary>
	public abstract class UnlimitedZone : Zone<IPlayable>
	{
		protected UnlimitedZone(Controller controller, Zone type) : base(type)
		{
			_entities = new IPlayable[3];
			Controller = controller;
			Game = controller.Game;
		}

		protected UnlimitedZone(Controller c, UnlimitedZone zone) : base(c, zone.Type)
		{
			IPlayable[] src = zone._entities;
			var entities = new IPlayable[src.Length];
			for (int i = 0; i < zone.Count; ++i)
			{
				IPlayable copy = src[i].Clone(c);
				copy.Zone = this;
				//entities.Add(copy);
				entities[i] = copy;
			}
			_entities = entities;
			_count = zone._count;
		}
		public override bool IsFull => false;
		public override int FreeSpace => int.MaxValue;

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

			//_entities.Remove(entity);
			IPlayable[] entities = _entities;
			int i = --_count;
			for (; i >= 0; --i)
				if (entities[i] == entity)
					break;
			if (i == _count)
				entities[i] = default;
			else if (i < 0)
				throw new ZoneException($"Could not remove {entity} from {this}; the entity is not in the zone.");
			else
			{
				Array.Copy(entities, i + 1, entities, i, _count - i);
			}

			entity.Zone = null;

			return entity;
		}

		public override void MoveTo(IPlayable entity, int zonePosition = -1)
		{
			if (_entities.Length == _count) Resize();

			_entities[_count++] = entity;
			entity.Zone = this;
			if (Game.History)
				entity[GameTag.ZONE] = (int) Type;
		}

		public override void ChangeEntity(IPlayable oldEntity, IPlayable newEntity)
		{
			int pos = Array.FindIndex(_entities, p => p == oldEntity);
			_entities[pos] = newEntity;
			newEntity.Zone = this;
		}

		public override IEnumerator<IPlayable> GetEnumerator()
		{
			return _entities.Take(_count).GetEnumerator();
		}

		private void Resize()
		{
			var newArray = new IPlayable[_count << 1];
			Array.Copy(_entities, 0, newArray, 0, _count);
			_entities = newArray;
		}
	}

	/// <summary>
	/// Base implementation of zones which have a maximum size.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class LimitedZone<T> : Zone<T> where T: IPlayable
	{
		/// <summary>
		/// The maximum amount of entities this zone can hold.
		/// </summary>
		public readonly int MaxSize;

		protected LimitedZone(Zone type, int maxSize) : base(type)
		{
			MaxSize = maxSize;
			_entities = new T[maxSize];
		}
		protected LimitedZone(Controller c, LimitedZone<T> zone) : base(c, zone.Type)
		{
			MaxSize = zone.MaxSize;
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

		public override int FreeSpace => MaxSize - _count;

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

		/// <summary>
		/// Removes an entity at the given index and returns the entity.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <param name="index"></param>
		/// <returns></returns>
		public T Remove(int index)
		{
			if (index < 0 || index >= _count)
				throw new ArgumentOutOfRangeException(nameof(index));

			T entity = _entities[index];
			if (index < --_count)
				Array.Copy(_entities, index + 1, _entities, index, _count - index);

			entity.Zone = null;

			entity.ActivatedTrigger?.Remove();

			return entity;
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
		public readonly List<Aura> Auras = new List<Aura>();

		protected PositioningZone(Zone type, int maxSize) : base(type, maxSize) { }
		protected PositioningZone(Controller c, PositioningZone<T> zone) : base(c, zone) { }

		private void Reposition(int zonePosition = 0)
		{
			if (zonePosition < 0)
			{
				_entities[_count - 1].ZonePosition = _count - 1;
				return;
			}

			T[] entities = _entities;
			for (int i = zonePosition; i < _count; ++i)
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

		public override void ChangeEntity(T oldEntity, T newEntity)
		{
			int pos = oldEntity.ZonePosition;
			_entities[pos] = newEntity;
			newEntity.ZonePosition = pos;
			newEntity.Zone = this;
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
	}

#if NOSPAN
	/// <summary>
	/// A Mocking class for System.Memory.ReadOnlySpan.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public readonly ref struct ReadOnlySpan<T>
	{
		private readonly T[] _array;
		public int Length { get; }

		public ReadOnlySpan(T[] array)
		{
			Length = array.Length;
			_array = array;
		}

		public T this[int index] => _array[index];

		public ReadOnlySpan<T> Slice(int start, int count)
		{
			T[] slice = new T[count];
			Array.Copy(_array, start, slice, 0, count);
			return new ReadOnlySpan<T>(slice);
		}
	}
#endif
}
