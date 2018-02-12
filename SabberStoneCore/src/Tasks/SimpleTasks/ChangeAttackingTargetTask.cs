using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

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
			//System.Collections.Generic.List<IPlayable> typeA = IncludeTask.GetEntities(TypeA, Controller, Source, Target, Playables);
			//System.Collections.Generic.List<IPlayable> typeB = IncludeTask.GetEntities(TypeB, Controller, Source, Target, Playables);
			List<IPlayable> typeA = IncludeTask.GetEntities(TypeA, Controller, Source, Target, Playables).ToList();
			List<IPlayable> typeB = IncludeTask.GetEntities(TypeB, Controller, Source, Target, Playables).ToList();
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

			if (Game.Logging)
				Game.Log(LogLevel.INFO, BlockType.ATTACK, "ChangeAttackingTargetTask", !Game.Logging? "":$"{attacker} target {Game.ProposedDefender} changed to {newDefender.Id}.");

			Game.ProposedDefender = newDefender.Id;
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
