using System.Collections.Generic;
using System.Linq;
using System.Text;
using HearthDb.Enums;
using log4net;
using SabberStone.Enchants;

namespace SabberStone.Model
{
    public class Card
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public int AssetId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public List<string> Entourage { get; set; }

        public Dictionary<GameTag, int> Tags { get; set; }

        public Dictionary<GameTag, int> RefTags { get; set; }

        public Dictionary<PlayReq, int> Requirements { get; set; }

        public int this[GameTag t] => Tags.ContainsKey(t) ? Tags[t] : 0;

        public bool Collectible => this[GameTag.COLLECTIBLE] == 1;

        public CardClass Class => (CardClass)this[GameTag.CLASS];

        public Race Race => (Race)this[GameTag.CARDRACE];

        public Faction Faction => (Faction)this[GameTag.FACTION];

        public bool HasCombo => this[GameTag.COMBO] == 1;

        public Rarity Rarity => (Rarity)this[GameTag.RARITY];

        public CardType Type => (CardType)this[GameTag.CARDTYPE];

        public CardSet Set => (CardSet) this[GameTag.CARD_SET];
         
        public int Cost => this[GameTag.COST];

        public bool HasOverload => this[GameTag.OVERLOAD] == 1;

        public int Overload => this[GameTag.OVERLOAD_OWED];

        public bool RequiresTarget => Requirements.ContainsKey(PlayReq.REQ_TARGET_TO_PLAY);

        public bool RequiresTargetIfAvailable => Requirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE);

        public bool RequiresTargetIfAvailableAndDragonInHand => Requirements.ContainsKey(PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND);

        public int MaxAllowedInDeck => Rarity == Rarity.LEGENDARY ? 1 : 2;

        public string AbbrieviatedName(int size)
        {
            if (Name.Length <= size)
            {
                return Name;
            } else if (!Name.Contains(" "))
            {
                return Name.Substring(0, size);
            }
            else
            {
                var strArray = Name.Split(' ');
                return string.Join("", strArray.Select(p => p.Length > 4 ? p.Substring(0, 4) : p).ToList()).Substring(0, 7);
            }
           
        }

        public List<Enchantment> Enchantments { get; set; } = new List<Enchantment>();

        public bool IsAffectedBySpellDamage { get; set; }

        public int MultiClassGroup => this[GameTag.MULTI_CLASS_GROUP];

        public override string ToString()
        {
            return $"[{Name}]";
        }

        public string FullPrint(bool gameTag = false, bool playReq = false)
        {
            var builder = new StringBuilder();
            builder.Append($"[CARD: {Name} - {Id} (Col={Collectible},Set={Set})]");
            if (gameTag)
            {
                builder.Append("\n   GameTags:");
                Tags.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
            }
            if (playReq)
            {
                builder.Append("\n   PlayReq:");
                Requirements.ToList().ForEach(pair => builder.Append($"\n   - {pair.Key} -> {pair.Value}"));
            }
            return builder.ToString();
        }

        internal static Card CardGame => new Card()
        {
            Id = "Game",
            Name = "Game",
            Tags = new Dictionary<GameTag, int> { [GameTag.CARDTYPE] = (int)CardType.GAME },
            Requirements = new Dictionary<PlayReq, int>(),
        };

        internal static Card CardPlayer => new Card()
        {
            Id = "Player",
            Name = "Player",
            Tags = new Dictionary<GameTag, int> { [GameTag.CARDTYPE] = (int)CardType.PLAYER },
            Requirements = new Dictionary<PlayReq, int>(),
        };
    }
}
