using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Actions
{
	public partial class Generic
	{
		public static IPlayable Copy(in Controller controller, in IPlayable source, in Zone targetZone)
		{
			bool copyEnchantments;
			Zone sourceZone = source.Zone.Type;
			if (sourceZone == targetZone)
				copyEnchantments = true;
			else if (targetZone == Zone.PLAY)
				copyEnchantments = true;
			else if (sourceZone == Zone.DECK)
				copyEnchantments = true;
			else if (sourceZone == Zone.HAND && targetZone != Zone.DECK)
				copyEnchantments = true;
			else
				copyEnchantments = false;

			var tags = new EntityData()
			{
				[GameTag.DISPLAYED_CREATOR] = source.Id
			};

			IPlayable copiedEntity = Entity.FromCard(in controller, source.Card);

			if (copiedEntity is Character c)
				((Character)source).CopyInternalAttributes(in c);

			if (copyEnchantments)
			{
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
						}
					}
				}

				var kvps = new KeyValuePair<GameTag, int>[source.NativeTags.Count];
				source.NativeTags.CopyTo(kvps, 0);

				for (int i = 0; i < kvps.Length; i++)
				{
					switch (kvps[i].Key)
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
							tags.Add(kvps[i]);
							break;
					}
				}
			}

			return copiedEntity;
		}
	}
}
