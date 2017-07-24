using Kettle.Adapter;
using Kettle.Adapter.Processing;
using Kettle.Protocol;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.master
{
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

        public override Socket Connect(IPEndPoint endpoint)
        {
            return ConnectAsync(endpoint).Result;
        }

        public override Task<Socket> ConnectAsync(IPEndPoint endpoint)
        {
            // TODO; Connect to matchmaker

            throw new NotImplementedException();
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

        /// <summary>
        /// Registers all necessary callbacks onto this processor.
        /// </summary>
        public void Bind()
        {
            OnMatchmakerPing += Respond_MatchmakerPing;
            OnCreateGame += Respond_CreateGame;
        }

        private void Respond_MatchmakerPing(KettleMatchmakerPing data, KettleConnectionArgs e)
        {
            // Do nothing.
        }

        private void Respond_CreateGame(KettleCreateGame data, KettleConnectionArgs e)
        {
            // Instruct slave to spin up new game instance.
            // Fire-and-forget.. event CreatedGame will bubble up towards matchmaker.

            // TODO
            
        }

    }
}
