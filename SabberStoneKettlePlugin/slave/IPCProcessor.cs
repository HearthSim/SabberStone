using Kettle.Adapter;
using Kettle.Adapter.Processing;
using Kettle.Adapter.Util;
using Kettle.Framework;
using Kettle.Protocol;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.slave
{
    /// <summary>
    /// Handles received messages for the IPC connection, Slave side.
    /// </summary>
    /// <seealso cref="Kettle.Adapter.Processing.KettleIPCProcessor" />
    internal class IPCProcessor : KettleIPCProcessor
    {
        public override event Action<ObservableCollection<KettleNack>, KettleConnectionArgs> OnNack;
        public override event Action<KettleEventBucketCreated, KettleConnectionArgs> Event_OnBucketCreated;
        public override event Action<KettleEventBucketRemoved, KettleConnectionArgs> Event_OnBucketRemoved;
        public override event Action<KettleEventGameCreated, KettleConnectionArgs> Event_OnGameCreated;
        public override event Action<KettleEventGameFinished, KettleConnectionArgs> Event_OnGameFinished;
        public override event Action<KettleEventGameJoined, KettleConnectionArgs> Event_OnGameJoined;
        public override event Action<KettleEventPlayerDequeued, KettleConnectionArgs> Event_OnPlayerDequeued;
        public override event Action<KettleEventPlayerQueued, KettleConnectionArgs> Event_OnPlayerQueued;
        public override event Action<KettleMasterAnnounce, KettleConnectionArgs> OnMasterAnnounce;
        public override event Action<KettleMasterPing, KettleConnectionArgs> OnMasterPing;
        public override event Action<KettleShutdown, KettleConnectionArgs> OnShutdown;
        public override event Action<KettleSlaveAnnounce, KettleConnectionArgs> OnSlaveAnnounce;
        public override event Action<KettleSlavePing, KettleConnectionArgs> OnSlavePing;
        public override event Action<KettleCreateBucket, KettleConnectionArgs> OnCreateBucket;
        public override event Action<KettleCreateGame, KettleConnectionArgs> OnCreateGame;

        private GameStore _gameStore;

        public IPCProcessor(GameStore store, string identification, string provider) : base(identification, provider)
        {
            _gameStore = store;
        }

        protected override KettlePayload GetAnnouncePayload()
        {
            return new KettlePayload()
            {
                Type = PayloadTypeStringEnum.KettleTypes_handshake_slave_announce,
                Data = new KettleSlaveAnnounce()
            };
        }

        public override Socket Connect(IPEndPoint endpoint, int timeout)
        {
            return ConnectAsync(endpoint, timeout).Result;
        }

        public override async Task<Socket> ConnectAsync(IPEndPoint endpoint, int timeout)
        {
            Debug.Assert(endpoint != null);
            Debug.Assert(timeout > 0);

            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeout));
            using (var timeoutTaskSource = new CancellationTaskSource(cts.Token))
            {
                // Build Task from cancellationtoken.
                Task timeoutTask = timeoutTaskSource.Task;
                TcpClient masterClient = new TcpClient(endpoint.AddressFamily);
                var connectTask = masterClient.ConnectAsync(endpoint.Address, endpoint.Port);

                int taskIdx = Task.WaitAny(new Task[] { timeoutTask, connectTask });
                if (taskIdx == 0)
                {
                    // Timeout!
                    // Dispose of socket, this will cancel the async connect task.
                    masterClient.Dispose();
                    return null;
                }

                /* 
				 * Succesfully connected to master.
				 * Perform handshaking.
				 */
                var dataStream = masterClient.GetStream();
                CancellationToken token = cts.Token;

                // Read announce.
                Task<KettleCore.KettleReadResult> readTask = KettleCore.ReadKettlePacketAsync(dataStream, token);
                KettleCore.KettleReadResult readResultObj = await readTask;
                if (!readTask.IsCompleted || readResultObj.State != KettleCore.READ_STATE.OK)
                {
                    dataStream.Dispose();
                    return null;
                }

                // Validate announce.
                var masterAnnounce = KettleCore.CastData<KettleMasterAnnounce>(readResultObj.Payload);
                if (masterAnnounce == null)
                {
                    dataStream.Dispose();
                    return null;
                }

                // Then we send our own announce.
                Task<KettleCore.WRITE_STATE> writeTask = KettleCore.WriteKettlePacketAsync(dataStream, GetAnnouncePayload(), token);
                KettleCore.WRITE_STATE writeResult = await writeTask;
                if (!writeTask.IsCompleted || writeResult != KettleCore.WRITE_STATE.OK)
                {
                    dataStream.Dispose();
                    return null;
                }

                // Valid handshake!
                Console.WriteLine("Connected to master!");
                return masterClient.Client;
            }
        }

        public void Bind()
        {
            OnMasterPing += Handle_MasterPing;
            OnCreateGame += Handle_CreateGame;
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
                case PayloadTypeStringEnum.KettleTypes_handshake_master_ping:
                    DelegateCallback(OnMasterPing, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_handshake_shutdown:
                    DelegateCallback(OnShutdown, data, cID);
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

        private void Handle_MasterPing(KettleMasterPing data, KettleConnectionArgs e)
        {
            // Do nothing.
        }

        private void Handle_Shutdown(KettleShutdown data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Handle_CreateGame(KettleCreateGame data, KettleConnectionArgs e)
        {
            // Any exception that's being caught will trigger a nack response.
            Game sabberGame = null;
            KettleGame kettleGame = null;
            try
            {
                var playerInformation = data.Players;
                var gameInformation = data.Bucket;

                var player1 = playerInformation[0];
                var player2 = playerInformation[1];

                var hero1 = KettleConversion.KettleHeroToCard(player1.HeroID);
                var hero2 = KettleConversion.KettleHeroToCard(player2.HeroID);

                var player1Deck = player1.Cards.Select(Cards.FromId).ToList();
                var player2Deck = player2.Cards.Select(Cards.FromId).ToList();

                var gameType = KettleConversion.KettleGameModeToFormat(gameInformation.Details.Scenario);

                var startMana = gameInformation.Details.Start_mana;
                var startHandSize = gameInformation.Details.Start_hand_size;
                var startEntities = gameInformation.Details.Start_entities;

                // Build game object.
                sabberGame = new Game(new GameConfig()
                {
                    Player1HeroClass = hero1.Class,
                    Player2HeroClass = hero2.Class,
                    DeckPlayer1 = player1Deck,
                    DeckPlayer2 = player2Deck,
                    SkipMulligan = false,
                    GameRule = gameType,
                    // StartPlayer is 1-indexed.
                    StartPlayer = 1
                }, false);

                // Setup correct hero cards.
                sabberGame.Player1.AddHeroAndPower(hero1);
                sabberGame.Player2.AddHeroAndPower(hero2);

                // TODO; Further finetune game object.
                // TODO; Use `SabberStoneKettlePlugin.configurations` for game setup.


                // Build kettle game object.
                var player1ID = player1.AccountID;
                var player2ID = player2.AccountID;

                kettleGame = new KettleGame(sabberGame, player1ID, player2ID);
                // Register game into store.
                string gameID;
                if(!_gameStore.RegisterGame(kettleGame, out gameID))
                {
                    // No more room to hold another game!
                    var nackPayload = KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid_State, Errors.GAMEQUEUE_FULL_MSG, Errors.GAMEQUEUE_FULL.ToString());
                    KettleFramework.QueuePacket(nackPayload, e);
                    return;
                }

                // TODO; open/link accept socket for game connection offhanding.

                // TODO; respond with GameCreated event.                
            }
            catch (Exception)
            {
                var nack = KettlePayloadBuilder.BuildNack(
                        ReasonEnum.Invalid,
                        Errors.MALFORMED_PAYLOAD_MSG,
                        Errors.MALFORMED_PAYLOAD.ToString()
                        );
                KettleFramework.QueuePacket(nack, e);
                return;
            }

            
        }
    }
}
