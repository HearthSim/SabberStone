using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Model.Entities
{
	public partial class Enchantment : IPlayable
	{
		private readonly IDictionary<GameTag, int> _tags;

		private Enchantment(Controller controller, Card card, IDictionary<GameTag, int> tags)
		{
			Game = controller.Game;
			Controller = controller;
			Card = card;
			_tags = tags;
			Id = tags[GameTag.ENTITY_ID];
		}

		private Enchantment(Controller c, Enchantment e)
		{
			Game = c.Game;
			Controller = c;
			Card = e.Card;
			Id = e.Id;
			Target = e.Target is IPlayable ? (IEntity) Game.IdEntityDic[e.Target.Id] : c;
			Creator = Game.IdEntityDic[e.Creator.Id];
			e.OngoingEffect?.Clone(this);
			e.ActivatedTrigger?.Activate(this);
			Game.IdEntityDic.Add(Id, this);

			if (c.Game.History)
			{
				Zone = c.BoardZone;
				_tags = new EntityData.Data((EntityData.Data) e._tags);
			}
		}

		public int this[GameTag t]
		{
			get => _tags.TryGetValue(t, out int value) ? value : 0;
			set => _tags[t] = value;
		}

		public IEntity Target { get; private set; }

		public IPlayable Creator { get; private set; }

		public bool IsOneTurnActive => Card[GameTag.TAG_ONE_TURN_EFFECT] == 1;

		/// <summary>
		/// Creates and adds a new Enchantment entity to the given Controller's Game.
		/// </summary>
		/// <param name="controller">The controller of the enchantment.</param>
		/// <param name="creator">The entity who creates the enchantment.</param>
		/// <param name="target">The entity who is subjected to the enchantment.</param>
		/// <param name="card">The card from which the enchantment must be derived.</param>
		/// <returns>The resulting enchantment entity.</returns>
		public static Enchantment GetInstance(Controller controller, IPlayable creator, IEntity target, Card card)
		{
			var tags = new EntityData.Data
			{
				{GameTag.ZONE, (int) Enums.Zone.SETASIDE},
				{GameTag.CONTROLLER, controller.PlayerId},
				{GameTag.ENTITY_ID, controller.Game.NextId}
			};

			var instance = new Enchantment(controller, card, tags)
			{
				Creator = creator,
				Target = target,
			};

			if (target is IPlayable p)
				p.RemoveEnchantments += instance.Remove;

			if (target.AppliedEnchantments == null)
				target.AppliedEnchantments = new List<Enchantment> {instance};
			else
				target.AppliedEnchantments.Add(instance);

			controller.Game.IdEntityDic.Add(instance.Id, (IPlayable)instance);

			if (controller.Game.History)
			{
				controller.Game.PowerHistory.Add(new PowerHistoryFullEntity
				{
					Entity = new PowerHistoryEntity
					{
						Id = instance.Id,
						Tags = tags.ToDictionary(k => k.Key, k => k.Value)
					}
				});

				if (!(target.Zone is DeckZone))
				{
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
				}
				
				instance[GameTag.ZONE] = (int)Enums.Zone.PLAY;
			}

			//if (instance.IsOneTurnActive)
			//	instance.Target[GameTag.TAG_ONE_TURN_EFFECT] = 1;

			instance.Zone = controller.BoardZone;
			instance.OrderOfPlay = controller.Game.NextOop;
			//	323 = 1

			if (card.Power.DeathrattleTask != null)
				((IPlayable)target).HasDeathrattle = true;

			controller.Game.Log(LogLevel.VERBOSE, BlockType.ACTION, "Enchantment",
				!controller.Game.Logging ? "" : $"Enchantment {card} created by {creator} is added to {target}.");

			return instance;
		}

		public IPlayable Clone(Controller controller)
		{
			return new Enchantment(controller, this);
		}

		public void Remove()
		{
			if (Game.History)
			{
				Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(this));
				this[GameTag.ZONE] = (int)Enums.Zone.REMOVEDFROMGAME;
			}

			if (Power.DeathrattleTask != null && Target.Zone is GraveyardZone)
			{
				ISimpleTask clone = Power.DeathrattleTask.Clone();
				clone.Game = Game;
				clone.Controller = Controller;
				clone.Source = Target;
				clone.Target = null;

				Game.TaskQueue.Enqueue(clone);
			}

			OngoingEffect?.Remove();
			ActivatedTrigger?.Remove();


			if (Target is IPlayable p)
				p.RemoveEnchantments -= Remove;

			Target.AppliedEnchantments.Remove(this);

			Game.Log(LogLevel.VERBOSE, BlockType.ACTION, "Enchantment",
				!Game.Logging ? "" : $"Enchantment {this} is removed from {Target}.");
		}

		public Power Power => Card.Power;
		public Action RemoveEnchantments { get; set; }
		public Trigger ActivatedTrigger { get; set; }

		public void Reset()
		{
			_tags.Clear();
		}

		public override string ToString()
		{
			return $"'{Card.Name}[{Id}]'";
		}
	}

	public partial class Enchantment
	{
		public int Id { get; }
		public int OrderOfPlay { get; set; }
		public Game Game { get; set; }
		public Card Card { get; }
		public Controller Controller { get; set; }
		public IZone Zone { get; set; }
		public IAura OngoingEffect { get; set; }
		public IEnumerable<ICharacter> ValidPlayTargets { get; }
		public bool ChooseOne { get; set; }
		public bool IsPlayable { get; }
		public bool IsPlayableByPlayer { get; }
		public bool IsPlayableByCardReq { get; }
		public bool IsIgnoreDamage { get; set; }
		public bool Combo { get; }
		public int Cost { get; set; }
		public int NumTurnsInPlay { get; set; }
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
		public AuraEffects AuraEffects { get; set; }
		public IDictionary<GameTag, int> NativeTags { get; }
		public List<Enchantment> AppliedEnchantments { get; set; }

		public void Stamp(Entity entity)
		{
			throw new NotImplementedException();
		}

		public string Hash(params GameTag[] ignore)
		{
			throw new NotImplementedException();
		}

		public bool IsValidPlayTarget(ICharacter target)
		{
			throw new NotImplementedException();
		}

		public void Destroy()
		{
			throw new NotImplementedException();
		}

		public void ActivateTask(PowerActivation activation, IPlayable target = null, int chooseOne = 0, IPlayable source = null)
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
