using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class LogTask : SimpleTask
	{
		public bool CardTextPrint { get; set; }

		public LogTask(bool cardTextPrint = false)
		{
			CardTextPrint = cardTextPrint;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(LogTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new LogTask(CardTextPrint);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}