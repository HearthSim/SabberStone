using Kettle.Adapter;
using Kettle.Adapter.Processing;
using Kettle.Framework;
using Kettle.Protocol;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SabberStoneKettlePlugin.slave
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
        public override event Action<KettleClientAnnounce, KettleConnectionArgs> OnClientAnnounce;
        public override event Action<KettleClientPing, KettleConnectionArgs> OnClientPing;
        public override event Action<KettleMatchmakerAnnounce, KettleConnectionArgs> OnMatchmakerAnounce = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleMatchmakerPing, KettleConnectionArgs> OnMatchmakerPing = delegate { Debug.Fail("Accessing this event is forbidden!"); };
        public override event Action<KettleShutdown, KettleConnectionArgs> OnShutdown;
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

        private GameStore _gameStore;

        public PublicProcessor(GameStore store, string identification, string provider) : base(identification, provider)
        {
            _gameStore = store;
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
                    Purpose = Program.Purpose,
                    // Leave these values out since they are sensitive.
                    Max_instances = -1,
                    Supported = null
                }
            };
        }

        public override Socket Connect(IPEndPoint endpoint, int timeout)
        {
            // We get connected to!
            throw new NotImplementedException();
        }

        public override Task<Socket> ConnectAsync(IPEndPoint endpoint, int timeout)
        {
            // We get connected to!
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
                case PayloadTypeStringEnum.KettleTypes_handshake_shutdown:
                    DelegateCallback(OnShutdown, data, cID);
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
            OnClientAnnounce += Respond_ClientAnnounce;
            OnClientPing += Respond_ClientPing;
            OnShutdown += Respond_Shutdown;
            OnJoinGame += Respond_JoinGame;
            OnChooseEntities += Respond_ChooseEntities;
            OnChooseOption += Respond_ChooseOption;
            OnConcede += Respond_Concede;
            OnUserUI += Respond_UserUI;
        }

        private void Respond_ClientAnnounce(KettleClientAnnounce data, KettleConnectionArgs e)
        {
            // We respond to each client with our own announce if there wasn't already any state bound.
            if (e.UserToken == null)
            {
                e.UserToken = new KettleUserToken();
                KettleFramework.QueuePacket(GetAnnouncePayload(), e);
            }
        }

        private void Respond_ClientPing(KettleClientPing data, KettleConnectionArgs e)
        {
            // Do nothing.
        }

        private void Respond_Shutdown(KettleShutdown data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_JoinGame(KettleJoinGame data, KettleConnectionArgs e)
        {
            if (e.UserToken == null)
            {
                KettleFramework.QueuePacket(
                    KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid_State, Errors.UNEXPECTED_PAYLOAD_MSG, Errors.UNEXPECTED_PAYLOAD.ToString()), e);
                return;
            }

            KettleUserToken token = e.UserToken as KettleUserToken;
            // There is already a game associated to this connection.
            if (token.GameToken != null) return;

            // Check for open game instances.
            var targetGameID = data.GameID;
            var userID = data.AccountID;
            var gamePassword = data.Password;

            var kettleGame = _gameStore.GetGame(targetGameID);
            if (kettleGame == null)
            {
                KettleFramework.QueuePacket(
                    KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, Errors.UNKNOWN_GAME_ID_MSG, Errors.UNKNOWN_GAME_ID.ToString()), e);
                return;
            }

            // Attach to open game instance.
            // If the result is NOT invalid, the player is attached to that game!
            var result = kettleGame.TryJoinGame(userID, gamePassword, e);
            KettlePayload eventGameJoinedPayload;
            switch(result)
            {
                case KettleGame.PLAYER_TYPE.PLAYER:
                    eventGameJoinedPayload = new KettlePayload()
                    {
                        Type = PayloadTypeStringEnum.KettleTypes_events_game_joined,
                        Data = new KettleEventGameJoined()
                        {
                            AccountID = userID,
                            Board = 0, // TODO
                            GameID = targetGameID,
                            Spectating = false,
                            Max_friendly_minions_per_player = 7, // TODO
                            Max_secrets_per_player = 7 // TODO
                        }
                    };
                    break;
                case KettleGame.PLAYER_TYPE.SPECTATOR:
                    eventGameJoinedPayload = new KettlePayload()
                    {
                        Type = PayloadTypeStringEnum.KettleTypes_events_game_joined,
                        Data = new KettleEventGameJoined()
                        {
                            AccountID = userID,
                            Board = 0, // TODO
                            GameID = targetGameID,
                            // DIFFERENT FROM PLAYER
                            Spectating = true,
                            Max_friendly_minions_per_player = 7, // TODO
                            Max_secrets_per_player = 7 // TODO
                        }
                    };
                    break;
                case KettleGame.PLAYER_TYPE.INVALID:
                default:
                    KettleFramework.QueuePacket(
                    KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, Errors.INVALID_CREDENTIALS_MSG, Errors.INVALID_CREDENTIALS.ToString()), e);
                    return;
            }

            // Send the event to the player, as well as master!
            KettleFramework.QueuePacket(eventGameJoinedPayload, e);
            // TODO; send to master

            // Store game token into connection details.
            token.SetGame(kettleGame);
        }

        private void Respond_ChooseEntities(KettleDoChooseEntities data, KettleConnectionArgs e)
        {
            if (e.UserToken == null)
            {
                // TODO
            }
            else
            {
                KettleFramework.QueuePacket(KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, ""), e);
            }
        }

        private void Respond_ChooseOption(KettleDoChooseOption data, KettleConnectionArgs e)
        {
            if (e.UserToken == null)
            {
                // TODO
            }
            else
            {
                KettleFramework.QueuePacket(KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, ""), e);
            }
        }

        private void Respond_Concede(KettleDoConcede data, KettleConnectionArgs e)
        {
            if (e.UserToken == null)
            {
                // TODO
            }
            else
            {
                KettleFramework.QueuePacket(KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, ""), e);
            }
        }

        private void Respond_UserUI(KettleUserUI data, KettleConnectionArgs e)
        {
            if (e.UserToken == null)
            {
                // TODO
            }
            else
            {
                KettleFramework.QueuePacket(KettlePayloadBuilder.BuildNack(ReasonEnum.Invalid, ""), e);
            }
        }
    }
}
