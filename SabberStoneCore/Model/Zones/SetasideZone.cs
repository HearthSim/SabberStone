using SabberStoneCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : Zone<IPlayable>
	{
		public SetasideZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
