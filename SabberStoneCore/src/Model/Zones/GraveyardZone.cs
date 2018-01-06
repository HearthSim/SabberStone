using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : UnlimitedZone
	{
		public GraveyardZone(Controller controller) : base(controller)
		{
			Type = Zone.GRAVEYARD;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			base.Add(entity, zonePosition, applyPowers);

			entity.RemoveEnchantments.Invoke();
		}
	}
}
