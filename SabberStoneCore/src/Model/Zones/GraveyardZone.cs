using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : Zone<IPlayable>
	{
		public GraveyardZone(Game game, Controller controller, EZone type) : base(game, controller, type)
		{
		}
	}
}
