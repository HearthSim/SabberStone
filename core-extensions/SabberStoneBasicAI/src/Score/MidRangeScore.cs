#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model.Entities;

namespace SabberStoneBasicAI.Score
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
