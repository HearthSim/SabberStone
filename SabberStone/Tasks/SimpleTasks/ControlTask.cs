using System.Reflection;
using log4net;

namespace SabberStone.Tasks.SimpleTasks
{
    public class ControlTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ControlTask(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
            {
                Log.Info($"{Controller.Name} is taking control of {p}.");
                Game.PlayTaskLog.AppendLine($"{Controller.Name} is taking control of {p}.");
                var removedEntity = p.Zone.Remove(p);
                removedEntity.Controller = Controller;
                Controller.Board.Add(removedEntity);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ControlTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}