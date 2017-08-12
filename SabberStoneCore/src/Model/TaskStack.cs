using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using System;

namespace SabberStoneCore.Model
{
	public class TaskStack : IModel<TaskStack>
	{
		public Game Game { get; set; }

		public List<IPlayable> Playables { get; set; }
		public List<string> CardIds { get; set; }
		public bool Flag { get; set; }
		public int[] Numbers { get; set; } = new[] { 0, 0, 0, 0, 0 };

		public TaskStack(Game game)
		{
			Game = game;
		}

		public void Reset()
		{
			Playables = new List<IPlayable>();
			CardIds = new List<string>();
			Flag = false;
			Numbers = new[] { 0, 0, 0, 0, 0 };
		}

		public TaskStack Clone()
		{
			return new TaskStack(Game)
			{
				Playables = Playables.ToList(), // Shallow copy
				CardIds = CardIds.ToList(), // Shallow copy
				Flag = Flag,
				Numbers = Numbers.ToArray(), // Shallow copy
			};
		}

		public string ToHash(params GameTag[] ignore)
		{
			throw new NotImplementedException();
		}

		public void Stamp(IModel other)
		{
			TaskStack taskStack = other as TaskStack ?? throw new InvalidOperationException("other's type is invalid");

			Playables = new List<IPlayable>();
			Playables = taskStack.Playables?.Select(p => Game.IdEntityDic[p.Id]).ToList();
			CardIds = taskStack.CardIds;
			Flag = taskStack.Flag;
			Numbers = taskStack.Numbers;
		}

		IModel IModel.Clone()
		{
			return Clone();
		}
	}
}