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
	internal class EntityData : IEnumerable<KeyValuePair<GameTag, int>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityData"/> class.
		/// </summary>
		/// <param name="card"></param>
		/// <param name="tags"></param>
		internal EntityData(Card card, Dictionary<GameTag, int> tags)
		{
			Card = card;
			//Tags = tags ?? new Dictionary<GameTag, int>(Enum.GetNames(typeof(GameTag)).Length);
			Tags = tags ?? new Dictionary<GameTag, int>(13);
		}

		/// <summary>
		/// A copy constructor. This constructor is only used for copying an <see cref="Entity"/>.
		/// </summary>
		/// <param name="entityData">The source <see cref="EntityData"/>.</param>
		internal EntityData(EntityData entityData)
		{
			Card = entityData.Card;
			Tags = new Dictionary<GameTag, int>(entityData.Tags);
		}

		/// <summary>
		/// Copies data from the other object into this one.
		/// </summary>
		/// <param name="data">The data.</param>
		public void Stamp(EntityData data)
		{
			Tags = new Dictionary<GameTag, int>(data.Tags);
		}

		/// <summary>
		/// Returns a string uniquely identifying this object.
		/// </summary>
		/// <param name="ignore">The tags to ignore during hashing.</param>
		/// <returns>The hash string.</returns>
		public string Hash(params GameTag[] ignore)
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

		/// <summary>
		/// The card which was used to create this instance.
		/// </summary>
		public Card Card { get; }

		/// <summary>
		/// The container with tags used to create this instance.
		/// </summary>
		/// TODO; This might be made private.
		public Dictionary<GameTag, int> Tags { get; private set; }

		/// <summary>Gets or sets the value of a specific GameTag.</summary>
		/// <value></value>
		/// <param name="t">The GameTag.</param>
		/// <returns></returns>
		public int this[GameTag t]
		{
			//get { return Tags.ContainsKey(t) ? Tags[t] : (Card.Tags.ContainsKey(t) ? Card[t] : 0); }
			get
			{
				if (Tags.TryGetValue(t, out int value))
					return value;
				else if (Card.Tags.TryGetValue(t, out value))
					return value;
				return 0;
			}
			set { Tags[t] = value; }
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

		public override string ToString()
		{
			string s = Tags.Aggregate(Card.Name + " - ", (current, tag) => current + new Tag(tag.Key, tag.Value) + ", ");
			return s.Substring(0, s.Length - 2);
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
			Tags.Remove(GameTag.NUM_ATTACKS_THIS_TURN);
		}
	}
}
