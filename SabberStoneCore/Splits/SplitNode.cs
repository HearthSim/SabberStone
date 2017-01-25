using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Splits
{
    internal class SplitNode
    {
        private readonly SplitNode _parent;

        private readonly Game _game;

        private readonly PlayerTask _playerTask;

        public bool IsRoot => _playerTask != null;

        public int SameState { get; set; }

        public double Probability { get; set; }

        public string Hash;

        public SplitNode(SplitNode parent, Game game, PlayerTask playerTask = null)
        {
            _parent = parent;
            _game = game;
            _playerTask = playerTask;

            if (!IsRoot)
                Execute();

            Hash = _game.Hash();
        }

        public void Execute()
        {
            _game.DeathProcessingAndAuraUpdate();
        }

        public void Splits(ref Dictionary<string, SplitNode> splitNodes)
        {
            var splits = _game.Splits;
            foreach (var split in splits)
            {
                var splitNode = new SplitNode(this, split);
                if (!splitNodes.ContainsKey(splitNode.Hash))
                    splitNodes.Add(splitNode.Hash, splitNode);
                else
                {
                    splitNodes[splitNode.Hash].SameState++;
                }
            }
        }

        public static List<SplitNode> GetSolutions(Game game, PlayerTask playerTask, int maxDepth = 10, int maxWidth = 10000)
        {
            var rootGame = new SplitNode(null, game, playerTask);
            var depthNodes = new Dictionary<string, SplitNode> { [rootGame.Hash] = rootGame };
            var endTurnNodes = new List<SplitNode>();
            for (var i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
            {
                var nextDepthNodes = new Dictionary<string, SplitNode>();
                foreach (var option in depthNodes.Values)
                {
                    option.Splits(ref nextDepthNodes);
                }

                endTurnNodes.AddRange(nextDepthNodes.Values.Where(p => !p._game.Splits.Any()));

                depthNodes = nextDepthNodes
                    .Take(maxWidth)
                    .ToDictionary(p => p.Key, p => p.Value);

                //Log.Info($"Depth: {i + 1} --> {depthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{endTurnNodes.Count}]");
            }
            return endTurnNodes;
        }

    }
}