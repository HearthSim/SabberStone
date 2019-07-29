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
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	// TODO: Should use Generic.Copy()
	/// <summary>
	/// Summon a copy of one (or more) existing entity.
	/// </summary>
	/// <seealso cref="SimpleTask" />
	public class SummonCopyTask : SimpleTask
	{
		private readonly bool _addToStack;

		/// <summary>
		/// If there are multiple entities to summon it will randomly summon them.
		/// </summary>
		private readonly bool _randomFlag;

		private readonly SummonSide _side;

		/// <summary>
		/// Entities to summon.
		/// </summary>
		private readonly EntityType _type;

		/// <summary>
		/// Summons a copy of the chosen entitytype.
		/// </summary>
		/// <param name="type">Selector of entity to copy.</param>
		/// <param name="randomFlag">
		/// <c>true</c> if the copies need to be summoned
		/// in random order, <c>false</c> otherwise.
		/// </param>
		/// <param name="addToStack">Add the summoned entity to the stack.</param>
		/// <param name="side">The side in which the summoned entity should be place.</param>
		public SummonCopyTask(EntityType type, bool randomFlag = false, bool addToStack = false,
			SummonSide side = SummonSide.DEFAULT)
		{
			_type = type;
			_randomFlag = randomFlag;
			_addToStack = addToStack;
			_side = side;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			int alternateCount = 0;

			if (controller.BoardZone.IsFull)
				return TaskState.STOP;

			IList<IPlayable> entities =
				IncludeTask.GetEntities(_type, controller, source, target, stack?.Playables);

			if (entities.Count < 1) return TaskState.STOP;

			// shuffle list randomly if needed
			entities = _randomFlag ? entities.Shuffle(game.Random) : entities;

			if (_randomFlag)
				game.OnRandomHappened(true);


			BoardZone board = controller.BoardZone;
			int space = board.MaxSize - board.Count;

			space = entities.Count > space ? space : entities.Count;

			if (entities[0].Zone == null || entities[0].Zone.Type != Zone.PLAY)
				for (int i = 0; i < space; i++)
				{
					if (board.IsFull)
						break;

					var minion = (Minion)Entity.FromCard(in controller, entities[i].Card,
						new EntityData
						{
							{GameTag.DISPLAYED_CREATOR, source.Id}
						});

					Generic.SummonBlock.Invoke(game, minion,
						SummonTask.GetPosition(in source, _side, stack?.Number ?? 0, ref alternateCount),
						source);

					if (_addToStack)
						stack.AddPlayable(minion);
				}
			else
				for (int i = 0; i < entities.Count; i++)
				{
					if (controller.BoardZone.IsFull) break;

					var minion = (Minion)entities[i];

					var tags = new EntityData((EntityData)minion.NativeTags);

					if (minion.Controller != controller)
						tags[GameTag.CONTROLLER] = controller.PlayerId;

					int zonePosition = SummonTask.GetPosition(in source, _side, stack?.Number ?? 0, ref alternateCount);

					var copy = (Minion)Entity.FromCard(in controller, minion.Card, tags, controller.BoardZone,
						zonePos: in zonePosition, creator: in source);
					minion.CopyInternalAttributes(copy);

					if (minion.AppliedEnchantments != null)
						foreach (Enchantment e in minion.AppliedEnchantments)
						{
							Enchantment instance = Enchantment.GetInstance(controller, copy, copy, e.Card);
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
							{
								instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
								if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
									instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
							}
							
							instance.CapturedCard = e.CapturedCard;

							if (e.IsOneTurnActive)
								instance.Game.OneTurnEffectEnchantments.Add(instance);
						}

					if (minion.OngoingEffect != null && copy.OngoingEffect == null)
						minion.OngoingEffect.Clone(copy);

					if (_addToStack)
						stack.AddPlayable(copy);
				}


			return TaskState.COMPLETE;
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
