using System;
using HearthDb.Enums;
using log4net;
using SabberStone.Model;

namespace SabberStone.Conditions
{
    public enum RelaSign
    {
        EQ, GEQ, LEQ
    }
    public class RelaCondition
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Func<IPlayable, IPlayable, bool> _function;

        public static RelaCondition IsEnraged { get; } = new RelaCondition((me, other) => me is ICharacter && ((ICharacter)me).Damage > 0);
        public static RelaCondition IsMyWeapon { get; } = new RelaCondition((me, other) => me.Controller.Hero.Weapon != null && me.Controller.Hero.Weapon == other);

        public static RelaCondition IsWeaponEquiped { get; } = new RelaCondition((me, other) => me.Controller.Hero.Weapon != null);

        public static RelaCondition IsFriendly { get; } = new RelaCondition((me, other) => me.Controller == other.Controller);
        public static RelaCondition IsSameZone { get; } = new RelaCondition((me, other) => me.Zone == other.Zone);
        public static RelaCondition IsSelf{ get; } = new RelaCondition((me, other) => me == other);
        public static RelaCondition IsNotSelf { get; } = new RelaCondition((me, other) => me != other);
        public static RelaCondition IsSideBySide { get; } = new RelaCondition((me, other) =>  me.Zone == other.Zone && Math.Abs(me[GameTag.ZONE_POSITION]-other[GameTag.ZONE_POSITION]) == 1);
        public static RelaCondition IsSameRace { get; } = new RelaCondition((me, other) => me is ICharacter && other is ICharacter && ((ICharacter)me).Race == ((ICharacter)other).Race);

        public static RelaCondition IsOtherSpell { get; } = new RelaCondition((me, other) => other is Spell);
        public static RelaCondition IsOtherTotem { get; } = new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).Race == Race.TOTEM);
        public static RelaCondition IsSpellDmgOnHero { get; } = new RelaCondition((me, other) => me.Controller.Hero.SpellPower > 0);
        public static RelaCondition IsOtherMinion { get; } = new RelaCondition((me, other) => other is Minion);

        public static RelaCondition HasTargetTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
        {
            return new RelaCondition((me, other) => 
             relaSign == RelaSign.EQ  && other[tag] == value 
          || relaSign == RelaSign.GEQ && other[tag] >= value
          || relaSign == RelaSign.LEQ && other[tag] <= value);
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