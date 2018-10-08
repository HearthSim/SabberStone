using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyTask : SimpleTask
	{
		private readonly Zone _zoneType;

		public CopyTask(EntityType type, int amount, bool opposite = false, Zone zoneType = Zone.INVALID)
		{
			Type = type;
			Amount = amount;
			Opposite = opposite;
			_zoneType = zoneType;
		}

		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public bool Opposite { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var result = new List<IPlayable>();
			switch (Type)
			{
				case EntityType.TARGET:
					var playableTarget = target as IPlayable;
					if (playableTarget == null) return TaskState.STOP;

					for (int i = 0; i < Amount; i++)
						result.Add(Opposite
							? Entity.FromCard(playableTarget.Controller.Opponent, Cards.FromId(playableTarget.Card.Id))
							: Entity.FromCard(controller, Cards.FromId(playableTarget.Card.Id)));

					break;
				case EntityType.SOURCE:
					var playableSource = source as IPlayable;
					if (playableSource == null) return TaskState.STOP;

					for (int i = 0; i < Amount; i++)
						result.Add(Opposite
							? Entity.FromCard(playableSource.Controller.Opponent, Cards.FromId(playableSource.Card.Id))
							: Entity.FromCard(controller, Cards.FromId(playableSource.Card.Id)));

					break;
				case EntityType.STACK:
					if (stack?.Playables.Count < 1) return TaskState.STOP;

					IZone zone = Opposite
						? controller.Opponent.ControlledZones[_zoneType]
						: controller.ControlledZones[_zoneType];
					foreach (IPlayable p in stack?.Playables)
					{
						if (zone?.IsFull ?? false)
							break;
						for (int i = 0; i < Amount; i++)
						{
							if (zone?.IsFull ?? false)
								break;
							// TODO
							result.Add(Opposite
								? Entity.FromCard(p.Controller.Opponent, Cards.FromId(p.Card.Id), null, zone)
								: Entity.FromCard(controller, Cards.FromId(p.Card.Id), null, zone));
						}
					}

					break;
				case EntityType.EVENT_SOURCE:
					IPlayable eSource = game.CurrentEventData?.EventSource;
					if (eSource == null) return TaskState.STOP;

					for (int i = 0; i < Amount; i++)
						result.Add(Opposite
							? Entity.FromCard(eSource.Controller.Opponent, Cards.FromId(eSource.Card.Id))
							: Entity.FromCard(controller, Cards.FromId(eSource.Card.Id)));

					break;
				case EntityType.OP_HERO_POWER:
					result.Add(Entity.FromCard(controller, Cards.FromId(controller.Opponent.Hero.HeroPower.Card.Id)));
					break;
				case EntityType.WEAPON:
					Weapon weapon = controller.Hero.Weapon;
					if (weapon == null) return TaskState.STOP;

					for (int i = 0; i < Amount; i++)
						result.Add(Entity.FromCard(controller, Cards.FromId(weapon.Card.Id)));

					break;
				default:
					throw new NotImplementedException();
			}

			stack.Playables = result;
			return TaskState.COMPLETE;
		}
	}
}
