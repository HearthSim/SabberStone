﻿using System;
using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class CopyTask : SimpleTask
    {
        public CopyTask(EntityType type, int amount)
        {
            Type = type;
            Amount = amount;
        }

        public EntityType Type { get; set; }

        public int Amount { get; set; }

        public override TaskState Process()
        {
            var result = new List<IPlayable>();
            switch (Type)
            {
                case EntityType.TARGET:
                    var target = Target as IPlayable;
                    if (target == null)
                    {
                        return TaskState.STOP;
                    }
                    for (var i = 0; i < Amount; i++)
                    {
                        result.Add(Entity.FromCard(Controller, Cards.FromId(target.Card.Id)));
                    }
                    break;
                case EntityType.SOURCE:
                    var source = Source as IPlayable;
                    if (source == null)
                    {
                        return TaskState.STOP;
                    }
                    for (var i = 0; i < Amount; i++)
                    {
                        result.Add(Entity.FromCard(Controller, Cards.FromId(source.Card.Id)));
                    }
                    break;
                case EntityType.STACK:
                    if (Playables.Count < 1)
                    {
                        return TaskState.STOP;
                    }
                    Playables.ForEach(p =>
                    {
                        for (var i = 0; i < Amount; i++)
                        {
                            result.Add(Entity.FromCard(Controller, Cards.FromId(p.Card.Id)));
                        }
                    });
                    break;
                case EntityType.OP_HERO_POWER:
                    result.Add(Entity.FromCard(Controller, Cards.FromId(Controller.Opponent.Hero.Power.Card.Id)));
                    break;
                default:
                    throw new NotImplementedException();
            }

            Playables = result;
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyTask(Type, Amount);
            clone.Copy(this);
            return clone;
        }
    }
}