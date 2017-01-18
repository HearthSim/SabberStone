using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class HealTask : SimpleTask
    {
        public HealTask(int amount, EntityType entityType)
        {
            Amount = amount;
            Type = entityType;
        }

        public int Amount { get; set; }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            if (Amount < 1)
            {
                return TaskState.STOP;
            }

            var source = Source as IPlayable;
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Amount);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }

    public class HealStackTask : SimpleTask
    {
        public HealStackTask(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if ((source == null) || (Amount < 1))
            {
                return TaskState.STOP;
            }

            Playables.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeHeal(source, Amount);
            });
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealStackTask(Amount);
            clone.Copy(this);
            return clone;
        }
    }

    public class HealFullTask : SimpleTask
    {
        public HealFullTask(EntityType entityType)
        {
            Type = entityType;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return TaskState.STOP;
            }

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var target = p as ICharacter;
                target?.TakeFullHeal(source);
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealFullTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}