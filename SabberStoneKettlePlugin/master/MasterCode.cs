using Kettle.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.master
{
    internal class MasterCode
    {
        private IPCProcessor _ipcProcessor;
        private PublicProcessor _publicProcessor;

        // ConnectionID of the link between the simulator and matchmaker.
        public static int MMConnectionID { get; private set; } = -1;

        public MasterCode()
        {
            _ipcProcessor = new IPCProcessor();
            _publicProcessor = new PublicProcessor(Program.IDENTIFIER, Program.PROVIDER);
        }

        public bool Enter()
        {
            // IPC event callbacks are bound through IPCProcessor.
            _ipcProcessor.Bind();

            // Public event callbacks are bound through PublicProcessor.
            _publicProcessor.Bind();
            // The public processor needs to be stored into the Framework.
            KettleFramework.PublicProcessor = _publicProcessor;

            if (!MatchmakerConnect().Result) return false;

            // Run the framework (and adapter). The task will go into completed state 
            // when the adapter has no more active connections.
            // This means that the matchmaker must have closed down our connection as well!
            return KettleFramework.RunUntilShutdown().Result;
        }

        private async Task<bool> MatchmakerConnect()
        {
            try
            {
                // Use the processor to setup a valid connection with the provided 
                // public endpoint address (of the Matchmaker [implicit]).
                var mmEndpoint = KettleFramework.Options.PublicEndpoint;
                if (mmEndpoint == null)
                {
                    Console.Error.WriteLine("This module must be launched with the option for a public endpoint!");
                    return false;
                }
                Socket mmConnection = await _publicProcessor.ConnectAsync(mmEndpoint);
                if (mmConnection == null)
                {
                    Console.Error.WriteLine("Matchmaker sent invalid data. Handshake failed!");
                    return false;
                }

                // Store connection with matchmaker into adapter.
                int cID = await KettleFramework.Adapter.AddStreamAsync(mmConnection, _publicProcessor);
                if (cID == -1)
                {
                    Console.Error.WriteLine("Issue storing the matchmaker connection into adapter!");
                    return false;
                }

                // Store the connectionID of matchmaker connection for reuse.
                MMConnectionID = cID;
            }
            catch (Exception e)
            {
                if (e is SocketException || e is IOException)
                {
                    Console.Error.WriteLine("MASTER - Public endpoint socket faulted!");
                    Console.Error.WriteLine("MASTER - Shutting down.");

                    return false;
                }

                Debug.Fail("Unexpected exception!");
                throw;
            }

            return true;
        }
    }
}
