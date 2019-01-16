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

namespace SabberStonePowerLog.Model
{
	internal class PowerHideEntity : PowerHistoryEntry
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string Zone { get; set; }
		public string ZonePos { get; set; }
		public string CardId { get; set; }
		public string PlayerId { get; set; }
		public string Tag { get; set; }
		public string Value { get; set; }

		public override void Process(PowerGame powerGame)
		{
			throw new NotImplementedException();
		}
	}
}
