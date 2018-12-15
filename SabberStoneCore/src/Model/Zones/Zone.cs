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
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

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
		/// <summary>Gets the game which contains the zone.</summary>
		/// <value><see cref="Model.Game"/></value>
		protected Game Game;
		/// <summary>
		/// Gets the owner of the zone.
		/// </summary>
		/// <value><see cref="SabberStoneCore.Model.Entities.Controller"/></value>
		protected IList<T> Entities;

		protected Zone() { }

		protected Zone(Controller c)
		{
			Controller = c;
			Game = c.Game;
		}

		List<IPlayable> IZone.GetAll => this.Cast<IPlayable>().ToList();
		public Controller Controller { get; set; }
		public Zone Type { get; protected set; }
		/// <summary>
		/// Gets a value indicating whether this contains entities or not.
		/// </summary>
		/// <value><c>true</c> if this zone is empty; otherwise, <c>false</c>.</value>
		//public bool IsEmpty => Entities[0] == null;
		public bool IsEmpty => Count == 0;
		/// <inheritdoc />
		/// <summary>
		/// Get the number of entities in this zone.
		/// </summary>
		public abstract int Count { get; }
		public abstract bool IsFull { get; }
		/// <summary>
		/// Gets a random entity in this zone.
		/// </summary>
		public T Random => Count == 0 ? (default) : Entities[Util.Random.Next(Count)];
		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The zero-based position inside the zone.</param>
		/// <returns></returns>
		public T this[int zonePosition] => Entities[zonePosition];

		public abstract void Add(IPlayable entity, int zonePosition = -1);

		public abstract IPlayable Remove(IPlayable entity);
		/// <summary>
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		public abstract void MoveTo(T entity, int zonePosition = -1);
		/// <summary>
		/// Swaps the positions of both entities in this zone.
		/// Both entities must be contained by this zone.
		/// </summary>
		/// <param name="oldEntity">The one entity.</param>
		/// <param name="newEntity">The other entity.</param>
		public void Swap(T oldEntity, T newEntity)
		{
			if (oldEntity.Zone.Type != newEntity.Zone.Type)
				throw new ZoneException("Swap not possible because of zone missmatch");

			int oldPos = oldEntity.ZonePosition;
			int newPos = newEntity.ZonePosition;
			newEntity.ZonePosition = oldPos;
			oldEntity.ZonePosition = newPos;
			Entities[newPos] = oldEntity;
			Entities[oldPos] = newEntity;
		}
		/// <summary>
		/// Returns TRUE if at least one of entities
		///	in this Zone satisfies the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public bool Any(Func<T, bool> predicate)
		{
			IList<T> entities = Entities;
			for (int i = 0; i < Count; i++)
				if (predicate(entities[i]))
					return true;
			return false;
		}

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
			//str.Append($"[ENCH {Enchants.Count}]");
			//str.Append($"[TRIG {Triggers.Count}]");
			return str.ToString();
		}
	}

	/// <summary>
	/// Base implementation of <see cref="GraveyardZone"/> and <see cref="SetasideZone"/>.
	/// This kind of zones never be full.
	/// </summary>
	public abstract class UnlimitedZone : Zone<IPlayable>
	{
		public override int Count => Entities.Count;
		public override bool IsFull => false;

		protected UnlimitedZone(Controller controller)
		{
			Entities = new List<IPlayable>();
			Game = controller.Game;
			Controller = controller;
		}

		protected UnlimitedZone(Controller c, UnlimitedZone zone) : base(c)
		{
			var entities = new List<IPlayable>(zone.Count);
			IList<IPlayable> src = zone.Entities;
			for (int i = 0; i < src.Count; ++i)
			{
				IPlayable copy = src[i].Clone(c);
				copy.Zone = this;
				entities.Add(copy);
			}
			Entities = entities;
		}

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

			Entities.Remove(entity);

			return entity;
		}

		public override void MoveTo(IPlayable entity, int zonePosition)
		{
			Entities.Add(entity);
			entity.Zone = this;
			entity[GameTag.ZONE] = (int) Type;
		}

		public override IEnumerator<IPlayable> GetEnumerator()
		{
			return Entities.GetEnumerator();
		}
	}

	/// <summary>
	/// Base implementation of zones which have a maximum size.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class LimitedZone<T> : Zone<T> where T: IPlayable
	{
		protected int _count;

		protected LimitedZone(int size)
		{
			MaxSize = size;
			Entities = new T[MaxSize];
		}
		protected LimitedZone(Controller c, LimitedZone<T> zone) : base(c)
		{
			_count = zone._count;
			MaxSize = zone.MaxSize;
			var entities = new T[MaxSize];
			T[] src = (T[])zone.Entities;
			for (int i = 0; i < _count; ++i)
			{
				T copy = (T)src[i].Clone(c);
				copy.Zone = this;
				entities[i] = copy;
			}
			Entities = entities;
		}

		/// <summary>
		/// Gets the maximum amount of entities this zone can hold.
		/// </summary>
		/// <value>The maximum size.</value>
		public int MaxSize { get; protected set; }

		/// <summary>
		/// Gets a value indicating whether this zone is full.
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		public override bool IsFull => _count == MaxSize;

		public override int Count => _count;

		public int FreeSpace => MaxSize - _count;

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");
			if (entity.Controller != Controller)
				throw new ZoneException("Can't add an opponent's entity to own Zones");

			MoveTo((T)entity, zonePosition < 0 ? _count : zonePosition);

			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");
		}

		public override void MoveTo(T entity, int zonePosition = -1)
		{
			if (entity == null)
				throw new ZoneException();
			if (IsFull)
				throw new ZoneException();

			if (zonePosition < 0)
				zonePosition = _count;

			if (zonePosition == _count)
				Entities[zonePosition] = entity;
			else
			{
				T[] entities = (T[])Entities;
				for (int i = _count - 1; i >= zonePosition; --i)
					entities[i + 1] = entities[i];
				entities[zonePosition] = entity;
			}

			_count++;

			entity.Zone = this;
			entity[GameTag.ZONE] = (int)Type;
		}

		public override IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			T[] entities = (T[])Entities;
			int pos;
			for (pos = _count - 1; pos >= 0; --pos)
				if (ReferenceEquals(entities[pos], entity)) break;

			if (pos < --_count)
				Array.Copy(entities, pos + 1, entities, pos, _count - pos);

			entity.Zone = null;

			entity.ActivatedTrigger?.Remove();

			return entity;
		}

		public virtual T[] GetAll()
		{
			T[] array = new T[_count];
			Array.Copy((Array) Entities, array, _count);
			return array;
		}

		public virtual T[] GetAll(Func<T, bool> predicate)
		{
			T[] buffer = new T[_count];
			int i = 0;
			T[] entities = (T[])Entities;
			for (int k = 0; k < _count; ++k)
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

		internal virtual void CopyTo(Array destination, int index)
		{
			Array.Copy((Array)Entities, 0, destination, index, _count);
		}

		public void ForEach(Action<T> action)
		{
			T[] entities = (T[])Entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i]);
		}

		public void ForEach<T2>(Action<T, T2> action, T2 arg2)
		{
			T[] entities = (T[])Entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i], arg2);
		}

		public void ForEach<T2, T3>(Action<T, T2, T3> action, T2 arg2, T3 arg3)
		{
			T[] entities = (T[])Entities;
			for (int i = 0; i < _count; ++i)
				action(entities[i], arg2, arg3);
		}

		public override IEnumerator<T> GetEnumerator()
		{
			T[] entities = (T[])Entities;
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
		protected PositioningZone(int size) : base(size) { }
		protected PositioningZone(Controller c, PositioningZone<T> zone) : base(c, zone) { }

		public readonly List<Aura> Auras = new List<Aura>();

		private void Reposition(int zonePosition = 0)
		{
			if (zonePosition < 0)
				zonePosition = _count - 1;

			T[] entities = (T[])Entities;
			for (int i = _count - 1; i >= zonePosition; --i)
				entities[i].ZonePosition = i;

			for (int i = 0; i < Auras.Count; i++)
				Auras[i].ToBeUpdated = true;
		}

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			Reposition(zonePosition);
		}

		public override IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos;
			T[] entities = (T[])Entities;
			for (pos = _count - 1; pos >= 0; --pos)
				if (ReferenceEquals(entities[pos], entity)) break;

			if (pos < --_count)
				Array.Copy(entities, pos + 1, entities, pos, _count - pos);

			Reposition(pos);

			entity.Zone = null;

			entity.ActivatedTrigger?.Remove();
			for (int j = 0; j < Auras.Count; j++)
				Auras[j].EntityRemoved(entity);

			return entity;
		}
	}
}
