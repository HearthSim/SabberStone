using SabberStoneCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : Zone<Minion>
	{
		public BoardZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
