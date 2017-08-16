using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	public class Spell : Playable<Spell>
	{
		public Spell(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Spell", $"{card.Name} ({card.Class}) was created.");
		}

		public override bool TargetingRequirements(ICharacter target)
		{
			return !target.CantBeTargetedBySpells && base.TargetingRequirements(target);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		protected override void InternalStamp(IModel entity)
		{
			// Do nothing, nothing to stamp.
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			// Do nothing, nothing to report.
			return String.Empty;
		}

		protected override Entity InternalDeepClone(Game newGame)
		{
			return new Spell(newGame.ControllerById(Controller.Id), Card, null);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		public bool IsAffectedBySpellpower => this[GameTag.AFFECTED_BY_SPELL_POWER] == 1;

		public bool IsSecret => this[GameTag.SECRET] == 1;

		public bool IsQuest => this[GameTag.QUEST] == 1;

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
}