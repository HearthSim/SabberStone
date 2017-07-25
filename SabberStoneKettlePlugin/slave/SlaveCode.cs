using Kettle.Framework;

namespace SabberStoneKettlePlugin.slave
{
    /// <summary>
    /// Formulates all procedures for the Slave processes.
    /// 
    /// Basically; Slaves execute commands from Master and run game instances.
    /// </summary>
    internal class SlaveCode
    {
        private IPCProcessor _ipcProcessor;
        private PublicProcessor _publicProcessor;

        public SlaveCode()
        {
            _publicProcessor = new PublicProcessor(Program.IDENTIFIER, Program.PROVIDER);
            _ipcProcessor = new IPCProcessor(Program.IDENTIFIER, Program.PROVIDER);
        }

        public bool Enter()
        {
            KettleFramework.PublicProcessor = _publicProcessor;
            KettleFramework.IPCProcessor = _ipcProcessor;

            if (!KettleFramework.ConnectToMasterAsync().Result.Result) return false;

            // IPC event callbacks are bound through IPCProcessor.
            _ipcProcessor.Bind();
            // Public event callbacks are bound through PublicProcessor.
            _publicProcessor.Bind();


            // Let it rip!
            return KettleFramework.RunUntilShutdown().Result;
        }
    }
}
