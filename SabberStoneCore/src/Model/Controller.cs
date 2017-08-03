using SabberStoneCore.Collections;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Instance that represents a player in SabberStone game instances.
	/// <seealso cref="Entity"/>
	/// </summary>
	public sealed class Controller : Entity
	{
		#region TAG_SHORTCUTS

		/// <summary>
		/// Duration of seconds of this player's turn.
		/// </summary>
		public int TimeOut
		{
			get { return this[EGameTag.TIMEOUT]; }
			set { this[EGameTag.TIMEOUT] = value; }
		}

		/// <summary>
		/// ID of the player, which is a monotone ranking order starting from 1.
		/// The first player gets PlayerID == 1
		/// </summary>
		public int PlayerId => this[EGameTag.PLAYER_ID];

		/// <summary>
		/// The EntityID of the selected Hero.
		/// </summary>
		public int HeroId
		{
			get { return this[EGameTag.HERO_ENTITY]; }
			set { this[EGameTag.HERO_ENTITY] = value; }
		}

		/// <summary>
		/// Context in which the controller is performing.
		/// </summary>
		public EPlayState PlayState
		{
			get { return (EPlayState)this[EGameTag.PLAYSTATE]; }
			set { this[EGameTag.PLAYSTATE] = (int)value; }
		}

		/// <summary>
		/// Progress this player is making during Mulligan Phase.
		/// <see cref="EMulligan"/>
		/// </summary>
		public EMulligan MulliganState
		{
			get { return (EMulligan)this[EGameTag.MULLIGAN_STATE]; }
			set { this[EGameTag.MULLIGAN_STATE] = (int)value; }
		}

		/// <summary>
		/// Total amount of mana available to this player.
		/// This value DOES NOT contain temporary mana!
		/// 
		/// This value is limited to 1 turnand should be reset in the next turn.
		/// </summary>
		public int BaseMana
		{
			get { return this[EGameTag.RESOURCES]; }
			set { this[EGameTag.RESOURCES] = value; }
		}

		/// <summary>
		/// Amount of mana used by this player.
		/// 
		/// This value is limited to 1 turnand should be reset in the next turn.
		/// </summary>
		public int UsedMana
		{
			get { return this[EGameTag.RESOURCES_USED]; }
			set { this[EGameTag.RESOURCES_USED] = value; }
		}

		/// <summary>
		/// Additionall mana gained during this turn.
		/// </summary>
		public int TemporaryMana
		{
			get { return this[EGameTag.TEMP_RESOURCES]; }
			set { this[EGameTag.TEMP_RESOURCES] = value; }
		}

		/// <summary>
		/// Indicates if combo enchantment effects of next cards should be executed or not.
		/// 
		/// Combo is active if at least one card has been played this turn.
		/// </summary>
		public bool IsComboActive
		{
			get { return this[EGameTag.COMBO_ACTIVE] == 1; }
			set { this[EGameTag.COMBO_ACTIVE] = value ? 1 : 0; }
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public int NumCardsDrawnThisTurn
		{
			get { return this[EGameTag.NUM_CARDS_DRAWN_THIS_TURN]; }
			set { this[EGameTag.NUM_CARDS_DRAWN_THIS_TURN] = value; }
		}

		public int NumAttacksThisTurn
		{
			get { return this[EGameTag.NUM_ATTACKS_THIS_TURN]; }
			set { this[EGameTag.NUM_ATTACKS_THIS_TURN] = value; }
		}

		public int NumCardsPlayedThisTurn
		{
			get { return this[EGameTag.NUM_CARDS_PLAYED_THIS_TURN]; }
			set { this[EGameTag.NUM_CARDS_PLAYED_THIS_TURN] = value; }
		}

		public int NumMinionsPlayedThisTurn
		{
			get { return this[EGameTag.NUM_MINIONS_PLAYED_THIS_TURN]; }
			set { this[EGameTag.NUM_MINIONS_PLAYED_THIS_TURN] = value; }
		}

		public int NumElementalsPlayedThisTurn
		{
			get { return this[EGameTag.NUM_ELEMENTAL_PLAYED_THIS_TURN]; }
			set { this[EGameTag.NUM_ELEMENTAL_PLAYED_THIS_TURN] = value; }
		}

		public int NumElementalsPlayedLastTurn
		{
			get { return this[EGameTag.NUM_ELEMENTAL_PLAYED_LAST_TURN]; }
			set { this[EGameTag.NUM_ELEMENTAL_PLAYED_LAST_TURN] = value; }
		}

		public int NumOptionsPlayedThisTurn
		{
			get { return this[EGameTag.NUM_OPTIONS_PLAYED_THIS_TURN]; }
			set { this[EGameTag.NUM_OPTIONS_PLAYED_THIS_TURN] = value; }
		}

		public int NumFriendlyMinionsThatAttackedThisTurn
		{
			get { return this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN]; }
			set { this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN] = value; }
		}

		public int NumFriendlyMinionsThatDiedThisTurn
		{
			get { return this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN]; }
			set { this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN] = value; }
		}

		public int NumFriendlyMinionsThatDiedThisGame
		{
			get { return this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME]; }
			set { this[EGameTag.NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME] = value; }
		}

		public int NumMinionsPlayerKilledThisTurn
		{
			get { return this[EGameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN]; }
			set { this[EGameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN] = value; }
		}

		public int TotalManaSpentThisGame
		{
			get { return this[EGameTag.NUM_RESOURCES_SPENT_THIS_GAME]; }
			set { this[EGameTag.NUM_RESOURCES_SPENT_THIS_GAME] = value; }
		}

		public int HeroPowerActivationsThisTurn
		{
			get { return this[EGameTag.HEROPOWER_ACTIVATIONS_THIS_TURN]; }
			set { this[EGameTag.HEROPOWER_ACTIVATIONS_THIS_TURN] = value; }
		}

		public int NumTimesHeroPowerUsedThisGame
		{
			get { return this[EGameTag.NUM_TIMES_HERO_POWER_USED_THIS_GAME]; }
			set { this[EGameTag.NUM_TIMES_HERO_POWER_USED_THIS_GAME] = value; }
		}

		public int NumSecretsPlayedThisGame
		{
			get { return this[EGameTag.NUM_SECRETS_PLAYED_THIS_GAME]; }
			set { this[EGameTag.NUM_SECRETS_PLAYED_THIS_GAME] = value; }
		}

		public int NumSpellsPlayedThisGame
		{
			get { return this[EGameTag.NUM_SPELLS_PLAYED_THIS_GAME]; }
			set { this[EGameTag.NUM_SPELLS_PLAYED_THIS_GAME] = value; }
		}

		public int NumWeaponsPlayedThisGame
		{
			get { return this[EGameTag.NUM_WEAPONS_PLAYED_THIS_GAME]; }
			set { this[EGameTag.NUM_WEAPONS_PLAYED_THIS_GAME] = value; }
		}

		public int NumMurlocsPlayedThisGame
		{
			get { return this[EGameTag.NUM_MURLOCS_PLAYED_THIS_GAME]; }
			set { this[EGameTag.NUM_MURLOCS_PLAYED_THIS_GAME] = value; }
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		/// <summary>
		/// Amount of turns left for this player.
		/// 
		/// This is a special tag used for the spell Time Warp, which grants 
		/// the caster an additional turn.
		/// </summary>
		public int NumTurnsLeft
		{
			get { return this[EGameTag.NUM_TURNS_LEFT]; }
			set { this[EGameTag.NUM_TURNS_LEFT] = value; }
		}

		/// <summary>
		/// Amount of mana crystals which will be locked during the next turn.
		/// </summary>
		public int OverloadOwed
		{
			get { return this[EGameTag.OVERLOAD_OWED]; }
			set { this[EGameTag.OVERLOAD_OWED] = value; }
		}

		/// <summary>
		/// Amount of mana crystals locked this turn.
		/// 
		/// The subtraction of BASE_MANA and this value gives the available
		/// resources during this turn.
		/// </summary>
		public int OverloadLocked
		{
			get { return this[EGameTag.OVERLOAD_LOCKED]; }
			set { this[EGameTag.OVERLOAD_LOCKED] = value; }
		}

		/// <summary>
		/// Sum of locked mana crystals during the entire game.
		/// </summary>
		public int OverloadThisGame
		{
			get { return this[EGameTag.OVERLOAD_THIS_GAME]; }
			set { this[EGameTag.OVERLOAD_THIS_GAME] = value; }
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public int LastCardPlayed
		{
			get { return this[EGameTag.LAST_CARD_PLAYED]; }
			set { this[EGameTag.LAST_CARD_PLAYED] = value; }
		}

		public int LastCardDrawn
		{
			get { return this[EGameTag.LAST_CARD_DRAWN]; }
			set { this[EGameTag.LAST_CARD_DRAWN] = value; }
		}

		public int LastCardDiscarded
		{
			get { return this[EGameTag.LAST_CARD_DISCARDED]; }
			set { this[EGameTag.LAST_CARD_DISCARDED] = value; }
		}

		public bool SeenCthun
		{
			get { return this[EGameTag.SEEN_CTHUN] == 1; }
			set { this[EGameTag.SEEN_CTHUN] = value ? 1 : 0; }
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		/// <summary>
		/// The entity which is a copy of the real C'Thun entity in deck.
		/// This proxy is used to display and store all buffs from rituals.
		/// The real C'Thun will mirror the proxy C'Thun.
		/// </summary>
		public int ProxyCthun
		{
			get { return this[EGameTag.PROXY_CTHUN]; }
			set { this[EGameTag.PROXY_CTHUN] = value; }
		}

		/// <summary>
		/// Returns true if for this player all battlecries should be executed another time.
		/// This is applicable when Brann BronzeBeard is in play.
		/// </summary>
		public bool ExtraBattlecry
		{
			get { return this[EGameTag.EXTRA_BATTLECRY] == 1; }
			set { this[EGameTag.EXTRA_BATTLECRY] = value ? 1 : 0; }
		}

		/// <summary>
		/// Returns true if this player automatically gets both options instead of having to
		/// choose one.
		/// This is applicable when Fandral Staghelm is in play.
		/// </summary>
		public bool ChooseBoth
		{
			get { return this[EGameTag.CHOOSE_BOTH] == 1; }
			set { this[EGameTag.CHOOSE_BOTH] = value ? 1 : 0; }
		}

		#endregion

		#region PROPERTIES

		/// <summary>
		/// Name of the player.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Available zones for this player.
		/// </summary>
		public ControlledZones Zones { get; }

		/// <summary>
		/// The deck of this player.
		/// This zone contains cards which are not yet drawn. Can be empty.
		/// </summary>
		public DeckZone Deck => (Zones[EZone.DECK] as DeckZone);

		/// <summary>
		/// The hand of this player.
		/// This zone contains cards which were drawn from deck or generated 
		/// during the game. Can be empty.
		/// </summary>
		public HandZone Hand => (Zones[EZone.HAND] as HandZone);

		/// <summary>
		/// The minions friendly to this player.
		/// This zone contains all minion entities generated by cards from the hand.
		/// Can be empty.
		/// </summary>
		public BoardZone Board => (Zones[EZone.PLAY] as BoardZone);

		/// <summary>
		/// The zone containing all entities which were once in play, but now destroyed. Can be empty.
		/// </summary>
		public GraveyardZone Graveyard => (Zones[EZone.GRAVEYARD] as GraveyardZone);

		/// <summary>
		/// The zone containing all played secrets by this player. Can be empty.
		/// </summary>
		public SecretZone Secrets => (Zones[EZone.SECRET] as SecretZone);

		/// <summary>
		/// The zone containing all entities that need to be chosen by the player.
		/// Before an option set is created, it's entities are built and stored in the this zone.
		/// The picked entity will move from that zone into the hand zone.
		/// 
		/// Unpicked entities will remain in the setaside zone.
		/// </summary>
		public SetasideZone Setaside => (Zones[EZone.SETASIDE] as SetasideZone);

		/// <summary>
		/// The hero entity representing this player.
		/// </summary>
		public Hero Hero { get; set; }

		/// <summary>
		/// The cardclass of the deck.
		/// Only neutral cards and cards specific to this class are allowed in the starting deck
		/// of the player.
		/// </summary>
		public ECardClass HeroClass => Hero.Card.Class;

		/// <summary>
		/// Maximum amount of cards in the player's hand
		/// </summary>
		public int MaxHandSize => this[EGameTag.MAXHANDSIZE];

		/// <summary>
		/// Maximum amount of mana this player is allowed to spend.
		/// </summary>
		public int MaxResources => this[EGameTag.MAXRESOURCES];

		/// <summary>
		/// All standard cards which can be put into a deck of this class.
		/// </summary>
		public IReadOnlySet<Card> Standard => Cards.StandardPerClass[HeroClass];

		/// <summary>
		/// All wild cards which can be put into a deck of this class.
		/// </summary>
		public IReadOnlySet<Card> Wild => Cards.WildPerClass[HeroClass];

		/// <summary>
		/// The amount of mana available to actually use after calculating all resource factors.
		/// </summary>
		public int RemainingMana => BaseMana + TemporaryMana - (UsedMana + OverloadLocked);

		/// <summary>
		/// Returns true if this player has a dragon in his hand.
		/// </summary>
		public bool DragonInHand => Hand.GetAll.Exists(p => p.Card.Race == ERace.DRAGON);

		/// <summary>
		/// The last choice set proposed to this player.
		/// The actual chosen entity is also stored in the Choice object.
		/// </summary>
		public Choice Choice { get; set; } = null;

		/// <summary>
		/// The opponent player instance.
		/// </summary>
		public Controller Opponent => Game.Player1 == this ? Game.Player2 : Game.Player1;

		#endregion


		/// <summary>
		/// Create a new controller instance.
		/// </summary>
		/// <param name="game">The game to which it registers.</param>
		/// <param name="name">The name of the player.</param>
		/// <param name="playerIdx">The player index; The first player will get assigned 1.</param>
		/// <param name="entityID">Entity ID of this controller.</param>
		public Controller(Game game, string name, int playerIdx, int entityID)
			: base(game, Card.CardPlayer,
			new Dictionary<EGameTag, int>
			{
				//[GameTag.HERO_ENTITY] = heroId,
				[EGameTag.MAXHANDSIZE] = 10,
				[EGameTag.STARTHANDSIZE] = 4,
				[EGameTag.PLAYER_ID] = playerIdx,
				[EGameTag.TEAM_ID] = playerIdx,
				[EGameTag.ZONE] = (int)EZone.PLAY,
				[EGameTag.CONTROLLER] = playerIdx,
				[EGameTag.ENTITY_ID] = entityID,
				[EGameTag.MAXRESOURCES] = 10,
				[EGameTag.CARDTYPE] = (int)ECardType.PLAYER

			})
		{
			Name = name;
			Zones = new ControlledZones(game, this);
			Game.Log(ELogLevel.INFO, EBlockType.PLAY, "Controller", $"Created Controller '{name}'");
		}

		/// <summary>
		/// Adds a new Hero entity and HeroPower entity to the game instance.
		/// </summary>
		/// <param name="heroCard">The card to derive the hero entity from.</param>
		/// <param name="powerCard">The heropower card to derive the hero power entity from.</param>
		public void AddHeroAndPower(Card heroCard, Card powerCard = null)
		{
			Hero = FromCard(this, heroCard) as Hero;
			HeroId = Hero.Id;
			Hero.Power = FromCard(this, powerCard ?? Cards.FromAssetId(Hero[EGameTag.HERO_POWER]),
				new Dictionary<EGameTag, int> { [EGameTag.CREATOR] = Hero.Id }) as HeroPower;
		}

		/// <summary>
		/// Copy data from the provided argument into this object.
		/// </summary>
		/// <param name="other"></param>
		public void Stamp(Controller other)
		{
			Zones.Stamp(other.Zones);
			base.Stamp(other);
			Hero = FromCard(this, other.Hero.Card, null, null, other.Hero.Id) as Hero;
			Hero.Stamp(other.Hero);
			Hero.Power = FromCard(this, other.Hero.Power.Card, null, null, other.Hero.Power.Id) as HeroPower;
			Hero.Power.Stamp(other.Hero.Power);
			if (other.Hero.Weapon != null)
			{
				Hero.Weapon =
					FromCard(this, other.Hero.Weapon.Card, null, null, other.Hero.Weapon.Id) as Weapon;
				Hero.Weapon.Stamp(other.Hero.Weapon);
			}

			if (other.Choice != null)
			{
				Choice = new Choice(this);
				Choice.Stamp(other.Choice);
			}
		}

		/// <summary>
		/// Build a unique string describing this object.
		/// </summary>
		/// <param name="ignore">All GameTags which have to be ignored during hash generation.</param>
		/// <returns>The unique hash string.</returns>
		public override string Hash(params EGameTag[] ignore)
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

		/// <summary>
		/// Returns a set of all options this player can execute for the current state of the game.
		/// From this set ONE option must be picked for execution by the game.
		/// </summary>
		/// <param name="playCards"></param>
		/// <returns></returns>
		public IReadOnlyOrderedSet<PlayerTask> Options(bool playCards = true)
		{
			var result = new OrderedHashSet<PlayerTask>();

			if (this != Game.CurrentPlayer)
				return result;

			if (Choice != null)
			{
				switch (Choice.ChoiceType)
				{
					case EChoiceType.GENERAL:
						foreach (int choice in Choice.Choices)
						{
							result.Add(ChooseTask.Pick(this, choice));
						}
						return result;

					case EChoiceType.MULLIGAN:
						IEnumerable<IReadOnlyOrderedSet<int>> choices = Util.GetPowerSet(Choice.Choices);
						foreach (IReadOnlyOrderedSet<int> choice in choices)
						{
							result.Add(ChooseTask.Mulligan(this, choice.ToList()));
						}
						return result;

					default:
						throw new NotImplementedException();
				}
			}

			// no options till mulligan is done for both players
			if (Game.Step != EStep.MAIN_ACTION)
				return result;

			// add end turn task ...
			result.Add(EndTurnTask.Any(this));

			if (playCards)
			{
				foreach (IPlayable playableCard in Hand)
				{
					var minion = playableCard as Minion;

					if (!playableCard.IsPlayableByPlayer)
						continue;

					List<IPlayable> playables = playableCard.ChooseOne && !Game.CurrentPlayer.ChooseBoth
						? playableCard.ChooseOnePlayables.ToList()
						: new List<IPlayable> { playableCard };

					foreach (IPlayable t in playables)
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
							int positions = Board.Count + 1;
							for (int j = 0; j < positions; j++)
							{
								subResult.ForEach(p =>
								{
									PlayCardTask task = p.Copy();
									task.ZonePosition = j;
									tempSubResult.Add(task);
								});
							}
							subResult = tempSubResult;
						}
						subResult.ForEach(x => result.Add(x));
					}
				}
			}

			foreach (Minion minion in Board)
			{
				if (!minion.CanAttack)
					continue;

				IEnumerable<ICharacter> targets = minion.ValidAttackTargets;
				foreach(ICharacter target in targets)
				{
					result.Add(MinionAttackTask.Any(this, minion, target));
				}
			}

			if (Hero.CanAttack)
			{
				IEnumerable<ICharacter> targets = Hero.ValidAttackTargets;
				foreach(ICharacter target in targets)
				{
					result.Add(HeroAttackTask.Any(this, target));
				}
			}

			if (Hero.Power.IsPlayable)
			{
				var targets = Hero.Power.GetValidPlayTargets().ToList();
				if (targets.Any())
				{
					foreach(ICharacter target in targets)
					{
						result.Add(HeroPowerTask.Any(this, target));
					}
				}
				else
				{
					result.Add(HeroPowerTask.Any(this));
				}
			}

			return result;
		}

		/// <summary>
		/// Returns a string which dumps information about this player.
		/// </summary>
		/// <returns></returns>
		public string FullPrint()
		{
			var str = new StringBuilder();
			str.Append($"{Name}[Mana:{RemainingMana}/{OverloadOwed}/{BaseMana}][{OverloadLocked}]");
			str.Append($"[ENCH {Enchants.Count}]");
			str.Append($"[TRIG {Triggers.Count}]");
			return str.ToString();
		}
	}
}