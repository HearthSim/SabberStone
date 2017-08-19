using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum PlayType { SPELL };

	/// <summary>
	/// Allows to have a playable played out in a task
	/// </summary>
	public class PlayTask : SimpleTask
	{
		/// <summary>
		/// Create a PlayTask to play a card as a task.
		/// </summary>
		/// <param name="playType">The type of playable.</param>
		public PlayTask(PlayType playType)
		{
			PlayType = playType;
		}

		public PlayType PlayType { get; set; }

		public override TaskState Process()
		{
			switch (PlayType)
			{
				case PlayType.SPELL:
					Playables.ForEach(p =>
					{
						if (p is Spell && Generic.RemoveFromZone(Controller, p))
						{
							bool success = Generic.PlaySpell.Invoke(Controller, (Spell)p, null);
						}
					});
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{
			var clone = new PlayTask(PlayType);
			clone.Copy(this);
			return clone;
		}
	}
}
