using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.POGame;
using SabberStoneCoreAi.Agent;
using SabberStoneCore.Enums;

namespace SabberStoneCoreAi.src.Agent.ExampleAgents
{
	class RandomAgent : AbstractAgent
	{
		private Random Rnd;

		public override void FinalizeAgent()
		{
			//Nothing to do here
		}

		public override void FinalizeGame()
		{
			//Nothing to do here
		}

		public override List<PlayerTask> GetMove(PartialObservationGame poGame)
		{
			List<PlayerTask> turnList = new List<PlayerTask>();
			PlayerTask option;

			do
			{
				List<PlayerTask> options = poGame.CurrentPlayer.Options();
				option = options[Rnd.Next(options.Count)];
				poGame.Process(option);
				turnList.Append(option);
			} while (poGame.State != State.COMPLETE);
			
			return turnList;
		}

		public override void InitializeAgent()
		{
			Rnd = new Random();
		}

		public override void InitializeGame()
		{
			//Nothing to do here
		}
	}
}
