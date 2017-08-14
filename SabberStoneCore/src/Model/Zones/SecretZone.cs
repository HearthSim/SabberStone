using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : Zone<Spell>
	{
		public override int MaxSize => 9999;

		public SecretZone(Game game, Controller controller) : base(game, controller, Zone.SECRET)
		{
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override Zone<Spell> InternalClone(Game newGame)
		{
			return new SecretZone(newGame, newGame.ControllerById(Controller.Id));
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
