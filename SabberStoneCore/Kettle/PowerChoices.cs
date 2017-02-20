using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

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
        private static int _index = 1;
        public int Index
        {
            get { return _index; }
            private set { _index = value; }
        }

        public ChoiceType ChoiceType { get; set; }
        public int CountMin { get; set; }
        public int CountMax { get; set; }
        public List<int> Entities { get; set; }
        public int SourceId { get; set; }
        public int PlayerId { get; set; }
        public bool HideChosen { get; set; }

        public List<PowerOption> PowerOptionList { get; set; }

        public PowerEntityChoices()
        {
            Index++;
            Entities = new List<int>();
        }
    }

    public class PowerChoicesBuilder
    {
        public static PowerEntityChoices EntityChoices(Choice choice)
        {
            var result = new PowerEntityChoices
            {
                ChoiceType = choice.ChoiceType
            };

            return result;
        }
    }
}