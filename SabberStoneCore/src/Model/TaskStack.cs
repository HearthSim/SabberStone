#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
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
