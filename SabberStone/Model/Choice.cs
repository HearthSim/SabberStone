using System.Collections.Generic;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public class Choice
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Choice(Controller controller)
        {
            Controller = controller;
        }

        public Controller Controller { get; set; }

        public ChoiceType ChoiceType { get; set; } = ChoiceType.INVALID;

        public List<Card> Choices { get; set; }

        public void Stamp(Choice choice)
        {
            ChoiceType = choice.ChoiceType;
            Choices = new List<Card>(choice.Choices);
        }
    }
}