using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public enum ChoiceAction
    {
        ADAPT, HAND, SUMMON, HEROPOWER, KAZAKUS, TRACKING, INVALID,
        
    }

    public class Choice
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

        public void Stamp(Choice choice)
        {
            ChoiceType = choice.ChoiceType;
            ChoiceAction = choice.ChoiceAction;
            Choices = new List<int>(choice.Choices);
            SourceId = choice.SourceId;
        }

        public string FullPrint()
        {
            var str = new StringBuilder();
            str.Append($"{Controller.Name}[ChoiceType:{ChoiceType}][ChoiceAction:{ChoiceAction}][");
            str.Append(string.Join(",", Choices));
            return str.ToString();
        }
    }
}