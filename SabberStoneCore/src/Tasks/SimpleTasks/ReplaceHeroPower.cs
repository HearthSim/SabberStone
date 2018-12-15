#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceHeroPower : SimpleTask
	{
		private ReplaceHeroPower(HeroPower power, Card cardPower)
		{
			Power = power;
			PowerCard = cardPower;
		}

		public ReplaceHeroPower()
		{
			Power = null;
			PowerCard = null;
		}

		public ReplaceHeroPower(HeroPower power)
		{
			Power = power;
			PowerCard = null;
		}

		public ReplaceHeroPower(Card cardPower)
		{
			Power = null;
			PowerCard = cardPower;
		}

		public HeroPower Power { get; set; }

		public Card PowerCard { get; set; }

		public override TaskState Process()
		{
			if (Controller == null)
			{
				return TaskState.STOP;
			}

			if (PowerCard == null && Power == null)
			{
				if (Playables.Count != 1 || !(Playables[0] is HeroPower))
				{
					return TaskState.STOP;
				}

				Power = (HeroPower)Playables[0];
			}

			if (PowerCard != null)
			{
				Power = Entity.FromCard(Controller, PowerCard) as HeroPower;
			}

			Power[GameTag.CREATOR] = Controller.Hero.Id;
			Game.Log(LogLevel.INFO, BlockType.PLAY, "ReplaceHeroPower", !Game.Logging? "":$"{Controller.Hero} power replaced by {Power}");

			Controller.SetasideZone.MoveTo(Controller.Hero.HeroPower, Controller.SetasideZone.Count);
			Controller.Hero.HeroPower = Power;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ReplaceHeroPower(Power, PowerCard);
			clone.Copy(this);
			return clone;
		}
	}
}
