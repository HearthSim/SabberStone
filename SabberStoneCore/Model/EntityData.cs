using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    internal class EntityData : IEnumerable<KeyValuePair<GameTag, int>>
    {
        internal EntityData(Card card, Dictionary<GameTag, int> tags, int id)
        {
            Card = card;
            Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
            Id = id;
        }

        public void Stamp(EntityData data)
        {
            Tags = new Dictionary<GameTag, int>(data.Tags);
        }

        public StringBuilder Hash(params GameTag[] ignore)
        {
            var hash = new StringBuilder();
            //hash.Append("[");
            //hash.Append(Id.ToString());
            //hash.Append(",");
            hash.Append(Card.Id);
            hash.Append("][GT:");
            var keys = Tags.Keys.ToList();
            keys.Sort();
            keys.ForEach(p =>
            {
                if (!ignore.Contains(p))
                {
                    hash.Append("{");
                    hash.Append(p.ToString());
                    hash.Append(",");
                    hash.Append(Tags[p].ToString());
                    hash.Append("}");
                }
            });
            hash.Append("]");
            return hash;
        }

        public int Id { get; internal set; }

        public Card Card { get; }

        public Dictionary<GameTag, int> Tags { get; private set; }

        public int this[GameTag t]
        {
            get { return Tags.ContainsKey(t) ? Tags[t] : (Card.Tags.ContainsKey(t) ? Card[t] : 0); }
            set { Tags[t] = value; }
        }

        public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
        {
            // Entity ID
            var allTags = new Dictionary<GameTag, int>(Card.Tags)
            {
                {GameTag.ENTITY_ID, Id}
            };

            // Entity tags override card tags
            foreach (var tag in Tags)
            {
                allTags[tag.Key] = tag.Value;
            }

            return allTags.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            var s = Tags.Aggregate(Card.Name + " - ", (current, tag) => current + new Tag(tag.Key, tag.Value) + ", ");
            return s.Substring(0, s.Length - 2);
        }

        public void Reset(Dictionary<GameTag, int> tags = null)
        {
            //Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
            Tags.Remove(GameTag.DAMAGE);
            Tags.Remove(GameTag.TAUNT);
            Tags.Remove(GameTag.FROZEN);
            Tags.Remove(GameTag.ENRAGED);
            Tags.Remove(GameTag.CHARGE);
            Tags.Remove(GameTag.WINDFURY);
            Tags.Remove(GameTag.DIVINE_SHIELD);
            Tags.Remove(GameTag.STEALTH);
            Tags.Remove(GameTag.DEATHRATTLE);
            Tags.Remove(GameTag.BATTLECRY);
            Tags.Remove(GameTag.SILENCED);
        }
    }
}