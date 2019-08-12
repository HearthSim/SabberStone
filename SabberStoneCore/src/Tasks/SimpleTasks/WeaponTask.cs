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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class WeaponTask : SimpleTask
	{
		private readonly Card _card;
		private readonly bool _op;

		public WeaponTask(string cardId = null, bool opponent = false)
		{
			if (cardId != null)
				_card = Cards.FromId(cardId);

			_op = opponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (_card == null && stack?.Playables.Count != 1) return TaskState.STOP;

			Controller c = _op ? controller.Opponent : controller;

			Weapon weapon = _card != null
				? Entity.FromCard(c, _card) as Weapon
				: stack?.Playables[0] as Weapon;

			if (weapon == null)
				return TaskState.STOP;

			weapon.Card.Power?.Aura?.Activate(weapon);
			weapon.Card.Power?.Trigger?.Activate(weapon);
			c.Hero.AddWeapon(weapon);

			return TaskState.COMPLETE;
		}
	}
}
