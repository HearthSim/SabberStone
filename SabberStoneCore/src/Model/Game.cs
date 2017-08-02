using SabberStoneCore.Actions;
using SabberStoneCore.Collections;
using SabberStoneCore.Config;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Splits;
using SabberStoneCore.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
	public delegate void EntityChangedEventHandler(object sender, EGameTag t, int oldValue, int newValue);

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

		public int NextCloneIndex { get; set; } = 1;

		public List<SplitNode> FinalSplits { get; set; }

		public string CloneIndex { get; set; } = "[0]";

		public bool Splitting => _gameConfig.Splitting;

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
		public Controller Player1 => _players[0];
		/// <summary>Player starting at the second turn, alias Player 2.</summary>
		/// <value><see cref="Controller"/></value>
		public Controller Player2 => _players[1];

		/// <summary>The game configuration, which was provided on setup</summary>
		private readonly GameConfig _gameConfig;

		/// <summary>Gets the maximum amount of minions allowed inside the PLAY <see cref="IZone"/>.</summary>
		/// <value>The maximum amount of minions.</value>
		public int MaxMinionsOnBoard => _gameConfig.MaxMinionsOnBoard;

		/// <summary>Gets the format type of this game.</summary>
		/// <value><see cref="EFormatType"/></value>
		public EFormatType FormatType => _gameConfig.FormatType;




		public PowerHistory PowerHistory { get; set; } = new PowerHistory();

		public bool History => _gameConfig.History;



		public TaskStack TaskStack { get; }

		public TaskQueue TaskQueue { get; }

		public Queue<ILazyRemove> LazyRemoves { get; set; } = new Queue<ILazyRemove>();

		public Dictionary<int, IPlayable> IdEntityDic { get; private set; } = new Dictionary<int, IPlayable>();

		public Dictionary<int, PowerEntityChoices> EntityChoicesMap { get; } = new Dictionary<int, PowerEntityChoices>();

		public Dictionary<int, PowerAllOptions> AllOptionsMap { get; } = new Dictionary<int, PowerAllOptions>();

		private int _idIndex = 4;
		public int NextId => _idIndex++;

		private int _oopIndex;
		public int NextOop => _oopIndex++;

		public void SetIndexer(int id, int oop)
		{
			_idIndex = id;
			_oopIndex = oop;
		}

		public List<Hero> Heroes => new List<Hero> { Game.Player1.Hero, Game.Player2.Hero };

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


		public Queue<LogEntry> Logs { get; set; } = new Queue<LogEntry>();



		#endregion

		public Game(GameConfig gameConfig, bool setupHeroes = true)
			: base(null, Card.CardGame, new Dictionary<EGameTag, int>
			{
				[EGameTag.ENTITY_ID] = 1,
				[EGameTag.ZONE] = (int)Enums.EZone.PLAY,
				[EGameTag.CARDTYPE] = (int)ECardType.GAME
			})
		{
			_gameConfig = gameConfig;
			Game = this;
			GamesEventManager = new GameStepManager(this);

			_players[0] = new Controller(this, gameConfig.Player1Name, 1, 2);
			_players[1] = new Controller(this, gameConfig.Player2Name, 2, 3);

			// add power history create game
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.CreateGame(this, _players));

			if (setupHeroes)
			{
				_players[0].AddHeroAndPower(Cards.DefaultHeroCard(gameConfig.Player1HeroClass));
				_players[1].AddHeroAndPower(Cards.DefaultHeroCard(gameConfig.Player2HeroClass));
			}

			TaskQueue = new TaskQueue(this);
			TaskStack = new TaskStack(this);
		}

		protected internal virtual void OnEntityChanged(Entity entity, EGameTag t, int oldValue, int newValue)
		{
			EntityChangedEvent?.Invoke(entity, t, oldValue, newValue);
		}

		public Controller ControllerById(int controllerId)
		{
			return _players.First(p => p.Id == controllerId);
		}

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
			if (History)
			{
				Enchants.ForEach(p =>
					p.Effects.Keys.ToList().ForEach(t =>
						IdEntityDic.Values.ToList().ForEach(o =>
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

					controller.Zones.Where(z => z != null).ToList().ForEach(z =>
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
				var finalSplits = SplitNode.GetSolutions(this, 10, 10000);
				Dump("Split", $"found {finalSplits.Count} final splits of {finalSplits.Sum(p => p.SameState + 1)}!");
				finalSplits.GroupBy(p => p.SameState)
					.Select(i => new { Word = i.Key, Count = i.Count() })
					.ToList().ForEach(p => Dump("Split", $" {p.Count},  with {p.Word} same states"));
				FinalSplits = finalSplits;
			}
		}

		#region STATE_MACHINE

		// Runs when STATE = RUNNING
		public void StartGame()
		{
			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", "Starting new game now!");

			// setting up the decks ...
			_gameConfig.DeckPlayer1?.ForEach(p => Entity.FromCard(Player1, p, null, Player1.Deck));
			_gameConfig.DeckPlayer2?.ForEach(p => Entity.FromCard(Player2, p, null, Player2.Deck));
			if (_gameConfig.FillDecks)
			{
				Player1.Deck.Fill();
				Player2.Deck.Fill();
			}

			// set gamestats
			State = EState.RUNNING;
			_players.ToList().ForEach(p => p.PlayState = EPlayState.PLAYING);

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, this.Id, "", -1, 0));

			// getting first player
			FirstPlayer = _gameConfig.StartPlayer < 0
				? _players[Util.Random.Next(0, 2)]
				: _players[_gameConfig.StartPlayer - 1];
			CurrentPlayer = FirstPlayer;

			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"Starting Player is {CurrentPlayer.Name}.");

			// first turn
			Turn = 1;

			// set next step
			NextStep = EStep.BEGIN_FIRST;
		}

		public void BeginFirst()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin First.");

			// set next step
			NextStep = EStep.BEGIN_SHUFFLE;
		}

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
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			NextStep = _gameConfig.SkipMulligan ? EStep.MAIN_BEGIN : EStep.BEGIN_MULLIGAN;
		}

		public void BeginMulligan()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Begin Mulligan.");

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, this.Id, "", -1, 0));

			Player1.MulliganState = EMulligan.INPUT;
			Player2.MulliganState = EMulligan.INPUT;

			Generic.CreateChoice.Invoke(Player1, this, EChoiceType.MULLIGAN, EChoiceAction.HAND, LightWeightOrderedSet<int>.Build(Player1.Hand.Select(p => p.Id)));
			Generic.CreateChoice.Invoke(Player2, this, EChoiceType.MULLIGAN, EChoiceAction.HAND, LightWeightOrderedSet<int>.Build(Player2.Hand.Select(p => p.Id)));

			// ending mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
		}

		public void MainBegin()
		{
			Log(ELogLevel.VERBOSE, EBlockType.PLAY, "Game", $"Main Begin.");

			// and a coin
			//Generic.DrawCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"));

			NextStep = EStep.MAIN_READY;
		}

		// Runs when STEP = MAIN_READY
		public void MainReady()
		{
			if (History)
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

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_START_TRIGGERS;
		}

		// Runs when STEP = MAIN_START_TRIGGERS
		public void MainStartTriggers()
		{
			CurrentPlayer.TurnStart = true;
			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, CurrentPlayer.Id, "", 8, 0));

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_RESOURCE;
		}

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

		public void MainDraw()
		{
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.TRIGGER, CurrentPlayer.Id, "", 0, 0)); // turn start effect

			//CurrentPlayer.NumCardsToDraw = 1;
			Generic.Draw(CurrentPlayer);

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			NextStep = EStep.MAIN_START;
		}

		// Runs when STEP = MAIN_START
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

		// Runs when STEP = MAIN_END
		public void MainEnd()
		{
			Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"End turn proccessed by player {CurrentPlayer}");

			if (History)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, CurrentPlayer.Id, "", 4, 0);

			CurrentPlayer.TurnStart = false;
			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.MAIN_NEXT;
		}

		// Runs when STEP = MAIN_NEXT
		public void MainNext()
		{
			if (History)
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

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.MAIN_READY;
		}

		public void MainCleanUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, CurrentPlayer.Id, "", 5, 0);

			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// move forward if game isn't won by any player now!
			NextStep = _players.ToList().TrueForAll(p => p.PlayState == EPlayState.PLAYING)
				? EStep.MAIN_ACTION
				: EStep.FINAL_WRAPUP;
		}

		public void FinalWrapUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(Enums.EBlockType.TRIGGER, Id, "", -1, 0);

			Heroes.ForEach(p =>
			{
				if (p.Controller.PlayState == EPlayState.LOSING || p.Controller.PlayState == EPlayState.CONCEDED)
				{
					p.Controller.PlayState = EPlayState.LOST;
					p.Controller.Opponent.PlayState = EPlayState.WON;
				}
			});

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = EStep.FINAL_GAMEOVER;
		}

		public void FinalGameOver()
		{
			State = EState.COMPLETE;
			_players.ToList().ForEach(p =>
			{
				Log(ELogLevel.INFO, EBlockType.PLAY, "Game", $"{p.Name} has {p.PlayState} the Game!");
			});
		}

		#endregion

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
				if (History)
					PowerHistoryBuilder.BlockStart(EBlockType.DEATHS, 1, "", 0, 0);
				p.IsExhausted = false;
				p.Controller.Graveyard.Add(p);
				p.Controller.NumFriendlyMinionsThatDiedThisTurn++;
				CurrentPlayer.NumMinionsPlayerKilledThisTurn++;
				NumMinionsKilledThisTurn++;
				p.Damage = 0;
				if (History)
					PowerHistoryBuilder.BlockEnd();
			});

			// check for dead heroes
			var deadHeroes = Heroes.Where(p => p.IsDead).ToList();
			deadHeroes.ForEach(p => p.Controller.PlayState = deadHeroes.Count > 1 ? EPlayState.TIED : EPlayState.LOSING);
		}

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

		public void Dump(string location, string text)
		{
			Logs.Enqueue(new LogEntry()
			{
				TimeStamp = DateTime.Now,
				Level = ELogLevel.DUMP,
				Location = location,
				BlockType = EBlockType.SCRIPT,
				Text = text
			});
		}

		public void Log(ELogLevel level, EBlockType block, string location, string text)
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

		public override string Hash(params EGameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append(base.Hash(ignore));
			str.Append(Player1.Hash(ignore));
			str.Append(Player2.Hash(ignore));
			return str.ToString();
		}

		public Game Clone()
		{
			var gameConfig = _gameConfig.Clone();
			gameConfig.Logging = false;
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
}