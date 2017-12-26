using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model;

namespace SabberStoneCoreAi.POGame
{
	class PartialObservationGame
	{
		public PartialObservationGame(Game game)
		{
			throw new NotImplementedException();
		}

		private PartialObservationGame(PartialObservationGame pogame)
		{
			throw new NotImplementedException();
		}

		public PartialObservationGame getCopy()
		{
			return new PartialObservationGame(this);
		}
	}
}
