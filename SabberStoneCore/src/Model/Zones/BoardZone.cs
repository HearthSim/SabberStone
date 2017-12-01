using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : PositioningZone<Minion>
	{
		//public override bool IsFull => Entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			base.Add(entity, zonePosition);

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.BOARD_ZONE, Zone.PLAY);

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
