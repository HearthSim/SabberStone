using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using System.Diagnostics;

namespace SabberStoneCore.Splits
{
	public class SplitNode
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

			SameState = 0;

			if (!isRoot)
				Execute();

			Hash = Game.ToHash(GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID);
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
			List<Game> splits = Game.Splits;

			foreach (Game split in splits)
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
			for (var i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
			{
				var nextDepthNodes = new List<SplitNode>();
				foreach (SplitNode option in depthNodes)
				{
					option.Splits(ref nextDepthNodes);
				}

				depthNodes.Clear();

				if (nextDepthNodes.Count == 8)
				{
					nextDepthNodes.ForEach(p => Debug.WriteLine(p.Hash));
				}

				nextDepthNodes.ForEach(p =>
				{
					if (!p.Game.Splits.Any())
					{
						if (uniqueFinalSplits.ContainsKey(p.Hash))
						{
							uniqueFinalSplits[p.Hash].SameState++;
						}
						else
						{
							uniqueFinalSplits.Add(p.Hash, p);
						}
					}
					else
					{
						depthNodes.Add(p);
					}
				});

				game.Dump("GetSolutions", $"Depth: {i + 1} --> {depthNodes.Count} Splits! [Final: {uniqueFinalSplits.Values.Count}]");
			}
			return uniqueFinalSplits.Values.ToList();
		}

	}
}