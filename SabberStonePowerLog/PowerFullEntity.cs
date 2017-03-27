using System;

namespace SabberStonePowerLog
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
            int id;
            if (!int.TryParse(Id, out id))
            {
                throw new NotImplementedException("couldn't intepret this id: " + Id);
            }

            if (powerGame.Entities.ContainsKey(id))
            {
                throw new NotImplementedException("entity is already contained");
            }

            powerGame.Entities.Add(id, PowerEntity);
            Console.WriteLine("Full Entity: " + PowerEntity.ToString());
        }
    }
}