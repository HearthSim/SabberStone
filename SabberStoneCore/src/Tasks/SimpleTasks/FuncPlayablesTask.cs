#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FuncPlayablesTask : SimpleTask
	{
		public FuncPlayablesTask(Func<List<IPlayable>, List<IPlayable>> function)
		{
			Function = function;
		}

		public Func<List<IPlayable>, List<IPlayable>> Function { get; set; }

		public override TaskState Process()
		{
			Playables = Function(Playables);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new FuncPlayablesTask(Function);
			clone.Copy(this);
			return clone;
		}
	}
}