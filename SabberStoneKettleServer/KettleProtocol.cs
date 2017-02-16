using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneKettleServer
{
    public class KettleCreateGame
    {
        public List<KettleCreatePlayer> Players;
    }

    public class KettleCreatePlayer
    {
        public String Name;
        public String Hero;
        public List<String> Cards;
    }

    public class KettleEntity
    {
        public int EntityID;
        public Dictionary<string, int> Tags;
    }

    public class KettlePlayer
    {
        public KettleEntity KettleEntity;
        public int PlayerID;
    }

    public class KettleTagChange
    {
        public int EntityID;
        public int Tag;
        public int Value;
    }

    public class KettleActionStart
    {
        public int EntityID;
        public int SubType;
        public int Index;
        public int Target;
    }

    public class KettleFullEntity
    {
        public KettleEntity KettleEntity;
        public string CardID;
    }

    public class KettleMetaData
    {
        public int Meta;
        public int Data;
        public int Info;
    }

    public class KettleChoices
    {
        public int Type;
        public int EntityID;
        public int Source;
        public int Min;
        public int Max;
        public List<int> Choices;
    }

    public class KettleOption
    {
        public int Type;
        public KettleSubOption MainOption;
        public List<KettleSubOption> SubOptions;
    }

    public class KettleSubOption
    {
        public int ID;
        public List<int> Targets;
    }

    public class KettleSendOption
    {
        public int Index;
        public int Target;
        public int SubOption;
        public int Position;
    }

    public class KettleEntityChoices
    {
        public int ChoiceType;
        public int CountMin;
        public int CountMax;
        public List<int> Entities;
        public int Source;
        public int PlayerID;
    }
}
