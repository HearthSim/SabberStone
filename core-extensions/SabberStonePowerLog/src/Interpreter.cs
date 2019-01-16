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
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using SabberStoneCore.Enums;
using SabberStonePowerLog.Model;

namespace SabberStonePowerLog
{
	class Interpreter
	{
		private static Regex logRgx = new Regex(@"([D])[ ]([0-9.:]{16})[ ]([A-Z]+)[.]([A-Z]+)[\(\)]+[ ][-][ ](.+)", RegexOptions.IgnoreCase);
		private static Regex fullEntityRgx = new Regex(@"FULL_ENTITY - Creating ID=([0-9]+)[ ]CardID=([A-Z0-9_]*)", RegexOptions.IgnoreCase);
		private static Regex tagValueRgx = new Regex(@"tag=([A-Z0-9_]+)[ ]value=([A-Z0-9]+)", RegexOptions.IgnoreCase);
		private static Regex idRgx = new Regex(@"(Entity|id)=([0-9]+|[A-Z0-9]+)", RegexOptions.IgnoreCase);
		private static Regex blockStartRgx = new Regex(@"BLOCK_START BlockType=([A-Z]+) Entity=([0-9]+|[A-Z0-9]+|\[.*?\]) EffectCardId=([A-Z0-9_]*) EffectIndex=([-0-9]+) Target=([0-9]+|[A-Z0-9]+|\[.*?\])", RegexOptions.IgnoreCase);
		private static Regex showEntityRgx1 = new Regex(@"([0-9]+) CardId=([A-Z0-9_]+)", RegexOptions.IgnoreCase);
		private static Regex showEntityRgx2 = new Regex(@"([0-9]+|\[name=([A-Za-z ]+) id=([0-9]+) zone=([A-Z]+) zonePos=([0-9]+) cardId= player=([1-2])\] CardId=([A-Z0-9_]+))", RegexOptions.IgnoreCase);
		private static Regex hideEntityRgx = new Regex(@"\[name=([A-Za-z ]+) id=([0-9]+) zone=([A-Z]+) zonePos=([0-9]+) cardId=([A-Za-z0-9_]+) player=([1-2])\] tag=([A-Z0-9_]+)[ ]value=([A-Z0-9]+)", RegexOptions.IgnoreCase);

		private StreamReader file;

		public string filePath;

		public string fileName;

		public Interpreter(string filePath, string fileName)
		{
			this.filePath = filePath;
			this.fileName = fileName;
			this.file = new StreamReader(File.Open(filePath + fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
		}

		public List<PowerGame> Parse(bool createJsonFile, bool createCleanLog)
		{
			List<PowerGame> powerGames = new List<PowerGame>();
			PowerState currentPowerState = PowerState.Start;
			PowerGame currentPowerGame = null;
			PowerType currentPowerType = 0;
			Dictionary<string, int> currentNameToIdDict;
			PowerHistoryEntry currentPowerHistoryEntry = null;
			StringBuilder cleanLog = new StringBuilder();

			string line;
			while ((line = file.ReadLine()) != null)
			{
				Match matchLogRgx = logRgx.Match(line);
				if (matchLogRgx.Success)
				{
					string entryType = matchLogRgx.Groups[1].Value;
					string timestamp = matchLogRgx.Groups[2].Value;
					string classType = matchLogRgx.Groups[3].Value;
					string debugType = matchLogRgx.Groups[4].Value;
					string content = matchLogRgx.Groups[5].Value;

					if (!classType.Equals("GameState") || debugType.Equals("DebugPrintOptions"))
						continue;

					string contentLine = content.Trim();

					cleanLog.AppendLine($"{("[" + debugType.ToString() + "] ").PadLeft(27)}{content}");

					PowerType nextPowerType;
					if (Enum.TryParse<PowerType>(contentLine.Split(' ')[0], out nextPowerType))
					{
						currentPowerType = nextPowerType;
					};

					switch (currentPowerType)
					{
						case PowerType.CREATE_GAME:
							break;
					}
				}
				else
				{
					Console.WriteLine("matchLogRgx: '" + line + "'");
				}
			}

			if (createJsonFile)
			{
				string jsonStr = JsonConvert.SerializeObject(powerGames, Formatting.Indented,
					new JsonSerializerSettings
					{
						TypeNameHandling = TypeNameHandling.All
					});
				File.WriteAllText(filePath + "powerLog.json", jsonStr);
			}

			if (createCleanLog)
			{
				File.WriteAllText(filePath + "cleanLog.log", cleanLog.ToString());
			}

			//while (powerGame.PowerHistory.Count > 0)
			//{
			//    var powerHistoryEntry = powerGame.PowerHistory.Dequeue();
			//    powerHistoryEntry.Process(powerGame);
			//}
			//File.WriteAllText(filePath + "powerLogProc.json", JsonConvert.SerializeObject(powerGame, Formatting.Indented));

			return powerGames;
		}

		private PowerHistoryEntry ProcessShowEntity(PowerGame currentPowerGame, string contentLine)
		{
			string str = contentLine
				.Replace("SHOW_ENTITY - Updating Entity=", "")
				.Replace(" [cardType=INVALID]", "");

			Match match1 = showEntityRgx1.Match(str);
			Match match2 = showEntityRgx2.Match(str);
			if (match1.Success)
			{
				return new PowerShowEntity()
				{
					Id = Int32.Parse(match1.Groups[1].Value),
					CardId = match1.Groups[2].Value
				};
			}

			if (match2.Success)
			{
				return new PowerShowEntity()
				{
					Name = match1.Groups[2].Value,
					Id = Int32.Parse(match1.Groups[3].Value),
					Zone = match1.Groups[4].Value,
					ZonePos = match1.Groups[5].Value,
					PlayerId = match1.Groups[6].Value,
					CardId = match1.Groups[7].Value
				};
			}

			Console.WriteLine("entityRgx unmatched: '" + str + "'");
			return null;
		}

		private PowerHistoryEntry ProcessHideEntity(PowerGame currentPowerGame, string contentLine)
		{
			string str = contentLine
				.Replace("HIDE_ENTITY - Entity=", "");
			Match match1 = hideEntityRgx.Match(str);
			if (!match1.Success)
			{
				Console.WriteLine("hideEntityRgx unmatched: '" + str + "'");
				return null;
			}

			return new PowerHideEntity()
			{
				Name = match1.Groups[1].Value,
				Id = int.Parse(match1.Groups[2].Value),
				Zone = match1.Groups[3].Value,
				ZonePos = match1.Groups[4].Value,
				CardId = match1.Groups[5].Value,
				PlayerId = match1.Groups[6].Value,
				Tag = match1.Groups[7].Value,
				Value = match1.Groups[8].Value
			};
		}

		private PowerBlockStart ProcessBlockStart(PowerGame powerGame, string str)
		{
			Match match1 = blockStartRgx.Match(str);
			if (!match1.Success)
			{
				Console.WriteLine("blockStartRgx unmatched: '" + str + "'");
				return null;
			}

			string blockType = match1.Groups[1].Value;
			string entity = match1.Groups[2].Value;
			string effectCardId = match1.Groups[3].Value;
			string effectIndex = match1.Groups[4].Value;
			string target = match1.Groups[5].Value;

			int entityId = GetIdFromEntity(entity, powerGame);

			int targetId = GetIdFromEntity(target, powerGame);

			return new PowerBlockStart()
			{
				BlockType = blockType,
			};
		}

		private PowerBlockEnd ProcessBlockEnd(PowerGame powerGame, string str)
		{
			return new PowerBlockEnd();
		}

		private int GetIdFromEntity(string str, PowerGame powerGame)
		{
			int result;
			if (!int.TryParse(str, out result))
			{
				Match match = idRgx.Match(str);
				if (match.Success)
				{
					result = int.Parse(match.Groups[2].Value);
				}
				else
				{
					result = powerGame.GetIdByName(str);
				}
			}
			return result;
		}

		private PowerFullEntity ProcessFullEntity(PowerGame powerGame, string str)
		{
			Match match = fullEntityRgx.Match(str);
			if (!match.Success)
			{
				Console.WriteLine("fullEntityRgx unmatched: '" + str + "'");
				return null;
			}
			int id = int.Parse(match.Groups[1].Value);
			string cardId = match.Groups[2].Value;

			return new PowerFullEntity()
			{
				Id = id,
				CardId = cardId
			};
		}

		private PowerTagChange ProcessTagChange(PowerGame powerGame, string str)
		{
			Match match1 = tagValueRgx.Match(str);
			Match match2 = idRgx.Match(str);
			if (!match1.Success || !match2.Success)
			{
				Console.WriteLine("tagValueRgx or idRgx unmatched: '" + str + "'");
				return null;
			}

			string tag = match1.Groups[1].Value;
			string value = match1.Groups[2].Value;
			string entity = match2.Groups[2].Value;
			int id;
			if (!int.TryParse(entity, out id))
			{
				if (powerGame.Game.Name == null)
				{
					id = 1;
					powerGame.Game.Name = entity;
					Console.WriteLine("Game " + entity);
				}
				else if (powerGame.Player1.Name == null)
				{
					id = 2;
					powerGame.Player1.Name = entity;
					Console.WriteLine("Player1: " + entity);
				}
				else if (powerGame.Player2.Name == null)
				{
					id = 3;
					powerGame.Player2.Name = entity;
					Console.WriteLine("Player2: " + entity);
				}
				else
				{
					id = powerGame.GetIdByName(entity);
				}

			}

			return new PowerTagChange()
			{
				Id = id,
				Tag = tag,
				Value = value
			};
		}

		public static object Load(string path)
		{
			return JsonConvert.DeserializeObject(File.ReadAllText(path),
					new JsonSerializerSettings
					{
						TypeNameHandling = TypeNameHandling.All
					});
		}
	}
}
