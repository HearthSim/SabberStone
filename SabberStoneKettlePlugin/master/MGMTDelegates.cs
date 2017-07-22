using Kettle.Adapter;
using Kettle.Protocol;
using System.Collections.ObjectModel;

namespace SabberStoneKettlePlugin.master
{
    internal static class MGMTDelegates
    {


        internal static void OnNack(ObservableCollection<Nack> data, ConnectionArgs e)
        {
            // We are BOSS, we don't accept NACKS!
        }

        internal static void Event_OnGameCreated(EventGameCreated data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void Event_OnGameFinished(EventGameFinished data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void Event_OnGameJoined(EventGameJoined data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnMasterPing(MasterPing data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnSlavePing(SlavePing data, ConnectionArgs e)
        {
            // TODO
        }


    }
}
