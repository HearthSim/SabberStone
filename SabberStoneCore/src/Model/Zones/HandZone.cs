using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Zone for all entities which are held 'in hand'.
	/// </summary>
	/// <seealso cref="SabberStoneCore.Model.Zone{SabberStoneCore.Model.IPlayable}" />
	public sealed class HandZone : Zone<IPlayable>
	{
		/// <summary><see cref="IZone.MaxSize"/></summary>
		public override int MaxSize => Controller.MaxHandSize;

		/// <summary>Initializes a new instance of the <see cref="HandZone"/> class.</summary>
		/// <param name="game">The game.</param>
		/// <param name="controller">The controller.</param>
		public HandZone(Game game, Controller controller) : base(game, controller, EZone.HAND)
		{
		}
	}
}
