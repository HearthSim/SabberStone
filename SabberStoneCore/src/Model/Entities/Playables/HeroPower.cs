using SabberStoneCore.Enums;
using SabberStoneCore.Model.Zones;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities.Playables
{
	/// <summary>
	/// The special effect linked to the controller's <see cref="Hero"/>/player.
	/// The hero power is built from <see cref="ECardType.HERO_POWER"/> <see cref="Card"/>s.
	/// The exact heropower depends on the <see cref="ECardClass"/> of the 
	/// <see cref="DeckZone"/> of the controller.
	/// </summary>
	/// <seealso cref="Playable{HeroPower}" />
	public class HeroPower : Playable<HeroPower>
	{
		/// <summary><see cref="Playable{T}.IsPlayable"/></summary>
		public override bool IsPlayable => !IsExhausted && base.IsPlayable;

		/// <summary>Initializes a new instance of the <see cref="HeroPower"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card from which this instance is derived.</param>
		/// <param name="tags">The tags.</param>
		public HeroPower(Controller controller, Card card, Dictionary<EGameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(ELogLevel.VERBOSE, EBlockType.PLAY, "HeroPower", $"{this} ({ Card.Class}) was created.");
		}

		/// <summary><see cref="Targeting.TargetingRequirementsMatch(ICharacter)"/></summary>
		protected override bool TargetingRequirementsMatch(ICharacter target)
		{
			return !target.CantBeTargetedByHeroPowers && base.TargetingRequirementsMatch(target);
		}


	}
}
