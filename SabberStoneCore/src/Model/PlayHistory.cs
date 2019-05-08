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
using SabberStoneCore.Model.Entities;
using System.Text;

namespace SabberStoneCore.Model
{
	public readonly struct PlayHistoryEntry
	{
		public readonly int SourceController;
		public readonly int TargetController;
		public readonly Card SourceCard;
		public readonly Card TargetCard;
		public readonly int SubOption;
		public readonly int SourceId;

		public PlayHistoryEntry(in IPlayable source, in ICharacter target = null, in int chooseOne = -1)
		{
			SourceController = source.Controller.PlayerId;
			TargetController = target?.Controller.PlayerId ?? 0;
			SourceCard = source.Card;
			TargetCard = target?.Card;
			SubOption = chooseOne;
			SourceId = source.Id;
		}

		public PlayHistoryEntry(in Card srcCard)
		{
			SourceCard = srcCard;

			SourceController = 0;
			TargetController = 0;
			TargetCard = null;
			SubOption = 0;
			SourceId = 0;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder($"[P{SourceController}]");
			sb.Append($"[{SourceCard}]");
			if (SubOption > 0)
				sb.Append($"[SubOption:{SubOption}]");
			if (TargetController != 0)
			{
				sb.Append("=>");
				sb.Append($"[P{TargetController}]");
				sb.Append($"[{TargetCard}]");
			}
			return sb.ToString();
		}
	}
}
