using Kettle.Framework;
using System;
using System.Collections.ObjectModel;
using Kettle.Protocol;
using SabberStoneKettlePlugin.master;
using SabberStoneKettlePlugin.slave;
using SabberStoneKettlePlugin.configurations;

namespace SabberStoneKettlePlugin
{
    class Program
    {
        /// <summary>
        /// The public identifier of the simulator.
        /// </summary>
        internal const string IDENTIFIER = "Sabberstone Kettle Client ALPHA";

        /// <summary>
        /// The BEST team.
        /// </summary>
        internal const string PROVIDER = "Stove Team";

        /// <summary>
        /// Shutdown timer used in the interrupt handler.
        /// This is the amount of time the program waits before shutting down completely.
        /// </summary>
        internal const int DESTRUCT_TIMEOUT = 5;

        /// <summary>
        /// The advertised purpose of this simulator.
        /// </summary>
        internal static readonly SimulatorPurpose Purpose = SimulatorPurpose.Simulator;

        /// <summary>
        /// The maximum game instances this simulator can run simultanuously.
        /// </summary>
        internal static readonly int MaxInstances = 20;

        /// <summary>
        /// The maximum amount of slaves this program supports.
        /// </summary>
        internal static readonly int MaxSlaves = 4;

        /// <summary>
        /// More details informing the simulator about our capabilities.
        /// </summary>
        internal static readonly Supported SupportedDetails = new Supported()
        {
            Scenario = new ObservableCollection<GameScenarioEnum>()
                        {
                            GameScenarioEnum.Match_Standard,
                            GameScenarioEnum.Match_Wild,
                            GameScenarioEnum.Ranked_Standard,
                            GameScenarioEnum.Ranked_Wild
                        },
            GameID = new ObservableCollection<string>() { DefaultGame.ADVERTISEMENT }
        };

        /// <summary>
        /// Main entry point of our program.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            if (!KettleFramework.Init(args))
            {
                Console.Error.WriteLine("Init KettleFramework: {0}", KettleFramework.LastError);
                return;
            }

            if (!KettleFramework.Options.EnableEvents)
            {
                Console.Error.WriteLine("This module must be launched with enabled events in order to work!");
                goto CLEANUP;
            }

            // Catch CTRL^C in order to shutdown properly!
            KettleFramework.PreventTerminalInterrupt(null, DESTRUCT_TIMEOUT);

            try
            {
                if (KettleFramework.IsSlave())
                {
                    if (new SlaveCode()?.Enter() != true)
                    {
                        Console.Error.WriteLine("SLAVE - Error occurred!");
                    }
                }
                else
                {
                    if (new MasterCode()?.Enter() != true)
                    {
                        Console.Error.WriteLine("MASTER - Error occurred!");
                    }
                }

            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Unhandled exception!");
                Console.Error.WriteLine(e.Message);
            }

            CLEANUP:
            if (!String.IsNullOrWhiteSpace(KettleFramework.LastError))
            {
                Console.Error.WriteLine("KettleFramework's last error: {0}", KettleFramework.LastError);
            }

            if (!KettleFramework.Destruct(DESTRUCT_TIMEOUT))
            {
                Console.Error.WriteLine("Destruct KettleFramework: {0}", KettleFramework.LastError);
            }
        }
    }
}