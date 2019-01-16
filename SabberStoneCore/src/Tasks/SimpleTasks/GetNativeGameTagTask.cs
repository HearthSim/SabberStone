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

//using SabberStoneCore.Enums;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Tasks.SimpleTasks
//{
//	public class GetNativeGameTagTask : SimpleTask
//	{
//		public GetNativeGameTagTask(GameTag tag, EntityType entityType, bool selfBuffs, int numberIndex = 0)
//		{
//			Tag = tag;
//			Type = entityType;
//			SelfBuffs = selfBuffs;
//			_index = numberIndex;
//		}

//		public GameTag Tag { get; set; }
//		public EntityType Type { get; set; }
//		public bool SelfBuffs { get; set; }
//		private readonly int _index;

//		public override TaskState Process()
//		{
//			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
//			//if (entities.Count != 1)
//			//{
//			//	return TaskState.STOP;
//			//}

//			//int num = ((Entity)entities[0]).GetNativeGameTag(Tag);

//			var entity = (Entity) IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables).GetEnumerator().Current;
//			int num = entity.GetNativeGameTag(Tag);

//			if (SelfBuffs)
//			{
//				//entities[0].OldEnchants.ForEach(p => num = p.Apply((Entity)entities[0], Tag, num));
//				num += entity.AuraEffects[Tag];
//			}

//			switch (_index)
//			{
//				case 0:
//					stack.Number = num;
//					break;
//				case 1:
//					stack.Number1 = num;
//					break;
//				case 2:
//					stack.Number2 = num;
//					break;
//				case 3:
//					stack.Number3 = num;
//					break;
//				case 4:
//					stack.Number4 = num;
//					break;
//				default:
//					stack.Number = num;
//					break;
//			}

//			return TaskState.COMPLETE;
//		}

//		public override ISimpleTask Clone()
//		{
//			var clone = new GetNativeGameTagTask(Tag, Type, SelfBuffs, _index);
//			clone.Copy(this);
//			return clone;
//		}
//	}
//}



