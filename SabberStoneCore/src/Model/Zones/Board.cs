//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//using SabberStoneCore.Enchants;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Exceptions;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Model.Zones
//{
//	partial class Board : IZone
//	{
//		Zone IZone.Type => Zone.PLAY;

//		int IZone.Count => _count;

//		bool IZone.IsFull => throw new NotImplementedException();

//		List<IPlayable> IZone.GetAll => throw new NotImplementedException();

//		void IZone.Add(IPlayable entity, int zonePosition)
//		{
//			throw new NotImplementedException();
//		}

//		string IZone.Hash(params GameTag[] ignore)
//		{
//			throw new NotImplementedException();
//		}

//		IPlayable IZone.Remove(IPlayable entity)
//		{
//			throw new NotImplementedException();
//		}

//		public const int MaxSize = 7;

//		private readonly int _p;
//		private int _count;
//		private int _untouchableCount;
//		private readonly Memory<Minion> _memory;

//		public readonly Game Game;
//		public readonly Controller Controller;
//		public readonly List<Aura> Auras = new List<Aura>();

//		public bool IsFull => _count == MaxSize;
//		public int CountExceptUntouchables => _count - _untouchableCount;
//		public bool DoesHaveUntouchables { get; private set; }
//		public Minion this[int zonePosition] => (Minion)Entities[zonePosition];

//		private Span<Minion> Entities => _memory.Span;

//		internal Board(in Controller c)
//		{
//			Game = c.Game;
//			Controller = c;

//			int p = c.PlayerId == 1 ? 1 : 1 + MaxSize;
//			_memory = new Memory<Minion>((Minion[])c.Game.AllCharacters, p, MaxSize);
//			_p = p;
//		}

//		public void Add(in Minion entity, int zonePosition = -1)
//		{
//			if (entity == null)
//				throw new ArgumentNullException();
//			if (IsFull)
//				throw new ZoneException($"Can't Add {entity}. Board is already Full");

//			int c = _count;

//			if (zonePosition > c)
//				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");
//			if (entity.Controller != Controller)
//				throw new ZoneException("Can't add an opponent's entity to own Zones");

//			if (zonePosition < 0)
//				zonePosition = c;

//			Span<Minion> entities = Entities;
//			if (zonePosition == c)
//				entities[c] = entity;
//			else
//			{
//				for (int i = c - 1; i >= zonePosition; --i)
//					entities[i + 1] = entities[i];
//				entities[zonePosition] = entity;
//			}

//			_count = c + 1;

//			entity.Zone = this;
//			entity[GameTag.ZONE] = 1;

//			Reposition(zonePosition);


//			if (entity[GameTag.CHARGE] != 1)
//			{
//				if (entity[GameTag.RUSH] == 1)
//				{
//					var m = entity as Minion;
//					m.AttackableByRush = true;
//					Game.RushMinions.Add(m.Id);
//				}
//				else
//					entity.IsExhausted = true;
//			}

//			if (entity[GameTag.GHOSTLY] == 1)
//				entity[GameTag.GHOSTLY] = 0;

//			entity.OrderOfPlay = Game.NextOop;

//			ActivateAura(entity);

//			Game.TriggerManager.OnZoneTrigger(entity);

//			if (entity.Card.Untouchable)
//			{
//				++_untouchableCount;
//				DoesHaveUntouchables = true;
//			}
//		}

//		public Minion Remove(in Minion entity)
//		{
//			if (entity.Zone == null || entity.Zone.Type != Zone.PLAY)
//				throw new ZoneException("Couldn't remove entity from zone.");

//			RemoveAura(entity);
//			if (entity.Card.Untouchable && --_untouchableCount == 0)
//				DoesHaveUntouchables = false;

//			Span<Minion> entities = Entities;

//			int pos;
//			int count = _count;
//			for (pos = count - 1; pos >= 0; --pos)
//				if (ReferenceEquals(entities[pos], entity)) break;

//			count--;
//			if (pos < count)
//			{
//				for (int i = pos; i < count; i++)
//				{
//					entities[i] = entities[i + 1];
//				}
//			}

//			_count = count;

//			Reposition(pos);

//			entity.Zone = null;

//			entity.ActivatedTrigger?.Remove();
//			foreach (Aura aura in Auras)
//				aura.EntityRemoved(entity);

//			return entity;
//		}

//		public void Replace(Minion oldEntity, Minion newEntity)
//		{
//			int pos = oldEntity.ZonePosition;
//			Entities[pos] = newEntity;
//			newEntity.ZonePosition = pos;
//			newEntity[GameTag.ZONE] = 1;
//			newEntity.Zone = this;

//			// Remove old Entity
//			RemoveAura(oldEntity);
//			Auras.ForEach(p => p.EntityRemoved(oldEntity));
//			oldEntity.ActivatedTrigger?.Remove();
//			if (oldEntity.Card.Untouchable && --_untouchableCount == 0)
//				DoesHaveUntouchables = false;

//			Controller.SetasideZone.Add(oldEntity);

//			// Add new Entity
//			newEntity.OrderOfPlay = Game.NextOop;
//			ActivateAura(newEntity);
//			if (newEntity.Card.Untouchable)
//			{
//				++_untouchableCount;
//				DoesHaveUntouchables = true;
//			}

//			Auras.ForEach(p => p.ToBeUpdated = true);
//		}

//		private void Reposition(int zonePosition = 0)
//		{
//			if (zonePosition < 0)
//				zonePosition = _count - 1;

//			Span<Minion> entities = Entities;
//			for (int i = _count - 1; i >= zonePosition; --i)
//				entities[i].ZonePosition = i;

//			foreach (Aura aura in Auras)
//				aura.ToBeUpdated = true;
//		}

//		private static void ActivateAura(Minion entity)
//		{
//			entity.Power?.Trigger?.Activate(entity);
//			entity.Power?.Aura?.Activate(entity);

//			if (entity.Card[GameTag.SPELLPOWER] > 0)
//				entity.Controller.CurrentSpellPower += entity.Card.Tags[GameTag.SPELLPOWER];
//		}

//		private static void RemoveAura(IPlayable entity)
//		{
//			entity.OngoingEffect?.Remove();
//			int csp = entity.Controller.CurrentSpellPower;
//			if (csp > 0)
//			{
//				int sp = entity[GameTag.SPELLPOWER];
//				if (sp > 0)
//					entity.Controller.CurrentSpellPower = csp - sp;
//			}
//		}

//		public Minion[] ToArray()
//		{
//			if (!DoesHaveUntouchables)
//				return _memory.ToArray();

//		}

//		public IEnumerator GetEnumerator()
//		{

//		}

//		public IEnumerable<Minion> GetAll(Predicate<Minion> predicate)
//		{
//			Span<Minion> entities = Entities;
//			int count = _count;
//			for (int i = 0; i < count; i++)
//			{
//				if (!entities[i].Untouchable)
//					if (predicate != null && predicate())
//			}
//		}

//		private class Enumerator : IEnumerator<Minion>
//		{
//			Minion IEnumerator<Minion>.Current => throw new NotImplementedException();

//			object IEnumerator.Current => throw new NotImplementedException();

//			bool IEnumerator.MoveNext()
//			{
//				throw new NotImplementedException();
//			}

//			void IEnumerator.Reset()
//			{
//				throw new NotImplementedException();
//			}

//			#region IDisposable Support
//			private bool disposedValue = false; // To detect redundant calls

//			protected virtual void Dispose(bool disposing)
//			{
//				if (!disposedValue)
//				{
//					if (disposing)
//					{
//						// TODO: dispose managed state (managed objects).
//					}

//					// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
//					// TODO: set large fields to null.

//					disposedValue = true;
//				}
//			}

//			// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
//			// ~Enumerator() {
//			//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//			//   Dispose(false);
//			// }

//			// This code added to correctly implement the disposable pattern.
//			void IDisposable.Dispose()
//			{
//				// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//				Dispose(true);
//				// TODO: uncomment the following line if the finalizer is overridden above.
//				// GC.SuppressFinalize(this);
//			}
//			#endregion

//		}
//	}

//	partial class Board
//	{
//		public void ForEach(Action<Minion> action)
//		{
//			Span<Minion> entities = Entities;
//			int count = _count;
//			for (int i = 0; i < count; i++)
//				action(entities[i]);
//		}
//	}
//}
