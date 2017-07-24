using Kettle.Framework;
using Kettle.Protocol;

namespace SabberStoneKettlePlugin.slave
{
    internal class SlaveCode
    {
        private SimulatorPurpose _purpose;
        private int _maxGameInstances;
        private Supported _details;


        private PublicProcessor _publicProcessor;

        public SlaveCode(SimulatorPurpose purpose, int maxGameInstances, Supported details)
        {
            _purpose = purpose;
            _maxGameInstances = maxGameInstances;
            _details = details;

            _publicProcessor = new PublicProcessor(Program.IDENTIFIER, Program.PROVIDER);
        }

        public bool Enter()
        {
            KettleFramework.PreventTerminalInterrupt(null, Program.DESTRUCT_TIMEOUT);

            // IPC event callbacks are bound through IPCProcessor.
            // TODO

            // Public event callbacks are bound through PublicProcessor.
            _publicProcessor.Bind();
            // The public processor needs to be stored into the Framework.
            KettleFramework.PublicProcessor = _publicProcessor;


            // Let it rip!
            return KettleFramework.RunUntilShutdown().Result;
        }
    }
}
