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
		NONE, TURN_END, TURN_START, DEATH, INSPIRE, DAMAGE, ATTACK, SUMMON,
	}

	public enum TriggerSource
	{
		GAME, SELF, MINIONS, OP_MINIONS, ALL_MINIONS, HERO, OP_HERO, ALL_CHARACTERS, SPELLS
	}

	public enum TriggerActivation
	{
		PLAY, HAND, DECK
	}

    public class Trigger
    {
		public Game Game;
	    public int SourceId;
	    public int ControllerId;
	    public TriggerActivation TriggerActivation;
	    public TriggerType TriggerType;
		public TriggerSource TriggerSource;
		public ISimpleTask SingleTask;
	    public bool FastExecution;
	    public bool RemoveAfterTriggered;

	    private IPlayable Source => _source ?? (_source = Game.IdEntityDic[SourceId]);
	    private IPlayable _source;

	    // Trigger Condition

	    private void Process(IEntity source)
	    {
		    switch (TriggerSource)
		    {
				case TriggerSource.SELF:
					if (source.Id != SourceId) return;
					break;
				//case TriggerSource.MINIONS:
		    }

		    var taskInstance = SingleTask.Clone();
			taskInstance.Game = Game;
			taskInstance.Controller = Source.Controller;
			taskInstance.Source = Source;
			taskInstance.Target = null;
			taskInstance.IsTrigger = true;


		    if (FastExecution)
			    Game.TaskQueue.Execute(taskInstance, taskInstance.Controller, Source, null);
		    else
			    Game.TaskQueue.Enqueue(taskInstance);

		    if (RemoveAfterTriggered)
			    Remove();
	    }

	    public void Activate(Game game, int sourceID)
	    {
			Game = game;
		    SourceId = sourceID;

		    switch (TriggerType)
		    {
			    case TriggerType.DAMAGE:
				    game.TriggerManager.DamageTrigger += Process;
				    break;
				case TriggerType.TURN_END:
					game.TriggerManager.EndTurnTrigger += Process;
					break;
		    }

		    //Source.Triggers.Add(this);
	    }

	    public void Remove()
	    {
			switch (TriggerType)
		    {
				case TriggerType.DAMAGE:
					Game.TriggerManager.DamageTrigger -= Process;
					break;
			    case TriggerType.TURN_END:
				    Game.TriggerManager.EndTurnTrigger -= Process;
				    break;
			}

		    //Source.Triggers.Remove(this);
	    }
    }
}
