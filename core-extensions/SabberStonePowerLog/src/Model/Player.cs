using System.Collections.Generic;
using System.Linq;

namespace SabberStonePowerLog.Model
{
	public class Player : PowerEntity
	{
		private readonly PowerGame _game;
		public List<PowerEntity> OriginalMulliganList { get; set; }
		public List<PowerEntity> MulliganDiscards { get; set; }
		public List<PowerEntity> FinalMulliganList { get; set; }

		public Player(PowerGame game)
		{
			_game = game;
		}

		public List<PowerEntity> Cards => _game.Entities.Values.Where(a => a.Data.ContainsKey("CARDTYPE") && (a.Data["CARDTYPE"] == "MINION" || a.Data["CARDTYPE"] == "SPELL")).ToList();

		public string Name { get; set; }

	}
}
