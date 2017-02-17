using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Kettle
{
    public class PowerAllOptions
    {
        public int EntityId;

        public List<PowerOption> PowerOptionList { get; set; } = new List<PowerOption>();

        public string Print()
        {
            var str = new StringBuilder();
            for (var i = 0; i < PowerOptionList.Count; i++)
            {
                str.Append($"option {i} {PowerOptionList[i].Print()}");
            }

            return str.ToString();
        }
    }

    public class PowerOptionsBuilder
    {
        public static PowerAllOptions AllOptions(int entityId, List<PlayerTask> list)
        {
            var result = new PowerAllOptions()
            {
                EntityId = entityId
            };

            if (list.Any(p => p.PlayerTaskType == PlayerTaskType.END_TURN))
            {
                result.PowerOptionList.Add(new PowerOption() { OptionType = OptionType.END_TURN });
            }

            var playCards = list.Where(p => p.PlayerTaskType == PlayerTaskType.PLAY_CARD).ToList();
            foreach (var sourceId in playCards.Select(p => p.Source.Id).Distinct())
            {
                var targets = playCards.Where(p => p.Source.Id == sourceId && p.Target != null);

                result.PowerOptionList.Add(
                    new PowerOption
                    {
                        OptionType = OptionType.POWER,
                        MainOption = new PowerSubOption
                        {
                            EntityId = sourceId,
                            Targets = targets.Any() ? targets.Select(p => p.Target.Id).Distinct().ToList() : null
                        }
                    });
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

            return result;
        }
    }

    public class PowerOption
    {
        public OptionType OptionType { get; set; }

        public PowerSubOption MainOption { get; set; }

        public List<PowerSubOption> SubOptions { get; set; }

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine($"type={OptionType} mainEntity=[{MainOption?.EntityId}]");
            for (int i = 0; i < MainOption?.Targets?.Count; i++)
            {
                str.AppendLine($" target {i} entity=[{MainOption.Targets[i]}] ");
            }
            return str.ToString();
        }
    }

    public class PowerSubOption
    {
        public int EntityId { get; set; }
        public List<int> Targets { get; set; }
    }
}
