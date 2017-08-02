using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public partial class Weapon : Playable<Weapon>
    {
        public Weapon(Controller controller, Card card, Dictionary<EGameTag, int> tags)
            : base(controller, card, tags)
        {
            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "Weapon", $"{this} ({Card.Class}) was created.");
        }
    }

    public partial class Weapon
    {
        public int AttackDamage
        {
            get { return this[EGameTag.ATK]; }
            set { this[EGameTag.ATK] = value; }
        }

        public int Durability
        {
            get { return this[EGameTag.DURABILITY]; }
            set { this[EGameTag.DURABILITY] = value; }
        }

        public bool HasWindfury
        {
            get { return this[EGameTag.WINDFURY] == 1; }
            set { this[EGameTag.WINDFURY] = value ? 1 : 0; }
        }

        public bool Poisonous
        {
            get { return this[EGameTag.POISONOUS] == 1; }
            set { this[EGameTag.POISONOUS] = value ? 1 : 0; }
        }
    }
}