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
using Newtonsoft.Json.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneKettle
{
	public interface KettlePayload
	{
		JObject ToPayload();
	}

	public abstract class KettleHistoryEntry : KettlePayload
	{
		public abstract JObject ToPayload();

		public static KettlePayload From(IPowerHistoryEntry entry)
		{
			switch (entry.PowerType)
			{
				case PowerType.CREATE_GAME:
					return new KettleHistoryCreateGame((PowerHistoryCreateGame)entry);
				case PowerType.FULL_ENTITY:
					return new KettleHistoryFullEntity((PowerHistoryFullEntity)entry);
				case PowerType.SHOW_ENTITY:
					return new KettleHistoryShowEntity((PowerHistoryShowEntity)entry);
				case PowerType.HIDE_ENTITY:
					return new KettleHistoryHideEntity((PowerHistoryHideEntity)entry);
				case PowerType.TAG_CHANGE:
					return new KettleHistoryTagChange((PowerHistoryTagChange)entry);
				case PowerType.BLOCK_START:
					return new KettleHistoryBlockBegin((PowerHistoryBlockStart)entry);
				case PowerType.BLOCK_END:
					return new KettleHistoryBlockEnd((PowerHistoryBlockEnd)entry);
				default:
					Console.WriteLine("Error, unhandled powertype " + entry.PowerType.ToString());
					return null;
			}
		}
	}

	public class KettleGameJoined : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public bool Spectating;
		public int Board;
		public int MaxSecretsPerPlayer;
		public int MaxFriendlyMinionsPerPlayer;
		public int MaxSecretZoneSizePerPlayer;
		public int MaxQuestsPerPlayer;

		public const String KettleName = "GameJoined";
	}

	public class KettleCreateGame : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public List<KettleCreatePlayer> Players;

		public const String KettleName = "CreateGame";
	}

	public class KettleCreatePlayer : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public String Name;
		public String Hero;
		public List<String> Cards;

		public const String KettleName = "CreatePlayer";
	}

	public class KettleEntity
	{
		public KettleEntity() { }
		public KettleEntity(PowerEntity entity)
		{
			EntityId = entity.Id;
			Tags = KettleUtils.TagsToKettleTags(entity.Tags);
		}
		public KettleEntity(PowerHistoryEntity entity)
		{
			EntityId = entity.Id;
			Tags = KettleUtils.TagsToKettleTags(entity.Tags);
		}

		public int EntityId;
		public Dictionary<int, int> Tags;
	}

	public class KettlePlayer
	{
		public KettlePlayer() { }
		public KettlePlayer(PowerPlayer player)
		{
			Entity = new KettleEntity(player.PowerEntity);
			PlayerId = player.PlayerId;
			AccountId = player.AccountId;
			CardBack = player.CardBack;
		}

		public KettleEntity Entity;
		public int PlayerId;
		public int AccountId;
		public int CardBack;
	}

	public class KettleHistoryMetaData : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryMetaData() { }

		public int Type;
		public int Data;
		public List<int> Info;

		public const String KettleName = "HistoryMetaData";
	}

	public class KettleHistoryTagChange : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryTagChange() { }
		public KettleHistoryTagChange(PowerHistoryTagChange p)
		{
			EntityId = p.EntityId;
			Tag = (int)p.Tag;
			Value = p.Value;
		}

		public int EntityId;
		public int Tag;
		public int Value;

		public const String KettleName = "HistoryTagChange";
	}

	public class KettleHistoryFullEntity : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryFullEntity() { }
		public KettleHistoryFullEntity(PowerHistoryFullEntity p)
		{
			Name = p.Entity.Name;
			Entity = new KettleEntity(p.Entity);
		}

		public KettleEntity Entity;
		public string Name;

		public const String KettleName = "HistoryFullEntity";
	}

	public class KettleHistoryShowEntity : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryShowEntity() { }
		public KettleHistoryShowEntity(PowerHistoryShowEntity p)
		{
			Name = p.Entity.Name;
			Entity = new KettleEntity(p.Entity);
		}

		public KettleEntity Entity;
		public string Name;

		public const String KettleName = "HistoryShowEntity";
	}

	public class KettleHistoryHideEntity : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryHideEntity() { }
		public KettleHistoryHideEntity(PowerHistoryHideEntity p)
		{
			EntityId = p.EntityID;
			Zone = (int)p.Zone;
		}

		public int EntityId;
		public int Zone;

		public const String KettleName = "HistoryHideEntity";
	}

	public class KettleHistoryChangeEntity : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryChangeEntity() { }
		public KettleHistoryChangeEntity(PowerHistoryFullEntity p)
		{
			Name = p.Entity.Name;
			Entity = new KettleEntity(p.Entity);
		}

		public KettleEntity Entity;
		public string Name;

		public const String KettleName = "HistoryChangeEntity";
	}

	public class KettleMetaData : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public int Meta;
		public int Data;
		public int Info;

		public const String KettleName = "MetaData";
	}

	public class KettleChoices : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public int Type;
		public int EntityId;
		public int Source;
		public int Min;
		public int Max;
		public List<int> Choices;

		public const String KettleName = "Choices";
	}

	public class KettleOptionsBlock : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleOptionsBlock() { }
		public KettleOptionsBlock(PowerAllOptions options, int playerID)
		{
			Id = options.Index;
			Options = new List<KettleOption>();
			PlayerId = playerID;

			foreach (PowerOption option in options.PowerOptionList)
				Options.Add(new KettleOption(option));
		}

		public int PlayerId;
		public int Id;
		public List<KettleOption> Options;

		public const String KettleName = "OptionsBlock";
	}

	public class KettleOption
	{

		public KettleOption() { }
		public KettleOption(PowerOption option)
		{
			Type = (int)option.OptionType;

			if (option.MainOption != null)
				MainOption = new KettleSubOption(option.MainOption);

			SubOptions = new List<KettleSubOption>();
			foreach (PowerSubOption sub in option.SubOptions)
				SubOptions.Add(new KettleSubOption(sub));
		}

		public int Type;
		public KettleSubOption MainOption;
		public List<KettleSubOption> SubOptions;
	}

	public class KettleSubOption
	{
		public KettleSubOption() { }
		public KettleSubOption(PowerSubOption option)
		{
			Id = option.EntityId;
			Targets = option.Targets;
		}

		public int Id;
		public List<int> Targets;
	}

	public class KettleSendOption : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public int Id;
		public int MainOption;
		public int Target;
		public int SubOption;
		public int Position;

		public const String KettleName = "SendOption";
	}

	public class KettleEntityChoices : KettlePayload
	{
		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleEntityChoices() { }
		public KettleEntityChoices(PowerEntityChoices choices)
		{
			ChoiceType = (int)choices.ChoiceType;
			CountMax = choices.CountMax;
			CountMin = choices.CountMin;
			Source = choices.SourceId;
			Entities = choices.Entities;
			PlayerId = choices.PlayerId;
			Id = choices.Index;
		}

		public int Id;
		public int ChoiceType;
		public int CountMin;
		public int CountMax;
		public List<int> Entities;
		public int Source;
		public int PlayerId;

		public const String KettleName = "EntityChoices";
	}

	public class KettleHistoryCreateGame : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryCreateGame() { }
		public KettleHistoryCreateGame(PowerHistoryCreateGame p)
		{
			Game = new KettleEntity(p.Game);

			Players = new List<KettlePlayer>();
			foreach (PowerPlayer player in p.Players)
				Players.Add(new KettlePlayer(player));
		}

		public KettleEntity Game;
		public List<KettlePlayer> Players;

		public const String KettleName = "HistoryCreateGame";
	}

	public class KettleHistoryBlockBegin : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryBlockBegin() { }
		public KettleHistoryBlockBegin(PowerHistoryBlockStart p)
		{
			EffectCardId = p.EffectCardId;
			Index = p.Index;
			Source = p.Source;
			Target = p.Target;
			Type = (int)p.BlockType;
		}

		public int Index;
		public int Source;
		public int Target;
		public int Type;
		public string EffectCardId;

		public const String KettleName = "HistoryBlockBegin";
	}

	public class KettleHistoryBlockEnd : KettleHistoryEntry
	{
		public override JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public KettleHistoryBlockEnd() { }
		public KettleHistoryBlockEnd(PowerHistoryBlockEnd end) { }

		public const String KettleName = "HistoryBlockEnd";
	}

	public class KettleChooseEntities : KettlePayload
	{
		public List<int> Choices;
		public int Id;

		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public const String KettleName = "ChooseEntities";
	}

	public class KettleEntitiesChosen : KettlePayload
	{
		public int ChoiceType;
		public int PlayerId;
		public KettleChooseEntities ChooseEntities;

		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public const String KettleName = "EntitiesChosen";
	}

	public class KettleMouseInfo
	{
		public int ArrowOrigin;
		public int HeldCard;
		public int HoverCard;
		public int X;
		public int Y;
	}

	public class KettleUserUI : KettlePayload
	{
		public int? PlayerId;
		public int? Emote;
		public KettleMouseInfo MouseInfo;

		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public const String KettleName = "UserUI";
	}

	public class KettleJoinGame : KettlePayload
	{
		public long AccountId;
		public int GameId;
		public string GamePassword;

		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public const String KettleName = "JoinGame";
	}

	public class KettleStartClient : KettlePayload
	{
		public KettleJoinGame JoinGame;
		public string IP;
		public int Port;
		public int GameType;
		public int Scenario;

		public JObject ToPayload()
		{
			return KettleUtils.CreateKettlePayload(KettleName, this);
		}

		public const String KettleName = "StartClient";
	}

	public class KettleUtils
	{
		public static JObject CreateKettlePayload(String name, object payload)
		{
			JObject packet = new JObject();
			packet.Add("Type", name);
			packet.Add(name, JObject.FromObject(payload));

			return packet;
		}

		public static Dictionary<int, int> TagsToKettleTags(Dictionary<GameTag, int> tags)
		{
			return tags.OrderBy(p => p.Key).ToDictionary(p => (int)p.Key, p => p.Value);
		}
	}
}
