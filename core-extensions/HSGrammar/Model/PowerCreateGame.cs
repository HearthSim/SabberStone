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

namespace HSGrammar.Model
{
    class PowerCreateGame : PowerLogEntry
    {

        public PowerEntity GameEntity { get; set; }

        public PowerEntity Player1 { get; set; }

        public PowerEntity Player2 { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}: GameEntity={GameEntity} Player1={Player1} Player2={Player2}";
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
