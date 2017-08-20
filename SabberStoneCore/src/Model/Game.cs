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
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

// TODO check if event should be removed
// TODO ... spellbender phase ??? and spell text ? wtf .. did you forget them???
// TODO [DS1_188] Gladiator's Longbow, check should be on IMMUNE_WHILE_ATTACKING
// TODO cleanup the Enchant class
// TODO refactor and cleanup SelfCondition & RelaCondition class
namespace SabberStoneCore.Model
{
	/// <summary>
	/// Signature used for passing tag update information around.
	/// </summary>
	/// <param name="sender">The sender, which is probably an entity.</param>
	/// <param name="t">The gametag which changed.</param>
	/// <param name="oldValue">The old value.</param>
	/// <param name="newValue">The new value.</param>
	public delegate void EntityChangedEventHandler(object sender, GameTag t, int oldValue, int newValue);

	/// <summary>
	/// The state machine which processes the given input and generates results which can be interpreted 
	/// to create a new set of inputs.
	/// 
	/// This is THE MOST IMPORTANT type, since it provides a simple interface for handling/processing 
	/// game data.
	/// </summary>
	/// <seealso cref="SabberStoneCore.Model.Entity" />
	public partial class Game : Entity
	{
		/// <summary>
		/// The entityID of the game itself is always 1.
		/// </summary>
		internal const int GAME_ENTITYID = 1;

		/// <summary>
		/// The maximum minions that are allowed on the board.
		/// </summary>
		public const int MAX_MINIONS_ON_BOARD = 7;

		/// <summary>
		/// Gets or sets the index value for identifying the N-th clone of a game. (0-indexed)
		/// </summary>
		/// <value>The index of the clone.</value>
		public string CloneIndex { get; set; } = "[0]";

		/// <summary>
		/// Gets or sets the index of the next clone.<seealso cref="CloneIndex"/>
		/// </summary>
		/// <value>The index of the next clone.</value>
		public int NextCloneIndex { get; set; } = 1;

		/// <summary>
		/// Gets or sets the list of splitted (and fully resolved) games, derived from this game.
		/// The values hold the derived game instances and split meta information.
		/// </summary>
		/// <value><see cref="SplitNode"/></value>
		public List<SplitNode> FinalSplits { get; set; }

		/// <summary>
		/// Gets or sets the list of splitted, but unresolved, game instances.
		/// These instances are derived from the current game instance but their TaskQueue
		/// still needs to process.
		/// </summary>
		/// <value><see cref="Game"/></value>
		public List<Game> Splits { get; set; } = new List<Game>();

		/// <summary>
		/// Occurs when a TAG on an entity, which is hooked onto this game, changes.
		/// </summary>
		public event EntityChangedEventHandler EntityChangedEvent;

		public event EventHandler<bool> RandomHappenedEvent;

		/// <summary>
		/// Gets the game event manager. This object delegates the state machine of
		/// the game.
		/// </summary>
		/// <value>The game event manager.</value>
		public GameEventManager GamesEventManager { get; }

		/// <summary>
		/// Holds all the controllers (== players) which are attached to this game.
		/// </summary>
		private readonly Controller[] _players = new Controller[2];

		/// <summary>
		/// Player with the first turn, alias Player 1.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller Player1
		{
			get => _players[0];
			protected set => _players[0] = value;
		}

		/// <summary>
		/// Player starting at the second turn, alias Player 2.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller Player2
		{
			get => _players[1];
			protected set => _players[1] = value;
		}

		private readonly GameConfig _gameConfig;

		/// <summary>
		/// Gets the format type of this game.
		/// </summary>
		/// <value><see cref="FormatType"/></value>
		public FormatType FormatType => _gameConfig.FormatType;

		/// <summary>Gets a value indicating whether this <see cref="Game"/> is intended to split.
		/// When TRUE, the game WILL SPLIT ITSELF when <see cref="Splits"/> contains games derived
		/// from this one with different random outcomes.
		/// </summary>
		/// <value><c>true</c> if splitting is intended; otherwise, <c>false</c>.</value>
		public bool Splitting => _gameConfig.Splitting;

		/// <summary>Gets or sets the power history container. 
		/// This object facilitates building POWER blocks to send to the hearthstone client.
		/// </summary>
		/// <value><see cref="Kettle.PowerHistory"/></value>
		public PowerHistory PowerHistory { get; set; } = new PowerHistory();

		/// <summary>Gets a value indicating whether this <see cref="Game"/> has Power History 
		/// building enabled.
		/// </summary>
		/// <value><c>true</c> if history building is enabled; otherwise, <c>false</c>.</value>
		public bool History => _gameConfig.History;

		/// <summary>
		/// Gets the task stack.
		/// </summary>
		/// <value>The task stack.</value>
		/// <autogeneratedoc />
		public TaskStack TaskStack { get; }

		/// <summary>
		/// Gets the task queue.
		/// </summary>
		/// <value>The task queue.</value>
		/// <autogeneratedoc />
		public TaskQueue TaskQueue { get; }

		/// <summary>
		/// Gets or sets the list of enchantments or triggers which need to be removed (lazily) 
		/// from this game.
		/// </summary>
		/// <value><see cref="ILazyRemove"/></value>
		public Queue<ILazyRemove> LazyRemoves { get; set; } = new Queue<ILazyRemove>();

		private int _idIndex = 4;
		public int NextId => _idIndex++;

		private int _oopIndex;
		public int NextOop => _oopIndex++;

		public void SetIndexer(int id, int oop)
		{
			_idIndex = id;
			_oopIndex = oop;
		}

		/// <summary>
		/// Gets the dictionary containing all generated entities for this game.
		/// </summary>
		/// <value><see cref="IPlayable"/></value>
		public Dictionary<int, IPlayable> IdEntityDic { get; private set; } = new Dictionary<int, IPlayable>();

		/// <summary>
		/// Gets the dictionary containing all generated choice sets for this game.
		/// </summary>
		/// <value><see cref="PowerEntityChoices"/></value>
		public Dictionary<int, PowerEntityChoices> EntityChoicesMap { get; } = new Dictionary<int, PowerEntityChoices>();

		/// <summary>
		/// Gets all the dictionary containing all generated option sets for this game.
		/// </summary>
		/// <value><see cref="PowerAllOptions"/></value>
		public Dictionary<int, PowerAllOptions> AllOptionsMap { get; } = new Dictionary<int, PowerAllOptions>();

		/// <summary>
		/// Gets or sets the collection of log entries.
		/// </summary>
		/// <value><see cref="LogEntry"/></value>
		public Queue<LogEntry> Logs { get; set; } = new Queue<LogEntry>();

		/// <summary>Initializes a new instance of the <see cref="Game"/> class.</summary>
		/// <param name="gameConfig">The game configuration.</param>
		/// <param name="setupHeroes"></param>
		public Game(GameConfig gameConfig, bool setupHeroes = true)
			: base(null, Card.CardGame, new Dictionary<GameTag, int>
			{
				[GameTag.ENTITY_ID] = GAME_ENTITYID,
				[GameTag.ZONE] = (int)Enums.Zone.PLAY,
				[GameTag.CARDTYPE] = (int)CardType.GAME
			})
		{
			_gameConfig = gameConfig;
			Game = this;
			GamesEventManager = new GameEventManager(this);

			_players[0] = new Controller(this, gameConfig.Player1Name, 1, 2);
			_players[1] = new Controller(this, gameConfig.Player2Name, 2, 3);

			// add power history create game
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.CreateGame(this, _players));

			if (setupHeroes)
			{
				_players[0].AddHeroAndPower(Cards.HeroCard(gameConfig.Player1HeroClass));
				_players[1].AddHeroAndPower(Cards.HeroCard(gameConfig.Player2HeroClass));
			}

			TaskQueue = new TaskQueue(this);
			TaskStack = new TaskStack(this);
		}

		/// <summary>Method which is called when an entity wants to notify that one of it's tags changed value.</summary>
		/// <param name="entity">The entity which has changed.</param>
		/// <param name="t">The game tag which value changed.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		protected internal virtual void OnEntityChanged(Entity entity, GameTag t, int oldValue, int newValue)
		{
			EntityChangedEvent?.Invoke(entity, t, oldValue, newValue);
		}

		protected internal virtual void OnRandomHappened(bool isHappened)
		{
			RandomHappenedEvent?.Invoke(this, isHappened);
		}

		/// <summary>
		/// Gets the controller for the provided entityID.
		/// </summary>
		/// <param name="entityID">The entityID.</param>
		/// <returns></returns>
		public Controller ControllerById(int entityID)
		{
			return _players.First(p => p.Id == entityID);
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

			Log(LogLevel.INFO, BlockType.PLAY, "Game", gameTask.FullPrint());

			// clear last power history
			PowerHistory.Last.Clear();

			// make sure that we only use task for this game ...
			gameTask.Game = this;
			gameTask.Process();

			// add enchantment and buff tag changes
			if (History)
			{
				Enchants.ForEach(p =>
					p.Effects.Keys.ToList().ForEach(t =>
						IdEntityDic.Values.ToList().ForEach(o =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t])))));

				foreach (Controller controller in _players)
				{
					controller.Hero.Enchants.ForEach(p =>
						p.Effects.Keys.ToList().ForEach(t =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(Game.CurrentPlayer.Hero.Id, t, Game.CurrentPlayer.Hero[t]))));

					//CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
					//CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());
					//CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
					//CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

					controller.ControlledZones.Where(z => z != null).ToList().ForEach(z =>
						z.Enchants.ForEach(p =>
							p.Effects.Keys.ToList().ForEach(t =>
								z.GetAll.ForEach(o =>
									PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t]))))));

				}

				Characters.ForEach(c =>
					c.Enchants.ForEach(p =>
						p.Effects.Keys.ToList().ForEach(t =>
							PowerHistory.Add(PowerHistoryBuilder.TagChange(c.Id, t, c[t])))));
			}

			if (Splitting)
			{
				List<SplitNode> finalSplits = SplitNode.GetSolutions(this, 10, 10000);
				Dump("Split", $"found {finalSplits.Count} final splits of {finalSplits.Sum(p => p.SameState + 1)}!");
				finalSplits.GroupBy(p => p.SameState)
					.Select(i => new { Word = i.Key, Count = i.Count() })
					.ToList().ForEach(p => Dump("Split", $" {p.Count},  with {p.Word} same states"));
				Dump("Split", $"Finalsplits ordered by probability:");
				finalSplits.OrderByDescending(p => p.Probability).ToList()
					.ForEach(p => Dump("Split", $"{finalSplits.IndexOf(p)}. {p.Probability.ToString("0.00%")} "));
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
			Log(LogLevel.INFO, BlockType.PLAY, "Game", "Starting new game now!");

			// setting up the decks ...
			_gameConfig.Player1Deck?.ForEach(p =>
			{
				Player1.DeckCards.Add(p);
				Entity.FromCard(Player1, p, null, Player1.DeckZone);
			});
			_gameConfig.Player2Deck?.ForEach(p =>
			{
				Player2.DeckCards.Add(p);
				Entity.FromCard(Player2, p, null, Player2.DeckZone);
			});
			if (_gameConfig.FillDecks)
			{
				Player1.DeckZone.Fill(_gameConfig.FillDecksPredictably ? _gameConfig.UnPredictableCardIDs : null);
				Player2.DeckZone.Fill(_gameConfig.FillDecksPredictably ? _gameConfig.UnPredictableCardIDs : null);
			}

			// set gamestats
			State = State.RUNNING;
			_players.ToList().ForEach(p => p.PlayState = PlayState.PLAYING);

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, this.Id, "", -1, 0));

			// getting first player
			FirstPlayer = _gameConfig.StartPlayer < 0
				? _players[Util.Random.Next(0, 2)]
				: _players[_gameConfig.StartPlayer - 1];
			CurrentPlayer = FirstPlayer;

			Log(LogLevel.INFO, BlockType.PLAY, "Game", $"Starting Player is {CurrentPlayer.Name}.");

			// first turn
			Turn = 1;

			// set next step
			NextStep = Step.BEGIN_FIRST;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_FIRST
		/// </summary>
		public void BeginFirst()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin First.");

			// set next step
			NextStep = Step.BEGIN_SHUFFLE;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_SHUFFLE
		/// </summary>
		public void BeginShuffle()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Shuffle.");

			if (_gameConfig.Shuffle)
			{
				Player1.DeckZone.Shuffle();
				Player2.DeckZone.Shuffle();
			}

			// set next step
			NextStep = Step.BEGIN_DRAW;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_DRAW
		/// </summary>
		public void BeginDraw()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Draw.");

			//FirstPlayer.NumCardsToDraw = 3;
			//FirstPlayer.Opponent.NumCardsToDraw = 4;

			_players.ToList().ForEach(p =>
			{
				// quest draw if there is
				IPlayable quest = p.DeckZone.GetAll.Where(q => q is Spell && ((Spell)q).IsQuest).FirstOrDefault();
				Generic.Draw(p, quest != null ? quest : null);
				Generic.Draw(p);
				Generic.Draw(p);

				if (p != FirstPlayer)
				{
					// 4th card for second player
					Generic.Draw(p);

					IPlayable coin = FromCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"), new Dictionary<GameTag, int>()
					{
						[GameTag.ZONE] = (int)Enums.Zone.HAND,
						[GameTag.CARDTYPE] = (int)CardType.SPELL,
						[GameTag.CREATOR] = FirstPlayer.Opponent.PlayerId
					});
					Generic.AddHandPhase(FirstPlayer.Opponent, coin);
				}

				p.NumTurnsLeft = 1;
			});

			Player1.TimeOut = 75;
			Player2.TimeOut = 75;

			// ending mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			NextStep = _gameConfig.SkipMulligan ? Step.MAIN_BEGIN : Step.BEGIN_MULLIGAN;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_MULLIGAN
		/// </summary>
		public void BeginMulligan()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Begin Mulligan.");

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, this.Id, "", -1, 0));

			Player1.MulliganState = Mulligan.INPUT;
			Player2.MulliganState = Mulligan.INPUT;

			Generic.CreateChoice.Invoke(Player1, this, ChoiceType.MULLIGAN, ChoiceAction.HAND, Player1.HandZone.Select(p => p.Id).ToList());
			Generic.CreateChoice.Invoke(Player2, this, ChoiceType.MULLIGAN, ChoiceAction.HAND, Player2.HandZone.Select(p => p.Id).ToList());

			// ending mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_BEGIN
		/// </summary>
		public void MainBegin()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", $"Main Begin.");

			// and a coin
			//Generic.DrawCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"));

			NextStep = Step.MAIN_READY;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_READY
		/// </summary>
		public void MainReady()
		{
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 1, 0));

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
			foreach (Minion e in CurrentPlayer.BoardZone)
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

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = Step.MAIN_START_TRIGGERS;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_START_TRIGGERS
		/// </summary>
		public void MainStartTriggers()
		{
			CurrentPlayer.TurnStart = true;
			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 8, 0));

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = Step.MAIN_RESOURCE;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_RESOURCE
		/// </summary>
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

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_DRAW
		/// </summary>
		public void MainDraw()
		{
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 0, 0)); // turn start effect

			//CurrentPlayer.NumCardsToDraw = 1;
			Generic.Draw(CurrentPlayer);

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = Step.MAIN_START;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_START
		/// </summary>
		public void MainStart()
		{
			Log(LogLevel.INFO, BlockType.PLAY, "Game", $"[T:{Turn}/R:{(int)Turn / 2}] with CurrentPlayer {CurrentPlayer.Name} " +
					 $"[HP:{CurrentPlayer.Hero.Health}/M:{CurrentPlayer.RemainingMana}]");


			DeathProcessingAndAuraUpdate();

			// move forward if game isn't won by any player now!
			NextStep = _players.ToList().TrueForAll(p => p.PlayState == PlayState.PLAYING)
				? Step.MAIN_ACTION
				: Step.FINAL_WRAPUP;

			// set next step
			//NextStep = Step.MAIN_CLEANUP;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_END
		/// </summary>
		public void MainEnd()
		{
			Log(LogLevel.INFO, BlockType.PLAY, "Game", $"End turn proccessed by player {CurrentPlayer}");

			if (History)
				PowerHistoryBuilder.BlockStart(Enums.BlockType.TRIGGER, CurrentPlayer.Id, "", 4, 0);

			CurrentPlayer.TurnStart = false;
			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = Step.MAIN_NEXT;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_NEXT
		/// </summary>
		public void MainNext()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(Enums.BlockType.TRIGGER, this.Id, "", -1, 0);

			CurrentPlayer.NumTurnsLeft = 0;
			CurrentOpponent.NumTurnsLeft = 1;

			// After a player ends their turn (just before the next player's Start of
			// Turn Phase), un-Freeze all characters they control that are Frozen, 
			// don't have summoning sickness (or do have Charge) and have not attacked
			// that turn.
			CurrentPlayer.BoardZone.GetAll.ForEach(p =>
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

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = Step.MAIN_READY;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_CLEANUP
		/// </summary>
		public void MainCleanUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(Enums.BlockType.TRIGGER, CurrentPlayer.Id, "", 5, 0);

			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// move forward if game isn't won by any player now!
			NextStep = _players.ToList().TrueForAll(p => p.PlayState == PlayState.PLAYING)
				? Step.MAIN_ACTION
				: Step.FINAL_WRAPUP;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = FINAL_WRAPUP
		/// </summary>
		public void FinalWrapUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(Enums.BlockType.TRIGGER, Id, "", -1, 0);

			Heroes.ForEach(p =>
			{
				if (p.Controller.PlayState == PlayState.LOSING || p.Controller.PlayState == PlayState.CONCEDED)
				{
					p.Controller.PlayState = PlayState.LOST;
					p.Controller.Opponent.PlayState = PlayState.WON;
				}
			});

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = Step.FINAL_GAMEOVER;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = FINAL_GAMEOVER
		/// </summary>
		public void FinalGameOver()
		{
			State = State.COMPLETE;
			_players.ToList().ForEach(p =>
			{
				Log(LogLevel.INFO, BlockType.PLAY, "Game", $"{p.Name} has {p.PlayState} the Game!");
			});
		}

		#endregion

		/// <summary>
		/// Move destroyed entities from <see cref="Zone.PLAY"/> <see cref="Zone{T}"/> into 
		/// <see cref="Zone.GRAVEYARD"/>
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
				Log(LogLevel.INFO, BlockType.PLAY, "Game", $"{p} is Dead! Graveyard say 'Hello'!");
				p.Zone.Remove(p);
				if (p.HasDeathrattle)
				{
					p.ApplyEnchantments(EnchantmentActivation.DEATHRATTLE, Enums.Zone.GRAVEYARD);
				}
				if (History)
					PowerHistoryBuilder.BlockStart(BlockType.DEATHS, 1, "", 0, 0);
				p.IsExhausted = false;
				p.Controller.GraveyardZone.Add(p);
				p.Controller.NumFriendlyMinionsThatDiedThisTurn++;
				CurrentPlayer.NumMinionsPlayerKilledThisTurn++;
				NumMinionsKilledThisTurn++;
				p.Damage = 0;
				if (History)
					PowerHistoryBuilder.BlockEnd();
			});

			// check for dead heroes
			var deadHeroes = Heroes.Where(p => p.IsDead).ToList();
			deadHeroes.ForEach(p => p.Controller.PlayState = deadHeroes.Count > 1 ? PlayState.TIED : PlayState.LOSING);
		}

		/// <summary>
		/// Update the auras on each zone (which can be influenced by entities from the 
		/// <see cref="Zone.PLAY"/> zone.
		/// </summary>
		public void AuraUpdate()
		{
			Enchants.ForEach(p => p.IsEnabled());
			Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.Hero.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.Hero.Triggers.ForEach(p => p.IsEnabled());

			//CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.BoardZone.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.BoardZone.Triggers.ForEach(p => p.IsEnabled());

			CurrentPlayer.GraveyardZone.Enchants.ForEach(p => p.IsEnabled());
			CurrentPlayer.GraveyardZone.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.Hero.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.Hero.Triggers.ForEach(p => p.IsEnabled());

			//CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.BoardZone.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.BoardZone.Triggers.ForEach(p => p.IsEnabled());

			CurrentOpponent.GraveyardZone.Enchants.ForEach(p => p.IsEnabled());
			CurrentOpponent.GraveyardZone.Triggers.ForEach(p => p.IsEnabled());

			Characters.ForEach(p1 => p1.Enchants.ForEach(p2 => p2.IsEnabled()));
			Characters.ForEach(p1 => p1.Triggers.ForEach(p2 => p2.IsEnabled()));

			LazyRemoves.ToList().ForEach(p => p.Remove());
			LazyRemoves.Clear();
		}

		/// <summary>
		/// Checks for entities which are pending to be destroyed and updated 
		/// active auras accordingly.
		/// </summary>
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

		/// <summary>
		/// Performs a deep copy of this game instance and returns the result.
		/// </summary>
		/// <returns></returns>
		public Game Clone(bool logging = false)
		{
			GameConfig gameConfig = _gameConfig.Clone();
			gameConfig.Logging = logging;
			var game = new Game(gameConfig, false)
			{
				CloneIndex = $"{this.CloneIndex}[{NextCloneIndex++}]"
			};
			game.Player1.Stamp(Player1);
			game.Player2.Stamp(Player2);
			game.Stamp(this);

			game.TaskStack.Stamp(TaskStack);
			game.TaskQueue.Stamp(TaskQueue);

			// set indexer to avoid conflicts ...
			game.SetIndexer(_idIndex, _oopIndex);

			return game;
		}

		/// <summary>Builds and stores a logentry, from the specified log message.</summary>
		/// <param name="level"><see cref="LogLevel"/></param>
		/// <param name="block"><see cref="BlockType"/></param>
		/// <param name="location">Rough string respresentation of where in the code the message came from.</param>
		/// <param name="text">The message itself.</param>
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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public void Dump(string location, string text)
		{
			Logs.Enqueue(new LogEntry()
			{
				TimeStamp = DateTime.Now,
				Level = LogLevel.DUMP,
				Location = location,
				BlockType = BlockType.SCRIPT,
				Text = text
			});
		}

		public override string Hash(params GameTag[] ignore)
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
			str.AppendLine(Player1.HandZone.FullPrint());
			str.AppendLine(Player1.Hero.FullPrint());
			str.AppendLine(Player1.BoardZone.FullPrint());
			str.AppendLine(Player2.BoardZone.FullPrint());
			str.AppendLine(Player2.Hero.FullPrint());
			str.AppendLine(Player2.HandZone.FullPrint());
			return str.ToString();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}

	public partial class Game
	{
		/// <summary>
		/// Gets or sets the turn count.
		/// </summary>
		/// <value>The amount of player turns that happened in the game. When the game starts (after Mulligan),
		/// value will equal 1.</value>
		public int Turn
		{
			get { return this[GameTag.TURN]; }
			set { this[GameTag.TURN] = value; }
		}

		/// <summary>
		/// Gets or sets the game state.
		/// </summary>
		/// <value><see cref="State"/></value>
		public State State
		{
			get { return (State)this[GameTag.STATE]; }
			set { this[GameTag.STATE] = (int)value; }
		}

		/// <summary>
		/// Gets or sets the first card played this turn.
		/// </summary>
		/// <value>The entityID of the card.</value>
		public int FirstCardPlayedThisTurn
		{
			get { return this[GameTag.FIRST_CARD_PLAYED_THIS_TURN]; }
			set { this[GameTag.FIRST_CARD_PLAYED_THIS_TURN] = value; }
		}

		/// <summary>
		/// The controller which goes 'first'. This player's turn starts after Mulligan.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller FirstPlayer
		{
			get
			{
				return Player1[GameTag.FIRST_PLAYER] == 1 ? Player1 : Player2[GameTag.FIRST_PLAYER] == 1 ? Player2 : null;
			}
			set { value[GameTag.FIRST_PLAYER] = 1; }
		}

		/// <summary>
		/// Gets or sets the controller delegating the current turn.
		/// </summary>
		/// <value><see cref="Controller"/></value>
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

		/// <summary>
		/// Gets the opponent controller of <see cref="CurrentPlayer"/>.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentOpponent
			=> Player1[GameTag.CURRENT_PLAYER] == 1 ? Player2 : Player2[GameTag.CURRENT_PLAYER] == 1 ? Player1 : null;

		/// <summary>
		/// Gets or sets the CURRENT step. These steps occur within <see cref="EState.RUNNING"/> and
		/// indicate states which are used to process actions.
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step Step
		{
			get { return (Step)this[GameTag.STEP]; }
			set { this[GameTag.STEP] = (int)value; }
		}

		/// <summary>
		/// Gets or sets the NEXT step. <seealso cref="Step"/>
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step NextStep
		{
			get { return (Step)this[GameTag.NEXT_STEP]; }
			set { this[GameTag.NEXT_STEP] = (int)value; }
		}

		/// <summary>
		/// Gets or sets the number of killed minions for this turn.
		/// </summary>
		/// <value>The amount of killed minions.</value>
		public int NumMinionsKilledThisTurn
		{
			get { return this[GameTag.NUM_MINIONS_KILLED_THIS_TURN]; }
			set { this[GameTag.NUM_MINIONS_KILLED_THIS_TURN] = value; }
		}

		public List<Hero> Heroes => new List<Hero> { Game.Player1.Hero, Game.Player2.Hero };

		public List<Minion> Minions
		{
			get
			{
				var list = new List<Minion>();
				list.AddRange(Game.Player1.BoardZone);
				list.AddRange(Game.Player2.BoardZone);
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
