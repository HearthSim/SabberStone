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

		protected override Zone<Spell> InternalClone()
		{
			return new SecretZone(Game, Controller);
		}
	}
}
