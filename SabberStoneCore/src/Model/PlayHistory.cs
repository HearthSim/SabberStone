﻿using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model
{
	public class PlayHistoryEntry
	{
		public readonly int SourceController;
		public readonly int TargetController;
		public readonly Card SourceCard;
		public readonly Card TargetCard;
		public readonly int SubOption;

		public PlayHistoryEntry(IPlayable source, IPlayable target = null, int chooseOne = -1)
		{
			SourceController = source.Controller.PlayerId;
			TargetController = target?.Controller.PlayerId ?? 0;
			SourceCard = source.Card;
			TargetCard = target?.Card;
			SubOption = chooseOne;
		}

		public PlayHistoryEntry(Card srcCard)
		{
			SourceCard = srcCard;
		}
	}
}
