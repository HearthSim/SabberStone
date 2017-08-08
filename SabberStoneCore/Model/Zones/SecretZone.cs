using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : Zone<Spell>
	{
		public SecretZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
