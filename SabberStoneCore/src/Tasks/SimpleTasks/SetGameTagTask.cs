using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SetGameTagTask : SimpleTask
    {
        public SetGameTagTask(EGameTag tag, int amount, EEntityType entityType, bool ignoreDamage = false)
        {
            Tag = tag;
            Amount = amount;
            Type = entityType;
            IgnoreDamage = ignoreDamage;
        }

        public EGameTag Tag { get; set; }

        public EEntityType Type { get; set; }

        public int Amount { get; set; }

        public bool IgnoreDamage { get; set; }

        public override ETaskState Process()
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

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetGameTagTask(Tag, Amount, Type, IgnoreDamage);
            clone.Copy(this);
            return clone;
        }
    }
}