using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromDeck : SimpleTask
    {
        public RemoveFromDeck(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            var list = new List<IPlayable>();
            entities.ForEach(p =>
            {
                if (p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p))
                    list.Add(p);
            });
            Playables = list;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RemoveFromDeck(Type);
            clone.Copy(this);
            return clone;
        }
    }
}