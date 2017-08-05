using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class IncludeTask : SimpleTask
    {
        public IncludeTask(EEntityType includeType, EEntityType[] excludeTypeArray = null, bool addFlag = false)
        {
            IncludeType = includeType;
            ExcludeTypeArray = excludeTypeArray;
            AddFlag = addFlag;
        }

        public EEntityType IncludeType { get; set; }
        public EEntityType[] ExcludeTypeArray { get; set; }
        public bool AddFlag { get; set; }

        public override ETaskState Process()
        {
            if (AddFlag)
            {
                Playables.AddRange(RemoveEntities(GetEntites(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray));
            }
            else
            {
                Playables = RemoveEntities(GetEntites(IncludeType, Controller, Source, Target, Playables), ExcludeTypeArray);
            }
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new IncludeTask(IncludeType, ExcludeTypeArray, AddFlag);
            clone.Copy(this);
            return clone;
        }

        private List<IPlayable> RemoveEntities(List<IPlayable> boardGetAll, IEnumerable<EEntityType> exceptArray)
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

        public static List<IPlayable> GetEntites(EEntityType type, Controller controller, IEntity source, IEntity target, List<IPlayable> stack )
        {
            var result = new List<IPlayable>();

            switch (type)
            {
                case EEntityType.STACK:
                    result = stack;
                    break;

                case EEntityType.TARGET:
                    var t = target as IPlayable;
                    if (t != null)
                    {
                        result.Add(t);
                    }
                    break;

                case EEntityType.SOURCE:
                    var s = source as IPlayable;
                    if (s != null)
                    {
                        result.Add(s);
                    }
                    break;

                case EEntityType.HERO:
                    result.Add(controller.Hero);
                    break;

                case EEntityType.HEROES:
                    result.Add(controller.Hero);
                    result.Add(controller.Opponent.Hero);
                    break;

                case EEntityType.HERO_POWER:
                    result.Add(controller.Hero.Power);
                    break;

                case EEntityType.OP_HERO_POWER:
                    result.Add(controller.Opponent.Hero.Power);
                    break;

                case EEntityType.WEAPON:
                    if (controller.Hero.Weapon != null)
                    {
                        result.Add(controller.Hero.Weapon);
                    }
                    break;

                case EEntityType.HAND:
                    result.AddRange(controller.Hand.GetAll);
                    break;

                case EEntityType.HAND_NOSOURCE:
                    result.AddRange(controller.Hand.GetAll);
                    result.Remove(source as IPlayable);
                    break;

                case EEntityType.DECK:
                    result.AddRange(controller.Deck.GetAll);
                    break;

                case EEntityType.MINIONS:
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EEntityType.MINIONS_NOSOURCE:
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    result.Remove(source as IPlayable);
                    break;

                case EEntityType.GRAVEYARD:
                    if (controller.Graveyard.Count > 0)
                    {
                        result.AddRange(controller.Graveyard.GetAll);
                    }
                    break;

                case EEntityType.FRIENDS:
                    result.Add(controller.Hero);
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EEntityType.OP_HERO:
                    result.Add(controller.Opponent.Hero);
                    break;

                case EEntityType.OP_WEAPON:
                    if (controller.Opponent.Hero.Weapon != null)
                    {
                        result.Add(controller.Opponent.Hero.Weapon);
                    }
                    break;

                case EEntityType.OP_HAND:
                    result.AddRange(controller.Opponent.Hand.GetAll);
                    break;

                case EEntityType.OP_DECK:
                    result.AddRange(controller.Opponent.Deck.GetAll);
                    break;

                case EEntityType.OP_MINIONS:
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    break;

                case EEntityType.OP_SECRETS:
                    if (controller.Opponent.Secrets.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Secrets.GetAll);
                    }
                    break;

                case EEntityType.ENEMIES:
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    break;

                case EEntityType.ENEMIES_NOTARGET:
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    result.Remove(target as IPlayable);
                    break;

                case EEntityType.ALL:
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

                case EEntityType.ALL_NOSOURCE:
                    result.Add(controller.Hero);
                    result.Add(controller.Opponent.Hero);
                    if (controller.Opponent.Board.Count > 0)
                        result.AddRange(controller.Opponent.Board.GetAll);
                    if (controller.Board.Count > 0)
                        result.AddRange(controller.Board.GetAll);
                    result.Remove(source as IPlayable);
                    break;

                case EEntityType.ALLMINIONS:
                    if (controller.Opponent.Board.Count > 0)
                    {
                        result.AddRange(controller.Opponent.Board.GetAll);
                    }
                    if (controller.Board.Count > 0)
                    {
                        result.AddRange(controller.Board.GetAll);
                    }
                    break;

                case EEntityType.ALLMINIONS_NOSOURCE:
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