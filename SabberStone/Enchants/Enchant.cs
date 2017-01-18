using System;
using System.Collections.Generic;
using HearthDb.Enums;
using log4net;
using SabberStone.Conditions;
using SabberStone.Model;
using SabberStone.Tasks;

namespace SabberStone.Enchants
{
    public class Enchant : ILazyRemove
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<Enchant> Parent { get; set; }

        public List<SelfCondition> EnableConditions { get; set; } = new List<SelfCondition>();

        public List<RelaCondition> ApplyConditions { get; set; } = new List<RelaCondition>();

        public string SourceId { get; set; }

        public Game Game { get; set; }

        private int _ownerId;
        public IPlayable Owner {
            get { return Game.IdEntityDic[_ownerId]; } 
            set { _ownerId = value.Id; }
        }

        public Dictionary<GameTag, int> Effects { get; set; } = new Dictionary<GameTag, int>();

        public Func<IPlayable, int> ValueFunc = null;

        public int TurnsActive { get; set; } = -1;

        public int Turn { get; set; }

        public ISimpleTask SingleTask { get; set; }

        public ISimpleTask RemovalTask { get; set; }

        public string Hash => $"{SourceId}{(TurnsActive > -1 ? $",{Turn}" : "")}";

        public Enchant Copy(string sourceId, Game game, int turn,  List<Enchant> parent, IPlayable owner)
        {
            return new Enchant()
            {
                Game = game,
                Parent = parent,
                Owner = owner,
                Turn = turn,

                SourceId = sourceId,
                EnableConditions = EnableConditions,
                ApplyConditions = ApplyConditions,
                SingleTask = SingleTask,
                RemovalTask = RemovalTask,
                Effects = Effects,
                ValueFunc = ValueFunc,
                TurnsActive = TurnsActive
            };
        }

        public void Remove()
        {
            if (SingleTask != null)
            {
                Log.Debug($"enqueueuing lazy removal task here!");

                // clone task here
                var clone = SingleTask.Clone();
                clone.Game = Owner.Controller.Game;
                clone.Controller = Owner.Controller;
                clone.Source = Owner;
                clone.Target = Owner;

                Owner.Controller.Game.TaskQueue.Enqueue(clone);
            }
            Parent.Remove(this);               
        }

        public bool IsEnabled()
        {
            var flag = true;
            EnableConditions.ForEach(p => flag &= p.Eval(Owner));
            flag &= TurnsActive < 0 || Owner.Game.Turn <= Turn + TurnsActive;

            if (!flag && !Owner.Game.LazyRemoves.Contains(this))
            {
                Owner.Game.LazyRemoves.Enqueue(this);
                // execute removal task here, ex. health rentantion   
                if (RemovalTask != null)
                {
                    Log.Debug($"executing removal task priority here");
                    Owner.Controller.Game.TaskQueue.Execute(RemovalTask, Owner.Controller, Owner, Owner);
                }
            }

            return flag;
        }

        private bool IsApplying(IPlayable target)
        {
            var flag = true;
            ApplyConditions.ForEach(p => flag &= p.Eval(Owner, target));
            return flag;
        }

        public int Apply(Entity entity, GameTag gameTag, int value)
        {

            // only allow enchantments on playable entitys ...
            var target = entity as IPlayable;
            if (target == null)
            {
                return value;
            }

            if (!Effects.ContainsKey(gameTag))
            {
                Log.Debug($"GameTag {gameTag} not concerned by this enchanting ...");
                return value;
            }

            if (!IsEnabled())
            {
                Log.Debug($"Enchant from {Owner} isn't enabled! {target}");
                return value;
            }

            if (!IsApplying(target))
            {
                Log.Debug($"Enchant conditions not meet.");
                return value;
            }

            Log.Debug($"Card[ind.{target.OrderOfPlay}.{target}] got enchanted. {gameTag} = {value} + {Effects[gameTag]}");

            // apply variable effects if we have ...
            var effect = ValueFunc?.Invoke(Owner) ?? Effects[gameTag];

            // TODO find an elegant way for that ... check if gametag is bool
            if (gameTag == GameTag.CHARGE || gameTag == GameTag.WINDFURY || gameTag == GameTag.IMMUNE)
            {
                return (value + effect) == 0 ? 0 : 1;
            }

            var result = value + effect;

            // TODO don't allow negative values for those tags ... for all???
            if (result < 0) // && (gameTag == GameTag.COST || gameTag == GameTag.ATK))
            {
                result = 0;
            }

            // enchanting value
            return result;

        }

        public void Activate(string sourceId, List<Enchant> parent, IPlayable owner)
        {
            parent.Add(Copy(sourceId, owner.Game, owner.Game.Turn, parent, owner));
        }

    }

}
