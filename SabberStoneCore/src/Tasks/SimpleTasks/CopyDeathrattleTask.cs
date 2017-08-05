using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyDeathrattleTask : SimpleTask
    {
        public EEntityType Type { get; set; }

        public override ETaskState Process()
        {
            var source = Source as Minion;
            var target = Target as Minion;

            Game.Log(ELogLevel.INFO, EBlockType.SCRIPT, "CopyDeathrattleTask", "Inside the Task.");

            if (source == null || target == null)
            {
                return ETaskState.STOP;
            }

            target.Enchantments.ForEach(p =>
            {
                if (p.Activation == EEnchantmentActivation.DEATHRATTLE)
                {
                    source.Enchantments.Add(p);
                    source.HasDeathrattle = true;
                }
            });


            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyDeathrattleTask();
            clone.Copy(this);
            return clone;
        }
    }
}