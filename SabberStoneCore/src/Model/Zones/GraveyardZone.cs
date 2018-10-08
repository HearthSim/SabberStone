﻿using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : UnlimitedZone
	{
		public GraveyardZone(Controller controller) : base(controller)
		{
			Type = Zone.GRAVEYARD;
		}

		private GraveyardZone(Controller c, GraveyardZone zone) : base(c, zone)
		{
			Type = Zone.GRAVEYARD;
			//Entities = new List<IPlayable>(zone.Entities);
		}

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			if (entity.AppliedEnchantments != null)
				for (int i = entity.AppliedEnchantments.Count - 1; i >= 0; i--)
					entity.AppliedEnchantments[i].Remove();

			//entity.Reset();
		}

		public GraveyardZone Clone(Controller c)
		{
			return new GraveyardZone(c, this);
		}
	}
}
