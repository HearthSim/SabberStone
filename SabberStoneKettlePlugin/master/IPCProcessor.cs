using Kettle.Adapter;
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
