using SabberStoneCore.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model.Entities.Playables
{
	/// <summary>
	/// Base implementation of ICharacter.
	/// <seealso cref="ICharacter"/>
	/// <seealso cref="Playable{T}"/>
	/// </summary>
	/// <typeparam name="T">Subclass of entity.</typeparam>
	public abstract class Character<T> : Playable<T>, ICharacter where T : Entity
	{

		#region TAG_SHORTCUTS

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public bool CantAttack
		{
			get { return this[EGameTag.CANT_ATTACK] == 1; }
			set { this[EGameTag.CANT_ATTACK] = value ? 1 : 0; }
		}

		public bool CantAttackHeroes
		{
			get { return this[EGameTag.CANNOT_ATTACK_HEROES] == 1; }
			set { this[EGameTag.CANNOT_ATTACK_HEROES] = value ? 1 : 0; }
		}

		public bool CantBeTargetedBySpells
		{
			get { return this[EGameTag.CANT_BE_TARGETED_BY_SPELLS] == 1; }
			set { this[EGameTag.CANT_BE_TARGETED_BY_SPELLS] = value ? 1 : 0; }
		}

		public bool CantBeTargetedByHeroPowers
		{
			get { return this[EGameTag.CANT_BE_TARGETED_BY_HERO_POWERS] == 1; }
			set { this[EGameTag.CANT_BE_TARGETED_BY_HERO_POWERS] = value ? 1 : 0; }
		}

		public int Armor
		{
			get { return this[EGameTag.ARMOR]; }
			set { this[EGameTag.ARMOR] = value; }
		}

		public int LastAffectedBy
		{
			get { return this[EGameTag.LAST_AFFECTED_BY]; }
			set { this[EGameTag.LAST_AFFECTED_BY] = value; }
		}

		public int AttackDamage
		{
			get { return this[EGameTag.ATK]; }
			set { this[EGameTag.ATK] = value; }
		}

		public bool CantBeTargetedByOpponents
		{
			get { return this[EGameTag.CANT_BE_TARGETED_BY_OPPONENTS] == 1; }
			set { this[EGameTag.CANT_BE_TARGETED_BY_OPPONENTS] = value ? 1 : 0; }
		}

		public int Damage
		{
			get { return this[EGameTag.DAMAGE]; }
			set
			{
				if (this[EGameTag.HEALTH] <= value)
				{
					ToBeDestroyed = true;
				}
				// don't allow negative values
				this[EGameTag.DAMAGE] = value < 0 ? 0 : value;
			}
		}

		public int Health
		{
			get { return this[EGameTag.HEALTH] - this[EGameTag.DAMAGE]; }
			set
			{
				if (value == 0)
				{
					ToBeDestroyed = true;
				}

				this[EGameTag.HEALTH] = value;
				this[EGameTag.DAMAGE] = 0;
			}
		}

		public bool IsAttacking
		{
			get { return this[EGameTag.ATTACKING] == 1; }
			set { this[EGameTag.ATTACKING] = value ? 1 : 0; }
		}

		public bool IsDefending
		{
			get { return this[EGameTag.DEFENDING] == 1; }
			set { this[EGameTag.DEFENDING] = value ? 1 : 0; }
		}

		public int ProposedAttacker
		{
			get { return this[EGameTag.PROPOSED_ATTACKER]; }
			set { this[EGameTag.PROPOSED_ATTACKER] = value; }
		}

		public int ProposedDefender
		{
			get { return this[EGameTag.PROPOSED_DEFENDER]; }
			set { this[EGameTag.PROPOSED_DEFENDER] = value; }
		}

		public bool IsImmune
		{
			get { return this[EGameTag.IMMUNE] == 1; }
			set { this[EGameTag.IMMUNE] = value ? 1 : 0; }
		}

		public bool IsFrozen
		{
			get { return this[EGameTag.FROZEN] == 1; }
			set { this[EGameTag.FROZEN] = value ? 1 : 0; }
		}

		public bool IsSilenced
		{
			get { return this[EGameTag.SILENCED] == 1; }
			set { this[EGameTag.SILENCED] = value ? 1 : 0; }
		}

		public bool HasTaunt
		{
			get { return this[EGameTag.TAUNT] == 1; }
			set { this[EGameTag.TAUNT] = value ? 1 : 0; }
		}

		public virtual bool HasWindfury
		{
			get { return this[EGameTag.WINDFURY] == 1; }
			set { this[EGameTag.WINDFURY] = value ? 1 : 0; }
		}

		public int NumAttacksThisTurn
		{
			get { return this[EGameTag.NUM_ATTACKS_THIS_TURN]; }
			set { this[EGameTag.NUM_ATTACKS_THIS_TURN] = value; }
		}

		public int PreDamage
		{
			get { return this[EGameTag.PREDAMAGE]; }
			set { this[EGameTag.PREDAMAGE] = value; }
		}

		public ERace Race
		{
			get { return (ERace)this[EGameTag.CARDRACE]; }
			set { this[EGameTag.CARDRACE] = (int)value; }
		}

		public bool ShouldExitCombat
		{
			get { return this[EGameTag.SHOULDEXITCOMBAT] == 1; }
			set { this[EGameTag.SHOULDEXITCOMBAT] = value ? 1 : 0; }
		}

		public int BaseHealth
		{
			get { return this[EGameTag.HEALTH]; }
			set { this[EGameTag.HEALTH] = value; }
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		#endregion

		#region PROPERTIES

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public bool IsDead => Health <= 0 || ToBeDestroyed;

		public virtual bool CanAttack => !CantAttack && !IsExhausted && !IsFrozen && ValidAttackTargets.Any();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		#endregion

		/// <summary>
		/// Build a new character from the provided data.
		/// </summary>
		/// <param name="controller">Owner of the character; not specifically limited to players.</param>
		/// <param name="card">The card which this character embodies.</param>
		/// <param name="tags">Properties of this entity.</param>
		protected Character(Controller controller, Card card, Dictionary<EGameTag, int> tags)
			: base(controller, card, tags)
		{
		}

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
				Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "Character", $"{this} has an invalid target {target}.");
				return false;
			}

			var hero = target as Hero;
			if (CantAttackHeroes && (hero != null))
			{
				Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "Character", $"Can't attack Heroes!");
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
				var allTargets = Controller.Opponent.Board.Where(x => !x.HasStealth && !x.IsImmune).ToList<ICharacter>();
				var allTargetsTaunt = allTargets.Where(x => x.HasTaunt).ToList();
				if (!CantAttackHeroes)
				{
					allTargets.Add(Controller.Opponent.Hero);
				}
				return allTargetsTaunt.Any() ? allTargetsTaunt : allTargets;
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
		public bool TakeDamage(IPlayable source, int damage)
		{
			var hero = this as Hero;
			var minion = this as Minion;

			bool fatigue = hero != null && this == source;

			if (fatigue)
			{
				hero.Fatigue = damage;
			}

			if (minion != null && minion.HasDivineShield)
			{
				Game.Log(ELogLevel.INFO, EBlockType.ACTION, "Character", $"{this} divine shield absorbed incoming damage.");
				minion.HasDivineShield = false;
				return false;
			}

			if (minion != null && minion.IsImmune || hero != null && hero.IsImmune)
			{
				Game.Log(ELogLevel.INFO, EBlockType.ACTION, "Character", $"{this} is immune.");
				return false;
			}

			// remove armor first from hero ....
			if (hero != null && hero.Armor > 0)
			{
				if (hero.Armor < damage)
				{
					damage = damage - hero.Armor;
					hero.Armor = 0;
				}
				else
				{
					hero.Armor = hero.Armor - damage;
					damage = 0;
				}
			}

			// added pre damage to be able to interact
			PreDamage = damage;

			// final damage is beeing accumulated
			Damage += PreDamage;

			Game.Log(ELogLevel.INFO, EBlockType.ACTION, "Character", $"{this} took damage for {PreDamage}({damage}). {(fatigue ? "(fatigue)" : "")}");

			// check if there was damage done
			bool tookDamage = PreDamage > 0;

			// reset predamage
			PreDamage = 0;

			return tookDamage;
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
		/// 
		/// TODO The actual amount of healed damage must be determined from the state of the game?
		/// </summary>
		/// <param name="source"></param>
		/// <param name="heal"></param>
		public void TakeHeal(IPlayable source, int heal)
		{
			// we don't heal undamaged entities
			if (Damage == 0)
			{
				return;
			}

			int amount = Damage > heal ? heal : Damage;
			Game.Log(ELogLevel.INFO, EBlockType.ACTION, "Character", $"{this} took healing for {amount}.");
			Damage -= amount;
		}

		/// <summary>
		/// Gain the specified amount of armor.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="armor"></param>
		public void GainArmor(IPlayable source, int armor)
		{
			Game.Log(ELogLevel.INFO, EBlockType.ACTION, "Character", $"{this} gaining armor for {armor}.");
			Armor += armor;
		}
	}
}