using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : Zone<IPlayable>
	{
		public SetasideZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
