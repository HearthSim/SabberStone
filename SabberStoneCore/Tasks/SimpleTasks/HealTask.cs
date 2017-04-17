using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealTask : SimpleTask
    {
        public HealTask(int amount, EntityType entityType)
        {
            Amount = amount;
            Type = entityType;
        }

        public HealTask(EntityType entityType)
        {
            Amount = -1;
            Type = entityType;
        }

        public HealTask(int amount)
        {
            Amount = amount;
            Type = EntityType.INVALID;
        }

        public int Amount { get; set; }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null)
            {
                return TaskState.STOP;
            }

            if (Type == EntityType.INVALID)
            {
                Playables.ForEach(p =>
                {
                    var target = p as ICharacter;
                    target?.TakeHeal(source, Amount);
                });
            }
            else
            {
                var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
                
                entities.ForEach(p =>
                {
                    var target = p as ICharacter;
                    switch (Amount)
                    {
                        case -1:
                            target?.TakeHeal(source, Number);
                            break;

                        default:
                            target?.TakeHeal(source, Amount);
                            break;
                    }
                });
            }

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}