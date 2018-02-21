using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.POGame;
using SabberStoneCoreAi.Agent;
using SabberStoneCore.Enums;

namespace SabberStoneCoreAi.src.Agent.ExampleAgents
{
	class RandomAgentMultipleMoves : AbstractAgent
	{
		private Random Rnd = new Random();

		public override void FinalizeAgent()
		{
			//Nothing to do here
		}

		public override void FinalizeGame()
		{
			//Nothing to do here
		}

		public override List<PlayerTask> GetMove(SabberStoneCoreAi.POGame.POGame poGame)
		{
			List<PlayerTask> turnList = new List<PlayerTask>();
			PlayerTask option;

			do
			{
				List<PlayerTask> options = poGame.CurrentPlayer.Options();
				option = options[Rnd.Next(options.Count)];
				poGame.Process(option);		//hint: the prediction process can fail due to non-deterministic actions
				turnList.Add(option);
			} while (option.PlayerTaskType != PlayerTaskType.END_TURN);
			
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
