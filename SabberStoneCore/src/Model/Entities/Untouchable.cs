using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
    public class Untouchable : Minion
    {
	    public Untouchable(Controller controller, Card card, IDictionary<GameTag, int> tags) : base(controller, card, tags) { }

		private Untouchable(Controller c, Untouchable u) : base(c, u) { }

		public override IPlayable Clone(Controller controller)
		{
			return new Untouchable(controller, this);
		}

		public override bool CanAttack => false;

	    public override bool ToBeDestroyed => false;

		public override bool IsValidAttackTarget(ICharacter target)
		{
			return false;
		}

		public override bool TargetingRequirements(ICharacter target)
		{
			return false;
		}
	}
}
