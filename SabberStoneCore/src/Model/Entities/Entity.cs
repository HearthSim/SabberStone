﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Kettle;
using System.Text;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Exposes the properties for each implementing entity.
	/// </summary>
	public interface IEntity : IEnumerable<KeyValuePair<GameTag, int>>
	{
		/// <summary>Gets the identifier of this entity (EntityID).</summary>
		/// <value>The identifier.</value>
		int Id { get; }

		/// <summary>Gets the ranking order of the moment this entity was played.</summary>
		/// <value>The ranking order.</value>
		int OrderOfPlay { get; set; }

		/// <summary>Gets or sets the game instance from which this entity is part of.</summary>
		/// <value>The game instance.</value>
		Game Game { get; set; }

		/// <summary>Gets the card from which this entity was derived from.</summary>
		/// <value>The card object.</value>
		Card Card { get; }

		/// <summary>Gets or sets the owner of this entity, the controller who played the entity.</summary>
		/// <value>The controller/owner object.</value>
		Controller Controller { get; set; }

		/// <summary>Gets or sets the zone in which the entity exists.</summary>
		/// <value>The zone, <see cref="IZone"/>.</value>
		/// <autogeneratedoc />
		IZone Zone { get; set; }

		/// <summary>Gets or sets the specific <see cref="GameTag"/> for this entity.</summary>
		/// <value><see cref="System.Int32"/>.</value>
		/// <param name="t">The gametag which represents a property of this entity.</param>
		/// <returns></returns>
		int this[GameTag t] { get; set; }

		/// <summary>Resets all tags (properties) to default values derived from the orginal card object.</summary>
		void Reset();

		/// <summary>Copy details from the other entity into into this object.</summary>
		/// <param name="entity">The entity.</param>
		void Stamp(Entity entity);

		/// <summary>Get a string which uniquely defines this entity object.</summary>
		/// <param name="ignore">All tags to ignore when generating the hash.</param>
		/// <returns></returns>
		string Hash(params GameTag[] ignore);

		/// <summary>Get all enchantments hooked onto this entity.</summary>
		/// <value>The enchantments. Enchantments force a temporary effect, for as long as this entity is in play, onto the game.</value>
		//List<OldEnchant> OldEnchants { get; }

		//List<string> Enchants { get; }

		/// <summary>Gets all triggers hooked onto this entity.</summary>
		/// <value>The triggers. Triggers execute a certain effect when the requirements are met.</value>
		/// <autogeneratedoc />
		//List<OldTrigger> Triggers { get; }

		AuraEffects AuraEffects { get; set; }

		Dictionary<GameTag, int> NativeTags { get; }

		List<Enchantment> AppliedEnchantments { get; set; }
	}

	/// <summary>
	/// The base class of all data-holding/action-performing/visible or invisible objects in a SabberStone game.
	/// An entity is defined as a collection of properties, called Tags.
	/// 
	/// <seealso cref="HeroPower"/>
	/// <seealso cref="Hero"/>
	/// <seealso cref="Minion"/>
	/// <seealso cref="Spell"/>
	/// </summary>
	/// <seealso cref="IEntity" />
	public partial class Entity : IEntity
	{
		/// <summary>
		/// This object holds the original tag values, defined through the constructor 
		/// of this instance.
		/// These tags are usefull when values are needed without any buffs/debuffs applied.
		/// </summary>
		internal readonly EntityData _data;

		/// <summary>Gets the ranking order of the moment this entity was played.</summary>
		/// <value>The ranking order.</value>
		public int OrderOfPlay { get; set; }

		/// <summary>Gets or sets the owner of this entity, the controller who played the entity.</summary>
		/// <value>The controller/owner object.</value>
		public Controller Controller { get; set; }

		/// <summary>Gets or sets the game instance from which this entity is part of.</summary>
		/// <value>The game instance.</value>
		public Game Game { get; set; }

		/// <summary>Gets or sets the zone in which the entity exists.</summary>
		/// <value>The zone, <see cref="T:SabberStoneCore.Model.Zones.IZone" />.</value>
		public IZone Zone { get; set; }

		/// <summary>Gets the card from which this entity was derived from.</summary>
		/// <value>The card object.</value>
		public Card Card => _data.Card;

		/// <summary>Get all enchantments hooked onto this entity.</summary>
		/// <value>
		/// The enchantments. Enchantments force a temporary effect, for as long as this entity is in play, onto the game.
		/// </value>
		//public List<OldEnchant> OldEnchants { get; } = new List<OldEnchant>();

		/// <summary>Gets all triggers hooked onto this entity.</summary>
		/// <value>The triggers. Triggers execute a certain effect when the requirements are met.</value>
		//public List<OldTrigger> Triggers { get; } = new List<OldTrigger>();

		/// <summary>Initializes a new instance of the <see cref="Entity"/> class.</summary>
		/// <param name="game">The game.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		protected internal Entity(Game game, Card card, Dictionary<GameTag, int> tags)
		{
			Game = game;
			_data = new EntityData(card, tags);
			Id = _data.Tags[GameTag.ENTITY_ID];
			AuraEffects = new AuraEffects(this);
		}

		/// <summary>
		/// A copy constructor. This constructor is only used to the inherited copy constructors.
		/// </summary>
		/// <param name="game"><see cref="Model.Game"/> instance of a copied entity.</param>
		/// <param name="entity">A source <see cref="Entity"/>.</param>
		protected Entity(Game game, Entity entity)
		{
			Game = game;
			_data = new EntityData(entity._data);
			Id = entity.Id;
			OrderOfPlay = entity.OrderOfPlay;
			AuraEffects = entity.AuraEffects.Clone(this);
			if (entity.AppliedEnchantments != null && entity.AppliedEnchantments.Count > 0)
				AppliedEnchantments = new List<Enchantment>(entity.AppliedEnchantments);
		}


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public virtual void Stamp(Entity entity)
		{
			OrderOfPlay = entity.OrderOfPlay;
			_data.Stamp(entity._data);
		}

		public virtual string Hash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append(_data.Hash(ignore));
			str.Append("[O:");
			str.Append(OrderOfPlay.ToString());
			//str.Append($"][EN:{OldEnchants.Count}");
			//OldEnchants.ForEach(p => str.Append(p.Hash));
			//str.Append($"][TR:{Triggers.Count}");
			//Triggers.ForEach(p => str.Append(p.Hash));
			str.Append("]");
			return str.ToString();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		/// <summary>
		/// Gets the native value with out any enchanment or aura applied.
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public int GetNativeGameTag(GameTag t)
		{
			return _data[t];
		}

		/// <summary>
		/// Sets the native value without any trigger activated.
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="value"></param>
		public void SetNativeGameTag(GameTag tag, int value)
		{
			_data[tag] = value;

			if (Game.History && (int)tag < 1000)
				Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, tag, value));
		}

		/// <summary>
		/// This is the call for a gametag value. At this point triggers
		/// and enchants come into play.
		/// Gets are looking for active enchants on that game tag.
		/// Sets are looking for active triggers on that game tag.
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public virtual int this[GameTag t]
		{
			get
			{
				int value = _data[t];

				value += AuraEffects[t];

				return value > 0 ? value : 0;
			}
			set
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", !Game.Logging? "":$"{this} set data {t} to {value}");

				Game.OnEntityChanged(this, t, 0, value);

				_data[t] = value > 0 ? value : 0;
			}
		}

		/// <summary>
		/// All gametag values that where changed after creation are wiped.
		/// Any enchants and trigger is removed.
		/// </summary>
		public virtual void Reset()
		{
			_data.Reset();
			//OldEnchants.Clear();
			//Triggers.Clear();
		}

		/// <summary>Builds a new subclass of entity that can be added to a SabberStone game instance.</summary>
		/// <param name="controller">The controller of the entity.</param>
		/// <param name="card">The card from which the entity must be derived.</param>
		/// <param name="tags">The tags preset for the entity.</param>
		/// <param name="zone">The zone in which the entity must spawn.</param>
		/// <param name="id">The EntityID to assign to the newly created entity.</param>
		/// <returns></returns>
		/// <exception cref="EntityException"></exception>
		public static IPlayable FromCard(Controller controller, Card card, Dictionary<GameTag, int> tags = null, IZone zone = null, int id = -1)
		{
			tags = tags ?? new Dictionary<GameTag, int>();
			tags[GameTag.ENTITY_ID] = id > 0 ? id : controller.Game.NextId;
			tags[GameTag.CONTROLLER] = controller.PlayerId;
			tags[GameTag.ZONE] = zone != null ? (int)zone.Type : 0;
			//tags[GameTag.CARD_ID] = card.AssetId;

			IPlayable result;
			switch (card.Type)
			{
				case CardType.MINION:
					result = new Minion(controller, card, tags);
					break;

				case CardType.SPELL:
					result = new Spell(controller, card, tags);
					break;

				case CardType.WEAPON:
					result = new Weapon(controller, card, tags);
					break;

				case CardType.HERO:

					// removing this because it's always the cards health or it is given by previous heros like for deathknight
					//tags[GameTag.HEALTH] = card[GameTag.HEALTH];

					//tags[GameTag.ZONE] = (int)Enums.Zone.PLAY;
					//tags[GameTag.FACTION] = card[GameTag.FACTION];
					//tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
					//tags[GameTag.RARITY] = card[GameTag.RARITY];
					//tags[GameTag.HERO_POWER] = card[GameTag.HERO_POWER];

					result = new Hero(controller, card, tags);
					break;

				case CardType.HERO_POWER:
					//tags[GameTag.COST] = card[GameTag.COST];
					tags[GameTag.ZONE] = (int)Enums.Zone.PLAY;
					//tags[GameTag.FACTION] = card[GameTag.FACTION];
					//tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
					//tags[GameTag.RARITY] = card[GameTag.RARITY];
					//tags[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = card[GameTag.COST];
					result = new HeroPower(controller, card, tags);
					break;

				default:
					throw new EntityException($"Couldn't create entity, because of an unknown cardType {card.Type}.");
			}

			// add entity to the game dic
			controller.Game.IdEntityDic.Add(result.Id, result);

			// add power history full entity 
			if (controller.Game.History)
			{
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.FullEntity(result));
			}

			// add entity to the appropriate zone if it was given
			zone?.Add(result);

			if (result.ChooseOne)
			{
				result.ChooseOnePlayables = new IPlayable[2];
				result.ChooseOnePlayables[0] =
					id < 0 ? FromCard(controller,
						Cards.FromId(result.Card.Id + "a"),
						new Dictionary<GameTag, int>
						{
							[GameTag.CREATOR] = result.Id,
							[GameTag.PARENT_CARD] = result.Id
						},
						controller.SetasideZone) :
						controller.SetasideZone.ToList().Find(p => p[GameTag.CREATOR] == result.Id && p.Card.Id == result.Card.Id + "a");

				result.ChooseOnePlayables[1] =
					id < 0 ? FromCard(controller,
						Cards.FromId(result.Card.Id + "b"),
						new Dictionary<GameTag, int>
						{
							[GameTag.CREATOR] = result.Id,
							[GameTag.PARENT_CARD] = result.Id
						},
						controller.SetasideZone) :
						controller.SetasideZone.ToList().Find(p => p[GameTag.CREATOR] == result.Id && p.Card.Id == result.Card.Id + "b");
			}

			return result;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override string ToString()
		{
			return $"'{Card.Name}[{Id}]'";
		}

		public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
		{
			return _data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public partial class Entity
	{

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		//public int Id => _data[GameTag.ENTITY_ID];
		public int Id { get; }

		public bool TurnStart
		{
			get { return this[GameTag.TURN_START] == 1; }
			set { this[GameTag.TURN_START] = value ? 1 : 0; }
		}

		public void TurnEnd()
		{
			this[GameTag.TURN_START] = 0;
		}

		public bool Combo => GetNativeGameTag(GameTag.COMBO) == 1;

		public bool ChooseOne
		{
			//get { return this[GameTag.CHOOSE_ONE] == 1; }
			//set { this[GameTag.CHOOSE_ONE] = value ? 1 : 0; }
			get => _data[GameTag.CHOOSE_ONE] == 1;
			set => SetNativeGameTag(GameTag.CHOOSE_ONE, value ? 1 : 0);
		}

		public bool ToBeDestroyed
		{
			//get { return GetNativeGameTag(GameTag.TO_BE_DESTROYED) == 1; }
			//get => _data.Tags.ContainsKey(GameTag.TO_BE_DESTROYED);
			get => _toBeDestroyed;
			set
			{
				this[GameTag.TO_BE_DESTROYED] = value ? 1 : 0;
				_toBeDestroyed = value;
			}
		}

		private bool _toBeDestroyed;

		public int NumTurnsInPlay
		{
			get { return this[GameTag.NUM_TURNS_IN_PLAY]; }
			set { this[GameTag.NUM_TURNS_IN_PLAY] = value; }
		}

		public bool IsIgnoreDamage
		{
			get { return this[GameTag.IGNORE_DAMAGE] == 1; }
			set { this[GameTag.IGNORE_DAMAGE] = value ? 1 : 0; }
		}

		public int JadeGolem
		{
			get { return this[GameTag.JADE_GOLEM]; }
			set { this[GameTag.JADE_GOLEM] = value; }
		}

		public int CardTarget
		{
			get { return this[GameTag.CARD_TARGET]; }
			set { this[GameTag.CARD_TARGET] = value; }
		}


#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	}

	public partial class Entity
	{
		//public Stack<(GameTag Tag, int LastValue)> OneTurnEffects => _effects ?? (_effects = new Stack<(GameTag, int)>());
		//private Stack<(GameTag, int)> _effects;

		public AuraEffects AuraEffects { get; set; }

		public Dictionary<GameTag, int> NativeTags => _data.Tags;

		public List<Enchantment> AppliedEnchantments { get; set; }
	}
}
