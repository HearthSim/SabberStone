using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class CopyTask : SimpleTask
    {
        public CopyTask(EEntityType type, int amount, bool opposite = false)
        {
            Type = type;
            Amount = amount;
            Opposite = opposite;
        }

        public EEntityType Type { get; set; }

        public int Amount { get; set; }

        public bool Opposite { get; set; }

        public override ETaskState Process()
        {
            var result = new List<IPlayable>();
            switch (Type)
            {
                case EEntityType.TARGET:
                    var target = Target as IPlayable;
                    if (target == null)
                    {
                        return ETaskState.STOP;
                    }
                    for (var i = 0; i < Amount; i++)
                    {
                        result.Add(Opposite ?
                            Entity.FromCard(target.Controller.Opponent, Cards.FromId(target.Card.Id)) :
                            Entity.FromCard(Controller, Cards.FromId(target.Card.Id)));
                    }
                    break;
                case EEntityType.SOURCE:
                    var source = Source as IPlayable;
                    if (source == null)
                    {
                        return ETaskState.STOP;
                    }
                    for (var i = 0; i < Amount; i++)
                    {
                        result.Add(Opposite ?
                            Entity.FromCard(source.Controller.Opponent, Cards.FromId(source.Card.Id)) :
                            Entity.FromCard(Controller, Cards.FromId(source.Card.Id)));
                    }
                    break;
                case EEntityType.STACK:
                    if (Playables.Count < 1)
                    {
                        return ETaskState.STOP;
                    }
                    Playables.ForEach(p =>
                    {
                        for (var i = 0; i < Amount; i++)
                        {
                            result.Add(Opposite ?
                                Entity.FromCard(p.Controller.Opponent, Cards.FromId(p.Card.Id)) :
                                Entity.FromCard(Controller, Cards.FromId(p.Card.Id)));
                        }
                    });
                    break;
                case EEntityType.OP_HERO_POWER:
                    result.Add(Entity.FromCard(Controller, Cards.FromId(Controller.Opponent.Hero.Power.Card.Id)));
                    break;
                default:
                    throw new NotImplementedException();
            }

            Playables = result;
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new CopyTask(Type, Amount, Opposite);
            clone.Copy(this);
            return clone;
        }
    }
}