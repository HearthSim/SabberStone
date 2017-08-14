using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChangeAttackingTargetTask : SimpleTask
	{
		public EntityType TypeA { get; set; }
		public EntityType TypeB { get; set; }

		public ChangeAttackingTargetTask(EntityType typA, EntityType typB)
		{
			TypeA = typA;
			TypeB = typB;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> typeA = IncludeTask.GetEntites(TypeA, Controller, Source, Target, Playables);
			List<IPlayable> typeB = IncludeTask.GetEntites(TypeB, Controller, Source, Target, Playables);
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

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ChangeAttackingTargetTask(TypeA, TypeB);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}