using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomCardTask : SimpleTask
    {
        private RandomCardTask(EntityType type, CardType cardType, CardClass cardClass, bool opposite)
        {
            Type = type;
            CardType = cardType;
            CardClass = cardClass;
            Opposite = opposite;
        }

        public RandomCardTask(EntityType type, bool opposite = false)
        {
            Type = type;
            CardType = CardType.INVALID;
            Opposite = opposite;
        }

        public RandomCardTask(CardType cardType, CardClass cardClass, bool opposite = false)
        {
            Type = EntityType.INVALID;
            CardType = cardType;
            CardClass = cardClass;
            Opposite = opposite;
        }

        public EntityType Type { get; set; }
        public CardType CardType { get; set; }
        public CardClass CardClass { get; set; }
        public bool Opposite { get; set; }

        public override TaskState Process()
        {

            switch (Type)
            {
                case EntityType.HERO:
                    CardClass = Controller.HeroClass;
                    break;
                case EntityType.OP_HERO:
                    CardClass = Controller.Opponent.HeroClass;
                    break;
                case EntityType.INVALID:
                    break;
                default:
                    throw new NotImplementedException();
            }

            var cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            var cardsList = cards.Where(p =>
                (CardType == CardType.INVALID || p.Type == CardType) &&
                (CardClass == CardClass.INVALID || p.Class == CardClass));

            var randomCard = Entity.FromCard(Opposite ? Controller.Opponent : Controller, Util<Card>.Choose(cardsList.ToList()));
            Playables.Add(randomCard);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomCardTask(Type, CardType, CardClass, Opposite);
            clone.Copy(this);
            return clone;
        }
    }
}