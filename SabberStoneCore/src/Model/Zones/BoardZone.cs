using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : Zone<Minion>
	{
		/// <summary><see cref="IZone.MaxSize"/></summary>
		public override int MaxSize => Game.MaxMinionsOnBoard;

		public BoardZone(Game game, Controller controller, EZone type) : base(game, controller, type)
		{
		}
	}
}
