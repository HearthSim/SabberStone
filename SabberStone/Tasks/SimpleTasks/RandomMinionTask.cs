using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HearthDb.Enums;
using log4net;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class RandomMinionTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private RandomMinionTask(GameTag tag, int value, EntityType type)
        {
            Tag = tag;
            Value = value;
            Type = type;
        }

        public RandomMinionTask(GameTag tag, EntityType type)
        {
            Tag = tag;
            Value = -1;
            Type = type;
        }

        public RandomMinionTask(GameTag tag, int value)
        {
            Tag = tag;
            Value = value;
            Type = EntityType.INVALID;
        }

        public GameTag Tag { get; set; }
        public int Value { get; set; }
        public EntityType Type { get; set; }

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

            var playable = Entity.FromCard(Controller, Util<Card>.Choose(cardsList));
            Playables = new List<IPlayable> { playable };

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomMinionTask(Tag, Value, Type);
            clone.Copy(this);
            return clone;
        }
    }
}