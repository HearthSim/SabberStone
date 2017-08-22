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
			str.Append("Id[" + Id + "]");
			str.Append($"Name[{Name}]");
			str.Append($"ZonePos[{ZonePos}]");
			str.Append($"PlayerId[{PlayerId}]");
			str.Append($"CardId[{CardId}]");
			return str.ToString();
		}
	}
}
