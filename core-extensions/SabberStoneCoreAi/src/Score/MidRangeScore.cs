﻿using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCoreAi.Score
{
	public class MidRangeScore : Score
	{
		public override int Rate()
		{
			if (OpHeroHp < 1)
				return int.MaxValue;

			if (HeroHp < 1)
				return int.MinValue;

			int result = 0;

			if (OpBoardZone.Count == 0 && BoardZone.Count > 0)
				result += 5000;

			result += (BoardZone.Count - OpBoardZone.Count) * 5;

			if (OpMinionTotHealthTaunt > 0)
				result += OpMinionTotHealthTaunt * -1000;

			result += MinionTotAtk;

			result += (HeroHp - OpHeroHp) * 10;

			result += (MinionTotHealth - OpMinionTotHealth) * 10;

			result += (MinionTotAtk - OpMinionTotAtk) * 10;

			return result;
		}

		public override Func<List<IPlayable>, List<int>> MulliganRule()
		{
			return p => p.Where(t => t.Cost > 3).Select(t => t.Id).ToList();
		}
	}
}
