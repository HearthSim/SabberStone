using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class Spell : Playable<Spell>
    {
        public Spell(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
        {
            Game.Log(LogLevel.INFO, BlockType.PLAY, "Spell", $"Spell  {card.Name} ({card.Class}) was created.");
        }

        public bool IsAffectedBySpellpower => this[GameTag.AFFECTED_BY_SPELL_POWER] == 1;

        public bool IsSecret => this[GameTag.SECRET] == 1;
    }
}