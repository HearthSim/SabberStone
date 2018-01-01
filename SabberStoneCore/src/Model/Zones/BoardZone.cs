using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : PositioningZone<Minion>
	{
		//public override bool IsFull => Entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			base.Add(entity, zonePosition);

			if (applyPowers)
				entity.ApplyPowers(PowerActivation.BOARD_ZONE, Zone.PLAY);

			if (entity.Powers != null)
				foreach (Power power in entity.Powers)
					power.Aura?.Activate(entity);

			entity.OrderOfPlay = Game.NextOop;
		}

		public BoardZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
			//MaxSize = Game.MAX_MINIONS_ON_BOARD;
			MaxSize = 7;
			Entities = new Minion[MaxSize];
			Type = Zone.PLAY;
		}
	}
}
