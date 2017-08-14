using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Holds original entity data for a specific card.
	/// </summary>
	internal class EntityData : IEnumerable<KeyValuePair<GameTag, int>>, IModel<EntityData>
	{
		/// <summary>
		/// The card which was used to create this instance.
		/// </summary>
		public Card Card { get; }

		/// <summary>
		/// The container with tags used to create this instance.
		/// </summary>
		/// TODO; This might be made private.
		public Dictionary<GameTag, int> Tags { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EntityData"/> class.
		/// </summary>
		/// <param name="card"></param>
		/// <param name="tags"></param>
		internal EntityData(Card card, Dictionary<GameTag, int> tags)
		{
			Card = card;
			Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
		}

		/// <summary>Gets or sets the value of a specific GameTag.</summary>
		/// <value></value>
		/// <param name="t">The GameTag.</param>
		/// <returns></returns>
		public int this[GameTag t]
		{
			get { return Tags.ContainsKey(t) ? Tags[t] : (Card.Tags.ContainsKey(t) ? Card[t] : 0); }
			set { Tags[t] = value; }
		}

		/// <summary>Resets all tags from the container.</summary>
		public void Reset(Dictionary<GameTag, int> tags = null)
		{
			//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
			Tags.Remove(GameTag.ATK);
			Tags.Remove(GameTag.HEALTH);
			Tags.Remove(GameTag.COST);
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

		public EntityData Clone(Game newGame)
		{
			return new EntityData(Card, new Dictionary<GameTag, int>(Tags)); // Shallow dictionary clone
		}

		public string ToHash(params GameTag[] ignore)
		{
			var hash = new StringBuilder();
			hash.Append("[");
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
			return hash.ToString();
		}

		public void Stamp(IModel other)
		{
			EntityData data = other as EntityData ?? throw new InvalidProgramException("other's type is invalid");
			Tags = new Dictionary<GameTag, int>(data.Tags);
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}

		public override string ToString()
		{
			string s = Tags.Aggregate(Card.Name + " - ", (current, tag) => current + new Tag(tag.Key, tag.Value) + ", ");
			return s.Substring(0, s.Length - 2);
		}

		public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
		{
			// Entity ID
			var allTags = new Dictionary<GameTag, int>(Card.Tags);

			// Entity tags override card tags
			foreach (KeyValuePair<GameTag, int> tag in Tags)
			{
				allTags[tag.Key] = tag.Value;
			}

			return allTags.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}