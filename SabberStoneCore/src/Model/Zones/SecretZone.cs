using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : Zone<Spell>
	{
		/// <summary><see cref="IZone.MaxSize"/> </summary>
		public override int MaxSize => base.MaxSize;

		public SecretZone(Game game, Controller controller, EZone type) : base(game, controller, type)
		{
		}
	}
}
