using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealTask : SimpleTask
    {
        public HealTask(int amount, EntityType entityType)
        {
            Amount = amount;
            Type = entityType;
            Sort = HealType.Heal;
        }

        public HealTask(EntityType entityType)
        {
            Type = entityType;
            Sort = HealType.HealNumber;
        }
        
        public HealTask(int amount)
        {
            Amount = amount;
            Type = EntityType.STACK;
            Sort = HealType.HealStack;
        }

        public int Amount { get; set; }

        public EntityType Type { get; set; }

        internal HealType Sort { get; set; }

        internal enum HealType
        {
            Heal, HealNumber, HealStack 
        }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            switch (Sort)
            {
                case HealType.Heal:
                    if (Amount < 1)
                    {
                        return TaskState.STOP;
                    }

                    entities.ForEach(p =>
                    {
                        var target = p as ICharacter;
                        target?.TakeHeal(source, Amount);
                    });
                    break;

                case HealType.HealNumber:
                    entities.ForEach(p =>
                    {
                        var target = p as ICharacter;
                        target?.TakeHeal(source, Number);
                    });
                    break;

                case HealType.HealStack:
                    if ((source == null) || (Amount < 1))
                    {
                        return TaskState.STOP;
                    }

                    Playables.ForEach(p =>
                    {
                        var target = p as ICharacter;
                        target?.TakeHeal(source, Amount);
                    });
                    break;

                default:
                    break;
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