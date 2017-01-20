using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HearthDb.Enums;
using SabberStone.Model;
using SimpleAi.Meta;

namespace SimpleUi.Deck
{
    internal interface IDeck
    {
        string Name { get; set; }
        string Link { get; set; }
        FormatType FormatType { get; set; }
        List<string> CardIds { get; set; }
    }

    public class MetaDeck : IDeck
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public CardClass HeroClass { get; set; }
        public FormatType FormatType { get; set; }
        public Strategy Strategy { get; set; }
        public List<string> CardIds { get; set; }
    }
}
