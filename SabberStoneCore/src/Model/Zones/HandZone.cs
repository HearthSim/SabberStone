using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
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


		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
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
			return base.Remove(entity);
		}
	}
}
