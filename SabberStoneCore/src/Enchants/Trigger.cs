using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class Trigger : ILazyRemove
	{
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

		public int Executions { get; set; } = 0;

		public int MaxExecutions { get; set; } = 0;

		//public GameTag NextCountGameTag { get; set; } = GameTag.NUM_CARDS_PLAYED_THIS_TURN;

		//public int NextCount { get; set; } = 0;

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
				FastExecution = FastExecution,
				Executions = Executions,
				MaxExecutions = MaxExecutions,
				//NextCountGameTag = NextCountGameTag,
				//NextCount = owner[NextCountGameTag]
			};
		}

		public void Remove()
		{
			Parent.Remove(this);
		}

		public bool IsEnabled()
		{
			bool flag = true;
			//EnableConditions.ForEach(p => flag &= p.Eval(Owner));
			for (int i = 0; i < EnableConditions.Count; i++)
				flag &= EnableConditions[i].Eval(Owner);
			flag &= TurnsActive < 0 || Owner.Game.Turn <= Turn + TurnsActive;
			if (!flag)
			{
				Owner.Game.LazyRemoves.Enqueue(this);
			}
			return flag;
		}

		private bool IsApplying(IPlayable target)
		{
			bool flag = true;
			//ApplyConditions.ForEach(p => flag &= p.Eval(Owner, target));
			for (int i = 0; i < ApplyConditions.Count; i++)
				flag &= ApplyConditions[i].Eval(Owner, target);
			return flag;
		}

		public void Change(Entity entity, GameTag gameTag, int oldValue, int newValue)
		{

			if (Owner.Game.LazyRemoves.Contains(this))
			{
				return;
			}

			var target = entity as IPlayable;

			//Game.Log(LogLevel.INFO, BlockType.TRIGGER, "Trigger", $"{entity} {gameTag} {oldValue} {newValue}");

			if (!Effects.ContainsKey(gameTag))
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger", !Game.Logging? "":$"GameTag {gameTag} not concerned by this enchanting(change) ...");
				return;
			}

			if (!IsEnabled())
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger", !Game.Logging? "":"Trigger isn't enabled!");
				return;
			}

			if (!IsApplying(target))
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger", !Game.Logging? "":$"Trigger conditions not meet.");
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger", !Game.Logging? "":$"Owner: {Owner}, Target: {target}");
				return;
			}

			if (Effects[gameTag] > 0 && oldValue >= newValue
			 || Effects[gameTag] < 0 && oldValue <= newValue)
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Trigger", !Game.Logging? "":$"Enchant(change) on {gameTag} conditions not meet positiv or negativ. {Effects[gameTag]} && {oldValue} == {newValue}");
				return;
			}

			// do a clone of the task
			ISimpleTask clone = SingleTask.Clone();
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

			Executions++;

			if (MaxExecutions != 0 && Executions >= MaxExecutions)
			{
				//Remove();
				Owner.Game.LazyRemoves.Enqueue(this);
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

		public TriggerBuilder TurnsActive(int value)
		{
			_trigger.TurnsActive = value;
			return this;
		}

		public TriggerBuilder FastExecution(bool fastExecution)
		{
			_trigger.FastExecution = fastExecution;
			return this;
		}

		public TriggerBuilder MaxExecution(int maxExecutions)
		{
			_trigger.MaxExecutions = maxExecutions;
			return this;
		}

		//public TriggerBuilder NextCountGameTag(GameTag nextCountGameTag)
		//{
		//    _trigger.NextCountGameTag = nextCountGameTag;
		//    return this;
		//}

		public Trigger Build()
		{
			return _trigger;
		}
	}
}
