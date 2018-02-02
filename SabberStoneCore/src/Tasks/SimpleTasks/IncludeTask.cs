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
		HEROES,
		/// <summary>
		/// The top card from the player's deck
		/// </summary>
		TOPCARDFROMDECK,
		/// <summary>
		/// The Controller entity of the player
		/// </summary>
		CONTROLLER
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
			return boardGetAll.Except(exceptListEntities).ToList();
		}

		public static IEnumerable<IPlayable> GetEntities(EntityType type, Controller c, IEntity source,
			IEntity target, List<IPlayable> stack)
		{
			return type == EntityType.STACK ? stack : GetEntitiesInternal(type, c, source, target);
		}

		private static IEnumerable<IPlayable> GetEntitiesInternal(EntityType type, Controller c, IEntity source, IEntity target)
		{
			switch (type)
			{
				case EntityType.TARGET:
					if (source is Enchantment e)
					{
						yield return (IPlayable)e.Target;
						yield break;
					}
					if (target is IPlayable p)
						yield return p;
					yield break;
				case EntityType.SOURCE:
					yield return (IPlayable)source;
					yield break;
				case EntityType.HERO:
					yield return c.Hero;
					yield break;
				case EntityType.HERO_POWER:
					yield return c.Hero.HeroPower;
					yield break;
				case EntityType.OP_HERO_POWER:
					yield return c.Opponent.Hero.HeroPower;
					yield break;
				case EntityType.HAND:
					for (int i = c.HandZone.Count - 1; i >= 0; i--)
						yield return c.HandZone[i];
					yield break;
				case EntityType.HAND_NOSOURCE:
					for (int i = c.HandZone.Count - 1; i >= 0; i--)
					{
						if (c.HandZone[i] != source)
							yield return c.HandZone[i];
					}
					yield break;
				case EntityType.DECK:
					for (int i = c.DeckZone.Count - 1; i >= 0; i--)
						yield return c.DeckZone[i];
					break;
				case EntityType.SECRETS:
					for (int i = c.SecretZone.Count - 1; i >= 0; i--)
						yield return c.SecretZone[i];
					yield break;
				case EntityType.MINIONS:
					for (int i = c.BoardZone.Count - 1; i >= 0; i--)
						yield return c.BoardZone[i];
					yield break;
				case EntityType.MINIONS_NOSOURCE:
					for (int i = c.BoardZone.Count - 1; i >= 0; i--)
					{
						if (c.BoardZone[i] != source)
							yield return c.BoardZone[i];
					}
					break;
				case EntityType.FRIENDS:
					yield return c.Hero;
					for (int i = c.BoardZone.Count - 1; i >= 0; i--)
						yield return c.BoardZone[i];
					yield break;
				case EntityType.OP_HERO:
					yield return c.Opponent.Hero;
					yield break;
				case EntityType.OP_HAND:
					for (int i = c.Opponent.HandZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.HandZone[i];
					yield break;
				case EntityType.OP_DECK:
					for (int i = c.Opponent.DeckZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.DeckZone[i];
					yield break;
				case EntityType.OP_SECRETS:
					for (int i = c.Opponent.SecretZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.SecretZone[i];
					yield break;
				case EntityType.OP_MINIONS:
					for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.BoardZone[i];
					yield break;
				case EntityType.ENEMIES:
					yield return c.Opponent.Hero;
					for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.BoardZone[i];
					yield break;
				case EntityType.ENEMIES_NOTARGET:
					if (target is Minion)
					{
						yield return c.Opponent.Hero;
						for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						{
							IPlayable t = c.Opponent.BoardZone[i];
							if (t != target)
								yield return t;
						}
					}
					else
					{
						for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
							yield return c.Opponent.BoardZone[i];
						yield break;
					}
					yield break;
				case EntityType.ALL:
					yield return c.Hero;
					for (int i = c.BoardZone.Count - 1; i >= 0; i--)
						yield return c.BoardZone[i];
					yield return c.Opponent.Hero;
					for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.BoardZone[i];
					yield break;
				case EntityType.ALL_NOSOURCE:
					if (source.Controller == c)
					{
						if (source.Zone.Type == Enums.Zone.PLAY)
						{
							yield return c.Hero;
							for (int i = c.BoardZone.Count - 1; i >= 0; i--)
							{
								if (c.BoardZone[i] != source)
									yield return c.BoardZone[i];
							}

							yield return c.Opponent.Hero;
							for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
								yield return c.Opponent.BoardZone[i];
							yield break;
						}

						if (source is Hero)
						{
							for (int i = c.BoardZone.Count - 1; i >= 0; i--)
								yield return c.BoardZone[i];
							yield return c.Opponent.Hero;
							for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
								yield return c.Opponent.BoardZone[i];
							yield break;
						}

						yield break;
					}
					else
					{
						if (source.Zone.Type == Enums.Zone.PLAY)
						{
							yield return c.Hero;
							for (int i = c.BoardZone.Count - 1; i >= 0; i--)
								yield return c.BoardZone[i];
							yield return c.Opponent.Hero;
							for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
							{
								IPlayable t = c.Opponent.BoardZone[i];
								if (t != source)
									yield return t;
							}

							yield break;
						}

						if (source is Hero)
						{
							yield return c.Hero;
							for (int i = c.BoardZone.Count - 1; i >= 0; i--)
								yield return c.BoardZone[i];
							for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
								yield return c.Opponent.BoardZone[i];
							yield break;
						}

						yield break;
					}
				case EntityType.WEAPON:
					if (c.Hero.Weapon != null)
						yield return c.Hero.Weapon;
					yield break;
				case EntityType.OP_WEAPON:
					if (c.Opponent.Hero.Weapon != null)
						yield return c.Opponent.Hero.Weapon;
					yield break;
				case EntityType.ALLMINIONS:
					for (int i = c.BoardZone.Count - 1; i >= 0; i--)
						yield return c.BoardZone[i];
					for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						yield return c.Opponent.BoardZone[i];
					yield break;
				case EntityType.ALLMINIONS_NOSOURCE:
					if (source.Controller == c)
					{
						for (int i = c.BoardZone.Count - 1; i >= 0; i--)
						{
							if (c.BoardZone[i] != source)
								yield return c.BoardZone[i];
						}
						for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
							yield return c.Opponent.BoardZone[i];

						yield break;
					}
					else
					{
						for (int i = c.BoardZone.Count - 1; i >= 0; i--)
							yield return c.BoardZone[i];
						for (int i = c.Opponent.BoardZone.Count - 1; i >= 0; i--)
						{
							IPlayable t = c.Opponent.BoardZone[i];
							if (t != source)
								yield return t;
						}

						yield break;
					}
				case EntityType.GRAVEYARD:
					for (int i = c.GraveyardZone.Count - 1; i >= 0; i--)
						yield return c.GraveyardZone[i];
					yield break;
				case EntityType.HEROES:
					yield return c.Hero;
					yield return c.Opponent.Hero;
					yield break;
				case EntityType.TOPCARDFROMDECK:
					if (c.DeckZone.Count > 0)
						yield return c.DeckZone.TopCard;
					yield break;
				default:
					throw new NotImplementedException();
			}
		}
	}
}
