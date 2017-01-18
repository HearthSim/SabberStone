using System.Reflection;
using log4net;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class HealthRetentionTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public int Amount { get; set; }

        public EntityType Type { get; set; }

        public HealthRetentionTask(int amount, EntityType type)
        {
            Amount = amount;
            Type = type;
        }

        public override TaskState Process()
        {
            var source = Source as ICharacter;
            if (source == null || Amount < 1)
            {
                return TaskState.STOP;
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

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new HealthRetentionTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}