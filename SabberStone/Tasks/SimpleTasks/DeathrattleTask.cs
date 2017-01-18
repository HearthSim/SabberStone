using log4net;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class DeathrattleTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeathrattleTask(EntityType type, Enchantment enchantment)
        {
            Type = type;
            Enchantment = enchantment;
        }

        public EntityType Type { get; set; }

        public Enchantment Enchantment { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var minion = p as Minion;
                if (minion != null)
                {
                    minion.HasDeathrattle = true;
                    minion.Enchantments.Add(Enchantment);
                }
            });
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DeathrattleTask(Type, Enchantment);
            clone.Copy(this);
            return clone;
        }
    }
}