using SabberStoneCore.Enums;

namespace SabberStonePowerLog.Model
{
    public abstract class PowerHistoryEntry
    {
        public EPowerType PowerType { get; set; }

        public abstract void Process(PowerGame powerGame);
    }
}