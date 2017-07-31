using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class QuestRewardTask : SimpleTask
    {
        private QuestRewardTask(Card card)
        {
            Card = card;
        }

        public QuestRewardTask(string cardId)
        {
            Card = Cards.FromId(cardId);
        }

        public Card Card { get; set; }

        public override TaskState Process()
        {
            var source = Source as Spell;
            if (source == null)
            {
                return TaskState.STOP;
            }

            // creating reward card ...
            var reward = Entity.FromCard(Controller, Card);
            Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestRewardTask", $"{Controller} Quest finished, reward {reward}!");

            // adding reward to hand
            Generic.AddHandPhase.Invoke(Controller, reward);
            source[GameTag.REVEALED] = 1;

            // moving quest to graveyard
            Controller.Graveyard.Add(source.Zone.Remove(source));

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new QuestRewardTask(Card);
            clone.Copy(this);
            return clone;
        }
    }
}