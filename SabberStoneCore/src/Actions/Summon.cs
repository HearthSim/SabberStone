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
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Action<Game, Minion, int, IEntity> SummonBlock
			=> delegate (Game g, Minion minion, int zonePosition, IEntity summoner)
			{
				SummonPhase.Invoke(g, minion, zonePosition);

				AfterSummonTrigger.Invoke(g, minion, summoner);
			};

		private static Action<Game, Minion, int> SummonPhase
			=> delegate (Game g, Minion minion, int zonePosition)
			{
				g.Log(LogLevel.INFO, BlockType.PLAY, "SummonPhase", !g.Logging? "":$"Summon Minion {minion} to Board of {minion.Controller.Name}.");
				minion.Controller.BoardZone.Add(minion, zonePosition);

				g.AuraUpdate();

				g.SummonedMinions.Add(minion);

				// add summon block show entity 
				if (g.History)
					g.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(minion));
			};

		private static Action<Game, Minion, IEntity> AfterSummonTrigger
			=> delegate (Game g, Minion minion, IEntity summoner)
			{
				//minion.IsSummoned = true;

				g.TaskQueue.StartEvent();
				EventMetaData temp = g.CurrentEventData;
				if (summoner != null)
					g.CurrentEventData = new EventMetaData(summoner as IPlayable, minion);
				g.TriggerManager.OnAfterSummonTrigger(minion);
				g.ProcessTasks();
				g.CurrentEventData = temp;
				g.TaskQueue.EndEvent();

				if (minion.IsRace(Race.TOTEM))
					minion.Controller.NumTotemSummonedThisGame++;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
