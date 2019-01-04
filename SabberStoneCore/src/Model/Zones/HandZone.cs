using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	public class HandZone : PositioningZone<IPlayable>
	{
		public const int MaxHandSize = 10;

		public HandZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
		}

		private HandZone(Controller c, HandZone zone) : base(c, zone)
		{
		}

		public override bool IsFull => _count == MaxHandSize;

		public override int MaxSize => MaxHandSize;

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

		public HandZone Clone(Controller c)
		{
			return new HandZone(c, this);
		}
	}
}
