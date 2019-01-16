#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChangeAttackingTargetTask : SimpleTask
	{
		/// <param name="typA">The attacker</param>
		/// <param name="typB">New Defender</param>
		public ChangeAttackingTargetTask(EntityType typA, EntityType typB)
		{
			TypeA = typA;
			TypeB = typB;
		}

		public EntityType TypeA { get; set; }
		public EntityType TypeB { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.List<IPlayable> typeA = IncludeTask.GetEntities(TypeA, in controller, source, target, stack?.Playables);
			//System.Collections.Generic.List<IPlayable> typeB = IncludeTask.GetEntities(TypeB, in controller, source, target, stack?.Playables);
			List<IPlayable> typeA = IncludeTask.GetEntities(TypeA, in controller, source, target, stack?.Playables)
				.ToList();
			List<IPlayable> typeB = IncludeTask.GetEntities(TypeB, in controller, source, target, stack?.Playables)
				.ToList();
			if (typeA.Count != 1 || typeB.Count != 1) return TaskState.STOP;

			var attacker = typeA[0] as ICharacter;
			var newDefender = typeB[0] as ICharacter;
			if (attacker == null || newDefender == null) return TaskState.STOP;

			if (game.Logging)
				game.Log(LogLevel.INFO, BlockType.ATTACK, "ChangeAttackingTargetTask",
					!game.Logging ? "" : $"{attacker} target {game.ProposedDefender} changed to {newDefender.Id}.");

			game.ProposedDefender = newDefender.Id;
			game.CurrentEventData.EventTarget = newDefender;
			return TaskState.COMPLETE;
		}
	}
}
