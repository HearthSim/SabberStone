using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomMinionTask : SimpleTask
    {
        private RandomMinionTask(EGameTag tag, int value, EEntityType type, int amount, ERelaSign relaSign)
        {
            Tag = tag;
            Value = value;
            Type = type;
            Amount = amount;
            RelaSign = relaSign;
        }

        public RandomMinionTask(EGameTag tag, EEntityType type, int amount = 1)
        {
            Tag = tag;
            Value = -1;
            Type = type;
            Amount = amount;
            RelaSign = ERelaSign.EQ;
        }

        public RandomMinionTask(EGameTag tag, int value, int amount = 1, ERelaSign relaSign = ERelaSign.EQ)
        {
            Tag = tag;
            Value = value;
            Type = EEntityType.INVALID;
            Amount = amount;
            RelaSign = relaSign;
        }

        public EGameTag Tag { get; set; }
        public int Value { get; set; }
        public EEntityType Type { get; set; }
        public int Amount { get; set; }
        public ERelaSign RelaSign { get; set; }

        public override ETaskState Process()
        {
            if (Type != EEntityType.INVALID)
            {
                if (Type == EEntityType.TARGET && Tag == EGameTag.COST)
                {
                    Value = ((IPlayable) Target).Cost;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            var cards = Game.FormatType == EFormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            var cardsList = cards.Where(p => p.Type == ECardType.MINION 
                && (RelaSign == ERelaSign.EQ && p[Tag] == Value
                 || RelaSign == ERelaSign.GEQ && p[Tag] >= Value
                 || RelaSign == ERelaSign.LEQ && p[Tag] <= Value)).ToList();
            if (!cardsList.Any())
            {
                return ETaskState.STOP;
            }

            var randomMinions = new List<IPlayable>();
            while (randomMinions.Count < Amount && cardsList.Count > 0)
            {
                var card = Util.Choose(cardsList);
                cardsList.Remove(card);
                randomMinions.Add(Entity.FromCard(Controller, card));
            }

            Playables = randomMinions;

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomMinionTask(Tag, Value, Type, Amount, RelaSign);
            clone.Copy(this);
            return clone;
        }
    }
}