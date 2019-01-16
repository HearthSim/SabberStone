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
using SabberStoneCore.Enums;
using System.Text;

namespace SabberStonePowerLog.Model
{
	internal class PowerTagChange : PowerHistoryEntry
	{
		public PowerTagChange()
		{
			PowerType = PowerType.TAG_CHANGE;
		}

		public int Id { get; internal set; }
		public string Tag { get; internal set; }
		public string Value { get; internal set; }

		public override void Process(PowerGame powerGame)
		{
			powerGame.Entities[Id].Change(Tag, Value);
		}

		public override string ToString()
		{
			var str = new StringBuilder();
			str.Append($"{GetType().Name}:");
			str.Append($"Id[{Id}]");
			str.Append($"Tag[{Tag}]");
			str.Append($"Value[{Value}]");
			return str.ToString();
		}
	}
}
