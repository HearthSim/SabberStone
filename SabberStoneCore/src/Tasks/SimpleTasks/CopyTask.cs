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
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class CopyTask : SimpleTask
	{
		private readonly Zone _zoneType;

		public CopyTask(EntityType type, int amount, bool opposite = false, Zone zoneType = Zone.INVALID)
		{
			Type = type;
			Amount = amount;
			Opposite = opposite;
			_zoneType = zoneType;
		}

		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public bool Opposite { get; set; }

		public override TaskState Process()
		{
			var result = new List<IPlayable>();
			switch (Type)
			{
				case EntityType.TARGET:
					var target = Target as IPlayable;
					if (target == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Opposite ?
							Entity.FromCard(target.Controller.Opponent, Cards.FromId(target.Card.Id)) :
							Entity.FromCard(Controller, Cards.FromId(target.Card.Id)));
					}
					break;
				case EntityType.SOURCE:
					var source = Source as IPlayable;
					if (source == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Opposite ?
							Entity.FromCard(source.Controller.Opponent, Cards.FromId(source.Card.Id)) :
							Entity.FromCard(Controller, Cards.FromId(source.Card.Id)));
					}
					break;
				case EntityType.STACK:
					if (Playables.Count < 1)
					{
						return TaskState.STOP;
					}
					IZone zone = Opposite ? Controller.Opponent.ControlledZones[_zoneType] : Controller.ControlledZones[_zoneType];
					foreach (IPlayable p in Playables)
					{
						if (zone?.IsFull ?? false)
							break;
						for (int i = 0; i < Amount; i++)
						{
							if (zone?.IsFull ?? false)
								break;
							// TODO
							result.Add(Opposite ?
								Entity.FromCard(p.Controller.Opponent, Cards.FromId(p.Card.Id), null, zone) :
								Entity.FromCard(Controller, Cards.FromId(p.Card.Id), null, zone));
						}
					}
					break;
				case EntityType.EVENT_SOURCE:
					IPlayable eSource = Game.CurrentEventData?.EventSource;
					if (eSource == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Opposite ?
							Entity.FromCard(eSource.Controller.Opponent, Cards.FromId(eSource.Card.Id)) :
							Entity.FromCard(Controller, Cards.FromId(eSource.Card.Id)));
					}
					break;
				case EntityType.OP_HERO_POWER:
					result.Add(Entity.FromCard(Controller, Cards.FromId(Controller.Opponent.Hero.HeroPower.Card.Id)));
					break;
				case EntityType.WEAPON:
					var weapon = Controller.Hero.Weapon as Weapon;
					if (weapon == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Entity.FromCard(Controller, Cards.FromId(weapon.Card.Id)));
					}
					break;
				default:
					throw new NotImplementedException();
			}

			Playables = result;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new CopyTask(Type, Amount, Opposite, _zoneType);
			clone.Copy(this);
			return clone;
		}
	}
}
