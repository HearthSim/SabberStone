using SabberStoneCore.Model;
using SabberStoneKettle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Kettle;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneKettleServer
{
    class KettleAISession
    {
        private KettleStartClient StartClient;
        private KettleAdapter Adapter;
        private int PlayerId;
        private KettleSession Session;

        private static readonly Random Rand = new Random();

        public KettleAISession(KettleSession session, KettleStartClient startClient)
        {
            this.StartClient = startClient;
            this.Session = session;
        }

        public void Enter()
        {
            // first we connect to the gameserver
            var socket = new Socket(SocketType.Stream, ProtocolType.IP);
            socket.Connect(StartClient.IP, StartClient.Port);
            Adapter = new KettleAdapter(new NetworkStream(socket));
            Adapter.OnGameJoined += OnGameJoined;
            Adapter.OnEntityChoices += OnEntityChoices;
            Adapter.OnEntitiesChosen += OnEntitiesChosen;
            Adapter.OnOptionsBlock += OnOptionsBlock;
            Adapter.OnUserUI += OnUserUI;
            Adapter.OnHistory += OnHistory;

            Adapter.SendMessage(StartClient.JoinGame);

            // and then we keep listening on the socket
            while (true)
            {
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
            }
        }

        public PlayerTask DoAI(List<PlayerTask> tasks)
        {
            return tasks[Rand.Next(0, tasks.Count)];
        }

        public void OnGameJoined(KettleGameJoined gameJoined)
        {
            Console.WriteLine("AI OnGameJoined called.");
        }

        public void OnEntityChoices(KettleEntityChoices entityChoices)
        {
            Console.WriteLine("AI EntityChoices called.");
            if (entityChoices.PlayerId != PlayerId)
                return;

            // convert that option
            var options = Session.Game.CurrentPlayer.Options();

            // Do AI shit
            var option = DoAI(options);

            // Convert it to a kettle choices
            KettleChooseEntities chooseEntities = new KettleChooseEntities();
            chooseEntities.Id = entityChoices.Id;
            chooseEntities.Choices = ((ChooseTask)option).Choices;

            Adapter.SendMessage(chooseEntities);
        }

        public void OnEntitiesChosen(KettleEntitiesChosen entitiesChosen)
        {
            Console.WriteLine("AI OnEntitiesChosen called.");
        }

        public void OnOptionsBlock(KettleOptionsBlock optionsBlock)
        {
            // convert that option 
            Console.WriteLine("AI OnOptionsBlock called.");
            if (optionsBlock.PlayerId != PlayerId)
                return;

            var options = Session.Game.CurrentPlayer.Options();

            // Do AI shit
            var option = DoAI(options);

            // Convert it to poweroptions
            var poweroptions = PowerOptionsBuilder.AllOptions(Session.Game, new List<PlayerTask> { option });

            // And create a kettle block for it
            var chosenoption = new KettleOptionsBlock(poweroptions, Session.Game.CurrentPlayer.PlayerId).Options[0];

            int mainOptionIndex = 0;
            int subOptionIndex = 0;
            int target = 0;
            int position = 0;

            // Then we try and find the kettle option that matches
            foreach (KettleOption koption in optionsBlock.Options)
            {
                if (koption.Type != chosenoption.Type)
                    continue;

                if (!OptionsMatch(chosenoption.MainOption, koption.MainOption))
                    continue;

                if ((chosenoption.SubOptions == null || chosenoption.SubOptions.Count == 0) != (koption.SubOptions == null || koption.SubOptions.Count == 0))
                    continue;

                if (chosenoption.SubOptions != null)
                {
                    foreach(KettleSubOption suboption in chosenoption.SubOptions)
                    {
                        if (OptionsMatch(chosenoption.SubOptions[0], suboption))
                        {
                            subOptionIndex = koption.SubOptions.IndexOf(suboption);
                            break;
                        }
                    }
                }

                mainOptionIndex = optionsBlock.Options.IndexOf(koption);

                if (chosenoption.MainOption != null && chosenoption.MainOption.Targets != null)
                    target = chosenoption.MainOption.Targets[0];
                break;
            }

            if (option is PlayCardTask)
            {
                position = ((PlayerTask)option).ZonePosition;
            }

            KettleSendOption sendoption = new KettleSendOption();
            sendoption.Id = optionsBlock.Id;
            sendoption.MainOption = mainOptionIndex;
            sendoption.SubOption = subOptionIndex;
            sendoption.Target = target;
            sendoption.Position = position;

            Adapter.SendMessage(sendoption);
        }

        public void OnUserUI(KettleUserUI userUi)
        {
            Console.WriteLine("AI OnUserUI called.");
        }

        public void OnHistory(List<KettleHistoryEntry> history)
        {
            Console.WriteLine("AI OnHistory called.");
            if (history[0] is KettleHistoryCreateGame)
            {
                KettleHistoryCreateGame kcreate = (KettleHistoryCreateGame)history[0];
                var player = kcreate.Players.Where(p => p.AccountId == StartClient.JoinGame.AccountId).First();
                PlayerId = player.Entity.EntityId - 1;
            }
        }

        public bool OptionsMatch(KettleSubOption option1, KettleSubOption option2)
        {
            if ((option1 == null) != (option2 == null))
                return false;

            if (option1 != null)
            {
                if (option1.Id != option2.Id)
                    return false;

                if ((option1.Targets == null || option1.Targets.Count == 0) != (option2.Targets == null || option2.Targets.Count == 0))
                    return false;

                if (option1.Targets != null)
                {
                    foreach(int target in option1.Targets)
                    {
                        if (!option2.Targets.Contains(target))
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
