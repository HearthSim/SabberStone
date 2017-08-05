using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class GetNativeGameTagTask : SimpleTask
    {
        public GetNativeGameTagTask(EGameTag tag, EEntityType entityType, bool selfBuffs)
        {
            Tag = tag;
            Type = entityType;
            SelfBuffs = selfBuffs;
        }

        public EGameTag Tag { get; set; }
        public EEntityType Type { get; set; }
        public bool SelfBuffs { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            if (entities.Count != 1)
            {
                return ETaskState.STOP;
            }

            Number = ((Entity)entities[0]).GetNativeGameTag(Tag);

            if (SelfBuffs)
            {
                entities[0].Enchants.ForEach(p => Number = p.Apply((Entity)entities[0], Tag, Number));
            }

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new GetNativeGameTagTask(Tag, Type, SelfBuffs);
            clone.Copy(this);
            return clone;
        }
    }
}