using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Splits
{
    internal class SplitNode
    {
        private readonly SplitNode _parent;

        private readonly Game _root;

        public Game Game;

        public int SameState { get; set; }

        public double Probability { get; set; }

        public string Hash;

        public SplitNode(SplitNode parent, Game root, Game game, bool isRoot = false)
        {
            _parent = parent;
            _root = root;
            Game = game;

            if (!isRoot)
                Execute();

            Hash = 
                _root.Splitting == SplitType.ALL_SPLITS ? 
                Game.CloneIndex + Game.Hash() : 
                Game.Hash();
        }

        public void Execute()
        {
            // pick-up mid splitting taks which aren't finished
            if (Game.TaskQueue.CurrentTask != null && Game.TaskQueue.CurrentTask.State != TaskState.COMPLETE)
                Game.TaskQueue.CurrentTask.Process();

            Game.DeathProcessingAndAuraUpdate();
        }

        public void Splits(ref Dictionary<string, SplitNode> splitNodes)
        {
            var splits = Game.Splits;
            foreach (var split in splits)
            {
                var splitNode = new SplitNode(this, this._root, split);
                if (!splitNodes.ContainsKey(splitNode.Hash))
                    splitNodes.Add(splitNode.Hash, splitNode);
                else
                {
                    splitNodes[splitNode.Hash].SameState++;
                }
            }
        }

        public static List<SplitNode> GetSolutions(Game game, int maxDepth = 10, int maxWidth = 10000)
        {
            var rootGame = new SplitNode(null, game, game, true);
            var depthNodes = new Dictionary<string, SplitNode> { [rootGame.Hash] = rootGame };
            var endTurnNodes = new List<SplitNode>();
            for (var i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
            {
                var nextDepthNodes = new Dictionary<string, SplitNode>();
                foreach (var option in depthNodes.Values)
                {
                    option.Splits(ref nextDepthNodes);
                }

                endTurnNodes.AddRange(nextDepthNodes.Values.Where(p => !p.Game.Splits.Any()));
                endTurnNodes.ForEach(p => nextDepthNodes.Remove(p.Hash));
                depthNodes = nextDepthNodes
                    .Take(maxWidth)
                    .ToDictionary(p => p.Key, p => p.Value);

                game.Dump("GetSolutions", $"Depth: {i + 1} --> {depthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{endTurnNodes.Count}]");
            }
            return endTurnNodes;
        }

    }
}