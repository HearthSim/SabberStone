using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	public partial class Minion : Character<Minion>
	{
		public Minion(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Minion", $"{this} ({Card.Class}) was created.");
		}

		public override bool CanAttack => AttackDamage > 0 && ChargeBuffed() && base.CanAttack;

		private bool ChargeBuffed()
		{
			if (NumAttacksThisTurn == 0 && HasCharge && IsExhausted)
			{
				IsExhausted = false;
			}
			return true;
		}

		public void Silence()
		{
			HasTaunt = false;
			IsFrozen = false;
			IsEnraged = false;
			HasCharge = false;
			HasWindfury = false;
			HasDivineShield = false;
			HasStealth = false;
			HasDeathrattle = false;
			HasBattleCry = false;
			HasInspire = false;

			IsSilenced = true;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Minion", $"{this} got silenced!");
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
			return new Minion(newGame.ControllerById(Controller.Id), Card, null);
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public partial class Minion
	{
		public bool HasCharge
		{
			get { return this[GameTag.CHARGE] == 1; }
			set { this[GameTag.CHARGE] = value ? 1 : 0; }
		}

		public bool HasDivineShield
		{
			get { return this[GameTag.DIVINE_SHIELD] == 1; }
			set { this[GameTag.DIVINE_SHIELD] = value ? 1 : 0; }
		}

		public bool HasBattleCry
		{
			get { return this[GameTag.BATTLECRY] != 0; }
			set { this[GameTag.BATTLECRY] = value ? 1 : 0; }
		}

		public bool HasInspire
		{
			get { return this[GameTag.INSPIRE] == 1; }
			set { this[GameTag.INSPIRE] = value ? 1 : 0; }
		}

		public bool HasStealth
		{
			get { return this[GameTag.STEALTH] == 1; }
			set { this[GameTag.STEALTH] = value ? 1 : 0; }
		}

		public bool IsEnraged
		{
			get { return this[GameTag.ENRAGED] == 1; }
			set { this[GameTag.ENRAGED] = value ? 1 : 0; }
		}

		public bool Freeze
		{
			get { return this[GameTag.FREEZE] == 1; }
			set { this[GameTag.FREEZE] = value ? 1 : 0; }
		}

		public bool Poisonous
		{
			get { return this[GameTag.POISONOUS] == 1; }
			set { this[GameTag.POISONOUS] = value ? 1 : 0; }
		}
	}
}