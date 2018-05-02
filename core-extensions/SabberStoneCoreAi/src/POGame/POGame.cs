using System;
using System.Collections.Generic;
using System.Text;
//using SabberStoneCore.CardSets.Debug;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.Meta;
namespace SabberStoneCoreAi.POGame
{
	partial class POGame
	{
		private Game game;
		private bool debug;
			
		public POGame(Game game, bool debug)
		{
			this.game = game.Clone();
			game.Player1.Game = game;
			game.Player2.Game = game;
			prepareOpponent();
			this.debug = debug;

			if (debug)
			{
				Console.WriteLine("Game Board");
				Console.WriteLine(game.FullPrint());
			}
		}

		private void prepareOpponent()
		{
			int nr_deck_cards = game.CurrentOpponent.DeckZone.Count;
			int nr_hand_cards = game.CurrentOpponent.HandZone.Count;

			game.CurrentOpponent.DeckCards = Decks.DebugDeck;

			//DebugCardsGen.AddAll(game.CurrentOpponent.DeckCards);
			game.CurrentOpponent.HandZone = new HandZone(game.CurrentOpponent);
			game.CurrentOpponent.DeckZone = new DeckZone(game.CurrentOpponent);

			for (int i = 0; i < nr_hand_cards; i++)
			{
				addCardToZone(game.CurrentOpponent.HandZone, game.CurrentOpponent.DeckCards[i], game.CurrentOpponent);
			}

			for (int i = 0; i < nr_deck_cards; i++)
			{
				addCardToZone(game.CurrentOpponent.DeckZone, game.CurrentOpponent.DeckCards[nr_hand_cards+i], game.CurrentOpponent);
			}
		}

		private void addCardToZone(IZone zone, Card card, Controller player)
		{
			var tags = new Dictionary<GameTag, int>();
			tags[GameTag.ENTITY_ID] = game.NextId;
			tags[GameTag.CONTROLLER] = player.PlayerId;
			tags[GameTag.ZONE] = (int)zone.Type;
			IPlayable playable = null;


			switch (card.Type)
			{
				case CardType.MINION:
				playable = new Minion(player, card, tags);
				break;

				case CardType.SPELL:
				playable = new Spell(player, card, tags);
				break;

				case CardType.WEAPON:
				playable = new Weapon(player, card, tags);
				break;

				case CardType.HERO:
				tags[GameTag.ZONE] = (int) SabberStoneCore.Enums.Zone.PLAY;
				tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
				playable = new Hero(player, card, tags);
				break;

				case CardType.HERO_POWER:
				tags[GameTag.COST] = card[GameTag.COST];
				tags[GameTag.ZONE] = (int) SabberStoneCore.Enums.Zone.PLAY;
				tags[GameTag.CARDTYPE] = card[GameTag.CARDTYPE];
				playable = new HeroPower(player, card, tags);
				break;

				default:
				throw new EntityException($"Couldn't create entity, because of an unknown cardType {card.Type}.");
			}

			zone?.Add(playable);
		}

		private void CreateFullInformationGame(List<Card> deck_player1, DeckZone deckzone_player1, HandZone handzone_player1, List<Card> deck_player2, DeckZone deckzone_player2, HandZone handzone_player2)
		{
			game.Player1.DeckCards = deck_player1;
			game.Player1.DeckZone = deckzone_player1;
			game.Player1.HandZone = handzone_player1;

			game.Player2.DeckCards = deck_player2;
			game.Player2.DeckZone = deckzone_player2;
			game.Player2.HandZone = handzone_player2;
		}

		public void Process(PlayerTask task)
		{
			game.Process(task);
		}

		public POGame getCopy(bool debug)
		{
			return new POGame(game, debug);
		}


		public string FullPrint()
		{
			return game.FullPrint();
		}

		public string PartialPrint()
		{
			var str = new StringBuilder();
			if (game.CurrentPlayer == game.Player1)
			{
				str.AppendLine(game.Player1.HandZone.FullPrint());
				str.AppendLine(game.Player1.Hero.FullPrint());
				str.AppendLine(game.Player1.BoardZone.FullPrint());
				str.AppendLine(game.Player2.BoardZone.FullPrint());
				str.AppendLine(game.Player2.Hero.FullPrint());
				str.AppendLine(string.Format("Opponent Hand Cards: {0}", game.Player2.HandZone.Count));
			}
			if (game.CurrentPlayer == game.Player1)
			{
				str.AppendLine(string.Format("Opponent Hand Cards: {0}", game.Player1.HandZone.Count));
				str.AppendLine(game.Player1.Hero.FullPrint());
				str.AppendLine(game.Player1.BoardZone.FullPrint());
				str.AppendLine(game.Player2.BoardZone.FullPrint());
				str.AppendLine(game.Player2.Hero.FullPrint());
				str.AppendLine(game.Player2.HandZone.FullPrint());
			}

			return str.ToString();
		}


	}

	/// <summary>
	/// Standard Getters for the current game
	/// </summary>
	partial class POGame
	{
		
		/// <summary>
		/// Gets or sets the turn count.
		/// </summary>
		/// <value>The amount of player turns that happened in the game. When the game starts (after Mulligan),
		/// value will equal 1.</value>
		public int Turn
		{
			get { return game[GameTag.TURN]; }
		}

		/// <summary>
		/// Gets or sets the game state.
		/// </summary>
		/// <value><see cref="State"/></value>
		public State State
		{
			get { return (State)game[GameTag.STATE]; }
		}

		/// <summary>
		/// Gets or sets the first card played this turn.
		/// </summary>
		/// <value>The entityID of the card.</value>
		public int FirstCardPlayedThisTurn
		{
			get { return game[GameTag.FIRST_CARD_PLAYED_THIS_TURN]; }
		}

		/// <summary>
		/// The controller which goes 'first'. This player's turn starts after Mulligan.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller FirstPlayer
		{
			get
			{
				return game.Player1[GameTag.FIRST_PLAYER] == 1 ? game.Player1 : game.Player2[GameTag.FIRST_PLAYER] == 1 ? game.Player2 : null;
			}
		}

		/// <summary>
		/// Gets or sets the controller delegating the current turn.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentPlayer
		{
			get
			{
				//return Player1[GameTag.CURRENT_PLAYER] == 1
				//	? Player1
				//	: Player2[GameTag.CURRENT_PLAYER] == 1 ? Player2 : null;
				return game.Player1.GetNativeGameTag(GameTag.CURRENT_PLAYER) == 1
					? game.Player1
					: game.Player2;
			}
		}

		/// <summary>
		/// Gets the opponent controller of <see cref="CurrentPlayer"/>.
		/// </summary>
		/// <value><see cref="Controller"/></value>
		public Controller CurrentOpponent => game.CurrentOpponent;

		/// <summary>
		/// Gets or sets the CURRENT step. These steps occur within <see cref="State.RUNNING"/> and
		/// indicate states which are used to process actions.
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step Step
		{
			//get { return (Step)this[GameTag.STEP]; }
			//set { this[GameTag.STEP] = (int)value; }
			get { return (Step)game.GetNativeGameTag(GameTag.STEP); }
		}

		/// <summary>
		/// Gets or sets the NEXT step. <seealso cref="Step"/>
		/// </summary>
		/// <value><see cref="Step"/></value>
		public Step NextStep
		{
			get { return (Step)game.GetNativeGameTag(GameTag.NEXT_STEP); }
		}

		/// <summary>
		/// Gets or sets the number of killed minions for this turn.
		/// </summary>
		/// <value>The amount of killed minions.</value>
		public int NumMinionsKilledThisTurn
		{
			get { return game[GameTag.NUM_MINIONS_KILLED_THIS_TURN]; }
		}

		/// <summary>Gets the heroes.</summary>
		/// <value><see cref="Hero"/></value>
		public List<Hero> Heroes => game.Heroes;

		/// <summary>Gets ALL minions (from both sides of the board).</summary>
		/// <value><see cref="Minion"/></value>
		public List<Minion> Minions => game.Minions;

		/// <summary>Gets ALL characters.</summary>
		/// <value><see cref="ICharacter"/></value>
		public List<ICharacter> Characters => game.Characters;
	}
}
