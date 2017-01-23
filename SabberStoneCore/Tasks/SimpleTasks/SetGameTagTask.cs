using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetGameTagTask : SimpleTask
    {
        public SetGameTagTask(GameTag tag, int amount, EntityType entityType)
        {
            Tag = tag;
            Amount = amount;
            Type = entityType;
        }

        public GameTag Tag { get; set; }

        public EntityType Type { get; set; }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => { p[Tag] = Amount; });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetGameTagTask(Tag, Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}