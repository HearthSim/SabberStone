using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Model.Entities.Playables
{
	/// <summary>
	/// The (character) entity built from <see cref="ECardType.MINION"/> <see cref="Card"/>s.
	/// This object will be stored inside the <see cref="BoardZone"/>
	/// where it will fight 'till death. That's the <see cref="GraveyardZone"/>!
	/// </summary>
	/// <seealso cref="Character{Minion}" />
	public partial class Minion : Character<Minion>
    {
        public Minion(Controller controller, Card card, Dictionary<EGameTag, int> tags)
            : base(controller, card, tags)
        {
            Game.Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Minion", $"{this} ({Card.Class}) was created.");
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

            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "Minion", $"{this} got silenced!");
        }
    }

    public partial class Minion
    {
        public bool HasCharge
        {
            get { return this[EGameTag.CHARGE] == 1; }
            set { this[EGameTag.CHARGE] = value ? 1 : 0; }
        }

        public bool HasDivineShield
        {
            get { return this[EGameTag.DIVINE_SHIELD] == 1; }
            set { this[EGameTag.DIVINE_SHIELD] = value ? 1 : 0; }
        }

        public bool HasBattleCry
        {
            get { return this[EGameTag.BATTLECRY] != 0; }
            set { this[EGameTag.BATTLECRY] = value ? 1 : 0; }
        }

        public bool HasInspire
        {
            get { return this[EGameTag.INSPIRE] == 1; }
            set { this[EGameTag.INSPIRE] = value ? 1 : 0; }
        }

        public bool HasStealth
        {
            get { return this[EGameTag.STEALTH] == 1; }
            set { this[EGameTag.STEALTH] = value ? 1 : 0; }
        }

        public bool IsEnraged
        {
            get { return this[EGameTag.ENRAGED] == 1; }
            set { this[EGameTag.ENRAGED] = value ? 1 : 0; }
        }

        public bool Freeze
        {
            get { return this[EGameTag.FREEZE] == 1; }
            set { this[EGameTag.FREEZE] = value ? 1 : 0; }
        }

        public bool Poisonous
        {
            get { return this[EGameTag.POISONOUS] == 1; }
            set { this[EGameTag.POISONOUS] = value ? 1 : 0; }
        }
    }
}