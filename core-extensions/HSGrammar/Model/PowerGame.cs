using System.Collections.Generic;
using System.Linq;

namespace HSGrammar.Model
{
    public class PowerGame
    {
        public Queue<PowerLogEntry> Entries;

        public List<PowerEntity> Entities;

        public PowerGame()
        {
            Entries = new Queue<PowerLogEntry>();
        }

        public PowerEntity GetEntityById(int id)
        {
            IEnumerable<PowerEntity> enumerable = null;
            if ((enumerable = Entities.Where(p => p.EntityId == id)).Any() && enumerable.Count() == 1)
            {
                return enumerable.First();
            }
            else
            {
                throw new KeyNotFoundException($"Haven't found id '{id}' in entities of powergame!");
            }
        }
    }
}
