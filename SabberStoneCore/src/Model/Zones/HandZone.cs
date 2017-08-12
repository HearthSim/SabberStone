using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	public class HandZone : Zone<IPlayable>
	{
		public override int MaxSize => Controller.MaxHandSize;

		/// <summary>Initializes a new instance of the <see cref="HandZone"/> class.</summary>
		/// <param name="game">The game.</param>
		/// <param name="controller">The controller.</param>
		public HandZone(Game game, Controller controller) : base(game, controller, Zone.HAND)
		{
		}

		protected override Zone<IPlayable> InternalClone()
		{
			return new HandZone(Game, Controller);
		}
	}
}
