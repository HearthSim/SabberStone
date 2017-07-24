using Kettle.Adapter;
using Kettle.Framework;
using Kettle.Protocol;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SabberStoneKettlePlugin.master
{
    internal class IPCProcessor
    {
        public IPCProcessor()
        {
        }

        public void Bind()
        {
            var processor = KettleFramework.IPCProcessor;
            processor.OnNack += Respond_Nack;
            processor.Event_OnGameCreated += Respond_Event_GameCreated;
            processor.Event_OnGameFinished += Respond_Event_GameFinished;
            processor.Event_OnGameJoined += Respond_Event_GameJoined;
            processor.OnMasterPing += Respond_MasterPing;
            processor.OnSlavePing += Respond_SlavePing;

        }

        private void Respond_Nack(ObservableCollection<KettleNack> data, KettleConnectionArgs e)
        {
            // We are BOSS, we don't accept NACKS!
        }

        private void Respond_Event_GameCreated(KettleEventGameCreated data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_Event_GameFinished(KettleEventGameFinished data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_Event_GameJoined(KettleEventGameJoined data, KettleConnectionArgs e)
        {
            // TODO
        }

        private void Respond_MasterPing(KettleMasterPing data, KettleConnectionArgs e)
        {
            Debug.Fail("Didn't expect a MASTER ping.. we are master!");
        }

        private void Respond_SlavePing(KettleSlavePing data, KettleConnectionArgs e)
        {
            // TODO
        }
    }
}
