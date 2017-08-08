using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SplitTask : SimpleTask
	{
		public SplitTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count == 0)
				return TaskState.STOP;

			if (Game.Splitting && Game.Splits.Count == 0)
			{
				if (Amount == 1)
				{
					entities.ForEach(p =>
					{
						//Game.Dump("SplitTask", $"{sets.IndexOf(p)}: {string.Join(";", p)}");
						Playables = new List<IPlayable> { p };
						State = TaskState.COMPLETE;
						var clone = Game.Clone();
						Game.Splits.Add(clone);
					});
				}
				else
				{
					var sets = Util.GetPowerSet(entities).Where(p => p.Count() == Amount).ToList();
					sets.ForEach(p =>
					{
						//Game.Dump("SplitTask", $"{sets.IndexOf(p)}: {string.Join(";", p)}");
						Playables = p.ToList();
						State = TaskState.COMPLETE;
						var clone = Game.Clone();
						Game.Splits.Add(clone);
					});
				}
			}

			Playables = entities;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SplitTask(Amount, Type);
			clone.Copy(this);
			return clone;
		}

	}

	public class RandomTask : SimpleTask
	{
		public RandomTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count == 0)
				return TaskState.STOP;

			Playables = new List<IPlayable>();
			for (var i = 0; i < Amount && entities.Count > 0; i++)
			{
				var randPlayable = Util.Choose<IPlayable>(entities);
				entities.Remove(randPlayable);
				Playables.Add(randPlayable);
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomTask(Amount, Type);
			clone.Copy(this);
			return clone;
		}
	}
}