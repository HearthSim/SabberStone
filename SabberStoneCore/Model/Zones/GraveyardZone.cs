using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : Zone<IPlayable>
	{
		public GraveyardZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
