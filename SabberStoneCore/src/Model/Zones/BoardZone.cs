using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : Zone<Minion>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo((Minion)entity, zonePosition < 0 ? _count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.BOARD_ZONE, Zone.PLAY);

			entity.OrderOfPlay = Game.NextOop;
		}

		public BoardZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = Game.MAX_MINIONS_ON_BOARD;
			_entities = new Minion[MaxSize];
			Type = Zone.PLAY;
		}
	}
}
