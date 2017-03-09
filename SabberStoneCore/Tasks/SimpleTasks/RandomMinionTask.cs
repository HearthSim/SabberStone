using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomMinionTask : SimpleTask
    {
        private RandomMinionTask(GameTag tag, int value, EntityType type, int amount)
        {
            Tag = tag;
            Value = value;
            Type = type;
            Amount = amount;
        }

        public RandomMinionTask(GameTag tag, EntityType type, int amount = 1)
        {
            Tag = tag;
            Value = -1;
            Type = type;
            Amount = amount;
        }

        public RandomMinionTask(GameTag tag, int value, int amount = 1)
        {
            Tag = tag;
            Value = value;
            Type = EntityType.INVALID;
            Amount = amount;
        }

        public GameTag Tag { get; set; }
        public int Value { get; set; }
        public EntityType Type { get; set; }
        public int Amount { get; set; }

        public override TaskState Process()
        {
            if (Type != EntityType.INVALID)
            {
                if (Type == EntityType.TARGET && Tag == GameTag.COST)
                {
                    Value = ((IPlayable) Target).Cost;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            var cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
            var cardsList = cards.Where(p => p.Type == CardType.MINION && p[Tag] == Value).ToList();
            if (!cardsList.Any())
            {
                return TaskState.STOP;
            }

            var randomMinions = new List<IPlayable>();
            while (randomMinions.Count < Amount && cardsList.Count > 0)
            {
                var card = Util<Card>.Choose(cardsList);
                cardsList.Remove(card);
                randomMinions.Add(Entity.FromCard(Controller, card));
            }

            Playables = randomMinions;

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomMinionTask(Tag, Value, Type, Amount);
            clone.Copy(this);
            return clone;
        }
    }
}