using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomCardTask : SimpleTask
    {
        private RandomCardTask(EEntityType type, ECardType cardType, ECardClass cardClass, ECardSet cardSet, bool opposite)
        {
            Type = type;
            CardType = cardType;
            CardClass = cardClass;
            CardSet = cardSet;
            Opposite = opposite;
        }

        public RandomCardTask(EEntityType type, bool opposite = false)
        {
            Type = type;
            CardType = ECardType.INVALID;
            CardSet = ECardSet.INVALID;
            Opposite = opposite;
        }

        public RandomCardTask(ECardType cardType, ECardClass cardClass, bool opposite = false)
        {
            Type = EEntityType.INVALID;
            CardType = cardType;
            CardClass = cardClass;
            CardSet = ECardSet.INVALID;
            Opposite = opposite;
        }

        public RandomCardTask(ECardSet cardSet)
        {
            Type = EEntityType.INVALID;
            CardType = ECardType.INVALID;
            CardClass = ECardClass.INVALID;
            CardSet = cardSet;
            Opposite = false;
        }

        public EEntityType Type { get; set; }
        public ECardType CardType { get; set; }
        public ECardClass CardClass { get; set; }
        public ECardSet CardSet { get; set; }
        public bool Opposite { get; set; }

        public override ETaskState Process()
        {

            switch (Type)
            {
                case EEntityType.HERO:
                    CardClass = Controller.HeroClass;
                    break;
                case EEntityType.OP_HERO:
                    CardClass = Controller.Opponent.HeroClass;
                    break;
                case EEntityType.INVALID:
                    break;
                default:
                    throw new NotImplementedException();
            }

            var cards = Game.FormatType == EFormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            var cardsList = cards.Where(p =>
                (CardType == ECardType.INVALID || p.Type == CardType) &&
                (CardClass == ECardClass.INVALID || p.Class == CardClass) &&
                (CardSet == ECardSet.INVALID || p.Set == CardSet));

            var randomCard = Entity.FromCard(Opposite ? Controller.Opponent : Controller, Util.Choose(cardsList.ToList()));
            Playables.Add(randomCard);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomCardTask(Type, CardType, CardClass, CardSet, Opposite);
            clone.Copy(this);
            return clone;
        }
    }
}