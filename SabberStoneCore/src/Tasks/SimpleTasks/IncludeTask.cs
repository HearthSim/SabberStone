using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public enum EntityType
	{
		/// <summary>
		///  The target
		/// </summary>
		TARGET,
		/// <summary>
		///  The source
		/// </summary>
		SOURCE,
		/// <summary>
		///  Player's hero
		/// </summary>
		HERO,
		/// <summary>
		///  Player's hero power
		/// </summary>
		HERO_POWER,
		/// <summary>
		///  Opponent's hero power
		/// </summary>
		OP_HERO_POWER,
		/// <summary>
		///  All cards in the player's hand
		/// </summary>
		HAND,
		///// <summary>
		/////  All cards in the player's hand except the source
		///// </summary>
		//HAND_NOSOURCE,
		/// <summary>
		///  All cards in the player's deck
		/// </summary>
		DECK,
		/// <summary>
		///  Player's secrets
		/// </summary>
		SECRETS,
		/// <summary>
		///  Player's minions
		/// </summary>
		MINIONS,
		/// <summary>
		///  Player's minions except the source
		/// </summary>
		MINIONS_NOSOURCE,
		/// <summary>
		///  All friends characters
		/// </summary>
		FRIENDS,
		/// <summary>
		///  Opponent's Hero
		/// </summary>
		OP_HERO,
		/// <summary>
		///  All cards in the opponent's hand
		/// </summary>
		OP_HAND,
		/// <summary>
		///  All cards in the opponent's deck
		/// </summary>
		OP_DECK,
		/// <summary>
		///  All opponent secret
		/// </summary>
		OP_SECRETS,
		/// <summary>
		///  All opponent minion
		/// </summary>
		OP_MINIONS,
		/// <summary>
		///  All opponent character
		/// </summary>
		ENEMIES,
		/// <summary>
		///  All opponent character except the source
		/// </summary>
		ENEMIES_NOTARGET,
		/// <summary>
		///  All characters
		/// </summary>
		ALL,
		/// <summary>
		///  All characters except the source
		/// </summary>
		ALL_NOSOURCE,
		/// <summary>
		///  Player's weapon
		/// </summary>
		WEAPON,
		/// <summary>
		///  Opponent's weapon
		/// </summary>
		OP_WEAPON,
		/// <summary>
		///  All cards on the stack
		/// </summary>
		STACK,
		/// <summary>
		///  All minions
		/// </summary>
		ALLMINIONS,
		/// <summary>
		///  Invalid
		/// </summary>
		INVALID,
		/// <summary>
		///  All minions except the source
		/// </summary>
		ALLMINIONS_NOSOURCE,
		/// <summary>
		///  All cards in the graveyard
		/// </summary>
		GRAVEYARD,
		/// <summary>
		///  All heroes
		/// </summary>
		HEROES,
		/// <summary>
		/// The top card from the player's deck
		/// </summary>
		TOPCARDFROMDECK,
		/// <summary>
		/// The top card from the opponent's deck
		/// </summary>
		OP_TOPDECK,
		/// <summary>
		/// The Controller entity of the player
		/// </summary>
		CONTROLLER,
		/// <summary>
		/// The Target of the current event. (e.g. the defender, the target of a spell, or the just damaged or healed character)
		/// </summary>
		EVENT_TARGET,
		/// <summary>
		/// The Source of the current event. (e.g. the attacker, the played card, or the just damaging or healing entity)
		/// </summary>
		EVENT_SOURCE
	}

	public class IncludeTask : SimpleTask
	{
		public IncludeTask(EntityType includeType, EntityType[] excludeTypeArray = null, bool addFlag = false)
		{
			IncludeType = includeType;
			ExcludeTypeArray = excludeTypeArray;
			AddFlag = addFlag;
		}

		public EntityType IncludeType { get; set; }
		public EntityType[] ExcludeTypeArray { get; set; }
		public bool AddFlag { get; set; }

		public override TaskState Process()
		{
			if (AddFlag)
			{
				Playables.AddRange(RemoveEntities(GetEntities(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray));
			}
			else
			{
				Playables = RemoveEntities(GetEntities(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray).ToList();
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new IncludeTask(IncludeType, ExcludeTypeArray, AddFlag);
			clone.Copy(this);
			return clone;
		}

		private IEnumerable<IPlayable> RemoveEntities(IEnumerable<IPlayable> boardGetAll, IEnumerable<EntityType> exceptArray)
		{
			if (exceptArray == null)
			{
				return boardGetAll;
			}
			var exceptListEntities = new List<IPlayable>();
			foreach (EntityType excludeType in exceptArray)
			{
				exceptListEntities.AddRange(GetEntities(excludeType, Controller, Source, Target, Playables));
			}
			return boardGetAll.Except(exceptListEntities);
		}

		public static IList<IPlayable> GetEntities(EntityType type, Controller c, IEntity source,
			IEntity target, List<IPlayable> stack)
		{
			switch (type)
			{
				case EntityType.STACK:
					return stack;
				case EntityType.HAND:
					return c.HandZone.GetAll();
				case EntityType.DECK:
					return c.DeckZone.GetAll();
				case EntityType.MINIONS:
					return c.BoardZone.GetAll();
				case EntityType.SECRETS:
					return c.SecretZone.GetAll();
				case EntityType.GRAVEYARD:
					return c.GraveyardZone.ToArray();
				case EntityType.OP_HAND:
					return c.Opponent.HandZone.GetAll();
				case EntityType.OP_DECK:
					return c.Opponent.DeckZone.GetAll();
				case EntityType.OP_MINIONS:
					return c.Opponent.BoardZone.GetAll();
				case EntityType.OP_SECRETS:
					return c.Opponent.SecretZone.GetAll();

				case EntityType.MINIONS_NOSOURCE:
					return c.BoardZone.GetAll(p => p != source);
				case EntityType.ALLMINIONS_NOSOURCE:
				{
					if (source.Controller == c)
					{
						Minion[] board = c.BoardZone.GetAll(p => p != source);
						Minion[] array = new Minion[board.Length + c.Opponent.BoardZone.CountExceptUntouchables];
						board.CopyTo(array, 0);
						c.Opponent.BoardZone.CopyTo(array, board.Length);
						return array;
					}
					else
					{
						Minion[] board = c.Opponent.BoardZone.GetAll(p => p != source);
						Minion[] array = new Minion[board.Length + c.BoardZone.CountExceptUntouchables];
						board.CopyTo(array, 0);
						c.BoardZone.CopyTo(array, board.Length);
						return array;
					}
				}
				case EntityType.ENEMIES:
				{
					var arr = new ICharacter[c.Opponent.BoardZone.CountExceptUntouchables + 1];
					arr[0] = c.Opponent.Hero;
					c.Opponent.BoardZone.CopyTo(arr, 1);
					return arr;
				}
				case EntityType.TARGET:
					return target == null ? new IPlayable[0] : new [] {(IPlayable)target};
				case EntityType.SOURCE:
					return new[] {(IPlayable)source};
				case EntityType.HERO:
					return new[] {c.Hero};
				case EntityType.HERO_POWER:
					return new[] {c.Hero.HeroPower};
				case EntityType.OP_HERO_POWER:
					return new[] {c.Opponent.Hero.HeroPower};
				case EntityType.FRIENDS:
				{
					var arr = new ICharacter[c.BoardZone.CountExceptUntouchables + 1];
					arr[0] = c.Hero;
					c.BoardZone.CopyTo(arr, 1);
					return arr;
				}
				case EntityType.OP_HERO:
					return new[] {c.Opponent.Hero};
				case EntityType.ENEMIES_NOTARGET:
					if (target is Hero)
						return c.Opponent.BoardZone.GetAll();
					else
					{
						if (c.Opponent.BoardZone.CountExceptUntouchables > 1)
						{
							var arr = new ICharacter[c.Opponent.BoardZone.CountExceptUntouchables];
							arr[0] = c.Opponent.Hero;
							Minion[] temp = c.Opponent.BoardZone.GetAll(p => p != target);
							Array.Copy(temp, 0, arr, 1, temp.Length);
							return arr;
						}

						return new[] {c.Opponent.Hero};
					}
				case EntityType.ALL:
				{
					var arr = new IPlayable[c.BoardZone.CountExceptUntouchables + c.Opponent.BoardZone.CountExceptUntouchables + 2];
					c.BoardZone.CopyTo(arr, 0);
					c.Opponent.BoardZone.CopyTo(arr, c.BoardZone.CountExceptUntouchables);
					arr[arr.Length - 2] = c.Hero;
					arr[arr.Length - 1] = c.Opponent.Hero;
					return arr;
				}
				case EntityType.ALL_NOSOURCE:
				{
					if (source.Zone == null) throw new NotImplementedException();

					var arr = new IPlayable[c.BoardZone.CountExceptUntouchables + c.Opponent.BoardZone.CountExceptUntouchables + 1];
					if (source.Zone == c.BoardZone)
					{
						c.BoardZone.GetAll(p => p != source).CopyTo(arr, 0);
						c.Opponent.BoardZone.CopyTo(arr, c.BoardZone.CountExceptUntouchables - 1);
						arr[arr.Length - 2] = c.Hero;
						arr[arr.Length - 1] = c.Opponent.Hero;
					}
					else if (source.Zone == c.Opponent.BoardZone)
					{
						c.BoardZone.CopyTo(arr, 0);
						c.Opponent.BoardZone.GetAll(p => p != source).CopyTo(arr, c.BoardZone.CountExceptUntouchables);
						arr[arr.Length - 2] = c.Hero;
						arr[arr.Length - 1] = c.Opponent.Hero;
					}
					else
					{
						c.BoardZone.CopyTo(arr, 0);
						c.Opponent.BoardZone.CopyTo(arr, c.BoardZone.CountExceptUntouchables);
						arr[arr.Length - 2] = c.Hero;
						arr[arr.Length - 1] = c.Opponent.Hero;
					}
					return arr;
				}
				case EntityType.WEAPON:
					return c.Hero.Weapon == null ? new IPlayable[0] : new[] {c.Hero.Weapon};
				case EntityType.OP_WEAPON:
					return c.Opponent.Hero.Weapon == null ? new IPlayable[0] : new[] {c.Opponent.Hero.Weapon};
				case EntityType.ALLMINIONS:
				{
					var arr = new Minion[c.BoardZone.CountExceptUntouchables + c.Opponent.BoardZone.CountExceptUntouchables];
					c.BoardZone.CopyTo(arr, 0);
					c.Opponent.BoardZone.CopyTo(arr, c.BoardZone.CountExceptUntouchables);
					return arr;
				}
				case EntityType.HEROES:
					return new[] {c.Hero, c.Opponent.Hero};
				case EntityType.TOPCARDFROMDECK:
					return c.DeckZone.Count > 0 ? new[] {c.DeckZone.TopCard} : new IPlayable[0];
				case EntityType.OP_TOPDECK:
					return c.Opponent.DeckZone.Count > 0 ? new[] {c.Opponent.DeckZone.TopCard} : new IPlayable[0];
				case EntityType.EVENT_SOURCE:
					return c.Game.CurrentEventData != null ? new[] {c.Game.CurrentEventData.EventSource} : new IPlayable[0];
				case EntityType.EVENT_TARGET:
					return c.Game.CurrentEventData != null ? new[] { c.Game.CurrentEventData.EventTarget} : new IPlayable[0];
				default:
					throw new NotImplementedException();
			}
		}
	}
}
