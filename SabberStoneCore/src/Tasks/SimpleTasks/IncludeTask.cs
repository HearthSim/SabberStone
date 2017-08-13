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
		/// <summary>
		///  All cards in the player's hand except the source
		/// </summary>
		HAND_NOSOURCE,
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
		HEROES
	}

	public class IncludeTask : SimpleTask
	{
		public EntityType IncludeType { get; set; }
		public EntityType[] ExcludeTypeArray { get; set; }
		public bool AddFlag { get; set; }

		public IncludeTask(EntityType includeType, EntityType[] excludeTypeArray = null, bool addFlag = false)
		{
			IncludeType = includeType;
			ExcludeTypeArray = excludeTypeArray;
			AddFlag = addFlag;
		}

		private List<IPlayable> RemoveEntities(List<IPlayable> boardGetAll, IEnumerable<EntityType> exceptArray)
		{
			if (exceptArray == null)
			{
				return boardGetAll;
			}
			var exceptListEntities = new List<IPlayable>();
			foreach (var excludeType in exceptArray)
			{
				exceptListEntities.AddRange(GetEntites(excludeType, Controller, Source, Target, Playables));
			}
			return boardGetAll.Except(exceptListEntities).ToList();
		}

		public static List<IPlayable> GetEntites(EntityType type, Controller controller, IEntity source, IEntity target, List<IPlayable> stack)
		{
			var result = new List<IPlayable>();

			switch (type)
			{
				case EntityType.STACK:
					result = stack;
					break;

				case EntityType.TARGET:
					var t = target as IPlayable;
					if (t != null)
					{
						result.Add(t);
					}
					break;

				case EntityType.SOURCE:
					var s = source as IPlayable;
					if (s != null)
					{
						result.Add(s);
					}
					break;

				case EntityType.HERO:
					result.Add(controller.Hero);
					break;

				case EntityType.HEROES:
					result.Add(controller.Hero);
					result.Add(controller.Opponent.Hero);
					break;

				case EntityType.HERO_POWER:
					result.Add(controller.Hero.Power);
					break;

				case EntityType.OP_HERO_POWER:
					result.Add(controller.Opponent.Hero.Power);
					break;

				case EntityType.WEAPON:
					if (controller.Hero.Weapon != null)
					{
						result.Add(controller.Hero.Weapon);
					}
					break;

				case EntityType.HAND:
					result.AddRange(controller.HandZone.GetAll);
					break;

				case EntityType.HAND_NOSOURCE:
					result.AddRange(controller.HandZone.GetAll);
					result.Remove(source as IPlayable);
					break;

				case EntityType.DECK:
					result.AddRange(controller.DeckZone.GetAll);
					break;

				case EntityType.MINIONS:
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					break;

				case EntityType.MINIONS_NOSOURCE:
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					result.Remove(source as IPlayable);
					break;

				case EntityType.GRAVEYARD:
					if (controller.GraveyardZone.Count > 0)
					{
						result.AddRange(controller.GraveyardZone.GetAll);
					}
					break;

				case EntityType.FRIENDS:
					result.Add(controller.Hero);
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					break;

				case EntityType.OP_HERO:
					result.Add(controller.Opponent.Hero);
					break;

				case EntityType.OP_WEAPON:
					if (controller.Opponent.Hero.Weapon != null)
					{
						result.Add(controller.Opponent.Hero.Weapon);
					}
					break;

				case EntityType.OP_HAND:
					result.AddRange(controller.Opponent.HandZone.GetAll);
					break;

				case EntityType.OP_DECK:
					result.AddRange(controller.Opponent.DeckZone.GetAll);
					break;

				case EntityType.OP_MINIONS:
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					break;

				case EntityType.OP_SECRETS:
					if (controller.Opponent.SecretZone.Count > 0)
					{
						result.AddRange(controller.Opponent.SecretZone.GetAll);
					}
					break;

				case EntityType.ENEMIES:
					result.Add(controller.Opponent.Hero);
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					break;

				case EntityType.ENEMIES_NOTARGET:
					result.Add(controller.Opponent.Hero);
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					result.Remove(target as IPlayable);
					break;

				case EntityType.ALL:
					result.Add(controller.Hero);
					result.Add(controller.Opponent.Hero);
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					break;

				case EntityType.ALL_NOSOURCE:
					result.Add(controller.Hero);
					result.Add(controller.Opponent.Hero);
					if (controller.Opponent.BoardZone.Count > 0)
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					if (controller.BoardZone.Count > 0)
						result.AddRange(controller.BoardZone.GetAll);
					result.Remove(source as IPlayable);
					break;

				case EntityType.ALLMINIONS:
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					break;

				case EntityType.ALLMINIONS_NOSOURCE:
					if (controller.Opponent.BoardZone.Count > 0)
					{
						result.AddRange(controller.Opponent.BoardZone.GetAll);
					}
					if (controller.BoardZone.Count > 0)
					{
						result.AddRange(controller.BoardZone.GetAll);
					}
					result.Remove(source as IPlayable);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
			return result;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (AddFlag)
			{
				Playables.AddRange(RemoveEntities(GetEntites(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray));
			}
			else
			{
				Playables = RemoveEntities(GetEntites(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray);
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new IncludeTask(IncludeType, ExcludeTypeArray, AddFlag);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}