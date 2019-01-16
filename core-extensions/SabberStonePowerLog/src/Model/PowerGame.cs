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

namespace SabberStonePowerLog.Model
{
	public class PowerGame
	{
		public Queue<PowerHistoryEntry> PowerHistory { get; set; }

		public GameEntity Game
		{
			get
			{
				PowerEntity value;
				if (Entities.TryGetValue(1, out value))
				{
					return value as GameEntity;
				}
				return null;
			}
			set { Entities.Add(1, value); }
		}

		public Player Player1
		{
			get
			{
				PowerEntity value;
				if (Entities.TryGetValue(2, out value))
				{
					return value as Player;
				}
				return null;
			}
			set { Entities.Add(2, value); }
		}

		public Player Player2
		{
			get
			{
				PowerEntity value;
				if (Entities.TryGetValue(3, out value))
				{
					return value as Player;
				}
				return null;
			}
			set { Entities.Add(3, value); }
		}

		public Dictionary<int, PowerEntity> Entities { get; set; }

		public int LastFullEntityId { get; set; }

		public void AddFullEntity(int id, PowerEntity entity)
		{
			LastFullEntityId = id;
			Entities.Add(id, entity);
		}

		public PowerGame()
		{
			Entities = new Dictionary<int, PowerEntity>();
			PowerHistory = new Queue<PowerHistoryEntry>();
		}


		public PowerEntity GetEntityById(int id)
		{
			return Entities[id];
		}

		public int GetIdByName(string name)
		{
			if (Game.Name == name)
			{
				return 1;
			}
			else if (Player1.Name == name)
			{
				return 2;
			}
			else if (Player2.Name == name)
			{
				return 3;
			}
			else
			{
				throw new Exception("Unknown name, haven't found in entities.");
			}
		}

	}
}
