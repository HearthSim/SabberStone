using Kettle.Adapter;
using Kettle.Adapter.Processing;
using Kettle.Protocol;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.slave
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
        public override event Action<KettleClientAnnounce, KettleConnectionArgs> OnClientAnnounce;
        public override event Action<KettleClientPing, KettleConnectionArgs> OnClientPing;
        public override event Action<KettleMatchmakerAnnounce, KettleConnectionArgs> OnMatchmakerAnounce = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleMatchmakerPing, KettleConnectionArgs> OnMatchmakerPing = delegate { Debug.Fail("Accessing this event is forbidden!"); };
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
        public override event Action<KettleCreateGame, KettleConnectionArgs> OnCreateGame = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleJoinGame, KettleConnectionArgs> OnJoinGame;
        public override event Action<KettleQueueCancel, KettleConnectionArgs> OnQueueCancel = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueuePlayer, KettleConnectionArgs> OnQueuePlayer = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueueStatus, KettleConnectionArgs> OnQueueStatus = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleQueueTransition, KettleConnectionArgs> OnQueueTransition = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleDoChooseEntities, KettleConnectionArgs> OnChooseEntities;
        public override event Action<KettleDoChooseOption, KettleConnectionArgs> OnChooseOption;
        public override event Action<KettleDoConcede, KettleConnectionArgs> OnConcede;
        public override event Action<KettleOptionEndTurn, KettleConnectionArgs> OnEndTurn = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionEntityChoices, KettleConnectionArgs> OnEntityChoices = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionStart, KettleConnectionArgs> OnOptionsStart = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionStop, KettleConnectionArgs> OnOptionsStop = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleOptionPower, KettleConnectionArgs> OnPower = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleUserUI, KettleConnectionArgs> OnUserUI;

        public PublicProcessor(string identification, string provider) : base(identification, provider)
        {
        }

        public override Socket Connect(IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        public override Task<Socket> ConnectAsync(IPEndPoint endpoint)
        {
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
                case PayloadTypeStringEnum.KettleTypes_handshake_client_announce:
                    DelegateCallback(OnClientAnnounce, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_handshake_client_ping:
                    DelegateCallback(OnClientPing, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_lobby_join_game:
                    DelegateCallback(OnJoinGame, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_options_choose_entities:
                    DelegateCallback(OnChooseEntities, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_options_choose_option:
                    DelegateCallback(OnChooseOption, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_options_concede:
                    DelegateCallback(OnConcede, data, cID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_user_ui:
                    DelegateCallback(OnUserUI, data, cID);
                    break;
                default:
                    // No error handling; we simple ignore/drop packets we don't expect.
                    Debug.Fail("Unexpected packet received!");
                    break;
            }

            return;
        }

        public void Bind()
        {
            // TODO
        }

        private void Respond_ClientAnnounce(KettleClientAnnounce data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_ClientPing(KettleClientPing data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_JoinGame(KettleJoinGame data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_ChooseEntities(KettleDoChooseEntities data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_ChooseOption(KettleDoChooseOption data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_Concede(KettleDoConcede data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_UserUI(KettleUserUI data, KettleConnectionArgs e)
        {
            // TODO
        }
    }
}
