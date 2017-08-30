using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;

namespace SabberStonePowerLog.Model
{
	public class Player : PowerEntity
	{
		private readonly PowerGame _game;
		private readonly int _playerId;
		public string Name { get; set; }

		public Player(PowerGame game, int playerId)
		{
			_game = game;
			_playerId = playerId;
		}

		public IEnumerable<PowerEntity> CardEntities
		{
			get
			{
				return _game.Entities.Values.Where(a => !string.IsNullOrEmpty(a.GetValue("CARD_ID"))
														&& !a.ValueEquals(GameTag.CARDTYPE, "HERO")
														&& !a.ValueEquals(GameTag.CARDTYPE, "HERO_POWER")
														&& a.ValueEquals(GameTag.CONTROLLER, _playerId.ToString())).ToList();
			}
		}

	}
}
