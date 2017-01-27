using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public enum EntityType
    {
        TARGET,
        SOURCE,

        HERO,
        HERO_POWER,
        HAND,
        HAND_NOSOURCE,
        DECK,
        SECRETS,
        MINIONS,
        MINIONS_NOSOURCE,
        FRIENDS,

        OP_HERO,
        OP_HAND,
        OP_DECK,
        OP_SECRETS,
        OP_MINIONS,
        ENEMIES,
        ENEMIES_NOTARGET,
        ALL,
        ALL_NOSOURCE,

        WEAPON,
        OP_WEAPON,
        STACK,
        ALLMINIONS,

        INVALID,
        ALLMINIONS_NOSOURCE,
        GRAVEYARD,
    }

    public class IncludeTask : SimpleTask
    {
        public IncludeTask(EntityType includeType, EntityType[] excludeTypeArray = null)
        {
            IncludeType = includeType;
            ExcludeTypeArray = excludeTypeArray;
        }

        public EntityType IncludeType { get; set; }

        public EntityType[] ExcludeTypeArray { get; set; }

        public override TaskState Process()
        {
            Playables = RemoveEntities(GetEntites(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray);
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new IncludeTask(IncludeType, ExcludeTypeArray);
            clone.Copy(this);
            return clone;
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

        public static List<IPlayable> GetEntites(EntityType type, Controller controller, IEntity source, IEntity target, List<IPlayable> stack )
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

                case EntityType.HERO_POWER:
                    result.Add(controller.Hero.Power);
                    break;

                case EntityType.WEAPON:
                    if (controller.Hero.Weapon != null)
                    {
                        result.Add(controller.Hero.Weapon);
                    }
                    break;

                case EntityType.HAND:
                    result.AddRange(controller.Hand.GetAll);
                    break;

                case EntityType.HAND_NOSOURCE:
                    result.AddRange(controller.Hand.GetAll);
                    result.Remove(source as IPlayable);
                    break;

                case EntityType.DECK:
                    result.AddRange(controller.Deck.GetAll);
                    break;

                case EntityType.SECRETS:
                    if (controller.Secrets.Count > 0)
                    {
                        result.AddRange(controller.Secrets.GetAll);
                    }                  
                    break;

                case EntityType.MINIONS:
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EntityType.MINIONS_NOSOURCE:
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    result.Remove(source as IPlayable);
                    break;

                case EntityType.GRAVEYARD:
                    if (controller.Graveyard.Count > 0)
                    {
                        result.AddRange(controller.Graveyard.GetAll);
                    }
                    break;

                case EntityType.FRIENDS:
                    result.Add(controller.Hero);
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
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
                    result.AddRange(controller.Opponent.Hand.GetAll);
                    break;

                case EntityType.OP_DECK:
                    result.AddRange(controller.Opponent.Deck.GetAll);
                    break;

                case EntityType.OP_MINIONS:
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    break;

                case EntityType.OP_SECRETS:
                    if (controller.Opponent.Secrets.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Secrets.GetAll);
                    }
                    break;

                case EntityType.ENEMIES:
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    break;

                case EntityType.ENEMIES_NOTARGET:
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    result.Remove(target as IPlayable);
                    break;

                case EntityType.ALL:
                    result.Add(controller.Hero);
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EntityType.ALL_NOSOURCE:
                    result.Add(controller.Hero);
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                        result.AddRange(controller.Opponent.Board.GetAll);
                    if (controller.Board.Count > 0)
                        result.AddRange(controller.Board.GetAll);
                    result.Remove(source as IPlayable);
                    break;

                case EntityType.ALLMINIONS:
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EntityType.ALLMINIONS_NOSOURCE:
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    result.Remove(source as IPlayable);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            return result;
        }
    }
}