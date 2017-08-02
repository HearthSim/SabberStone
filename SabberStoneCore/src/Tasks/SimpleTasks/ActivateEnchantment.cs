using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ActivateEnchantment : SimpleTask
    {
        public ActivateEnchantment(EEntityType entityType, EEnchantmentActivation activation)
        {
            Type = entityType;
            Activation = activation;
        }

        public EEntityType Type { get; set; }

        public EEnchantmentActivation Activation { get; set; }

        public override ETaskState Process()
        {

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            entities.ForEach(p =>
            {
                p.Enchantments.ForEach(t =>
                {
                    if (t.Activation == Activation)
                    {
                        t.Activate(Controller, p, Target as IPlayable);
                    }
                });

            });

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ActivateEnchantment(Type, Activation);
            clone.Copy(this);
            return clone;
        }
    }
}