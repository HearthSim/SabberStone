using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class LogTask : SimpleTask
    {
        public LogTask(bool cardTextPrint = false)
        {
            CardTextPrint = cardTextPrint;
        }

        public bool CardTextPrint { get; set; }

        public override ETaskState Process()
        {
            if (true)
            {
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "LogTask", $"Log task is beeing processed!");
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "LogTask", $"Flag: {Flag}, Number: {Number}");
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "LogTask", $"Controller: {Controller?.Name}, Source: {Source}, Target: {Target}!");
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "LogTask", $"Playables: {string.Join(",", Playables.Select(x => x.Card))} [{Playables.Count}]");
            }

            if (CardTextPrint)
            {
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "LogTask", $"{Source.Card.Text}");
            }
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new LogTask(CardTextPrint);
            clone.Copy(this);
            return clone;
        }
    }
}