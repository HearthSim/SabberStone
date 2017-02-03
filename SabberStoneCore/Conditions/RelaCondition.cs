using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Conditions
{
    public enum RelaSign
    {
        EQ, GEQ, LEQ
    }
    public class RelaCondition
    {
        private readonly Func<IPlayable, IPlayable, bool> _function;

        public static RelaCondition IsEnraged { get; } = new RelaCondition((me, other) => me is ICharacter && ((ICharacter)me).Damage > 0);
        public static RelaCondition IsMyWeapon { get; } = new RelaCondition((me, other) => me.Controller.Hero.Weapon != null && me.Controller.Hero.Weapon == other);

        public static RelaCondition IsWeaponEquiped { get; } = new RelaCondition((me, other) => me.Controller.Hero.Weapon != null);

        public static RelaCondition IsFriendly { get; } = new RelaCondition((me, other) => me.Controller == other.Controller);
        public static RelaCondition IsSameZone { get; } = new RelaCondition((me, other) => me.Zone == other.Zone);
        public static RelaCondition IsSelf { get; } = new RelaCondition((me, other) => me == other);
        public static RelaCondition IsNotSelf { get; } = new RelaCondition((me, other) => me != other);
        public static RelaCondition IsSideBySide { get; } = new RelaCondition((me, other) =>  me.Zone == other.Zone && Math.Abs(me[GameTag.ZONE_POSITION]-other[GameTag.ZONE_POSITION]) == 1);
        public static RelaCondition IsSameRace { get; } = new RelaCondition((me, other) => me is ICharacter && other is ICharacter && ((ICharacter)me).Race == ((ICharacter)other).Race);

        public static RelaCondition IsOtherSpell { get; } = new RelaCondition((me, other) => other is Spell);
        public static RelaCondition IsOtherWeapon { get; } = new RelaCondition((me, other) => other is Weapon);
        public static RelaCondition IsOtherTotem { get; } = new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).Race == Race.TOTEM);
        public static RelaCondition IsSpellDmgOnHero { get; } = new RelaCondition((me, other) => me.Controller.Hero.SpellPower > 0);
        public static RelaCondition IsOtherMinion { get; } = new RelaCondition((me, other) => other is Minion);
        public static RelaCondition IsOtherCthun { get; } = new RelaCondition((me, other) => other.Card.Id.Equals("OG_280"));
        public static RelaCondition IsOtherAttacking { get; } = new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).IsAttacking);
        public static RelaCondition IsOtherAttackingHero { get; } = new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).ProposedDefender == me.Controller.Hero.Id);
        public static RelaCondition IsOtherHero { get; } = new RelaCondition((me, other) => other is Hero);

        public static RelaCondition IsAnyNotImmune { get; } = new RelaCondition((me, other) => me.Game.Characters.Exists(p => !p.IsImmune));
        public static RelaCondition IsOtherSilverHandRecruit { get; } = new RelaCondition((me, other) => other is Minion && ((Minion)other).Card.Id.Equals("CS2_101t"));

        public static RelaCondition HasOtherTakenLethalDamage { get; } = new RelaCondition((me, other) => {
            var character = other as ICharacter;
            if (character != null)
            {
                return (character.PreDamage > 0) && (character.PreDamage >= character.Health);
            }
            return false;
        });

        public static RelaCondition IsOtherRace(Race race)
        {
            return new RelaCondition((me, other) => SelfCondition.IsRace(race).Eval(other));
        }
        public static RelaCondition IsOtherNotRace(Race race) { 
            return new RelaCondition((me, other) => !SelfCondition.IsRace(race).Eval(other));
        }

        //public static RelaCondition Is50PercChance { get; } = new RelaCondition((me, other) => Util.Random.Next(0,2) == 0);

        public static RelaCondition HasTargetTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
        {
            return new RelaCondition((me, other) => 
                relaSign == RelaSign.EQ  && other[tag] == value 
             || relaSign == RelaSign.GEQ && other[tag] >= value
             || relaSign == RelaSign.LEQ && other[tag] <= value);
        }

        public static RelaCondition IsBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
        {
            return new RelaCondition((me, other) => 
                relaSign == RelaSign.EQ  && other.Controller.Board.Count == value
             || relaSign == RelaSign.GEQ && other.Controller.Board.Count >= value
             || relaSign == RelaSign.LEQ && other.Controller.Board.Count <= value);
        }

        public RelaCondition(Func<IPlayable, IPlayable, bool> function)
        {
            _function = function;
        }

        public bool Eval(IPlayable owner, IPlayable affected)
        {
            return _function(owner, affected);
        }

    }
}