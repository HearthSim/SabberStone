using System.Collections;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Enchants;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model
{
    public interface IEntity : IEnumerable<KeyValuePair<GameTag, int>>
    {
        int Id { get; }
        int OrderOfPlay { get; }
        Game Game { get; set; }
        Card Card { get; }
        Controller Controller { get; set; }
        IZone Zone { get; set; }
        int this[GameTag t] { get; set; }

        void Reset();
        void Stamp(Entity entity);
        string Hash(params GameTag[] ignore);

        List<Enchant> Enchants { get; }
        List<Trigger> Triggers { get; }
    }

    public partial class Entity : IEntity
    {
        internal readonly EntityData _data;

        public int OrderOfPlay { get; protected set; }

        public Controller Controller { get; set; }

        public Game Game { get; set; }

        public IZone Zone { get; set; }

        public Card Card => _data.Card;

        public List<Enchant> Enchants { get; } = new List<Enchant>();

        public List<Trigger> Triggers { get; } = new List<Trigger>();

        protected internal Entity(Game game, Card card, Dictionary<GameTag, int> tags)
        {
            Game = game;
            _data = new EntityData(card, tags);
        }

        public virtual void Stamp(Entity entity)
        {
            OrderOfPlay = entity.OrderOfPlay;
            _data.Stamp(entity._data);
            entity.Enchants.ForEach(p => Enchants.Add(p.Copy(p.SourceId, Game, p.Turn, Enchants, p.Owner)));
            entity.Triggers.ForEach(p => Triggers.Add(p.Copy(p.SourceId, Game, p.Turn, Triggers, p.Owner)));
        }

        public virtual string Hash(params GameTag[] ignore)
        {
            var str = _data.Hash(ignore);
            str.Append("[O:");
            str.Append(OrderOfPlay.ToString());
            str.Append($"][EN:{Enchants.Count}");
            Enchants.ForEach(p => str.Append(p.Hash));
            str.Append($"][TR:{Triggers.Count}");
            Triggers.ForEach(p => str.Append(p.Hash));
            str.Append("]");
            return str.ToString();
        }

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
        /// Sets the native value with out any trigger activated.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        public void SetNativeGameTag(GameTag tag, int value)
        {
            _data[tag] = value;

            if (Game.History && (int)tag < 1000) // && (tag != GameTag.ZONE_POSITION || Zone == null || Zone.Type == Enums.Zone.PLAY || Zone.Type == Enums.Zone.HAND))
                Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, tag, value));
        }

        public int this[GameTag t]
        {
            get
            {
                //if (Card.Name.Equals("Angry Chicken"))
                Game?.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", $"{this} get org. data {t} = {_data[t]}");

                var value = _data[t];

                // cumulative enchanment calculation ... priorizing game, zone, entity
                Game?.Enchants.ForEach(p => value = p.Apply(this, t, value));
                Zone?.Enchants.ForEach(p => value = p.Apply(this, t, value));
                Enchants.ForEach(p => value = p.Apply(this, t, value));

                return value;
            }
            set
            {
                var oldValue = _data[t];
                Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", $"{this} set data {t} to {value} oldvalue {oldValue}");
                if (oldValue == value)
                {
                    Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Entity", $"{this} set data {t} to {value} obsolet as value is already that value.");
                    return;
                }

                SetNativeGameTag(t, value);

                Game.OnEntityChanged(this, t, oldValue, value);


                // don't trigger on explicit turned off heals or predamage changes ....
                if ((t == GameTag.DAMAGE || t == GameTag.PREDAMAGE) && IsIgnoreDamage)
                {
                    return;
                }

                // trigger here
                Game?.Triggers.ForEach(p => p.Change(this, t, oldValue, value));
                Zone?.Triggers.ForEach(p => p.Change(this, t, oldValue, value));
                Triggers.ForEach(p => p.Change(this, t, oldValue, value));
            }
        }

        public virtual void Reset()
        {
            _data.Reset();
            Enchants.Clear();
            Triggers.Clear();
        }

        public static IPlayable FromCard(Controller controller, Card card, Dictionary<GameTag, int> tags = null, IZone zone = null, int id = -1)
        {
            tags = tags ?? new Dictionary<GameTag, int>();
            tags[GameTag.ENTITY_ID] = id > 0 ? id : controller.Game.NextId;
            tags[GameTag.CONTROLLER] = controller.PlayerId;
            tags[GameTag.ZONE] = zone != null ? (int) zone.Type : 0;
            //tags[GameTag.CARD_ID] = card.AssetId;

            IPlayable result = null;
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
                    tags[GameTag.HEALTH] = card[GameTag.HEALTH];
                    tags[GameTag.ZONE] = (int) Enums.Zone.PLAY;
                    //tags[GameTag.FACTION] = card[GameTag.FACTION];
                    tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
                    //tags[GameTag.RARITY] = card[GameTag.RARITY];
                    //tags[GameTag.HERO_POWER] = card[GameTag.HERO_POWER];
                    result = new Hero(controller, card, tags);
                    break;

                case CardType.HERO_POWER:
                    tags[GameTag.COST] = card[GameTag.COST];
                    tags[GameTag.ZONE] = (int)Enums.Zone.PLAY;
                    //tags[GameTag.FACTION] = card[GameTag.FACTION];
                    tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
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

            if (result.ChooseOne && id < 0)
            {
                result.ChooseOnePlayables[0] = FromCard(controller, 
                    Cards.FromId(result.Card.Id + "a"), 
                    new Dictionary<GameTag, int>
                    {
                        [GameTag.CREATOR] = result.Id,
                        [GameTag.PARENT_CARD] = result.Id
                    }, 
                    controller.Setaside);

                result.ChooseOnePlayables[1] = FromCard(controller, 
                    Cards.FromId(result.Card.Id + "b"), 
                    new Dictionary<GameTag, int>
                    {
                        [GameTag.CREATOR] = result.Id,
                        [GameTag.PARENT_CARD] = result.Id
                    }, 
                    controller.Setaside);
            }

            return result;
        }

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
    }

    public partial class Entity
    {
        public int Id => _data[GameTag.ENTITY_ID];

        public bool TurnStart
        {
            get { return this[GameTag.TURN_START] == 1; }
            set { this[GameTag.TURN_START] = value ? 1 : 0; }
        }

        public void TurnEnd()
        {
            this[GameTag.TURN_START] = 0;
        }

        public int Overload
        {
            get { return this[GameTag.OVERLOAD]; }
            set { this[GameTag.OVERLOAD] = value; }
        }

        public int Cost
        {
            get { return this[GameTag.COST]; }
            set { this[GameTag.COST] = value; }
        }

        public bool Combo => this[GameTag.COMBO] == 1;

        public bool ChooseOne
        {
            get { return this[GameTag.CHOOSE_ONE] == 1; }
            set { this[GameTag.CHOOSE_ONE] = value ? 1 : 0; }
        }

        public bool ChooseBoth
        {
            get { return this[GameTag.CHOOSE_BOTH] == 1; }
            set { this[GameTag.CHOOSE_BOTH] = value ? 1 : 0; }
        }

        public bool ToBeDestroyed
        {
            get { return this[GameTag.TO_BE_DESTROYED] == 1; }
            set { this[GameTag.TO_BE_DESTROYED] = value ? 1 : 0; }
        }

        public int ZonePosition
        {
            get { return this[GameTag.ZONE_POSITION] - 1; }
            set { this[GameTag.ZONE_POSITION] = value + 1; }
        }

        public int NumTurnsInPlay
        {
            get { return this[GameTag.NUM_TURNS_IN_PLAY]; }
            set { this[GameTag.NUM_TURNS_IN_PLAY] = value; }
        }

        public bool IsExhausted
        {
            get { return this[GameTag.EXHAUSTED] == 1; }
            set { this[GameTag.EXHAUSTED] = value ? 1 : 0; }
        }

        public bool IsSummoned
        {
            get { return this[GameTag.SUMMONED] == 1; }
            set { this[GameTag.SUMMONED] = value ? 1 : 0; }
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

        public bool JustPlayed
        {
            get { return this[GameTag.JUST_PLAYED] == 1; }
            set { this[GameTag.JUST_PLAYED] = value ? 1 : 0; }
        }

        public int CardTarget
        {
            get { return this[GameTag.CARD_TARGET]; }
            set { this[GameTag.CARD_TARGET] = value; }
        }

        public bool HasDeathrattle
        {
            get { return this[GameTag.DEATHRATTLE] == 1; }
            set { this[GameTag.DEATHRATTLE] = value ? 1 : 0; }
        }

    }
}