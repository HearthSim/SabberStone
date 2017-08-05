using SabberStoneCore.Collections;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities.Playables;
using SabberStoneCore.Model.Zones;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Entities
{
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
	public class Entity : IEntity
	{

		#region TAG_SHORTCUTS

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public int Id => _data[EGameTag.ENTITY_ID];

		public bool TurnStart
		{
			get { return this[EGameTag.TURN_START] == 1; }
			set { this[EGameTag.TURN_START] = value ? 1 : 0; }
		}

		public void TurnEnd()
		{
			this[EGameTag.TURN_START] = 0;
		}

		public int Overload
		{
			get { return this[EGameTag.OVERLOAD]; }
			set { this[EGameTag.OVERLOAD] = value; }
		}

		public int Cost
		{
			get { return this[EGameTag.COST]; }
			set { this[EGameTag.COST] = value; }
		}

		public bool ComboMechanic => this[EGameTag.COMBO] == 1;

		public bool ChooseOneMechanic
		{
			get { return this[EGameTag.CHOOSE_ONE] == 1; }
			set { this[EGameTag.CHOOSE_ONE] = value ? 1 : 0; }
		}

		public bool ToBeDestroyed
		{
			get { return this[EGameTag.TO_BE_DESTROYED] == 1; }
			set { this[EGameTag.TO_BE_DESTROYED] = value ? 1 : 0; }
		}

		public int ZonePosition
		{
			get { return this[EGameTag.ZONE_POSITION] - 1; }
			set { this[EGameTag.ZONE_POSITION] = value + 1; }
		}

		public int NumTurnsInPlay
		{
			get { return this[EGameTag.NUM_TURNS_IN_PLAY]; }
			set { this[EGameTag.NUM_TURNS_IN_PLAY] = value; }
		}

		public bool IsExhausted
		{
			get { return this[EGameTag.EXHAUSTED] == 1; }
			set { this[EGameTag.EXHAUSTED] = value ? 1 : 0; }
		}

		public bool IsSummoned
		{
			get { return this[EGameTag.SUMMONED] == 1; }
			set { this[EGameTag.SUMMONED] = value ? 1 : 0; }
		}

		public bool IsIgnoringDamage
		{
			get { return this[EGameTag.IGNORE_DAMAGE] == 1; }
			set { this[EGameTag.IGNORE_DAMAGE] = value ? 1 : 0; }
		}

		public int JadeGolem
		{
			get { return this[EGameTag.JADE_GOLEM]; }
			set { this[EGameTag.JADE_GOLEM] = value; }
		}

		public bool JustPlayed
		{
			get { return this[EGameTag.JUST_PLAYED] == 1; }
			set { this[EGameTag.JUST_PLAYED] = value ? 1 : 0; }
		}

		public int CardTarget
		{
			get { return this[EGameTag.CARD_TARGET]; }
			set { this[EGameTag.CARD_TARGET] = value; }
		}

		public bool HasDeathrattle
		{
			get { return this[EGameTag.DEATHRATTLE] == 1; }
			set { this[EGameTag.DEATHRATTLE] = value ? 1 : 0; }
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		#endregion

		#region PROPERTIES

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public int OrderOfPlay { get; protected set; }

		public Controller Controller { get; set; }

		public Game Game { get; set; }

		public IZone Zone { get; set; }

		public Card Card => _data.Card;

		public IList<Enchant> Enchants { get; } = new List<Enchant>();

		public IList<Trigger> Triggers { get; } = new List<Trigger>();

		public int this[EGameTag t]
		{
			get
			{
				//if (Card.Name.Equals("Angry Chicken"))
				//Game?.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", $"{this} get org. data {t} = {_data[t]}");

				int value = _data[t];

				// cumulative enchanment calculation ... priorizing game, zone, entity
				Game?.Enchants.ForEach(p => value = p.Apply(this, t, value));
				Zone?.Enchants.ForEach(p => value = p.Apply(this, t, value));
				Enchants.ForEach(p => value = p.Apply(this, t, value));

				return value;
			}
			set
			{
				int oldValue = _data[t];
				Game.Log(ELogLevel.DEBUG, EBlockType.TRIGGER, "Entity", $"{this} set data {t} to {value} oldvalue {oldValue}");
				//if (oldValue == value && t != GameTag.ZONE_POSITION)
				//{
				//    Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", $"{this} set data {t} to {value} obsolet as value is already that value.");
				//    return;
				//}

				SetNativeGameTag(t, value);

				Game.OnEntityChanged(this, t, oldValue, value);


				// don't trigger on explicit turned off heals or predamage changes ....
				if ((t == EGameTag.DAMAGE || t == EGameTag.PREDAMAGE) && IsIgnoringDamage)
				{
					return;
				}

				// trigger here
				Game?.Triggers.ForEach(p => p.Change(this, t, oldValue, value));
				Zone?.Triggers.ForEach(p => p.Change(this, t, oldValue, value));
				Triggers.ForEach(p => p.Change(this, t, oldValue, value));
			}
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		#endregion

		/// <summary>
		/// This object holds the original tag values, defined through the constructor 
		/// of this instance.
		/// These tags are usefull when values are needed without any buffs/debuffs applied.
		/// </summary>
		internal readonly EntityData _data;

		/// <summary>Initializes a new instance of the <see cref="Entity"/> class.</summary>
		/// <param name="game">The game.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		protected internal Entity(Game game, Card card, Dictionary<EGameTag, int> tags)
		{
			Game = game;
			_data = new EntityData(card, tags);
		}

		/// <summary>Resets all tags (properties) to default values derived from the orginal card object.</summary>
		/// <autogeneratedoc />
		public virtual void Reset()
		{
			_data.Reset();
			Enchants.Clear();
			Triggers.Clear();
		}

		/// <summary>
		/// Gets the native value with out any enchanment or aura applied.
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public int GetNativeGameTag(EGameTag t)
		{
			return _data[t];
		}

		/// <summary>
		/// Sets the native value without any trigger activated.
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="value"></param>
		public void SetNativeGameTag(EGameTag tag, int value)
		{
			_data[tag] = value;

			if (Game.HistoryEnabled && (int)tag < 1000)
			{
				Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, tag, value));
			}
		}

		/// <summary>Builds a new subclass of entity that can be added to a SabberStone game instance.</summary>
		/// <param name="controller">The controller of the entity.</param>
		/// <param name="card">The card from which the entity must be derived.</param>
		/// <param name="tags">The tags preset for the entity.</param>
		/// <param name="zone">The zone in which the entity must spawn.</param>
		/// <param name="id">The EntityID to assign to the newly created entity.</param>
		/// <returns></returns>
		/// <exception cref="EntityException"></exception>
		public static IPlayable FromCard(Controller controller, Card card, Dictionary<EGameTag, int> tags = null, IZone zone = null, int id = -1)
		{
			tags = tags ?? new Dictionary<EGameTag, int>();
			tags[EGameTag.ENTITY_ID] = id > 0 ? id : controller.Game.NextEntityID;
			tags[EGameTag.CONTROLLER] = controller.PlayerId;
			tags[EGameTag.ZONE] = zone != null ? (int)zone.Type : 0;
			//tags[GameTag.CARD_ID] = card.AssetId;

			IPlayable result = null;
			switch (card.Type)
			{
				case ECardType.MINION:
					result = new Minion(controller, card, tags);
					break;

				case ECardType.SPELL:
					result = new Spell(controller, card, tags);
					break;

				case ECardType.WEAPON:
					result = new Weapon(controller, card, tags);
					break;

				case ECardType.HERO:
					tags[EGameTag.HEALTH] = card[EGameTag.HEALTH];
					tags[EGameTag.ZONE] = (int)EZone.PLAY;
					//tags[GameTag.FACTION] = card[GameTag.FACTION];
					tags[EGameTag.CARDTYPE] = card[EGameTag.CARDTYPE];
					//tags[GameTag.RARITY] = card[GameTag.RARITY];
					//tags[GameTag.HERO_POWER] = card[GameTag.HERO_POWER];
					result = new Hero(controller, card, tags);
					break;

				case ECardType.HERO_POWER:
					tags[EGameTag.COST] = card[EGameTag.COST];
					tags[EGameTag.ZONE] = (int)EZone.PLAY;
					//tags[GameTag.FACTION] = card[GameTag.FACTION];
					tags[EGameTag.CARDTYPE] = card[EGameTag.CARDTYPE];
					//tags[GameTag.RARITY] = card[GameTag.RARITY];
					//tags[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = card[GameTag.COST];
					result = new HeroPower(controller, card, tags);
					break;

				default:
					throw new EntityException($"Couldn't create entity, because of an unknown cardType {card.Type}.");
			}

			// add entity to the game dic
			controller.Game.Entities.Add(result.Id, result);

			// add power history full entity 
			if (controller.Game.HistoryEnabled)
			{
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.FullEntity(result));
			}

			// add entity to the appropriate zone if it was given
			zone?.Add(result);

			if (result.ChooseOneMechanic && id < 0)
			{
				result.ChooseOnePlayables[0] = FromCard(controller,
					Cards.FromId(result.Card.Id + "a"),
					new Dictionary<EGameTag, int>
					{
						[EGameTag.CREATOR] = result.Id,
						[EGameTag.PARENT_CARD] = result.Id
					},
					controller.Setaside);

				result.ChooseOnePlayables[1] = FromCard(controller,
					Cards.FromId(result.Card.Id + "b"),
					new Dictionary<EGameTag, int>
					{
						[EGameTag.CREATOR] = result.Id,
						[EGameTag.PARENT_CARD] = result.Id
					},
					controller.Setaside);
			}

			return result;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public virtual void Stamp(Entity entity)
		{
			OrderOfPlay = entity.OrderOfPlay;
			_data.Stamp(entity._data);

			foreach (Enchant enchantment in entity.Enchants)
			{
				Enchant copied = enchantment.Copy(enchantment.SourceId, Game, enchantment.Turn, Enchants, enchantment.Owner, enchantment.RemoveTriggers);
				Enchants.Add(copied);
			}

			foreach (Trigger trigger in entity.Triggers)
			{
				Trigger copied = trigger.Copy(trigger.SourceId, Game, trigger.Turn, Triggers, trigger.Owner);
				Triggers.Add(copied);
			}
		}

		public virtual string Hash(params EGameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append(_data.Hash(ignore));
			str.Append("[O:");
			str.Append(OrderOfPlay.ToString());
			str.Append($"][EN:{Enchants.Count}");
			Enchants.ForEach(p => str.Append(p.Hash));
			str.Append($"][TR:{Triggers.Count}");
			Triggers.ForEach(p => str.Append(p.Hash));
			str.Append("]");
			return str.ToString();
		}

		public override string ToString()
		{
			return $"'{Card.Name}[{Id}]'";
		}

		public IEnumerator<KeyValuePair<EGameTag, int>> GetEnumerator()
		{
			return _data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	}
}