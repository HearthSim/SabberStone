using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class PowerHistory
    {
    }

    public class PowerLogEntry
    {
        public PowerType powerType;

        public Dictionary<GameTag, int> tags;
    }

    public class PowerHistoryEntity
    {
        public int id;

        public string name;

        public Dictionary<GameTag, int> tags;
    }
}

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
