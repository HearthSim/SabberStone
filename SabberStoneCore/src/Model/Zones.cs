using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;

namespace SabberStoneCore.Model
{
    public class Zones : IEnumerable<IZone>
    {
        public Game Game { get; }

        public Controller Controller { get; }

        private readonly IZone[] _zones = new IZone[Enum.GetNames(typeof(EZone)).Length];

        public Zones(Game game, Controller controller)
        {
            Game = game;
            Controller = controller;
        }

        public void Stamp(Zones zones)
        {
            // setaside need to be cloned first for references like choose one cards ...
            List<EZone> zoneEnums = new List<EZone> {
                EZone.SETASIDE,
                EZone.PLAY,
                EZone.DECK,
                EZone.HAND,
                EZone.GRAVEYARD,
                EZone.SECRET,
                EZone.REMOVEDFROMGAME
            };
            zoneEnums.ForEach(p => {
                var zone = zones[p];
                if (zone != null)
                    this[p].Stamp(zone);
            });

            //foreach (Zone value in Enum.GetValues(typeof(Zone)))
            //{
            //    if (value == Zone.INVALID)
            //        continue;

            //    var zone = zones[value];
            //    if (zone != null)
            //        this[value].Stamp(zone);
            //}
        }

        public string Hash(params EGameTag[] ignore)
        {
            var str = new StringBuilder();
            foreach (var zone in _zones)
            {
                if (zone != null)
                    str.Append(zone.Hash(ignore));
            }
            return str.ToString();
        }

        public IZone this[EZone zone]
        {
            get
            {
                var result = _zones[(int) zone];

                if (result != null)
                {
                    return result;
                }

                switch (zone)
                {
                    case EZone.INVALID:
                        result = null;
                        break;
                    case EZone.GRAVEYARD:
                        result = new Zone<IPlayable>(Game, Controller, zone);
                        break;
                    case EZone.PLAY:
                        result = new Zone<Minion>(Game, Controller, zone);
                        break;
                    case EZone.DECK:
                        result = new Deck(Game, Controller);
                        break;
                    case EZone.HAND:
                        result = new Hand(Game, Controller);
                        break;
                    case EZone.REMOVEDFROMGAME:
                        break;
                    case EZone.SETASIDE:
                        result = new Zone<IPlayable>(Game, Controller, zone);
                        break;
                    case EZone.SECRET:
                        result = new Zone<Spell>(Game, Controller, zone);
                        break;
                    default:
                        throw new ZoneException("No such zone type when creating zone: " + zone);
                }

                _zones[(int) zone] = result;

                return result;
            }
        }

        public IEnumerator<IZone> GetEnumerator()
        {
            return ((IEnumerable<IZone>) _zones).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _zones.GetEnumerator();
        }
    }
}