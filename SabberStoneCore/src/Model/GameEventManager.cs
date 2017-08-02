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

        private void EntityChangedEvent(object sender, EGameTag t, int oldValue, int newValue)
        {
            var entity = (Entity)sender;
            //_game.Dump("EntityChangedEvent", $"{sender} - {t}, old: {oldValue}, new: {newValue}");


            if (t == EGameTag.NEXT_STEP)
            { 
                NextStepEvent(entity as Game, (EStep)newValue);
            }
        }

        public void NextStepEvent(Game game, EStep step)
        {
            _game.Log(ELogLevel.DEBUG, EBlockType.TRIGGER, "Event", $"NextStepEvent - {step}");
            switch (step)
            {
                case EStep.BEGIN_FIRST:
                    game.Step = step;
                    game.BeginFirst();
                    break;

                case EStep.BEGIN_SHUFFLE:
                    game.Step = step;
                    game.BeginShuffle();
                    break;

                case EStep.BEGIN_DRAW:
                    game.Step = step;
                    game.BeginDraw();
                    break;

                case EStep.BEGIN_MULLIGAN:
                    game.Step = step;
                    game.BeginMulligan();
                    break;

                case EStep.MAIN_BEGIN:
                    game.Step = step;
                    game.MainBegin();
                    break;

                case EStep.MAIN_DRAW:
                    game.Step = step;
                    game.MainDraw();
                    break;

                case EStep.MAIN_READY:
                    game.Step = step;
                    game.MainReady();
                    break;

                case EStep.MAIN_RESOURCE:
                    game.Step = step;
                    game.MainRessources();
                    break;

                case EStep.MAIN_START:
                    game.Step = step;
                    game.MainStart();
                    break;

                case EStep.MAIN_START_TRIGGERS:
                    game.Step = step;
                    game.MainStartTriggers();
                    break;

                case EStep.MAIN_ACTION:
                    game.Step = step;
                    break;

                case EStep.MAIN_COMBAT:
                    break;

                case EStep.MAIN_CLEANUP:
                    game.Step = step;
                    game.MainCleanUp();
                    break;

                case EStep.MAIN_END:
                    game.Step = step;
                    game.MainEnd();
                    break;

                case EStep.MAIN_NEXT:
                    game.Step = step;
                    game.MainNext();
                    break;

                case EStep.FINAL_WRAPUP:
                    game.FinalWrapUp();
                    break;

                case EStep.FINAL_GAMEOVER:
                    game.FinalGameOver();
                    break;

                case EStep.INVALID:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(step), step, null);
            }
        }
    }
}