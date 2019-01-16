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
using System.Collections.Generic;
using System.Linq;

namespace HSGrammar.Model
{
    public class PowerGame
    {
        public Queue<PowerLogEntry> Entries;

        public List<PowerEntity> Entities;

        public PowerGame()
        {
            Entries = new Queue<PowerLogEntry>();
        }

        public PowerEntity GetEntityById(int id)
        {
            IEnumerable<PowerEntity> enumerable = null;
            if ((enumerable = Entities.Where(p => p.EntityId == id)).Any() && enumerable.Count() == 1)
            {
                return enumerable.First();
            }
            else
            {
                throw new KeyNotFoundException($"Haven't found id '{id}' in entities of powergame!");
            }
        }
    }
}
