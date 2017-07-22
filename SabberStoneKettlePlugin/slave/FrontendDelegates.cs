using Kettle.Adapter;
using Kettle.Protocol;
using System.Collections.ObjectModel;

namespace SabberStoneKettlePlugin.slave
{
    internal static class FrontendDelegates
    {
        internal static void OnNack(ObservableCollection<Nack> data, ConnectionArgs e)
        {
            // We are BOSS, we don't accept NACKS!
        }

        internal static void OnChooseEntities(OptionChooseEntities data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnChooseOption(OptionChooseOption data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnConcede(OptionConcede data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnJoinGame(JoinGame data, ConnectionArgs e)
        {
            // TODO
        }

        internal static void OnUserUI(UserUI data, ConnectionArgs e)
        {
            // TODO
        }
    }
}
