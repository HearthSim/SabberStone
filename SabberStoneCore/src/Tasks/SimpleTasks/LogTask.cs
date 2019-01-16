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
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !Game.Logging? "":$"Log task is beeing processed!");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !Game.Logging? "": $"Flag: {Flag}, Number: {Number}");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !Game.Logging? "":$"Controller: {Controller?.Name}, Source: {Source}, Target: {Target}!");
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !Game.Logging? "":$"Playables: {String.Join(",", Playables.Select(x => x.Card))} [{Playables.Count}]");
			}

			if (CardTextPrint)
			{
				Game.Log(LogLevel.INFO, BlockType.PLAY, "LogTask", !Game.Logging? "":$"{Source.Card.Text}");
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
