using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Kettle
{
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

    public class PowerHistoryBuilder
    {
        public static PowerHistoryCreateGame CreateGame(Game game, Controller[] players)
        {
            return new PowerHistoryCreateGame()
            {
                Game = new PowerEntity
                {
                    Id = game.Id,
                    Tags = new Dictionary<GameTag, int>(((Entity)game)._data.Tags)
                },
                Players = new PowerPlayer[]
                        {
                    new PowerPlayer
                    {
                        PlayerId = players[0].PlayerId,
                        AccountId = 12718623,
                        CardBack = 100,
                        PowerEntity = new PowerEntity
                        {
                            Id = players[0].Id,
                            Tags = new Dictionary<GameTag, int>(((Entity)players[0])._data.Tags)
                        }
                    },
                    new PowerPlayer
                    {
                        PlayerId = players[1].PlayerId,
                        AccountId = 18463223,
                        CardBack = 100,
                        PowerEntity = new PowerEntity
                        {
                            Id = players[1].Id,
                            Tags = new Dictionary<GameTag, int>(((Entity)players[1])._data.Tags)
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
            return new PowerHistoryFullEntity
            {
                Entity = new PowerHistoryEntity
                {
                    Id = playable.Id,
                    Name = playable.Card.Id,
                    Tags = new Dictionary<GameTag, int>(((Entity)playable)._data.Tags)
                }
            };
        }
    }

    public interface IPowerHistoryEntry
    {
        PowerType PowerType { get; }
        string Print();
    }


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
            foreach (var player in Players)
            {
                str.AppendLine($" - Player Entity = [{player.Print()}]");
            }
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
        public string Print() => "";
    }

    public class PowerHistoryTagChange : IPowerHistoryEntry
    {
        public PowerType PowerType => PowerType.TAG_CHANGE;
        public int EntityId { get; set; }
        public GameTag Tag { get; set; }
        public int Value { get; set; }

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"{PowerType} Entity = [{EntityId}] Tag={Tag} Value={Value}");
            return str.ToString();
        }
    }

    public class PowerHistoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<GameTag, int> Tags { get; set; } = new Dictionary<GameTag, int>();
        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"Id={Id}, Name={Name}, Tags=[");
            foreach (var pair in Tags)
            {
                str.AppendLine($"      [{pair.Key},{pair.Value}]");
            }
            str.Append("]");
            return str.ToString();
        }
    }

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

    public class PowerEntity
    {
        public int Id { get; set; }
        public Dictionary<GameTag, int> Tags { get; set; } = new Dictionary<GameTag, int>();
        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"Id={Id} Tags=[");
            foreach (var pair in Tags)
            {
                str.AppendLine($"      [{pair.Key},{pair.Value}]");
            }
            str.Append("]");
            return str.ToString();
        }
    }
}

//message Player
//{
//    required int32 id = 1;
//    required pegasus.pegasusshared.BnetId game_account_id = 2;
//    required int32 card_back = 3;
//    required Entity entity = 4;
//}

//message Entity
//{
//    required int32 id = 1;
//    repeated Tag tags = 2;
//}

//message PowerHistory
//{
//    enum PacketID
//{
//    ID_acd5 = 19;
//}

//repeated PowerHistoryData list = 1;
//}

//message PowerHistoryCreateGame
//{
//    required Entity game_entity = 1;
//    repeated Player players = 2;
//}

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

//message PowerHistoryEnd
//{
//}

//message PowerHistoryEntity
//{
//    required int32 entity = 1;
//    required string name = 2;
//    repeated Tag tags = 3;
//}

//message PowerHistoryHide
//{
//    required int32 entity = 1;
//    required int32 zone = 2;
//}

//message PowerHistoryMetaData
//{
//    repeated int32 info = 2 [packed=true];
//    optional HistoryMeta.Type type = 3 [default = TARGET];
//    optional int32 data = 4;
//}

//message PowerHistoryStart
//{
//    required HistoryBlock.Type type = 1;
//    required int32 index = 2;
//    required int32 source = 3;
//    required int32 target = 4;
//    optional string effect_card_id = 5;
//}

//message PowerHistoryTagChange
//{
//    required int32 entity = 1;
//    required int32 tag = 2;
//    required int32 value = 3;
//}
