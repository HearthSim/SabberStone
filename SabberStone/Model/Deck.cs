using System.Linq;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public class Deck : Zone<IPlayable>
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public int StartingCards { get; set; } = 30;

        public Deck(Game game, Controller controller) : base(game, controller, Zone.DECK)
        {
        }

        public void Add(Card card)
        {
            Add(Entity.FromCard(Controller, card));
        }

        public void Fill()
        {
            var cards = Game.FormatType == FormatType.FT_STANDARD ? Controller.Standard : Controller.Wild;
            var cardsToAdd = StartingCards - Count;
            
            Log.Info($"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
            Game.PlayTaskLog.AppendLine($"Deck[{Game.FormatType}] from {Controller.Name} filling up with {cardsToAdd} random cards.");
            while (cardsToAdd > 0)
            {
                var card = Util<Card>.Choose(cards);
                if (cards.Count(c => c == card) >= card.MaxAllowedInDeck) continue;
                Add(card);
                cardsToAdd--;
            }
        }

        public void Shuffle(int times = 100)
        {
            // no need to shuffle something that has no or only one entity ...
            if (Count < 2)
            {
                return;
            }

            Log.Info($"Deck[{Game.FormatType}] from {Controller.Name} shuffling ({times}x).");
            Game.PlayTaskLog.AppendLine($"Deck[{Game.FormatType}] from {Controller.Name} shuffling ({times}x).");
            for (var i = 0; i < times; i++)
            {
                Swap(Random, Random);
            }
        }
    }
}
