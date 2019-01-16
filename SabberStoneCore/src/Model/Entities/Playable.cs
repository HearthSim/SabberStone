#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Interface for an entity which can be played from <see cref="Zone.HAND"/> into
	/// <see cref="Zone.PLAY"/>, in other words: the entity can be 'played'.
	/// </summary>
	/// <seealso cref="IEntity" />
	public partial interface IPlayable : IEntity
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

		///// <summary>Gets or sets the number of turns this entity is in <see cref="Zone.PLAY"/>.</summary>
		///// <value>The number of turns in play.</value>
		//int NumTurnsInPlay { get; set; }

		/// <summary>Mark this entity for destruction.</summary>
		/// <returns>Returns itself.</returns>
		void Destroy();

		/// <summary>
		/// Gets a value indicating whether this entity will be destroyed during the next cleanup
		/// phase.
		/// </summary>
		/// <value><c>true</c> if pending destruction; otherwise, <c>false</c>.</value>
		bool ToBeDestroyed { get; set; }

		/// <summary>
		/// Activates <see cref="SabberStoneCore.Enchants.Power"/> and queues up tasks.
		/// </summary>
		/// <param name="activation"></param>
		/// <param name="target"></param>
		/// <param name="chooseOne"></param>
		/// <param name="source"></param>
		void ActivateTask(in PowerActivation activation, in ICharacter target = null, in int chooseOne = 0, in IPlayable source = null);

		/// <summary>Gets or sets the entity ID target.</summary>
		/// <value><see cref="IEntity.Id"/></value>
		int CardTarget { get; set; }

		/// <summary>
		/// Playable zoneposition.
		/// </summary>
		int ZonePosition { get; set; }

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
		int Overload { get; }

		/// <summary>
		/// Playable has deathrattle.
		/// </summary>
		bool HasDeathrattle { get; set; }

		/// <summary>
		/// Playable has lifesteal.
		/// </summary>
		bool HasLifeSteal { get; set; }

		/// <summary>
		/// Playable has Echo ability.
		/// </summary>
		bool IsEcho { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the target must be an option from the
		/// 'Choose One' set.
		/// </summary>
		/// <value><c>true</c> if 'Choose One' must be assumed; otherwise, <c>false</c>.</value>
		bool ChooseOne { get; }

		/// <summary>Gets the set of playables necessary for the 'choose one' action
		/// invoked by this entity. This list is hardcoded into the card data of this
		/// entity.
		/// The controller must have chosen one of these playables
		/// before this entity can be moved into <see cref="Zone.PLAY"/>.
		/// </summary>
		/// <value>Playables to choose from.</value>
		IPlayable[] ChooseOnePlayables { get; set; }

		/// <summary>Gets or sets the Powers attached to this entity.
		/// These Powers are hardcoded into the card data, from which this entity
		/// is constructed.
		/// </summary>
		/// <value><see cref="Power"/></value>
		Power Power { get; }

		/// <summary>Gets the ranking order of the moment this entity was played.</summary>
		/// <value>The ranking order.</value>
		int OrderOfPlay { get; set; }

		/// <summary>
		/// Performs a deep copy of this <see cref="Controller"/> instance and returns the result.
		/// <para />
		/// Copied instance and all entities in its zones are deep copied to the target <see cref="Controller"/> instance.
		/// <para />
		/// Also, the copied <see cref="IPlayable"/> is added to the <see cref="Game.IdEntityDic"/> of the target <see cref="Controller"/>'s <see cref="Game"/>.
		/// </summary>
		/// <param name="controller">The target <see cref="Controller"/> instance.</param>
		/// <returns></returns>
		IPlayable Clone(in Controller controller);

		/// <summary>
		/// Gets or sets Ongoing effect of this entity.
		/// Ongoing effects are minion, weapon, and boss Hero Power abilities
		/// which grant special effects on an ongoing basis.
		/// Ongoing effects are often referred to as auras, particularly
		/// those which grant temporary enchantments to other targets.
		/// https://hearthstone.gamepedia.com/Ongoing_effect
		/// Here, OngoingEffect includes <see cref="OngoingEnchant"/> too.
		/// </summary>
		IAura OngoingEffect { get; set; }

		/// <summary>
		/// Gets or sets current activated <see cref="Trigger"/> of this entity.
		/// Nullifying this field does not mean deactivation of the trigger.
		/// Use <see cref="Trigger.Remove()"/> instead.
		/// </summary>
		Trigger ActivatedTrigger { get; set; }

		#region obsoleted
		// Unused
		// bool TurnStart { get; set; }

		/// <summary>Applies on of the Powers defined on this entity.</summary>
		/// <param name="activation">The activation trigger for the enchants.</param>
		/// <param name="zoneType">Type of the zone the enchant will perform on.</param>
		/// <param name="target">The target, mostly of type <see cref="ICharacter"/>.</param>
		//void ApplyPowers(PowerActivation activation, Zone zoneType, IPlayable target = null);

		/// <summary>Stores the next Order Of Play index held by the <see cref="Game"/> instance.
		///	Order of play is important because it's the order in which effects are resolved.
		/// </summary>
		/// <param name="type">The type of this entity, stringified.</param>
		//void SetOrderOfPlay(string type);

		///// <summary>
		///// Playable has just been played.
		///// </summary>
		//bool JustPlayed { get; set; }

		///// <summary>
		///// Playable has been summoned.
		///// </summary>
		//bool IsSummoned { get; set; }
		#endregion
	}

	/// <summary>
	/// Base implementation of the <see cref="IPlayable"/> interface.
	/// </summary>
	/// <seealso cref="IPlayable" />
	/// <seealso cref="Entity"/>
	public abstract partial class Playable : Entity, IPlayable
	{
		/// <summary>Initializes a new instance of the <see cref="Playable"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		protected Playable(in Controller controller, in Card card, in IDictionary<GameTag, int> tags, in int id)
			: base(controller.Game, in card, in tags, in id)
		{
			Controller = controller;

			if (_history)
				tags[GameTag.CONTROLLER] = controller.PlayerId;
		}

		/// <inheritdoc />
		/// <summary>
		/// A copy constructor. This constructor is only used to the inherited copy constructors.
		/// </summary>
		/// <param name="controller">The target <see cref="T:SabberStoneCore.Model.Entities.Controller" /> instance.</param>
		/// <param name="playable">The source <see cref="T:SabberStoneCore.Model.Entities.Playable`1" /></param>
		protected Playable(in Controller controller, in Playable playable) : base(controller.Game, playable)
		{
			Controller = controller;

			controller.Game.IdEntityDic[playable.Id] = this;

			//playable.OngoingEffect?.Clone(this);
			playable.ActivatedTrigger?.Activate(this, cloning: true);

			// Cloning applied enchantments.
			{
				List<Enchantment> originalEnchantments = playable.AppliedEnchantments;
				if (originalEnchantments != null)
				{
					var enchantments = new List<Enchantment>(originalEnchantments.Count);
					foreach (Enchantment p in originalEnchantments)
					{
						enchantments.Add(p.Clone(controller));
					}
					AppliedEnchantments = enchantments;
				}
			}

			if (playable.ChooseOnePlayables != null)
			{
				ChooseOnePlayables = new IPlayable[2];
				Array.Copy(playable.ChooseOnePlayables, ChooseOnePlayables, 2);
			}

			_exhausted = playable._exhausted;
			_zonePosition = playable._zonePosition;

			_modifiedCost = playable._modifiedCost;
			_costManager = playable._costManager?.Clone();
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
		/// Gets or sets Ongoing effect of this entity.
		/// Ongoing effects are minion, weapon, and boss Hero Power abilities
		/// which grant special effects on an ongoing basis.
		/// Ongoing effects are often referred to as auras, particularly
		/// those which grant temporary enchantments to other targets.
		/// https://hearthstone.gamepedia.com/Ongoing_effect
		/// Here, OngoingEffect includes <see cref="OngoingEnchant"/> too.
		/// </summary>
		public IAura OngoingEffect { get; set; }

		/// <summary>
		/// Gets or sets current activated <see cref="Trigger"/> of this entity.
		/// Nullifying this field does not mean deactivation of the trigger.
		/// Use <see cref="Trigger.Remove()"/> instead.
		/// </summary>
		public Trigger ActivatedTrigger { get; set; }

		/// <summary>
		/// Gets or sets the Powers attached to this entity.
		/// These Powers are hardcoded into the card data, from which this entity
		/// is constructed.
		/// </summary>
		/// <value>
		/// <see cref="T:SabberStoneCore.Enchants.Power" />
		/// </value>
		/// <autogeneratedoc />
		//public List<Power> Powers => Card.Powers;
		public Power Power => Card.Power;

		public void ActivateTask(in PowerActivation activation = PowerActivation.POWER, in ICharacter target = null, in int chooseOne = 0, in IPlayable source = null)
		{
			if (ChooseOne)
			{
				if (Controller.ChooseBoth
				    && !Card.Id.Equals("EX1_165")	// OG_044a, using choose one 0 option
				    && !Card.Id.Equals("BRM_010")	// OG_044b, using choose one 0 option
				    && !Card.Id.Equals("AT_042")	// OG_044c, using choose one 0 option
					&& !Card.Id.Equals("UNG_101")	// UNG_101t3
					&& !Card.Id.Equals("ICC_051")	// ICC_051t3
					&& !Card.Id.Equals("ICC_047"))	// using choose one 0 option
				{
					ChooseOnePlayables[0].ActivateTask(activation, target, chooseOne, this);
					ChooseOnePlayables[1].ActivateTask(activation, target, chooseOne, this);
					return;
				}

				if (!Controller.ChooseBoth && chooseOne > 0)
				{
					ChooseOnePlayables[chooseOne - 1].ActivateTask(activation, target, chooseOne, this);
					return;
				}
			}

			if (Power == null) return;

			ISimpleTask task = null;
			switch (activation)
			{
				case PowerActivation.POWER:
					task = Power.PowerTask;
					break;
				case PowerActivation.DEATHRATTLE:
					task = Power.DeathrattleTask;
					break;
				case PowerActivation.COMBO:
					task = Power.ComboTask;
					break;
			}
			if (task == null) return;

			// clone task here
			//ISimpleTask clone = task.Clone();
			//clone.Game = source?.Game ?? Game;
			//clone.Controller = source?.Controller ?? Controller;
			//clone.Source = source ?? this;
			//clone.Target = target;

			if (source != null)
			{
				source.Game.TaskQueue.Enqueue(in task, source.Controller, source, target);
			}
			else
				Game.TaskQueue.Enqueue(in task, Controller, this, target);
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
		public virtual void Destroy()
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
				if (Card.HideStat)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable",
						!Game.Logging ? "" : $"{this} isn't playable, because can't play card with HIDE_STAT");
					return false;
				}

				// check if player has enough mana to play card
				bool bool1 = (this is Spell && Controller.ControllerAuraEffects[GameTag.SPELLS_COST_HEALTH] == 1);
				bool bool2 = AuraEffects?.CardCostHealth ?? false;
				if ((!bool1 && !bool2) && Controller.RemainingMana < Cost)
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
				// check requirements on cards here 
				if (!Card.IsPlayableByCardReq(Controller))
				{
					if (_logging)
					{
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
										for (int i = 0; i < Card.Entourage.Length; i++)
											containsAll &= ids.Contains(Card.Entourage[i]);

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
										if (!Controller.Hero.HeroPower.Card.Id.Equals("DS1h_292"))
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
					}

					return false;
				}

				// check if we need a target and there are some
				if (Card.MustHaveTargetToPlay && !HasAnyValidPlayTargets)
				{
					Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Playable", !Game.Logging ? "" : $"{this} isn't playable, because need valid target and we don't have one.");
					return false;
				}

				return true;
			}
		}

		public abstract IPlayable Clone(in Controller controller);

		public override string Hash(params GameTag[] ignore)
		{
			if (ActivatedTrigger == null && OngoingEffect == null)
				return base.Hash(ignore);

			var str = new StringBuilder(base.Hash(ignore));
			if (ActivatedTrigger != null)
			{
				str.Append("[TR:");
				str.Append(ActivatedTrigger);
				str.Append("]");
			}

			if (OngoingEffect != null)
			{
				str.Append("[OE:");
				str.Append(OngoingEffect);
				str.Append("]");
			}
			return str.ToString();
		}
	}


	public abstract partial class Playable
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		protected bool _exhausted;
		protected int _zonePosition;

		public int ZonePosition
		{
			get => _zonePosition;
			set
			{
				_zonePosition = value;
				if (_history)
					this[GameTag.ZONE_POSITION] = value + 1;
			}
		}

		public bool Combo => Card.Combo;

		public bool ChooseOne => Card.ChooseOne;

		//public bool JustPlayed
		//{
		//	get { return this[GameTag.JUST_PLAYED] == 1; }
		//	set { this[GameTag.JUST_PLAYED] = value ? 1 : 0; }
		//}

		//public bool IsSummoned
		//{
		//	get { return this[GameTag.SUMMONED] == 1; }
		//	set { this[GameTag.SUMMONED] = value ? 1 : 0; }
		//}

		public bool IsExhausted
		{
			get => _exhausted;
			set
			{
				_exhausted = value;
				if (_history || _logging)
				{
					this[GameTag.EXHAUSTED] = value ? 1 : 0;
				}
			}
		}

		public int Overload => Card.Overload;

		public virtual bool HasDeathrattle
		{
			get => false;
			set => throw new NotImplementedException();
		}

		public virtual bool HasLifeSteal
		{
			get => Card.LifeSteal;
			set => this[GameTag.LIFESTEAL] = value ? 1 : 0;
		}

		public bool IsEcho
		{
			get
			{
				if (AuraEffects?.Echo ?? false)
					return true;
				return Card.Echo;
			}
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
