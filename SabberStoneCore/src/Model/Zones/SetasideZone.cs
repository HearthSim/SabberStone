using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : Zone<IPlayable>
	{
		public override bool IsFull => false;

		public SetasideZone(Game game, Controller controller)
		{
			Game = game;
			Controller = controller;
			_entities = new List<IPlayable>(1);
			Type = Zone.SETASIDE;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			MoveTo(entity, _count);
			Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");
		}
	}
}
