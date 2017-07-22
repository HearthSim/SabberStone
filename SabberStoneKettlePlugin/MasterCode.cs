using Kettle.Adapter.Processing.Management.Implementations;
using Kettle.Framework;
using SabberStoneKettlePlugin.master;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin
{
    internal class MasterCode
    {
        public MasterCode()
        {
        }

        public bool Enter()
        {
            if (KettleFramework.Options.PublicEndpoint == null)
            {
                Console.Error.WriteLine("This module must be launched with the option for a public endpoint!");
                return false;
            }

            // Build+Hookup processors.
            var _MGMTProcessor = new MGMT_Simulator(Program.IDENTIFIER, Program.PROVIDER);

            _MGMTProcessor.OnNack += MGMTDelegates.OnNack;
            _MGMTProcessor.Event_OnGameCreated += MGMTDelegates.Event_OnGameCreated;
            _MGMTProcessor.Event_OnGameFinished += MGMTDelegates.Event_OnGameFinished;
            _MGMTProcessor.Event_OnGameJoined += MGMTDelegates.Event_OnGameJoined;
            _MGMTProcessor.MGMT_OnMasterPing += MGMTDelegates.OnMasterPing;
            _MGMTProcessor.MGMT_OnSlavePing += MGMTDelegates.OnSlavePing;

            // Construct adapter.
            KettleFramework.MainProcessor = _MGMTProcessor;
            if (!KettleFramework.BuildAdapter("Master Adapter")) return false;

            // Start the first slave.
            if (!KettleFramework.StartSlaveAsync().Result) return false;

            return PublicAcceptLoop().Result;
        }

        private async Task<bool> PublicAcceptLoop()
        {
            // Run the framework (and adapter). The task will go into completed state 
            // when the adapter crashes, since an uninterrupted run is chosen.
            var interruptTask = KettleFramework.RunUninterrupted();

            try
            {
                // Setup public socket.
                TcpListener listener = new TcpListener(KettleFramework.Options.PublicEndpoint);
                listener.Start(10);
                Console.WriteLine("MASTER - Public listener started!");

                while (true)
                {
                    var acceptSocketTask = listener.AcceptTcpClientAsync();
                    var targetTask = await Task.WhenAny(acceptSocketTask, interruptTask);
                    if (targetTask == interruptTask) break;

                    // Accept the new connection.
                    var newClient = acceptSocketTask.Result;
                    // TODO; Perform handshaking.


                    // Register socket on adapter.
                    // This method call blocks until the adapter has a free slot to register
                    // another stream.
                    await KettleFramework.Adapter.AddStreamAsync(newClient.Client);
                }
            }
            catch (Exception e)
            {
                if (e is SocketException || e is IOException)
                {
                    Console.Error.WriteLine("MASTER - Public endpoint socket faulted!");
                    Console.Error.WriteLine("MASTER - Shutting down public endpoint.");

                    // Request the framework to shutdown gracefully.
                    KettleFramework.RequestShutdown();
                }
            }

            // Return or await the result of the adapter.
            return interruptTask.Result;
        }
    }
}
