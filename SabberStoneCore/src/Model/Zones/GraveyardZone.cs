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

		protected override Zone<IPlayable> InternalClone()
		{
			return new GraveyardZone(Game, Controller);
		}
	}
}
