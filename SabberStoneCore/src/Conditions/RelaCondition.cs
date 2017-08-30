using System;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Conditions
{
	/// <summary>
	/// Container for all conditions about the relation between 2 <see cref="IPlayable"/>
	/// instances.
	/// </summary>
	public class RelaCondition
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		private readonly Func<IPlayable, IPlayable, bool> _function;

		public static RelaCondition IsMyWeapon => new RelaCondition((me, other) => me.Controller.Hero.Weapon != null && me.Controller.Hero.Weapon == other);
		public static RelaCondition IsFriendly => new RelaCondition((me, other) => me.Controller == other.Controller);
		public static RelaCondition IsSameZone => new RelaCondition((me, other) => me.Zone == other.Zone);
		public static RelaCondition IsSelf => new RelaCondition((me, other) => me == other);
		public static RelaCondition IsNotSelf => new RelaCondition((me, other) => me != other);
		public static RelaCondition IsSideBySide => new RelaCondition((me, other) => me.Zone == other.Zone && Math.Abs(me.ZonePosition - other.ZonePosition) == 1);
		public static RelaCondition IsSameRace => new RelaCondition((me, other) => me is ICharacter && other is ICharacter && ((ICharacter)me).Race == ((ICharacter)other).Race);
		public static RelaCondition IsMyHeroAttacked => new RelaCondition((me, other) => other is ICharacter && ((ICharacter)other).ProposedDefender == me.Controller.Hero.Id);
		public static RelaCondition IsTargetingMe => new RelaCondition((me, other) => other.CardTarget == me.Id);

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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
