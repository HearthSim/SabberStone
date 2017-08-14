using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class GraveyardZone : Zone<IPlayable>
	{
		public override int MaxSize => 9999;

		public GraveyardZone(Game game, Controller controller) : base(game, controller, Zone.GRAVEYARD)
		{
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override Zone<IPlayable> InternalClone(Game newGame)
		{
			return new GraveyardZone(newGame, newGame.ControllerById(Controller.Id));
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
