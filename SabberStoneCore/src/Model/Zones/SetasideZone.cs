using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class SetasideZone : Zone<IPlayable>
	{
		public override int MaxSize => 9999;

		public SetasideZone(Game game, Controller controller) : base(game, controller, Zone.SETASIDE)
		{
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override Zone<IPlayable> InternalClone(Game newGame)
		{
			return new SetasideZone(newGame, newGame.ControllerById(Controller.Id));
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
