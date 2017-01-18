using HearthDb.Enums;

namespace SabberStone.Tasks.SimpleTasks
{
    public class SetGameTagNumberTask : SimpleTask
    {
        public SetGameTagNumberTask(GameTag tag, EntityType entityType)
        {
            Tag = tag;
            Type = entityType;
        }

        public GameTag Tag { get; set; }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => { p[Tag] = Number; });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetGameTagNumberTask(Tag, Type);
            clone.Copy(this);
            return clone;
        }
    }
}