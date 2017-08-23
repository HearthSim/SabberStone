using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonCopyTask : SimpleTask
	{
		/// <summary>
		/// Summons a copy of the choosen entitytype.
		/// </summary>
		/// <param name="type"></param>
		public SummonCopyTask(EntityType type, bool randomFlag = false)
		{
			Type = type;
			RandomFlag = randomFlag;
		}

		/// <summary>
		/// Entities to summon.
		/// </summary>
		public EntityType Type { get; set; }

		/// <summary>
		/// If there are multiple entities to summon it will randomly summon them.
		/// </summary>
		public bool RandomFlag { get; set; }

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count < 1)
			{
				return TaskState.STOP;
			}

			// shuffle list randomly if needed
			entities = RandomFlag ? entities.OrderBy (x => Util.Random.Next()).ToList() : entities;

			entities.ForEach(p =>
			{
				// clone task here
				var task = new SummonTask(SummonSide.DEFAULT, p.Card)
				{
					Game = Controller.Game,
					Controller = Controller,
					Source = Source as IPlayable,
					Target = Target as IPlayable
				};

				Controller.Game.TaskQueue.Enqueue(task);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonCopyTask(Type, RandomFlag);
			clone.Copy(this);
			return clone;
		}
	}
}
