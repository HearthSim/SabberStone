using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
    public partial class Weapon : Playable<Weapon>
    {
        public Weapon(Controller controller, Card card, Dictionary<GameTag, int> tags)
            : base(controller, card, tags)
        {
            Game.Log(LogLevel.INFO, BlockType.PLAY, "Weapon", $"{this} ({Card.Class}) was created.");
        }
    }

    public partial class Weapon
    {
        public int AttackDamage
        {
            get { return this[GameTag.ATK]; }
            set { this[GameTag.ATK] = value; }
        }

        public int Durability
        {
            get { return this[GameTag.DURABILITY]; }
            set { this[GameTag.DURABILITY] = value; }
        }

        public bool HasWindfury
        {
            get { return this[GameTag.WINDFURY] == 1; }
            set { this[GameTag.WINDFURY] = value ? 1 : 0; }
        }

        public bool Poisonous
        {
            get { return this[GameTag.POISONOUS] == 1; }
            set { this[GameTag.POISONOUS] = value ? 1 : 0; }
        }
    }
}