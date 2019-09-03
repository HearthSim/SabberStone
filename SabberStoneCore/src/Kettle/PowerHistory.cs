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
using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Kettle
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
{
	public class PowerHistoryBuilder
	{
		public static PowerHistoryCreateGame CreateGame(Game game, Controller[] players)
		{
			return new PowerHistoryCreateGame()
			{
				Game = new PowerEntity
				{
					Id = game.Id,
					Tags = new Dictionary<GameTag, int>(game._data)
				},
				Players = new[]
						{
					new PowerPlayer
					{
						PlayerId = players[0].PlayerId,
						AccountId = 12718623,
						CardBack = 0,
						PowerEntity = new PowerEntity
						{
							Id = players[0].Id,
							Tags = new Dictionary<GameTag, int>(players[0]._data)
						}
					},
					new PowerPlayer
					{
						PlayerId = players[1].PlayerId,
						AccountId = 18463223,
						CardBack = 0,
						PowerEntity = new PowerEntity
						{
							Id = players[1].Id,
							Tags = new Dictionary<GameTag, int>(players[1]._data)
						}
					},
						}
			};
		}

		public static PowerHistoryTagChange TagChange(int id, GameTag tag, int value)
		{
			return new PowerHistoryTagChange()
			{
				EntityId = id,
				Tag = tag,
				Value = value
			};
		}

		public static PowerHistoryFullEntity FullEntity(IPlayable playable)
		{
			var tags = new Dictionary<GameTag, int>(((Entity)playable)._data);
			gameTagsEntities.ForEach(p => tags[p] = playable[p]);
			if (playable is Character c)
			{
				tags[GameTag.ATK] = c.AttackDamage;
				tags[GameTag.HEALTH] = c.Health;
				tags[GameTag.DAMAGE] = c.Damage;
			}

			return new PowerHistoryFullEntity
			{
				Entity = new PowerHistoryEntity
				{
					Id = playable.Id,
					Name = playable.Card.Id,
					Tags = tags
				}
			};
		}

		private static List<GameTag> gameTagsEntities = new List<GameTag>()
		{
			GameTag.PREMIUM,
			GameTag.ATK,
			GameTag.HEALTH,
			GameTag.DURABILITY,
			GameTag.DAMAGE,
			GameTag.COST,
			GameTag.ZONE,
			GameTag.ZONE_POSITION,
			GameTag.CONTROLLER,
			GameTag.ENTITY_ID,
			GameTag.SILENCED,
			GameTag.WINDFURY,
			GameTag.TAUNT,
			GameTag.STEALTH,
			GameTag.DIVINE_SHIELD,
			GameTag.POISONOUS,
			GameTag.LIFESTEAL,
			GameTag.CHARGE,
			GameTag.FACTION,
			GameTag.CARDTYPE,
			GameTag.RARITY,
			GameTag.BATTLECRY,
			GameTag.DEATHRATTLE,
			GameTag.FROZEN,
			GameTag.NUM_ATTACKS_THIS_TURN,
			GameTag.FORCED_PLAY,
			GameTag.TO_BE_DESTROYED,
			GameTag.START_WITH_1_HEALTH,
			GameTag.CUSTOM_KEYWORD_EFFECT,
			GameTag.EXTRA_ATTACKS_THIS_TURN
		};

		public static PowerHistoryShowEntity ShowEntity(IPlayable playable)
		{
			var tags = new Dictionary<GameTag, int>(((Entity)playable)._data);
			gameTagsEntities.ForEach(p => tags[p] = playable[p]);
			//tags[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = playable[GameTag.COST];

			return new PowerHistoryShowEntity
			{
				Entity = new PowerHistoryEntity
				{
					Id = playable.Id,
					Name = playable.Card.Id,
					Tags = tags
				}
			};
		}

		public static IPowerHistoryEntry HideEntity(IPlayable playable)
		{
			return new PowerHistoryHideEntity
			{
				EntityID = playable.Id,
				Zone = playable.Zone.Type
			};
		}

		public static PowerHistoryBlockStart BlockStart(BlockType blockType, int source, string effectCardId, int index, int target)
		{
			return new PowerHistoryBlockStart
			{
				BlockType = blockType,
				Source = source,
				EffectCardId = effectCardId,
				Index = index,
				Target = target
			};
		}

		public static PowerHistoryBlockEnd BlockEnd()
		{
			return new PowerHistoryBlockEnd();
		}
	}

	//message PowerHistory
	//{
	//    enum PacketID
	//    {
	//        ID_acd5 = 19;
	//    }
	//    repeated PowerHistoryData list = 1;
	//}
	public class PowerHistory
	{
		public List<IPowerHistoryEntry> Full { get; } = new List<IPowerHistoryEntry>();
		public List<IPowerHistoryEntry> Last { get; } = new List<IPowerHistoryEntry>();

		public void Add(IPowerHistoryEntry entry)
		{
			Full.Add(entry);
			Last.Add(entry);
		}

		public string Print(bool fullFlag = true)
		{
			var str = new StringBuilder();
			if (fullFlag)
				Full.ForEach(p => str.Append(p.Print()));
			else
				Last.ForEach(p => str.Append(p.Print()));
			return str.ToString();
		}
	}

	//message PowerHistoryData
	//{
	//    optional PowerHistoryEntity full_entity = 1;
	//    optional PowerHistoryEntity show_entity = 2;
	//    optional PowerHistoryHide hide_entity = 3;
	//    optional PowerHistoryTagChange tag_change = 4;
	//    optional PowerHistoryCreateGame create_game = 5;
	//    optional PowerHistoryStart power_start = 6;
	//    optional PowerHistoryEnd power_end = 7;
	//    optional PowerHistoryMetaData meta_data = 8;
	//    optional PowerHistoryEntity change_entity = 9;
	//}
	public interface IPowerHistoryEntry
	{
		PowerType PowerType { get; }
		string Print();
	}

	//message PowerHistoryCreateGame
	//{
	//    required Entity game_entity = 1;
	//    repeated Player players = 2;
	//}
	public class PowerHistoryCreateGame : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.CREATE_GAME;
		public PowerEntity Game { get; set; }
		public PowerPlayer[] Players { get; set; }
		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType}");
			str.AppendLine($" - Game Entity = [{Game.Print()}]");
			foreach (PowerPlayer player in Players)
			{
				str.AppendLine($" - Player Entity = [{player.Print()}]");
			}
			return str.ToString();
		}
	}

	//message PowerHistoryStart
	//{
	//    required HistoryBlock.Type type = 1;
	//    required int32 index = 2;
	//    required int32 source = 3;
	//    required int32 target = 4;
	//    optional string effect_card_id = 5;
	//}
	public class PowerHistoryBlockStart : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.BLOCK_START;
		public BlockType BlockType { get; set; }
		public int Index { get; set; } = -1;
		public int Source { get; set; }
		public int Target { get; set; }
		public string EffectCardId { get; set; } = "";

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} {BlockType} Entity=[{Source}] EffectCardId={EffectCardId} EffectIndex={Index} Target={Target}");
			return str.ToString();
		}
	}

	//message PowerHistoryEnd
	//{
	//}
	public class PowerHistoryBlockEnd : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.BLOCK_END;

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType}");
			return str.ToString();
		}
	}

	public class PowerHistoryFullEntity : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.FULL_ENTITY;
		public PowerHistoryEntity Entity { get; set; }

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} - Creating Entity = [{Entity.Print()}]");
			return str.ToString();
		}
	}

	public class PowerHistoryShowEntity : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.SHOW_ENTITY;
		public PowerHistoryEntity Entity { get; set; }
		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} - Updating Entity = [{Entity.Print()}]");
			return str.ToString();
		}
	}

	//message PowerHistoryHide
	//{
	//    required int32 entity = 1;
	//    required int32 zone = 2;
	//}
	public class PowerHistoryHideEntity : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.HIDE_ENTITY;
		public int EntityID { get; set; }
		public Zone Zone { get; set; }

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} Entity = [{EntityID}] tag={Zone}");
			return str.ToString();
		}
	}

	//message PowerHistoryTagChange
	//{
	//    required int32 entity = 1;
	//    required int32 tag = 2;
	//    required int32 value = 3;
	//}
	public class PowerHistoryTagChange : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.TAG_CHANGE;
		public int EntityId { get; set; }
		public GameTag Tag { get; set; }
		public int Value { get; set; }

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine(Model.Tag.TypedTags.ContainsKey(Tag)
				? $"{PowerType} Entity = [{EntityId}] Tag={Tag} Value={Enum.GetName(Model.Tag.TypedTags[Tag], Value)}"
				: $"{PowerType} Entity = [{EntityId}] Tag={Tag} Value={Value}");
			return str.ToString();
		}

		public override string ToString()
		{
			return $"[{EntityId}][{Tag}][{Value}]";
		}
	}

	//message PowerHistoryMetaData
	//{
	//    repeated int32 info = 2;
	//    HistoryMeta.Type type = 3;
	//    int32 data = 4;
	//}
	public class PowerHistoryMetaData : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.META_DATA;
		public MetaDataType Type { get; set; }
		public int Data { get; set; }
		public List<int> Info { get; set; }

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} Type={Type} Data={Data} Info={string.Join(", ", Info)}");
			return str.ToString();
		}
	}

	public class PowerHistoryChangeEntity : IPowerHistoryEntry
	{
		public PowerType PowerType => PowerType.CHANGE_ENTITY;
		public string CardId { get; set; }
		public PowerHistoryEntity Entity { get; set; }

		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"{PowerType} Type={CardId} - Change Entity = [{Entity.Print()}]");
			return str.ToString();
		}
	}

	//message PowerHistoryEntity
	//{
	//    required int32 entity = 1;
	//    required string name = 2;
	//    repeated Tag tags = 3;
	//}
	//message Tag
	//{
	//    required int32 name = 1;
	//    required int32 value = 2;
	//}
	public class PowerHistoryEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IDictionary<GameTag, int> Tags { get; set; } = new Dictionary<GameTag, int>();
		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"Id={Id}, Name={Name}, Tags=[");
			foreach (KeyValuePair<GameTag, int> pair in Tags)
			{
				str.AppendLine(Tag.TypedTags.ContainsKey(pair.Key)
					? $"      [{pair.Key},{Enum.GetName(Tag.TypedTags[pair.Key], pair.Value)}]"
					: $"      [{pair.Key},{pair.Value}]");
			}
			str.Append("]");
			return str.ToString();
		}
	}

	//message Player
	//{
	//    required int32 id = 1;
	//    required pegasus.pegasusshared.BnetId game_account_id = 2;
	//    required int32 card_back = 3;
	//    required Entity entity = 4;
	//}
	public class PowerPlayer
	{
		public int PlayerId { get; set; }
		public int AccountId { get; set; }
		public int CardBack { get; set; }
		public PowerEntity PowerEntity { get; set; }
		public string Print()
		{
			var str = new StringBuilder();
			str.Append($"PlayerId={PlayerId}, AccountId={AccountId}, CardBack={CardBack}, Entity=[{PowerEntity.Print()}]");
			return str.ToString();
		}
	}

	//message Entity
	//{
	//    required int32 id = 1;
	//    repeated Tag tags = 2;
	//}
	public class PowerEntity
	{
		public int Id { get; set; }
		public Dictionary<GameTag, int> Tags { get; set; } = new Dictionary<GameTag, int>();
		public string Print()
		{
			var str = new StringBuilder();
			str.AppendLine($"Id={Id} Tags=[");
			foreach (KeyValuePair<GameTag, int> pair in Tags)
			{
				str.AppendLine($"      [{pair.Key},{pair.Value}]");
			}
			str.Append("]");
			return str.ToString();
		}
	}
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
