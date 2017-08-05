using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
    public class PlayCardTask : PlayerTask
    {
        public static PlayCardTask Any(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0)
        {
            return new PlayCardTask(controller, source, target, zonePosition, chooseOne);
        }
        public static PlayCardTask Minion(Controller controller, IEntity source, int chooseOne = 0)
        {
            return new PlayCardTask(controller, source, null, -1, chooseOne);
        }
        public static PlayCardTask MinionTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0)
        {
            return new PlayCardTask(controller, source, target, -1, chooseOne);
        }
        public static PlayCardTask Spell(Controller controller, IEntity source, int chooseOne = 0)
        {
            return new PlayCardTask(controller, source, null, -1, chooseOne);
        }
        public static PlayCardTask SpellTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0)
        {
            return new PlayCardTask(controller, source, target, -1, chooseOne);
        }
        private PlayCardTask(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0)
        {
            PlayerTaskType = EPlayerTaskType.PLAY_CARD;
            Game = controller.Game;
            Controller = controller;
            Source = source;
            Target = target;
            ZonePosition = zonePosition;
            ChooseOne = chooseOne;
        }

        public PlayCardTask Copy()
        {
            return new PlayCardTask(Controller, Source, Target, ZonePosition, ChooseOne);
        }

        public override ETaskState Process()
        {
            var success = Generic.PlayCard(Controller, Source as IPlayable, Target as ICharacter, ZonePosition, ChooseOne);
            Controller.Game.NextStep = EStep.MAIN_CLEANUP;
            return ETaskState.COMPLETE;
        }

        public override string FullPrint()
        {
            return $"PlayCardTask => [{Controller.Name}] play {Source}({Source.Card.Type})" +
                   $"{(Target != null ? $" {Target}" : "")}{(ZonePosition > -1 ? $" to Pos[{ZonePosition}]" : "")}" +
                   $"{(ChooseOne != 0 ? $" Option {ChooseOne}" : "")}";
        }
    }
}