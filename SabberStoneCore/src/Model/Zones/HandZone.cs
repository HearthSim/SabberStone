#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	public class HandZone : PositioningZone<IPlayable>
	{ 
		public HandZone(Controller controller) : base(10)
		{
			Game = controller.Game;
			Controller = controller;
			//MaxSize = Controller.MaxHandSize;
			Type = Zone.HAND;
		}

		private HandZone(Controller c, HandZone zone) : base(c, zone)
		{
			Type = Zone.HAND;
		}


		public override void Add(IPlayable entity, int zonePosition = -1)
		{
			base.Add(entity, zonePosition);

			if (entity.Power?.Aura is AdaptiveCostEffect e)
				e.Activate(entity);
			entity.Power?.Trigger?.Activate(entity, TriggerActivation.HAND);

			Game.TriggerManager.OnZoneTrigger(entity);
		}

		public override IPlayable Remove(IPlayable entity)
		{
			entity.AuraEffects.ResetCost();
			entity.AppliedEnchantments?.ForEach(p => p.ActivatedTrigger?.Remove());
			return base.Remove(entity);
		}

		/// <summary>
		/// Replaces an entity in the given position internally. (i.e. not creates any history packets)
		/// </summary>
		internal void ChangeEntity(IPlayable oldEntity, IPlayable newEntity)
		{
			Entities[oldEntity.ZonePosition] = newEntity;
			newEntity.Zone = this;
			for (int i = 0; i < Auras.Count; i++)
				Auras[i].EntityRemoved(oldEntity);
		}

		public HandZone Clone(Controller c)
		{
			return new HandZone(c, this);
		}
	}
}
