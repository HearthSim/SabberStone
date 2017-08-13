using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyCthun : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}

			if (Controller.ProxyCthun == 0)
			{
				return TaskState.STOP;
			}

			var proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];

			proxyCthun.Enchants.ForEach(p => p.Activate(p.SourceId, source.Enchants, source));

			source[GameTag.TAUNT] = proxyCthun[GameTag.TAUNT];

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new CopyCthun();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}