using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class QuestProgressTask : SimpleTask
    {
        public override ETaskState Process()
        {
            var source = Source as Spell;
            if (source == null)
            {
                return ETaskState.STOP;
            }

            source.QuestProgress++;
            Game.Log(ELogLevel.INFO, EBlockType.PLAY, "QuestProgressTask", $"{Controller} {source}'s Quest {source.QuestProgress} / {source.QuestTotalProgress} progress!");
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new QuestProgressTask();
            clone.Copy(this);
            return clone;
        }
    }
}