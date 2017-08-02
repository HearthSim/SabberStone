using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MoveToDeck : SimpleTask
    {
        public MoveToDeck(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var removedEntity = p.Zone.Remove(p);
                removedEntity.Controller = Controller;
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "MoveToDeck", $"{Controller.Name} is taking control of {p} and shuffled into his deck.");
                Generic.ShuffleIntoDeck.Invoke(Controller, p);
            });
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MoveToDeck(Type);
            clone.Copy(this);
            return clone;
        }
    }
}