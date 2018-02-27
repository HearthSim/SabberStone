using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Represents an entity in game which behaves as an actor. 
	/// The actions it can perform, as well as actions it undergoes,
	/// are defined by this interface.
	/// 
	/// The properties defined by this type are non complex, they have a
	/// very superficial meaning.
	/// </summary>
	public partial interface ICharacter : IPlayable
	{
		/// <summary>
		/// Indicates if this character can continue performing actions.
		/// </summary>
		bool IsDead { get; }

		/// <summary>
		/// Indicates if this character has the possibility to attack.
		/// </summary>
		bool CanAttack { get; }

		/// <summary>
		/// Contains a sequence of valid targets, also Characters, which
		/// can be attacked.
		/// </summary>
		IEnumerable<ICharacter> ValidAttackTargets { get; }

		/// <summary>
		/// Indicates if the provided target is attackable.
		/// 
		/// A quick solution would be to test if there are no taunt minions
		/// present and the target is not immune.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		bool IsValidAttackTarget(ICharacter target);

		/// <summary>
		/// This character takes damage from a certain other entity.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		int TakeDamage(IPlayable source, int damage);

		/// <summary>
		/// This character gets healed by a certain other entity.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="heal"></param>
		void TakeHeal(IPlayable source, int heal);

		/// <summary>
		/// This character receives a heal for it's maximum health.
		/// </summary>
		/// <param name="source"></param>
		void TakeFullHeal(IPlayable source);

		/// <summary>
		/// This character receives a specified amount of armor.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="armor"></param>
		void GainArmor(IPlayable source, int armor);

		event TriggerManager.TriggerHandler AfterAttackTrigger;
		void OnAfterAttackTrigger();
	}

	/// <summary>
	/// Base implementation of ICharacter.
	/// <seealso cref="ICharacter"/>
	/// <seealso cref="Playable{T}"/>
	/// </summary>
	/// <typeparam name="T">Subclass of entity.</typeparam>
	public abstract partial class Character<T> : Playable<T>, ICharacter where T : Entity
	{
		public event TriggerManager.TriggerHandler PreDamageTrigger;

		public event TriggerManager.TriggerHandler TakeDamageTrigger;

		public event TriggerManager.TriggerHandler AfterAttackTrigger;

		private bool _lifestealChecker;
		//private int _numDamageTriggerSubscribers;
		//private TriggerManager.TriggerHandler _damageTrigger;

		/// <summary>
		/// Build a new character from the provided data.
		/// </summary>
		/// <param name="controller">Owner of the character; not specifically limited to players.</param>
		/// <param name="card">The card which this character embodies.</param>
		/// <param name="tags">Properties of this entity.</param>
		protected Character(Controller controller, Card card, IDictionary<GameTag, int> tags)
			: base(controller, card, tags) { }

		/// <summary>
		/// A copy constructor. This constructor is only used to the inherited copy constructors.
		/// </summary>
		/// <param name="controller">The target <see cref="T:SabberStoneCore.Model.Entities.Controller" /> instance.</param>
		/// <param name="character">The source <see cref="T:SabberStoneCore.Model.Entities.Character`1" />.</param>
		protected Character(Controller controller, Character<T> character) : base(controller, character) { }

		/// <summary>
		/// Character is dead or destroyed.
		/// </summary>
		public bool IsDead => Health <= 0 || ToBeDestroyed;

		/// <summary>
		/// Character can attack.
		/// </summary>
		public virtual bool CanAttack => !IsExhausted && !IsFrozen && ValidAttackTargets.Any() && !CantAttack;

		/// <summary>
		/// Indicates if the provided character can be attacked by this character.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public virtual bool IsValidAttackTarget(ICharacter target)
		{
			// got target but isn't contained in valid targets
			if (!ValidAttackTargets.Contains(target))
			{
				Game.Log(LogLevel.WARNING, BlockType.ACTION, "Character", !Game.Logging? "":$"{this} has an invalid target {target}.");
				return false;
			}

			var hero = target as Hero;
			if (CantAttackHeroes && (hero != null))
			{
				Game.Log(LogLevel.WARNING, BlockType.ACTION, "Character", !Game.Logging? "":$"Can't attack Heroes!");
				return false;
			}

			return true;
		}

		/// <summary>
		/// Returns a sequence of characters which are attackable.
		/// </summary>
		public IEnumerable<ICharacter> ValidAttackTargets
		{
			get
			{
				bool tauntFlag = false;
				var allTargets = new List<ICharacter>(4);
				var allTargetsTaunt = new List<ICharacter>(2);
				foreach (Minion minion in Controller.Opponent.BoardZone.GetAll())
				{
					if (!minion.HasStealth)
					{
						if (minion.HasTaunt)
						{
							allTargetsTaunt.Add(minion);
							tauntFlag = true;
							continue;
						}
						if (!tauntFlag)
							allTargets.Add(minion);
					}
				}
				if (tauntFlag)
					return allTargetsTaunt;

				if (!CantAttackHeroes)
					allTargets.Add(Controller.Opponent.Hero);

				return allTargets;
			}
		}

		/// <summary>
		/// Inflict damage onto this character.
		/// The actual amount still needs to be determined by the current
		/// state of the game. eg: The presence of immunity effects can cause
		/// the damage to be ignored.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		public int TakeDamage(IPlayable source, int damage)
		{
			var hero = this as Hero;
			var minion = this as Minion;

			bool fatigue = hero != null && this == source;

			if (fatigue)
				hero.Fatigue = damage;

			if (minion != null && minion.HasDivineShield)
			{
				Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", !Game.Logging? "":$"{this} divine shield absorbed incoming damage.");
				minion.HasDivineShield = false;
				return 0;
			}

			int armor = hero?.Armor ?? 0;

			int amount = hero == null ? damage : armor < damage ? damage - armor : 0;

			// added pre damage
			PreDamage = amount;

			// Predamage triggers (Ice Block)
			if (PreDamageTrigger != null)
			{
				PreDamageTrigger.Invoke(this);
				amount = PreDamage;
			}
			if (IsImmune)
			{
				Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", !Game.Logging ? "" : $"{this} is immune.");
				PreDamage = 0;
				return 0;
			}

			// remove armor first from hero ....
			if (armor > 0)
				hero.Armor = armor < damage ? 0 : armor - damage;

			// final damage is beeing accumulated
			Damage += amount;

			Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", !Game.Logging? "":$"{this} took damage for {PreDamage}({damage}). {(fatigue ? "(fatigue)" : "")}");

			// reset predamage
			PreDamage = 0;

			//LastAffectedBy = source.Id;	TODO


			// Damage event is created
			// Collect all the tasks and sort them by order of play
			// Death phase and aura update are not emerge here

			// place event related data
			Game.TaskQueue.StartEvent();
			EventMetaData temp = Game.CurrentEventData;
			Game.CurrentEventData = new EventMetaData(source, this, amount);

			// on-damage triggers
			TakeDamageTrigger?.Invoke(this);
			Game.TriggerManager.OnDamageTrigger(this);
			Game.TriggerManager.OnDealDamageTrigger(source);
			Game.ProcessTasks();
			Game.TaskQueue.EndEvent();
			Game.CurrentEventData = temp;

			if (source.HasLifeSteal && !_lifestealChecker)
			{
				if (_history)
					Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, source.Id, source.Card.Id, -1, 0)); // TriggerKeyword=LIFESTEAL
				Game.Log(LogLevel.VERBOSE, BlockType.ATTACK, "TakeDamage", !_logging ? "" : $"lifesteal source {source} has damaged target for {amount}.");
				source.Controller.Hero.TakeHeal(source, amount);
				if (_history)
					Game.PowerHistory.Add(new PowerHistoryBlockEnd());

				if (source.Controller.Hero.ToBeDestroyed && source.Controller.Hero.Health > 0)
					source.Controller.Hero.ToBeDestroyed = false;
			}

			return amount;
		}

		/// <summary>
		/// Heal up all taken damage.
		/// </summary>
		/// <param name="source"></param>
		public void TakeFullHeal(IPlayable source)
		{
			TakeHeal(source, Damage);
		}

		/// <summary>
		/// Heal a specified amount of health.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="heal"></param>
		public void TakeHeal(IPlayable source, int heal)
		{
			//	TODO: Power Word: Glory interaction https://hearthstone.gamepedia.com/Healing#Advanced_rules
			if ((source is Spell || source is HeroPower) && source.Controller.ControllerAuraEffects[GameTag.HEALING_DOUBLE] > 0)
			{
				heal *= (int) Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.HEALING_DOUBLE]);
			}

			if (source.Controller.ControllerAuraEffects[GameTag.RESTORE_TO_DAMAGE] == 1)
			{
				_lifestealChecker = true;
				TakeDamage(source, heal);
				_lifestealChecker = false;
				return;
			}
			// we don't heal undamaged entities
			if (Damage == 0)
			{
				return;
			}

			int amount = Damage > heal ? heal : Damage;
			if (Game.Logging)
				Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} took healing for {amount}.");
			Damage -= amount;

			// Heal event created
			// Process gathered tasks
			Game.TaskQueue.StartEvent();
			EventMetaData temp = Game.CurrentEventData;
			Game.CurrentEventData = new EventMetaData(source, this, amount);
			Game.TriggerManager.OnHealTrigger(this);
			Game.ProcessTasks();
			Game.TaskQueue.EndEvent();
			Game.CurrentEventData = temp;

			if (this is Hero)
				Controller.AmountHeroHealedThisTurn += amount;
		}

		/// <summary>
		/// Gain the specified amount of armor.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="armor"></param>
		public void GainArmor(IPlayable source, int armor)
		{
			Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", !Game.Logging? "":$"{this} gaining armor for {armor}.");
			Armor += armor;
			EventMetaData temp = Game.CurrentEventData;
			Game.CurrentEventData = new EventMetaData(source, this, armor);
			Game.TriggerManager.OnArmorTrigger(this);
			//Game.ProcessTasks();
			Game.CurrentEventData = temp;
		}

		public void OnAfterAttackTrigger()
		{
			AfterAttackTrigger?.Invoke(this);
		}
	}

	public partial interface ICharacter
	{
		/// <summary>
		/// The amount of damage this character can output.
		/// </summary>
		int AttackDamage { get; set; }

		/// <summary>
		/// The amount of damage taken during the evaluation of one phase.
		/// </summary>
		int Damage { get; set; }

		/// <summary>
		/// The amount of damage this character is about to take.
		/// </summary>
		int PreDamage { get; set; }

		/// <summary>
		/// The amount of health this character has remaing. This value is returned
		/// AFTER SUBTRACTING the pending damage for this entity.
		/// </summary>
		int Health { get; set; }

		/// <summary>
		/// The starting amount of health of this character.
		/// </summary>
		int BaseHealth { get; }

		/// <summary>
		/// This character is currently attacking another characteaftr.
		/// </summary>
		bool IsAttacking { get; set; }

		/// <summary>
		/// This character is currently defending against another character.
		/// </summary>
		bool IsDefending { get; set; }

		/// <summary>
		/// The entityID of the character which wants to attack, by entering the
		/// next combat phase.
		/// The defender is this character.
		/// </summary>
		int ProposedAttacker { get; set; }

		/// <summary>
		/// The entityID of the character which has to defend during the next
		/// ombat phase.
		/// The attacker is this character.
		/// </summary>
		int ProposedDefender { get; set; }

		/// <summary>
		/// Amount of attacks this character has executed during this turn.
		/// </summary>
		int NumAttacksThisTurn { get; set; }

		/// <summary>
		/// <see cref="Enums.Race"/>
		/// </summary>
		Race Race { get; set; }

		/// <summary>
		/// Character should exit combat.
		/// </summary>
		bool ShouldExitCombat { get; set; }

		/// <summary>
		/// Character is frozen.
		/// </summary>
		bool IsFrozen { get; set; }

		/// <summary>
		/// Character is silenced.
		/// </summary>
		bool IsSilenced { get; set; }

		/// <summary>
		/// Character is immune.
		/// </summary>
		bool IsImmune { get; set; }

		/// <summary>
		/// Character has taunt.
		/// </summary>
		bool HasTaunt { get; set; }

		/// <summary>
		/// Character has windfury.
		/// </summary>
		bool HasWindfury { get; }

		/// <summary>
		/// Character has stealth.
		/// </summary>
		bool HasStealth { get; }

		/// <summary>
		/// Character can't be targeted by spells.
		/// </summary>
		bool CantBeTargetedBySpells { get; set; }

		/// <summary>
		/// Character can't be targeted by opponents.
		/// </summary>
		bool CantBeTargetedByOpponents { get; set; }

		/// <summary>
		/// Character can't be targeted by heropowers.
		/// </summary>
		bool CantBeTargetedByHeroPowers { get; set; }

	}

	public abstract partial class Character<T>
	{

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element

		public bool CantAttack
		{
			get { return this[GameTag.CANT_ATTACK] == 1; }
			set { this[GameTag.CANT_ATTACK] = value ? 1 : 0; }
		}

		public bool CantAttackHeroes
		{
			get { return this[GameTag.CANNOT_ATTACK_HEROES] == 1; }
			set { this[GameTag.CANNOT_ATTACK_HEROES] = value ? 1 : 0; }
		}

		public bool CantBeTargetedBySpells
		{
			get { return this[GameTag.CANT_BE_TARGETED_BY_SPELLS] == 1; }
			set { this[GameTag.CANT_BE_TARGETED_BY_SPELLS] = value ? 1 : 0; }
		}

		public bool CantBeTargetedByHeroPowers
		{
			get { return this[GameTag.CANT_BE_TARGETED_BY_HERO_POWERS] == 1; }
			set { this[GameTag.CANT_BE_TARGETED_BY_HERO_POWERS] = value ? 1 : 0; }
		}

		public int Armor
		{
			get
			{
				NativeTags.TryGetValue(GameTag.ARMOR, out int value);
				return value;
			}
			set { this[GameTag.ARMOR] = value; }
		}

		public int LastAffectedBy
		{
			get { return this[GameTag.LAST_AFFECTED_BY]; }
			set { this[GameTag.LAST_AFFECTED_BY] = value; }
		}

		public virtual int AttackDamage
		{
			get { return this[GameTag.ATK]; }
			set { this[GameTag.ATK] = value; }
		}

		public bool CantBeTargetedByOpponents
		{
			get { return this[GameTag.CANT_BE_TARGETED_BY_OPPONENTS] == 1; }
			set { this[GameTag.CANT_BE_TARGETED_BY_OPPONENTS] = value ? 1 : 0; }
		}

		public int Damage
		{
			get => NativeTags.TryGetValue(GameTag.DAMAGE, out int value) ? value : 0;
			set
			{
				if (this[GameTag.HEALTH] <= value)
				{
					ToBeDestroyed = true;
				}

				// don't allow negative values
				this[GameTag.DAMAGE] = value < 0 ? 0 : value;
			}
		}

		public int Health
		{
			get { return this[GameTag.HEALTH] - this[GameTag.DAMAGE]; }
			set
			{
				if (value == 0)
				{
					ToBeDestroyed = true;
				}

				this[GameTag.HEALTH] = value;
				this[GameTag.DAMAGE] = 0;
			}
		}

		public bool IsAttacking
		{
			get { return this[GameTag.ATTACKING] == 1; }
			set { this[GameTag.ATTACKING] = value ? 1 : 0; }
		}

		public bool IsDefending
		{
			get { return this[GameTag.DEFENDING] == 1; }
			set { this[GameTag.DEFENDING] = value ? 1 : 0; }
		}

		public int ProposedAttacker
		{
			get { return this[GameTag.PROPOSED_ATTACKER]; }
			set { this[GameTag.PROPOSED_ATTACKER] = value; }
		}

		public int ProposedDefender
		{
			get { return this[GameTag.PROPOSED_DEFENDER]; }
			set { this[GameTag.PROPOSED_DEFENDER] = value; }
		}

		public bool IsImmune
		{
			get { return this[GameTag.IMMUNE] == 1; }
			set { this[GameTag.IMMUNE] = value ? 1 : 0; }
		}

		public bool IsFrozen
		{
			get
			{
				NativeTags.TryGetValue(GameTag.FROZEN, out int value);
				return value == 1;
			}
			set
			{
				if (value)
				{
					Game.TriggerManager.OnFreezeTrigger(this);
					NativeTags[GameTag.FROZEN] = 1;
				}
				else
				{
					NativeTags[GameTag.FROZEN] = 0;
				}
			}
		}

		public bool IsSilenced
		{
			get { return GetNativeGameTag(GameTag.SILENCED) == 1; }
			set { this[GameTag.SILENCED] = value ? 1 : 0; }
		}

		public bool HasTaunt
		{
			get => _data[GameTag.TAUNT] == 1;
			set => this[GameTag.TAUNT] = value ? 1 : 0;
		}

		public virtual bool HasWindfury
		{
			get { return this[GameTag.WINDFURY] >= 1; }
			set { this[GameTag.WINDFURY] = value ? 1 : 0; }
		}

		public bool HasStealth
		{
			get => _data[GameTag.STEALTH] == 1;
			set => this[GameTag.STEALTH] = value ? 1 : 0;
		}

		public int NumAttacksThisTurn
		{
			get
			{
				NativeTags.TryGetValue(GameTag.NUM_ATTACKS_THIS_TURN, out int value);
				return value;
			}
			set => this[GameTag.NUM_ATTACKS_THIS_TURN] = value;
		}

		public int PreDamage
		{
			get { return this[GameTag.PREDAMAGE]; }
			set { this[GameTag.PREDAMAGE] = value; }
		}

		public Race Race
		{
			get { return (Race)this[GameTag.CARDRACE]; }
			set { this[GameTag.CARDRACE] = (int)value; }
		}

		public bool ShouldExitCombat
		{
			get { return this[GameTag.SHOULDEXITCOMBAT] == 1; }
			set { this[GameTag.SHOULDEXITCOMBAT] = value ? 1 : 0; }
		}

		public int BaseHealth
		{
			get { return this[GameTag.HEALTH]; }
			set { this[GameTag.HEALTH] = value; }
		}
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element

	}
}
