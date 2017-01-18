using System.Collections.Generic;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public partial class Weapon : Playable<Weapon>
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Weapon(Controller controller, IZone zone, Card card, Dictionary<GameTag, int> tags, int id)
            : base(controller, zone, card, tags, id)
        {
            Log.Debug($"Weapon {this} ({Card.Class}) was created.");
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