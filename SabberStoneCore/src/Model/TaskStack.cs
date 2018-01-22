using System;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model
{
	public class TaskStack
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

		public void Stamp(TaskStack taskStack)
		{
			//Playables = taskStack.Playables?.Select(p => Game.IdEntityDic[p.Id]).ToList();
			Playables = new List<IPlayable>();
			CardIds = new List<string>();
			Flag = taskStack.Flag;
			Numbers = new int[5];
			Array.Copy(taskStack.Numbers, Numbers, 5);
		}
	}
}
