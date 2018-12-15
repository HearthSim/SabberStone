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
namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class ActivateEnchantment : SimpleTask
	//{
	//	public ActivateEnchantment(EntityType entityType, PowerActivation activation)
	//	{
	//		Type = entityType;
	//		Activation = activation;
	//	}

	//	public EntityType Type { get; set; }

	//	public PowerActivation Activation { get; set; }

	//	public override TaskState Process()
	//	{

	//		System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

	//		entities.ForEach(p =>
	//		{
	//			p.Powers.ForEach(t =>
	//			{
	//				if (t.Activation == Activation)
	//				{
	//					//t.Activate(Controller, p, Target as IPlayable);
	//				}
	//			});

	//		});

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new ActivateEnchantment(Type, Activation);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
