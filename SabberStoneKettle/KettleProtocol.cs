using Newtonsoft.Json.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

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
            EntityID = entity.Id;
            Tags = KettleUtils.TagsToKettleTags(entity.Tags);
        }
        public KettleEntity(PowerHistoryEntity entity)
        {
            EntityID = entity.Id;
            Tags = KettleUtils.TagsToKettleTags(entity.Tags);
        }

        public int EntityID;
        public Dictionary<int, int> Tags;
    }

    public class KettlePlayer
    {
        public KettlePlayer() { }
        public KettlePlayer(PowerPlayer player)
        {
            Entity = new KettleEntity(player.PowerEntity);
            PlayerID = player.PlayerId;
            CardBack = player.CardBack;
        }

        public KettleEntity Entity;
        public int PlayerID;
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
            EntityID = p.EntityId;
            Tag = (int)p.Tag;
            Value = p.Value;
        }

        public int EntityID;
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
            EntityID = p.EntityID;
            Zone = (int)p.Zone;
        }

        public int EntityID;
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
        public int EntityID;
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
            ID = options.Index;
            Options = new List<KettleOption>();
            PlayerID = playerID;

            foreach (var option in options.PowerOptionList)
                Options.Add(new KettleOption(option));
        }

        public int PlayerID;
        public int ID;
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
            foreach (var sub in option.SubOptions)
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
            ID = option.EntityId;
            Targets = option.Targets;
        }

        public int ID;
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
            PlayerID = choices.PlayerId;
            ID = choices.Index;
        }

        public int ID;
        public int ChoiceType;
        public int CountMin;
        public int CountMax;
        public List<int> Entities;
        public int Source;
        public int PlayerID;

        public const String KettleName = "EntityChoices";
    }

    public class KettleHistoryCreateGame : KettleHistoryEntry
    {
        public override JObject ToPayload()
        {
            return KettleUtils.CreateKettlePayload(KettleName, this);
        }

        public KettleHistoryCreateGame() {}
        public KettleHistoryCreateGame(PowerHistoryCreateGame p)
        {
            Game = new KettleEntity(p.Game);

            Players = new List<KettlePlayer>();
            foreach (var player in p.Players)
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
        public int ID;

        public JObject ToPayload()
        {
            return KettleUtils.CreateKettlePayload(KettleName, this);
        }

        public const String KettleName = "ChooseEntities";
    }

    public class KettleEntitiesChosen : KettlePayload
    {
        public int ChoiceType;
        public int PlayerID;
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
        public int? PlayerID;
        public int? Emote;
        public KettleMouseInfo MouseInfo;

        public JObject ToPayload()
        {
            return KettleUtils.CreateKettlePayload(KettleName, this);
        }

        public const String KettleName = "UserUI";
    }

    public class KettleJoinGame: KettlePayload
    {
        public long PlayerID;
        public int GameID;
        public string GamePassword;

        public JObject ToPayload()
        {
            return KettleUtils.CreateKettlePayload(KettleName, this);
        }

        public const String KettleName = "JoinGame";
    }

    public class KettleStartClient: KettlePayload
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
