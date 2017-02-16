using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SabberStoneKettleServer
{
    class KettleSession
    {
        private Socket Client;
        private KettleAdapter Adapter;
        private Game Game;

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

        public void OnConcede(int concede)
        {

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
            Game = new Game(new GameConfig
                    {
                        StartPlayer = 1,
                        Player1HeroClass = CardClass.PRIEST,
                        DeckPlayer1 = new List<Card>()
                        {
                            Cards.FromName("Loot Hoarder"),       // 1
                            Cards.FromName("Loot Hoarder"),       // 2
                            Cards.FromName("Huge Toad"),          // 3
                            Cards.FromName("Mad Bomber"),         // 4
                            Cards.FromName("Stonetusk Boar"),     // 5
                            Cards.FromName("Magma Rager"),        // 6
                            Cards.FromName("War Golem"),          // 7
                            Cards.FromName("Reckless Rocketeer"), // 8
                            Cards.FromName("Wolfrider"),          // 9
                            Cards.FromName("Sen'jin Shieldmasta"),// 10
                            Cards.FromName("Voodoo Doctor"),      // 11
                            Cards.FromName("River Crocolisk"),    // 12
                            Cards.FromName("Oasis Snapjaw"),      // 13
                            Cards.FromName("Novice Engineer"),    // 14
                            Cards.FromName("Core Hound"),         // 15
                            Cards.FromName("Booty Bay Bodyguard"),// 16
                            Cards.FromName("Ogre Magi"),          // 17
                            Cards.FromName("Chillwind Yeti"),     // 18
                            Cards.FromName("Acidic Swamp Ooze"),  // 19
                            Cards.FromName("Ironfur Grizzly"),    // 20
                            Cards.FromName("Bluegill Warrior"),   // 21
                            Cards.FromName("Murloc Tidehunter"),  // 22
                            Cards.FromName("Frostwolf Grunt"),    // 23
                            Cards.FromName("Ironforge Rifleman"), // 24
                            Cards.FromName("Kobold Geomancer"),   // 25
                            Cards.FromName("Razorfen Hunter"),    // 26
                            Cards.FromName("Gnomish Inventor"),   // 27
                            Cards.FromName("Stormwind Knight"),   // 28
                            Cards.FromName("Gurubashi Berserker"),// 29
                            Cards.FromName("Elven Archer"),       // 30
                        },
                        Player2HeroClass = CardClass.HUNTER,
                        DeckPlayer2 = new List<Card>()
                        {
                            Cards.FromName("Loot Hoarder"),       // 1
                            Cards.FromName("Loot Hoarder"),       // 2
                            Cards.FromName("Huge Toad"),          // 3
                            Cards.FromName("Mad Bomber"),         // 4
                            Cards.FromName("Stonetusk Boar"),     // 5
                            Cards.FromName("Magma Rager"),        // 6
                            Cards.FromName("War Golem"),          // 7
                            Cards.FromName("Reckless Rocketeer"), // 8
                            Cards.FromName("Wolfrider"),          // 9
                            Cards.FromName("Sen'jin Shieldmasta"),// 10
                            Cards.FromName("Voodoo Doctor"),      // 11
                            Cards.FromName("River Crocolisk"),    // 12
                            Cards.FromName("Oasis Snapjaw"),      // 13
                            Cards.FromName("Novice Engineer"),    // 14
                            Cards.FromName("Core Hound"),         // 15
                            Cards.FromName("Booty Bay Bodyguard"),// 16
                            Cards.FromName("Ogre Magi"),          // 17
                            Cards.FromName("Chillwind Yeti"),     // 18
                            Cards.FromName("Acidic Swamp Ooze"),  // 19
                            Cards.FromName("Ironfur Grizzly"),    // 20
                            Cards.FromName("Bluegill Warrior"),   // 21
                            Cards.FromName("Murloc Tidehunter"),  // 22
                            Cards.FromName("Frostwolf Grunt"),    // 23
                            Cards.FromName("Ironforge Rifleman"), // 24
                            Cards.FromName("Kobold Geomancer"),   // 25
                            Cards.FromName("Razorfen Hunter"),    // 26
                            Cards.FromName("Gnomish Inventor"),   // 27
                            Cards.FromName("Stormwind Knight"),   // 28
                            Cards.FromName("Gurubashi Berserker"),// 29
                            Cards.FromName("Elven Archer"),       // 30
                        },
                        FillDecks = false,
                        Shuffle = false,
                        Splitting = true
                    });

            // TODO: perhaps add kettlesession callbacks to game whenever something changes, so it can send packets through kettle?
            Game.StartGame();
        }
    }
}
