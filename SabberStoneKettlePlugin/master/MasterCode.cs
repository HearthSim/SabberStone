using Kettle.Framework;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.master
{
    internal class MasterCode
    {
        private IPCProcessor _ipcProcessor;
        private PublicProcessor _publicProcessor;

        public MasterCode()
        {
            _ipcProcessor = new IPCProcessor();
            _publicProcessor = new PublicProcessor(Program.IDENTIFIER, Program.PROVIDER);
        }

        public bool Enter()
        {
            if (KettleFramework.Options.PublicEndpoint == null)
            {
                Console.Error.WriteLine("This module must be launched with the option for a public endpoint!");
                return false;
            }

            // IPC event callbacks are bound through IPCProcessor.
            _ipcProcessor.Bind();

            // Public event callbacks are bound through PublicProcessor.
            _publicProcessor.Bind();
            // The public processor needs to be stored into the Framework.
            KettleFramework.PublicProcessor = _publicProcessor;

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
                listener.Start(1);
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
                    await KettleFramework.Adapter.AddStreamAsync(newClient.Client, _publicProcessor);
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
