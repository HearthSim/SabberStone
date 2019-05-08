//using System;
//using System.Collections.Generic;
//using System.Text;
//using SabberStoneCore.Model.Entities;
//using SabberStoneCore.Tasks.SimpleTasks;

//namespace SabberStoneCore.Tasks
//{
//	internal readonly ref struct EntityContainer
//	{
//		private readonly ReadOnlySpan<Minion> _boardSpan;
//		private readonly ReadOnlySpan<IPlayable> _zoneSpan;
//		private readonly IPlayable _singleEntity;
//		public EntityContainer(in Controller c, in IEntity source, in ICharacter target, in EntityType type)
//		{
//			switch (type)
//			{
//				case EntityType.INVALID:
//					break;
//				case EntityType.STACK:
//					break;
//				case EntityType.TARGET:
//					_singleEntity = target;
//					break;
//				case EntityType.SOURCE:
//					_singleEntity = (IPlayable)source;
//					break;
//				case EntityType.HERO:
//					_singleEntity = c.Hero;
//					break;
//				case EntityType.HERO_POWER:
//					_singleEntity = c.Hero.HeroPower;
//					break;
//				case EntityType.OP_HERO_POWER:
//					_singleEntity = c.Opponent.Hero.HeroPower;
//					break;
//				case EntityType.EVENT_TARGET:
//					_singleEntity = c.Game.CurrentEventData.EventTarget;
//					break;
//				case EntityType.EVENT_SOURCE:
//					_singleEntity = c.Game.CurrentEventData.EventSource;
//					break;
//				case EntityType.TOPCARDFROMDECK:
//					_singleEntity = c.DeckZone.TopCard;
//					break;
//				case EntityType.OP_TOPDECK:
//					_singleEntity = c.Opponent.DeckZone.TopCard;
//					break;
//				case EntityType.HAND:
//					_zoneSpan = c.HandZone.GetSpan();
//					break;
//				case EntityType.DECK:
//					_zoneSpan = c.DeckZone.GetSpan();
//					break;
//				case EntityType.MINIONS:
//					_boardSpan = c.BoardZone.GetSpan();
//					break;
//				case EntityType.MINIONS_NOSOURCE:
//					_boardSpan = c.BoardZone.GetSpan();
//					break;
//				case EntityType.FRIENDS:
//					break;
//				case EntityType.OP_HERO:
//					break;
//				case EntityType.OP_HAND:
//					break;
//				case EntityType.OP_DECK:
//					break;
//				case EntityType.OP_SECRETS:
//					break;
//				case EntityType.OP_MINIONS:
//					break;
//				case EntityType.ENEMIES:
//					break;
//				case EntityType.ENEMIES_NOTARGET:
//					break;
//				case EntityType.ALL:
//					break;
//				case EntityType.ALL_NOSOURCE:
//					break;
//				case EntityType.WEAPON:
//					break;
//				case EntityType.OP_WEAPON:
//					break;
//				case EntityType.ALLMINIONS:
//					break;
//				case EntityType.ALLMINIONS_NOSOURCE:
//					break;
//				case EntityType.GRAVEYARD:
//					break;
//				case EntityType.HEROES:
//					break;
//				case EntityType.CONTROLLER:
//					break;
//				case EntityType.OP_CONTROLLER:
//					break;
//				default:
//					throw new ArgumentOutOfRangeException(nameof(type), type, null);
//			}
//		}
//	}
//}
