﻿using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : UnlimitedZone
	{
		public SetasideZone(Controller controller) : base(controller)
		{
			Type = Zone.SETASIDE;
		}

		private SetasideZone(Controller c, SetasideZone zone) : base(c, zone)
		{
			Type = Zone.SETASIDE;
		}

		public SetasideZone Clone(Controller c)
		{
			return new SetasideZone(c, this);
		}
	}
}
