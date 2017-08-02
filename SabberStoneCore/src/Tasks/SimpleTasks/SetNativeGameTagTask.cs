using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetNativeGameTagTask : SimpleTask
    {
        public SetNativeGameTagTask(EGameTag tag, int value, EEntityType entityType)
        {
            Tag = tag;
            Value = value;
            Type = entityType;
        }

        public EGameTag Tag { get; set; }
        public int Value { get; set; }
        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            if (entities.Count != 1)
            {
                return ETaskState.STOP;
            }

            ((Entity)entities[0]).SetNativeGameTag(Tag, Value);

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetNativeGameTagTask(Tag, Value, Type);
            clone.Copy(this);
            return clone;
        }
    }
}