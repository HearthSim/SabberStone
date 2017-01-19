using System.Reflection;
using log4net;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class DamageTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public DamageTask(int amount, int randAmount, EntityType entityType, bool spellDmg = false)
        {
            Amount = amount;
            RandAmount = randAmount;
            Type = entityType;
            SpellDmg = spellDmg;
        }

        public DamageTask(int amount, EntityType entityType, bool spellDmg = false)
        {
            Amount = amount;
            RandAmount = 0;
            Type = entityType;
            SpellDmg = spellDmg;
        }

        public int Amount { get; set; }

        public int RandAmount { get; set; }

        public EntityType Type { get; set; }

        public bool SpellDmg { get; set; }

        public override TaskState Process()
        {
            if (Amount < 1 && RandAmount < 1)
                return TaskState.STOP;

            if (Game.Splitting)
            {
                ProccessSplit();
            }

            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
                    Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Amount + (RandAmount > 0 ? Random.Next(0, RandAmount + 1) : 0),
                        SpellDmg ? Controller.Hero.SpellPower : 0));
            return TaskState.COMPLETE;
        }

        public void ProccessSplit()
        {

            //if (Game.Splits.Count > 0 || Splits != null && Splits.Count > 0)
            //    return;

            //// EndTurnTask off log here if needed :-)
            ////Util.LogOn(true);

            //Splits = new List<Game> { Controller.Game };

            //var result = new List<Game>();

            //Splits.ForEach(game => Sets?.ToList().ForEach(set =>
            //{
            //    var clone = game.Clone();
            //    Log.Info($"Executing Clone Split {clone.CloneIndex} <-- !!!");
            //    var source = clone.IdEntityDic[Source.Id];
            //    set.ToList().ForEach(p => 
            //        Generic.DamageCharFunc.Invoke(source, clone.IdEntityDic[p.Id] as ICharacter, Amount,
            //            SpellDmg ? Controller.Hero.SpellPower : 0)
            //    );

            //    result.Add(clone);
            //}));

            //// EndTurnTask on log here if needed :-)
            ////Util.LogOn(true);

            //Log.Info($"[Game-Split] calculated {result.Count} splits");

            //Splits = result;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DamageTask(Amount, RandAmount, Type, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}