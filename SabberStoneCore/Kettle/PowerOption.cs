using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Kettle
{
    //message AllOptions
    //{
    //    enum PacketID
    //    {
    //        ID_a74d = 14;
    //    }
    //    required int32 id = 1;
	//    repeated Option options = 2;
    //}
    public class PowerAllOptions
    {
        private static int _index = 1;
        public int Index
        {
            get { return _index; }
            private set { _index = value; }
        }

        public List<PowerOption> PowerOptionList { get; set; }

        public PowerAllOptions()
        {
            Index++;
            PowerOptionList = new List<PowerOption>();
        }

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"PowerOption index={Index}");
            for (var i = 0; i < PowerOptionList.Count; i++)
            {
                str.Append($"option {i} {PowerOptionList[i].Print()}");
            }

            return str.ToString();
        }
    }

    public class PowerOptionsBuilder
    {
        public static PowerAllOptions AllOptions(List<PlayerTask> list)
        {
            if (list.All(p => p.PlayerTaskType != PlayerTaskType.END_TURN))
            {
                return null;
            }

            var result = new PowerAllOptions();
            result.PowerOptionList.Add(new PowerOption { OptionType = OptionType.END_TURN });

            var playCards = list.Where(p => p.PlayerTaskType == PlayerTaskType.PLAY_CARD).ToList();
            foreach (var sourceId in playCards.Select(p => p.Source.Id).Distinct())
            {
                var targets = playCards.Where(p => p.Source.Id == sourceId && p.Target != null && p.ChooseOne == 0);
                var mainOption = new PowerOption
                {
                    OptionType = OptionType.POWER,
                    MainOption = new PowerSubOption
                    {
                        EntityId = sourceId,
                        Targets = targets.Any() ? targets.Select(p => p.Target.Id).Distinct().ToList() : null
                    }
                };
                result.PowerOptionList.Add(mainOption);

                for (var i = 1; i < 3; i++)
                {
                    var subOptions1 = playCards.Where(p => p.Source.Id == sourceId && p.ChooseOne == i).ToList();
                    if (subOptions1.Any())
                    {
                        var refCardId = ((IPlayable)subOptions1.First().Source).ChooseOnePlayables[i-1].Id;
                        var refCardTargets = subOptions1.Where(p => p.Target != null).Select(p => p.Target).ToList();
                        mainOption.SubOptions.Add(new PowerSubOption
                        {
                            EntityId = refCardId,
                            Targets = refCardTargets.Any() ? refCardTargets.Select(p => p.Id).ToList() : null
                        });
                    }
                }
            }

            var minionAttacks = list.Where(p => p.PlayerTaskType == PlayerTaskType.MINION_ATTACK).ToList();
            foreach (var sourceId in minionAttacks.Select(p => p.Source.Id).Distinct())
            {
                var targets = minionAttacks.Where(p => p.Source.Id == sourceId);

                result.PowerOptionList.Add(
                    new PowerOption
                    {
                        OptionType = OptionType.POWER,
                        MainOption = new PowerSubOption
                        {
                            EntityId = sourceId,
                            Targets = targets.Select(p => p.Target.Id).Distinct().ToList()
                        }
                    });
            }

            var heroAttacks = list.Where(p => p.PlayerTaskType == PlayerTaskType.HERO_ATTACK).ToList();
            if (heroAttacks.Any())
            {
                var targets = heroAttacks.Where(p => p.Target != null);
                var mainOption = new PowerOption
                {
                    OptionType = OptionType.POWER,
                    MainOption = new PowerSubOption
                    {
                        EntityId = heroAttacks.First().Controller.Hero.Id,
                        Targets = targets.Any() ? targets.Select(p => p.Target.Id).Distinct().ToList() : null
                    }
                };
                result.PowerOptionList.Add(mainOption);
            }

            var heroPowers = list.Where(p => p.PlayerTaskType == PlayerTaskType.HERO_POWER).ToList();
            if (heroPowers.Any())
            {
                var targets = heroPowers.Where(p => p.Target != null);
                var mainOption = new PowerOption
                {
                    OptionType = OptionType.POWER,
                    MainOption = new PowerSubOption
                    {
                        EntityId = heroPowers.First().Controller.Hero.Power.Id,
                        Targets = targets.Any() ? targets.Select(p => p.Target.Id).Distinct().ToList() : null
                    }
                };
                result.PowerOptionList.Add(mainOption);
            }

            return result;
        }
    }

    //message Option
    //{
    //    enum Type
    //    {
    //        PASS = 1;
    //        END_TURN = 2;
    //        POWER = 3;
    //    }
    //    required Type type = 1;
	//    optional SubOption main_option = 2;
	//    repeated SubOption sub_options = 3;
    //}
    public class PowerOption
    {
        public OptionType OptionType { get; set; }

        public PowerSubOption MainOption { get; set; }

        public List<PowerSubOption> SubOptions { get; set; } = new List<PowerSubOption>();

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"type={OptionType} mainEntity=[{MainOption?.EntityId}]");
            for (int i = 0; i < MainOption?.Targets?.Count; i++)
            {
                str.AppendLine($" target {i} entity=[{MainOption.Targets[i]}] ");
            }
            for (int i = 0; i < SubOptions.Count; i++)
            {
                var subOption = SubOptions[i];
                str.AppendLine($" subOption {i} entity=[{subOption.EntityId}] ");
                for (var j = 0; j < subOption.Targets?.Count; j++)
                {
                    str.AppendLine($"  target {j} entity=[{subOption.Targets[j]}] ");
                }
            }
            return str.ToString();
        }
    }

    //message SubOption
    //{
    //    required int32 id = 1;
    //    repeated int32 targets = 3 [packed=true];
    //}
    public class PowerSubOption
    {
        public int EntityId { get; set; }
        public List<int> Targets { get; set; }
    }
}
