using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class ControlledZones : IReadOnlyModelCollection<IZone>
	{
		public Game Game { get; }

		public Controller Controller { get; }

		private readonly IZone[] _zones = new IZone[Enum.GetNames(typeof(Zone)).Length];

		public int Count => _zones.Length;

		public ControlledZones(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
		}

		public IZone this[Zone zone]
		{
			get
			{
				IZone result = _zones[(int)zone];

				if (result != null)
				{
					return result;
				}

				switch (zone)
				{
					case Zone.INVALID:
						result = null;
						break;
					case Zone.GRAVEYARD:
						result = new GraveyardZone(Game, Controller);
						break;
					case Zone.PLAY:
						result = new BoardZone(Game, Controller);
						break;
					case Zone.DECK:
						result = new DeckZone(Game, Controller);
						break;
					case Zone.HAND:
						result = new HandZone(Game, Controller);
						break;
					case Zone.SETASIDE:
						result = new SetasideZone(Game, Controller);
						break;
					case Zone.SECRET:
						result = new SecretZone(Game, Controller);
						break;
					case Zone.REMOVEDFROMGAME:
						break;
					default:
						throw new ZoneException("No such zone type when creating zone: " + zone);
				}

				_zones[(int)zone] = result;

				return result;
			}
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public string ToHash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			foreach (IZone zone in _zones)
			{
				if (zone != null)
					str.Append(zone.ToHash(ignore));
			}
			return str.ToString();
		}

		public void Stamp(IModel other)
		{
			ControlledZones zones = other as ControlledZones ?? throw new InvalidOperationException("other's type is wrong");

			// setaside need to be cloned first for references like choose one cards ...
			var zoneEnums = new List<Zone> {
				Zone.SETASIDE,
				Zone.PLAY,
				Zone.DECK,
				Zone.HAND,
				Zone.GRAVEYARD,
				Zone.SECRET,
				Zone.REMOVEDFROMGAME
			};
			zoneEnums.ForEach(p =>
			{
				IZone zone = zones[p];
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

		IModel IModel.Clone(Game newGame)
		{
			// Delegate to more type specific method.
			return Clone(newGame);
		}

		public IReadOnlyModelCollection<IZone> Clone(Game newGame)
		{
			var clone = new ControlledZones(newGame, Controller.ClonedFrom(newGame));
			for (int i = 0; i < _zones.Length; ++i)
			{
				// Zone could be null!
				// TODO; FIX this by always initializing ALL zones at construction.
				clone._zones[i] = _zones[i]?.Clone(newGame) as IZone;
			}

			return clone;
		}

		public IEnumerator<IZone> GetEnumerator()
		{
			return ((IEnumerable<IZone>)_zones).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _zones.GetEnumerator();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
