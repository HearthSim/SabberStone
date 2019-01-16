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
//			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
//			entities.ForEach(p =>
//			{
//				var minion = p as Minion;
//				if (minion != null)
//				{
//					minion.IsDeathrattle = Power.Activation == PowerActivation.DEATHRATTLE ? true : false;
//					//if (minion.Powers == null)
//					//	minion.Powers = new System.Collections.Generic.List<Power> { Power };
//					//else
//					//	minion.Powers.Add(Power);
//					if (Activate)
//					{
//						//Power.Activate(controller, minion);
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



