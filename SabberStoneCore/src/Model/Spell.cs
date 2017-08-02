using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class Spell : Playable<Spell>
    {
        public Spell(Controller controller, Card card, Dictionary<EGameTag, int> tags)
            : base(controller, card, tags)
        {
            Game.Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Spell", $"{card.Name} ({card.Class}) was created.");
        }

        public override bool TargetingRequirements(ICharacter target)
        {
            return !target.CantBeTargetedBySpells && base.TargetingRequirements(target);
        }

        public bool IsAffectedBySpellpower => this[EGameTag.AFFECTED_BY_SPELL_POWER] == 1;

        public bool IsSecret => this[EGameTag.SECRET] == 1;

        public bool IsQuest => this[EGameTag.QUEST] == 1;

        public bool IsCountered
        {
            get { return this[EGameTag.COUNTER] == 1; }
            set { this[EGameTag.COUNTER] = value ? 1 : 0; }
        }

        public bool ReceveivesDoubleSpellDamage
        {
            get { return this[EGameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] == 1; }
            set { this[EGameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] = value ? 1 : 0; }
        }

        public int QuestProgress
        {
            get { return this[EGameTag.QUEST_PROGRESS]; }
            set { this[EGameTag.QUEST_PROGRESS] = value; }
        }

        public int QuestTotalProgress => this[EGameTag.QUEST_PROGRESS_TOTAL];
    }
}