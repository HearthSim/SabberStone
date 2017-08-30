﻿using System;
using System.Text;

namespace SabberStonePowerLog.Model
{
	public class PowerFullEntity : PowerHistoryEntry
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
