using System;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
    public partial class Generic
    {
        public static Func<Controller, Minion, int, bool> SummonBlock
            => delegate(Controller c, Minion minion, int zonePosition)
            {
                SummonPhase.Invoke(c, minion, zonePosition);

                AfterSummonTrigger.Invoke(c, minion);

                return true;
            };

        private static Action<Controller, Minion, int> SummonPhase
            => delegate(Controller c, Minion minion, int zonePosition)
            {
                if (!minion.HasCharge)
                    minion.IsExhausted = true;
                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "SummonPhase", $"Summon Minion {minion} to Board of {c.Name}.");
                c.BoardZone.Add(minion, zonePosition);

                // add summon block show entity 
                if (c.Game.History)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(minion));
            };

        private static Action<Controller, Minion> AfterSummonTrigger
            => delegate(Controller c, Minion minion)
            {
                minion.IsSummoned = true;
                c.Game.DeathProcessingAndAuraUpdate();
            };
    }
}