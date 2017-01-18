using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public class Hand : Zone<IPlayable>
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Hand(Game game, Controller controller) : base(game, controller, Zone.HAND)
        {
        }
    }
}
