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

            if (game != null && t == GameTag.MULLIGAN_STATE)
            {
                if (game.Player1.MulliganState == Mulligan.DONE
                 || game.Player2.MulliganState == Mulligan.DONE)
                NextStepEvent(game, Step.MAIN_BEGIN);
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

                case Step.BEGIN_MULLIGAN:
                    game.Step = step;
                    game.BeginMulligan();
                    break;

                case Step.MAIN_BEGIN:
                    game.Step = step;
                    game.MainBegin();
                    break;

                case Step.MAIN_DRAW:
                    game.Step = step;
                    game.MainDraw();
                    break;

                case Step.MAIN_READY:
                    game.Step = step;
                    game.MainReady();
                    break;

                case Step.MAIN_RESOURCE:
                    game.Step = step;
                    game.MainRessources();
                    break;

                case Step.MAIN_START:
                    game.Step = step;
                    game.MainStart();
                    break;

                case Step.MAIN_START_TRIGGERS:
                    game.Step = step;
                    game.MainStartTriggers();
                    break;

                case Step.MAIN_ACTION:
                    game.Step = step;
                    break;

                case Step.MAIN_COMBAT:
                    break;

                case Step.MAIN_CLEANUP:
                    game.Step = step;
                    game.MainCleanUp();
                    break;

                case Step.MAIN_END:
                    game.Step = step;
                    game.MainEnd();
                    break;

                case Step.MAIN_NEXT:
                    game.Step = step;
                    game.MainNext();
                    break;

                case Step.FINAL_WRAPUP:
                    game.FinalWrapUp();
                    break;

                case Step.FINAL_GAMEOVER:
                    game.FinalGameOver();
                    break;

                case Step.INVALID:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(step), step, null);
            }
        }
    }
}