using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

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
	}
}
