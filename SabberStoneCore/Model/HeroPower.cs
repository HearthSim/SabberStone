using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class HeroPower : Playable<HeroPower>
    {
        public HeroPower(Controller controller, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, null, card, tags, id)
        {
            Game.Log(LogLevel.INFO, BlockType.PLAY, "HeroHeroPower", $"{this} ({ Card.Class}) was created.");
        }

        public override bool TargetingRequirements(ICharacter target)
        {
            var minion = target as Minion;
            return (minion == null || !minion.CantBeTargetedByAbilities) && base.TargetingRequirements(target);
        }

        public override bool IsPlayable => !IsExhausted && base.IsPlayable;
    }
}
