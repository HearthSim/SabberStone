using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCoreAi.Score
{
    public class ControlScore : SabberStoneCoreAi.Score.Score
    {
        public override int Rate()
        {
            if (OpHeroHp < 1)
                return int.MaxValue;

            if (HeroHp < 1)
                return int.MinValue;

            var result = 0;

            if (OpBoard.Count == 0 && Board.Count > 0)
                result += 1000;

            result += (Board.Count - OpBoard.Count) * 50;

            result += (MinionTotHealthTaunt - OpMinionTotHealthTaunt) * 25;

            result += MinionTotAtk;

            result += (HeroHp - OpHeroHp) * 10;

            return result;
        }

        public override Func<List<IPlayable>, List<int>> MulliganRule()
        {
            return p => p.Where(t => t.Cost > 3).Select(t => t.Id).ToList();
        }
    }
}