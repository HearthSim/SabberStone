using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks.SimpleTasks;
using Newtonsoft.Json.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;

namespace SabberStoneKettleServer
{
    class KettleTest
    {
        private static List<JObject> _history = new List<JObject>();
        private static KettleAdapter _adapter;

        public static void Test(KettleAdapter adapter)
        {
            // test data source: https://github.com/HearthSim/SabberStone/blob/master/hslogs/GameStates.txt
            _adapter = adapter;


            Console.WriteLine("creating game");
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARRIOR,
                Player2HeroClass = CardClass.SHAMAN,
                SkipMulligan = false,
                FillDecks = true
            });
            // Start the game and send the following powerhistory to the client
            game.StartGame();

            var powerHistory = game.PowerHistory.Last;
            var createGame = powerHistory[0];
            powerHistory.Remove(powerHistory[0]);
            Console.WriteLine(createGame);
            CreateGameSabber(createGame as PowerHistoryCreateGame);
            
            ///CreateGameTest();

            foreach (var fullEntity in powerHistory.Where(p => p is PowerHistoryFullEntity).Select(p => p as PowerHistoryFullEntity))
            {
                Console.WriteLine(fullEntity.Print());
                FullEntityCreate(fullEntity.Entity.Id, 
                    fullEntity.Entity.Name,
                    fullEntity.Entity.Tags.ToDictionary(x => (int) x.Key, x => x.Value)
                );
            }

            //CreateFullEntitiesB();
            //CreateFullEntitiesA();

            EmitHistory();

            /*TagChangeTest(1, (int)GameTag.STATE, (int)State.RUNNING);
            TagChangeTest(2, (int)GameTag.PLAYSTATE, (int)PlayState.PLAYING);
            TagChangeTest(3, (int)GameTag.PLAYSTATE, (int)PlayState.PLAYING);

            BlockStartTest("", -1, 1, 0, (int) BlockType.TRIGGER);

            TagChangeTest(2, (int)GameTag.CURRENT_PLAYER, 1);
            TagChangeTest(2, (int)GameTag.FIRST_PLAYER, 1);
            TagChangeTest(1, (int)GameTag.TURN, 1);
            TagChangeTest(1, 467, 3);
            ShowEntityTest(11, "CS2_106", new Dictionary<int, int>
            {
                [(int) GameTag.PREMIUM] = 0,
                [(int) GameTag.DAMAGE] = 0,
                [(int) GameTag.ATK] = 3,
                [(int) GameTag.COST] = 2,
                [(int) GameTag.ZONE] = (int)Zone.HAND,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 11,
                [(int)GameTag.DURABILITY] = 2,
                [(int)GameTag.SILENCED] = 0,
                [(int)GameTag.WINDFURY] = 0,
                [(int)GameTag.TAUNT] = 0,
                [(int)GameTag.STEALTH] = 0,
                [(int)GameTag.DIVINE_SHIELD] = 0,
                [(int)GameTag.CHARGE] = 0,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.WEAPON,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.FROZEN] = 0,
                [(int)GameTag.ZONE_POSITION] = 0,
                [(int)GameTag.NUM_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.FORCED_PLAY] = 0,
                [(int)GameTag.TO_BE_DESTROYED] = 0,
                [(int)GameTag.START_WITH_1_HEALTH] = 0,
                [(int)GameTag.CUSTOM_KEYWORD_EFFECT] = 0,
                [(int)GameTag.EXTRA_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
                [479] = 3,
            });

            TagChangeTest(11, (int)GameTag.ZONE_POSITION, 1);
            TagChangeTest(2, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 1);
            TagChangeTest(2, 467, 2);
            ShowEntityTest(29, "NEW1_011", new Dictionary<int, int>
            {
                [(int)GameTag.PREMIUM] = 0,
                [(int)GameTag.DAMAGE] = 0,
                [(int)GameTag.HEALTH] = 3,
                [(int)GameTag.ATK] = 4,
                [(int)GameTag.COST] = 4,
                [(int)GameTag.ZONE] = (int)Zone.HAND,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 29,
                [(int)GameTag.SILENCED] = 0,
                [(int)GameTag.WINDFURY] = 0,
                [(int)GameTag.TAUNT] = 0,
                [(int)GameTag.STEALTH] = 0,
                [(int)GameTag.DIVINE_SHIELD] = 0,
                [(int)GameTag.CHARGE] = 1,
                //[(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.MINION,
                [(int)GameTag.RARITY] = (int)Rarity.COMMON,
                [(int)GameTag.FROZEN] = 0,
                [(int)GameTag.ZONE_POSITION] = 0,
                [(int)GameTag.NUM_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.FORCED_PLAY] = 0,
                [(int)GameTag.TO_BE_DESTROYED] = 0,
                [(int)GameTag.START_WITH_1_HEALTH] = 0,
                [(int)GameTag.CUSTOM_KEYWORD_EFFECT] = 0,
                [(int)GameTag.EXTRA_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 4,
                [479] = 4,
            });

            TagChangeTest(29, (int)GameTag.ZONE_POSITION, 2);
            TagChangeTest(2, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 2);
            TagChangeTest(2, 467, 1);
            ShowEntityTest(12, "CS2_105", new Dictionary<int, int>
            {
                [(int)GameTag.PREMIUM] = 0,
                [(int)GameTag.DAMAGE] = 0,
                //[(int)GameTag.HEALTH] = 3,
                //[(int)GameTag.ATK] = 4,
                [(int)GameTag.COST] = 2,
                [(int)GameTag.ZONE] = (int)Zone.HAND,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 12,
                [(int)GameTag.SILENCED] = 0,
                [(int)GameTag.WINDFURY] = 0,
                [(int)GameTag.TAUNT] = 0,
                [(int)GameTag.STEALTH] = 0,
                [(int)GameTag.DIVINE_SHIELD] = 0,
                [(int)GameTag.CHARGE] = 0,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.SPELL,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.FROZEN] = 0,
                [(int)GameTag.ZONE_POSITION] = 0,
                [(int)GameTag.NUM_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.FORCED_PLAY] = 0,
                [(int)GameTag.TO_BE_DESTROYED] = 0,
                [(int)GameTag.START_WITH_1_HEALTH] = 0,
                [(int)GameTag.CUSTOM_KEYWORD_EFFECT] = 0,
                [(int)GameTag.EXTRA_ATTACKS_THIS_TURN] = 0,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
                [479] = 0,
            });

            TagChangeTest(12, (int)GameTag.ZONE_POSITION, 3);
            TagChangeTest(2, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 3);
            TagChangeTest(2, 467, 0);

            TagChangeTest(2, (int)GameTag.NUM_TURNS_LEFT, 1);

            TagChangeTest(3, 467, 4);

            TagChangeTest(46, (int)GameTag.ZONE, (int)Zone.HAND);
            TagChangeTest(46, (int)GameTag.ZONE_POSITION, 1);
            TagChangeTest(3, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 1);
            TagChangeTest(3, 467, 3);

            TagChangeTest(50, (int)GameTag.ZONE, (int)Zone.HAND);
            TagChangeTest(50, (int)GameTag.ZONE_POSITION, 2);
            TagChangeTest(3, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 2);
            TagChangeTest(3, 467, 2);

            TagChangeTest(34, (int)GameTag.ZONE, (int)Zone.HAND);
            TagChangeTest(34, (int)GameTag.ZONE_POSITION, 3);
            TagChangeTest(3, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 3);
            TagChangeTest(3, 467, 1);

            TagChangeTest(41, (int)GameTag.ZONE, (int)Zone.HAND);
            TagChangeTest(41, (int)GameTag.ZONE_POSITION, 4);
            TagChangeTest(3, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 4);
            TagChangeTest(3, 467, 0);

            TagChangeTest(3, (int)GameTag.NUM_TURNS_LEFT, 1);
            FullEntityCreate(68, "", new Dictionary<int, int>
            {
                [(int)GameTag.ZONE] = (int)Zone.HAND,
                [(int)GameTag.CONTROLLER] = 2,
                [(int)GameTag.ENTITY_ID] = 68,
                [(int)GameTag.ZONE_POSITION] = 5,
            });

            TagChangeTest(2, (int)GameTag.TIMEOUT, 75);
            TagChangeTest(3, (int)GameTag.TIMEOUT, 75);
            TagChangeTest(1, 10, 85);
            TagChangeTest(3, (int)GameTag.NEXT_STEP, (int)Step.BEGIN_MULLIGAN);

            BlockEndTest();

            EmitHistory();
            TagChangeTest(1, (int)GameTag.STEP, (int)Step.BEGIN_MULLIGAN);

            BlockStartTest("", -1, 1, 0, (int)BlockType.TRIGGER);
            TagChangeTest(2, (int)GameTag.MULLIGAN_STATE, (int)Mulligan.INPUT);
            EmitHistory();

            EntityChoicesTest((int) ChoiceType.MULLIGAN, 3, 0, 1, new List<int> {11, 29, 12}, 2, 1);

            TagChangeTest(3, (int)GameTag.MULLIGAN_STATE, (int)Mulligan.INPUT);
            EmitHistory();

            EntityChoicesTest((int)ChoiceType.MULLIGAN, 5, 0, 1, new List<int> { 46,50,34,41,68 }, 3, 2);

            //EntitiesChosen: id = 2 Player = toshiro EntitiesCount = 0
            //   SendChoices: id = 1 ChoiceType = MULLIGAN
            //   SendChoices: m_chosenEntities[0] =[name = Fiery War Axe id = 11 zone = HAND zonePos = 1 cardId = CS2_106 player = 1]
            //     PowerList: Count = 42
            BlockEndTest();*/


        }

        public static KettleHistoryCreateGame CreateGameSabber(PowerHistoryCreateGame createGame)
        {
            var k = new KettleHistoryCreateGame
            {
                Game = new KettleEntity
                {
                    EntityID = createGame.Game.Id,
                    Tags = createGame.Game.Tags.ToDictionary(x => (int)x.Key, x => x.Value) 
                },
                Players = new List<KettlePlayer>(),
            };

            k.Players.Add(new KettlePlayer
            {
                Entity = new KettleEntity()
                {
                    EntityID = createGame.Players[0].PowerEntity.Id,
                    Tags = createGame.Players[0].PowerEntity.Tags.ToDictionary(x => (int)x.Key, x => x.Value)
                },
                PlayerID = createGame.Players[0].PlayerId,
                CardBack = createGame.Players[0].CardBack
            });


            k.Players.Add(new KettlePlayer
            {
                Entity = new KettleEntity()
                {
                    EntityID = createGame.Players[1].PowerEntity.Id,
                    Tags = createGame.Players[1].PowerEntity.Tags.ToDictionary(x => (int)x.Key, x => x.Value)
                },
                PlayerID = createGame.Players[1].PlayerId,
                CardBack = createGame.Players[1].CardBack
            });

            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleHistoryCreateGame CreateGameTest()
        {
            var k = new KettleHistoryCreateGame
            {
                Game = new KettleEntity
                {
                    EntityID = 1,
                    Tags = new Dictionary<int, int>
                    {
                        [(int)GameTag.ENTITY_ID] = 1,
                        [(int)GameTag.ZONE] = (int)Zone.PLAY,
                        [(int)GameTag.CARDTYPE] = (int)CardType.GAME,
                    }
                },
                Players = new List<KettlePlayer>(),
            };

            k.Players.Add(new KettlePlayer
            {
                Entity = new KettleEntity()
                {
                  EntityID  = 2,
                  Tags = new Dictionary<int, int>
                  {
                      [(int)GameTag.ENTITY_ID] = 2,
                      [(int)GameTag.PLAYER_ID] = 1,
                      [(int)GameTag.HERO_ENTITY] = 4,
                      [(int)GameTag.MAXHANDSIZE] = 10,
                      [(int)GameTag.STARTHANDSIZE] = 4,
                      [(int)GameTag.TEAM_ID] = 1,
                      [(int)GameTag.ZONE] = (int)Zone.PLAY,
                      [(int)GameTag.CONTROLLER] = 1,
                      [(int)GameTag.MAXRESOURCES] = 10,
                      [(int)GameTag.CARDTYPE] = (int)CardType.PLAYER,
                  }
                },
                PlayerID = 1,
                CardBack = 0
            });


            k.Players.Add(new KettlePlayer
            {
                Entity = new KettleEntity()
                {
                    EntityID = 3,
                    Tags = new Dictionary<int, int>
                    {
                        [(int)GameTag.ENTITY_ID] = 3,
                        [(int)GameTag.PLAYER_ID] = 2,
                        [(int)GameTag.HERO_ENTITY] = 6,
                        [(int)GameTag.MAXHANDSIZE] = 10,
                        [(int)GameTag.STARTHANDSIZE] = 4,
                        [(int)GameTag.TEAM_ID] = 2,
                        [(int)GameTag.ZONE] = (int)Zone.PLAY,
                        [(int)GameTag.CONTROLLER] = 2,
                        [(int)GameTag.MAXRESOURCES] = 10,
                        [(int)GameTag.CARDTYPE] = (int)CardType.PLAYER,
                    }
                },
                PlayerID = 1,
                CardBack = 0
            });

            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleHistoryTagChange TagChangeTest(int entityId, int tag, int value)
        {
            var k = new KettleHistoryTagChange
            {
                EntityID = entityId,
                Tag = tag,
                Value = value,
            };

            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        private static void CreateFullEntitiesA()
        {
            var list = new List<KettleHistoryFullEntity>();
            for (var i = 0; i < 60; i++)
            {
                list.Add(FullEntityCreate(i + 8, "", new Dictionary<int, int>
                {
                    [(int)GameTag.ZONE] = (int)Zone.DECK,
                    [(int)GameTag.CONTROLLER] = i < 30 ? 1 : 2,
                    [(int)GameTag.ENTITY_ID] = i + 8,
                }));
            }
        }

        private static void CreateFullEntitiesB()
        {
            var list = new List<KettleHistoryFullEntity>();
            list.Add(FullEntityCreate(4, "HERO_01", new Dictionary<int, int>
            {
                [(int)GameTag.HEALTH] = 30,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 4,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.HERO_POWER] = 725,
            }));

            list.Add(FullEntityCreate(5, "CS2_102", new Dictionary<int, int>
            {
                [(int)GameTag.COST] = 2,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 5,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO_POWER,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.CREATOR] = 4,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
            }));

            list.Add(FullEntityCreate(6, "HERO_02", new Dictionary<int, int>
            {
                [(int)GameTag.HEALTH] = 30,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 2,
                [(int)GameTag.ENTITY_ID] = 6,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.HERO_POWER] = 687,
            }));

            list.Add(FullEntityCreate(7, "CS2_049", new Dictionary<int, int>
            {
                [(int)GameTag.COST] = 2,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 2,
                [(int)GameTag.ENTITY_ID] = 7,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO_POWER,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.CREATOR] = 6,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
            }));
        }

        public static KettleHistoryBlockBegin BlockStartTest(string effectCardId, int index, int source, int target, int blockType)
        {
            var k = new KettleHistoryBlockBegin
            {
                EffectCardId = effectCardId,
                Index = index,
                Source = source,
                Target = target,
                Type = blockType,
            };

            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleHistoryBlockEnd BlockEndTest()
        {
            var k = new KettleHistoryBlockEnd();
            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleEntityChoices EntityChoicesTest(int choiceType, int countMax, int countMin, int source, List<int> entities, int playerId, int index)
        {
            var k = new KettleEntityChoices
            {
                ChoiceType = choiceType,
                CountMax = countMax,
                CountMin = countMin,
                Source = source,
                Entities = entities,
                PlayerID = playerId,
                ID = index,
            };
            _adapter.SendMessage(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleHistoryShowEntity ShowEntityTest(int entityId, string cardId, Dictionary<int, int> tags)
        {
            var k = new KettleHistoryShowEntity
            {
                Name = cardId,
                Entity = new KettleEntity()
                {
                    EntityID = entityId,
                    Tags = tags
                }
            };
            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static KettleHistoryFullEntity FullEntityCreate(int entityId, string cardId, Dictionary<int,int> tags)
        {
            var k = new KettleHistoryFullEntity
            {
                Name = cardId,
                Entity = new KettleEntity()
                {
                    EntityID = entityId,
                    Tags = tags
                }
            };
            _history.Add(_adapter.CreatePayload(k));
            return k;
        }

        public static void EmitHistory()
        {
            _adapter.SendMessage(_history);
            _history.Clear();
        }

    }
}
