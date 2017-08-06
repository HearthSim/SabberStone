using SabberStoneCore.Actions;
using SabberStoneCore.Collections;
using SabberStoneCore.Config;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Splits;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// TODO check if event should be removed
// TODO ... spellbender phase ??? and spell text ? wtf .. did you forget them???
// TODO [DS1_188] Gladiator's Longbow, check should be on IMMUNE_WHILE_ATTACKING
// TODO cleanup the Enchant class
// TODO refactor and cleanup SelfCondition & RelaCondition class
// TODO; check documentation regarding splitting.
namespace SabberStoneCore.Model
{
	/// <summary>
	/// Signature used for passing tag update information around.
	/// </summary>
	/// <param name="sender">The sender, which is probably an entity.</param>
	/// <param name="t">The gametag which changed.</param>
	/// <param name="oldValue">The old value.</param>
	/// <param name="newValue">The new value.</param>
	public delegate void EntityChangedEventHandler(object sender, EGameTag t, int oldValue, int newValue);

	/// <summary>
	/// The state machine which processes the given input and generates results which can be interpreted 
	/// to create a new set of inputs.
	/// 
	/// This is THE MOST IMPORTANT type, since it provides a simple interface for handling/processing 
	/// game data.
	/// </summary>
	/// <seealso cref="SabberStoneCore.Model.Entity" />
	public sealed class Game : Entity
	{

		/// <summary>The entityID of the game itself is always 1.</summary>
		internal const int GAME_ENTITYID = 1;

		#region TAG_SHORTCUTS

		/// <summary>Gets or sets the turn count.</summary>
		/// <value>The amount of player turns that happened in the game. When the game starts (after Mulligan),
		/// value will equal 1.</value>
		public int Turn
		{
			get { return this[EGameTag.TURN]; }
			set { this[EGameTag.TURN] = value; }
		}

		/// <summary>Gets or sets the game state.</summary>
		/// <value><see cref="EState"/></value>
		public EState State
		{
			get { return (EState)this[EGameTag.STATE]; }
			set { this[EGameTag.STATE] = (int)value; }
		}

		/// <summary>Gets or sets the [TODO] ??entityID?? of the first card played this turn.</summary>
		/// <value>The entityID of the card.</value>
		public int FirstCardPlayedThisTurn
		{
			get { return this[EGameTag.FIRST_CARD_PLAYED_THIS_TURN]; }
			set { this[EGameTag.FIRST_CARD_PLAYED_THIS_TURN] = value; }
		}

		/// <summary>The controller which goes 'first'. This player's turn starts after Mulligan.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller FirstPlayer
		{
			get
			{
				return Player1[EGameTag.FIRST_PLAYER] == 1 ? Player1 : Player2[EGameTag.FIRST_PLAYER] == 1 ? Player2 : null;
			}
			set
			{
				value[EGameTag.FIRST_PLAYER] = 1;
			}
		}

		/// <summary>Gets or sets the controller delegating the current turn.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentPlayer
		{
			get
			{
				return Player1[EGameTag.CURRENT_PLAYER] == 1
					? Player1
					: Player2[EGameTag.CURRENT_PLAYER] == 1 ? Player2 : null;
			}
			set
			{
				value.Opponent[EGameTag.CURRENT_PLAYER] = 0;
				value[EGameTag.CURRENT_PLAYER] = 1;
			}
		}

		/// <summary>Gets the opponent controller of <see cref="CurrentPlayer"/>.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentOpponent
			=> Player1[EGameTag.CURRENT_PLAYER] == 1 ? Player2 : Player2[EGameTag.CURRENT_PLAYER] == 1 ? Player1 : null;

		/// <summary>Gets or sets the CURRENT step. These steps occur within <see cref="EState.RUNNING"/> and
		/// indicate states which are used to process actions.
		/// </summary>
		/// <value><see cref="EStep"/></value>
		public EStep Step
		{
			get { return (EStep)this[EGameTag.STEP]; }
			set { this[EGameTag.STEP] = (int)value; }
		}

		/// <summary>Gets or sets the NEXT step. <seealso cref="Step"/></summary>
		/// <value><see cref="EStep"/></value>
		public EStep NextStep
		{
			get { return (EStep)this[EGameTag.NEXT_STEP]; }
			set { this[EGameTag.NEXT_STEP] = (int)value; }
		}

		/// <summary>Gets or sets the number of killed minions for this turn.</summary>
		/// <value>The amount of killed minions.</value>
		public int NumMinionsKilledThisTurn
		{
			get { return this[EGameTag.NUM_MINIONS_KILLED_THIS_TURN]; }
			set { this[EGameTag.NUM_MINIONS_KILLED_THIS_TURN] = value; }
		}

		#endregion

		#region PROPERTIES

		/// <summary>Gets a value indicating whether this <see cref="Game"/> is intended to split.
		/// When TRUE, the game WILL SPLIT ITSELF when <see cref="Splits"/> contains games derived
		/// from this one with different random outcomes.
		/// 
		/// </summary>
		/// <value><c>true</c> if splitting is intended; otherwise, <c>false</c>.</value>
		public bool Splitting => _gameConfig.Splitting;

		/// <summary>Gets or sets the index value for identifying the N-th clone of a game. (0-indexed)</summary>
		/// <value>The index of the clone.</value>
		public int CloneIndex { get; set; } = 0;

		/// <summary>Gets or sets the index of the next clone.<seealso cref="CloneIndex"/></summary>
		/// <value>The index of the next clone.</value>
		public int NextCloneIndex { get; set; } = 1;

		/// <summary>Gets or sets the list of splitted (and fully resolved) games, derived from this game.
		/// The values hold the derived game instances and split meta information.
		/// </summary>
		/// <value><see cref="SplitNode"/></value>
		public List<SplitNode> FinalSplits { get; set; }

		/// <summary>Gets or sets the list of splitted, but unresolved, game instances.
		/// These instances are derived from the current game instance but their TaskQueue
		/// still needs to process.
		/// </summary>
		/// <value><see cref="Game"/></value>
		public List<Game> Splits { get; set; } = new List<Game>();


		/// <summary>Occurs when a TAG on an entity, which is hooked onto this game, changes.</summary>
		public event EntityChangedEventHandler EntityChangedEvent;
		/// <summary>Gets the game event manager. This object delegates the state machine of
		/// the game.</summary>
		/// <value>The game event manager.</value>
		public GameStepManager GamesEventManager { get; }


		/// <summary>Holds all the controllers (== players) which are attached to this game.</summary>
		private readonly Controller[] _players = new Controller[2];

		/// <summary>Player with the first turn, alias Player 1.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller Player1 => _players.FirstOrDefault(p => p.PlayerId == 1);
		/// <summary>Player starting at the second turn, alias Player 2.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller Player2 => _players.FirstOrDefault(p => p.PlayerId == 2);

		/// <summary>The game configuration, which was provided on setup</summary>
		private readonly IReadOnlyGameConfig _gameConfig;

		/// <summary>Gets the maximum amount of minions allowed inside the PLAY <see cref="IZone"/>.</summary>
		/// <value>The maximum amount of minions.</value>
		public int MaxMinionsOnBoard => _gameConfig.MaxMinionsOnBoard;

		/// <summary>Gets the format type of this game.</summary>
		/// <value><see cref="EFormatType"/></value>
		public EFormatType FormatType => _gameConfig.FormatType;


		/// <summary>Gets or sets the power history container. 
		/// This object facilitates building POWER blocks to send to the hearthstone client.
		/// </summary>
		/// <value><see cref="Kettle.PowerHistory"/></value>
		public PowerHistory PowerHistory { get; set; } = new PowerHistory();

		/// <summary>Gets a value indicating whether this <see cref="Game"/> has Power History 
		/// building enabled.
		/// </summary>
		/// <value><c>true</c> if history building is enabled; otherwise, <c>false</c>.</value>
		public bool HistoryEnabled => _gameConfig.History;

		/// <summary>Gets the task stack, which holds arguments to fill in parameters of the 
		/// currently executing task (<see cref="TaskQueue.CurrentTask"/>).</summary>
		/// <value><see cref="Model.TaskStack"/></value>
		public TaskStack TaskStack { get; }

		/// <summary>Gets the task queue, which holds the currently executing task AND all tasks
		/// which need to be executed in the future. The future tasks are generated as side-effect of
		/// running the currently executing task.
		/// </summary>
		/// <value><see cref="Model.TaskQueue"/></value>
		public TaskQueue TaskQueue { get; }

		/// <summary>Gets or sets the list of enchantments or triggers which need to be removed (lazily) 
		/// from this game.
		/// </summary>
		/// <value><see cref="ILazyRemove"/></value>
		public Queue<ILazyRemove> LazyRemoves { get; set; } = new Queue<ILazyRemove>();

		/// <summary>Gets the dictionary containing all generated entities for this game.</summary>
		/// <value><see cref="IPlayable"/></value>
		public Dictionary<int, IPlayable> Entities { get; private set; } = new Dictionary<int, IPlayable>();

		/// <summary>Gets the dictionary containing all generated choice sets for this game.</summary>
		/// <value><see cref="PowerEntityChoices"/></value>
		public Dictionary<int, PowerEntityChoices> EntityChoicesMap { get; } = new Dictionary<int, PowerEntityChoices>();

		/// <summary>Gets all the dictionary containing all generated option sets for this game.</summary>
		/// <value><see cref="PowerAllOptions"/></value>
		public Dictionary<int, PowerAllOptions> AllOptionsMap { get; } = new Dictionary<int, PowerAllOptions>();

		/// <summary>Gets the next available entity identifier.</summary>
		/// <value>The entity identifier.</value>
		public int NextEntityID => ++_entityIDIdx;
		// Start at the GAME entityID, since that's always the first entity to be created each game.
		private int _entityIDIdx = GAME_ENTITYID;

		/// <summary>Gets the next order of play index.
		/// The order of play value is used for ordering entities before processing their enchantments
		/// or triggers.
		/// </summary>
		/// <value>The index of the next order of play.</value>
		public int NextOrderOfPlayIdx => ++_oopIndex;
		private int _oopIndex = 0;

		/// <summary>Gets the hero objects representing the controllers.</summary>
		/// <value><see cref="Hero"/></value>
		public IReadOnlyList<Hero> Heroes => new List<Hero> { Game.Player1.Hero, Game.Player2.Hero };

		/// <summary>Gets all minion objects residing in the PLAY <see cref="IZone"/>, in other words 
		/// 'on the board'.
		/// </summary>
		/// <value><see cref="Minion"/></value>
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

		/// <summary>Gets the all characters attached to this game.
		/// This enumeration contains all heroes and minions.
		/// </summary>
		/// <value><see cref="ICharacter"/></value>
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

		/// <summary>Gets the collection of log entries.</summary>
		/// <value><see cref="LogEntry"/></value>
		public Queue<LogEntry> Logs { get; } = new Queue<LogEntry>();

		#endregion

		/// <summary>Initializes a new instance of the <see cref="Game"/> class.</summary>
		/// <param name="gameConfig">The game configuration.</param>
		/// <autogeneratedoc />
		public Game(IReadOnlyGameConfig gameConfig)
			: base(null, Card.CardGame, new Dictionary<EGameTag, int>
			{
				[EGameTag.ENTITY_ID] = GAME_ENTITYID,
				[EGameTag.ZONE] = (int)EZone.PLAY,
				[EGameTag.CARDTYPE] = (int)ECardType.GAME
			})
		{
			_gameConfig = gameConfig ?? throw new ArgumentNullException("gameConfig was null!");
			ValidateConfig();

			Game = this;
			GamesEventManager = new GameStepManager(this);

			_players[0] = new Controller(this, gameConfig.Player1Name, 1, NextEntityID);
			_players[1] = new Controller(this, gameConfig.Player2Name, 2, NextEntityID);

			TaskQueue = new TaskQueue(this);
			TaskStack = new TaskStack(this);

			// add power history create game
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.CreateGame(this, _players));

			if (_gameConfig.SetupHeroes)
			{
				_players[0].AddHeroAndPower(Cards.DefaultHeroCard(gameConfig.Player1CardClass));
				_players[1].AddHeroAndPower(Cards.DefaultHeroCard(gameConfig.Player2CardClass));
			}
		}

		/// <summary>Validates the game configuration.
		/// An exception will be thrown when the game configuration is invalid!
		/// </summary>
		private void ValidateConfig()
		{
			if (_gameConfig.Player2CardClass == ECardClass.INVALID || _gameConfig.Player1CardClass == ECardClass.INVALID)
			{
				throw new GameConfigException("The cardclass properties MUST be provided!");
			}

			if (_gameConfig.FormatType == EFormatType.FT_UNKNOWN)
			{
				throw new GameConfigException("The formattype propertie MUST be provided!");
			}

			// If no exception was thrown, the Game configuration is invariantly valid.
		}

		/// <summary>Method which is called when an entity wants to notify that one of it's tags changed value.</summary>
		/// <param name="entity">The entity which has changed.</param>
		/// <param name="t">The game tag which value changed.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		internal void OnEntityChanged(Entity entity, EGameTag t, int oldValue, int newValue)
		{
			EntityChangedEvent?.Invoke(entity, t, oldValue, newValue);
		}

		/// <summary>Get the controller for the provided player index.</summary>
		/// <param name="playerIdx">Index of the player.</param>
		public Controller ControllerByPlayerIdx(int playerIdx)
		{
			return _players.FirstOrDefault(p => p.PlayerId == playerIdx);
		}

		/// <summary>Gets the controller for the provided entityID.</summary>
		/// <param name="entityID">The entityID.</param>
		/// <returns></returns>
		public Controller ControllerByEntityID(int entityID)
		{
			return _players.FirstOrDefault(p => p.Id == entityID);
		}

		/// <summary>Process the specified task.
		/// The game will execute the desired task and all effects coupled either
		/// directly or indirectly in synchronous manner.
		/// 
		/// Call <see cref="Controller.Options(bool)"/> on the <see cref="CurrentPlayer"/> 
		/// instance for tasks which are accepted as arguments.
		/// After this method returns, check <see cref="Controller.Options(bool)"/>
		/// again until only <see cref="EndTurnTask"/> remains, which will
		/// start the turn of <see cref="CurrentOpponent"/>. 
		/// </summary>
		/// <param name="gameTask">The game task to execute.</param>
		public void Process(PlayerTask gameTask)
		{
			// start with no splits ...
			Splits = new List<Game>();

			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", gameTask.FullPrint());

			// clear last power history
			PowerHistory.Last.Clear();

			// make sure that we only use task for this game ...
			gameTask.Game = this;
			gameTask.Process();

			// add enchantment and buff tag changes
			if (HistoryEnabled)
			{
				Enchants.ForEach(p =>
					p.Effects.Keys.ToList().ForEach(t =>
						Entities.Values.ToList().ForEach(o =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t])))));

				foreach (var controller in _players)
				{
					controller.Hero.Enchants.ForEach(p =>
						p.Effects.Keys.ToList().ForEach(t =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(Game.CurrentPlayer.Hero.Id, t, Game.CurrentPlayer.Hero[t]))));

					//CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
					//CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());
					//CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
					//CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

					foreach (IZone z in controller.Zones.Where(z => z != null)) {
						z.Enchants.ForEach(p =>
							p.Effects.Keys.ToList().ForEach(t =>
								z.GetAll.ForEach(o =>
									PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t])))));
					}

				}

				Characters.ForEach(c =>
					c.Enchants.ForEach(p =>
						p.Effects.Keys.ToList().ForEach(t =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(c.Id, t, c[t])))));
			}

			if (Splitting)
			{
				var finalSplits = SplitNode.GetSolutions(this, 10, 10000);
				Dump("Split", $"found {finalSplits.Count} final splits of {finalSplits.Sum(p => p.SameState + 1)}!");
				finalSplits.GroupBy(p => p.SameState)
					.Select(i => new { Word = i.Key, Count = i.Count() })
					.ToList().ForEach(p => Dump("Split", $" {p.Count},  with {p.Word} same states"));
				FinalSplits = finalSplits;
			}
		}

		#region STATE_MACHINE

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING.
		/// </summary>
		public void StartGame()
		{
			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", "Starting new game now!");

			// setting up the decks ...
			_gameConfig.Player1Deck?.ForEach(p => Entity.FromCard(Player1, p, null, Player1.Deck));
			_gameConfig.Player2Deck?.ForEach(p => Entity.FromCard(Player2, p, null, Player2.Deck));
			if (_gameConfig.FillDecks)
			{
				Player1.Deck.Fill();
				Player2.Deck.Fill();
			}

			// set gamestats
			State = EState.RUNNING;
			_players.ToList().ForEach(p => p.PlayState = EPlayState.PLAYING);

			// starting mulligan draw block
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, this.Id, "", -1, 0));

			// getting first player
			FirstPlayer = _gameConfig.StartPlayerIdx < 0
				? _players[Util.Random.Next(0, 2)]
				: _players[_gameConfig.StartPlayerIdx - 1];
			CurrentPlayer = FirstPlayer;

			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"Starting Player is {CurrentPlayer.Name}.");

			// first turn
			Turn = 1;

			// set next step
			NextStep = EStep.BEGIN_FIRST;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_FIRST
		/// </summary>
		public void BeginFirst()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin First.");

			// set next step
			NextStep = EStep.BEGIN_SHUFFLE;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_SHUFFLE
		/// </summary>
		public void BeginShuffle()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin Shuffle.");

			if (_gameConfig.Shuffle)
			{
				Player1.Deck.Shuffle();
				Player2.Deck.Shuffle();
			}

			// set next step
			NextStep = EStep.BEGIN_DRAW;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_DRAW
		/// </summary>
		public void BeginDraw()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin Draw.");

			//FirstPlayer.NumCardsToDraw = 3;
			//FirstPlayer.Opponent.NumCardsToDraw = 4;

			_players.ToList().ForEach(p =>
			{
				Generic.Draw(p);
				Generic.Draw(p);
				Generic.Draw(p);

				if (p != FirstPlayer)
				{
					// 4th card for second player
					Generic.Draw(p);

					var coin = FromCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"), new Dictionary<EGameTag, int>()
					{
						[EGameTag.ZONE] = (int)Enums.EZone.HAND,
						[EGameTag.CARDTYPE] = (int)ECardType.SPELL,
						[EGameTag.CREATOR] = FirstPlayer.Opponent.PlayerId
					});
					Generic.AddHandPhase(FirstPlayer.Opponent, coin);
				}

				p.NumTurnsLeft = 1;
			});

			Player1.TimeOut = 75;
			Player2.TimeOut = 75;

			// ending mulligan draw block
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			NextStep = _gameConfig.SkipMulligan ? EStep.MAIN_BEGIN : EStep.BEGIN_MULLIGAN;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_MULLIGAN
		/// </summary>
		public void BeginMulligan()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin Mulligan.");

			// starting mulligan draw block
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, this.Id, "", -1, 0));

			Player1.MulliganState = EMulligan.INPUT;
			Player2.MulliganState = EMulligan.INPUT;

			Generic.CreateChoice.Invoke(Player1, this, EChoiceType.MULLIGAN, EChoiceAction.HAND, LightWeightOrderedSet<int>.Build(Player1.Hand.Select(p => p.Id)));
			Generic.CreateChoice.Invoke(Player2, this, EChoiceType.MULLIGAN, EChoiceAction.HAND, LightWeightOrderedSet<int>.Build(Player2.Hand.Select(p => p.Id)));

			// ending mulligan draw block
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_BEGIN
		/// </summary>
		public void MainBegin()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Main Begin.");

			// and a coin
			//Generic.DrawCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"));

			NextStep = EStep.MAIN_READY;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_READY
		/// </summary>
		public void MainReady()
		{
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, CurrentPlayer.Id, "", 1, 0));

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

			CurrentPlayer.NumElementalsPlayedLastTurn = CurrentPlayer.NumElementalsPlayedThisTurn;
			CurrentPlayer.NumElementalsPlayedThisTurn = 0;

			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_START_TRIGGERS;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_RESOURCE
		/// </summary>
		public void MainResources()
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
			NextStep = EStep.MAIN_DRAW;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_DRAW
		/// </summary>
		public void MainDraw()
		{
			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, CurrentPlayer.Id, "", 0, 0)); // turn start effect

			//CurrentPlayer.NumCardsToDraw = 1;
			Generic.Draw(CurrentPlayer);

			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_START;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_START
		/// </summary>
		public void MainStart()
		{
			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"[T:{Turn}/R:{(int)Turn / 2}] with CurrentPlayer {CurrentPlayer.Name} " +
					 $"[HP:{CurrentPlayer.Hero.Health}/M:{CurrentPlayer.RemainingMana}]");


			DeathProcessingAndAuraUpdate();

			// move forward if game isn't won by any player now!
			NextStep = _players.ToList().TrueForAll(p => p.PlayState == EPlayState.PLAYING)
				? EStep.MAIN_ACTION
				: EStep.FINAL_WRAPUP;

			// set next step
			//NextStep = Step.MAIN_CLEANUP;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_START_TRIGGERS
		/// </summary>
		public void MainStartTriggers()
		{
			CurrentPlayer.TurnStart = true;
			DeathProcessingAndAuraUpdate();

			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, CurrentPlayer.Id, "", 8, 0));

			if (HistoryEnabled)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_RESOURCE;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_CLEANUP
		/// </summary>
		public void MainCleanUp()
		{
			if (HistoryEnabled)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, CurrentPlayer.Id, "", 5, 0);

			DeathProcessingAndAuraUpdate();

			if (HistoryEnabled)
				PowerHistoryBuilder.BlockEnd();

			// move forward if game isn't won by any player now!
			NextStep = _players.ToList().TrueForAll(p => p.PlayState == EPlayState.PLAYING)
				? EStep.MAIN_ACTION
				: EStep.FINAL_WRAPUP;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_END
		/// </summary>
		public void MainEnd()
		{
			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"End turn proccessed by player {CurrentPlayer}");

			if (HistoryEnabled)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, CurrentPlayer.Id, "", 4, 0);

			CurrentPlayer.TurnStart = false;
			DeathProcessingAndAuraUpdate();

			if (HistoryEnabled)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.MAIN_NEXT;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_NEXT
		/// </summary>
		public void MainNext()
		{
			if (HistoryEnabled)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, this.Id, "", -1, 0);

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

			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"CurentPlayer {CurrentPlayer.Name}.");

			if (HistoryEnabled)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.MAIN_READY;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = FINAL_WRAPUP
		/// </summary>
		public void FinalWrapUp()
		{
			if (HistoryEnabled)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, Id, "", -1, 0);

			Heroes.ForEach(p =>
			{
				if (p.Controller.PlayState == EPlayState.LOSING || p.Controller.PlayState == EPlayState.CONCEDED)
				{
					p.Controller.PlayState = EPlayState.LOST;
					p.Controller.Opponent.PlayState = EPlayState.WON;
				}
			});

			if (HistoryEnabled)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.FINAL_GAMEOVER;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = FINAL_GAMEOVER
		/// </summary>
		public void FinalGameOver()
		{
			State = EState.COMPLETE;
			_players.ToList().ForEach(p =>
			{
				Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"{p.Name} has {p.PlayState} the Game!");
			});
		}

		#endregion

		/// <summary>Checks for entities which are pending to be destroyed and updates
		/// active auras accordingly.
		/// </summary>
		public void DeathProcessingAndAuraUpdate()
		{
			GraveYard();

			AuraUpdate();

			while (TaskQueue.Count > 0)
			{
				if (TaskQueue.Process() != ETaskState.COMPLETE)
				{
					Log(ELogLevel.INFO, EBlockType.PLAY, "Game", "Something really bad happend during proccessing, please analyze!");
				}
				GraveYard();

				AuraUpdate();
			}
		}

		/// <summary>Move destroyed entities from <see cref="EZone.PLAY"/> <see cref="Zone{T}"/> into 
		/// <see cref="EZone.GRAVEYARD"/>
		/// </summary>
		public void GraveYard()
		{
			// remove dead weapons
			var heroesBadWeapons =
				Heroes.Where(p => p.Weapon != null && (p.Weapon.Durability == 0 || p.Weapon.ToBeDestroyed)).ToList();
			heroesBadWeapons.ForEach(p => p.RemoveWeapon());

			// check for dead minions to carry to the graveyard
			Minions.Where(p => p.IsDead).ToList().ForEach(p =>
			{
				Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"{p} is Dead! Graveyard say 'Hello'!");
				p.Zone.Remove(p);
				if (p.HasDeathrattle)
				{
					p.ApplyEnchantments(EEnchantmentActivation.DEATHRATTLE, EZone.GRAVEYARD);
				}
				if (HistoryEnabled)
					PowerHistoryBuilder.BlockStart(EBlockType.DEATHS, 1, "", 0, 0);
				p.IsExhausted = false;
				p.Controller.Graveyard.Add(p);
				p.Controller.NumFriendlyMinionsThatDiedThisTurn++;
				CurrentPlayer.NumMinionsPlayerKilledThisTurn++;
				NumMinionsKilledThisTurn++;
				p.Damage = 0;
				if (HistoryEnabled)
					PowerHistoryBuilder.BlockEnd();
			});

			// check for dead heroes
			var deadHeroes = Heroes.Where(p => p.IsDead).ToList();
			deadHeroes.ForEach(p => p.Controller.PlayState = (deadHeroes.Count > 1 ? EPlayState.TIED : EPlayState.LOSING) );
		}

		/// <summary>Update the auras on each zone (which can be influenced by entities from the 
		/// <see cref="EZone.PLAY"/> zone.
		/// </summary>
		public void AuraUpdate()
		{
			Enchants.ForEach(p => p.IsEnabled());
			Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.Hero.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.Hero.Triggers.ForEach(p => p.IsEnabled());

			//CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.Board.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.Board.Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.Graveyard.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.Graveyard.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.Hero.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.Hero.Triggers.ForEach(p => p.IsEnabled());

			//CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.Board.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.Board.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.Graveyard.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.Graveyard.Triggers.ForEach(p => p.IsEnabled());

			Characters.ForEach(p1 => p1.Enchants.ForEach(p2 => p2.IsEnabled()));
			Characters.ForEach(p1 => p1.Triggers.ForEach(p2 => p2.IsEnabled()));

			LazyRemoves.ToList().ForEach(p => p.Remove());
			LazyRemoves.Clear();
		}

		/// <summary>Builds and stores a logentry, from the specified log message.</summary>
		/// <param name="level"><see cref="ELogLevel"/></param>
		/// <param name="block"><see cref="EBlockType"/></param>
		/// <param name="location">Rough string respresentation of where in the code the message came from.</param>
		/// <param name="text">The message itself.</param>
		internal void Log(ELogLevel level, EBlockType block, string location, string text)
		{
			if (!_gameConfig.Logging)
				return;

			Logs.Enqueue(new LogEntry()
			{
				Level = level,
				Location = location,
				BlockType = block,
				Text = text
			});
		}

		/// <summary>Performs a deep copy of this game instance and returns the result.</summary>
		/// <returns></returns>
		public Game Clone()
		{
			// Copy game configuration.
			var gameConfig = GameConfig.Stamp(_gameConfig);
			gameConfig.Logging = false;

			// Deep copy game instance.
			var other = new Game(gameConfig)
			{
				CloneIndex = NextCloneIndex++
			};
			other.Player1.Stamp(Player1);
			other.Player2.Stamp(Player2);
			other.Stamp(this);

			other.TaskStack.Stamp(TaskStack);
			other.TaskQueue.Stamp(TaskQueue);

			// Set indexes to keep constraints valid.
			other._entityIDIdx = _entityIDIdx;
			other._oopIndex = _oopIndex;

			return other;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public void Dump(string location, string text)
		{
			Logs.Enqueue(new LogEntry()
			{
				Level = ELogLevel.DUMP,
				Location = location,
				BlockType = EBlockType.SCRIPT,
				Text = text
			});
		}

		public override string Hash(params EGameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append(base.Hash(ignore));
			str.Append(Player1.Hash(ignore));
			str.Append(Player2.Hash(ignore));
			return str.ToString();
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

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}