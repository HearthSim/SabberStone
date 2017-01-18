using System.Linq;
using System.Reflection;
using log4net;

namespace SabberStone.Tasks.SimpleTasks
{
    public class LogTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public LogTask(bool cardTextPrint = false)
        {
            CardTextPrint = cardTextPrint;
        }

        public bool CardTextPrint { get; set; }

        public override TaskState Process()
        {
            if (true)
            {
                Log.Info($"Log task is beeing processed!");
                Log.Info($"Flag: {Flag}, Number: {Number}");
                Log.Info($"Controller: {Controller?.Name}, Source: {Source}, Target: {Target}!");
                Log.Info($"Playables: {string.Join(",", Playables.Select(x => x.Card))} [{Playables.Count}]");
            }

            if (CardTextPrint)
            {
                Log.Info($"{Source.Card.Text}");
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new LogTask(CardTextPrint);
            clone.Copy(this);
            return clone;
        }
    }
}