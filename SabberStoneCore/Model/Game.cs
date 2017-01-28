using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enchants;
using SabberStoneCore.Splits;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;

// TODO check this https://github.com/jleclanche/fireplace/wiki/How-to-enable-logging
// TODO implement http://hearthstone.gamepedia.com/Excess_Mana & tests
// TODO implement freeze water elemental & tests
// TODO test combo and choose one with battle cry check if that makes problem ...
// TODO verify http://hearthstone.gamepedia.com/Advanced_rulebook#Damage_and_Healing
// TODO implement clone split on random events ^^ bääm
// TODO removed duplicate check in lazyqueue ... check if we need a check ... to avoid multiple triggering
// TODO check for stealth implementation, until now only removed stealth when attacking ...
// TODO check for reseting entity allways when zone move ...
// TODO Discovery ... blah blah
// TODO remove event shit
// TODO choice has to use ... cards not playables .... moron
// TODO ... spellbender phase ??? and spell text ? wtf .. did you forget them???
namespace SabberStoneCore.Model
{
    public delegate void EntityChangedEventHandler(object sender, GameTag t, int oldValue, int newValue);

    public partial class Game : Entity
    {
        public int NextCloneIndex { get; set; } = 1;

        public static List<Game> FinalSplits { get; set; }

        public string CloneIndex { get; set; } = "[0]";

        public int MaxMinionsOnBoard => 7;

        public Controller Player1 => _players[0];

        public Controller Player2 => _players[1];

        private readonly Controller[] _players = new Controller[2];

        public event EntityChangedEventHandler EntityChangedEvent;

        public GameEventManager GamesEventManager { get; }

        public FormatType FormatType { get; }

        private readonly GameConfig _gameConfig;

        public bool Splitting => _gameConfig.Splitting;

        public TaskStack TaskStack { get; }

        public TaskQueue TaskQueue { get; }

        public Queue<ILazyRemove> LazyRemoves { get; set; } = new Queue<ILazyRemove>();

        public Queue<LogEntry> Logs { get; set; } = new Queue<LogEntry>();
        public void Log(LogLevel level, BlockType block, string location, string text)
        {
            if (!_gameConfig.Logging)
                return;

            Logs.Enqueue(new LogEntry()
            {
                TimeStamp = DateTime.Now,
                Level = level,
                Location = location,
                BlockType = block,
                Text = text
            });
        }

        private int _idIndex;
        public int NextId => _idIndex++;

        private int _oopIndex;
        public int NextOop => _oopIndex++;

        public void SetIndexer(int id, int oop)
        {
            _idIndex = id;
            _oopIndex = oop;
        }

        public Dictionary<int, IPlayable> IdEntityDic { get; private set; } = new Dictionary<int, IPlayable>();

        public Controller ControllerById(int controllerId)
        {
            return _players[controllerId - 1];
        }

        public List<Game> Splits { get; set; } = new List<Game>();

        public Game(GameConfig gameConfig, bool setupHeroes = true) : base(null, Card.CardGame, null, 0)
        {
            _gameConfig = gameConfig;
            Game = this;
            GamesEventManager = new GameEventManager(this);
            FormatType = gameConfig.GameRule;
            _players[0] = new Controller(this, gameConfig.Player1Name, 1);
            _players[1] = new Controller(this, gameConfig.Player2Name, 2);
            if (setupHeroes)
            {
                _players[0].AddHeroAndPower(Cards.HeroCard(gameConfig.Player1HeroClass));
                _players[1].AddHeroAndPower(Cards.HeroCard(gameConfig.Player2HeroClass));
            }
            TaskQueue = new TaskQueue(this);
            TaskStack = new TaskStack(this);
        }

        protected internal virtual void OnEntityChanged(Entity entity, GameTag t, int oldValue, int newValue)
        {
            EntityChangedEvent?.Invoke(entity, t, oldValue, newValue);
        }

        // Runs when STATE = RUNNING
        public void StartGame()
        {
            Log(LogLevel.INFO, BlockType.PLAY, "Game", "Starting new game now!");

            // set gamestats
            State = State.RUNNING;
            _players.ToList().ForEach(p => p.PlayState = PlayState.PLAYING);

            // getting first player
            FirstPlayer = _gameConfig.StartPlayer < 0
                ? _players[Util.Random.Next(0, 2)]
                : _players[_gameConfig.StartPlayer - 1];
            CurrentPlayer = FirstPlayer;

            Log(LogLevel.INFO, BlockType.PLAY, "Game", $"Starting Player is {CurrentPlayer.Name}.");

            _gameConfig.DeckPlayer1?.ForEach(p => Player1.Deck.Add(p));
            _gameConfig.DeckPlayer2?.ForEach(p => Player2.Deck.Add(p));
            if (_gameConfig.FillDecks)
            {
                Player1.Deck.Fill();
                Player2.Deck.Fill();
            }

            // TODO implement mulligan step Step.BEGIN_MULLIGAN

            // first turn
            Turn = 1;

            // set next step
            NextStep = Step.BEGIN_FIRST;
        }

        public void BeginFirst()
        {
            Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin First.");

            // set next step
            NextStep = Step.BEGIN_SHUFFLE;
        }

        public void BeginShuffle()
        {
            Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Shuffle.");

            if (_gameConfig.Shuffle)
            {
                Player1.Deck.Shuffle();
                Player2.Deck.Shuffle();
            }

            // set next step
            NextStep = Step.BEGIN_DRAW;
        }

        public void BeginDraw()
        {
            Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Draw.");

            _players.ToList().ForEach(p =>
            {

                Generic.Draw(p);
                Generic.Draw(p);
                Generic.Draw(p);

                if (p != FirstPlayer)
                {
                    // 4th card for second player
                    Generic.Draw(p);
                }

                p.NumTurnsLeft = 1;
            });

            NextStep = _gameConfig.SkipMulligan ? Step.MAIN_BEGIN : Step.BEGIN_MULLIGAN;
        }

        public void BeginMulligan()
        {
            Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Mulligan.");

            Generic.CreateChoice.Invoke(Player1, ChoiceType.MULLIGAN, ChoiceAction.HAND, Player1.Hand.Select(p => p.Card).ToList());
            Generic.CreateChoice.Invoke(Player2, ChoiceType.MULLIGAN, ChoiceAction.HAND, Player2.Hand.Select(p => p.Card).ToList());

            Player1.MulliganState = Mulligan.INPUT;
            Player2.MulliganState = Mulligan.INPUT;
        }

        public void MainBegin()
        {
            Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Main Begin.");

            // and a coin
            Generic.DrawCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"));

            NextStep = Step.MAIN_READY;
        }

        // Runs when STEP = MAIN_READY
        public void MainReady()
        {
            Characters.ForEach(p =>
            {
                p.NumTurnsInPlay++;
                p.NumAttacksThisTurn = 0;
            });

            Heroes.ForEach(p =>
            {
                p.Controller.NumCardsDrawnThisTurn = 0;
                p.Controller.NumCardsPlayedThisTurn = 0;
                p.Controller.NumMinionsPlayedThisTurn = 0;
                p.Controller.NumOptionsPlayedThisTurn = 0;
                p.Controller.NumFriendlyMinionsThatDiedThisTurn = 0;
            });

            CurrentPlayer.Hero.IsExhausted = false;
            CurrentPlayer.Hero.Power.IsExhausted = false;
            foreach (var e in CurrentPlayer.Board)
            {
                e.IsSummoned = false;
                e.IsExhausted = false;
            }

            // De-activate combo buff
            CurrentPlayer.IsComboActive = false;

            CurrentPlayer.NumMinionsPlayerKilledThisTurn = 0;
            CurrentOpponent.NumMinionsPlayerKilledThisTurn = 0;
            CurrentPlayer.NumFriendlyMinionsThatAttackedThisTurn = 0;
            NumMinionsKilledThisTurn = 0;
            CurrentPlayer.HeroPowerActivationsThisTurn = 0;

            // set next step
            NextStep = Step.MAIN_START_TRIGGERS;
        }

        // Runs when STEP = MAIN_START_TRIGGERS
        public void MainStartTriggers()
        {
            CurrentPlayer.TurnStart = true;

            // set next step
            NextStep = Step.MAIN_RESOURCE;
        }

        public void MainRessources()
        {
            // adding manacrystal to next player
            Generic.ChangeManaCrystal.Invoke(CurrentPlayer, 1, false);

            // clear used mana
            CurrentPlayer.UsedMana = 0;

            // remove temp mana
            CurrentPlayer.TemporaryMana = 0;

            // overload
            CurrentPlayer.OverloadLocked = CurrentPlayer.OverloadOwed;
            CurrentPlayer.OverloadOwed = 0;

            // set next step
            NextStep = Step.MAIN_DRAW;
        }

        public void MainDraw()
        {
            Generic.Draw(CurrentPlayer);

            // set next step
            NextStep = Step.MAIN_START;
        }

        // Runs when STEP = MAIN_START
        public void MainStart()
        {

            Log(LogLevel.INFO, BlockType.PLAY, "Game", $"[T:{Turn}/R:{(int)Turn / 2}] with CurrentPlayer {CurrentPlayer.Name} " +
                     $"[HP:{CurrentPlayer.Hero.Health}/M:{CurrentPlayer.RemainingMana}]");

            // set next step
            NextStep = Step.MAIN_CLEANUP;
        }

        // Runs when STEP = MAIN_END
        public void MainEnd()
        {
            Log(LogLevel.INFO, BlockType.PLAY, "Game", $"End turn proccessed by player {CurrentPlayer}");
            
            CurrentPlayer.TurnStart = false;

            // set next step
            NextStep = Step.MAIN_NEXT;
        }

        // Runs when STEP = MAIN_NEXT
        public void MainNext()
        {
            CurrentPlayer.NumTurnsLeft = 0;
            CurrentOpponent.NumTurnsLeft = 1;

            // After a player ends their turn (just before the next player's Start of
            // Turn Phase), un-Freeze all characters they control that are Frozen, 
            // don't have summoning sickness (or do have Charge) and have not attacked
            // that turn.
            CurrentPlayer.Board.GetAll.ForEach(p =>
            {
                var minion = p as Minion;
                if (minion != null && minion.IsFrozen && minion.NumAttacksThisTurn == 0 && (!minion.IsSummoned || minion.HasCharge))
                {
                    minion.IsFrozen = false;
                }
            });
            if (CurrentPlayer.Hero.IsFrozen && CurrentPlayer.Hero.NumAttacksThisTurn == 0)
            {
                CurrentPlayer.Hero.IsFrozen = false;
            }

            // set player for next turn ...
                CurrentPlayer = CurrentOpponent;

            // count next turn
            Turn++;

            Log(LogLevel.INFO, BlockType.PLAY, "Game", $"CurentPlayer {CurrentPlayer.Name}.");

            // set next step
            NextStep = Step.MAIN_READY;
        }

        public void MainCleanUp()
        {
            DeathProcessingAndAuraUpdate();

            // move forward if game isn't won by any player now!
            NextStep = _players.ToList().TrueForAll(p => p.PlayState == PlayState.PLAYING)
                ? Step.MAIN_ACTION
                : Step.FINAL_WRAPUP;
        }

        public void FinalWrapUp()
        {
            Heroes.ForEach(p =>
            {
                if (p.Controller.PlayState == PlayState.LOSING)
                {
                    p.Controller.PlayState = PlayState.LOST;
                    p.Controller.Opponent.PlayState = PlayState.WON;
                }
            });

            // set next step
            NextStep = Step.FINAL_GAMEOVER;
        }

        public void FinalGameOver()
        {
            State = State.COMPLETE;
            _players.ToList().ForEach(p =>
            {
                Log(LogLevel.INFO, BlockType.PLAY, "Game", $"{p.Name} has {p.PlayState} the Game!");
            });
        }

        public void GraveYard()
        {
            // remove dead weapons
            var heroesBadWeapons =
                Heroes.Where(p => p.Weapon != null && (p.Weapon.Durability == 0 || p.Weapon.ToBeDestroyed)).ToList();
            heroesBadWeapons.ForEach(p => p.RemoveWeapon());

            // check for dead minions to carry to the graveyard
            Minions.Where(p => p.IsDead).ToList().ForEach(p =>
            {
                Log(LogLevel.INFO, BlockType.PLAY, "Game", $"{p} is Dead! Graveyard say 'Hello'!");
                p.Zone.Remove(p);
                if (p.HasDeathrattle)
                {
                    p.ApplyEnchantments(EnchantmentActivation.DEATHRATTLE, SabberStoneCore.Enums.Zone.GRAVEYARD);
                }
                p.Controller.Graveyard.Add(p);
                CurrentPlayer.NumMinionsPlayerKilledThisTurn++;
            });

            // check for dead heroes
            var deadHeroes = Heroes.Where(p => p.IsDead).ToList();
            deadHeroes.ForEach(p => p.Controller.PlayState = deadHeroes.Count > 1 ? PlayState.TIED : PlayState.LOSING);
        }

        public void AuraUpdate()
        {
            Game.Enchants.ForEach(p => p.IsEnabled());
            Game.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentPlayer.Hero.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentPlayer.Hero.Triggers.ForEach(p => p.IsEnabled());

            //Game.CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
            //Game.CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentPlayer.Board.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentPlayer.Board.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentPlayer.Graveyard.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentPlayer.Graveyard.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentOpponent.Hero.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentOpponent.Hero.Triggers.ForEach(p => p.IsEnabled());

            //Game.CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
            //Game.CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentOpponent.Board.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentOpponent.Board.Triggers.ForEach(p => p.IsEnabled());

            Game.CurrentOpponent.Graveyard.Enchants.ForEach(p => p.IsEnabled());
            Game.CurrentOpponent.Graveyard.Triggers.ForEach(p => p.IsEnabled());

            Characters.ForEach(p1 => p1.Enchants.ForEach(p2 => p2.IsEnabled()));
            Characters.ForEach(p1 => p1.Triggers.ForEach(p2 => p2.IsEnabled()));

            LazyRemoves.ToList().ForEach(p => p.Remove());
            LazyRemoves.Clear();
        }

        public void DeathProcessingAndAuraUpdate()
        {
            GraveYard();

            AuraUpdate();

            while (TaskQueue.Count > 0)
            {
                if (TaskQueue.Process() != TaskState.COMPLETE)
                {
                    Log(LogLevel.INFO, BlockType.PLAY, "Game", "Something really bad happend during proccessing, please analyze!");
                }
                GraveYard();

                AuraUpdate();
            }
        }

        public void Process(PlayerTask gameTask)
        {
            // start with no splits ...
            Splits = new List<Game>();

            Log(LogLevel.INFO, BlockType.PLAY, "Game", gameTask.FullPrint());

            // make sure that we only use task for this game ...
            gameTask.Game = this;
            gameTask.Process();

            if (Splitting)
            {
                var finalSplits = SplitNode.GetSolutions(this, gameTask, 10, 10000);
                Log(LogLevel.INFO, BlockType.PLAY, "Split", $"found {finalSplits.Count} final splits!");
                finalSplits.GroupBy(p => p.SameState)
                    .Select(i => new {Word = i.Key, Count = i.Count()})
                    .ToList().ForEach(p => Log(LogLevel.INFO, BlockType.PLAY, "Split", $"{p.Word} - {p.Count}"));
            }
        }

        public override string Hash(params GameTag[] ignore)
        {
            var str = new StringBuilder();
            str.Append(base.Hash(ignore));
            str.Append(Player1.Hash(ignore));
            str.Append(Player2.Hash(ignore));
            return str.ToString();
        }

        public Game Clone()
        {
            var game = new Game(_gameConfig.Clone(), false) {CloneIndex = $"{this.CloneIndex}[{NextCloneIndex++}]"};
            game.Player1.Stamp(Player1);
            game.Player2.Stamp(Player2);
            game.Stamp(this);
            game.TaskQueue.Stamp(TaskQueue);
            game.TaskStack.Stamp(TaskStack);

            // set indexer to avoid conflicts ...
            game.SetIndexer(_idIndex, _oopIndex);

            return game;
        }

        public string FullPrint()
        {
            var str = new StringBuilder();
            str.AppendLine(Player1.Hand.FullPrint());
            str.AppendLine(Player1.Hero.FullPrint());
            str.AppendLine(Player1.Board.FullPrint());
            str.AppendLine(Player2.Board.FullPrint());
            str.AppendLine(Player2.Hero.FullPrint());
            str.AppendLine(Player2.Hand.FullPrint());
            return str.ToString();
        }
    }

    public partial class Game
    {
        public int Turn
        {
            get { return this[GameTag.TURN]; }
            set { this[GameTag.TURN] = value; }
        }

        public State State
        {
            get { return (State) this[GameTag.STATE]; }
            set { this[GameTag.STATE] = (int) value; }
        }

        public int FirstCardPlayedThisTurn
        {
            get { return this[GameTag.FIRST_CARD_PLAYED_THIS_TURN]; }
            set { this[GameTag.FIRST_CARD_PLAYED_THIS_TURN] = value; }
        }

        public Controller FirstPlayer
        {
            get
            {
                return Player1[GameTag.FIRST_PLAYER] == 1 ? Player1 : Player2[GameTag.FIRST_PLAYER] == 1 ? Player2 : null;
            }
            set { value[GameTag.FIRST_PLAYER] = 1; }
        }

        public Controller CurrentPlayer
        {
            get
            {
                return Player1[GameTag.CURRENT_PLAYER] == 1
                    ? Player1
                    : Player2[GameTag.CURRENT_PLAYER] == 1 ? Player2 : null;
            }
            set
            {
                value.Opponent[GameTag.CURRENT_PLAYER] = 0;
                value[GameTag.CURRENT_PLAYER] = 1;
            }
        }

        public Controller CurrentOpponent
            => Player1[GameTag.CURRENT_PLAYER] == 1 ? Player2 : Player2[GameTag.CURRENT_PLAYER] == 1 ? Player1 : null;

        public Step Step
        {
            get { return (Step) this[GameTag.STEP]; }
            set { this[GameTag.STEP] = (int) value; }
        }

        public Step NextStep
        {
            get { return (Step) this[GameTag.NEXT_STEP]; }
            set { this[GameTag.NEXT_STEP] = (int) value; }
        }

        public int NumMinionsKilledThisTurn
        {
            get { return this[GameTag.NUM_MINIONS_KILLED_THIS_TURN]; }
            set { this[GameTag.NUM_MINIONS_KILLED_THIS_TURN] = value; }
        }

        public List<Hero> Heroes => new List<Hero> {Game.Player1.Hero, Game.Player2.Hero};

        public List<Minion> Minions
        {
            get
            {
                var list = new List<Minion>();
                list.AddRange(Game.Player1.Board);
                list.AddRange(Game.Player2.Board);
                return list;
            }
        }

        public List<ICharacter> Characters
        {
            get
            {
                var list = new List<ICharacter>();
                list.AddRange(Minions);
                list.AddRange(Heroes);
                return list;
            }
        }
    }
}