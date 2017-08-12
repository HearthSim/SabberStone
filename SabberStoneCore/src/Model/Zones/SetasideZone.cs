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

		protected override Zone<IPlayable> InternalClone()
		{
			return new SetasideZone(Game, Controller);
		}
	}
}
