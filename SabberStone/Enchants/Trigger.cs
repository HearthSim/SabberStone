using System.Collections.Generic;
using System.Reflection;
using HearthDb.Enums;
using log4net;
using SabberStone.Conditions;
using SabberStone.Model;
using SabberStone.Tasks;

namespace SabberStone.Enchants
{
    public class Trigger : ILazyRemove
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public List<Trigger> Parent { get; set; }

        public List<SelfCondition> EnableConditions { get; set; } = new List<SelfCondition>();

        public List<RelaCondition> ApplyConditions { get; set; } = new List<RelaCondition>();

        public string SourceId { get; set; }

        public Game Game { get; set; }

        private int _ownerId;
        public IPlayable Owner
        {
            get { return Game.IdEntityDic[_ownerId]; }
            set { _ownerId = value.Id; }
        }

        public Dictionary<GameTag, int> Effects { get; set; } = new Dictionary<GameTag, int>();

        public int TurnsActive { get; set; } = -1;

        public int Turn { get; set; }

        public bool FastExecution { get; set; } = false;

        public ISimpleTask SingleTask { get; set; }

        public string Hash => $"{SourceId}{(TurnsActive > -1 ? $",{Turn}" : "")}";

        public Trigger Copy(string sourceId, Game game, int turn, List<Trigger> parent, IPlayable owner)
        {
            return new Trigger
            {
                Game = game,
                Parent = parent,
                Owner = owner,
                Turn = turn,

                SourceId = sourceId,
                EnableConditions = EnableConditions,
                ApplyConditions = ApplyConditions,
                SingleTask = SingleTask,
                Effects = Effects,
                TurnsActive = TurnsActive,
                FastExecution = FastExecution
            };
        }

        public void Remove()
        {
            Parent.Remove(this);
        }

        public bool IsEnabled()
        {
            var flag = true;
            EnableConditions.ForEach(p => flag &= p.Eval(Owner));
            flag &= TurnsActive < 0 || Owner.Game.Turn <= Turn + TurnsActive;
            if (!flag)
            {
                Owner.Game.LazyRemoves.Enqueue(this);
            }
            return flag;
        }

        private bool IsApplying(IPlayable target)
        {
            var flag = true;
            ApplyConditions.ForEach(p => flag &= p.Eval(Owner, target));
            return flag;
        }

        public void Change(Entity entity, GameTag gameTag, int oldValue, int newValue)
        {

            var target = entity as IPlayable;

            Log.Info($"{entity} {gameTag} {oldValue} {newValue}");

            if (!Effects.ContainsKey(gameTag))
            {
                Log.Info($"GameTag {gameTag} not concerned by this enchanting(change) ...");
                return;
            }

            if (!IsEnabled())
            {
                Log.Info($"Trigger isn't enabled!");
                return;
            }

            if (!IsApplying(target))
            {
                Log.Info($"Trigger conditions not meet.");
                return;
            }

            if (Effects[gameTag] > 0 && oldValue >= newValue
             || Effects[gameTag] < 0 && oldValue <= newValue)
            {
                Log.Info($"Enchant(change) conditions not meet positiv or negativ.");
                return;
            }

            // do a clone of the task
            var clone = SingleTask.Clone();
            clone.Game = Owner.Controller.Game;
            clone.Controller = Owner.Controller;
            clone.Source = Owner;
            clone.Target = target;
            // let the change move into the task
            clone.Number = newValue - oldValue;

            if (FastExecution)
            {
                Owner.Controller.Game.TaskQueue.Execute(SingleTask, Owner.Controller, Owner, target);
            }
            else
            {
                Owner.Controller.Game.TaskQueue.Enqueue(clone);
            }
        }

        public void Activate(string sourceId, List<Trigger> parent, IPlayable owner)
        {
            parent.Add(Copy(sourceId, owner.Game, owner.Game.Turn, parent, owner));
        }
    }

    public class TriggerBuilder
    {
        private Trigger _trigger;

        public TriggerBuilder Create()
        {
            _trigger = new Trigger();
            return this;
        }

        public TriggerBuilder EnableConditions(params SelfCondition[] list)
        {
            _trigger.EnableConditions.AddRange(list);
            return this;
        }

        public TriggerBuilder ApplyConditions(params RelaCondition[] list)
        {
            _trigger.ApplyConditions.AddRange(list);
            return this;
        }

        public TriggerBuilder SingleTask(ISimpleTask task)
        {
            _trigger.SingleTask = task;
            return this;
        }

        public TriggerBuilder TriggerEffect(GameTag tag, int change)
        {
            _trigger.Effects.Add(tag, change);
            return this;
        }

        public TriggerBuilder FastExecution(bool fastExecution)
        {
            _trigger.FastExecution = fastExecution;
            return this;
        }

        public Trigger Build()
        {
            return _trigger;
        }
    }
}