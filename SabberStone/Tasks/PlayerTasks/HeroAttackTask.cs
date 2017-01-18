using HearthDb.Enums;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.PlayerTasks
{
    public class HeroAttackTask : PlayerTask
    {
        public static HeroAttackTask Any(Controller controller, IEntity target)
        {
            return new HeroAttackTask(controller, target);
        }
        private HeroAttackTask(Controller controller, IEntity target)
        {
            PlayerTaskType = PlayerTaskType.HERO_ATTACK;
            Game = controller.Game;
            Controller = controller;
            Target = target;
        }
        public override TaskState Process()
        {
            var success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target as ICharacter);
            Controller.Game.NextStep = Step.MAIN_CLEANUP;
            return TaskState.COMPLETE;
        }

        public override string FullPrint()
        {
            return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
        }
    }
}