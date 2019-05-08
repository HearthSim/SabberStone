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
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RevealTask : SimpleTask
	{
		private readonly ISimpleTask _failedJoustTask;
		private readonly ISimpleTask _successJoustTask;
		private readonly CardType _type;

		public RevealTask(ISimpleTask successJoustTask, ISimpleTask failedJoustTask = null,
			CardType type = CardType.MINION)
		{
			_successJoustTask = successJoustTask;
			_failedJoustTask = failedJoustTask;
			_type = type;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (game.History)
				game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.JOUST, source.Id, "", 0, 0));
			IPlayable playable = Generic.JoustBlock.Invoke(controller, _type);
			if (game.History)
				game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
			if (playable != null)
			{
				// add joust card winner to stack
				if (stack != null)
				{
					stack.Playables = new[] {playable};
					return _successJoustTask.Process(in game, in controller, in source, in target, in stack);
				}
				else
				{
					var tempStack = new TaskStack();
					tempStack.Playables = new[] { playable };
					return _successJoustTask.Process(in game, in controller, in source, in target, in tempStack);
				}
			}

			if (_failedJoustTask != null) return _failedJoustTask.Process(in game, in controller, in source, in target, in stack);

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
