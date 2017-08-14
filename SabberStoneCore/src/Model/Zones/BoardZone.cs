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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override Zone<Minion> InternalClone(Game newGame)
		{
			return new BoardZone(newGame, newGame.ControllerById(Controller.Id));
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
