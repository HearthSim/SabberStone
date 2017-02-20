using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.Score;

namespace SabberStoneCoreAi.Nodes
{
    public class OptionNode
    {
        private readonly OptionNode _parent;

        private readonly Game _game;

        private int _playerId;

        public PlayerTask PlayerTask { get; }

        public string Hash;

        private int _gameState = 0;
        public bool IsWon => _gameState > 0;

        public bool IsLost => _gameState < 0;

        public bool IsRunning => _gameState == 0;

        private int _endTurn = 0;
        public bool IsEndTurn => _endTurn > 0;

        public bool IsRoot => PlayerTask == null;

        public int Score { get; private set; } = 0;

        public IScore Scoring { get; private set; }

        private bool _isOpponentTurn = false;

        public OptionNode(OptionNode parent, Game game, int playerId, PlayerTask playerTask, IScore scoring)
        {
            _parent = parent;
            _game = game.Clone(); // create clone
            _playerId = playerId;
            PlayerTask = playerTask;
            Scoring = scoring;

            if (!IsRoot)
                Execute();
        }

        public void Switch()
        {
            _isOpponentTurn = !_isOpponentTurn;
            _playerId = _game.ControllerById(_playerId).Opponent.Id;
        }

        public void Execute()
        {
            _game.Process(PlayerTask);

            var controller = _game.ControllerById(_playerId);

            _gameState = _game.State == State.RUNNING ? 0
                : (controller.PlayState == PlayState.WON ? 1 : -1);

            _endTurn = _game.CurrentPlayer.Id != _playerId ? 1 : 0;

            Hash = _game.Hash(GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID);

            if (IsEndTurn || !IsRunning)
            {
                Scoring.Controller = controller;
                Score = Scoring.Rate();
            }
        }

        public void PlayerTasks(ref List<PlayerTask> list)
        {
            if (_parent == null)
                return;

            _parent.PlayerTasks(ref list);
            list.Add(PlayerTask);
        }

        public void Options(ref Dictionary<string, OptionNode> optionNodes)
        {
            var options = _game.ControllerById(_playerId).Options(!_isOpponentTurn);

            foreach (var option in options)
            {
                var optionNode = new OptionNode(this, _game, _playerId, option, Scoring);
                if (!optionNodes.ContainsKey(optionNode.Hash))
                    optionNodes.Add(optionNode.Hash, optionNode);
            }
        }

        public static List<OptionNode> GetSolutions(Game game, int playerId, IScore scoring, int maxDepth, int maxWidth)
        {
            var depthNodes = new Dictionary<string, OptionNode> { ["root"] = new OptionNode(null, game, playerId, null, scoring) };
            var endTurnNodes = new List<OptionNode>();
            for (var i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
            {
                var nextDepthNodes = new Dictionary<string, OptionNode>();
                foreach (var option in depthNodes.Values)
                {
                    option.Options(ref nextDepthNodes);
                }
                
                endTurnNodes.AddRange(nextDepthNodes.Values.Where(p => p.IsEndTurn || p.IsWon));

                depthNodes = nextDepthNodes
                    .Where(p => !p.Value.IsEndTurn && p.Value.IsRunning)
                    .OrderByDescending(p => p.Value.Score)
                    .Take(maxWidth)
                    .ToDictionary(p => p.Key, p => p.Value);

                Console.WriteLine($"Depth: {i + 1} --> {depthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{endTurnNodes.Count}]");
            }
            return endTurnNodes;
        }

    }
}