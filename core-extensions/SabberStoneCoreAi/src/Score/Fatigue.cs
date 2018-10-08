using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCoreAi.Score
{
	public class FatigueScore : SabberStoneCoreAi.Score.Score
	{
		public override int Rate()
		{
			if (OpHeroHp < 1)
				return int.MaxValue;

			if (HeroHp < 1)
				return int.MinValue;

			int result = 0;

			if (OpBoardZone.Count == 0 && BoardZone.Count > 0)
				result += 1000;

			if (OpHandCnt > 9)
				result += 1000;

			if (OpDeckCnt == 0)
				result += 10000;

			result += (DeckCnt - OpDeckCnt) * 50;

			result += (BoardZone.Count - OpBoardZone.Count) * 10;

			result += (MinionTotHealthTaunt - OpMinionTotHealthTaunt) * 10;

			result += MinionTotAtk;

			result += (HeroHp - OpHeroHp) * 5;

			return result;
		}

		public override Func<List<IPlayable>, List<int>> MulliganRule()
		{
			return p => p.Where(t => t.Cost > 3).Select(t => t.Id).ToList();
		}
	}
}