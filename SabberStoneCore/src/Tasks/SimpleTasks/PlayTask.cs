using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
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
		private readonly bool _randTarget;

		/// <summary>
		/// Create a PlayTask to play a card as a task.
		/// </summary>
		/// <param name="playType">The type of playable.</param>
		/// <param name="randTarget">true if the target of the playable is chosen randomly</param>
		public PlayTask(PlayType playType, bool randTarget = false)
		{
			PlayType = playType;
			_randTarget = randTarget;
		}

		public PlayType PlayType { get; set; }

		public override TaskState Process()
		{
			switch (PlayType)
			{
				case PlayType.SPELL:
					Playables.ForEach(p =>
					{
						ICharacter randTarget = null;
						if (_randTarget && p.Card.RequiresTarget)
						{
							List<ICharacter> targets = (List<ICharacter>)p.ValidPlayTargets;

							randTarget = targets.Count > 0 ? Util.RandomElement(targets) : throw new InvalidOperationException();

							p.CardTarget = randTarget?.Id ?? -1;

							Game.Log(LogLevel.INFO, BlockType.POWER, "PlayTask",
								!Game.Logging ? "" : $"{p}'s target is randomly selected to {randTarget}");
						}
						if (p is Spell && (p.Zone == null || Generic.RemoveFromZone(Controller, p)))
						{
							Generic.CastSpell.Invoke(Controller, (Spell)p, randTarget, 0);
						}
					});
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{
			var clone = new PlayTask(PlayType, _randTarget);
			clone.Copy(this);
			return clone;
		}
	}
}
