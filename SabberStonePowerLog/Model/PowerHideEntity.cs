using System;

namespace SabberStonePowerLog.Model
{
    internal class PowerHideEntity : PowerHistoryEntry
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Zone { get; set; }
        public string ZonePos { get; set; }
        public string CardId { get; set; }
        public string PlayerId { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }

        public override void Process(PowerGame powerGame)
        {
            throw new NotImplementedException();
        }
    }
}
