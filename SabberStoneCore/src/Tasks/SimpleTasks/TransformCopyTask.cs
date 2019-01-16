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
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformCopyTask : SimpleTask
	{
		private readonly bool _addToStack;

		public TransformCopyTask(bool addToStack = false)
		{
			_addToStack = addToStack;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var minionTarget = (Minion) target;
			if (minionTarget == null)
				return TaskState.STOP;

			var sourceTarget = (Minion) source;
			if (sourceTarget.Zone?.Type != Zone.PLAY)
				return TaskState.STOP;

			var tags = new EntityData
			{
				{GameTag.CREATOR, sourceTarget.Id}
			};
			if (game.History)
				tags.Add(GameTag.PREMIUM, minionTarget[GameTag.PREMIUM]);

			var copy = (Minion) Entity.FromCard(in controller, minionTarget.Card, tags);
			minionTarget.CopyInternalAttributes(copy);

			//Trigger trigger = minionTarget.ActivatedTrigger;
			IAura aura = minionTarget.OngoingEffect;

			// LINKED_ENTITY
			if (sourceTarget == game.CurrentEventData.EventSource)
				game.CurrentEventData.EventSource = copy;
			sourceTarget.Controller.BoardZone.Replace(sourceTarget, copy);

			// Copy Enchantments
			if (minionTarget.AppliedEnchantments != null)
				foreach (Enchantment e in minionTarget.AppliedEnchantments)
				{
					Enchantment instance = Enchantment.GetInstance(in controller, copy, copy, e.Card);
					if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
					{
						instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
							instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];

						instance.CapturedCard = e.CapturedCard;
					}
					if (e.IsOneTurnActive)
						game.OneTurnEffectEnchantments.Add(instance);
				}

			foreach (KeyValuePair<GameTag, int> kvp in minionTarget._data)
				switch (kvp.Key)
				{
					case GameTag.ENTITY_ID:
					case GameTag.CONTROLLER:
					case GameTag.ZONE:
					case GameTag.ZONE_POSITION:
					case GameTag.CREATOR:
					case GameTag.PREMIUM:
					case GameTag.EXHAUSTED:
					case GameTag.DEATHRATTLE:
						continue;
					default:
						copy._data.Add(kvp.Key, kvp.Value);
						break;
				}

			if (aura != null && copy.OngoingEffect == null)
				aura.Clone(copy);

			List<(int entityId, IEffect effect)> oneTurnEffects = controller.Game.OneTurnEffects;
			for (int i = oneTurnEffects.Count - 1; i >= 0; i--)
			{
				(int id, IEffect effect) = oneTurnEffects[i];

				if (id == target.Id)
					oneTurnEffects.Add((copy.Id, effect));
			}

			if (!minionTarget.HasCharge)
				copy.IsExhausted = true;

			if (_addToStack)
				stack.Playables = new []{copy};

			return TaskState.COMPLETE;
		}
	}
}
