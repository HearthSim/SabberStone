﻿using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Entity which produces a single effect when played.
	/// </summary>
	/// <seealso cref="Playable{Spell}" />
	public partial class Spell : Playable<Spell>
	{
		/// <summary>Initializes a new instance of the <see cref="Spell"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		public Spell(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Spell", !Game.Logging ? "" : $"{card.Name} ({card.Class}) was created.");
		}

		/// <summary>
		/// Calculates if a target is valid by testing the game state for each hardcoded requirement.
		/// </summary>
		/// <param name="target">The proposed target.</param>
		/// <returns><c>true</c> if the proposed target is valid, <c>false</c> otherwise.</returns>
		/// <autogeneratedoc />
		public override bool TargetingRequirements(ICharacter target)
		{
			return !target.CantBeTargetedBySpells && base.TargetingRequirements(target);
		}

		/// <summary>
		/// Gets a value indicating whether this entity is playable by the player. Some entities require specific
		/// requirements before they can be played. This method will process the requirements and produce
		/// a result for the current state of the game.
		/// </summary>
		/// <value><c>true</c> if this entity is playable; otherwise, <c>false</c>.</value>
		public override bool IsPlayableByPlayer {
			get
			{
				// check if we can play this secret
				var spell = this as Spell;
				if (spell != null && spell.IsSecret && (Controller.SecretZone.IsFull || Controller.SecretZone.Any(p => p.Card.Id == spell.Card.Id)))
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging? "":$"{this} isn't playable, because secret already active on controller.");
					return false;
				}
				else if (spell != null && spell.IsQuest && Controller.SecretZone.Quest != null)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging ? "" : $"{this} isn't playable, because controller already has a quest in play.");
					return false;
				}

				return base.IsPlayableByPlayer;
			}
		}
	}

	public partial class Spell
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public bool IsAffectedBySpellpower => this[GameTag.AFFECTED_BY_SPELL_POWER] == 1;

		public bool IsSecret => Card[GameTag.SECRET] == 1;

		public bool IsQuest => Card[GameTag.QUEST] == 1;

		public bool IsCountered
		{
			get { return this[GameTag.COUNTER] == 1; }
			set { this[GameTag.COUNTER] = value ? 1 : 0; }
		}

		public bool ReceveivesDoubleSpellDamage
		{
			get { return this[GameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] == 1; }
			set { this[GameTag.RECEIVES_DOUBLE_SPELLDAMAGE_BONUS] = value ? 1 : 0; }
		}

		public int QuestProgress
		{
			get { return this[GameTag.QUEST_PROGRESS]; }
			set { this[GameTag.QUEST_PROGRESS] = value; }
		}

		public int QuestTotalProgress => this[GameTag.QUEST_PROGRESS_TOTAL];
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
