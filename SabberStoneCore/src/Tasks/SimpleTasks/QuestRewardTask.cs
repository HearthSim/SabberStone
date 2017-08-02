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

        public override ETaskState Process()
        {
            var source = Source as Spell;
            if (source == null)
            {
                return ETaskState.STOP;
            }

            // creating reward card ...
            var reward = Entity.FromCard(Controller, Card);
            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "QuestRewardTask", $"{Controller} Quest finished, reward {reward}!");

            // adding reward to hand
            Generic.AddHandPhase.Invoke(Controller, reward);
            source[EGameTag.REVEALED] = 1;

            // moving quest to graveyard
            Controller.Graveyard.Add(source.Zone.Remove(source));

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new QuestRewardTask(Card);
            clone.Copy(this);
            return clone;
        }
    }
}