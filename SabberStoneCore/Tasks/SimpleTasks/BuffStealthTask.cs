using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.SimpleTasks.Tasks
{

    public class BuffStealthTask : SimpleTask
    {
        public BuffStealthTask(EntityType type)
        {
            Type = type;
        }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
            {
                var minion = p as Minion;
                if (minion == null)
                    return;
                var buff = new BuffTask(Buffs.StealthTurn(minion.NumAttacksThisTurn), Type);
                buff.Copy(this);
                buff.Process();
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffStealthTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}