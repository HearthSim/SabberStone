using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCore.Model
{
    public partial class Controller : Entity
    {
        public Controller(Game game, string name, int playerId, int id) 
            : base(game, Card.CardPlayer,
            new Dictionary<GameTag, int>
            {
                //[GameTag.HERO_ENTITY] = heroId,
                [GameTag.MAXHANDSIZE] = 10,
                [GameTag.STARTHANDSIZE] = 4,
                [GameTag.PLAYER_ID] = playerId,
                [GameTag.TEAM_ID] = playerId,
                [GameTag.ZONE] = (int)Enums.Zone.PLAY,
                [GameTag.CONTROLLER] = playerId,
                [GameTag.ENTITY_ID] = id,
                [GameTag.MAXRESOURCES] = 10,
                [GameTag.CARDTYPE] = (int) CardType.PLAYER

            })
        {
            Name = name;
            Zones = new Zones(game, this);
            Game.Log(LogLevel.INFO, BlockType.PLAY, "Controller", $"Created Controller '{name}'");
        }

        public void AddHeroAndPower(Card heroCard, Card powerCard = null)
        {
            Hero = FromCard(this, heroCard) as Hero;
            HeroId = Hero.Id;
            Hero.Power = FromCard(this, powerCard ?? Cards.FromAssetId(Hero[GameTag.SHOWN_HERO_POWER]),
                new Dictionary<GameTag, int> {[GameTag.CREATOR] = Hero.Id}) as HeroPower;
        }

        public void Stamp(Controller controller)
        {
            Zones.Stamp(controller.Zones);
            base.Stamp(controller);
            Hero = FromCard(this, controller.Hero.Card, null, null, controller.Hero.Id) as Hero;
            Hero.Stamp(controller.Hero);
            Hero.Power = FromCard(this, controller.Hero.Power.Card, null, null, controller.Hero.Power.Id) as HeroPower;
            Hero.Power.Stamp(controller.Hero.Power);
            if (controller.Hero.Weapon != null)
            {
                Hero.Weapon =
                    FromCard(this, controller.Hero.Weapon.Card, null, null, controller.Hero.Weapon.Id) as Weapon;
                Hero.Weapon.Stamp(controller.Hero.Weapon);
            }

            if (controller.Choice != null)
            {
                Choice = new Choice(this);
                Choice.Stamp(controller.Choice);
            }
        }

        public override string Hash(params GameTag[] ignore)
        {
            var str = new StringBuilder();
            str.Append("][C:");
            str.Append($"{Name}");
            str.Append("]");
            str.Append(base.Hash(ignore));
            str.Append(Hero.Hash(ignore));
            str.Append(Hero.Power.Hash(ignore));
            if (Hero.Weapon != null)
                str.Append(Hero.Weapon.Hash(ignore));
            str.Append(Zones.Hash(ignore));
            return str.ToString();
        }

        public string Name { get; }

        public Zones Zones { get; }

        public Deck Deck => Zones[SabberStoneCore.Enums.Zone.DECK] as Deck;

        public Hand Hand => Zones[SabberStoneCore.Enums.Zone.HAND] as Hand;

        public Zone<Minion> Board => Zones[SabberStoneCore.Enums.Zone.PLAY] as Zone<Minion>;

        public Zone<IPlayable> Graveyard => Zones[SabberStoneCore.Enums.Zone.GRAVEYARD] as Zone<IPlayable>;

        public Zone<Spell> Secrets => Zones[SabberStoneCore.Enums.Zone.SECRET] as Zone<Spell>;

        public Zone<IPlayable> Setaside => Zones[SabberStoneCore.Enums.Zone.SETASIDE] as Zone<IPlayable>;

        public Hero Hero { get; set; }

        public CardClass HeroClass => Hero.Card.Class;

        public int MaxHandSize => this[GameTag.MAXHANDSIZE];

        public int MaxResources => this[GameTag.MAXRESOURCES];

        public List<Card> Standard => Cards.Standard[HeroClass];

        public List<Card> Wild => Cards.Wild[HeroClass];

        public int RemainingMana => BaseMana + TemporaryMana - (UsedMana + OverloadLocked);

        public bool DragonInHand => Hand.GetAll.Exists(p => p.Card.Race == Race.DRAGON);

        public Choice Choice { get; set; } = null;

        public List<PlayerTask> Options(bool playCards = true)
        {
            var result = new List<PlayerTask>();

            if (this != Game.CurrentPlayer)
                return null;

            if (Choice != null)
            {
                switch (Choice.ChoiceType)
                {
                    case ChoiceType.GENERAL:
                        Choice.Choices.ToList().ForEach(p => result.Add(ChooseTask.Pick(this, p)));
                        return result;

                    case ChoiceType.MULLIGAN:
                        var choices = Util.GetPowerSet(Choice.Choices);
                        choices.ToList().ForEach(p => result.Add(ChooseTask.Mulligan(this, p.ToList())));
                        return result;

                    default:
                        throw new NotImplementedException();
                } 
            }

            // add end turn task ...
            result.Add(EndTurnTask.Any(this));

            if (playCards)
            {
                foreach (var playableCard in Hand)
                {
                    var minion = playableCard as Minion;

                    if (!playableCard.IsPlayableByPlayer)
                        continue;

                    var playables = playableCard.ChooseOne 
                        ? playableCard.ChooseOnePlayables.ToList() 
                        : new List<IPlayable> {playableCard};

                    foreach (var t in playables)
                    {
                        if (!t.IsPlayableByCardReq)
                            continue;

                        var targets = t.ValidPlayTargets.ToList();
                        var subResult = new List<PlayCardTask>();
                        if (!targets.Any())
                        {
                            subResult.Add(PlayCardTask.Any(this, playableCard, null, -1,
                                playables.Count == 1 ? 0 : playables.IndexOf(t) + 1));
                        }

                        subResult.AddRange(
                            targets.Select(
                                target =>
                                    PlayCardTask.Any(this, playableCard, target, -1,
                                        playables.Count == 1 ? 0 : playables.IndexOf(t) + 1)));

                        if (minion != null)
                        {
                            var tempSubResult = new List<PlayCardTask>();
                            var positions = Board.Count + 1;
                            for (var j = 0; j < positions; j++)
                            {
                                subResult.ForEach(p =>
                                {
                                    var task = p.Copy();
                                    task.ZonePosition = j;
                                    tempSubResult.Add(task);
                                });
                            }
                            subResult = tempSubResult;
                        }
                        result.AddRange(subResult);
                    }
                }
            }

            foreach (var minion in Board)
            {
                if (!minion.CanAttack)
                    continue;

                var targets = minion.ValidAttackTargets;
                targets.ToList().ForEach(p => result.Add(MinionAttackTask.Any(this, minion, p)));
            }

            if (Hero.CanAttack)
            {
                var targets = this.Hero.ValidAttackTargets;
                targets.ToList().ForEach(p => result.Add(HeroAttackTask.Any(this, p)));
            }

            if (Hero.Power.IsPlayable)
            {
                var targets = this.Hero.Power.GetValidPlayTargets().ToList();
                if (targets.Any())
                {
                    targets.ToList().ForEach(p => result.Add(HeroPowerTask.Any(this, p)));
                }
                else
                {
                    result.Add(HeroPowerTask.Any(this));
                }
            }

            return result;
        }

        public string FullPrint()
        {
            var str = new StringBuilder();
            str.Append($"{Name}[Mana:{RemainingMana}/{OverloadOwed}/{BaseMana}][{OverloadLocked}]");
            str.Append($"[ENCH {Enchants.Count}]");
            str.Append($"[TRIG {Triggers.Count}]");
            return str.ToString();
        }
    }

    public partial class Controller
    {
        public Controller Opponent => Game.Player1 == this ? Game.Player2 : Game.Player1;

        public int PlayerId
        {
            get { return this[GameTag.PLAYER_ID]; }
            set { this[GameTag.PLAYER_ID] = value; }
        }

        public int HeroId
        {
            get { return this[GameTag.HERO_ENTITY]; }
            set { this[GameTag.HERO_ENTITY] = value; }
        }

        public PlayState PlayState
        {
            get { return (PlayState) this[GameTag.PLAYSTATE]; }
            set { this[GameTag.PLAYSTATE] = (int) value; }
        }

        public Mulligan MulliganState
        {
            get { return (Mulligan)this[GameTag.MULLIGAN_STATE]; }
            set { this[GameTag.MULLIGAN_STATE] = (int)value; }
        }

        public int BaseMana
        {
            get { return this[GameTag.RESOURCES]; }
            set { this[GameTag.RESOURCES] = value; }
        }

        public int UsedMana
        {
            get { return this[GameTag.RESOURCES_USED]; }
            set { this[GameTag.RESOURCES_USED] = value; }
        }

        public int TemporaryMana
        {
            get { return this[GameTag.TEMP_RESOURCES]; }
            set { this[GameTag.TEMP_RESOURCES] = value; }
        }

        public bool IsComboActive
        {
            get { return this[GameTag.COMBO_ACTIVE] == 1; }
            set { this[GameTag.COMBO_ACTIVE] = value ? 1 : 0; }
        }

        public int NumCardsDrawnThisTurn
        {
            get { return this[GameTag.NUM_CARDS_DRAWN_THIS_TURN]; }
            set { this[GameTag.NUM_CARDS_DRAWN_THIS_TURN] = value; }
        }

        public int NumAttacksThisTurn
        {
            get { return this[GameTag.NUM_ATTACKS_THIS_TURN]; }
            set { this[GameTag.NUM_ATTACKS_THIS_TURN] = value; }
        }

        public int NumCardsPlayedThisTurn
        {
            get { return this[GameTag.NUM_CARDS_PLAYED_THIS_TURN]; }
            set { this[GameTag.NUM_CARDS_PLAYED_THIS_TURN] = value; }
        }

        public int NumMinionsPlayedThisTurn
        {
            get { return this[GameTag.NUM_MINIONS_PLAYED_THIS_TURN]; }
            set { this[GameTag.NUM_MINIONS_PLAYED_THIS_TURN] = value; }
        }

        public int NumOptionsPlayedThisTurn
        {
            get { return this[GameTag.NUM_OPTIONS_PLAYED_THIS_TURN]; }
            set { this[GameTag.NUM_OPTIONS_PLAYED_THIS_TURN] = value; }
        }

        public int NumFriendlyMinionsThatAttackedThisTurn
        {
            get { return this[GameTag.NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN]; }
            set { this[GameTag.NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN] = value; }
        }

        public int NumFriendlyMinionsThatDiedThisTurn
        {
            get { return this[GameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN]; }
            set { this[GameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN] = value; }
        }

        public int NumFriendlyMinionsThatDiedThisGame
        {
            get { return this[GameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME]; }
            set { this[GameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME] = value; }
        }

        public int NumMinionsPlayerKilledThisTurn
        {
            get { return this[GameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN]; }
            set { this[GameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN] = value; }
        }

        public int TotalManaSpentThisGame
        {
            get { return this[GameTag.NUM_RESOURCES_SPENT_THIS_GAME]; }
            set { this[GameTag.NUM_RESOURCES_SPENT_THIS_GAME] = value; }
        }

        public int HeroPowerActivationsThisTurn
        {
            get { return this[GameTag.HEROPOWER_ACTIVATIONS_THIS_TURN]; }
            set { this[GameTag.HEROPOWER_ACTIVATIONS_THIS_TURN] = value; }
        }

        public int NumTimesHeroPowerUsedThisGame
        {
            get { return this[GameTag.NUM_TIMES_HERO_POWER_USED_THIS_GAME]; }
            set { this[GameTag.NUM_TIMES_HERO_POWER_USED_THIS_GAME] = value; }
        }

        public int NumSecretsPlayedThisGame
        {
            get { return this[GameTag.NUM_SECRETS_PLAYED_THIS_GAME]; }
            set { this[GameTag.NUM_SECRETS_PLAYED_THIS_GAME] = value; }
        }

        public int NumSpellsPlayedThisGame
        {
            get { return this[GameTag.NUM_SPELLS_PLAYED_THIS_GAME]; }
            set { this[GameTag.NUM_SPELLS_PLAYED_THIS_GAME] = value; }
        }

        public int NumWeaponsPlayedThisGame
        {
            get { return this[GameTag.NUM_WEAPONS_PLAYED_THIS_GAME]; }
            set { this[GameTag.NUM_WEAPONS_PLAYED_THIS_GAME] = value; }
        }

        public int NumTurnsLeft
        {
            get { return this[GameTag.NUM_TURNS_LEFT]; }
            set { this[GameTag.NUM_TURNS_LEFT] = value; }
        }

        public int OverloadOwed
        {
            get { return this[GameTag.OVERLOAD_OWED]; }
            set { this[GameTag.OVERLOAD_OWED] = value; }
        }

        public int OverloadLocked
        {
            get { return this[GameTag.OVERLOAD_LOCKED]; }
            set { this[GameTag.OVERLOAD_LOCKED] = value; }
        }

        public int OverloadThisGame
        {
            get { return this[GameTag.OVERLOAD_THIS_GAME]; }
            set { this[GameTag.OVERLOAD_THIS_GAME] = value; }
        }

        public int LastCardPlayed
        {
            get { return this[GameTag.LAST_CARD_PLAYED]; }
            set { this[GameTag.LAST_CARD_PLAYED] = value; }
        }

        public int LastCardDrawn
        {
            get { return this[GameTag.LAST_CARD_DRAWN]; }
            set { this[GameTag.LAST_CARD_DRAWN] = value; }
        }

        public int LastCardDiscarded
        {
            get { return this[GameTag.LAST_CARD_DISCARDED]; }
            set { this[GameTag.LAST_CARD_DISCARDED] = value; }
        }

        public bool SeenCthun
        {
            get { return this[GameTag.SEEN_CTHUN] == 1; }
            set { this[GameTag.SEEN_CTHUN] = value ? 1 : 0; }
        }

        public int ProxyCthun
        {
            get { return this[GameTag.PROXY_CTHUN]; }
            set { this[GameTag.PROXY_CTHUN] = value; }
        }
    }
}