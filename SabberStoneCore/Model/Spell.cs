using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class Spell : Playable<Spell>
    {
        public Spell(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
        {
            Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Spell", $"{card.Name} ({card.Class}) was created.");
        }

        public bool IsAffectedBySpellpower => this[GameTag.AFFECTED_BY_SPELL_POWER] == 1;

        public bool IsSecret => this[GameTag.SECRET] == 1;

        public bool IsCountered
        {
            get { return this[GameTag.COUNTER] == 1; }
            set { this[GameTag.COUNTER] = value ? 1 : 0; }
        }

        public bool ReceveivesDoubleSpellDamage
        {
            get { return this[GameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] == 1; }
            set { this[GameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] = value ? 1 : 0; }
        }
    }
}