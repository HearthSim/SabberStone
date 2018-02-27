using System;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model
{
	public class TaskStack
	{
		public Game Game { get; set; }

		public Controller Controller { get; set; }
		public IEntity Source;
		public IEntity Target;

		public List<IPlayable> Playables { get; set; } = new List<IPlayable>();
		//public List<string> CardIds { get; set; }
		public bool Flag { get; set; }
		public int[] Numbers { get; set; } = new[] { 0, 0, 0, 0, 0 };

		public TaskStack(Game game)
		{
			Game = game;
		}

		//public void SetDamageMetaData(IPlayable source, IPlayable target)
		//{
		//	_damageSource = source;
		//	_damageTarget = target;
		//}

		//public void ResetDamageMetaData()
		//{
		//	_damageSource = null;
		//	_damageTarget = null;
		//}

		public void Reset()
		{
			Playables = new List<IPlayable>();
			Flag = false;
			Numbers = new[] { 0, 0, 0, 0, 0 };
		}

		public void Stamp(TaskStack taskStack)
		{
			//Playables = taskStack.Playables?.Select(p => Game.IdEntityDic[p.Id]).ToList();
			Playables = new List<IPlayable>();
			//CardIds = new List<string>();
			Flag = taskStack.Flag;
			Numbers = new int[5];
			Array.Copy(taskStack.Numbers, Numbers, 5);

			if (taskStack.Controller != null)
				Controller = Game.ControllerById(taskStack.Controller.Id);
			if (taskStack.Source != null)
				Source = Game.IdEntityDic[taskStack.Source.Id];
			if (taskStack.Target != null)
				Target = Game.IdEntityDic[taskStack.Target.Id];
		}
	}
}
