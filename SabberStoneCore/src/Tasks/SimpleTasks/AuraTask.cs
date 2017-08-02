using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{

    public class AuraTask : SimpleTask
    {
        public AuraTask(Enchant aura, EAuraArea area)
        {
            Aura = aura;
            Area = area;
        }

        public Enchant Aura { get; set; }
        public EAuraArea Area { get; set; }

        public override ETaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Aura == null)
            {
                return ETaskState.STOP;
            }

            if (Area == EAuraArea.BOARD)
            {
                Aura.Activate(source.Card.Id, source.Controller.Board.Enchants, source);
            }
            else if (Area == EAuraArea.HAND)
            {
                Aura.Activate(source.Card.Id, source.Controller.Hand.Enchants, source);
            }
            else if (Area == EAuraArea.OP_HAND)
            {
                Aura.Activate(source.Card.Id, source.Controller.Opponent.Hand.Enchants, source);
            }
            else if (Area == EAuraArea.GAME)
            {
                Aura.Activate(source.Card.Id, source.Controller.Game.Enchants, source);
            }
            else if (Area == EAuraArea.SELF)
            {
                Aura.Activate(source.Card.Id, source.Enchants, source);
            }
            else if (Area == EAuraArea.HERO)
            {
                Aura.Activate(source.Card.Id, source.Controller.Hero.Enchants, source);
            }
            else
            {
                throw new NotImplementedException();
            }
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new AuraTask(Aura, Area);
            clone.Copy(this);
            return clone;
        }
    }
}