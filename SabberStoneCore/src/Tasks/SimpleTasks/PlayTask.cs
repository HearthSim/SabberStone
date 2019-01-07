using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum PlayType
	{
		SPELL
	}

	/// <summary>
	///     Allows to have a playable played out in a task
	/// </summary>
	public class PlayTask : SimpleTask
	{
		private readonly bool _randTarget;

		/// <summary>
		///     Create a PlayTask to play a card as a task.
		/// </summary>
		/// <param name="playType">The type of playable.</param>
		/// <param name="randTarget">true if the target of the playable is chosen randomly</param>
		public PlayTask(PlayType playType, bool randTarget = false)
		{
			PlayType = playType;
			_randTarget = randTarget;
		}

		public PlayType PlayType { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			switch (PlayType)
			{
				case PlayType.SPELL:
					foreach (IPlayable p in stack?.Playables)
					{
						ICharacter randTarget = null;
						if (_randTarget && p.Card.MustHaveTargetToPlay)
						{
							var targets = (List<ICharacter>) p.ValidPlayTargets;

							randTarget = targets.Count > 0
								? Util.RandomElement(targets)
								: throw new InvalidOperationException();

							p.CardTarget = randTarget?.Id ?? -1;

							game.Log(LogLevel.INFO, BlockType.POWER, "PlayTask",
								!game.Logging ? "" : $"{p}'s target is randomly selected to {randTarget}");
						}

						if (p is Spell spell && (p.Zone == null || Generic.RemoveFromZone(controller, p)))
							Generic.CastSpell.Invoke(controller, spell, randTarget, 0, true);

						while (controller.Choice != null)
							Generic.ChoicePick(controller, Util.Choose(controller.Choice.Choices));
					}

					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}
	}
}
