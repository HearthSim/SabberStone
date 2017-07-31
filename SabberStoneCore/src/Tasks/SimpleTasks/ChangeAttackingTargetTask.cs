using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ChangeAttackingTargetTask : SimpleTask
    {
        public ChangeAttackingTargetTask(EntityType typA, EntityType typB)
        {
            TypeA = typA;
            TypeB = typB;
        }

        public EntityType TypeA { get; set; }
        public EntityType TypeB { get; set; }

        public override TaskState Process()
        {
            var typeA = IncludeTask.GetEntites(TypeA, Controller, Source, Target, Playables);
            var typeB = IncludeTask.GetEntites(TypeB, Controller, Source, Target, Playables);
            if (typeA.Count != 1 || typeB.Count != 1)
            {
                return TaskState.STOP;
            }

            var attacker = typeA[0] as ICharacter;
            var newDefender = typeB[0] as ICharacter;
            if (attacker == null || newDefender == null)
            {
                return TaskState.STOP;
            }

            Game.Log(LogLevel.INFO, BlockType.ATTACK, "ChangeAttackingTargetTask", $"{attacker} target {attacker.ProposedDefender} changed to {newDefender.Id}.");

            attacker.ProposedDefender = newDefender.Id;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ChangeAttackingTargetTask(TypeA, TypeB);
            clone.Copy(this);
            return clone;
        }
    }
}