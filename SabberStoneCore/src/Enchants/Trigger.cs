using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Enchants
{
	public enum TriggerType
	{
		NONE, TURN_END, TURN_START, DEATH, INSPIRE, DAMAGE, HEAL, ATTACK, SUMMON,
	}

	public enum TriggerSource
	{
		GAME, SELF, MINIONS, MINIONS_EXCEPT_SELF, OP_MINIONS, ALL_MINIONS, HERO, OP_HERO, ALL_CHARACTERS, SPELLS
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
	    public SelfCondition Condition;
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
				case TriggerSource.ALL_MINIONS:
					if (!(source is Minion)) return;
					break;
				case TriggerSource.MINIONS_EXCEPT_SELF:
					if (!(source is Minion) || source.Id == SourceId || source.Zone.Type != Zone.PLAY) return;
					break;
				case TriggerSource.HERO:
					if (!(source is Hero) || source.Controller.Id != ControllerId) return;
					break;
		    }

			switch (TriggerType)
			{
				case TriggerType.TURN_START when ((Game)source).CurrentPlayer != Game.ControllerById(ControllerId):
					return;
				case TriggerType.TURN_END when ((Game)source).CurrentPlayer != Game.ControllerById(ControllerId):
					return;
			}

		    if (Condition != null)
		    {
				if (!Condition.Eval((IPlayable)source))
					return;
		    }

		    ISimpleTask taskInstance = SingleTask.Clone();
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

	    public void Activate(IEntity source)
	    {
		    var instance = new Trigger()
		    {
			    Game = source.Game,
			    SourceId = source.Id,
				ControllerId = source.Controller.Id,
				TriggerType = TriggerType,
				TriggerSource = TriggerSource,
				Condition = Condition,
				SingleTask = SingleTask,
				FastExecution = FastExecution,
				RemoveAfterTriggered = RemoveAfterTriggered,
		    };

			source.ActivatedTrigger = instance;


		    switch (TriggerType)
		    {
			    case TriggerType.DAMAGE:
				    source.Game.TriggerManager.DamageTrigger += instance.Process;
				    break;
				case TriggerType.HEAL:
					source.Game.TriggerManager.HealTrigger += instance.Process;
					break;
			    case TriggerType.TURN_END:
				    source.Game.TriggerManager.EndTurnTrigger += instance.Process;
				    break;
			    case TriggerType.TURN_START:
				    source.Game.TriggerManager.TurnStartTrigger += instance.Process;
				    break;
				case TriggerType.SUMMON:
					source.Game.TriggerManager.SummonTrigger += instance.Process;
				    break;
				case TriggerType.ATTACK:
					source.Game.TriggerManager.AttackTrigger += instance.Process;
					break;
		    }
	    }

	    public void Remove()
	    {
			switch (TriggerType)
		    {
				case TriggerType.DAMAGE:
					Game.TriggerManager.DamageTrigger -= Process;
					break;
			    case TriggerType.HEAL:
				    Game.TriggerManager.HealTrigger += Process;
				    break;
				case TriggerType.TURN_END:
				    Game.TriggerManager.EndTurnTrigger -= Process;
				    break;
			    case TriggerType.TURN_START:
				    Game.TriggerManager.TurnStartTrigger -= Process;
				    break;
				case TriggerType.SUMMON:
				    Game.TriggerManager.SummonTrigger -= Process;
				    break;
				case TriggerType.ATTACK:
					Game.TriggerManager.AttackTrigger -= Process;
					break;
			}
	    }
    }
}
