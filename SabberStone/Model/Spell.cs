using System.Collections.Generic;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public class Spell : Playable<Spell>
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Spell(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
        {
            Log.Debug($"Spell  {card.Name} ({card.Class}) was created.");
        }

        public bool IsAffectedBySpellpower => this[GameTag.AFFECTED_BY_SPELL_POWER] == 1;

        public bool IsSecret => this[GameTag.SECRET] == 1;
    }
}