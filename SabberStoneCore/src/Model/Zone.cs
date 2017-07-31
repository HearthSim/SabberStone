using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model
{
    public interface IZone
    {
        int MaxSize { get; }
        bool IsFull { get; }
        bool IsEmpty { get; }
        int Count { get; }
        Controller Controller { get; }
        Zone Type { get; }
        IPlayable this[int zonePosition] { get; }
        List<IPlayable> GetAll { get; }
        IPlayable Add(IPlayable entity, int zonePosition = -1);
        IPlayable Remove(IPlayable entity);
        IPlayable Replace(IPlayable oldEntity, IPlayable newEntity);

        void MoveTo(IPlayable entity, int zonePosition);
        void Swap(IPlayable oldEntity, IPlayable newEntity);

        List<Enchant> Enchants { get; }
        List<Trigger> Triggers { get; }

        void Stamp(IZone zone);
        string Hash(params GameTag[] ignore);
    }

    public class Zone<T> : IZone, IEnumerable<T> where T : IPlayable
    {
        public Game Game { get; }

        public Controller Controller { get; }

        public Zone Type { get; }

        public int MaxSize => Type == Zone.PLAY
            ? Game.MaxMinionsOnBoard
            : (Type == Zone.HAND
                ? Controller.MaxHandSize
                : 9999);

        public bool IsFull => !(Count < MaxSize);

        public bool IsEmpty => Count == 0;

        public int Count => _entitiesAsList.Count;

        public T Random => Util<T>.Choose(_entitiesAsList);

        private readonly List<T> _entitiesAsList = new List<T>();

        public List<Enchant> Enchants { get; } = new List<Enchant>();

        public List<Trigger> Triggers { get; } = new List<Trigger>();

        public List<IPlayable> GetAll
        {
            get
            {
                var list = new List<IPlayable>();
                _entitiesAsList.ForEach(p => list.Add(p));
                return list;
            }
        }

        public Zone(Game game, Controller controller, Zone type)
        {
            Game = game;
            Controller = controller;
            Type = type;
            Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Zone", $"Created Zone {type} in Game with Controller {controller.Name}");
        }

        public void Stamp(IZone zone)
        {
            zone.GetAll.ToList().ForEach(p =>
            {
                var copy = Entity.FromCard(Controller, p.Card, null, null, p.Id);
                copy.Stamp(p as Entity);
                MoveTo(copy, copy.ZonePosition);
            });
            zone.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner, p.RemoveTriggers)));
            zone.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
        }

        public string Hash(params GameTag[] ignore)
        {
            var str = new StringBuilder();
            str.Append("[Z:");
            str.Append($"{Type}");
            str.Append("][E:");
            var list = GetAll;
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
            entity.ApplyEnchantments(EnchantmentActivation.SETASIDE, Zone.SETASIDE);
            entity.ApplyEnchantments(EnchantmentActivation.BOARD, Zone.PLAY);
            entity.ApplyEnchantments(EnchantmentActivation.HAND, Zone.HAND);
            entity.ApplyEnchantments(EnchantmentActivation.DECK, Zone.DECK);

            entity.SetOrderOfPlay(Type.ToString());
            return entity;
        }

        public IPlayable Remove(IPlayable entity)
        {
            if (!_entitiesAsList.Remove((T) entity))
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
            _entitiesAsList.Insert(zonePosition, (T) entity);
            entity.Zone = this;
            entity[GameTag.ZONE] = (int) Type;
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

            var oldPos = oldEntity.ZonePosition;
            var newPos = newEntity.ZonePosition;
            newEntity.ZonePosition = oldPos;
            oldEntity.ZonePosition = newPos;
            _entitiesAsList[newPos] = (T) oldEntity;
            _entitiesAsList[oldPos] = (T) newEntity;
        }

        private void RePosition(int zonePosition = 0)
        {
            for (var i = zonePosition; i < _entitiesAsList.Count; i++)
            {
                _entitiesAsList[i].ZonePosition = i;
            }
        }

        public override string ToString()
        {
            return $"[ZONE {Type} '{Controller.Name}']";
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _entitiesAsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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
    }
}