using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealTask : SimpleTask
    {
        public HealTask(int amount, EEntityType entityType)
        {
            Amount = amount;
            Type = entityType;
        }

        public int Amount { get; set; }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            if (Amount < 1)
            {
                return ETaskState.STOP;
            }

            var source = Source as IPlayable;
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Amount);
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}