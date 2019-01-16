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
//using System.Collections.Generic;
//using System.Linq;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model;
//using SabberStoneCore.Tasks;

//namespace SabberStoneCore.Splits
//{
//	public class SplitNode
//	{
//		private readonly SplitNode _parent;

//		private readonly Game _root;

//		public Game Game;

//		public int SameState { get; set; }

//		public double Probability { get; private set; }

//		public string Hash;

//		public SplitNode(SplitNode parent, Game root, Game game, bool isRoot = false)
//		{
//			_parent = parent;
//			Probability = (_parent?.Probability ?? 1.0) * (1.0 / (_parent?.Game.Splits.Count ?? 1.0));
//			_root = root;
//			Game = game;

//			SameState = 1;

//			if (!isRoot)
//				Execute();

//			Hash = Game.Hash(GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID, GameTag.TAG_LAST_KNOWN_POSITION_ON_BOARD);
//		}

//		public void Execute()
//		{
//			// pick-up mid splitting taks which aren't finished
//			if (Game.TaskQueue.CurrentTask != null && Game.TaskQueue.CurrentTask.State != TaskState.COMPLETE)
//				Game.TaskQueue.Process();

//			Game.DeathProcessingAndAuraUpdate();
//		}

//		public void Splits(ref List<SplitNode> splitNodes)
//		{
//			//var uniqSplits = new Dictionary<string, SplitNode>();
//			List<Game> splits = Game.Splits;

//			foreach (Game split in splits)
//			{
//				var splitNode = new SplitNode(this, _root, split);

//				//if (!uniqSplits.ContainsKey(splitNode.Hash))
//				//{
//				//    uniqSplits.Add(splitNode.Hash, splitNode);
//				splitNodes.Add(splitNode);
//				//}

//				//splitNodes.Add(splitNode);
//			}
//		}

//		public static List<SplitNode> GetSolutions(Game game, int maxDepth = 10, int maxWidth = 10000)
//		{
//			var rootGame = new SplitNode(null, game, game, true);
//			var depthNodes = new List<SplitNode> { rootGame };
//			var uniqueFinalSplits = new Dictionary<string, SplitNode>();
//			for (int i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
//			{
//				var nextDepthNodes = new List<SplitNode>();
//				foreach (SplitNode option in depthNodes)
//				{
//					option.Splits(ref nextDepthNodes);
//				}

//				depthNodes.Clear();

//				nextDepthNodes.ForEach(p =>
//				{
//					if (!p.Game.Splits.Any())
//					{
//						if (uniqueFinalSplits.ContainsKey(p.Hash))
//						{
//							uniqueFinalSplits[p.Hash].SameState++;
//						}
//						else
//						{
//							uniqueFinalSplits.Add(p.Hash, p);
//						}

//						uniqueFinalSplits[p.Hash].Probability += p.Probability;
//					}
//					else
//					{
//						depthNodes.Add(p);
//					}
//				});

//				game.Dump("GetSolutions", $"Depth: {i + 1} --> {depthNodes.Count} Splits! [Final: {uniqueFinalSplits.Values.Count}]");
//			}
//			return uniqueFinalSplits.Values.ToList();
//		}

//	}
//}
