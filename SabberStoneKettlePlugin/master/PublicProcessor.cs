using Kettle.Adapter;
using Kettle.Adapter.Processing;
using Kettle.Protocol;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.master
{
    /// <summary>
    /// Handles received messages for the public connection.
    /// </summary>
    /// <seealso cref="Kettle.Adapter.Processing.KettleFrontendProcessor" />
    internal class PublicProcessor : KettleFrontendProcessor
    {
        public override event Action<ObservableCollection<KettleNack>, KettleConnectionArgs> OnNack;
        public override event Action<KettleEventBucketCreated, KettleConnectionArgs> Event_OnBucketCreated = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventBucketRemoved, KettleConnectionArgs> Event_OnBucketRemoved = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventGameCreated, KettleConnectionArgs> Event_OnGameCreated = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventGameFinished, KettleConnectionArgs> Event_OnGameFinished = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventGameJoined, KettleConnectionArgs> Event_OnGameJoined = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventPlayerDequeued, KettleConnectionArgs> Event_OnPlayerDequeued = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleEventPlayerQueued, KettleConnectionArgs> Event_OnPlayerQueued = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleClientAnnounce, KettleConnectionArgs> OnClientAnnounce = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleClientPing, KettleConnectionArgs> OnClientPing = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleMatchmakerAnnounce, KettleConnectionArgs> OnMatchmakerAnounce;
        public override event Action<KettleMatchmakerPing, KettleConnectionArgs> OnMatchmakerPing;
        public override event Action<KettleSimulatorAnnounce, KettleConnectionArgs> OnSimulatorAnounce = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleSimulatorPing, KettleConnectionArgs> OnSimulatorPing = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryCreateEntity, KettleConnectionArgs> OnCreateEntity = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryGameCreated, KettleConnectionArgs> OnGameCreated = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryStart, KettleConnectionArgs> OnHistoryStart = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryStop, KettleConnectionArgs> OnHistoryStop = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryMetaData, KettleConnectionArgs> OnMetaData = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryPowerStart, KettleConnectionArgs> OnPowerStart = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryPowerStop, KettleConnectionArgs> OnPowerStop = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleHistoryTagChange, KettleConnectionArgs> OnTagChange = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleCreateBucket, KettleConnectionArgs> OnCreateBucket = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleCreateGame, KettleConnectionArgs> OnCreateGame;
        public override event Action<KettleJoinGame, KettleConnectionArgs> OnJoinGame = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueueCancel, KettleConnectionArgs> OnQueueCancel = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueuePlayer, KettleConnectionArgs> OnQueuePlayer = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueueStatus, KettleConnectionArgs> OnQueueStatus = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueueTransition, KettleConnectionArgs> OnQueueTransition = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleDoChooseEntities, KettleConnectionArgs> OnChooseEntities = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleDoChooseOption, KettleConnectionArgs> OnChooseOption = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleDoConcede, KettleConnectionArgs> OnConcede = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionEndTurn, KettleConnectionArgs> OnEndTurn = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionEntityChoices, KettleConnectionArgs> OnEntityChoices = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionStart, KettleConnectionArgs> OnOptionsStart = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionStop, KettleConnectionArgs> OnOptionsStop = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionPower, KettleConnectionArgs> OnPower = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleUserUI, KettleConnectionArgs> OnUserUI = delegate { Debug.Fail("Accessing this event is forbidden!"); };

        public PublicProcessor(string identification, string provider) : base(identification, provider)
        {
        }

        protected override KettlePayload GetAnnouncePayload()
        {
            return new KettlePayload()
            {
                Type = PayloadTypeStringEnum.KettleTypes_handshake_simulator_announce,
                Data = new KettleSimulatorAnnounce()
                {
                    Identification = Identification,
                    Provider = Provider,
                    Max_instances = Program.MaxInstances,
                    Purpose = Program.Purpose,
                    Supported = Program.SupportedDetails
                }
            };
        }

        public override Socket Connect(IPEndPoint endpoint)
        {
            return ConnectAsync(endpoint).Result;
        }

        public override async Task<Socket> ConnectAsync(IPEndPoint endpoint)
        {
            Debug.Assert(endpoint != null);

            TcpClient client = new TcpClient(endpoint.AddressFamily);
            await client.ConnectAsync(endpoint.Address, endpoint.Port);

            if (!client.Connected) return null;

            // Perform handshaking.
            var dataStream = client.GetStream();
            var token = CancellationToken.None;
            var readResult = await KettleCore.ReadKettlePacketAsync(dataStream, token, 5);
            if (readResult.State != KettleCore.READ_STATE.OK || readResult.Data == null)
            {
                client.Dispose();
                return null;
            }

            // We assume here that the job succeeded.
            var mmAnnounce = readResult.Data;
            if (mmAnnounce.Type != PayloadTypeStringEnum.KettleTypes_handshake_matchmaker_announce)
            {
                client.Dispose();
                return null;
            }

            // Send our own announce.
            var simAnnounce = GetAnnouncePayload();
            var writeResult = await KettleCore.WriteKettlePacketAsync(dataStream, simAnnounce, token);
            if (writeResult != KettleCore.WRITE_STATE.OK)
            {
                client.Dispose();
                return null;
            }

            // Do logging.
            var mmPayload = mmAnnounce.Data as KettleMatchmakerAnnounce;
            Console.WriteLine("Connected to Matchmaker:\n{0}\n{1}", mmPayload.Identification, mmPayload.Provider);

            return client.Client;
        }

        public override void ParsePayload(KettlePayload data, int cID)
        {
            if (data.Errors.Count > 0)
            {
                // Not registering a NACK handler is forgivable.
                OnNack?.Invoke(data.Errors, GetConnectionDetails(cID));
                return;
            }

            switch (data.Type)
            {
                // MatchmakerAnnounce is actually part of handshake, so we ignore it.
                //case PayloadTypeStringEnum.KettleTypes_handshake_matchmaker_announce:
                //    DelegateCallback(OnMatchmakerAnounce, data, cID);
                //    break;
                case PayloadTypeStringEnum.KettleTypes_handshake_matchmaker_ping:
                    DelegateCallback(OnMatchmakerPing, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_lobby_create_game:
                    DelegateCallback(OnCreateGame, data, cID);
                    break;
                default:
                    // No error handling; we simple ignore/drop packets we don't expect.
                    Debug.Fail("Unexpected packet received!");
                    break;
            }

            return;
        }
    }
}
