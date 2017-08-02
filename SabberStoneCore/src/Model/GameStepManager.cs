using System;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Controls the state machine which is 'the game'.
	/// 
	/// This object registers itself on the game (entity) tag
	/// changes. If the requirements are fulfilled, it will transition the game
	/// to the next state.
	/// </summary>
	public class GameStepManager
	{
		/// <summary>Initializes a new instance of the <see cref="GameStepManager"/> class.</summary>
		/// <param name="game">The game to manage.</param>
		public GameStepManager(Game game)
		{
			// Hook ourselves onto tag updates.
			game.EntityChangedEvent += EntityChangedEvent;
		}

		/// <summary>Gets called when the an entity has changed it's tag.</summary>
		/// <param name="sender">The sender entity.</param>
		/// <param name="t">The gametag.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		private void EntityChangedEvent(object sender, EGameTag t, int oldValue, int newValue)
		{
			var game = sender as Game;
			//_game.Dump("EntityChangedEvent", $"{sender} - {t}, old: {oldValue}, new: {newValue}");

			if (game != null && game.State == EState.RUNNING && t == EGameTag.NEXT_STEP)
			{
				NextStepHandler(game, (EStep)newValue);
			}
		}

		/// <summary>
		/// Called when the state machine of the game must proceed to the next step.
		/// </summary>
		/// <param name="game"></param>
		/// <param name="step"></param>
		public void NextStepHandler(Game game, EStep step)
		{
			game.Log(ELogLevel.DEBUG, EBlockType.TRIGGER, "Event", $"NextStepEvent - {step}");
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
					game.MainResources();
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
					// Step transition paused.
					// Game will wait for external input to proceed!
					// (This external input has to set NEXT_STEP to MAIN_CLEANUP) 
					break;

				case EStep.MAIN_COMBAT:
					throw new ArgumentException("Unexpected NEXT_STEP value!");

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