﻿using System.Collections.Generic;
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

			var tags = new EntityData.Data
			{
				{GameTag.CREATOR, sourceTarget.Id}
			};
			if (game.History)
				tags.Add(GameTag.PREMIUM, minionTarget[GameTag.PREMIUM]);

			var copy = (Minion) Entity.FromCard(in controller, minionTarget.Card, tags, null);
			minionTarget.CopyInternalAttributes(copy);

			Trigger trigger = minionTarget.ActivatedTrigger;
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
					}
				}

			foreach (KeyValuePair<GameTag, int> kvp in minionTarget._data.Tags)
				switch (kvp.Key)
				{
					case GameTag.ENTITY_ID:
					case GameTag.CONTROLLER:
					case GameTag.ZONE:
					case GameTag.ZONE_POSITION:
					case GameTag.CREATOR:
					case GameTag.PREMIUM:
					case GameTag.EXHAUSTED:
						continue;
					default:
						copy._data.Tags.Add(kvp.Key, kvp.Value);
						break;
				}

			if (aura != null && copy.OngoingEffect == null)
				aura.Clone(copy);

			if (!minionTarget.HasCharge)
				copy.IsExhausted = true;

			if (_addToStack)
				stack.Playables = new List<IPlayable> {copy};

			return TaskState.COMPLETE;
		}
	}
}
