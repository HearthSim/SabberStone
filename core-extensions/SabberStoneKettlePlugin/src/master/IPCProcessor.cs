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

namespace SabberStoneKettlePlugin.master
{
    /// <summary>
    /// Handles received messages for the IPC connection, Master side.
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

        public IPCProcessor(string identification, string provider) : base(identification, provider)
        {
            Bind();
        }

        private void Bind()
        {
            OnNack += Respond_Nack;
            OnSlavePing += Respond_SlavePing;
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
                case PayloadTypeStringEnum.KettleTypes_events_game_created:
                case PayloadTypeStringEnum.KettleTypes_events_game_finished:
                case PayloadTypeStringEnum.KettleTypes_events_game_joined:
                    // Transfer relevant event packets directly to the matchmaker.
                    KettleFramework.Adapter.QueuePayload(data, MasterCode.MMConnectionID);
                    break;
                case PayloadTypeStringEnum.KettleTypes_handshake_slave_ping:
                    DelegateCallback(OnSlavePing, data, cID);
                    break;
                default:
                    // No error handling; we simple ignore/drop packets we don't expect.
                    Debug.Fail("Unexpected packet received!");
                    break;
            }

            return;
        }

        protected override KettlePayload GetAnnouncePayload()
        {
            return new KettlePayload()
            {
                Type = PayloadTypeStringEnum.KettleTypes_handshake_master_announce,
                Data = new KettleMasterAnnounce()
            };
        }


        public override Socket Connect(IPEndPoint endpoint, int timeout)
        {
            // We don't connect, but get connected to.
            throw new NotImplementedException();
        }

        public override Task<Socket> ConnectAsync(IPEndPoint endpoint, int timeout)
        {
            // We don't connect, but get connected to.
            throw new NotImplementedException();
        }

        private void Respond_Nack(ObservableCollection<KettleNack> data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_SlavePing(KettleSlavePing data, KettleConnectionArgs e)
        {
            // Do nothing.
        }
    }
}
