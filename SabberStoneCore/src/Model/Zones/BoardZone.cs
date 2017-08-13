using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : Zone<Minion>
	{
		public override int MaxSize => 7;

		public BoardZone(Game game, Controller controller) : base(game, controller, Zone.PLAY)
		{
		}

		protected override Zone<Minion> InternalClone()
		{
			return new BoardZone(Game, Controller);
		}
	}
}
