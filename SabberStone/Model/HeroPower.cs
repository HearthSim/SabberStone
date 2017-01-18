using System.Collections.Generic;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public class HeroPower : Playable<HeroPower>
    {
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HeroPower(Controller controller, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, null, card, tags, id)
        {
            Log.Debug($"HeroPower {this} ({Card.Class}) was created.");
        }

        public override bool TargetingRequirements(ICharacter target)
        {
            var minion = target as Minion;
            return (minion == null || !minion.CantBeTargetedByAbilities) && base.TargetingRequirements(target);
        }

        public override bool IsPlayable => !IsExhausted && base.IsPlayable;
    }
}
