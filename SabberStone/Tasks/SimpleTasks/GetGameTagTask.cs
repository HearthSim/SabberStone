using HearthDb.Enums;
using log4net;

namespace SabberStone.Tasks.SimpleTasks
{
    public class GetGameTagTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GetGameTagTask(GameTag tag, EntityType entityType)
        {
            Tag = tag;
            Type = entityType;
        }

        public GameTag Tag { get; set; }
        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            if (entities.Count != 1)
            {
                return TaskState.STOP;
            }

            Number = entities[0][Tag];
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new GetGameTagTask(Tag, Type);
            clone.Copy(this);
            return clone;
        }
    }
}