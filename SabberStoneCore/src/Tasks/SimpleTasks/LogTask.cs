using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class LogTask : SimpleTask
	{
		public LogTask(bool cardTextPrint = false)
		{
			CardTextPrint = cardTextPrint;
		}

		public bool CardTextPrint { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (true)
			{
				game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask",
					!game.Logging ? "" : "Log task is beeing processed!");
				game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask",
					!game.Logging ? "" : $"Flag: {stack.Flag}, stack.Number: {stack.Number}");
				game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask",
					!game.Logging ? "" : $"Controller: {controller?.Name}, source: {source}, target: {target}!");
				game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask",
					!game.Logging
						? ""
						: $"stack?.Playables: {String.Join(",", stack?.Playables.Select(x => x.Card))} [{stack?.Playables.Count}]");
			}

			if (CardTextPrint)
				game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !game.Logging ? "" : $"{source.Card.Text}");

			return TaskState.COMPLETE;
		}
	}
}
