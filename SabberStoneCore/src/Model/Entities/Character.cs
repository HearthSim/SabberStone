using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	/// <seealso cref="Playable"/>
	/// </summary>
	/// <typeparam name="T">Subclass of entity.</typeparam>
	public abstract partial class Character : Playable, ICharacter
	{
		public event TriggerManager.TriggerHandler PreDamageTrigger;
		public event TriggerManager.TriggerHandler TakeDamageTrigger;
		public event TriggerManager.TriggerHandler AfterAttackTrigger;

		/// <summary>
		/// Build a new character from the provided data.
		/// </summary>
		/// <param name="controller">Owner of the character; not specifically limited to players.</param>
		/// <param name="card">The card which this character embodies.</param>
		/// <param name="tags">Properties of this entity.</param>
		protected Character(in Controller controller, in Card card, in IDictionary<GameTag, int> tags, in int id)
			: base(in controller, in card, in tags, in id)
		{
			_atkModifier = card.ATK;
			_healthModifier = card.Health;
		}

		/// <summary>
		/// A copy constructor. This constructor is only used to the inherited copy constructors.
		/// </summary>
		/// <param name="controller">The target <see cref="T:SabberStoneCore.Model.Entities.Controller" /> instance.</param>
		/// <param name="character">The source <see cref="T:SabberStoneCore.Model.Entities.Character`1" />.</param>
		protected Character(in Controller controller, in Character character) : base(in controller, character)
		{
			character.CopyInternalAttributes(this);
		}

		/// <summary>
		/// Character is dead or destroyed.
		/// </summary>
		public bool IsDead => Health <= 0 || ToBeDestroyed;

		public override int this[GameTag t]
		{
			get
			{
				switch (t)
				{
					case GameTag.ATK:
						return AttackDamage;
					case GameTag.HEALTH:
						return BaseHealth;
					case GameTag.DAMAGE:
						return Damage;
					case GameTag.STEALTH:
						return HasStealth ? 1 : 0;
					case GameTag.IMMUNE:
						return IsImmune ? 1 : 0;
					default:
						return base[t];
				}
			}
			set
			{
				switch (t)
				{
					case GameTag.ATK:
						AttackDamage = value;
						return;
					case GameTag.HEALTH:
						BaseHealth = value;
						return;
					case GameTag.DAMAGE:
						Damage = value;
						return;
					case GameTag.STEALTH:
						HasStealth = value > 0;
						return;
					case GameTag.IMMUNE:
						IsImmune = value > 0;
						return;
					default:
						base[t] = value;
						return;
				}
			}
		}

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

				Hero opHero = Controller.Opponent.Hero;

				if (!(this is Minion m && m.AttackableByRush) && !CantAttackHeroes && !opHero.IsImmune && !opHero.HasStealth)
					allTargets.Add(opHero);

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

			if (minion != null && minion.Zone.Type != Enums.Zone.PLAY)
				return 0;

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

			if (this is Hero h)
				h.DamageTakenThisTurn += amount;

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
			if ((source is Spell || source is HeroPower) && source.Controller.ControllerAuraEffects[GameTag.SPELL_HEALING_DOUBLE] > 0)
			{
				heal *= (int) Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.SPELL_HEALING_DOUBLE]);
			}

			if (source.Controller.ControllerAuraEffects[GameTag.ALL_HEALING_DOUBLE] > 0)
				heal *= (int) Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.ALL_HEALING_DOUBLE]);

			if (source.Controller.ControllerAuraEffects[GameTag.RESTORE_TO_DAMAGE] == 1)
			{
				if (_lifestealChecker)
					return;

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

		public override string Hash(params GameTag[] ignore)
		{
			var sb = new StringBuilder(base.Hash(ignore));
			sb.Append($"[A:{_atkModifier}, ");
			sb.Append($"H:{_healthModifier}, ");
			sb.Append($"D:{_dmgModifier}]");
			return sb.ToString();
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

		///// <summary>
		///// The entityID of the character which wants to attack, by entering the
		///// next combat phase.
		///// The defender is this character.
		///// </summary>
		//int ProposedAttacker { get; set; }

		///// <summary>
		///// The entityID of the character which has to defend during the next
		///// ombat phase.
		///// The attacker is this character.
		///// </summary>
		//int ProposedDefender { get; set; }

		/// <summary>
		/// Amount of attacks this character has executed during this turn.
		/// </summary>
		int NumAttacksThisTurn { get; set; }

		/// <summary>
		/// <see cref="Enums.Race"/>
		/// </summary>
		Race Race { get; }

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

	public abstract partial class Character
	{
		private bool _lifestealChecker;

		internal int _atkModifier;
		internal int _healthModifier;
		internal int _dmgModifier;
		internal bool? _stealth;
		internal bool? _immune;
		internal bool? _taunt;

		internal void CopyInternalAttributes(in Character copy)
		{
			copy._atkModifier = _atkModifier;
			copy._healthModifier = _healthModifier;
			copy._dmgModifier = _dmgModifier;
			copy._stealth = _stealth;
			copy._immune = _immune;
			copy._taunt = _taunt;
		}

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element

		public virtual int AttackDamage
		{
			get
			{
				int value = _atkModifier;

				int auraValue = AuraEffects.AttackDamage;
				value += auraValue;
				return value < 0 ? 0 : value;
			}
			set
			{
				if (_logging)
					Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", !Game.Logging ? "" : $"{this} set data {GameTag.ATK} to {value}");
				if (_history && value + AuraEffects.AttackDamage != AttackDamage)
					Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.ATK, value));

				_atkModifier = value;
			}
		}

		public int BaseHealth
		{
			get
			{
				int value = _healthModifier;

				int auraValue = AuraEffects.Health;
				if (auraValue >= 0) return value + auraValue;
				value += auraValue;
				return value < 0 ? 0 : value;
			}
			set
			{
				if (_logging)
					Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", !Game.Logging ? "" : $"{this} set data {GameTag.HEALTH} to {value}");
				if (_history && value + AuraEffects.AttackDamage != AttackDamage)
					Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.HEALTH, value));

				_healthModifier = value;
			}
		}

		public int Damage
		{
			//get => NativeTags.TryGetValue(GameTag.DAMAGE, out int value) ? value : 0;
			get => _dmgModifier;
			set
			{
				if (BaseHealth <= value)
				{
					ToBeDestroyed = true;
				}

				//// don't allow negative values
				//this[GameTag.DAMAGE] = value < 0 ? 0 : value;

				if (_logging)
					Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", !Game.Logging ? "" : $"{this} set data {GameTag.DAMAGE} to {value}");
				if (_history && value != _dmgModifier)
					Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.DAMAGE, value));

				_dmgModifier = value;
			}
		}

		public int Health
		{
			get => BaseHealth - _dmgModifier;
			set
			{
				if (value == 0)
				{
					ToBeDestroyed = true;
				}

				//this[GameTag.HEALTH] = value;
				//this[GameTag.DAMAGE] = 0;
				_healthModifier = value;
				_dmgModifier = 0;
			}
		}

		public bool CantAttack
		{
			get
			{
				if (!_data.TryGetValue(GameTag.CANT_ATTACK, out int value))
					return Card.CantAttack;
				
				return value > 0;
			}
			set => this[GameTag.CANT_ATTACK] = value ? 1 : 0;
		}

		public bool CantAttackHeroes
		{
			get
			{
				_data.TryGetValue(GameTag.CANNOT_ATTACK_HEROES, out int value);
				value += AuraEffects[GameTag.CANNOT_ATTACK_HEROES];
				return value > 0;
			}
			set => this[GameTag.CANNOT_ATTACK_HEROES] = value ? 1 : 0;
		}

		public bool CantBeTargetedBySpells
		{
			get
			{
				if (!_data.TryGetValue(GameTag.CANT_BE_TARGETED_BY_SPELLS, out int value))
					value = Card.CantBeTargetedBySpells ? 1 : 0;
				value += AuraEffects[GameTag.CANT_BE_TARGETED_BY_SPELLS];

				return value > 0;
			}
			set => this[GameTag.CANT_BE_TARGETED_BY_SPELLS] = value ? 1 : 0;
		}

		public bool CantBeTargetedByHeroPowers
		{
			get
			{
				if (!_data.TryGetValue(GameTag.CANT_BE_TARGETED_BY_HERO_POWERS, out int value))
					value = Card.CantBeTargetedByHeroPowers ? 1 : 0;
				value += AuraEffects[GameTag.CANT_BE_TARGETED_BY_HERO_POWERS];

				return value > 0;
			}
			set { this[GameTag.CANT_BE_TARGETED_BY_HERO_POWERS] = value ? 1 : 0; }
		}

		public int Armor
		{
			get
			{
				_data.TryGetValue(GameTag.ARMOR, out int value);
				return value;
			}
			set { this[GameTag.ARMOR] = value; }
		}

		public int LastAffectedBy
		{
			get
			{
				_data.TryGetValue(GameTag.LAST_AFFECTED_BY, out int value);
				return value;
			}
			set { this[GameTag.LAST_AFFECTED_BY] = value; }
		}

		public bool CantBeTargetedByOpponents
		{
			get { return this[GameTag.CANT_BE_TARGETED_BY_OPPONENTS] == 1; }
			set { this[GameTag.CANT_BE_TARGETED_BY_OPPONENTS] = value ? 1 : 0; }
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

		public bool IsImmune
		{
			get
			{
				if (_immune.HasValue && _immune.Value)
					return true;

				// bool cardTag = Card[GameTag.IMMUNE]; TODO: Some Adv/Brawl cards have IMMUNE tag
				// _immune = cardTag;
				return AuraEffects[GameTag.IMMUNE] > 0;
			}
			set
			{
				_immune = value;
				base[GameTag.IMMUNE] = value ? 1 : 0;
			}
		}

		public bool IsFrozen
		{
			get
			{
				_data.TryGetValue(GameTag.FROZEN, out int value);
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
			get { return _data.ContainsKey(GameTag.SILENCED); }
			set { this[GameTag.SILENCED] = value ? 1 : 0; }
		}

		public bool HasTaunt
		{
			get
			{
				if (_taunt.HasValue) return _taunt.Value;

				bool cardTag = Card.Taunt;
				_taunt = cardTag;
				return cardTag;
			}
			set
			{
				_taunt = value;
				base[GameTag.TAUNT] = value ? 1 : 0;
			}
		}

		public virtual bool HasWindfury
		{
			get { return this[GameTag.WINDFURY] >= 1; }
			set { this[GameTag.WINDFURY] = value ? 1 : 0; }
		}

		public bool HasStealth
		{
			get
			{
				if (_stealth.HasValue) return _stealth.Value;

				bool cardTag = Card.Stealth;
				_stealth = cardTag;
				return cardTag;
			}
			set
			{
				_stealth = value;
				base[GameTag.STEALTH] = value ? 1 : 0;
			}
		}

		public int NumAttacksThisTurn
		{
			get
			{
				_data.TryGetValue(GameTag.NUM_ATTACKS_THIS_TURN, out int value);
				return value;
			}
			set => this[GameTag.NUM_ATTACKS_THIS_TURN] = value;
		}

		public int PreDamage
		{
			get => _data[GameTag.PREDAMAGE];
			set => this[GameTag.PREDAMAGE] = value;
		}

		public Race Race => Card.Race;

		public bool ShouldExitCombat
		{
			get { return this[GameTag.SHOULDEXITCOMBAT] == 1; }
			set { this[GameTag.SHOULDEXITCOMBAT] = value ? 1 : 0; }
		}
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element

	}
}
