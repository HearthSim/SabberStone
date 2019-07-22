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
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : LimitedZone<Spell>
	{
		public const int SecretZoneMaxSize = 5;

		/// <summary>
		/// An unique field for Quest.
		/// Gets or sets the quest in this SecretZone.
		/// null means absence.
		/// </summary>
		public Spell Quest { get; set; }

		public SecretZone(Controller controller) : base(Zone.SECRET, SecretZoneMaxSize)
		{
			Game = controller.Game;
			Controller = controller;
		}

		private SecretZone(Controller c, SecretZone zone) : base(c, zone)
		{
			Quest = (Spell) zone.Quest?.Clone(c);
		}

		public override bool IsFull => _count == SecretZoneMaxSize;

		public override void Add(Spell entity, int zonePosition = -1)
		{
			if (entity.Card.IsQuest)
			{
				if (Quest != null)
					throw new ZoneException($"Another quest is already in play");

				Quest = entity;
				entity[GameTag.ZONE] = (int)Type;
				entity.Zone = this;

				Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Quest {entity} has been added to zone '{Type}'.");

				entity.OrderOfPlay = Game.NextOop;

				return;
			}

			base.Add(entity, zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? ""
				: $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'."); 

			entity.OrderOfPlay = Game.NextOop;
		}

		public override void ChangeEntity(Spell oldEntity, Spell newEntity)
		{
			throw new NotImplementedException();
		}

		public override IEnumerator<Spell> GetEnumerator()
		{
			var entities = _entities;
			for (int i = 0; i < _count; i++)
				yield return entities[i];
			if (Quest != null)
				yield return Quest;
		}

		public SecretZone Clone(Controller c)
		{
			return new SecretZone(c, this);
		}
	}
}
