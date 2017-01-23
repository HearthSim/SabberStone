using System;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class GameEventManager
    {
        private Game _game;

        public GameEventManager(Game game)
        {
            _game = game;
            game.EntityChangedEvent += EntityChangedEvent;
        }

        private void EntityChangedEvent(object sender, GameTag t, int oldValue, int newValue)
        {
            var entity = (Entity)sender;
            //Log.Info($"EntityChangedEvent - {sender} - {t}, old: {oldValue}, new: {newValue}");

            var game = entity as Game;
            if (game != null && t == GameTag.NEXT_STEP)
            {
                NextStepEvent(game, (Step) newValue);
            }
        }

        public void NextStepEvent(Game game, Step step)
        {
            _game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Event", $"NextStepEvent - {step}");
            switch (step)
            {
                case Step.BEGIN_FIRST:
                    game.Step = step;
                    game.BeginFirst();
                    break;
                case Step.BEGIN_SHUFFLE:
                    game.Step = step;
                    game.BeginShuffle();
                    break;
                case Step.BEGIN_DRAW:
                    game.Step = step;
                    game.BeginDraw();
                    break;
                //case Step.BEGIN_MULLIGAN:

                case Step.MAIN_BEGIN:
                    break;

                case Step.MAIN_READY:
                    game.Step = step;
                    game.BeginTurn();
                    break;
                case Step.MAIN_RESOURCE:
                    game.Step = step;
                    game.BeginTurnRessources();
                    break;
                case Step.MAIN_DRAW:
                    break;
                case Step.MAIN_START:
                    game.Step = step;
                    game.BeginTurnPlayer();
                    break;
                case Step.MAIN_START_TRIGGERS:
                    game.Step = step;
                    game.BeginTurnTriggers();
                    break;

                case Step.MAIN_ACTION:
                    game.Step = step;
                    break;
                case Step.MAIN_COMBAT:
                    break;
                case Step.MAIN_CLEANUP:
                    game.Step = step;
                    game.CleanUp();
                    break;

                case Step.MAIN_END:
                    game.Step = step;
                    game.EndTurnPlayer();
                    break;
                case Step.MAIN_NEXT:
                    game.Step = step;
                    game.EndTurn();
                    break;

                case Step.FINAL_WRAPUP:
                    game.WrapUp();
                    break;
                case Step.FINAL_GAMEOVER:
                    game.GameOver();
                    break;

                case Step.INVALID:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(step), step, null);
            }
        }
    }
}