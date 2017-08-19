using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class LogTask : SimpleTask
	{
		public LogTask(bool cardTextPrint = false)
		{
			CardTextPrint = cardTextPrint;
		}

		public bool CardTextPrint { get; set; }

		public override TaskState Process()
		{
			if (true)
			{
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", $"Log task is beeing processed!");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", $"Flag: {Flag}, Number: {Number}");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", $"Controller: {Controller?.Name}, Source: {Source}, Target: {Target}!");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", $"Playables: {String.Join(",", Playables.Select(x => x.Card))} [{Playables.Count}]");
			}

			if (CardTextPrint)
			{
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", $"{Source.Card.Text}");
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new LogTask(CardTextPrint);
			clone.Copy(this);
			return clone;
		}
	}
}
