using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;

namespace SabberStoneKettleServer
{
    class KettleTest
    {
        public static KettleHistoryCreateGame CreatePowerHistoryCreateGameTest()
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
                        [(int)GameTag.PLAYER_ID] = 1,
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
            return k;
        }
    }
}
