using System.Linq;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model
{
	public class TaskStack
	{
		public List<IPlayable> Playables { get; set; } = new List<IPlayable>();
		//public List<string> CardIds { get; set; }
		public bool Flag { get; set; }
		public int Number { get; set; }
		public int Number1 { get; set; }
		public int Number2 { get; set; }
		public int Number3 { get; set; }
		public int Number4 { get; set; }

		public TaskStack()
		{

		}

		public void Reset()
		{
			Playables = new List<IPlayable>();
			Flag = false;
			Number = 0;
			Number1 = 0;
			Number2 = 0;
			Number3 = 0;
			Number4 = 0;
		}


		public TaskStack Clone(Game game)
		{

			var clone = new TaskStack()
			{
				Playables = new List<IPlayable>(),
				Flag = Flag,
				Number = Number,
				Number1 = Number1,
				Number2 = Number2,
				Number3 = Number3,
				Number4 = Number4
			};

			if (Playables.Count > 0)
				clone.Playables.AddRange(Playables.Select(p => game.IdEntityDic[p.Id]));

			return clone;
		}
	}
}
