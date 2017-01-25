using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomCardTask : SimpleTask
    {
        private RandomCardTask(EntityType type, CardType cardType, CardClass cardClass)
        {
            Type = type;
            CardType = cardType;
            CardClass = cardClass;
        }

        public RandomCardTask(EntityType type)
        {
            Type = type;
            CardType = CardType.INVALID;
        }

        public RandomCardTask(CardType cardType, CardClass cardClass)
        {
            Type = EntityType.INVALID;
            CardType = cardType;
            CardClass = cardClass;
        }

        public EntityType Type { get; set; }
        public CardType CardType { get; set; }
        public CardClass CardClass { get; set; }

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

            var cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass] : Cards.Wild[CardClass];
            var cardsList = cards.Where(p =>
                (CardType == CardType.INVALID || p.Type == CardType) &&
                (CardClass == CardClass.INVALID || p.Class == CardClass));

            var randomCard = Entity.FromCard(Controller, Util<Card>.Choose(cardsList.ToList()));
            Playables.Add(randomCard);

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomCardTask(Type, CardType, CardClass);
            clone.Copy(this);
            return clone;
        }
    }
}