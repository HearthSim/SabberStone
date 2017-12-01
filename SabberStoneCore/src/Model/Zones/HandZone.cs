﻿using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	public class HandZone : PositioningZone<IPlayable>
	{ 
		public HandZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
			//MaxSize = Controller.MaxHandSize;
			MaxSize = 10;
			Entities = new IPlayable[MaxSize];
			Type = Zone.HAND;
		}


		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			base.Add(entity, zonePosition);

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.HAND_ZONE, Zone.HAND);
		}
	}
}
