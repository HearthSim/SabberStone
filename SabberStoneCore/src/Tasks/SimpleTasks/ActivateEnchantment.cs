using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ActivateEnchantment : SimpleTask
	{

		public EntityType Type { get; set; }

		public EnchantmentActivation Activation { get; set; }

		public ActivateEnchantment(EntityType entityType, EnchantmentActivation activation)
		{
			Type = entityType;
			Activation = activation;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			entities.ForEach(p =>
			{
				p.Enchantments.ForEach(t =>
				{
					if (t.Activation == Activation)
					{
						t.Activate(Controller, p, Target as IPlayable);
					}
				});

			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(ActivateEnchantment).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ActivateEnchantment(Type, Activation);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}