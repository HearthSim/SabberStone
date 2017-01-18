using System;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public enum AuraArea
    {
        BOARD,
        HAND,
        GAME,
        HERO,
        SELF
    }

    public class AuraTask : SimpleTask
    {
        public AuraTask(Enchant aura, AuraArea area)
        {
            Aura = aura;
            Area = area;
        }

        public Enchant Aura { get; set; }
        public AuraArea Area { get; set; }

        public override TaskState Process()
        {
            var source = Source as IPlayable;
            if (source == null || Aura == null)
            {
                return TaskState.STOP;
            }

            if (Area == AuraArea.BOARD)
            {
                Aura.Activate(source.Card.Id, source.Controller.Board.Enchants, source);
            }
            else if (Area == AuraArea.HAND)
            {
                Aura.Activate(source.Card.Id, source.Controller.Hand.Enchants, source);
            }
            else if (Area == AuraArea.GAME)
            {
                Aura.Activate(source.Card.Id, source.Controller.Game.Enchants, source);
            }
            else if (Area == AuraArea.SELF)
            {
                Aura.Activate(source.Card.Id, source.Enchants, source);
            }
            else if (Area == AuraArea.HERO)
            {
                Aura.Activate(source.Card.Id, source.Controller.Hero.Enchants, source);
            }
            else
            {
                throw new NotImplementedException();
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new AuraTask(Aura, Area);
            clone.Copy(this);
            return clone;
        }
    }
}