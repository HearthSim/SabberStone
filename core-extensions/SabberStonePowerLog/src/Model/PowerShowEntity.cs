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
using System.Text;

namespace SabberStonePowerLog.Model
{
	internal class PowerShowEntity : PowerHistoryEntry
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string Zone { get; set; }
		public string ZonePos { get; set; }
		public string PlayerId { get; set; }
		public string CardId { get; set; }

		public override void Process(PowerGame powerGame)
		{
			powerGame.Entities[Id].Change("CARD_ID", CardId);
		}

		public override string ToString()
		{
			var str = new StringBuilder();
			str.Append($"{GetType().Name}:");
			str.Append($"Name[{Name}]");
			str.Append($"ZonePos[{ZonePos}]");
			str.Append($"PlayerId[{PlayerId}]");
			str.Append($"CardId[{CardId}]");
			return str.ToString();
		}
	}
}
