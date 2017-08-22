using Kettle.Adapter;
using Kettle.Framework;
using Kettle.Protocol;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.master
{
    /// <summary>
    /// Formulates all procedures for the Master process.
    /// 
    /// The Master process communicates with a simulator over a public line.
    /// The Master spawns slaves and 
    /// </summary>
    internal class MasterCode : GameMaster
    {
        private IPCProcessor _ipcProcessor;
        private PublicProcessor _publicProcessor;

        // ConnectionID of the link between the simulator and matchmaker.
        public static int MMConnectionID { get; private set; } = -1;

        public MasterCode(int maxInstances, int maxSlaves, int maxInstancesPerSlave): base(maxInstances, maxSlaves, maxInstancesPerSlave)
        {
            _ipcProcessor = new IPCProcessor(Program.IDENTIFIER, Program.PROVIDER);
            _publicProcessor = new PublicProcessor(Program.IDENTIFIER, Program.PROVIDER);
        }

        public bool Enter()
        {
            KettleFramework.IPCProcessor = _ipcProcessor;
            KettleFramework.PublicProcessor = _publicProcessor;

            // Holds information about all running games.
            // Also, the game master has setup slave processes for us!
            if (GameMasterInit() == false)
            {
                Console.Error.WriteLine("MASTER - GameMaster wasn't properly initialised!");
                return false;
            }

            /* 
             * Bindings 
             * IPC delegates are bound inside IPCProcessor.
             */
            // The public processor methods are written in this class because of the dependancy
            // on GameMaster.
            _publicProcessor.OnMatchmakerPing += Handle_MatchmakerPing;
            _publicProcessor.OnCreateGame += Handle_CreateGame;


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
                Socket mmConnection = await _publicProcessor.ConnectAsync(mmEndpoint, KettleFramework.CONNECTION_CREATE_TIMEOUT_SECONDS);
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

        private void Handle_MatchmakerPing(KettleMatchmakerPing data, KettleConnectionArgs e)
        {
            // Do nothing.
        }

        private void Handle_CreateGame(KettleCreateGame data, KettleConnectionArgs e)
        {
            // Instruct slave to spin up new game instance.
            // Fire-and-forget.. event CreatedGame will bubble up towards matchmaker.

            int slaveID;
            if (RegisterNewGameInstance(out slaveID))
            {
                // Use the IPC connection towards the slave to instruct it to start a new instance.
                // TODO; Test if slave is still connected and available! Validity cannot be guaranteed!
                var createGamePayload = new KettlePayload()
                {
                    Type = PayloadTypeStringEnum.KettleTypes_lobby_create_game,
                    Data = data,
                };
                KettleFramework.Adapter.QueuePayload(createGamePayload, slaveID);
                return;
            }

            // Send NACK because a new game instance cannot be allocated.
            var nackPayload = KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid_State, Errors.GAMEQUEUE_FULL_MSG, Errors.GAMEQUEUE_FULL.ToString());
            KettleFramework.QueuePacket(nackPayload, e);
        }
    }
}
