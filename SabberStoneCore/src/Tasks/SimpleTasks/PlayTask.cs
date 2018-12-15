#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
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
						if (p is Spell spell && (p.Zone == null || Generic.RemoveFromZone(Controller, p)))
						{
							Generic.CastSpell.Invoke(Controller, spell, randTarget, 0);
						}

						while (Controller.Choice != null)
						{
							Generic.ChoicePick(Controller, Util.Choose(Controller.Choice.Choices));
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
