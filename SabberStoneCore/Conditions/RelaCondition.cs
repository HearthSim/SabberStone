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

        public static RelaCondition IsMyWeapon => new RelaCondition((me, other) => me.Controller.Hero.Weapon != null && me.Controller.Hero.Weapon == other);
        public static RelaCondition IsFriendly => new RelaCondition((me, other) => me.Controller == other.Controller);
        public static RelaCondition IsSameZone => new RelaCondition((me, other) => me.Zone == other.Zone);
        public static RelaCondition IsSelf => new RelaCondition((me, other) => me == other);
        public static RelaCondition IsNotSelf => new RelaCondition((me, other) => me != other);
        public static RelaCondition IsSideBySide => new RelaCondition((me, other) =>  me.Zone == other.Zone && Math.Abs(me[GameTag.ZONE_POSITION]-other[GameTag.ZONE_POSITION]) == 1);
        public static RelaCondition IsSameRace => new RelaCondition((me, other) => me is ICharacter && other is ICharacter && ((ICharacter)me).Race == ((ICharacter)other).Race);
        public static RelaCondition IsMyHeroAttacked => new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).ProposedDefender == me.Controller.Hero.Id);
        public static RelaCondition IsMe(SelfCondition condition) => new RelaCondition((me, other) => condition.Eval(me));
        public static RelaCondition IsOther(SelfCondition condition) => new RelaCondition((me, other) => condition.Eval(other));

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