using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCoreGui.Meta;

namespace SabberStoneGui.Deck
{
    internal interface IDeck
    {
        string Name { get; set; }
        string Link { get; set; }
        EFormatType FormatType { get; set; }
        List<string> CardIds { get; set; }
    }

    public class MetaDeck : IDeck
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public ECardClass HeroClass { get; set; }
        public EFormatType FormatType { get; set; }
        public Strategy Strategy { get; set; }
        public List<string> CardIds { get; set; }
    }
}
