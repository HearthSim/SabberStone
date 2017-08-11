using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStonePowerLog.Model
{
	internal class PowerCreateGame : PowerHistoryEntry
	{
		public PowerCreateGame()
		{
			PowerType = PowerType.CREATE_GAME;
			Players = new List<Player>();
		}

		public GameEntity Game { get; set; }

		public List<Player> Players { get; set; }

		public override void Process(PowerGame powerGame)
		{
			//throw new NotImplementedException();
		}
	}
}