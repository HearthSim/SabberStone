#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
//using SabberStoneCore.Splits;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Auras;

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
	/// <seealso cref="Entity" />
	public partial class Game : Entity
	{
		private readonly GameConfig _gameConfig;

		private Controller _currentPlayer;

		/// <summary>
		/// The entityID of the game itself is always 1.
		/// </summary>
		internal const int GAME_ENTITYID = 1;

		/// <summary>
		/// The maximum minions that are allowed on the board.
		/// </summary>
		public const int MAX_MINIONS_ON_BOARD = 7;

		/// <summary>
		/// List of activated auras.
		/// </summary>
		public readonly List<IAura> Auras;

		public readonly List<(int entityId, IEffect effect)> OneTurnEffects;

		/// <summary>
		/// Temporal container to store Enchantment entities of One_Turn_effects.
		/// </summary>
		public readonly List<Enchantment> OneTurnEffectEnchantments;

		/// <summary>
		/// List of activated triggers that should be validated in advance.
		/// </summary>
		public readonly List<Trigger> Triggers;

		/// <summary>
		/// List of Minions that ready to be destroyed and to be removed from the BoardZone.
		/// </summary>
		public readonly List<Minion> DeadMinions = new List<Minion>();

		/// <summary>
		/// List of Minions summoned in current event.
		/// </summary>
		public readonly List<Minion> SummonedMinions = new List<Minion>();

		/// <summary>
		/// List of entity ids of Minions in the state of 'AttackableByRush'.
		/// </summary>
		public readonly List<int> RushMinions = new List<int>();

		/// <summary>
		/// List of entity ids of 'Ghostly' entities created by Echo ability.
		/// </summary>
		public readonly List<int> GhostlyCards = new List<int>();

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

		///// <summary>
		///// Gets or sets the list of splitted (and fully resolved) games, derived from this game.
		///// The values hold the derived game instances and split meta information.
		///// </summary>
		///// <value><see cref="SplitNode"/></value>
		//public List<SplitNode> FinalSplits { get; set; }

		///// <summary>
		///// Gets or sets the list of splitted, but unresolved, game instances.
		///// These instances are derived from the current game instance but their TaskQueue
		///// still needs to process.
		///// </summary>
		///// <value><see cref="Game"/></value>
		//public List<Game> Splits { get; set; } = new List<Game>();

		/// <summary>
		/// Occurs when a TAG on an entity, which is hooked onto this game, changes.
		/// </summary>
		public event EntityChangedEventHandler EntityChangedEvent;

		/// <summary>Occurs when a random event was processed by this game.</summary>
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

		/// <summary>
		/// Gets the format type of this game.
		/// </summary>
		/// <value><see cref="FormatType"/></value>
		public FormatType FormatType => _gameConfig.FormatType;

		///// <summary>Gets a value indicating whether this <see cref="Game"/> is intended to split.
		///// When TRUE, the game WILL SPLIT ITSELF when <see cref="Splits"/> contains games derived
		///// from this one with different random outcomes.
		///// </summary>
		///// <value><c>true</c> if splitting is intended; otherwise, <c>false</c>.</value>
		//public bool Splitting => _gameConfig.Splitting;

		/// <summary>Gets a value indicating whether this <see cref="Game"/> records debug logs.
		/// When TRUE, detailed information each process step will be saved in <see cref="Logs"/>
		/// in a form of <see cref="LogEntry"/>.
		/// </summary>
		public bool Logging => _gameConfig.Logging;

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
		/// Gets the task queue.
		/// </summary>
		/// <value>The task queue.</value>
		/// <autogeneratedoc />
		public readonly TaskQueue TaskQueue;

		public readonly TriggerManager TriggerManager = new TriggerManager();

		internal EventMetaData CurrentEventData { get; set; }

		private int _idIndex = 4;
		/// <summary>Gets the next entity identifier.</summary>
		/// <value>The next entity id.</value>
		public int NextId => _idIndex++;

		private int _oopIndex;
		/// <summary>Gets the next order of play index.</summary>
		/// <value>The next oop index.</value>
		public int NextOop => _oopIndex++;

		/// <summary>Ovewrites the internal index (multiple) values.
		/// This method is relevant when cloning games.
		/// </summary>
		/// <param name="id">The nex entity ID.</param>
		/// <param name="oop">The next OOP index.</param>
		public void SetIndexer(int id, int oop)
		{
			_idIndex = id;
			_oopIndex = oop;
		}

		///// <summary>
		///// Gets the dictionary containing all generated entities for this game.
		///// </summary>
		///// <value><see cref="IPlayable"/></value>
		public EntityList IdEntityDic { get; private set; }

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
			: base(null, Card.CardGame, new EntityData
			{
				[GameTag.ENTITY_ID] = GAME_ENTITYID,
				[GameTag.ZONE] = (int)Enums.Zone.PLAY,
				[GameTag.CARDTYPE] = (int)CardType.GAME
			})
		{
			//IdEntityDic = new Dictionary<int, IPlayable>(75);
			IdEntityDic = new EntityList(75);
			_gameConfig = gameConfig;
			Game = this;
			Auras = new List<IAura>();
			Triggers = new List<Trigger>();
			GamesEventManager = new GameEventManager(this);

			EntityData p1Dict = gameConfig.History
				? new EntityData(64)
				{
					//[GameTag.HERO_ENTITY] = heroId,
					[GameTag.MAXHANDSIZE] = 10,
					[GameTag.STARTHANDSIZE] = 4,
					[GameTag.PLAYER_ID] = 1,
					[GameTag.TEAM_ID] = 1,
					[GameTag.ZONE] = (int) SabberStoneCore.Enums.Zone.PLAY,
					[GameTag.CONTROLLER] = 1,
					[GameTag.MAXRESOURCES] = 10,
					[GameTag.CARDTYPE] = (int) CardType.PLAYER
				}
				: new EntityData(64)
				{
					{GameTag.MAXRESOURCES, 10},
					{GameTag.MAXHANDSIZE, 10}
				};
			EntityData p2Dict = gameConfig.History
				? new EntityData(64)
				{
					//[GameTag.HERO_ENTITY] = heroId,
					[GameTag.MAXHANDSIZE] = 10,
					[GameTag.STARTHANDSIZE] = 4,
					[GameTag.PLAYER_ID] = 2,
					[GameTag.TEAM_ID] = 2,
					[GameTag.ZONE] = (int) SabberStoneCore.Enums.Zone.PLAY,
					[GameTag.CONTROLLER] = 2,
					[GameTag.MAXRESOURCES] = 10,
					[GameTag.CARDTYPE] = (int) CardType.PLAYER
				}
				: new EntityData(64)
				{
					{GameTag.MAXRESOURCES, 10},
					{GameTag.MAXHANDSIZE, 10}
				};
			_players[0] = new Controller(this, gameConfig.Player1Name, 1, 2, p1Dict);
			_players[1] = new Controller(this, gameConfig.Player2Name, 2, 3, p2Dict);

			// add power history create game
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.CreateGame(this, _players));

			if (setupHeroes)
			{
				_players[0].AddHeroAndPower(gameConfig.Player1HeroCard ?? Cards.HeroCard(gameConfig.Player1HeroClass));
				_players[0].BaseClass = _players[0].HeroClass;

				_players[1].AddHeroAndPower(gameConfig.Player2HeroCard ?? Cards.HeroCard(gameConfig.Player2HeroClass));
				_players[1].BaseClass = _players[1].HeroClass;
			}

			TaskQueue = new TaskQueue(this);

			OneTurnEffects = new List<(int, IEffect)>();
			OneTurnEffectEnchantments = new List<Enchantment>();

			if (!_gameConfig.Shuffle)
			{
				_gameConfig.Player1Deck?.Reverse();
				_gameConfig.Player2Deck?.Reverse();
			}

			// setting up the decks ...
			_gameConfig.Player1Deck?.ForEach(p =>
			{
				Player1.DeckCards.Add(p);
				FromCard(Player1, p, null, Player1.DeckZone);
			});
			_gameConfig.Player2Deck?.ForEach(p =>
			{
				Player2.DeckCards.Add(p);
				FromCard(Player2, p, null, Player2.DeckZone);
			});
			if (_gameConfig.FillDecks)
			{
				Player1.DeckZone.Fill(_gameConfig.FillDecksPredictably ? GameConfig.UnPredictableCardIDs : null);
				Player2.DeckZone.Fill(_gameConfig.FillDecksPredictably ? GameConfig.UnPredictableCardIDs : null);
			}
		}

		/// <summary> A copy constructor. </summary>
		private Game(Game game, bool logging = false) : base(null, game)
		{
			//IdEntityDic = new Dictionary<int, IPlayable>(game.IdEntityDic.Count);
			IdEntityDic = new EntityList(game.IdEntityDic.Count);
			Game = this;

			Auras = new List<IAura>(game.Auras.Count);
			Triggers = new List<Trigger>(game.Triggers.Count);
			OneTurnEffects = new List<(int entityId, IEffect effect)>(game.OneTurnEffects);
			OneTurnEffectEnchantments = new List<Enchantment>(game.OneTurnEffectEnchantments.Count);
			RushMinions.AddRange(game.RushMinions);
			GhostlyCards.AddRange(game.GhostlyCards);
			
			GamesEventManager = new GameEventManager(this);

			_gameConfig = game._gameConfig.Clone();
			_gameConfig.Logging = logging;

			CloneIndex = game.CloneIndex + $"[{game.NextCloneIndex++}]";

			Player1 = game.Player1.Clone(this);
			Player2 = game.Player2.Clone(this);
			if (game._currentPlayer != null)
				CurrentPlayer = game.CurrentPlayer.Id == 2 ? _players[0] : _players[1];

			// Clone auras lastly
			foreach (IAura aura in game.Auras)
			{
				aura.Clone(IdEntityDic[aura.Owner.Id]);
			}

			TaskQueue = new TaskQueue(this);

			SetIndexer(game._idIndex, game._oopIndex);
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

		/// <summary>Call this method to invode the <see cref="RandomHappenedEvent"/>.</summary>
		/// <param name="isHappened">TODO</param>
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
			//return _players.First(p => p.Id == entityID);
			return entityID == 2 ? _players[0] : _players[1];
		}

		/// <summary>Process the specified task.
		/// The game will execute the desired task and all effects coupled either
		/// directly or indirectly in synchronous manner.
		/// 
		/// Call <see cref="Controller.Options(Boolean)"/> on the <see cref="CurrentPlayer"/> 
		/// instance for tasks which are accepted as arguments.
		/// After this method returns, check <see cref="Controller.Options(Boolean)"/>
		/// again until only <see cref="EndTurnTask"/> remains, which will
		/// start the turn of <see cref="CurrentOpponent"/>. 
		/// </summary>
		/// <param name="gameTask">The game task to execute.</param>
		public bool Process(PlayerTask gameTask)
		{
			//// start with no splits ...
			//Splits = new List<Game>();

			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : gameTask.FullPrint());

			// clear last power history
			PowerHistory.Last.Clear();

			// make sure that we only use task for this game ...
			if (gameTask.Game != this)
			{
				gameTask.Game = this;
				gameTask.Controller = ControllerById(gameTask.Controller.Id);
				if (gameTask.HasSource)
					gameTask.Source = IdEntityDic[gameTask.Source.Id];
				if (gameTask.HasTarget)
					gameTask.Target = (ICharacter) IdEntityDic[gameTask.Target.Id];
			}
			bool result = gameTask.Process();

			// check dead heroes here again (TODO)
			if (State != State.COMPLETE)
			{
				if (Player1.Hero.ToBeDestroyed)
				{
					if (Player2.Hero.ToBeDestroyed)
					{
						Player1.PlayState = PlayState.TIED;
						Player2.PlayState = PlayState.TIED;
					}
					else
						Player1.PlayState = PlayState.LOSING;

					NextStep = Step.FINAL_WRAPUP;
				}
				else if (Player2.Hero.ToBeDestroyed)
				{
					Player2.PlayState = PlayState.LOSING;

					NextStep = Step.FINAL_WRAPUP;
				}
			}


			// add power and buff tag changes
			//if (false)
			//{
			//	OldEnchants.ForEach(p =>
			//		p.Effects.Keys.ToList().ForEach(t =>
			//			IdEntityDic.Values.ToList().ForEach(o =>
			//				PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t])))));

			//	foreach (Controller controller in _players)
			//	{
			//		controller.Hero.OldEnchants.ForEach(p =>
			//			p.Effects.Keys.ToList().ForEach(t =>
			//				PowerHistory.Add(PowerHistoryBuilder.TagChange(Game.CurrentPlayer.Hero.Id, t, Game.CurrentPlayer.Hero[t]))));

			//		//CurrentPlayer.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//		//CurrentPlayer.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());
			//		//CurrentOpponent.Hero.Weapon?.Enchants.ForEach(p => p.IsEnabled());
			//		//CurrentOpponent.Hero.Weapon?.Triggers.ForEach(p => p.IsEnabled());

			//		controller.ControlledZones.Where(z => z != null).ToList().ForEach(z =>
			//			z.Enchants.ForEach(p =>
			//				p.Effects.Keys.ToList().ForEach(t =>
			//					z.GetAll.ForEach(o =>
			//						PowerHistory.Add(PowerHistoryBuilder.TagChange(o.Id, t, o[t]))))));

			//	}

			//	Characters.ForEach(c =>
			//		c.OldEnchants.ForEach(p =>
			//			p.Effects.Keys.ToList().ForEach(t =>
			//				PowerHistory.Add(PowerHistoryBuilder.TagChange(c.Id, t, c[t])))));
			//}

			//if (Splitting)
			//{
			//	List<SplitNode> finalSplits = SplitNode.GetSolutions(this, 10, 10000);
			//	Dump("Split", $"found {finalSplits.Count} final splits of {finalSplits.Sum(p => p.SameState)}!");
			//	finalSplits.GroupBy(p => p.SameState)
			//		.Select(i => new { Word = i.Key, Count = i.Count() })
			//		.ToList().ForEach(p => Dump("Split", $" {p.Count},  with {p.Word} same states"));
			//	Dump("Split", $"Finalsplits ordered by probability:");
			//	finalSplits.OrderByDescending(p => p.Probability).ToList()
			//		.ForEach(p => Dump("Split", $"{finalSplits.IndexOf(p)}. {p.Probability.ToString("0.00%")} "));
			//	FinalSplits = finalSplits;
			//}

			return result;
		}

		#region STATE_MACHINE

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING.
		/// </summary>
		public void StartGame(bool stopBeforeShuffling = false)
		{
			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : "Starting new game now!");

			// set gamestats
			State = State.RUNNING;
			_players.ToList().ForEach(p => p.PlayState = PlayState.PLAYING);

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Id, "", -1, 0));

			// getting first player
			FirstPlayer = _gameConfig.StartPlayer < 0
				? _players[Util.Random.Next(0, 2)]
				: _players[_gameConfig.StartPlayer - 1];
			CurrentPlayer = FirstPlayer;

			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"Starting Player is {CurrentPlayer.Name}.");

			// first turn
			Turn = 1;

			// triggers Start of Game triggers (but does not process tasks here)
			TriggerManager.OnGameStartTrigger();

			if (stopBeforeShuffling)
				return;

			// set next step
			NextStep = Step.BEGIN_FIRST;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_FIRST
		/// </summary>
		public void BeginFirst()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", !Logging ? "" : $"Begin First.");

			// set next step
			NextStep = Step.BEGIN_SHUFFLE;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = BEGIN_SHUFFLE
		/// </summary>
		public void BeginShuffle()
		{
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", !Logging ? "" : $"Begin Shuffle.");

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
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", !Logging ? "" : $"Begin Draw.");

			//FirstPlayer.NumCardsToDraw = 3;
			//FirstPlayer.Opponent.NumCardsToDraw = 4;

			_players.ToList().ForEach(p =>
			{
				// quest draw if there is
				IPlayable quest = p.DeckZone.FirstOrDefault(q => q is Spell spell && spell.IsQuest);
				Generic.Draw(p, quest);
				Generic.Draw(p);
				Generic.Draw(p);

				if (p != FirstPlayer)
				{
					// 4th card for second player
					Generic.Draw(p);

					IPlayable coin = FromCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"), new EntityData
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
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", !Logging ? "" : $"Begin Mulligan.");

			// starting mulligan draw block
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Id, "", -1, 0));

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
			Log(LogLevel.VERBOSE, BlockType.PLAY, "Game", !Logging ? "" : $"Main Begin.");

			// and a coin
			//Generic.DrawCard(FirstPlayer.Opponent, Cards.FromId("GAME_005"));

			ProcessTasks();

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


			for (int i = 0; i < 2; ++i)
			{
				Controller c = _players[i];

				c.BoardZone.ForEach(p =>
				{
					//p.NumTurnsInPlay++;
					p.NumAttacksThisTurn = 0;
				});

				//c.Hero.NumTurnsInPlay++;
				c.Hero.NumAttacksThisTurn = 0;

				c.NumCardsDrawnThisTurn = 0;
				c.NumCardsPlayedThisTurn = 0;
				c.NumMinionsPlayedThisTurn = 0;
				c.NumOptionsPlayedThisTurn = 0;
				c.NumFriendlyMinionsThatDiedThisTurn = 0;
				if (c.AmountHeroHealedThisTurn > 0)
					c.AmountHeroHealedThisTurn = 0;
			}
			

			CurrentPlayer.Hero.IsExhausted = false;
			if (CurrentPlayer.Hero.Weapon != null)
				CurrentPlayer.Hero.Weapon.IsExhausted = false;
			CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			CurrentPlayer.BoardZone.ForEach(m => m.IsExhausted = false);

			// De-activate combo buff
			CurrentPlayer.IsComboActive = false;

			CurrentPlayer.SecretZone.ForEach(s => s.IsExhausted = true);

			CurrentPlayer.NumMinionsPlayerKilledThisTurn = 0;
			CurrentOpponent.NumMinionsPlayerKilledThisTurn = 0;
			CurrentPlayer.NumFriendlyMinionsThatAttackedThisTurn = 0;
			NumMinionsKilledThisTurn = 0;
			CurrentPlayer.HeroPowerActivationsThisTurn = 0;

			CurrentPlayer.NumElementalsPlayedLastTurn = CurrentPlayer.NumElementalsPlayedThisTurn;
			CurrentPlayer.NumElementalsPlayedThisTurn = 0;

			MainRessources();

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
			//CurrentPlayer.TurnStart = true;

			//Game.TaskQueue.StartEvent();
			TriggerManager.OnTurnStartTrigger(CurrentPlayer);
			ProcessTasks();

			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 8, 0));

			DeathProcessingAndAuraUpdate();
			//Game.TaskQueue.EndEvent();
			if (History)
				PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// set next step
			//NextStep = Step.MAIN_RESOURCE;
			NextStep = Step.MAIN_START;
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

			//// set next step
			//NextStep = Step.MAIN_DRAW;
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

			//// set next step
			//NextStep = Step.MAIN_START;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_START
		/// </summary>
		public void MainStart()
		{
			MainDraw();

			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"[T:{Turn}/R:{Turn / 2}] with CurrentPlayer {CurrentPlayer.Name} " +
					 $"[HP:{CurrentPlayer.Hero.Health}/M:{CurrentPlayer.RemainingMana}]");

			DeathProcessingAndAuraUpdate();

			NextStep = Step.MAIN_ACTION;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_END
		/// </summary>
		public void MainEnd()
		{
			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"End turn proccessed by player {CurrentPlayer}");

			if (History)
				PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 4, 0);

			//CurrentPlayer.TurnStart = false;

			TaskQueue.StartEvent();
			TriggerManager.OnEndTurnTrigger(CurrentPlayer);
			ProcessTasks();
			TaskQueue.EndEvent();
			DeathProcessingAndAuraUpdate();

			if (History)
				PowerHistoryBuilder.BlockEnd();

			CurrentPlayer.CardsPlayedThisTurn.Clear();

			CurrentPlayer.Hero.DamageTakenThisTurn = 0;

			if (RushMinions.Count > 0)
			{
				RushMinions.ForEach(i => IdEntityDic[i][GameTag.ATTACKABLE_BY_RUSH] = 0);
				RushMinions.Clear();
			}

			// set next step
			//NextStep = Step.MAIN_NEXT;
			NextStep = Step.MAIN_CLEANUP;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_CLEANUP
		/// </summary>
		public void MainCleanUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, CurrentPlayer.Id, "", 5, 0);

			// Removing Ghostly cards
			if (GhostlyCards.Count > 0)
			{
				foreach (int id in GhostlyCards)
				{
					IPlayable entity = IdEntityDic[id];
					if (entity.Zone.Type != Enums.Zone.HAND) continue;
					entity.Controller.SetasideZone.Add(entity.Zone.Remove(entity));
				}

				GhostlyCards.Clear();
			}

			// Removing one-turn-effects
			foreach ((int id, IEffect eff) in OneTurnEffects)
				eff.RemoveFrom(IdEntityDic[id]);
			OneTurnEffects.Clear();
			List<Enchantment> enchantments = OneTurnEffectEnchantments;
			for (int i = enchantments.Count - 1; i >= 0; --i)
				enchantments[i].Remove();
			

			// After a player ends their turn (just before the next player's Start of
			// Turn Phase), un-Freeze all characters they control that are Frozen, 
			// don't have summoning sickness (or do have Charge) and have not attacked
			// that turn.
			CurrentPlayer.BoardZone.ForEach(m =>
			{
				if (m.IsFrozen && m.NumAttacksThisTurn == 0 && !m.IsExhausted)
					m.IsFrozen = false;
			});

			if (CurrentPlayer.Hero.IsFrozen && CurrentPlayer.Hero.NumAttacksThisTurn == 0)
			{
				CurrentPlayer.Hero.IsFrozen = false;
			}

			// Exhausts weapon and secrets
			if (CurrentPlayer.Hero.Weapon != null)
				CurrentPlayer.Hero.Weapon.IsExhausted = true;
			CurrentPlayer.SecretZone.ForEach(p => p.IsExhausted = false);

			if (History)
				PowerHistoryBuilder.BlockEnd();

			NextStep = Step.MAIN_NEXT;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = MAIN_NEXT
		/// </summary>
		public void MainNext()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Id, "", -1, 0);

			// extra turn effect here
			if (CurrentPlayer.NumTurnsLeft > 1)
			{
				//this[GameTag.EXTRA_TURNS_TAKEN_THIS_GAME]++;
				//CurrentPlayer[GameTag.EXTRA_TURNS_TAKEN_THIS_GAME]++;
				//this[GameTag.IS_CURRENT_TURN_AN_EXTRA_TURN] = 1;
				CurrentPlayer.NumTurnsLeft--;
			}
			else if
				(CurrentOpponent.TemporusFlag)
			{
				//this[GameTag.EXTRA_TURNS_TAKEN_THIS_GAME]++;
				//CurrentOpponent[GameTag.EXTRA_TURNS_TAKEN_THIS_GAME]++;
				//this[GameTag.IS_CURRENT_TURN_AN_EXTRA_TURN] = 1;
				CurrentPlayer = CurrentOpponent;
				CurrentPlayer.NumTurnsLeft = 2;
				CurrentPlayer.TemporusFlag = false;
			}
			else
			{
				CurrentPlayer.NumTurnsLeft = 0;
				CurrentOpponent.NumTurnsLeft = 1;
				// set player for next turn ...
				CurrentPlayer = CurrentOpponent;
			}

			// count next turn
			Turn++;

			Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"CurentPlayer {CurrentPlayer.Name}.");

			if (History)
				PowerHistoryBuilder.BlockEnd();

			// set next step
			NextStep = Step.MAIN_READY;
		}

		/// <summary>
		/// Part of the state machine.
		/// Runs when STATE = RUNNING &amp;&amp; NEXTSTEP = FINAL_WRAPUP
		/// </summary>
		public void FinalWrapUp()
		{
			if (History)
				PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, Id, "", -1, 0);

			foreach (Controller player in _players)
			{
				if (player.PlayState == PlayState.TIED)
				{
					player.PlayState = PlayState.LOST;
					player.Opponent.PlayState = PlayState.LOST;
					break;
				}

				if (player.PlayState != PlayState.LOSING && player.PlayState != PlayState.CONCEDED) continue;

				player.PlayState = PlayState.LOST;
				player.Opponent.PlayState = PlayState.WON;
			}

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
			if (Logging)
			{
				_players.ToList().ForEach(p =>
				{
					Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"{p.Name} has {p.PlayState} the Game!");
				});
			}
		}
		#endregion

		internal Action ClearWeapons;
		private static readonly Func<Minion, int> GetOrderOfPlay = m => m.OrderOfPlay;

		/// <summary>
		/// Move destroyed entities from <see cref="Zone.PLAY"/> <see cref="Zone{T}"/> into 
		/// <see cref="Zone.GRAVEYARD"/>
		/// <para></para>
		/// Death Creation Step (Death event is created but not resolved here)
		/// </summary>
		public void GraveYard()
		{
			if (ClearWeapons != null)
			{
				ClearWeapons.Invoke();
				ClearWeapons = null;
			}

			if (DeadMinions.Count > 0)
			{
				if (History)
					PowerHistoryBuilder.BlockStart(BlockType.DEATHS, 1, "", 0, 0);

				DeadMinions.InsertionSort(GetOrderOfPlay);
				foreach (Minion minion in DeadMinions)
				{
					Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : $"{minion} is Dead! Graveyard say 'Hello'!");

					// Death event created
					TriggerManager.OnDeathTrigger(minion);

					minion.LastBoardPosition = minion.ZonePosition;
					minion.Zone.Remove(minion);

					if (minion.HasDeathrattle)
						minion.ActivateTask(PowerActivation.DEATHRATTLE);

					minion.Controller.GraveyardZone.Add(minion);
					minion.Controller.NumFriendlyMinionsThatDiedThisTurn++;
					CurrentPlayer.NumMinionsPlayerKilledThisTurn++;
					NumMinionsKilledThisTurn++;

					//minion.Damage = 0;
					//minion.IsExhausted = false;

					// should remove tags of dead cards for faster cloning
				}

				if (History)
					PowerHistoryBuilder.BlockEnd();

				DeadMinions.Clear();
			}

			if (Player1.Hero.ToBeDestroyed)
			{
				// TODO: Temporary approach. Should change the whole structure.
				if (State == State.COMPLETE)
					return;

				if (Player2.Hero.ToBeDestroyed)
				{
					Player1.PlayState = PlayState.TIED;
					Player2.PlayState = PlayState.TIED;
				}
				else
					Player1.PlayState = PlayState.LOSING;

				NextStep = Step.FINAL_WRAPUP;
			}
			else if (Player2.Hero.ToBeDestroyed)
			{
				// TODO: Temporary approach. Should change the whole structure.
				if (State == State.COMPLETE)
					return;

				Player2.PlayState = PlayState.LOSING;

				if (State == State.COMPLETE)
					return;
				NextStep = Step.FINAL_WRAPUP;
			}
		}

		/// <summary>
		/// Update the auras on each zone (which can be influenced by entities from the 
		/// <see cref="Zone.PLAY"/> zone.
		/// </summary>
		public void AuraUpdate()
		{
			List<IAura> auras = Auras;
			for (int i = auras.Count - 1; i >= 0; i--)
				auras[i].Update();
		}

		/// <summary>
		/// Process enqueued tasks.
		/// </summary>
		internal void ProcessTasks()
		{
			TaskQueue queue = TaskQueue;
			while (!queue.IsEmpty)
			{
				if (queue.Process() != TaskState.COMPLETE)
				{
					Log(LogLevel.INFO, BlockType.PLAY, "Game", !Logging ? "" : "Something really bad happend during proccessing, please analyze!");
				}
			}
		}

		/// <summary>
		/// Checks for entities which are pending to be destroyed and updated 
		/// active auras accordingly.
		/// </summary>
		public void DeathProcessingAndAuraUpdate()
		{
			//Inter-Phase steps
			
			AuraUpdate();

			// Summon Resolution Step
			if (TriggerManager.HasOnSummonTrigger)
			{
				List<Minion> minions = SummonedMinions;
				TaskQueue.StartEvent();
				for (int i = 0; i < minions.Count; i++)
				{
					TriggerManager.OnSummonTrigger(minions[i]);
				}
				ProcessTasks();
				TaskQueue.EndEvent();
			}
			SummonedMinions.Clear();

			TaskQueue.StartEvent();
			do
			{
				GraveYard();	// Death Creation Step

				ProcessTasks(); // Death Resolution Phase
			} while (DeadMinions.Count != 0);
			TaskQueue.EndEvent();

			AuraUpdate();	// Aura Update (Other) step(Not implemented)
		}


		/// <summary>
		/// Performs a deep copy of this game instance and returns the result.
		/// </summary>
		/// <returns></returns>
		public Game Clone(bool logging = false)
		{
			return new Game(this, logging);
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
			get => Player1[GameTag.FIRST_PLAYER] == 1 ? Player1 : Player2[GameTag.FIRST_PLAYER] == 1 ? Player2 : null;
			set => value[GameTag.FIRST_PLAYER] = 1;
		}

		/// <summary>
		/// Gets or sets the controller delegating the current turn.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentPlayer
		{
			get => _currentPlayer;
			private set
			{
				_currentPlayer = value;
				if (!History) return;
				value.Opponent[GameTag.CURRENT_PLAYER] = 0;
				value[GameTag.CURRENT_PLAYER] = 1;
			}
		}

		/// <summary>
		/// Gets the opponent controller of <see cref="CurrentPlayer"/>.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		//public Controller CurrentOpponent
		//	=> Player1[GameTag.CURRENT_PLAYER] == 1 ? Player2 : Player2[GameTag.CURRENT_PLAYER] == 1 ? Player1 : null;
		public Controller CurrentOpponent => _currentPlayer == Player1 ? Player2 : Player1;

		/// <summary>
		/// Gets or sets the CURRENT step. These steps occur within <see cref="State.RUNNING"/> and
		/// indicate states which are used to process actions.
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step Step
		{
			get => (Step)_data[GameTag.STEP];
			set => this[GameTag.STEP] = (int)value;
		}

		/// <summary>
		/// Gets or sets the NEXT step. <seealso cref="Step"/>
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step NextStep
		{
			set
			{
				this[GameTag.NEXT_STEP] = (int)value;
				GamesEventManager.NextStepEvent(this, value);
			}
		}

		/// <summary>
		/// Gets or sets the number of killed minions for this turn.
		/// </summary>
		/// <value>The amount of killed minions.</value>
		public int NumMinionsKilledThisTurn
		{
			get
			{
				_data.TryGetValue(GameTag.NUM_MINIONS_KILLED_THIS_TURN, out int value);
				return value;
			}
			set { this[GameTag.NUM_MINIONS_KILLED_THIS_TURN] = value; }
		}

		/// <summary>
		/// The entityID of the character which wants to attack, by entering the
		/// next combat phase.
		/// </summary>
		public int ProposedAttacker
		{
			get
			{
				_data.TryGetValue(GameTag.PROPOSED_ATTACKER, out int value);
				return value;
			}
			set => this[GameTag.PROPOSED_ATTACKER] = value;
		}

		/// <summary>
		/// The entityID of the character which has to defend during the next
		/// combat phase.
		/// </summary>
		public int ProposedDefender
		{
			get
			{
				_data.TryGetValue(GameTag.PROPOSED_DEFENDER, out int value);
				return value;
			}
			set => this[GameTag.PROPOSED_DEFENDER] = value;
		}

		/// <summary>Gets the heroes.</summary>
		/// <value><see cref="Hero"/></value>
		public List<Hero> Heroes => new List<Hero> { Game.Player1.Hero, Game.Player2.Hero };

		/// <summary>Gets ALL minions (from both sides of the board).</summary>
		/// <value><see cref="Minion"/></value>
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

		/// <summary>Gets ALL characters.</summary>
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
	}
}
