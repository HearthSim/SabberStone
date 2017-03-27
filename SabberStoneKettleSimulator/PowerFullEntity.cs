using System;

namespace PowerLogInterpreter
{
    internal class PowerFullEntity : PowerHistoryEntry
    {
        public PowerEntity PowerEntity { get; set; }
        public PowerFullEntity()
        {
            PowerEntity = new PowerEntity();
        }

        public string Id
        {
            get { return PowerEntity.Id; }
            set { PowerEntity.Id = value; }
        }

        public string CardId
        {
            get { return PowerEntity.GetValue("CARD_ID"); }
            set { PowerEntity.Add("CARD_ID", value); }
        }

        public override void Process(PowerGame powerGame)
        {
            throw new NotImplementedException();
        }
    }
}