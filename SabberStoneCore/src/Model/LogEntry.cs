using System;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{

    public sealed class LogEntry
    {
        public DateTime TimeStamp { get; set; }
        public ELogLevel Level { get; set; }
        public EBlockType BlockType { get; set; }
        public string Location { get; set; }
        public string Text { get; set; }

    }
}
