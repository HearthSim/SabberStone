using Kettle.Adapter.Processing.Frontend.Implementations;
using Kettle.Adapter.Processing.Management.Implementations;
using Kettle.Framework;
using Kettle.Protocol;
using SabberStoneKettlePlugin.slave;

namespace SabberStoneKettlePlugin
{
    internal class SlaveCode
    {
        private SimulatorPurpose _purpose;
        private int _maxGameInstances;
        private Supported _details;

        public SlaveCode(SimulatorPurpose purpose, int maxGameInstances, Supported details)
        {
            _purpose = purpose;
            _maxGameInstances = maxGameInstances;
            _details = details;
        }

        public bool Enter()
        {
            KettleFramework.PreventTerminalInterrupt(null, Program.DESTRUCT_TIMEOUT);

            // Build+Hookup processors.
            var _MainProcessor = new Simulator(Program.IDENTIFIER, Program.PROVIDER, _maxGameInstances, _purpose, _details);

            _MainProcessor.OnNack += FrontendDelegates.OnNack;
            _MainProcessor.OnChooseEntities += FrontendDelegates.OnChooseEntities;
            _MainProcessor.OnChooseOption += FrontendDelegates.OnChooseOption;
            _MainProcessor.OnConcede += FrontendDelegates.OnConcede;
            _MainProcessor.OnJoinGame += FrontendDelegates.OnJoinGame;
            _MainProcessor.OnUserUI += FrontendDelegates.OnUserUI;


            var _MGMTProcessor = new MGMT_Simulator(Program.IDENTIFIER, Program.PROVIDER);

            _MGMTProcessor.OnNack += MGMTDelegates.OnNack;
            _MGMTProcessor.Event_OnGameCreated += MGMTDelegates.Event_OnGameCreated;
            _MGMTProcessor.Event_OnGameFinished += MGMTDelegates.Event_OnGameFinished;
            _MGMTProcessor.Event_OnGameJoined += MGMTDelegates.Event_OnGameJoined;
            _MGMTProcessor.MGMT_OnMasterPing += MGMTDelegates.OnMasterPing;
            _MGMTProcessor.MGMT_OnSlavePing += MGMTDelegates.OnSlavePing;

            // Construct adapter.
            KettleFramework.MainProcessor = _MainProcessor;
            KettleFramework.MGMT_Processor = _MGMTProcessor;
            if (!KettleFramework.BuildAdapter("Slave Adapter")) return false;
            if (!KettleFramework.ConnectToMasterAsync().Result) return false;

            // Let it rip!
            return KettleFramework.RunUntilShutdown().Result;
        }
    }
}
