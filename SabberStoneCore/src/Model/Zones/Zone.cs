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
		protected Controller Controller;

		protected IList<T> Entities;

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

		public List<OldEnchant> Enchants { get; } = new List<OldEnchant>();

		public List<OldTrigger> Triggers { get; } = new List<OldTrigger>();

		public List<IPlayable> GetAll => this.Cast<IPlayable>().ToList();

		/// <summary>
		/// Gets a random entity in this zone.
		/// </summary>
		public T Random => Entities[Util.Random.Next(Count)];

		/// <summary>
		/// Gets the <see cref="IPlayable"/> with the specified zone position.
		/// </summary>
		/// <value>The <see cref="IPlayable"/>.</value>
		/// <param name="zonePosition">The position inside the zone.</param>
		/// <returns></returns>
		public T this[int zonePosition] => Entities[zonePosition];

		public abstract void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true);

		public abstract IPlayable Remove(IPlayable entity);

		/// <summary>
		/// Moves the specified entity to a new position.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="zonePosition">The zone position.</param>
		public abstract void MoveTo(T entity, int zonePosition);

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
			for (int i = 0; i < Count; i++)
			{
				if (predicate(Entities[i]))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Copy data from the specified zone into this one.
		/// </summary>
		/// <param name="zone">The other zone object.</param>
		public abstract void Stamp(Zone<T> zone);

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
			str.Append($"[ENCH {Enchants.Count}]");
			str.Append($"[TRIG {Triggers.Count}]");
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

		protected UnlimitedZone(Controller controller)
		{
			Entities = new List<IPlayable>();
			Game = controller.Game;
			Controller = controller;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
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
			((Entity) entity).SetNativeGameTag(GameTag.ZONE, (int) Type);
		}

		public override void Stamp(Zone<IPlayable> zone)
		{
			foreach (IPlayable p in zone)
			{
				IPlayable copy = p.Clone(Controller);
				Entities.Add(copy);
				copy.Zone = this;
			}

			zone.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner, p.RemoveTriggers)));
			zone.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
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
		/// <summary>
		/// Gets the maximum amount of entities this zone can hold.
		/// </summary>
		/// <value>The maximum size.</value>
		public int MaxSize { get; protected set; }

		/// <summary>
		/// Gets a value indicating whether this zone is full.
		/// </summary>
		/// <value><c>true</c> if this zone reach the maximum amount of entities; otherwise, <c>false</c>.</value>
		public bool IsFull => _count == MaxSize;

		public override int Count => _count;

		protected int _count;


		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo((T)entity, zonePosition < 0 ? _count : zonePosition);

			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");
		}

		public override void MoveTo(T entity, int zonePosition = -1)
		{
			if (entity == null)
				throw new ZoneException();

			if (zonePosition < 0)
				zonePosition = _count;

			if (zonePosition == _count)
				Entities[zonePosition] = entity;
			else
			{
				for (int i = _count - 1; i >= zonePosition; --i)
					Entities[i + 1] = Entities[i];
				Entities[zonePosition] = entity;
			}

			_count++;

			entity.Zone = this;
			((Entity)(IPlayable)entity).SetNativeGameTag(GameTag.ZONE, (int)Type);
		}

		public override IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos = Array.IndexOf((Array)Entities, entity);
			Entities[pos] = default(T);

			int i;
			for (i = pos; i < _count - 1; i++)
				Entities[i] = Entities[i + 1];

			Entities[i] = default(T);

			_count--;

			entity.Zone = null;

			entity.ActivatedTriggers.Clear();

			return entity;
		}

		public override void Stamp(Zone<T> zone)
		{
			foreach (T entity in zone)
			{
				var copy = (T) entity.Clone(Controller);
				copy.Zone = this;
				Entities[_count] = copy;
				_count++;
			}

			zone.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner, p.RemoveTriggers)));
			zone.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
		}

		public override IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < _count; i++)
				yield return Entities[i];
		}
	}

	/// <summary>
	/// Base implementation of zones performing strict recalculation of its containing entities' ZonePosition when any member comes and goes.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class PositioningZone<T> : LimitedZone<T> where T : IPlayable
	{
		public readonly List<Aura> Auras = new List<Aura>();

		private void Reposition(int zonePosition = 0)
		{
			if (zonePosition < 0)
				zonePosition = _count - 1;

			for (int i = _count - 1; i >= zonePosition; --i)
				Entities[i].ZonePosition = i;

			for (int i = 0; i < Auras.Count; i++)
				Auras[i].ToBeUpdated = true;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			base.Add(entity, zonePosition, applyPowers);

			Reposition(zonePosition);
		}

		public override IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos = entity.ZonePosition;
			Entities[pos] = default(T);

			int i;
			for (i = pos; i < _count - 1; i++)
				Entities[i] = Entities[i + 1];

			Entities[i] = default(T);

			_count--;

			Reposition(pos);
			//entity.ZonePosition = 0;
			entity.Zone = null;

			entity.ActivatedTriggers.Clear();

			return entity;
		}
	}
}
