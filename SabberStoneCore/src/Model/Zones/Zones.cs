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
	public interface IZone
	{
		Zone Type { get; }
		int Count { get; set; }
		List<Enchant> Enchants { get; }
		List<Trigger> Triggers { get; }

		void Add(IPlayable entity, int zonePosition = -1 , bool applyEnchantment = true);
		IPlayable Remove(IPlayable entity);
		IPlayable Replace(IPlayable oldEntity, IPlayable newEntity);
		string Hash(params GameTag[] ignore);
	}

	public abstract class Zone<T> : IZone, IEnumerable<T> where T: IPlayable
	{
		public int MaxSize;

		public Game Game;

		public Controller Controller;

		protected IList<T> _entities;



		public Zone Type { get; set; }

		public abstract bool IsFull { get; }

		public abstract void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true);

		public bool IsEmpty => _entities[0] == null;

		public int Count { get; set; }

		public List<Enchant> Enchants { get; } = new List<Enchant>();

		public List<Trigger> Triggers { get; } = new List<Trigger>();

		public T Random => _entities[Util.Random.Next(Count)];

		public T this[int zonePosition] => _entities[zonePosition];



		public IPlayable Remove(IPlayable entity)
		{
			if (entity.Zone == null || entity.Zone.Type != Type)
				throw new ZoneException("Couldn't remove entity from zone.");

			int pos = entity.ZonePosition;
			_entities[pos] = default(T);

			for (int i = pos; i < Count - 1; i++)
				_entities[i] = _entities[i + 1];
			_entities[Count - 1] = default(T);

			Count--;

			Reposition(pos);
			entity.Zone = null;

			return entity;
		}

		public void MoveTo(T entity, int zonePosition)
		{
			if (_entities is Array)
			{
				if (zonePosition == Count)
					_entities[zonePosition] = entity;
				else
				{
					for (int i = Count - 1; i >= zonePosition; --i)
						_entities[i + 1] = _entities[i];
					_entities[zonePosition] = entity;
				}
			}
			else
				_entities.Insert(zonePosition, entity);

			Count++;

			entity.Zone = this;
			Reposition(zonePosition);
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
			for (int i = Count - 1; i >= zonePosition; --i)
				_entities[i].ZonePosition = i;
		}

		public bool Any(Func<T, bool> predicate)
		{
			for (int i = 0; i < Count; i++)
			{
				if (predicate(_entities[i]))
					return true;
			}
			return false;
		}

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
			for (int i = 0; i < Count; i++)
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

	public class BoardZone : Zone<Minion>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo((Minion)entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.BOARD_ZONE, Zone.PLAY);

			entity.OrderOfPlay = Game.NextOop;
		}

		public BoardZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = Game.MAX_MINIONS_ON_BOARD;
			_entities = new Minion[MaxSize];
			Type = Zone.PLAY;
		}
	}

	public class HandZone : Zone<IPlayable>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.HAND_ZONE, Zone.HAND);

		}

		public HandZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = Controller.MaxHandSize;
			_entities = new IPlayable[MaxSize];
			Type = Zone.HAND;
		}
	}

	public class DeckZone : Zone<IPlayable>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.DECK_ZONE, Zone.DECK);
		}

		public DeckZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = 60;
			_entities = new IPlayable[MaxSize];
			Type = Zone.DECK;
		}

		public int StartingCards { get; set; } = 30;

		public void Fill(List<string> excludeIds = null)
		{
			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
			int cardsToAdd = StartingCards - Count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
			while (cardsToAdd > 0)
			{
				Card card = Util.Choose<Card>(cards.ToList());

				// don't add cards that have to be excluded here.
				if (excludeIds != null && excludeIds.Contains(card.Id))
					continue;

				// don't add cards that have already reached max occurence in deck.
				if (this.Count(c => c.Card == card) >= card.MaxAllowedInDeck)
					continue;

				Controller.DeckCards.Add(card);

				Entity.FromCard(Controller, card, null, this);

				cardsToAdd--;
			}
		}

		public void Shuffle()
		{
			int n = Count;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Deck", !Game.Logging ? "" : $"{Controller.Name} shuffles its deck.");
			for (int i = 0; i < n; i++)
			{
				int r = i + Util.Random.Next(n - i);
				Swap(this[i], this[r]);
			}
		}
	}

	public class SetasideZone : Zone<IPlayable>
	{
		public override bool IsFull => false;

		public SetasideZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			_entities = new List<IPlayable>(1);
			Type = Zone.SETASIDE;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

		}
	}

	public class GraveyardZone : Zone<IPlayable>
	{
		public override bool IsFull => false;

		public GraveyardZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			_entities = new List<IPlayable>(1);
			Type = Zone.GRAVEYARD;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");
		}
	}

	public class SecretZone : Zone<Spell>
	{
		public Spell Quest
		{
			get => _entities[5];
			set => _entities[5] = value;
		}

		public override bool IsFull => _entities[MaxSize - 2] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (entity.Card[GameTag.QUEST] == 1)
			{
				if (Quest != null)
					throw new ZoneException($"Another quest is already in play");

				Quest = (Spell)entity;
				Quest.SetNativeGameTag(GameTag.ZONE, (int)Type);
				Quest.Zone = this;

				Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

				entity.OrderOfPlay = Game.NextOop;

				return;
			}

			if (zonePosition > Count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo((Spell)entity, zonePosition < 0 ? Count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			entity.OrderOfPlay = Game.NextOop;
		}

		public SecretZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = 6;
			_entities = new Spell[MaxSize];
			Type = Zone.SECRET;
		}

		public override IEnumerator<Spell> GetEnumerator()
		{
			if (Quest != null)
				yield return Quest;
			for (int i = 0; i < Count; i++)
				yield return _entities[i];
		}
	}

	public class ControlledZones
	{
		Game Game;
		Controller Controller;

		public ControlledZones(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			Controller.DeckZone = new DeckZone(Game, Controller);
			Controller.HandZone = new HandZone(Game, Controller);
			Controller.BoardZone = new BoardZone(Game, Controller);
			Controller.SecretZone = new SecretZone(Game, Controller);
			Controller.GraveyardZone = new GraveyardZone(Game, Controller);
			Controller.SetasideZone = new SetasideZone(Game, Controller);
		}

		public IZone this[Zone zone]
		{
			get
			{
				switch (zone)
				{
					case Zone.GRAVEYARD:
						return Controller.GraveyardZone;
					case Zone.PLAY:
						return Controller.BoardZone;
					case Zone.DECK:
						return Controller.DeckZone;
					case Zone.HAND:
						return Controller.HandZone;
					case Zone.SECRET:
						return Controller.SecretZone;
					case Zone.SETASIDE:
						return Controller.SetasideZone;
					case Zone.REMOVEDFROMGAME:
					case Zone.INVALID:
						return null;
					default:
						throw new ZoneException("No such zone type when creating zone: " + zone);
				}
			}
		}

		public string Hash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			foreach (Zone zone in Enum.GetValues(typeof(Zone)))
			{
				IZone temp = this[zone];
				if (temp != null)
					str.Append(temp.Hash(ignore));
			}
			return str.ToString();
		}
	}
}
