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
