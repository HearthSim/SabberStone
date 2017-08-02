using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class HealthRetentionTask : SimpleTask
    {
        public int Amount { get; set; }

        public EEntityType Type { get; set; }

        public HealthRetentionTask(int amount, EEntityType type)
        {
            Amount = amount;
            Type = type;
        }

        public override ETaskState Process()
        {
            var source = Source as ICharacter;
            if (source == null || Amount < 1)
            {
                return ETaskState.STOP;
            }

            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
            {
                var target = p as ICharacter;
                if (target != null)
                {
                    target.IsIgnoreDamage = true;
                    target.Damage -= Amount;
                    target.IsIgnoreDamage = false;
                }
            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealthRetentionTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}