using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;

namespace SabberStoneCoreAi.Score
{
    public interface IScore
    {
        Controller Controller { get; set; }
        Func<List<IPlayable>, List<int>> MulliganRule();
        int Rate();
    }

    public abstract class Score : IScore
    {
        public Controller Controller { get; set; }

        public int HeroHp => Controller.Hero.Health;

        public int OpHeroHp => Controller.Opponent.Hero.Health;

        public int HeroAtk => Controller.Hero.TotalAttackDamage;

        public int OpHeroAtk => Controller.Opponent.Hero.TotalAttackDamage;

        public Zone<IPlayable> Hand => Controller.Hand;

        public int HandTotCost => Hand.Sum(p => p.Cost);

        public int HandCnt => Controller.Hand.Count;

        public int OpHandCnt => Controller.Opponent.Hand.Count;

        public int DeckCnt => Controller.Deck.Count;

        public int OpDeckCnt => Controller.Opponent.Deck.Count;

        public Zone<Minion> Board => Controller.Board;

        public Zone<Minion> OpBoard => Controller.Opponent.Board;

        public int MinionTotAtk => Board.Sum(p => p.AttackDamage);

        public int OpMinionTotAtk => OpBoard.Sum(p => p.AttackDamage);

        public int MinionTotHealth => Board.Sum(p => p.Health);

        public int OpMinionTotHealth => OpBoard.Sum(p => p.Health);

        public int MinionTotHealthTaunt => Board.Where(p => p.HasTaunt).Sum(p => p.Health);

        public int OpMinionTotHealthTaunt => OpBoard.Where(p => p.HasTaunt).Sum(p => p.Health);

        public virtual int Rate()
        {
            return 0;
        }

        public virtual Func<List<IPlayable>, List<int>> MulliganRule()
        {
            return p => new List<int>();
        }
    }
}
