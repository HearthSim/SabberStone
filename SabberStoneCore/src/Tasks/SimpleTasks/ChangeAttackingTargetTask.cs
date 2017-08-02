using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ChangeAttackingTargetTask : SimpleTask
    {
        public ChangeAttackingTargetTask(EEntityType typA, EEntityType typB)
        {
            TypeA = typA;
            TypeB = typB;
        }

        public EEntityType TypeA { get; set; }
        public EEntityType TypeB { get; set; }

        public override ETaskState Process()
        {
            var typeA = IncludeTask.GetEntites(TypeA, Controller, Source, Target, Playables);
            var typeB = IncludeTask.GetEntites(TypeB, Controller, Source, Target, Playables);
            if (typeA.Count != 1 || typeB.Count != 1)
            {
                return ETaskState.STOP;
            }

            var attacker = typeA[0] as ICharacter;
            var newDefender = typeB[0] as ICharacter;
            if (attacker == null || newDefender == null)
            {
                return ETaskState.STOP;
            }

            Game.Log(ELogLevel.INFO, EBlockType.ATTACK, "ChangeAttackingTargetTask", $"{attacker} target {attacker.ProposedDefender} changed to {newDefender.Id}.");

            attacker.ProposedDefender = newDefender.Id;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new ChangeAttackingTargetTask(TypeA, TypeB);
            clone.Copy(this);
            return clone;
        }
    }
}