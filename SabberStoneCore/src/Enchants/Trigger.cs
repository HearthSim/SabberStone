using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Enchants
{
	public enum TriggerType
	{
		INVALID, DEATH, INSPIRE, DAMAGE, ATTACK, SUMMON,
	}

    public class Trigger
    {
		public Game Game;
	    public int SourceId;
	    public TriggerType TriggerType;
		public ISimpleTask SingleTask;
	    public bool FastExecution;
	    public bool RemoveAfterTriggered;

	    private IPlayable Source => _source ?? (_source = Game.IdEntityDic[SourceId]);
	    private IPlayable _source;

	    // Trigger Condition

	    private void Process(IEntity source)
	    {
		    if (FastExecution)
			    Game.TaskQueue.Execute(SingleTask, SingleTask.Controller, Source, (IPlayable) SingleTask.Target);
		    else
			    Game.TaskQueue.Enqueue(SingleTask);

		    if (RemoveAfterTriggered)
			    Remove();
	    }

	    public void Activate()
	    {
		    TriggerManager manager = Game.TriggerManager;

		    switch (TriggerType)
		    {
			    case TriggerType.DAMAGE:
				    manager.DamageTrigger += Process;
				    break;
		    }

		    //Source.Triggers.Add(this);
	    }

	    public void Remove()
	    {
		    TriggerManager manager = Game.TriggerManager;

			switch (TriggerType)
		    {
				case TriggerType.DAMAGE:
					manager.DamageTrigger -= Process;
					break;
		    }

		    //Source.Triggers.Remove(this);
	    }
    }
}
