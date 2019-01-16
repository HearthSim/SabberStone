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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceWeaponTask : SimpleTask
	{
		public ReplaceWeaponTask(Card cardWeapon)
		{
			WeaponCard = cardWeapon;
		}
		public ReplaceWeaponTask(string cardIdWeapon)
		{
			WeaponCard = Cards.FromId(cardIdWeapon);
		}

		public Card WeaponCard { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Controller == null)
			{
				return TaskState.STOP;
			}
			Controller.Hero.AddWeapon(Entity.FromCard(Controller, WeaponCard) as Weapon);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ReplaceWeaponTask(WeaponCard);
			clone.Copy(this);
			return clone;
		}
	}
}