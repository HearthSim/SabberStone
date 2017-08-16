using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Linq;

namespace SabberStoneCore.Model
{
	public enum ChoiceAction
	{
		ADAPT, HAND, SUMMON, HEROPOWER, KAZAKUS, TRACKING, INVALID,

	}

	public class Choice : IModel<Choice>
	{
		public Choice(Controller controller)
		{
			Controller = controller;
		}

		public Controller Controller { get; set; }

		public ChoiceType ChoiceType { get; set; } = ChoiceType.INVALID;

		public ChoiceAction ChoiceAction { get; set; } = ChoiceAction.INVALID;

		public List<int> Choices { get; set; }

		public int SourceId { get; set; }

		public List<int> TargetIds { get; set; }

		public Choice Clone(Game newGame)
		{
			return new Choice(newGame.ControllerById(Controller.Id))
			{
				ChoiceType = ChoiceType,
				ChoiceAction = ChoiceAction,
				Choices = Choices?.ToList(), // Makes shallow copy
				SourceId = SourceId,
				TargetIds = TargetIds?.ToList(), // Makes shallow copy
			};
		}

		public string ToHash(params GameTag[] ignore)
		{
			// TODO hash
			throw new NotImplementedException();
		}

		public void Stamp(IModel other)
		{
			Choice choice = other as Choice ?? throw new InvalidOperationException("other's type is invalid");

			ChoiceType = choice.ChoiceType;
			ChoiceAction = choice.ChoiceAction;
			Choices = new List<int>(choice.Choices);
			SourceId = choice.SourceId;
			TargetIds = new List<int>(choice.TargetIds);
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}
	}
}