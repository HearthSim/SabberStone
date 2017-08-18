using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Splits
{
	public class SplitNode
	{
		private readonly SplitNode _parent;

		private readonly Game _root;

		public Game Game;

		public int SameState { get; set; } = 1;

		public double Probability { get; private set; }

		public string Hash;

		public SplitNode(SplitNode parent, Game root, Game game, bool isRoot = false)
		{
			_parent = parent;
			SameState = parent?.SameState ?? 1;
			_root = root;
			Game = game;

			if (!isRoot)
				Execute();

			Hash = Game.Hash(GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID);
		}

		public void Execute()
		{
			// pick-up mid splitting taks which aren't finished
			if (Game.TaskQueue.CurrentTask != null && Game.TaskQueue.CurrentTask.State != TaskState.COMPLETE)
				Game.TaskQueue.CurrentTask.Process();

			Game.DeathProcessingAndAuraUpdate();
		}

		public void Splits(ref List<SplitNode> splitNodes)
		{
			//var uniqSplits = new Dictionary<string, SplitNode>();
			var splits = Game.Splits;

			foreach (var split in splits)
			{
				var splitNode = new SplitNode(this, _root, split);

				//if (!uniqSplits.ContainsKey(splitNode.Hash))
				//{
				//    uniqSplits.Add(splitNode.Hash, splitNode);
				splitNodes.Add(splitNode);
				//}

				//splitNodes.Add(splitNode);
			}
		}

		public static List<SplitNode> GetSolutions(Game game, int maxDepth = 10, int maxWidth = 10000)
		{
			var rootGame = new SplitNode(null, game, game, true);
			var depthNodes = new List<SplitNode> { rootGame };
			var uniqueFinalSplits = new Dictionary<string, SplitNode>();
			for (var i = 0; i < maxDepth; i++)
			{
				if (!depthNodes.Any())
					break;

				var nextDepthNodes = new List<SplitNode>();
				foreach (var option in depthNodes)
				{
					option.Splits(ref nextDepthNodes);
				}

				depthNodes.Clear();
				var uniques = new Dictionary<string, SplitNode>();
				nextDepthNodes.ForEach(p =>
				{
					if (!p.Game.Splits.Any())
					{
						if (uniqueFinalSplits.ContainsKey(p.Hash))
						{
							uniqueFinalSplits[p.Hash].SameState += p.SameState;
						}
						else
						{
							uniqueFinalSplits.Add(p.Hash, p);
						}
					}
					else
					{
						if (!uniques.ContainsKey(p.Hash))
						{
							uniques.Add(p.Hash, p);
						}
						else
							uniques[p.Hash].SameState += p.SameState;
					}
				});
				depthNodes = uniques.Values.ToList();
				game.Dump("GetSolutions", $"Depth: {i + 1} --> {depthNodes.Count} Splits! [Final: {uniqueFinalSplits.Values.Count}]");
			}
			var finalStates = uniqueFinalSplits.Values.ToList();
			var totalNumStates = finalStates.Sum(a => a.SameState);
			finalStates.ForEach(a => a.Probability = a.SameState * 1.0 / totalNumStates);
			return finalStates;
		}

	}
}
