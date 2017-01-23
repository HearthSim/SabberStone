namespace SabberStoneCoreGui.Score
{
    public class ControlScore : Score
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
    }
}