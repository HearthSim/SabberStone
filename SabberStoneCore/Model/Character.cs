using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public partial interface ICharacter : IPlayable
    {
        bool IsDead { get; }
        bool CanAttack { get; }
        IEnumerable<ICharacter> ValidAttackTargets { get; }
        bool IsValidAttackTarget(ICharacter target);
        bool TakeDamage(IPlayable source, int damage);
        void TakeHeal(IPlayable source, int heal);
        void TakeFullHeal(IPlayable source);
        void GainArmor(IPlayable source, int armor);
    }

    public abstract partial class Character<T> : Playable<T>, ICharacter where T : Entity
    {
        protected Character(Controller controller, Card card, Dictionary<GameTag, int> tags)
            : base(controller, card, tags)
        {
        }

        public bool IsDead => Health <= 0 || ToBeDestroyed;

        public virtual bool CanAttack => !CantAttack && !IsExhausted && !IsFrozen && ValidAttackTargets.Any();

        public virtual bool IsValidAttackTarget(ICharacter target)
        {
            // got target but isn't contained in valid targets
            if (!ValidAttackTargets.Contains(target))
            {
                Game.Log(LogLevel.WARNING, BlockType.ACTION, "Character", $"{this} has an invalid target {target}.");
                return false;
            }

            var hero = target as Hero;
            if (CantAttackHeroes && (hero != null))
            {
                Game.Log(LogLevel.WARNING, BlockType.ACTION, "Character", $"Can't attack Heroes!");
                return false;
            }

            return true;
        }

        public IEnumerable<ICharacter> ValidAttackTargets
        {
            get
            {
                var allTargets = Controller.Opponent.Board.Where(x => !x.HasStealth).ToList<ICharacter>();
                var allTargetsTaunt = allTargets.Where(x => x.HasTaunt).ToList();
                allTargets.Add(Controller.Opponent.Hero);
                return allTargetsTaunt.Any() ? allTargetsTaunt : allTargets;
            }
        }

        public bool TakeDamage(IPlayable source, int damage)
        {
            var hero = this as Hero;
            var minion = this as Minion;

            var fatigue = hero != null && this == source;

            if (fatigue)
            {
                hero.Fatigue = damage;
            }

            if (minion != null && minion.HasDivineShield)
            {
                Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} divine shield absorbed incoming damage.");
                minion.HasDivineShield = false;
                return false;
            }

            if (minion != null && minion.IsImmune || hero != null && hero.IsImmune)
            {
                Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} is immune.");
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

            Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} took damage for {PreDamage}({damage}). {(fatigue?"(fatigue)":"")}");

            // check if there was damage done
            var tookDamage = PreDamage > 0;

            // reset predamage
            PreDamage = 0;

            return tookDamage;
        }

        public void TakeFullHeal(IPlayable source)
        {
            TakeHeal(source, Damage);
        }

        public void TakeHeal(IPlayable source, int heal)
        {
            // we don't heal undamaged entities
            if (Damage == 0)
            {
                return;
            }

            var amount = Damage > heal ? heal : Damage;
            Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} took healing for {amount}.");
            Damage -= amount;
        }

        public void GainArmor(IPlayable source, int armor)
        {
            Game.Log(LogLevel.INFO, BlockType.ACTION, "Character", $"{this} gaining armor for {armor}.");
            Armor += armor;
        }
    }

    public partial interface ICharacter
    {
        int AttackDamage { get; set; }
        bool CantBeTargetedBySpells { get; set; }
        bool CantBeTargetedByOpponents { get; set; }
        bool CantBeTargetedByHeroPowers { get; set; }
        int Damage { get; set; }
        int Health { get; set; }
        bool IsAttacking { get; set; }
        bool IsDefending { get; set; }
        int ProposedAttacker { get; set; }
        int ProposedDefender { get; set; }
        bool IsExhausted { get; set; }
        bool IsFrozen { get; set; }
        bool IsSilenced { get; set; }
        bool IsImmune { get; set; }
        bool HasTaunt { get; set; }
        bool HasWindfury { get; set; }
        int NumAttacksThisTurn { get; set; }
        int PreDamage { get; set; }
        Race Race { get; set; }
        bool ShouldExitCombat { get; set; }
        int BaseHealth { get; }
    }

    public abstract partial class Character<T>
    {

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
            get { return this[GameTag.ARMOR]; }
            set { this[GameTag.ARMOR] = value; }
        }

        public int LastAffectedBy
        {
            get { return this[GameTag.LAST_AFFECTED_BY]; }
            set { this[GameTag.LAST_AFFECTED_BY] = value; }
        }

        public int AttackDamage
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
            get { return this[GameTag.DAMAGE]; }
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
            get { return this[GameTag.FROZEN] == 1; }
            set { this[GameTag.FROZEN] = value ? 1 : 0; }
        }

        public bool IsSilenced
        {
            get { return this[GameTag.SILENCED] == 1; }
            set { this[GameTag.SILENCED] = value ? 1 : 0; }
        }

        public bool HasTaunt
        {
            get { return this[GameTag.TAUNT] == 1; }
            set { this[GameTag.TAUNT] = value ? 1 : 0; }
        }

        public virtual bool HasWindfury
        {
            get { return this[GameTag.WINDFURY] == 1; }
            set { this[GameTag.WINDFURY] = value ? 1 : 0; }
        }

        public int NumAttacksThisTurn
        {
            get { return this[GameTag.NUM_ATTACKS_THIS_TURN]; }
            set { this[GameTag.NUM_ATTACKS_THIS_TURN] = value; }
        }

        public int PreDamage
        {
            get { return this[GameTag.PREDAMAGE]; }
            set { this[GameTag.PREDAMAGE] = value; }
        }

        public Race Race
        {
            get { return (Race) this[GameTag.CARDRACE]; }
            set { this[GameTag.CARDRACE] = (int) value; }
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

    }
}