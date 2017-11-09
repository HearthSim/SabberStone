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
		/// <value><see cref="Entities.Controller"/></value>
		protected Controller Controller;

		protected IList<T> _entities;

		protected int _count;

		public Zone Type { get; set; }

		/// <summary>
		/// Gets the maximum amount of entities this zone can hold.
		/// </summary>
		/// <value>The maximum size.</value>
		public int MaxSize { get; protected set; }

		/// <summary>
		/// Gets a value indicating whether this zone is full. <seealso cref="MaxSize"/>
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		public abstract bool IsFull { get; }

		/// <summary>
		/// Gets a value indicating whether this contains entities or not.
		/// </summary>
		/// <value><c>true</c> if this zone is empty; otherwise, <c>false</c>.</value>
		public bool IsEmpty => _entities[0] == null;

		/// <summary>
		/// Get the number of entities in this zone.
		/// </summary>
		public int Count => _count;

		public List<Enchant> Enchants { get; } = new List<Enchant>();

		public List<Trigger> Triggers { get; } = new List<Trigger>();

		public List<IPlayable> GetAll => this.Cast<IPlayable>().ToList();

		/// <summary>
		/// Gets a random entity in this zone.
		/// </summary>
		public T Random => _entities[Util.Random.Next(_count)];

		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The position inside the zone.</param>
		/// <returns></returns>
		public T this[int zonePosition] => _entities[zonePosition];

		public abstract void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true);

		public IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos = entity.ZonePosition;
			_entities[pos] = default(T);

			int i;
			for (i = pos; i < _count - 1; i++)
				_entities[i] = _entities[i + 1];

			_entities[i] = default(T);

			_count--;

			Reposition(pos);
			entity.Zone = null;

			return entity;
		}

		public IPlayable Replace(IPlayable oldEntity, IPlayable newEntity)
		{
			int pos = oldEntity.ZonePosition;
			_entities[pos] = (T)newEntity;
			newEntity.ZonePosition = pos;
			newEntity.Zone = this;
			oldEntity.Zone = null;
			return oldEntity;
		}

		/// <summary>
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		public void MoveTo(T entity, int zonePosition)
		{
			if (_entities is Array)
			{
				if (zonePosition == _count)
					_entities[zonePosition] = entity;
				else
				{
					for (int i = _count - 1; i >= zonePosition; --i)
						_entities[i + 1] = _entities[i];
					_entities[zonePosition] = entity;
				}
			}
			else
				_entities.Insert(zonePosition, entity);

			_count++;

			entity.Zone = this;
			Reposition(zonePosition);
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
				throw new ZoneException("Swap not possible because of zone missmatch");

			int oldPos = oldEntity.ZonePosition;
			int newPos = newEntity.ZonePosition;
			newEntity.ZonePosition = oldPos;
			oldEntity.ZonePosition = newPos;
			_entities[newPos] = oldEntity;
			_entities[oldPos] = newEntity;
		}

		void Reposition(int zonePosition = 0)
		{
			for (int i = _count - 1; i >= zonePosition; --i)
				_entities[i].ZonePosition = i;
		}

		/// <summary>
		/// Returns TRUE if at least one of entities
		///	in this Zone satisfies the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public bool Any(Func<T, bool> predicate)
		{
			for (int i = 0; i < _count; i++)
			{
				if (predicate(_entities[i]))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Copy data from the specified zone into this one.
		/// </summary>
		/// <param name="zone">The other zone object.</param>
		public void Stamp(Zone<T> zone)
		{
			foreach (T p in zone)
			{
				var copy = (T)Entity.FromCard(Controller, p.Card, null, null, p.Id);
				copy.Stamp(p as Entity);
				MoveTo(copy, copy.ZonePosition);
			};
			zone.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner, p.RemoveTriggers)));
			zone.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
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
			str.Append($"][EN:{Enchants.Count}");
			Enchants.ForEach(p => str.Append(p.Hash));
			str.Append($"][TR:{Triggers.Count}");
			Triggers.ForEach(p => str.Append(p.Hash));
			str.Append("]");
			return str.ToString();
		}

		public override string ToString()
		{
			return $"[ZONE {Type} '{Controller.Name}']";
		}

		public virtual IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < _count; i++)
				yield return _entities[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public string FullPrint()
		{
			var str = new StringBuilder();
			str.Append($"{this}|");
			foreach (IPlayable p in this)
			{
				var m = p as Minion;
				var w = p as Weapon;
				string mStr = m != null ? $"[{m.AttackDamage}/{m.Health}]" : (w != null ? $"[{w.AttackDamage}/{w.Durability}]" : "");
				str.Append($"[P{p.ZonePosition}]{mStr}[C{p.Cost}]{p}|");
			}
			str.Append($"[ENCH {Enchants.Count}]");
			str.Append($"[TRIG {Triggers.Count}]");
			return str.ToString();
		}
	}
}
