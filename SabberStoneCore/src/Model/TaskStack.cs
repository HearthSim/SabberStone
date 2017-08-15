using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using System;
using System.Text;

namespace SabberStoneCore.Model
{
	public class TaskStack : IModel<TaskStack>
	{
		public Game Game { get; set; }

		public List<IPlayable> Playables { get; set; }
		public List<string> CardIds { get; set; }
		public bool Flag { get; set; }
		public int[] Numbers { get; set; } = new[] { 0, 0, 0, 0, 0 };

		public TaskStack(Game game)
		{
			Game = game;
		}

		public void Reset()
		{
			Playables = new List<IPlayable>();
			CardIds = new List<string>();
			Flag = false;
			Numbers = new[] { 0, 0, 0, 0, 0 };
		}

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public TaskStack Clone(Game newGame)
		{
			var deepClone = new TaskStack(newGame)
			{
				// Be aware of NULL values..
				CardIds = CardIds?.ToList(), // Shallow copy
				Flag = Flag,
				Numbers = Numbers.ToArray(), // Shallow copy
			};

			if (Playables != null)
			{
				deepClone.Playables = new List<IPlayable>(Playables.Capacity);
				Playables.ForEach(p => deepClone.Playables.Add(p.ClonedFrom(newGame)));
			}

			return deepClone;
		}

		public string ToHash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append("??TS??[PL:");
			Playables?.ForEach(pl => str.Append(pl.ToHash()));
			str.Append("][IDs:");
			CardIds?.ForEach(id => str.Append(id));
			str.AppendFormat("][FLAG:{0}]", Flag);
			str.AppendFormat("[REG:{0}-{1}-{2}-{3}-{4}]", Numbers[0], Numbers[1], Numbers[2], Numbers[3], Numbers[4]);
			str.Append("!!TS!!");
			return str.ToString();
		}

		public void Stamp(IModel other)
		{
			TaskStack taskStack = other as TaskStack ?? throw new InvalidOperationException("other's type is invalid");

			Playables = new List<IPlayable>();
			Playables = taskStack.Playables?.Select(p => Game.EntityContainer[p.Id]).ToList();
			CardIds = taskStack.CardIds;
			Flag = taskStack.Flag;
			Numbers = taskStack.Numbers;
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion
	}
}