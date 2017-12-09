using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Interface for an entity which can be played from <see cref="Zone.HAND"/> into
	/// <see cref="Zone.PLAY"/>, in other words: the entity can be 'played'.
	/// </summary>
	/// <seealso cref="ITargeting" />
	public interface IPlayable : ITargeting
	{
		/// <summary>Gets a value indicating whether this entity is playable. Some entities require specific
		/// requirements before they can be played. This method will process the requirements and produce
		/// a result for the current state of the game.
		/// </summary>
		/// <value><c>true</c> if this entity is playable; otherwise, <c>false</c>.</value>
		bool IsPlayable { get; }

		/// <summary>Gets a value indicating whether this entity is playable by player. Dynamic requirements
		/// are checked, eg: If a spell costs health instead of mana, this method will return <c>false</c>
		/// if the health cost would be higher than the available health.
		/// </summary>
		/// <value><c>true</c> if this entity is playable by player; otherwise, <c>false</c>.</value>
		bool IsPlayableByPlayer { get; }

		/// <summary>Gets a value indicating whether this entity is playable by card requirements.
		/// Static requirements are checked.</summary>
		/// <value><c>true</c> if this entity is playable by card requirements; otherwise, <c>false</c>.</value>
		bool IsPlayableByCardReq { get; }

		/// <summary>Gets or sets a value indicating whether this entity is ignoring damage.
		/// This is usefull when damage related tags have to be edited without causing
		///	side-effects on this entities health and destruction status.
		/// </summary>
		/// <value><c>true</c> if this instance is ignoring damage; otherwise, <c>false</c>.</value>
		bool IsIgnoreDamage { get; set; }

		/// <summary>Gets a value indicating whether this <see cref="IPlayable"/> has a combo effect.</summary>
		/// <value><c>true</c> if combo; otherwise, <c>false</c>.</value>
		bool Combo { get; }

		/// <summary>Gets or sets the amount of resources this entity costs to play.</summary>
		/// <value>The cost.</value>
		int Cost { get; set; }

		/// <summary>Gets or sets the number of turns this entity is in <see cref="Zone.PLAY"/>.</summary>
		/// <value>The number of turns in play.</value>
		int NumTurnsInPlay { get; set; }

		/// <summary>Mark this entity for destruction.</summary>
		/// <returns>Returns itself.</returns>
		void Destroy();

		/// <summary>
		/// Gets a value indicating whether this entity will be destroyed during the next cleanup
		/// phase.
		/// </summary>
		/// <value><c>true</c> if pending destruction; otherwise, <c>false</c>.</value>
		bool ToBeDestroyed { get; set; }

		// Unused
		// bool TurnStart { get; set; }

		/// <summary>Applies on of the enchantments defined on this entity.</summary>
		/// <param name="activation">The activation trigger for the enchants.</param>
		/// <param name="zoneType">Type of the zone the enchant will perform on.</param>
		/// <param name="target">The target, mostly of type <see cref="ICharacter"/>.</param>
		void ApplyEnchantments(EnchantmentActivation activation, Zone zoneType, IPlayable target = null);

		/// <summary>Stores the next Order Of Play index held by the <see cref="Game"/> instance.
		///	Order of play is important because it's the order in which effects are resolved.
		/// </summary>
		/// <param name="type">The type of this entity, stringified.</param>
		//void SetOrderOfPlay(string type);

		/// <summary>Gets or sets the entity ID target.</summary>
		/// <value><see cref="IEntity.Id"/></value>
		int CardTarget { get; set; }

		/// <summary>
		/// Playable zoneposition.
		/// </summary>
		int ZonePosition { get; set; }

		/// <summary>
		/// Playable has just been played.
		/// </summary>
		bool JustPlayed { get; set; }

		/// <summary>
		/// Playable has been summoned.
		/// </summary>
		bool IsSummoned { get; set; }

		/// <summary>
		/// Playable is exhausted. <c>true</c> indicates that the entity cannot
		/// perform it's effect anymore.
		/// eg: <see cref="Minion"/>s cannot attack when exhausted.
		/// eg: <see cref="HeroPower"/>s cannot be triggered when exhausted.
		/// </summary>
		bool IsExhausted { get; set; }

		/// <summary>
		/// Playable is overloading mana.
		/// </summary>
		int Overload { get; set; }

		/// <summary>
		/// Playable has deathrattle.
		/// </summary>
		bool HasDeathrattle { get; set; }

		/// <summary>
		/// Playable has lifesteal.
		/// </summary>
		bool HasLifeSteal { get; set; }

		/// <summary>Gets the set of playables necessary for the 'choose one' action
		/// invoked by this entity. This list is hardcoded into the card data of this
		/// entity.
		/// The controller must have chosen one of these playables
		/// before this entity can be moved into <see cref="Zone.PLAY"/>.
		/// </summary>
		/// <value>Playables to choose from.</value>
		IPlayable[] ChooseOnePlayables { get; set; }

		/// <summary>Gets or sets the enchantments attached to this entity.
		/// These enchantments are hardcoded into the card data, from which this entity
		/// is constructed.
		/// </summary>
		/// <value><see cref="Enchantment"/></value>
		List<Enchantment> Enchantments { get; set; }

		/// <summary>
		/// Performs a deep copy of this <see cref="Controller"/> instance and returns the result.
		/// <para />
		/// Copied instance and all entities in its zones are deep copied to the target <see cref="Controller"/> instance.
		/// <para />
		/// Also, the copied <see cref="IPlayable"/> is added to the <see cref="Game.IdEntityDic"/> of the target <see cref="Controller"/>'s <see cref="Game"/>.
		/// </summary>
		/// <param name="controller">The target <see cref="Controller"/> instance.</param>
		/// <returns></returns>
		IPlayable Clone(Controller controller);
	}

	/// <summary>
	/// Base implementation of the <see cref="IPlayable"/> interface.
	/// </summary>
	/// <typeparam name="T">Instance deriving from <see cref="Entity"/></typeparam>
	/// <seealso cref="Targeting" />
	/// <seealso cref="IPlayable" />
	public abstract partial class Playable<T> : Targeting, IPlayable where T : Entity
	{
		/// <summary>Initializes a new instance of the <see cref="Playable{T}"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		protected Playable(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			if (Card.Enchantments != null)
				Enchantments = new List<Enchantment>(Card.Enchantments);
		}

		/// <inheritdoc />
		/// <summary>
		/// A copy constructor. This constructor is only used to the inherited copy constructors.
		/// </summary>
		/// <param name="controller">The target <see cref="T:SabberStoneCore.Model.Entities.Controller" /> instance.</param>
		/// <param name="playable">The source <see cref="T:SabberStoneCore.Model.Entities.Playable`1" /></param>
		protected Playable(Controller controller, Playable<T> playable) : base(controller, playable)
		{
			if (playable.Enchantments != null)
				Enchantments = new List<Enchantment>(playable.Enchantments);

			if (playable.ChooseOnePlayables != null)
			{
				ChooseOnePlayables = new IPlayable[2];
				Array.Copy(playable.ChooseOnePlayables, ChooseOnePlayables, 2);
			}

			controller.Game.IdEntityDic.Add(playable.Id, this);
		}

		/// <summary>
		/// Gets the set of playables necessary for the 'choose one' action
		/// invoked by this entity. This list is hardcoded into the card data of this
		/// entity.
		/// The controller must have chosen one of these playables
		/// before this entity can be moved into <see cref="F:SabberStoneCore.Enums.Zone.PLAY" />.
		/// </summary>
		/// <value>Playables to choose from.</value>
		/// <autogeneratedoc />
		public IPlayable[] ChooseOnePlayables { get; set; }

		/// <summary>
		/// Gets or sets the enchantments attached to this entity.
		/// These enchantments are hardcoded into the card data, from which this entity
		/// is constructed.
		/// </summary>
		/// <value>
		/// <see cref="T:SabberStoneCore.Enchants.Enchantment" />
		/// </value>
		/// <autogeneratedoc />
		public List<Enchantment> Enchantments { get; set; }

		/// <summary>Applies on of the enchantments defined on this entity.</summary>
		/// <param name="activation">The activation trigger for the enchants.</param>
		/// <param name="zoneType">Type of the zone the enchant will perform on.</param>
		/// <param name="target">The target, mostly of type <see cref="T:SabberStoneCore.Model.Entities.ICharacter" />.</param>
		/// <autogeneratedoc />
		public virtual void ApplyEnchantments(EnchantmentActivation activation, Zone zoneType, IPlayable target = null)
		{
			if (Enchantments == null || Enchantments.Count == 0)
				return;

			var removeEnchantments = new List<Enchantment>();

			Enchantments.ForEach(p =>
			{
				if (p.Activation == activation && (Zone == null || Zone.Type == zoneType))
				{
					p.Activate(Controller, this, target);
					if (p.RemoveAfterActivation)
					{
						removeEnchantments.Add(p);
					}
				}
			});

			removeEnchantments.ForEach(p => Enchantments.Remove(p));
		}

		/// <summary>
		/// Stores the next Order Of Play index held by the <see cref="T:SabberStoneCore.Model.Game" /> instance.
		/// Order of play is important because it's the order in which effects are resolved.
		/// </summary>
		/// <param name="type">The type of this entity, stringified.</param>
		/// <autogeneratedoc />
		//public void SetOrderOfPlay(string type)
		//{
		//	if (type.Equals("PLAY")
		//	 || type.Equals("SECRET_OR_QUEST")
		//	 || type.Equals("WEAPON"))
		//	{
		//		OrderOfPlay = Game.NextOop;
		//	}
		//}

		/// <summary>Mark this entity for destruction.</summary>
		/// <returns>Returns itself.</returns>
		/// <autogeneratedoc />
		public void Destroy()
		{
			ToBeDestroyed = true;
			Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"{this} just got set to be destroyed.");
			//return this;
		}

		/// <summary>
		/// Gets a value indicating whether this entity is playable. Some entities require specific
		/// requirements before they can be played. This method will process the requirements and produce
		/// a result for the current state of the game.
		/// </summary>
		/// <value><c>true</c> if this entity is playable; otherwise, <c>false</c>.</value>
		/// <autogeneratedoc />
		public bool IsPlayable => IsPlayableByPlayer && IsPlayableByCardReq;

		/// <summary>
		/// Gets a value indicating whether this entity is playable by player. Dynamic requirements
		/// are checked, eg: If a spell costs health instead of mana, this method will return <c>false</c>
		/// if the health cost would be higher than the available health.
		/// </summary>
		/// <value><c>true</c> if this entity is playable by player; otherwise, <c>false</c>.</value>
		/// <autogeneratedoc />
		public virtual bool IsPlayableByPlayer
		{
			get
			{
				// check if player has enough mana to play card
				if (Controller.RemainingMana < Cost)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging ? "" : $"{this} isn't playable, because not enough mana to pay cost.");
					return false;
				}

				// check if player is on turn
				if (Controller != Game.CurrentPlayer)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging ? "" : $"{this} isn't playable, because player not on turn.");
					return false;
				}

				// check if entity is in hand to be played
				if (Zone != Controller.HandZone && !(this is HeroPower))
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging ? "" : $"{this} isn't playable, because card not in hand.");
					return false;
				}

				return true;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this entity is playable by card requirements.
		/// Static requirements are checked.
		/// </summary>
		/// <value><c>true</c> if this entity is playable by card requirements; otherwise, <c>false</c>.</value>
		/// <autogeneratedoc />
		public bool IsPlayableByCardReq
		{
			get
			{
				// check if we need a target and there are some
				if (Card.RequiresTarget && ValidPlayTargets.Count() == 0)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"{this} isn't playable, because need valid target and we don't have one.");
					return false;
				}

				// check requirments on cards here 
				foreach (KeyValuePair<PlayReq, int> item in Card.PlayRequirements)
				{
					PlayReq req = item.Key;
					int param = item.Value;

					Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"{this} check PlayReq {req} ... !");

					switch (req)
					{
						case PlayReq.REQ_NUM_MINION_SLOTS:
							{
								if (Controller.BoardZone.IsFull)
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"Board is full can't summon new minion.");
									return false;
								}
								break;
							}
						case PlayReq.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY:
							{
								var ids = Controller.BoardZone.Select(p => p.Card.Id).ToList();
								bool containsAll = true;
								Card.Entourage.ForEach(p => containsAll &= ids.Contains(p));
								if (containsAll)
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"All ready all entourageing cards summoned.");
									return false;
								}
								break;
							}
						case PlayReq.REQ_WEAPON_EQUIPPED:
							{
								if (Controller.Hero.Weapon == null)
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"Need a weapon to play this card.");
									return false;
								}
								break;
							}
						case PlayReq.REQ_MINIMUM_ENEMY_MINIONS:
							{
								if (Controller.Opponent.BoardZone.Count < param)
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"Need at least {param} enemy minions to play this card.");
									return false;
								}
								break;
							}
						case PlayReq.REQ_MINIMUM_TOTAL_MINIONS:
							{
								if (Controller.BoardZone.Count + Controller.Opponent.BoardZone.Count < param)
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"Need at least {param} minions to play this card.");
									return false;
								}
								break;
							}
						case PlayReq.REQ_STEADY_SHOT:
							{
								if (!Controller.Hero.Power.Card.Id.Equals("DS1h_292"))
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"Need steady shoot to be used.");
									return false;
								}
								break;
							}

						case PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME:
							{
								if (!Controller.GraveyardZone.Any(p => p is Minion && p.ToBeDestroyed))
								{
									Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"No friendly minions died this game.");
									return false;
								}
								break;
							}

						// implemented in Targeting
						case PlayReq.REQ_TARGET_FOR_COMBO:
						case PlayReq.REQ_FROZEN_TARGET:
						case PlayReq.REQ_MINION_OR_ENEMY_HERO:
						case PlayReq.REQ_TARGET_MAX_ATTACK:
						case PlayReq.REQ_MINION_TARGET:
						case PlayReq.REQ_FRIENDLY_TARGET:
						case PlayReq.REQ_ENEMY_TARGET:
						case PlayReq.REQ_UNDAMAGED_TARGET:
						case PlayReq.REQ_DAMAGED_TARGET:
						case PlayReq.REQ_TARGET_WITH_RACE:
						case PlayReq.REQ_MUST_TARGET_TAUNTER:
						case PlayReq.REQ_TARGET_MIN_ATTACK:
						case PlayReq.REQ_TARGET_WITH_DEATHRATTLE:
						case PlayReq.REQ_TARGET_WITH_BATTLECRY:
						case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND:
						case PlayReq.REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN:
						case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS:
						case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS:
						case PlayReq.REQ_NONSELF_TARGET:
							break;

						// already implemented ... card.RequiresTarget and RequiresTargetIfAvailable
						case PlayReq.REQ_TARGET_TO_PLAY:
						case PlayReq.REQ_TARGET_IF_AVAILABLE:
							break;

						default:
							Game.Log(LogLevel.ERROR, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"PlayReq {req} not in switch needs to be added (Playable)!");
							break;
					}
				}

				return true;

			}
		}

		public abstract IPlayable Clone(Controller controller);
	}


	public abstract partial class Playable<T>
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public int ZonePosition
		{
			//get { return this[GameTag.ZONE_POSITION] - 1; }
			//set { this[GameTag.ZONE_POSITION] = value + 1; }
			get { return _data[GameTag.ZONE_POSITION] - 1; }
			set { SetNativeGameTag(GameTag.ZONE_POSITION, value + 1); }
		}

		public bool JustPlayed
		{
			get { return this[GameTag.JUST_PLAYED] == 1; }
			set { this[GameTag.JUST_PLAYED] = value ? 1 : 0; }
		}

		public bool IsSummoned
		{
			get { return this[GameTag.SUMMONED] == 1; }
			set { this[GameTag.SUMMONED] = value ? 1 : 0; }
		}

		public bool IsExhausted
		{
			get { return this[GameTag.EXHAUSTED] == 1; }
			set { this[GameTag.EXHAUSTED] = value ? 1 : 0; }
		}

		public int Overload
		{
			get { return this[GameTag.OVERLOAD]; }
			set { this[GameTag.OVERLOAD] = value; }
		}

		public bool HasDeathrattle
		{
			get { return this[GameTag.DEATHRATTLE] == 1; }
			set { this[GameTag.DEATHRATTLE] = value ? 1 : 0; }
		}

		public bool HasLifeSteal
		{
			get { return this[GameTag.LIFESTEAL] == 1; }
			set { this[GameTag.LIFESTEAL] = value ? 1 : 0; }
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
