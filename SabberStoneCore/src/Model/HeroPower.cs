using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Represents a hero power object.
	/// </summary>
	/// <seealso cref="SabberStoneCore.Model.Playable{SabberStoneCore.Model.HeroPower}" />
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

		/// <summary><see cref="Targeting.TargetingRequirements(ICharacter)"/></summary>
		public override bool TargetingRequirements(ICharacter target)
		{
			return !target.CantBeTargetedByHeroPowers && base.TargetingRequirements(target);
		}


	}
}
