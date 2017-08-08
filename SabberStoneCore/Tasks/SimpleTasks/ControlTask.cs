using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ControlTask : SimpleTask
    {
        public ControlTask(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
            {
                Game.Log(LogLevel.INFO, BlockType.PLAY, "ControlTask", $"{Controller.Name} is taking control of {p}.");
                var removedEntity = p.Zone.Remove(p);
                removedEntity.Controller = Controller;
                Controller.BoardZone.Add(removedEntity);
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