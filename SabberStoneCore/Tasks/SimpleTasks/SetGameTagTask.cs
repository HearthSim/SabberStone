using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetGameTagTask : SimpleTask
    {
        public SetGameTagTask(GameTag tag, int amount, EntityType entityType, bool ignoreDamage = false)
        {
            Tag = tag;
            Amount = amount;
            Type = entityType;
            IgnoreDamage = ignoreDamage;
        }

        public GameTag Tag { get; set; }

        public EntityType Type { get; set; }

        public int Amount { get; set; }

        public bool IgnoreDamage { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                if (IgnoreDamage)
                {
                    p.IsIgnoreDamage = true;
                    p[Tag] = Amount;
                    p.IsIgnoreDamage = false;
                }
                else
                {
                    p[Tag] = Amount;
                }
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetGameTagTask(Tag, Amount, Type, IgnoreDamage);
            clone.Copy(this);
            return clone;
        }
    }
}