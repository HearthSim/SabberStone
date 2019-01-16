using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.Actions
{
	public partial class Generic
	{
		public static IPlayable Copy(in Controller controller, in IEntity creator, in IPlayable source, Zone targetZone, bool deathrattle = false)
		{
			// Determine whether enchantments should be also copied.
			// Whenever a card moves forward in that flow (Deck -> Hand, Hand -> Play, Deck -> Play),
			// it retains enchantments. If a card moves backwards in zones
			// (Play -> Hand, Hand -> Deck, Play -> Deck, Play/Hand/Deck -> Graveyard and
			// Graveyard -> Play/Hand/Deck), it loses enchantments.
			// https://playhearthstone.com/en-gb/blog/21965466
			bool copyEnchantments;

			Zone sourceZone = source.Zone?.Type ?? Zone.PLAY;

			if (sourceZone == Zone.GRAVEYARD)
				copyEnchantments = false;
			else if (sourceZone == targetZone)
				copyEnchantments = true;
			else if (targetZone == Zone.SETASIDE)
				copyEnchantments = false;
			else if (targetZone == Zone.PLAY)
				copyEnchantments = true;
			else if (sourceZone == Zone.DECK)
				copyEnchantments = true;
			else if (sourceZone == Zone.HAND && targetZone != Zone.DECK)
				copyEnchantments = true;
			else
				copyEnchantments = false;

			IPlayable copiedEntity;

			if (copyEnchantments)
			{
				var tags = new EntityData()
				{
					[GameTag.DISPLAYED_CREATOR] = creator.Id
				};

				copiedEntity = Entity.FromCard(in controller, source.Card, tags);

				int? modifiedCost = ((Playable)source)._modifiedCost;

				if (modifiedCost.HasValue)
					copiedEntity.Cost = modifiedCost.Value;

				if (copiedEntity is Character c)
					((Character)source).CopyInternalAttributes(in c);


				if (source.AppliedEnchantments != null)
				{
					foreach (Enchantment e in source.AppliedEnchantments)
					{
						Enchantment instance = Enchantment.GetInstance(in controller, e.Creator, copiedEntity, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];

							instance.CapturedCard = e.CapturedCard;
						}

						if (e.IsOneTurnActive)
							instance.Game.OneTurnEffectEnchantments.Add(instance);
					}
					
				}

				var kvps = new KeyValuePair<GameTag, int>[source.NativeTags.Count];
				source.NativeTags.CopyTo(kvps, 0);

				//for (int i = 0; i < kvps.Length; i++)
				//{
				//	switch (kvps[i].Key)
				//	{
				//		case GameTag.ENTITY_ID:
				//		case GameTag.CONTROLLER:
				//		case GameTag.ZONE:
				//		case GameTag.ZONE_POSITION:
				//		case GameTag.CREATOR:
				//		case GameTag.DISPLAYED_CREATOR:
				//		case GameTag.EXHAUSTED:
				//			continue;
				//		case GameTag.COST:
				//			copiedEntity.AuraEffects.ToBeUpdated = true;
				//			goto default;
				//		default:
				//			tags.Add(kvps[i]);
				//			break;
				//	}
				//}

				List<(int entityId, IEffect effect)> oneTurnEffects = controller.Game.OneTurnEffects;
				for (int i = oneTurnEffects.Count - 1; i >= 0; i--)
				{
					(int id, IEffect effect) = oneTurnEffects[i];
					if (id == source.Id)
						oneTurnEffects.Add((copiedEntity.Id, effect));
				}
			}
			else
			{
				copiedEntity = Entity.FromCard(in controller, source.Card);
				copiedEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, creator.Id);
			}

			switch (targetZone)
			{
				case Zone.HAND:
					Generic.AddHandPhase.Invoke(controller, copiedEntity);
					break;
				case Zone.DECK:
					Generic.ShuffleIntoDeck.Invoke(controller, creator, copiedEntity);
					break;
				case Zone.PLAY:
					int position = -1;
					if (deathrattle)
					{
						position = ((Minion) source).LastBoardPosition;
						if (position > controller.BoardZone.Count)
							position = controller.BoardZone.Count;
					}
					Generic.SummonBlock.Invoke(controller.Game, (Minion) copiedEntity, position);
					break;
				case Zone.SETASIDE:
					controller.SetasideZone.Add(copiedEntity);
					break;
			}

			if (copyEnchantments && source.OngoingEffect != null && copiedEntity.OngoingEffect == null)
				source.OngoingEffect.Clone(copiedEntity);

			return copiedEntity;
		}
	}
}
