using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	public class HeroPower : Playable<HeroPower>
	{
		public override bool IsPlayable => !IsExhausted && base.IsPlayable;

		public HeroPower(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "HeroPower", $"{this} ({ Card.Class}) was created.");
		}

		public override bool TargetingRequirements(ICharacter target)
		{
			return !target.CantBeTargetedByHeroPowers && base.TargetingRequirements(target);
		}

		protected override void InternalStamp(IModel entity)
		{
			// Do nothing, nothing to stamp.
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			// Do nothing, nothing to report.
			return String.Empty;
		}

		protected override Entity InternalClone()
		{
			return new HeroPower(Controller, Card, null);
		}
	}
}
