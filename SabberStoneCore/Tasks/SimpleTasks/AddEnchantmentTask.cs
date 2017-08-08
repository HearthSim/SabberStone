using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddEnchantmentTask : SimpleTask
    {
        public AddEnchantmentTask(EntityType type, Enchantment enchantment, bool activate = false)
        {
            Type = type;
            Enchantment = enchantment;
            Activate = activate;
        }

        public EntityType Type { get; set; }

        public Enchantment Enchantment { get; set; }

        public bool Activate { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var minion = p as Minion;
                if (minion != null)
                {
                    
                    minion.HasDeathrattle = Enchantment.Activation == EnchantmentActivation.DEATHRATTLE ? true : false;
                    minion.Enchantments.Add(Enchantment);
                    if (Activate)
                    {
                        Enchantment.Activate(Controller, minion);
                    }
                }
            });
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new AddEnchantmentTask(Type, Enchantment, Activate);
            clone.Copy(this);
            return clone;
        }
    }
}