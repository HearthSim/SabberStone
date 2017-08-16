﻿using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RevealTask : SimpleTask
	{
		public ISimpleTask SuccessJoustTask { get; set; }

		public ISimpleTask FailedJoustTask { get; set; }

		public RevealTask(ISimpleTask successJoustTask, ISimpleTask failedJoustTask = null)
		{
			SuccessJoustTask = successJoustTask;
			FailedJoustTask = failedJoustTask;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IPlayable playable = Generic.JoustBlock.Invoke(Controller);
			if (playable != null)
			{
				// add joust card winner to stack
				Playables = new List<IPlayable> { playable };

				SuccessJoustTask.Game = Game;
				SuccessJoustTask.Controller = Controller;
				SuccessJoustTask.Source = Source;
				SuccessJoustTask.Target = Target;
				SuccessJoustTask.Playables = Playables;
				SuccessJoustTask.CardIds = CardIds;
				SuccessJoustTask.Flag = Flag;
				SuccessJoustTask.Number = Number;
				SuccessJoustTask.Number1 = Number1;
				SuccessJoustTask.Number2 = Number2;
				SuccessJoustTask.Number3 = Number3;
				SuccessJoustTask.Number4 = Number4;
				return SuccessJoustTask.Process();
			}

			if (FailedJoustTask != null)
			{
				FailedJoustTask.Game = Game;
				FailedJoustTask.Controller = Controller;
				FailedJoustTask.Source = Source;
				FailedJoustTask.Target = Target;
				FailedJoustTask.Playables = Playables;
				FailedJoustTask.CardIds = CardIds;
				FailedJoustTask.Flag = Flag;
				FailedJoustTask.Number = Number;
				FailedJoustTask.Number1 = Number1;
				FailedJoustTask.Number2 = Number2;
				FailedJoustTask.Number3 = Number3;
				FailedJoustTask.Number4 = Number4;
				return FailedJoustTask.Process();
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RevealTask(SuccessJoustTask?.Clone(newGame), FailedJoustTask?.Clone(newGame));
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}