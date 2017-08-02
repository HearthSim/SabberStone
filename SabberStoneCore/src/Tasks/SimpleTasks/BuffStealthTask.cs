using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class BuffStealthTask : SimpleTask
    {
        public BuffStealthTask(EEntityType type)
        {
            Type = type;
        }

        public EEntityType Type { get; set; }

        public override ETaskState Process()
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

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new BuffStealthTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}