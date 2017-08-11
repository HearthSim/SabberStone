using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : Zone<Minion>
	{
		public BoardZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
