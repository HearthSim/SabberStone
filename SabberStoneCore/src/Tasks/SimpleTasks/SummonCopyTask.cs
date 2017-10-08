using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// Summon a copy of one (or more) existing entity.
	/// </summary>
	/// <seealso cref="SimpleTask" />
	public class SummonCopyTask : SimpleTask
	{
		/// <summary>
		/// Summons a copy of the choosen entitytype.
		/// </summary>
		/// <param name="type">Selector of entity to copy.</param>
		/// <param name="randomFlag"><c>true</c> if the copies need to be summoned
		/// in random order, <c>false</c> otherwise.</param>
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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
			entities = RandomFlag ? entities.OrderBy(x => Util.Random.Next()).ToList() : entities;

			if (RandomFlag)
				Game.OnRandomHappened(true);

			int space = Controller.BoardZone.MaxSize - Controller.BoardZone.Count;
			if (space < Playables.Count)
				Playables = Playables.Take(space).ToList();

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

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
