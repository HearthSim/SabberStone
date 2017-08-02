using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class MoveToSetaside : SimpleTask
    {
        public MoveToSetaside(EEntityType type)
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
                Game.Log(ELogLevel.INFO, EBlockType.PLAY, "MoveToSetaside", $"{p.Controller.Name}'s {p} is moved to the setaside zone.");
                p.Controller.Setaside.Add(removedEntity);
            });
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new MoveToSetaside(Type);
            clone.Copy(this);
            return clone;
        }
    }
}