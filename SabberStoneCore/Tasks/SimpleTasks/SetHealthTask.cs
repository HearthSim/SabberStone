using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetHealthTask : SimpleTask
    {
        public SetHealthTask(int amount, EntityType entityType)
        {
            Amount = amount;
            Type = entityType;
        }

        public EntityType Type { get; set; }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.TrueForAll(p =>
            {
                var target = p as Minion;
                if (target == null)
                {
                    return false;
                }

                // work around health buffs
                p.Enchants.ForEach(t =>
                {
                    if (t.Effects.ContainsKey(GameTag.HEALTH))
                    {
                        t.Effects.Remove(GameTag.HEALTH);
                    }
                });

                target.Health = Amount;
                return true;
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SetHealthTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}