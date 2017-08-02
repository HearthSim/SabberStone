using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class Hand : Zone<IPlayable>
    {
        public Hand(Game game, Controller controller) : base(game, controller, EZone.HAND)
        {
        }
    }
}
