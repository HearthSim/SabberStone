#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion

using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : UnlimitedZone
	{
		public GraveyardZone(Controller controller) : base(controller, Zone.GRAVEYARD)
		{
		}

		private GraveyardZone(Controller c, GraveyardZone zone) : base(c, zone)
		{
		}

		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			// Add enchantments here.
			List<Enchantment> enchantments = entity.AppliedEnchantments;
			if (enchantments == null) return;
			for (int i = enchantments.Count - 1; i >= 0; i--)
			{
				Enchantment e = enchantments[i];
				e.Remove();
				if (e.Card.Modular)
					enchantments.Add(e);
			}
		}

		public GraveyardZone Clone(Controller c)
		{
			return new GraveyardZone(c, this);
		}
	}
}
