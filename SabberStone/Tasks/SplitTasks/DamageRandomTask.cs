using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HsProtoSim.Actions;
using HsProtoSim.Model;
using HsProtoSim.Tasks.SimpleTasks;
using log4net;

namespace HsProtoSim.Tasks.SplitTasks
{
    public class DamageRandMinMaxTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public DamageRandMinMaxTask(int min, int max, EntityType entityType, bool spellDmg = false)
        {
            Min = min;
            Max = max;
            Type = entityType;
            SpellDmg = spellDmg;
        }

        public int Min { get; set; }

        public int Max { get; set; }

        public EntityType Type { get; set; }

        public bool SpellDmg { get; set; }

        public override bool Process()
        {
            if (Min > Max || Min == 0 && Max == 0)
                return false;

            var varAmounts = Enumerable.Range(0, Max - Min).ToList();

            if (Game.Splitting)
            {
                ProccessSplit(varAmounts);
            }

            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
                    Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Min + varAmounts[Random.Next(0, varAmounts.Count)],
                        SpellDmg ? Controller.Hero.SpellPower : 0));

            return true;
        }

        public void ProccessSplit(List<int> varAmounts)
        {

            if (Game.Splits.Count > 0 || Splits != null && Splits.Count > 0)
                return;

            // EndTurnTask off log here if needed :-)
            //Util.LogOn(true);

            Splits = new List<Game> { Controller.Game };

            var result = new List<Game>();

            varAmounts.ForEach(varAmount =>
            {
                var clone = Game.Clone();
                Log.Info($"Executing Clone Split {clone.CloneIndex} <-- !!!");
                var source = clone.IdEntityDic[Source.Id];
                varAmount.ToList().ForEach(p =>
                    Generic.DamageCharFunc.Invoke(source, clone.IdEntityDic[p.Id] as ICharacter, Amount,
                        SpellDmg ? Controller.Hero.SpellPower : 0)
                );

                result.Add(clone);
            }));

            // EndTurnTask on log here if needed :-)
            //Util.LogOn(true);

            Log.Info($"[Game-Split] calculated {result.Count} splits");

            Splits = result;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DamageTask(Amount, Type, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}
