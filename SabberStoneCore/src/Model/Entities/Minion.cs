﻿using System;
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Entity which is a character that can reside in the <see cref="Controller.BoardZone"/> and perform
	/// certain actions (provided through <see cref="Character{Minion}"/>.
	/// </summary>
	/// <seealso cref="Character{Minion}" />
	public partial class Minion : Character<Minion>
	{
		/// <summary>Initializes a new instance of the <see cref="Minion"/> class.</summary>
		/// <param name="controller">Owner of the character; not specifically limited to players.</param>
		/// <param name="card">The card which this character embodies.</param>
		/// <param name="tags">Properties of this entity.</param>
		/// <autogeneratedoc />
		public Minion(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Minion", !Game.Logging? "":$"{this} ({Card.Class}) was created.");
		}

		/// <summary>
		/// A copy constructor.
		/// </summary>
		/// <param name="controller">The target <see cref="Controller"/> instance.</param>
		/// <param name="minion">The source <see cref="Minion"/>.</param>
		private Minion(Controller controller, Minion minion) : base(controller, minion) { }

		/// <summary>Character can attack.</summary>
		/// <autogeneratedoc />
		public override bool CanAttack => ChargeBuffed() && base.CanAttack && AttackDamage > 0;

		private bool ChargeBuffed()
		{
			if (NumAttacksThisTurn == 0 && HasCharge && IsExhausted)
			{
				IsExhausted = false;
			}
			return true;
		}

		/// <summary>Disables all special effects on this minion.
		/// It's not possible to undo a silence!
		/// </summary>
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
			HasLifeSteal = false;
			CantBeTargetedByHeroPowers = false;
			CantBeTargetedBySpells = false;
			//IsImmune = false;

			int sp = this[GameTag.SPELLPOWER];
			if (sp > 0)
			{
				Controller.CurrentSpellPower -= sp;
				this[GameTag.SPELLPOWER] = 0;
			}
			OngoingEffect?.Remove();
			RemoveEnchantments?.Invoke();

			AttackDamage = Card[GameTag.ATK];
			if (Health > Card[GameTag.HEALTH])
			{
				Health = Card[GameTag.HEALTH];
			}
			else
			{
				int cardBaseHealth = Card[GameTag.HEALTH];
				int delta = BaseHealth - cardBaseHealth;
				if (delta > 0)
					Damage -= delta;
				this[GameTag.HEALTH] = Card[GameTag.HEALTH];
			}


			IsSilenced = true;

			Game.Log(LogLevel.INFO, BlockType.PLAY, "Minion", !Game.Logging? "":$"{this} got silenced!");
		}

		/// <summary>
		/// Gets a value indicating whether this entity is playable by the player. Some entities require specific
		/// requirements before they can be played. This method will process the requirements and produce
		/// a result for the current state of the game.
		/// </summary>
		/// <value><c>true</c> if this entity is playable; otherwise, <c>false</c>.</value>
		public override bool IsPlayableByPlayer
		{
			get
			{
				// check if we got a slot on board for minions
				if (Controller.BoardZone.IsFull)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging? "":$"{this} isn't playable, because not enough place on board.");
					return false;
				}

				return base.IsPlayableByPlayer;
			}
		}

		public override IPlayable Clone(Controller controller)
		{
			return new Minion(controller, this);
		}
	}

	public partial class Minion
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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

		public int LastBoardPosition
		{
			get { return GetNativeGameTag(GameTag.TAG_LAST_KNOWN_POSITION_ON_BOARD); }
			set { SetNativeGameTag(GameTag.TAG_LAST_KNOWN_POSITION_ON_BOARD, value); }
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
