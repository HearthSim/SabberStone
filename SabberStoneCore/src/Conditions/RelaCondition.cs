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
		public static RelaCondition IsMyHeroAttacked => new RelaCondition((me, other) => other is ICharacter && (me.Game.ProposedDefender == me.Controller.Hero.Id));
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
