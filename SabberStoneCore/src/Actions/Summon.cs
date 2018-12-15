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
using System;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<Controller, Minion, int, bool> SummonBlock
			=> delegate (Controller c, Minion minion, int zonePosition)
			{
				SummonPhase.Invoke(c, minion, zonePosition);

				AfterSummonTrigger.Invoke(c, minion);

				return true;
			};

		private static Action<Controller, Minion, int> SummonPhase
			=> delegate (Controller c, Minion minion, int zonePosition)
			{
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "SummonPhase", !c.Game.Logging? "":$"Summon Minion {minion} to Board of {c.Name}.");
				c.BoardZone.Add(minion, zonePosition);

				c.Game.AuraUpdate();

				c.Game.SummonedMinions.Add(minion);

				// add summon block show entity 
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(minion));
			};

		private static Action<Controller, Minion> AfterSummonTrigger
			=> delegate (Controller c, Minion minion)
			{
				//minion.IsSummoned = true;
				Game game = c.Game;

				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterSummonTrigger(minion);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				if (minion.Race == Race.TOTEM)
					c.NumTotemSummonedThisGame++;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
