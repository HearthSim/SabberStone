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
using System.Text;

namespace SabberStonePowerLog.Model
{
	internal class PowerFullEntity : PowerHistoryEntry
	{
		public PowerEntity PowerEntity { get; set; }
		public PowerFullEntity()
		{
			PowerEntity = new PowerEntity();
		}

		public int Id
		{
			get { return int.Parse(PowerEntity.Id); }
			set { PowerEntity.Id = value.ToString(); }
		}

		public string CardId
		{
			get { return PowerEntity.GetValue("CARD_ID"); }
			set { PowerEntity.Add("CARD_ID", value); }
		}

		public override void Process(PowerGame powerGame)
		{
			if (powerGame.Entities.ContainsKey(Id))
			{
				throw new NotImplementedException("entity is already contained");
			}

			powerGame.Entities.Add(Id, PowerEntity);
		}

		public override string ToString()
		{
			var str = new StringBuilder();
			str.Append($"{GetType().Name}:");
			str.Append("Id[" + Id + "]");
			str.Append("CardId[" + CardId + "]");
			str.Append(PowerEntity.ToString());
			return str.ToString();
		}
	}
}
