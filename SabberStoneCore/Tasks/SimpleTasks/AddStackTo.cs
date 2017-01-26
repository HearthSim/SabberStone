using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddStackTo : SimpleTask
    {
        public AddStackTo(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {

            switch (Type)
            {
                case EntityType.DECK:

                    Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(Controller, p));
                    return TaskState.COMPLETE;

                case EntityType.HAND:
                    Playables.ForEach(p => Generic.AddHandPhase.Invoke(Controller, p));
                    return TaskState.COMPLETE;

                case EntityType.OP_HAND:
                    Playables.ForEach(p => Generic.AddHandPhase.Invoke(Controller.Opponent, p));
                    return TaskState.COMPLETE;

                case EntityType.OP_DECK:
                    Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(Controller.Opponent, p));
                    return TaskState.COMPLETE;

                default:
                    throw new NotImplementedException();
            }
        }

        public override ISimpleTask Clone()
        {
            var clone = new AddStackTo(Type); 
            clone.Copy(this);
            return clone;
        }
    }
}