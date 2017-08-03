using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : Zone<IPlayable>
	{
		public SetasideZone(Game game, Controller controller, EZone type) : base(game, controller, type)
		{
		}
	}
}
