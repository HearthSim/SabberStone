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

				// add summon block show entity 
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(minion));
			};

		private static Action<Controller, Minion> AfterSummonTrigger
			=> delegate (Controller c, Minion minion)
			{
				//minion.IsSummoned = true;
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterSummonTrigger(minion);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				if (minion.Race == Race.TOTEM)
					c.NumTotemSummonedThisGame++;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
