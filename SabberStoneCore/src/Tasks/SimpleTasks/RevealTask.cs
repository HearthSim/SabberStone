using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RevealTask : SimpleTask
	{
		private readonly CardType _type;

		public RevealTask(ISimpleTask successJoustTask, ISimpleTask failedJoustTask = null, CardType type = CardType.MINION)
		{
			SuccessJoustTask = successJoustTask;
			FailedJoustTask = failedJoustTask;
			_type = type;
		}

		public ISimpleTask SuccessJoustTask { get; set; }

		public ISimpleTask FailedJoustTask { get; set; }

		public override TaskState Process()
		{
			if (Game.History)
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.JOUST, Source.Id, "", 0, 0));
			IPlayable playable = Generic.JoustBlock.Invoke(Controller, _type);
			if (Game.History)
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
			if (playable != null)
			{
				// add joust card winner to stack
				Playables = new List<IPlayable> { playable };

				SuccessJoustTask.Game = Game;
				SuccessJoustTask.Controller = Controller;
				SuccessJoustTask.Source = Source;
				SuccessJoustTask.Target = Target;

				return SuccessJoustTask.Process();
			}

			if (FailedJoustTask != null)
			{
				FailedJoustTask.Game = Game;
				FailedJoustTask.Controller = Controller;
				FailedJoustTask.Source = Source;
				FailedJoustTask.Target = Target;

				return FailedJoustTask.Process();
			}

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RevealTask(SuccessJoustTask.Clone(), FailedJoustTask?.Clone(), _type);
			clone.Copy(this);
			return clone;
		}
	}
}
