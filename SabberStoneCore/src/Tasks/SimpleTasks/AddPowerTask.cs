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

//using SabberStoneCore.Enchants;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Tasks.SimpleTasks
//{
//	public class AddPowerTask : SimpleTask
//	{
//		public AddPowerTask(EntityType type, Power power, bool activate = false)
//		{
//			Type = type;
//			Power = power;
//			Activate = activate;
//		}

//		public EntityType Type { get; set; }

//		public Power Power { get; set; }

//		public bool Activate { get; set; }

//		public override TaskState Process()
//		{
//			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
//			entities.ForEach(p =>
//			{
//				var minion = p as Minion;
//				if (minion != null)
//				{
//					minion.HasDeathrattle = Power.Activation == PowerActivation.DEATHRATTLE ? true : false;
//					//if (minion.Powers == null)
//					//	minion.Powers = new System.Collections.Generic.List<Power> { Power };
//					//else
//					//	minion.Powers.Add(Power);
//					if (Activate)
//					{
//						//Power.Activate(Controller, minion);
//					}
//				}
//			});
//			return TaskState.COMPLETE;
//		}

//		public override ISimpleTask Clone()
//		{
//			var clone = new AddPowerTask(Type, Power, Activate);
//			clone.Copy(this);
//			return clone;
//		}
//	}
//}
