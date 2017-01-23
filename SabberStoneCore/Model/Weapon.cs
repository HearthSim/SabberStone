using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public partial class Weapon : Playable<Weapon>
    {
        public Weapon(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
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
    }
}