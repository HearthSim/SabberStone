using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddStackTo : SimpleTask
    {
        public AddStackTo(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {

            switch (Type)
            {
                case EEntityType.DECK:
                   
                    Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
                    return ETaskState.COMPLETE;

                case EEntityType.HAND:
                    Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
                    return ETaskState.COMPLETE;

                case EEntityType.OP_HAND:
                    Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
                    return ETaskState.COMPLETE;

                case EEntityType.OP_DECK:
                    Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
                    return ETaskState.COMPLETE;

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