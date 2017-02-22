using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneKettleServer
{
    class KettleTest
    {
        private static void Test()
        {
            CreateGameTest();
            CreateFullEntities();
            TagChangeTest(1, (int)GameTag.STATE, (int)State.RUNNING);
            TagChangeTest(2, (int)GameTag.PLAYSTATE, (int)PlayState.PLAYING);
            TagChangeTest(3, (int)GameTag.PLAYSTATE, (int)PlayState.PLAYING);

            //         Power: BLOCK_START BlockType = TRIGGER Entity = 1 EffectCardId = EffectIndex = -1 Target = 0
            TagChangeTest(2, (int)GameTag.CURRENT_PLAYER, 1);
            TagChangeTest(2, (int)GameTag.FIRST_PLAYER, 1);
            TagChangeTest(1, (int)GameTag.TURN, 1);
            TagChangeTest(1, 467, 3);
            //         Power: SHOW_ENTITY - Updating Entity = 11 CardID = CS2_106
            //         Power: tag = PREMIUM value = 0
            //         Power: tag = DAMAGE value = 0
            //         Power: tag = ATK value = 3
            //         Power: tag = COST value = 2
            //         Power: tag = ZONE value = HAND
            //         Power: tag = CONTROLLER value = 1
            //         Power: tag = ENTITY_ID value = 11
            //         Power: tag = DURABILITY value = 2
            //         Power: tag = SILENCED value = 0
            //         Power: tag = WINDFURY value = 0
            //         Power: tag = TAUNT value = 0
            //         Power: tag = STEALTH value = 0
            //         Power: tag = DIVINE_SHIELD value = 0
            //         Power: tag = CHARGE value = 0
            //         Power: tag = FACTION value = NEUTRAL
            //         Power: tag = CARDTYPE value = WEAPON
            //         Power: tag = RARITY value = FREE
            //         Power: tag = FROZEN value = 0
            //         Power: tag = ZONE_POSITION value = 0
            //         Power: tag = NUM_ATTACKS_THIS_TURN value = 0
            //         Power: tag = FORCED_PLAY value = 0
            //         Power: tag = TO_BE_DESTROYED value = 0
            //         Power: tag = START_WITH_1_HEALTH value = 0
            //         Power: tag = CUSTOM_KEYWORD_EFFECT value = 0
            //         Power: tag = EXTRA_ATTACKS_THIS_TURN value = 0
            //         Power: tag = TAG_LAST_KNOWN_COST_IN_HAND value = 2
            //         Power: tag = 479 value = 3
            TagChangeTest(11, (int)GameTag.ZONE_POSITION, 1);
            TagChangeTest(2, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 1);
            TagChangeTest(2, 467, 2);
            //         Power: SHOW_ENTITY - Updating Entity = 29 CardID = NEW1_011
            //         Power: tag = PREMIUM value = 0
            //         Power: tag = DAMAGE value = 0
            //         Power: tag = HEALTH value = 3
            //         Power: tag = ATK value = 4
            //         Power: tag = COST value = 4
            //         Power: tag = ZONE value = HAND
            //         Power: tag = CONTROLLER value = 1
            //         Power: tag = ENTITY_ID value = 29
            //         Power: tag = SILENCED value = 0
            //         Power: tag = WINDFURY value = 0
            //         Power: tag = TAUNT value = 0
            //         Power: tag = STEALTH value = 0
            //         Power: tag = DIVINE_SHIELD value = 0
            //         Power: tag = CHARGE value = 1
            //         Power: tag = CARDTYPE value = MINION
            //         Power: tag = RARITY value = COMMON
            //         Power: tag = FROZEN value = 0
            //         Power: tag = ZONE_POSITION value = 0
            //         Power: tag = NUM_ATTACKS_THIS_TURN value = 0
            //         Power: tag = FORCED_PLAY value = 0
            //         Power: tag = TO_BE_DESTROYED value = 0
            //         Power: tag = START_WITH_1_HEALTH value = 0
            //         Power: tag = CUSTOM_KEYWORD_EFFECT value = 0
            //         Power: tag = EXTRA_ATTACKS_THIS_TURN value = 0
            //         Power: tag = TAG_LAST_KNOWN_COST_IN_HAND value = 4
            //         Power: tag = 479 value = 4
            TagChangeTest(29, (int)GameTag.ZONE_POSITION, 2);
            TagChangeTest(2, (int)GameTag.NUM_CARDS_DRAWN_THIS_TURN, 2);
            TagChangeTest(2, 467, 1);
            //         Power: SHOW_ENTITY - Updating Entity = 12 CardID = CS2_105
            //         Power: tag = PREMIUM value = 0
            //         Power: tag = DAMAGE value = 0
            //         Power: tag = COST value = 2
            //         Power: tag = ZONE value = HAND
            //         Power: tag = CONTROLLER value = 1
            //         Power: tag = ENTITY_ID value = 12
            //         Power: tag = SILENCED value = 0
            //         Power: tag = WINDFURY value = 0
            //         Power: tag = TAUNT value = 0
            //         Power: tag = STEALTH value = 0
            //         Power: tag = DIVINE_SHIELD value = 0
            //         Power: tag = CHARGE value = 0
            //         Power: tag = FACTION value = NEUTRAL
            //         Power: tag = CARDTYPE value = SPELL
            //         Power: tag = RARITY value = FREE
            //         Power: tag = FROZEN value = 0
            //         Power: tag = ZONE_POSITION value = 0
            //         Power: tag = NUM_ATTACKS_THIS_TURN value = 0
            //         Power: tag = FORCED_PLAY value = 0
            //         Power: tag = TO_BE_DESTROYED value = 0
            //         Power: tag = START_WITH_1_HEALTH value = 0
            //         Power: tag = CUSTOM_KEYWORD_EFFECT value = 0
            //         Power: tag = EXTRA_ATTACKS_THIS_TURN value = 0
            //         Power: tag = TAG_LAST_KNOWN_COST_IN_HAND value = 2
            //         Power: tag = 479 value = 0
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
            //         Power: BLOCK_END
            //    PowerList:  Count = 3
            //         Power: TAG_CHANGE Entity = GameEntity tag = STEP value = BEGIN_MULLIGAN
            //         Power: BLOCK_START BlockType = TRIGGER Entity = GameEntity EffectCardId = EffectIndex = -1 Target = 0
            //         Power: TAG_CHANGE Entity = RoxOnTox tag = MULLIGAN_STATE value = INPUT
            // EntityChoices: id = 1 Player = RoxOnTox TaskList = 4 ChoiceType = MULLIGAN CountMin = 0 CountMax = 3
            // EntityChoices: Source = GameEntity
            // EntityChoices: Entities[0] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 11 zone = DECK zonePos = 0 cardId = player = 1]
            // EntityChoices: Entities[1] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 29 zone = DECK zonePos = 0 cardId = player = 1]
            // EntityChoices: Entities[2] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 12 zone = DECK zonePos = 0 cardId = player = 1]
            //     PowerList: Count = 1
            //         Power: TAG_CHANGE Entity = toshiro tag = MULLIGAN_STATE value = INPUT
            // EntityChoices: id = 2 Player = toshiro TaskList = 5 ChoiceType = MULLIGAN CountMin = 0 CountMax = 5
            // EntityChoices: Source = GameEntity
            // EntityChoices: Entities[0] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 46 zone = DECK zonePos = 0 cardId = player = 2]
            // EntityChoices: Entities[1] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 50 zone = DECK zonePos = 0 cardId = player = 2]
            // EntityChoices: Entities[2] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 34 zone = DECK zonePos = 0 cardId = player = 2]
            // EntityChoices: Entities[3] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 41 zone = DECK zonePos = 0 cardId = player = 2]
            // EntityChoices: Entities[4] =[name = UNKNOWN ENTITY[cardType = INVALID] id = 68 zone = HAND zonePos = 5 cardId = player = 2]
            //EntitiesChosen: id = 2 Player = toshiro EntitiesCount = 0
            //   SendChoices: id = 1 ChoiceType = MULLIGAN
            //   SendChoices: m_chosenEntities[0] =[name = Fiery War Axe id = 11 zone = HAND zonePos = 1 cardId = CS2_106 player = 1]
            //     PowerList: Count = 42
            //         Power: BLOCK_END
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
                      [(int)GameTag.HERO_ENTITY] = 64,
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
                        [(int)GameTag.PLAYER_ID] = 1,
                        [(int)GameTag.HERO_ENTITY] = 66,
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
            return k;
        }

        public static KettleHistoryTagChange TagChangeTest(int entityId, int tag, int value)
        {
            return new KettleHistoryTagChange
            {
                EntityID = entityId,
                Tag = tag,
                Value = value,
            };
        }

        private static List<KettleHistoryFullEntity> CreateFullEntities()
        {
            var list = new List<KettleHistoryFullEntity>();
            for (var i = 0; i < 60; i++)
            {
                list.Add(FullEntityCreate(i + 4, "", new Dictionary<int,int>
                {
                    [(int)GameTag.ZONE] = (int)Zone.DECK,
                    [(int)GameTag.CONTROLLER] = i < 30 ? 1 : 2,
                    [(int)GameTag.ENTITY_ID] = i + 4,

                }));
            }

            list.Add(FullEntityCreate(64, "HERO_01", new Dictionary<int, int>
            {
                [(int)GameTag.HEALTH] = 30,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 64,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.HERO_POWER] = 725,
            }));

            list.Add(FullEntityCreate(65, "CS2_102", new Dictionary<int, int>
            {
                [(int)GameTag.COST] = 2,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 1,
                [(int)GameTag.ENTITY_ID] = 65,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO_POWER,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.CREATOR] = 64,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
            }));

            list.Add(FullEntityCreate(66, "HERO_02", new Dictionary<int, int>
            {
                [(int)GameTag.HEALTH] = 30,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 2,
                [(int)GameTag.ENTITY_ID] = 66,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.HERO_POWER] = 687,
            }));

            list.Add(FullEntityCreate(67, "CS2_049", new Dictionary<int, int>
            {
                [(int)GameTag.COST] = 2,
                [(int)GameTag.ZONE] = (int)Zone.PLAY,
                [(int)GameTag.CONTROLLER] = 2,
                [(int)GameTag.ENTITY_ID] = 67,
                [(int)GameTag.FACTION] = (int)Faction.NEUTRAL,
                [(int)GameTag.CARDTYPE] = (int)CardType.HERO_POWER,
                [(int)GameTag.RARITY] = (int)Rarity.FREE,
                [(int)GameTag.CREATOR] = 66,
                [(int)GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = 2,
            }));

            return list;
        }

        public static KettleHistoryFullEntity FullEntityCreate(int entityId, string cardId, Dictionary<int,int> tags)
        {
            return new KettleHistoryFullEntity
            {
                Name = cardId,
                Entity = new KettleEntity()
                {
                    EntityID = entityId,
                    Tags = tags
                }
            };
        }

    }
}
