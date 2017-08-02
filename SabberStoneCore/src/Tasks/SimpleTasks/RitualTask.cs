using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RitualTask : SimpleTask
    {

        public RitualTask(Enchant enchant = null, bool taunt = false)
        {
            Enchant = enchant;
            Taunt = taunt;
        }

        public Enchant Enchant { get; set; }

        public bool Taunt { get; set; }

        public override ETaskState Process()
        {
            //[irc] Patashu @darkfriend77 yeah, that's the general idea. 
            // there's two kinds of triggers, one when a c'thun is summoned or 
            // generated in hand or moved to hand that copies the ritual buffs 
            // on the proxy to that c'thun, one when a new c'thun buff is made 
            // (or maybe it's a card effect not a trigger? or even an aura style 
            // effect ??) that copies the additional effect to c'thuns in your 
            // hand and board that aren't silenced

            if (!Controller.SeenCthun)
            {
                var proxyCthun = Entity.FromCard(Controller, Cards.FromId("OG_279"));
                proxyCthun[EGameTag.REVEALED] = 1;
                Controller.Setaside.Add(proxyCthun);
                Controller.ProxyCthun = proxyCthun.Id;
                Controller.SeenCthun = true;
            }

            var entities = new List<IPlayable> {Game.IdEntityDic[Controller.ProxyCthun]};
            entities.AddRange(Controller.Board.GetAll.Where(p => p.Card.Id.Equals("OG_280")));
            entities.AddRange(Controller.Hand.GetAll.Where(p => p.Card.Id.Equals("OG_280")));

            if (Enchant != null)
            {
                // activate enchants on the sources
                entities.ForEach(p => Enchant.Activate(Source.Card.Id, p.Enchants, p));
            }

            if (Taunt)
            {
                entities.ForEach(p => p[EGameTag.TAUNT] = 1);
            }

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RitualTask(Enchant, Taunt);
            clone.Copy(this);
            return clone;
        }
    }
}