using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model.Entities
{
	public class Enchantment : IPlayable
	{
		public Controller Controller;

		public Card Card;

		public int Id;

		public List<Enchant> Enchants;

		public Game Game;

		public bool IsOneTurnActive;

		public IPlayable Target { get; private set; }

		public IPlayable Creator { get; private set; }

		public Enchantment(Game game, Card card, Dictionary<GameTag, int> tags) : base(game, card, tags)
		{
			IsOneTurnActive = card[GameTag.TAG_ONE_TURN_EFFECT] == 1;
		}

		public static Enchantment GetInstance(Controller controller, IPlayable creator, IPlayable target, Card card)
		{
			var tags = new Dictionary<GameTag, int>
			{
				{GameTag.ZONE, (int) Enums.Zone.SETASIDE},
				{GameTag.CONTROLLER, controller.Id},
				{GameTag.ENTITY_ID, controller.Game.NextId}
			};

			var instance = new Enchantment(controller.Game, card, tags)
			{
				Controller = controller,
				Creator = creator,
				Target = target
			};

			controller.Game.IdEntityDic.Add(instance.Id, instance);

			if (controller.Game.History)
			{
				controller.Game.PowerHistory.Add(new PowerHistoryFullEntity
				{
					Entity = new PowerHistoryEntity
					{
						Id = instance.Id,
						Tags = tags
					}
				});

				controller.Game.PowerHistory.Add(new PowerHistoryShowEntity
				{
					Entity = new PowerHistoryEntity
					{
						Id = instance.Id,
						Name = instance.Card.Name,
						Tags = new Dictionary<GameTag, int>
						{
							{GameTag.CONTROLLER, controller.Id},
							{GameTag.CARDTYPE, (int) CardType.ENCHANTMENT},
							{GameTag.PREMIUM, creator[GameTag.PREMIUM]},
							{GameTag.ATTACHED, target.Id},
							{GameTag.DAMAGE, 0},
							{GameTag.ZONE, (int) Enums.Zone.SETASIDE},
							{GameTag.ENTITY_ID, instance.Id},
							{GameTag.SILENCE, 0},
							{GameTag.WINDFURY, 0},
							{GameTag.TAUNT, 0},
							{GameTag.STEALTH, 0},
							{GameTag.DIVINE_SHIELD, 0},
							{GameTag.CHARGE, 0},
							{GameTag.FROZEN, 0},
							{GameTag.ZONE_POSITION, 0},
							{GameTag.NUM_ATTACKS_THIS_TURN, 0},
							{GameTag.CREATOR, creator.Id},
							{GameTag.FORCED_PLAY, 0},
							{GameTag.TO_BE_DESTROYED, 0},
							{GameTag.POISONOUS, 0},
							{GameTag.CUSTOM_KEYWORD_EFFECT, 0},
							{GameTag.EXTRA_ATTACKS_THIS_TURN, 0},
							{GameTag.TAG_LAST_KNOWN_ATK_IN_HAND, 0},
							//	479
							{GameTag.LIFESTEAL, 0}
						}
					}
				});
			}

			instance[GameTag.ZONE] = (int)Enums.Zone.PLAY;
			//	323 = 1

			return instance;
		}

		public void Remove()
		{

		}

		public IEnumerable<ICharacter> ValidPlayTargets { get; }
		public bool IsValidPlayTarget(ICharacter target)
		{
			throw new NotImplementedException();
		}

		public bool IsPlayable { get; }
		public bool IsPlayableByPlayer { get; }
		public bool IsPlayableByCardReq { get; }
		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public void ApplyPowers(PowerActivation activation, Zone zoneType, IPlayable target = null)
		{
			throw new NotImplementedException();
		}

		public int ZonePosition { get; set; }
		public bool JustPlayed { get; set; }
		public bool IsSummoned { get; set; }
		public bool IsExhausted { get; set; }
		public int Overload { get; set; }
		public bool HasDeathrattle { get; set; }
		public bool HasLifeSteal { get; set; }
		public IPlayable[] ChooseOnePlayables { get; set; }
		public List<Power> Powers { get; set; }
		public IPlayable Clone(Controller controller)
		{
			throw new NotImplementedException();
		}
	}
}
