using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class HeroPower : Playable<HeroPower>
    {
        public HeroPower(Controller controller, Card card, Dictionary<EGameTag, int> tags)
            : base(controller, card, tags)
        {
            Game.Log(ELogLevel.VERBOSE, EBlockType.PLAY, "HeroPower", $"{this} ({ Card.Class}) was created.");
        }

        public override bool TargetingRequirements(ICharacter target)
        {
            return !target.CantBeTargetedByHeroPowers && base.TargetingRequirements(target);
        }

        public override bool IsPlayable => !IsExhausted && base.IsPlayable;
    }
}
