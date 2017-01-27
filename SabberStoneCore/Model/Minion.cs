using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public partial class Minion : Character<Minion>
    {
        public Minion(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
        {
            Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Minion", $"{this} ({Card.Class}) was created.");
        }

        public override bool CanAttack => AttackDamage > 0 && ChargeBuffed() && base.CanAttack;

        private bool ChargeBuffed()
        {
            if (NumAttacksThisTurn == 0 && HasCharge && IsExhausted)
            {
                IsExhausted = false;
            }
            return true;
        }

        public void Silence()
        {
            HasTaunt = false;
            IsFrozen = false;
            IsEnraged = false;
            HasCharge = false;
            HasWindfury = false;
            HasDivineShield = false;
            HasStealth = false;
            HasDeathrattle = false;
            HasBattleCry = false;
            HasInspire = false;

            IsSilenced = true;

            Game.Log(LogLevel.INFO, BlockType.PLAY, "Minion", $"{this} got silenced!");
        }

        public void RemoveStealth()
        {
            HasStealth = false;
        }
    }

    public partial class Minion
    {
        public bool CantBeTargetedByAbilities
        {
            get { return this[GameTag.CANT_BE_TARGETED_BY_ABILITIES] == 1; }
            set { this[GameTag.CANT_BE_TARGETED_BY_ABILITIES] = value ? 1 : 0; }
        }

        public bool HasCharge
        {
            get { return this[GameTag.CHARGE] == 1; }
            set { this[GameTag.CHARGE] = value ? 1 : 0; }
        }

        public bool HasDivineShield
        {
            get { return this[GameTag.DIVINE_SHIELD] == 1; }
            set { this[GameTag.DIVINE_SHIELD] = value ? 1 : 0; }
        }

        public bool HasBattleCry
        {
            get { return this[GameTag.BATTLECRY] == 1; }
            set { this[GameTag.BATTLECRY] = value ? 1 : 0; }
        }

        public bool HasInspire
        {
            get { return this[GameTag.INSPIRE] == 1; }
            set { this[GameTag.INSPIRE] = value ? 1 : 0; }
        }

        public bool HasDeathrattle
        {
            get { return this[GameTag.DEATHRATTLE] == 1; }
            set { this[GameTag.DEATHRATTLE] = value ? 1 : 0; }
        }

        public bool HasStealth
        {
            get { return this[GameTag.STEALTH] == 1; }
            set { this[GameTag.STEALTH] = value ? 1 : 0; }
        }

        public bool IsEnraged
        {
            get { return this[GameTag.ENRAGED] == 1; }
            set { this[GameTag.ENRAGED] = value ? 1 : 0; }
        }

        public bool IsImmune
        {
            get { return this[GameTag.IMMUNE] == 1; }
            set { this[GameTag.IMMUNE] = value ? 1 : 0; }
        }

        public bool Freeze
        {
            get { return this[GameTag.FREEZE] == 1; }
            set { this[GameTag.FREEZE] = value ? 1 : 0; }
        }
    }
}