using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RemoveFromHand : SimpleTask
    {
        public RemoveFromHand(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            var list = new List<IPlayable>();
            entities.ForEach(p =>
            {
                if (p.Zone.Type == EZone.HAND && Generic.RemoveFromZone.Invoke(p.Controller, p))
                    list.Add(p);
            });
            Playables = list;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RemoveFromHand(Type);
            clone.Copy(this);
            return clone;
        }
    }
}