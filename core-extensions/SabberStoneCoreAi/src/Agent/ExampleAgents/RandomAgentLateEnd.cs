using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.POGame;
using SabberStoneCoreAi.Agent;
using SabberStoneCore.Enums;

namespace SabberStoneCoreAi.Agent.ExampleAgents
{
	class RandomAgentLateEnd : AbstractAgent
	{
		private Random Rnd = new Random();

		public override void InitializeAgent()
		{
			Rnd = new Random();
		}

		public override void FinalizeAgent()
		{
			//Nothing to do here
		}

		public override void FinalizeGame()
		{
			//Nothing to do here
		}

		public override PlayerTask GetMove(SabberStoneCoreAi.POGame.POGame poGame)
		{			
			List<PlayerTask> options = poGame.CurrentPlayer.Options();
			if (options.Count > 1)
			{
				// filter all non EndTurn Tasks
				List<PlayerTask> validTasks = new List<PlayerTask>();
				foreach (PlayerTask task in options)
				{
					if (task.PlayerTaskType != PlayerTaskType.END_TURN)
						validTasks.Add(task);
				}
				return validTasks[Rnd.Next(validTasks.Count)];
			}
			return options[0];

		}



		public override void InitializeGame()
		{
			//Nothing to do here
		}
	}
}
