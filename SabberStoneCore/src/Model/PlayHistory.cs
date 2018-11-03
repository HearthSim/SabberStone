using SabberStoneCore.Model.Entities;
using System.Text;

namespace SabberStoneCore.Model
{
	public class PlayHistoryEntry
	{
		public readonly int SourceController;
		public readonly int TargetController;
		public readonly Card SourceCard;
		public readonly Card TargetCard;
		public readonly int SubOption;

		public PlayHistoryEntry(in IPlayable source, in ICharacter target = null, in int chooseOne = -1)
		{
			SourceController = source.Controller.PlayerId;
			TargetController = target?.Controller.PlayerId ?? 0;
			SourceCard = source.Card;
			TargetCard = target?.Card;
			SubOption = chooseOne;
		}

		public PlayHistoryEntry(in Card srcCard)
		{
			SourceCard = srcCard;
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
