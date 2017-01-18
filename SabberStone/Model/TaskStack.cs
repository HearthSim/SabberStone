using System.Collections.Generic;

namespace SabberStone.Model
{
    public class TaskStack
    {
        public Game Game { get; set; }

        public List<IPlayable> Playables { get; set; }
        public bool Flag { get; set; }
        public int Number { get; set; }

        public TaskStack(Game game)
        {
            Game = game;
        }

        public void Reset()
        {
            Playables = new List<IPlayable>();
            Flag = false;
            Number = 0;
        }

        public void Stamp(TaskStack taskStack)
        {
            Playables = new List<IPlayable>();
            //taskStack.Playables?.ForEach(p => Playables.Add(Game.IdEntityDic[p.Id]));
            Flag = taskStack.Flag;
            Number = taskStack.Number;
        }
    }
}