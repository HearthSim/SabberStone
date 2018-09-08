using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>
	/// Summon a copy of one (or more) existing entity.
	/// </summary>
	/// <seealso cref="SimpleTask" />
	public class SummonCopyTask : SimpleTask
	{
		/// <summary>
		/// Summons a copy of the chosen entitytype.
		/// </summary>
		/// <param name="type">Selector of entity to copy.</param>
		/// <param name="randomFlag"><c>true</c> if the copies need to be summoned
		/// in random order, <c>false</c> otherwise.</param>
		public SummonCopyTask(EntityType type, bool randomFlag = false, bool addToStack = false)
		{
			Type = type;
			RandomFlag = randomFlag;
			_addToStack = addToStack;
		}

		public SummonCopyTask(EntityType type, SummonSide side) : this(type)
		{
			_side = side;
		}

		/// <summary>
		/// Entities to summon.
		/// </summary>
		public EntityType Type { get; set; }

		/// <summary>
		/// If there are multiple entities to summon it will randomly summon them.
		/// </summary>
		public bool RandomFlag { get; set; }

		private readonly bool _addToStack;
		private readonly SummonSide _side;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

			IList<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).ToList();

			if (entities.Count < 1)
			{
				return TaskState.STOP;
			}

			// shuffle list randomly if needed
			entities = RandomFlag ? entities.OrderBy(x => Util.Random.Next()).ToList() : entities;

			if (RandomFlag)
				Game.OnRandomHappened(true);

			int space = Controller.BoardZone.MaxSize - Controller.BoardZone.Count;

			space = entities.Count > space ? space : entities.Count;

			if (entities[0].Zone == null || entities[0].Zone.Type != Enums.Zone.PLAY)
			{
				for (int i = 0; i < space; i++)
				{
					// clone task here
					var task = new SummonTask(_side, entities[i].Card)
					{
						Game = Controller.Game,
						Controller = Controller,
						Source = Source as IPlayable,
						Target = Target as IPlayable
					};

					Controller.Game.TaskQueue.Enqueue(task);
				}
			}
			else
			{
				for (int i = 0; i < entities.Count; i++)
				{
					if (Controller.BoardZone.IsFull) break;

					Minion target = (Minion)entities[i];

					var tags = new EntityData.Data((EntityData.Data) target.NativeTags);

					if (target.Controller != Controller)
						tags[GameTag.CONTROLLER] = Controller.PlayerId;

					Minion copy = (Minion) Entity.FromCard(Controller, target.Card, tags, Controller.BoardZone);
					copy._atkModifier = target._atkModifier;
					copy._healthModifier = target._healthModifier;
					copy._dmgModifier = target._dmgModifier;

					target.AppliedEnchantments?.ForEach(e =>
					{
						Enchantment instance = Enchantment.GetInstance(Controller, copy, copy, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
						}
					});

					if (target.OngoingEffect != null && copy.OngoingEffect == null)
						target.OngoingEffect.Clone(copy);

					if (_addToStack)
						Playables.Add(copy);
				}
			}



			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SummonCopyTask(Type, RandomFlag, _addToStack);
			clone.Copy(this);
			return clone;
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
