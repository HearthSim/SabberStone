using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Entity representing the special ability for a hero.
	/// </summary>
	/// <seealso cref="Playable{HeroPower}" />
	public class HeroPower : Playable<HeroPower>
	{
		/// <summary>Initializes a new instance of the <see cref="HeroPower"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		public HeroPower(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "HeroPower", !Game.Logging? "":$"{this} ({ Card.Class}) was created.");
		}

		/// <summary>Targetings the requirements.</summary>
		/// <param name="target">The target.</param>
		/// <returns></returns>
		public override bool TargetingRequirements(ICharacter target)
		{
			return !target.CantBeTargetedByHeroPowers && base.TargetingRequirements(target);
		}

		/// <summary>
		/// Gets a value indicating whether this entity is playable by the player. Some entities require specific
		/// requirements before they can be played. This method will process the requirements and produce
		/// a result for the current state of the game.
		/// </summary>
		/// <value><c>true</c> if this entity is playable; otherwise, <c>false</c>.</value>
		public override bool IsPlayableByPlayer => !IsExhausted && !Controller.HeroPowerDisabled && base.IsPlayableByPlayer;
	}
}
