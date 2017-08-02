using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ControlTask : SimpleTask
    {
        public ControlTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
            {
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "ControlTask", $"{Controller.Name} is taking control of {p}.");
                var removedEntity = p.Zone.Remove(p);
                removedEntity.Controller = Controller;
                Controller.Board.Add(removedEntity);
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ControlTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}