using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyTask : SimpleTask
	{
		private readonly EntityType _entityType;
		private readonly Zone _zoneType;
		private readonly int _amount;
		private readonly bool _addToStack;
		private readonly bool _toOpponent;

		public CopyTask(EntityType type, Zone targetZone, int amount = 1, bool addToStack = false, bool toOpponent = false)
		{
			_entityType = type;
			_amount = amount;
			_zoneType = targetZone;
			_addToStack = addToStack;
			_toOpponent = toOpponent;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			Zone zone = _zoneType;
			bool addToStack = _addToStack;
			int amount = _amount;

			Controller c = _toOpponent ? controller.Opponent : controller;
			IZone targetZone = c.ControlledZones[zone];

			if (targetZone.IsFull)
				return TaskState.STOP;

			List<IPlayable> result = addToStack ? new List<IPlayable>() : null;

			if (_entityType == EntityType.STACK)
			{
				if (stack?.Playables.Count < 1)
					return TaskState.STOP;

				foreach (IPlayable p in stack.Playables)
				{
					for (int i = 0; i < amount; i++)
					{
						IPlayable copied = Generic.Copy(in c, in source, in p, zone);
						if (addToStack)
							result.Add(copied);

						if (targetZone.IsFull)
						{
							if (addToStack)
								stack.Playables = result;
							return TaskState.COMPLETE;
						}
					}
				}
			}
			else
			{
				IPlayable toBeCopied;
				switch (_entityType)
				{
					case EntityType.TARGET:
						toBeCopied = target as IPlayable;
						break;
					case EntityType.SOURCE:
						toBeCopied = source as IPlayable;
						break;
					case EntityType.EVENT_SOURCE:
						toBeCopied = game.CurrentEventData?.EventSource;
						break;
					case EntityType.OP_HERO_POWER:
						toBeCopied = Entity.FromCard(c,
							Cards.FromId(controller.Opponent.Hero.HeroPower.Card.Id));
						if (addToStack)
							result.Add(toBeCopied);
						return TaskState.COMPLETE;
					case EntityType.WEAPON:
						Weapon weapon = controller.Hero.Weapon;
						if (weapon == null) return TaskState.STOP;

						for (int i = 0; i < _amount; i++)
							result.Add(Entity.FromCard(c, Cards.FromId(weapon.Card.Id)));
						return TaskState.COMPLETE;
					default:
						throw new NotImplementedException();
				}

				for (int i = 0; i < amount; i++)
				{
					IPlayable copied = Generic.Copy(in c, in source, in toBeCopied, zone);

					if (addToStack)
						result.Add(copied);

					if (targetZone.IsFull)
					{
						if (addToStack)
							stack.Playables = result;
						return TaskState.COMPLETE;
					}
				}
			}

			if (addToStack)
				stack.Playables = result;

			return TaskState.COMPLETE;
		}
	}
}
