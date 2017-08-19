using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum PlayType { SPELL };
	public class PlayTask : SimpleTask
	{
		public PlayTask(PlayType playType, IPlayable playable)
		{
			PlayType = playType;
			Playable = playable;
		}

		public PlayType PlayType { get; set; }

		public IPlayable Playable { get; set; }

		public override TaskState Process()
		{
			switch (PlayType)
			{
				case PlayType.SPELL:
					Generic.PlaySpell.Invoke(Controller, (Spell)Playable, null);
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{
			var clone = new PlayTask(PlayType, Playable);
			clone.Copy(this);
			return clone;
		}
	}
}
