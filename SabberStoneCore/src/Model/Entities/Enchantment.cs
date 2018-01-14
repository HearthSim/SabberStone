﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Model.Entities
{
	public partial class Enchantment : IPlayable
	{
		private readonly Dictionary<GameTag, int> _tags;

		private Enchantment(Game game, Card card, Dictionary<GameTag, int> tags)
		{
			Game = game;
			Card = card;
			_tags = tags;
			Id = tags[GameTag.ENTITY_ID];

			if (card.Powers[0].Trigger != null)
				ActivatedTriggers = new List<Trigger>(1);
		}

		public int this[GameTag t]
		{
			get => _tags.TryGetValue(t, out int value) ? value : 0;
			set => _tags[t] = value;
		}

		public IEntity Target { get; private set; }

		public IPlayable Creator { get; private set; }

		public bool IsOneTurnActive => Card[GameTag.TAG_ONE_TURN_EFFECT] == 1;

		public Effect[] EffectsToBeRemoved { get; set; }

		public static Enchantment GetInstance(Controller controller, IPlayable creator, IEntity target, Card card)
		{
			var tags = new Dictionary<GameTag, int>
			{
				{GameTag.ZONE, (int) Enums.Zone.SETASIDE},
				{GameTag.CONTROLLER, controller.PlayerId},
				{GameTag.ENTITY_ID, controller.Game.NextId}
			};

			var instance = new Enchantment(controller.Game, card, tags)
			{
				Controller = controller,
				Creator = creator,
				Target = target,
			};

			if (target is IPlayable p)
				p.RemoveEnchantments += instance.Remove;

			controller.Game.IdEntityDic.Add(instance.Id, (IPlayable)instance);

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
							{GameTag.CONTROLLER, controller.PlayerId},
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

				instance[GameTag.ZONE] = (int)Enums.Zone.PLAY;
			}

			//if (instance.IsOneTurnActive)
			//	instance.Target[GameTag.TAG_ONE_TURN_EFFECT] = 1;

			instance.Zone = controller.BoardZone;
			//	323 = 1


			return instance;
		}

		public void Remove()
		{
			if (Game.History)
			{
				Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(this));
				this[GameTag.ZONE] = (int)Enums.Zone.REMOVEDFROMGAME;
			}

			//if (EffectsToBeRemoved != null)
			//{
			//	for (int i = 0; i < EffectsToBeRemoved.Length; i++)
			//		EffectsToBeRemoved[i].Remove(Target);
			//}

			if (Powers[0].DeathrattleTask != null && Target.Zone is GraveyardZone)
			{
				ISimpleTask clone = Powers[0].DeathrattleTask.Clone();
				clone.Game = Game;
				clone.Controller = Controller;
				clone.Source = Target;
				clone.Target = null;

				Game.TaskQueue.Enqueue(clone);
			}

			//OngoingEffect?.Remove();
			ActivatedTrigger?.Remove();

			if (Target is IPlayable p)
				p.RemoveEnchantments -= Remove;

			Target.AppliedEnchantments.Remove(this);
		}
		public Trigger ActivatedTrigger { get; set; }
		public AuraEffects AuraEffects { get; set; }
		public Dictionary<GameTag, int> NativeTags { get; }
		public List<Enchantment> AppliedEnchantments { get; set; }
		public Action RemoveEnchantments { get; set; }
		public List<Trigger> ActivatedTriggers { get; }
	}

	public partial class Enchantment
	{
		public int Id { get; }
		public int OrderOfPlay { get; set; }
		public Game Game { get; set; }
		public Card Card { get; }
		public Controller Controller { get; set; }
		public IZone Zone { get; set; }

		public void Reset()
		{
			_tags.Clear();
		}

		public void Stamp(Entity entity)
		{
			throw new NotImplementedException();
		}

		public string Hash(params GameTag[] ignore)
		{
			throw new NotImplementedException();
		}

		public List<OldEnchant> OldEnchants { get; }
		public IAura OngoingEffect { get; set; }
		public List<OldTrigger> Triggers { get; }
		public IEnumerable<ICharacter> ValidPlayTargets { get; }
		public bool IsValidPlayTarget(ICharacter target)
		{
			throw new NotImplementedException();
		}

		public bool ChooseOne { get; set; }
		public bool IsPlayable { get; }
		public bool IsPlayableByPlayer { get; }
		public bool IsPlayableByCardReq { get; }
		public bool IsIgnoreDamage { get; set; }
		public bool Combo { get; }
		public int Cost { get; set; }
		public int NumTurnsInPlay { get; set; }
		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public bool ToBeDestroyed { get; set; }

		public int CardTarget { get; set; }
		public int ZonePosition { get; set; }
		public bool JustPlayed { get; set; }
		public bool IsSummoned { get; set; }
		public bool IsExhausted { get; set; }
		public int Overload { get; set; }
		public bool HasDeathrattle { get; set; }
		public bool HasLifeSteal { get; set; }
		public IPlayable[] ChooseOnePlayables { get; set; }

		public List<Power> Powers
		{
			get => Card.Powers;
			set
			{
				return;
			}
		}
		public IPlayable Clone(Controller controller)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<GameTag, int>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
