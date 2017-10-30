using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	public class HandZone : Zone<IPlayable>
	{
		public override bool IsFull => _entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (zonePosition > _count)
				throw new ZoneException($"Zoneposition '{zonePosition}' isn't in a valid range.");

			MoveTo(entity, zonePosition < 0 ? _count : zonePosition);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

			if (applyEnchantment)
				entity.ApplyEnchantments(EnchantmentActivation.HAND_ZONE, Zone.HAND);

		}

		public HandZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			MaxSize = Controller.MaxHandSize;
			_entities = new IPlayable[MaxSize];
			Type = Zone.HAND;
		}
	}
}
