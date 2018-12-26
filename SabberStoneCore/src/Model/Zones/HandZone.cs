using SabberStoneCore.Auras;
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
		}

		private HandZone(Controller c, HandZone zone) : base(c, zone)
		{
		}

		public override Zone Type => Zone.HAND;

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
			int pos = oldEntity.ZonePosition;
			Entities[pos] = newEntity;
			newEntity.ZonePosition = pos;
			newEntity.Zone = this;
			//Auras.ForEach(a => a.EntityAdded(newEntity));
		}

		public HandZone Clone(Controller c)
		{
			return new HandZone(c, this);
		}
	}
}
