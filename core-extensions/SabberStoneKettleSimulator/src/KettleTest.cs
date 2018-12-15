#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneKettle;

namespace SabberStoneKettleSimulator
{
	class KettleTest
	{
		private static List<KettlePayload> _history = new List<KettlePayload>();
		private static KettleAdapter _adapter;
		private static Game _game;

		public static void TestStep1(KettleAdapter adapter)
		{
			// test data source: https://github.com/HearthSim/SabberStone/blob/master/hslogs/GameStates.txt
			_adapter = adapter;

			Console.WriteLine("creating game");
			_game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.WARLOCK,
				SkipMulligan = false,
				FillDecks = true
			});



			// Start the game and send the following powerhistory to the client
			_game.StartGame();

			List<IPowerHistoryEntry> powerHistory = _game.PowerHistory.Last;

			foreach (IPowerHistoryEntry h in powerHistory)
				QueuePacket(KettleHistoryEntry.From(h));
			SendQueue();

			PowerEntityChoices entityChoices1 = PowerChoicesBuilder.EntityChoices(_game, _game.Player1.Choice);
			SendPacket(new KettleEntityChoices(entityChoices1));

			PowerEntityChoices entityChoices2 = PowerChoicesBuilder.EntityChoices(_game, _game.Player2.Choice);
			SendPacket(new KettleEntityChoices(entityChoices2));

			KettleAdapter.OnChooseEntitiesDelegate handleMulligan = null;
			handleMulligan = (KettleChooseEntities) =>
			{
				// Handle the response to the mulligan (in a dynamic or hardcoded way)
				// this means sending the proper response/history and perhaps a ChosenEntities 

				// If both players are handled, we can jump to game phase 2
				if (_game.Step == Step.BEGIN_MULLIGAN
					&& _game.Player1.MulliganState == Mulligan.DONE
					&& _game.Player2.MulliganState == Mulligan.DONE)
				{
					_adapter.OnChooseEntities -= handleMulligan;
					_game.NextStep = Step.MAIN_BEGIN;
					TestStep2();
				}
			};
			_adapter.OnChooseEntities += handleMulligan;
		}

		public static void TestStep2()
		{

		}

		private static void QueuePacket(KettlePayload payload)
		{
			_history.Add(payload);
		}

		private static void SendQueue()
		{
			_adapter.SendMessage(_history);
			_history.Clear();
		}

		private static void SendPacket(KettlePayload payload)
		{
			_adapter.SendMessage(payload);
		}

		public static KettleHistoryCreateGame CreateGameTest()
		{
			var k = new KettleHistoryCreateGame
			{
				Game = new KettleEntity
				{
					EntityId = 1,
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
					EntityId = 2,
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
				PlayerId = 1,
				CardBack = 0
			});


			k.Players.Add(new KettlePlayer
			{
				Entity = new KettleEntity()
				{
					EntityId = 3,
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
				PlayerId = 1,
				CardBack = 0
			});

			return k;
		}

		public static KettleHistoryTagChange TagChangeTest(int entityId, int tag, int value)
		{
			var k = new KettleHistoryTagChange
			{
				EntityId = entityId,
				Tag = tag,
				Value = value,
			};

			return k;
		}

		private static List<KettleHistoryFullEntity> CreateFullEntitiesA()
		{
			var list = new List<KettleHistoryFullEntity>();
			for (int i = 0; i < 60; i++)
			{
				list.Add(CreateEntityCreate(i + 8, "", new Dictionary<int, int>
				{
					[(int)GameTag.ZONE] = (int)Zone.DECK,
					[(int)GameTag.CONTROLLER] = i < 30 ? 1 : 2,
					[(int)GameTag.ENTITY_ID] = i + 8,
				}));
			}

			return list;
		}

		private static List<KettleHistoryFullEntity> CreateFullEntitiesB()
		{
			var list = new List<KettleHistoryFullEntity>();
			list.Add(CreateEntityCreate(4, "HERO_01", new Dictionary<int, int>
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

			list.Add(CreateEntityCreate(5, "CS2_102", new Dictionary<int, int>
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

			list.Add(CreateEntityCreate(6, "HERO_02", new Dictionary<int, int>
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

			list.Add(CreateEntityCreate(7, "CS2_049", new Dictionary<int, int>
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

			return list;
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

			return k;
		}

		public static KettleHistoryBlockEnd BlockEndTest()
		{
			var k = new KettleHistoryBlockEnd();
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
				PlayerId = playerId,
				Id = index,
			};

			return k;
		}

		public static KettleHistoryShowEntity ShowEntityTest(int entityId, string cardId, Dictionary<int, int> tags)
		{
			var k = new KettleHistoryShowEntity
			{
				Name = cardId,
				Entity = new KettleEntity()
				{
					EntityId = entityId,
					Tags = tags
				}
			};
			return k;
		}

		public static KettleHistoryFullEntity CreateEntityCreate(int entityId, string cardId, Dictionary<int, int> tags)
		{
			var k = new KettleHistoryFullEntity
			{
				Name = cardId,
				Entity = new KettleEntity()
				{
					EntityId = entityId,
					Tags = tags
				}
			};
			return k;
		}
	}
}
