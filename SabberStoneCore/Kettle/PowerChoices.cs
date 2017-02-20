using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Kettle
{
    //message EntityChoices
    //{
    //    enum PacketID
    //    {
    //        ID_a5d9 = 17;
    //    }
    //    required int32 id = 1;
	//    required int32 choice_type = 2;
	//    required int32 count_min = 4;
	//    required int32 count_max = 5;
	//    repeated int32 entities = 6 [packed=true];
	//    optional int32 source = 7;
	//    required int32 player_id = 8;
	//    required bool hide_chosen = 9;
    //}
    public class PowerEntityChoices
    {
        public int Id { get; set; }
        public ChoiceType ChoiceType { get; set; }
        public int CountMin { get; set; }
        public int CountMax { get; set; }
        public List<int> Entities { get; set; }
        public int SourceId { get; set; }
        public int PlayerId { get; set; }
        public bool HideChosen { get; set; }
    }
}
