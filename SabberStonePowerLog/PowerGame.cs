using System;
using System.Collections.Generic;

namespace SabberStonePowerLog
{
    public class PowerGame
    {
        public List<PowerHistoryEntry> PowerHistory { get; set; }

        public GameEntity Game 
        {
            get
            {
                PowerEntity value;
                if (Entities.TryGetValue(1, out value))
                {
                    return value as GameEntity;
                }
                return null;
            }
            set { Entities.Add(1, value); } 
        }

        public Player Player1 
        { 
            get 
            {
                PowerEntity value;
                if (Entities.TryGetValue(2, out value))
                {
                    return value as Player;
                }
                return null; 
            }
            set { Entities.Add(2, value); } 
        }

        public Player Player2
        {
            get
            {
                PowerEntity value;
                if (Entities.TryGetValue(3, out value))
                {
                    return value as Player;
                }
                return null;
            }
            set { Entities.Add(3, value); }
        }

        public Dictionary<int, PowerEntity> Entities { get; set; }

        public int LastFullEntityId { get; set; }
        
        public void AddFullEntity(int id, PowerEntity entity)
        {
            LastFullEntityId = id;
            Entities.Add(id, entity);
        }

        public PowerGame() 
        {
            Entities = new Dictionary<int, PowerEntity>();
            PowerHistory = new List<PowerHistoryEntry>();
        }

        public PowerEntity GetEntityById(int id)
        {
            return Entities[id];
        }

        public int GetIdByName(string name)
        {
            if (Game.Name == name)
            { 
                return 1;
            }
            else if (Player1.Name == name)
            {
                return 2;
            }
            else if (Player2.Name == name)
            {
                return 3;
            }
            else
            {
                throw new Exception("Unknown name, haven't found in entities.");
            }
        }

    }
}
