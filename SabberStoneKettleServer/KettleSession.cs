using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Kettle;

namespace SabberStoneKettleServer
{
    class KettleSession
    {
        private Socket Client;
        private KettleAdapter Adapter;
        private Game _game;

        public KettleSession(Socket client)
        {
            Client = client;
            Adapter = new KettleAdapter(new NetworkStream(client));
            Adapter.OnCreateGame += OnCreateGame;
            Adapter.OnConcede += OnConcede;
            Adapter.OnChooseEntities += OnChooseEntities;
            Adapter.OnSendOption += OnSendOption;
        }

        public void Enter()
        {
            while (true)
            {
                Console.WriteLine("Handling next packet..");
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
                Console.WriteLine("Done!");
            }
        }

        public void OnConcede(int entityid)
        {
            Console.WriteLine($"player[{entityid}] concedes");
            var concedingPlayer = _game.ControllerById(entityid);
            _game.Process(ConcedeTask.Any(concedingPlayer));
            SendPowerHistory(_game.PowerHistory.Last);
        }

        public void OnSendOption(KettleSendOption sendOption)
        {

        }

        public void OnChooseEntities(List<int> chooseEntities)
        {

        }

        public void OnCreateGame(KettleCreateGame createGame)
        {
            Console.WriteLine("creating game");
            _game = new Game(new GameConfig
                    {
                        StartPlayer = 1,
                        Player1HeroClass = CardClass.PRIEST,
                        Player2HeroClass = CardClass.HUNTER,
                        FillDecks = true
                    });

            _game.StartGame();
            SendPowerHistory(_game.PowerHistory.Last);
        }

        private Dictionary<int, int> GameTagsToKettleTags(Dictionary<GameTag, int> tags)
        {
            var ktags = new Dictionary<int, int>();

            foreach (var tag in ktags)
                ktags.Add((int)tag.Key, tag.Value);

            return ktags;
        }

        private KettleEntity GameEntityToKettleEntity(PowerEntity entity)
        {
            return new KettleEntity
            {
                EntityID = entity.Id,
                Tags = GameTagsToKettleTags(entity.Tags),
            };
        }

        private KettleEntity GameEntityToKettleEntity(PowerHistoryEntity entity)
        {
            return new KettleEntity
            {
                EntityID = entity.Id,
                Tags = GameTagsToKettleTags(entity.Tags),
            };
        }

        private void SendPowerHistory(List<IPowerHistoryEntry> history)
        {
            foreach (var entry in history)
            {
                SendPowerHistoryEntry(entry);
            }
        }

        private void SendPowerHistoryEntry(IPowerHistoryEntry entry)
        {
            switch (entry.PowerType)
            {
                case PowerType.CREATE_GAME:
                    SendPowerHistoryCreateGame((PowerHistoryCreateGame)entry);
                    break;
                case PowerType.FULL_ENTITY:
                    SendPowerHistoryFullEntity((PowerHistoryFullEntity)entry);
                    break;
                case PowerType.SHOW_ENTITY:
                    SendPowerHistoryShowEntity((PowerHistoryShowEntity)entry);
                    break;
                case PowerType.TAG_CHANGE:
                    SendPowerHistoryTagChange((PowerHistoryTagChange)entry);
                    break;
                /*case PowerType.HIDE_ENTITY:
                    SendPowerHistoryChangeEntity((SendPowerHistoryChangeEntity)entry);
                    break;*/
                default:
                    Console.WriteLine("Error, unhandled powertype " + entry.PowerType.ToString());
                    break;
            }
        }

        private void SendPowerHistoryCreateGame(PowerHistoryCreateGame p)
        {
            var k = new KettleHistoryCreateGame
            {
                Game = new KettleEntity
                {
                    EntityID = p.Game.Id,
                    Tags = GameTagsToKettleTags(p.Game.Tags),
                },
                Players = new List<KettlePlayer>(),
            };

            foreach (var player in p.Players)
            {

                k.Players.Add(new KettlePlayer
                {
                    Entity = GameEntityToKettleEntity(player.PowerEntity),
                    PlayerID = player.PlayerId,
                    CardBack = player.CardBack,
                });
            }

            Adapter.SendMessage(k);
        }

        private void SendPowerHistoryFullEntity(PowerHistoryFullEntity p)
        {
            Adapter.SendMessage(new KettleHistoryFullEntity
            {
                Name = p.Entity.Name,
                KettleEntity = GameEntityToKettleEntity(p.Entity),
            });
        }

        private void SendPowerHistoryShowEntity(PowerHistoryShowEntity p)
        {
            Adapter.SendMessage(new KettleHistoryShowEntity
            {
                Name = p.Entity.Name,
                KettleEntity = GameEntityToKettleEntity(p.Entity),
            });
        }

        private void SendPowerHistoryTagChange(PowerHistoryTagChange p)
        {
            Adapter.SendMessage(new KettleHistoryTagChange
            {
                EntityID = p.EntityId,
                Tag = (int)p.Tag,
                Value = p.Value,
            });
        }

    }
}
