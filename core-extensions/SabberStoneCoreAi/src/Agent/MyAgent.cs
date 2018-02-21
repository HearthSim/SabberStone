using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.Agent;
using SabberStoneCoreAi.POGame;

namespace SabberStoneCoreAi.src.Agent
{
	class MyAgent : AbstractAgent
	{
		public override void FinalizeAgent()
		{
		}

		public override void FinalizeGame()
		{
		}

		public override List<PlayerTask> GetMove(SabberStoneCoreAi.POGame.POGame poGame)
		{
		}

		public override void InitializeAgent()
		{
			Rnd = new Random();
		}

		public override void InitializeGame()
		{
		}
	}
}
