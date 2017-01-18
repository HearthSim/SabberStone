using System;
using System.Reflection;
using log4net;
using SabberStone.Model;

namespace SabberStone.Actions
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
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                if (!minion.HasCharge)
                    minion.IsExhausted = true;
                log.Info($"[SummonPhase] Summon Minion {minion} to Board of {c.Name}.");
                c.Game.PlayTaskLog.AppendLine($"[SummonPhase] Summon Minion {minion} to Board of {c.Name}.");
                c.Board.Add(minion, zonePosition);
            };

        private static Action<Controller, Minion> AfterSummonTrigger
            => delegate(Controller c, Minion minion)
            {
                minion.IsSummoned = true;
                c.Game.DeathProcessingAndAuraUpdate();
            };
    }
}