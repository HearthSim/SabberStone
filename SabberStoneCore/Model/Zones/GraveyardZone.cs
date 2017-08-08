using SabberStoneCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : Zone<IPlayable>
	{
		public GraveyardZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
