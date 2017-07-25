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
    /// <summary>
    /// Handles received messages for the IPC connection, Slave side.
    /// </summary>
    /// <seealso cref="Kettle.Adapter.Processing.KettleIPCProcessor" />
    internal class IPCProcessor: KettleIPCProcessor
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
        public override event Action<KettleSlaveAnnounce, KettleConnectionArgs> OnSlaveAnnounce;
        public override event Action<KettleSlavePing, KettleConnectionArgs> OnSlavePing;
        public override event Action<KettleCreateBucket, KettleConnectionArgs> OnCreateBucket;
        public override event Action<KettleCreateGame, KettleConnectionArgs> OnCreateGame;

        public IPCProcessor(string identification, string provider) : base(identification, provider)
        {
        }

        protected override KettlePayload GetAnnouncePayload()
        {
            return new KettlePayload()
            {
                Type = PayloadTypeStringEnum.KettleTypes_handshake_slave_announce,
                Data = new KettleSlaveAnnounce()
            };
        }

        public override Socket Connect(IPEndPoint endpoint)
        {
            return ConnectAsync(endpoint).Result;
        }

        public override async Task<Socket> ConnectAsync(IPEndPoint endpoint)
        {
            Debug.Assert(endpoint != null);

            // DEBUG
            await Task.CompletedTask;

            // TODO
            return null;
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

        private void Handle_CreateGame(KettleCreateGame data, KettleConnectionArgs e)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
