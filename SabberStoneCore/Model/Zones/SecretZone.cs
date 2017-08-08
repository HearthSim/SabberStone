using SabberStoneCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : Zone<Spell>
	{
		public SecretZone(Game game, Controller controller, Zone type) : base(game, controller, type)
		{
		}
	}
}
